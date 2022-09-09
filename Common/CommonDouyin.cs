using DouyinDownloader.Model;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DouyinDownloader.Common
{
    public static class CommonDouyin
    {
        public static string getUidVideo(string url, Label lbl_noti) {
            var mobileUrl = Regex.Match(url, @"http[s]?://(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+").Value;

            if (String.IsNullOrEmpty(mobileUrl))
            {
                MessageBox.Show("Vui lòng nhập URL");
                return null;
            }
            else
            {
                if (!mobileUrl.Contains("https://v.douyin.com"))
                {
                    MessageBox.Show("- Nhập URL video Douyin dạng: https://v.douyin.com/***\n- Lấy URL tại nút chia sẻ trong video");
                    return null;
                }
            }

            // Tao thu muc download
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Download"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Download");
            }

            writeLog(lbl_noti, "Đang tìm url");
            RestRequest restRequest = new RestRequest("", Method.Get);
            // Lay url pc
            var restClient = new RestClient(new Uri(mobileUrl));

            //restClient.AddDefaultHeader("Authorization", string.Format("Bearer {0}", api));
            restClient.AddDefaultHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
            var restResponse = restClient.Execute(restRequest);

            string urlPc = restResponse.ResponseUri.ToString();

            //var jsonRes = JObject.Parse(restResponse.Content);
            // Lay id video
            writeLog(lbl_noti, "Đang tìm id video");
            var id = Regex.Match(urlPc, @"\d+").Value;
            return id;
        }

        public static string getUrlDownload(string id_vid, Label lbl_status) {
            // Lay link tai video
            CommonDouyin.writeLog(lbl_status, "Đang lấy link tải video");
            RestRequest restRequest = new RestRequest("", Method.Get);
            RestClient restClient = new RestClient(new Uri(@"https://www.iesdouyin.com/web/api/v2/aweme/iteminfo/?item_ids=" + id_vid));
            RestResponse restResponse = restClient.Execute(restRequest);
            var jsonRes = JObject.Parse(restResponse.Content);
            string urlDownload;
            string duration;
            if (jsonRes.ContainsKey("item_list"))
            {
                urlDownload = jsonRes["item_list"][0]["video"]["play_addr"]["url_list"][0].ToString().
                    Replace("playwm", "play").Replace("720p", "1080p");
                if (!String.IsNullOrEmpty(urlDownload))
                {

                    return urlDownload;

                }
                else
                {
                    // Thong bao that bai
                    CommonDouyin.writeLog(lbl_status, "Không tìm thấy link video");
                    return null;
                }
            }
            else
            {
                // Thong bao that bai
                CommonDouyin.writeLog(lbl_status, "Không tìm thấy link video");
                return null;
            }
        }

        public static List<ModelVideo> getPostUser(string uid, Label lbl_status) {
            List<ModelVideo> modelVideos = new List<ModelVideo>();
            string maxcursor = "0";
            RestRequest restRequest = new RestRequest("", Method.Get);
            // Lay link tai video
            CommonDouyin.writeLog(lbl_status, "Đang lấy thông tin user");

            while (true)
            {
                
                string url = String.Format(@"https://www.iesdouyin.com/web/api/v2/aweme/post/?sec_uid={0}&count=40&max_cursor={1}", uid, maxcursor.ToString());
                
                RestClient restClient = new RestClient(new Uri(url));
                RestResponse restResponse = restClient.Execute(restRequest);
                var jsonRes = JObject.Parse(restResponse.Content);

                // Lay du lieu danh sach video
                if (jsonRes.ContainsKey("aweme_list"))
                {
                   
                    foreach (var aweme_list in jsonRes["aweme_list"])
                    {
                        // Kiem tra la video hay story
                        if (!String.IsNullOrEmpty(aweme_list["video"]["vid"].ToString()))
                        {
                            var aweme_id = aweme_list["aweme_id"].ToString();
                            var desc = aweme_list["desc"].ToString();
                            var like = Convert.ToInt32(aweme_list["statistics"]["digg_count"].ToString());
                            var author = aweme_list["author"]["uid"].ToString();
                            Uri cover = new Uri(aweme_list["video"]["cover"]["url_list"][0].ToString());
                            double duration = Convert.ToDouble(aweme_list["video"]["duration"].ToString()) ;
                            modelVideos.Add(new ModelVideo(aweme_id, desc, author, cover, duration,like));

                        }
                        else
                        {
                            continue;
                        }
                        
                    }
                    
                }
                else
                {
                    // Thong bao that bai
                    CommonDouyin.writeLog(lbl_status, "Không tìm thấy link video");
                    return null;
                }

                // Kiem tra con video khong
                // neu con thi lay maxcursor lay du lieu tiep
                if (Convert.ToBoolean(jsonRes["has_more"].ToString()))
                {
                    maxcursor = jsonRes["max_cursor"].ToString();
                }
                else
                {
                    // khong con video thi thoat vong lap
                    break;
                }
            }

            return modelVideos;

        }

        public static void writeLog(Label lbl_status, string message)
        {
            lbl_status.Invoke((Action)(() => {
                lbl_status.Text = message;
            }));
        }

        public static void downloadVideoFromUrl(Label lbl_status, string url, string video_id, string user_id) {

            if (!String.IsNullOrEmpty(url))
            {
                String currentDir = Directory.GetCurrentDirectory();
                RestRequest restRequest = new RestRequest("", Method.Get);                
                CommonDouyin.writeLog(lbl_status, "Đang tải video " + video_id);
                RestClient client = new RestClient(new Uri(url));
                byte[] response = client.DownloadData(restRequest);
                var filename = String.Format("{0}_{1}.mp4", video_id, DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
                var path = String.Format(currentDir + @"\Download\{0}\{1}", user_id, filename);
                File.WriteAllBytes(path, response);
                CommonDouyin.writeLog(lbl_status, "Đã tải xong: " + video_id);
                Task.Delay(1000).Wait();
                return;

            }
            else
            {
                // Thong bao that bai
                CommonDouyin.writeLog(lbl_status, "Không tìm thấy link video");
                return;
            }
        }
    }
}
