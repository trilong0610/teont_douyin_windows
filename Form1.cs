using DouyinDownloader.Common;
using DouyinDownloader.Model;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DouyinDownloader
{
    public partial class Form1 : Form
    {
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_url.Text))
            {
                MessageBox.Show("Vui lòng nhập URL");
            }
            else {
                Task.Run(() => {
                    downloadVideo(txt_url.Text);
                });
                
            }
            
            
        }

        private void downloadVideo(string url) {

            // loc id url
            //https://v.douyin.com/jvWJJ2W/
            var mobileUrl = Regex.Match(url, @"http[s]?://(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+").Value;

            if (String.IsNullOrEmpty(mobileUrl))
            {
                MessageBox.Show("Vui lòng nhập URL");
                return;
            }
            else
            {
                if (!mobileUrl.Contains("https://v.douyin.com"))
                {
                    MessageBox.Show("- Nhập URL video Douyin dạng: https://v.douyin.com/***\n- Lấy URL tại nút chia sẻ trong video");
                    return;
                }
            }

            // Tao thu muc download
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Download"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Download"); 
            }

            CommonDouyin.writeLog(lbl_status,"Đang tìm url");
            RestRequest restRequest = new RestRequest("", Method.Get);
            // Lay url pc
            var restClient = new RestClient(new Uri(mobileUrl));

            //restClient.AddDefaultHeader("Authorization", string.Format("Bearer {0}", api));
            restClient.AddDefaultHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
            var restResponse = restClient.Execute(restRequest);
            RestClient client;
            string urlPc = restResponse.ResponseUri.ToString();
            if (urlPc.Contains("user"))
            {
                MessageBox.Show("Đây là link user, không phải link video");
                CommonDouyin.writeLog(lbl_status, "");
                return;
            }
            //var jsonRes = JObject.Parse(restResponse.Content);
            // Lay id video
            CommonDouyin.writeLog(lbl_status,"Đang tìm id video");
            var id = Regex.Match(urlPc, @"\d+").Value;

            // Lay link tai video
            CommonDouyin.writeLog(lbl_status,"Đang lấy link tải video");
            restClient = new RestClient(new Uri(@"https://www.iesdouyin.com/web/api/v2/aweme/iteminfo/?item_ids=" + id));
            restResponse = restClient.Execute(restRequest);
            var jsonRes = JObject.Parse(restResponse.Content);
            string urlDownload;
            string duration;
            if (jsonRes.ContainsKey("item_list"))
            {
                urlDownload = jsonRes["item_list"][0]["video"]["play_addr"]["url_list"][0].ToString().
                    Replace("playwm", "play").Replace("720p", "1080p");
                duration = jsonRes["item_list"][0]["video"]["duration"].ToString();
                if (!String.IsNullOrEmpty(urlDownload))
                {
                    CommonDouyin.writeLog(lbl_status, "Đang tải video " + id);
                    client = new RestClient(urlDownload);
                    
                    byte[] response = client.DownloadData(restRequest);
                    
                    var filename = String.Format("{0}_{1}.mp4", id, DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
                    
                    File.WriteAllBytes(@".\Download\" + filename, response);
                    CommonDouyin.writeLog(lbl_status,"Đã tải xong");
                    if (chk_notification.Checked)
                    {
                        MessageBox.Show("Đã tải xong","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return; 

                }
                else
                {
                    // Thong bao that bai
                    CommonDouyin.writeLog(lbl_status,"Không tìm thấy link video");
                    return;
                }
            }
            else
            {
            // Thong bao that bai
                CommonDouyin.writeLog(lbl_status,"Không tìm thấy link video");
                return;
            }
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.facebook.com/teooo.nt");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText("0374234303");
            MessageBox.Show("Đã coppy số Momo");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText("669061099");
            MessageBox.Show("Đã coppy số Tài khoản VPBank");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory() + @"\Download");
        }

        private void btn_user_download_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                try
                {
                    // Kiem tra co phai url khong
                    var mobileUrl = Regex.Match(txt_url_user.Text.Trim(), @"http[s]?://(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+").Value;
                    if (String.IsNullOrEmpty(mobileUrl))
                    {
                        MessageBox.Show("Vui lòng nhập URL");
                        return;
                    }
                    else
                    {
                        //https://www.douyin.com/user/MS4wLjABAAAA3SUB6MY0OwkSIJoth56WOk2VIDO4y7EfcodiY9HMfnQ
                        // Kiem tra co phai url user douyin ko
                        if (!mobileUrl.Contains("https://www.douyin.com/user/"))
                        {
                            MessageBox.Show("Nhập URL User Douyin dạng: https://www.douyin.com/user/***");
                            return;
                        }
                    }

                    // Lay uid
                    //https://www.douyin.com/user/MS4wLjABAAAA3SUB6MY0OwkSIJoth56WOk2VIDO4y7EfcodiY9HMfnQ
                    //var splitUrl = mobileUrl.Split('/');
                    var uid = Regex.Match(mobileUrl, @"[^\/]*$").Value;

                    if (uid.Contains(@"?"))
                    {
                        uid = uid.Split('?')[0];
                    }

                    // Lay danh sach video
                    var listVideo = CommonDouyin.getPostUser(uid, lbl_user_status);

                // Gan danh sach video len gridview
                if (listVideo != null)
                {
                        
                        reloadGridview(grid_user, listVideo);
                        CommonDouyin.writeLog(lbl_user_status, "Đã tải thông tin!");
                        chk_mark_all.Invoke(new Action(() =>
                        {
                            chk_mark_all.Enabled = true;
                        }));
                        btn_mark.Invoke(new Action(() =>
                        {
                            btn_mark.Enabled = true;
                        }));
                        txt_mark_from.Invoke(new Action(() =>
                        {
                            txt_mark_from.Text = "1";
                        }));
                        txt_mark_to.Invoke(new Action(() =>
                        {
                            txt_mark_to.Text = listVideo.Count.ToString();
                        }));
                    }
                    else
                    {
                        MessageBox.Show("Lấy thông tin video thất bại");
                    }
                }
                catch (OperationCanceledException)
                {

                    CommonDouyin.writeLog(lbl_user_status, "Đã dừng lấy thông tin");
                }
                

                // lay danh sach video

                // tai xuong tung video
            });
            
        }

        private void grid_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reloadGridview(DataGridView dataGridView, List<ModelVideo> modelVideos) {
            //dataGridView.Rows.Clear();
            //dataGridView.Columns.Clear();
            dataGridView.Invoke(new Action(() =>
            {
                DataTable table = new DataTable();
                table.Columns.Add("STT", typeof(int));
                table.Columns.Add(" ", typeof(bool));
                table.Columns.Add("ID", typeof(string));
                table.Columns.Add("Tiêu đề", typeof(string));
                table.Columns.Add("Tim", typeof(int));
                table.Columns.Add("Tác giả", typeof(string));
                table.Columns.Add("Thời lượng", typeof(double));

                for (int i = 0; i < modelVideos.Count; i++)
                { 
                    table.Rows.Add(
                        i + 1,
                        chk_mark_all.Checked,
                        modelVideos[i].id,
                        modelVideos[i].desc,
                        modelVideos[i].like,
                        modelVideos[i].author,
                        modelVideos[i].duration / 1000
                        );
                }

                dataGridView.DataSource = table;

                dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dataGridView.Columns[0].ReadOnly = true;
                dataGridView.Columns[1].ReadOnly = false;
                dataGridView.Columns[2].ReadOnly = true;
                dataGridView.Columns[3].ReadOnly = false;
                dataGridView.Columns[4].ReadOnly = true;
                dataGridView.Columns[5].ReadOnly = true;
                dataGridView.Columns[6].ReadOnly = true;
            }));
            
        }

        private List<ModelVideo> getVideoSelected(DataGridView dataGridView) {
            List<ModelVideo> ids = new List<ModelVideo>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                {
                    var id = row.Cells[2].Value.ToString().Trim();
                    var desc = row.Cells[3].Value.ToString().Trim();
                    var like = Convert.ToInt32(row.Cells[4].Value.ToString().Trim());
                    var author = row.Cells[5].Value.ToString().Trim();
                    var duration = Convert.ToDouble(row.Cells[6].Value.ToString().Trim());
                    ids.Add(new ModelVideo(id,desc,author,null,duration,like));
                }
            }
            return ids;
        }

        private void btn_user_download_post_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
            if (getVideoSelected(grid_user).Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn video");
                return;
            }
            Task.Run(() =>
            {
                try
                {
                    List<string> urlDownloads = new List<string>();
                    int countVideoDownloaded = 1;
                    var videoSelected = getVideoSelected(grid_user);
                    foreach (var video in videoSelected)
                    {
                        if (tokenSource.Token.IsCancellationRequested)
                        {
                            tokenSource.Token.ThrowIfCancellationRequested();
                        }
                        var url = CommonDouyin.getUrlDownload(video.id, lbl_user_status);
                        Task.Delay(1000).Wait();
                        if (url != null)
                        {
                            // Tao thu muc de download
                            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Download\" + video.author))
                            {
                                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Download\" + video.author);
                            }
                            CommonDouyin.downloadVideoFromUrl(lbl_user_status, url, video.id, video.author);
                            writeProcess(countVideoDownloaded.ToString(), videoSelected.Count.ToString());
                            countVideoDownloaded++;
                            Task.Delay(1000).Wait();
                        }
                        else
                        {
                            continue;
                        }

                    }
                    if (chk_user_noti.Checked)
                    {
                        MessageBox.Show("Đã tải toàn bộ video");
                    }

                }
                catch (OperationCanceledException)
                {

                    CommonDouyin.writeLog(lbl_user_status,"Đã dừng tải video");
                }
                
            });
            

        }

        private void btn_user_stop_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }

        private void chk_mark_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mark_all.Checked)
            {
                chk_mark_all.Text = "Bỏ đánh dấu tất cả";
            }
            else
            {
                chk_mark_all.Text = "Đánh dấu tất cả";
            }
            foreach (DataGridViewRow row in grid_user.Rows)
            {
                DataGridViewCheckBoxCell chk = ((DataGridViewCheckBoxCell)row.Cells[1]);
                //chk.Value = !(chk.Value == null ? false : (bool)chk.Value); //because chk.Value is initialy null
                chk.Value = chk_mark_all.Checked; //because chk.Value is initialy null
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_mark_Click(object sender, EventArgs e)
        {
            int from = Convert.ToInt32(txt_mark_from.Text.Trim());
            int to = Convert.ToInt32(txt_mark_to.Text.Trim());
            if (from < 1)
            {
                MessageBox.Show("Bắt đầu đánh dấu phải > 0");
                return;
            }
            if (from > grid_user.Rows.Count)
            {
                MessageBox.Show("Bắt đầu đánh dấu vượt quá số lượng video");
                return;
            }
            if (to > grid_user.Rows.Count)
            {
                MessageBox.Show("Kết thúc đánh dấu phải nhỏ hơn hoặc bằng " + grid_user.Rows.Count);
                return;
            }
            if (from > to)
            {
                MessageBox.Show("Bắt đầu đánh dấu phải nhỏ hơn kết thúc đánh dấu");
                return;
            }

            for (int i = 0; i < grid_user.Rows.Count; i++)
            {
                if (i >= from - 1 && i < to )
                {
                    DataGridViewRow row = grid_user.Rows[i];
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                    chk.Value = true; //because chk.Value is initialy null
                }
                else
                {
                    DataGridViewRow row = grid_user.Rows[i];
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                    chk.Value = false;
                }
                
            }
           
        }

        private void txt_user_open_explorer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory() + @"\Download");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.facebook.com/teooo.nt");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText("0374234303");
            MessageBox.Show("Đã coppy số Momo");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText("669061099");
            MessageBox.Show("Đã coppy số Tài khoản VPBank");
        }

        private void writeProcess(string downloaded, string total) {

            lbl_process.Invoke(new Action(() => {
                lbl_process.Text = downloaded + "/" + total;
            }));
        }
    }
}
