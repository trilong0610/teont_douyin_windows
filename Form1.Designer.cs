namespace DouyinDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_download = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.chk_notification = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_user_download_post = new System.Windows.Forms.Button();
            this.btn_user_stop = new System.Windows.Forms.Button();
            this.btn_mark = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mark_to = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mark_from = new System.Windows.Forms.TextBox();
            this.chk_mark_all = new System.Windows.Forms.CheckBox();
            this.grid_user = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user_open_explorer = new System.Windows.Forms.LinkLabel();
            this.txt_url_user = new System.Windows.Forms.TextBox();
            this.chk_user_noti = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_user_status = new System.Windows.Forms.Label();
            this.btn_user_download = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_process = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_user)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_url.Location = new System.Drawing.Point(88, 32);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(397, 22);
            this.txt_url.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL Video:";
            // 
            // btn_download
            // 
            this.btn_download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_download.Location = new System.Drawing.Point(9, 624);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(486, 55);
            this.btn_download.TabIndex = 2;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(17, 533);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 16);
            this.lbl_status.TabIndex = 3;
            // 
            // chk_notification
            // 
            this.chk_notification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_notification.AutoSize = true;
            this.chk_notification.Location = new System.Drawing.Point(9, 598);
            this.chk_notification.Name = "chk_notification";
            this.chk_notification.Size = new System.Drawing.Size(189, 20);
            this.chk_notification.TabIndex = 4;
            this.chk_notification.Text = "Hiện thông báo khi tải xong";
            this.chk_notification.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkLabel4);
            this.groupBox1.Controls.Add(this.txt_url);
            this.groupBox1.Controls.Add(this.chk_notification);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_status);
            this.groupBox1.Controls.Add(this.btn_download);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 685);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Không cần xóa chữ Trung Quốc trong URL)";
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(347, 598);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(138, 16);
            this.linkLabel4.TabIndex = 6;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Mở thư mục Download";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(510, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 683);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ủng hộ tác giả";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(6, 111);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(56, 16);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "VPBank";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(6, 84);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(45, 16);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Momo";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 58);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Facebook";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nguyễn Tri Long";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1364, 727);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1356, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tải video";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1356, 698);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tải người dùng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Controls.Add(this.btn_mark);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txt_mark_to);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txt_mark_from);
            this.groupBox5.Controls.Add(this.chk_mark_all);
            this.groupBox5.Controls.Add(this.grid_user);
            this.groupBox5.Location = new System.Drawing.Point(387, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(820, 685);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_user_download_post, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_user_stop, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 624);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 55);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btn_user_download_post
            // 
            this.btn_user_download_post.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_user_download_post.Location = new System.Drawing.Point(3, 3);
            this.btn_user_download_post.Name = "btn_user_download_post";
            this.btn_user_download_post.Size = new System.Drawing.Size(398, 49);
            this.btn_user_download_post.TabIndex = 8;
            this.btn_user_download_post.Text = "Tải xuống";
            this.btn_user_download_post.UseVisualStyleBackColor = true;
            this.btn_user_download_post.Click += new System.EventHandler(this.btn_user_download_post_Click);
            // 
            // btn_user_stop
            // 
            this.btn_user_stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_user_stop.Location = new System.Drawing.Point(407, 3);
            this.btn_user_stop.Name = "btn_user_stop";
            this.btn_user_stop.Size = new System.Drawing.Size(398, 49);
            this.btn_user_stop.TabIndex = 9;
            this.btn_user_stop.Text = "Dừng";
            this.btn_user_stop.UseVisualStyleBackColor = true;
            this.btn_user_stop.Click += new System.EventHandler(this.btn_user_stop_Click);
            // 
            // btn_mark
            // 
            this.btn_mark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mark.Enabled = false;
            this.btn_mark.Location = new System.Drawing.Point(670, 571);
            this.btn_mark.Name = "btn_mark";
            this.btn_mark.Size = new System.Drawing.Size(142, 23);
            this.btn_mark.TabIndex = 15;
            this.btn_mark.Text = "Đánh dấu";
            this.btn_mark.UseVisualStyleBackColor = true;
            this.btn_mark.Click += new System.EventHandler(this.btn_mark_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 574);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Đến video:";
            // 
            // txt_mark_to
            // 
            this.txt_mark_to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mark_to.Location = new System.Drawing.Point(562, 571);
            this.txt_mark_to.Name = "txt_mark_to";
            this.txt_mark_to.Size = new System.Drawing.Size(92, 22);
            this.txt_mark_to.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Từ video:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_mark_from
            // 
            this.txt_mark_from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mark_from.Location = new System.Drawing.Point(365, 571);
            this.txt_mark_from.Name = "txt_mark_from";
            this.txt_mark_from.Size = new System.Drawing.Size(92, 22);
            this.txt_mark_from.TabIndex = 11;
            // 
            // chk_mark_all
            // 
            this.chk_mark_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_mark_all.AutoSize = true;
            this.chk_mark_all.Enabled = false;
            this.chk_mark_all.Location = new System.Drawing.Point(6, 570);
            this.chk_mark_all.Name = "chk_mark_all";
            this.chk_mark_all.Size = new System.Drawing.Size(121, 20);
            this.chk_mark_all.TabIndex = 10;
            this.chk_mark_all.Text = "Đánh dấu tất cả";
            this.chk_mark_all.UseVisualStyleBackColor = true;
            this.chk_mark_all.CheckedChanged += new System.EventHandler(this.chk_mark_all_CheckedChanged);
            // 
            // grid_user
            // 
            this.grid_user.AllowUserToAddRows = false;
            this.grid_user.AllowUserToDeleteRows = false;
            this.grid_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_user.Location = new System.Drawing.Point(6, 22);
            this.grid_user.MultiSelect = false;
            this.grid_user.Name = "grid_user";
            this.grid_user.RowHeadersVisible = false;
            this.grid_user.RowHeadersWidth = 51;
            this.grid_user.RowTemplate.Height = 24;
            this.grid_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_user.Size = new System.Drawing.Size(808, 542);
            this.grid_user.TabIndex = 0;
            this.grid_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_user_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.lbl_process);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_user_open_explorer);
            this.groupBox3.Controls.Add(this.txt_url_user);
            this.groupBox3.Controls.Add(this.chk_user_noti);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbl_user_status);
            this.groupBox3.Controls.Add(this.btn_user_download);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 685);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cài đặt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "(Không cần xóa chữ Trung Quốc trong URL)";
            // 
            // txt_user_open_explorer
            // 
            this.txt_user_open_explorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_user_open_explorer.AutoSize = true;
            this.txt_user_open_explorer.Location = new System.Drawing.Point(218, 599);
            this.txt_user_open_explorer.Name = "txt_user_open_explorer";
            this.txt_user_open_explorer.Size = new System.Drawing.Size(138, 16);
            this.txt_user_open_explorer.TabIndex = 6;
            this.txt_user_open_explorer.TabStop = true;
            this.txt_user_open_explorer.Text = "Mở thư mục Download";
            this.txt_user_open_explorer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txt_user_open_explorer_LinkClicked);
            // 
            // txt_url_user
            // 
            this.txt_url_user.Location = new System.Drawing.Point(81, 32);
            this.txt_url_user.Name = "txt_url_user";
            this.txt_url_user.Size = new System.Drawing.Size(286, 22);
            this.txt_url_user.TabIndex = 0;
            // 
            // chk_user_noti
            // 
            this.chk_user_noti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_user_noti.AutoSize = true;
            this.chk_user_noti.Location = new System.Drawing.Point(9, 598);
            this.chk_user_noti.Name = "chk_user_noti";
            this.chk_user_noti.Size = new System.Drawing.Size(189, 20);
            this.chk_user_noti.TabIndex = 4;
            this.chk_user_noti.Text = "Hiện thông báo khi tải xong";
            this.chk_user_noti.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "URL User:";
            // 
            // lbl_user_status
            // 
            this.lbl_user_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_user_status.AutoSize = true;
            this.lbl_user_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_status.Location = new System.Drawing.Point(18, 512);
            this.lbl_user_status.Name = "lbl_user_status";
            this.lbl_user_status.Size = new System.Drawing.Size(15, 16);
            this.lbl_user_status.TabIndex = 3;
            this.lbl_user_status.Text = "0";
            // 
            // btn_user_download
            // 
            this.btn_user_download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_user_download.Location = new System.Drawing.Point(9, 624);
            this.btn_user_download.Name = "btn_user_download";
            this.btn_user_download.Size = new System.Drawing.Size(358, 55);
            this.btn_user_download.TabIndex = 2;
            this.btn_user_download.Text = "Lấy thông tin";
            this.btn_user_download.UseVisualStyleBackColor = true;
            this.btn_user_download.Click += new System.EventHandler(this.btn_user_download_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.linkLabel6);
            this.groupBox4.Controls.Add(this.linkLabel7);
            this.groupBox4.Controls.Add(this.linkLabel8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(1213, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 683);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ủng hộ tác giả";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(6, 111);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(56, 16);
            this.linkLabel6.TabIndex = 5;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "VPBank";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(6, 84);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(45, 16);
            this.linkLabel7.TabIndex = 4;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Momo";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(6, 58);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(69, 16);
            this.linkLabel8.TabIndex = 3;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Facebook";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nguyễn Tri Long";
            // 
            // lbl_process
            // 
            this.lbl_process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_process.AutoSize = true;
            this.lbl_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_process.Location = new System.Drawing.Point(18, 548);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(15, 16);
            this.lbl_process.TabIndex = 8;
            this.lbl_process.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 727);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Douyin Downloader - by teooo.nt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_user)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.CheckBox chk_notification;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel txt_user_open_explorer;
        private System.Windows.Forms.TextBox txt_url_user;
        private System.Windows.Forms.CheckBox chk_user_noti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_user_status;
        private System.Windows.Forms.Button btn_user_download;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grid_user;
        private System.Windows.Forms.Button btn_user_download_post;
        private System.Windows.Forms.Button btn_user_stop;
        private System.Windows.Forms.Button btn_mark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_mark_to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mark_from;
        private System.Windows.Forms.CheckBox chk_mark_all;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_process;
    }
}

