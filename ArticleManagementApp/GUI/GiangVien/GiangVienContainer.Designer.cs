using System.Drawing;
using System.Windows.Forms;

namespace ArticleManagementApp.GUI
{
    partial class GiangVienContainer
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
            this.giangVienHomeContainter = new Guna.UI2.WinForms.Guna2Panel();
            this.giangVienSideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmittedReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnProcessingReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnProcessedReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnStoreReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.giangVienHomeContainter.SuspendLayout();
            this.giangVienSideBar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // giangVienHomeContainter
            // 
            this.giangVienHomeContainter.Controls.Add(this.guna2PictureBox2);
            this.giangVienHomeContainter.Dock = System.Windows.Forms.DockStyle.Right;
            this.giangVienHomeContainter.Location = new System.Drawing.Point(232, 0);
            this.giangVienHomeContainter.Name = "giangVienHomeContainter";
            this.giangVienHomeContainter.Size = new System.Drawing.Size(1352, 861);
            this.giangVienHomeContainter.TabIndex = 12;
            // 
            // giangVienSideBar
            // 
            this.giangVienSideBar.Controls.Add(this.guna2Panel1);
            this.giangVienSideBar.Controls.Add(this.flowLayoutPanel1);
            this.giangVienSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giangVienSideBar.Location = new System.Drawing.Point(0, 0);
            this.giangVienSideBar.Name = "giangVienSideBar";
            this.giangVienSideBar.Size = new System.Drawing.Size(232, 861);
            this.giangVienSideBar.TabIndex = 13;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Blue;
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 779);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(232, 82);
            this.guna2Panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 50);
            this.panel2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Powered By Team 17";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmittedReport);
            this.flowLayoutPanel1.Controls.Add(this.btnProcessingReport);
            this.flowLayoutPanel1.Controls.Add(this.btnProcessedReport);
            this.flowLayoutPanel1.Controls.Add(this.btnStoreReport);
            this.flowLayoutPanel1.Controls.Add(this.btnInfo);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 861);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 67);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "SECO Software";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ArticleManagementApp.Properties.Resources.group_logo_v2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 47);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArticleManagementApp.Properties.Resources.app_logo;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 64);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::ArticleManagementApp.Properties.Resources.house_icon;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHome.IndicateFocus = true;
            this.btnHome.Location = new System.Drawing.Point(3, 125);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(206, 40);
            this.btnHome.TabIndex = 31;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.UseTransparentBackground = true;
            this.btnHome.Click += new System.EventHandler(this.Go_Home);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::ArticleManagementApp.Properties.Resources.thembaibao_icon;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.IndicateFocus = true;
            this.btnAdd.Location = new System.Drawing.Point(3, 198);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 40);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Thêm bài báo";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.Go_AddReportForm);
            // 
            // btnSubmittedReport
            // 
            this.btnSubmittedReport.Animated = true;
            this.btnSubmittedReport.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmittedReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSubmittedReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmittedReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmittedReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmittedReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmittedReport.FillColor = System.Drawing.Color.Transparent;
            this.btnSubmittedReport.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmittedReport.ForeColor = System.Drawing.Color.White;
            this.btnSubmittedReport.Image = global::ArticleManagementApp.Properties.Resources.report_icon;
            this.btnSubmittedReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSubmittedReport.IndicateFocus = true;
            this.btnSubmittedReport.Location = new System.Drawing.Point(3, 271);
            this.btnSubmittedReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnSubmittedReport.Name = "btnSubmittedReport";
            this.btnSubmittedReport.Size = new System.Drawing.Size(206, 40);
            this.btnSubmittedReport.TabIndex = 33;
            this.btnSubmittedReport.Text = "Danh sách đơn đã nộp";
            this.btnSubmittedReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSubmittedReport.UseTransparentBackground = true;
            this.btnSubmittedReport.Click += new System.EventHandler(this.Go_SubmittedReport);
            // 
            // btnProcessingReport
            // 
            this.btnProcessingReport.Animated = true;
            this.btnProcessingReport.BackColor = System.Drawing.Color.Transparent;
            this.btnProcessingReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProcessingReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProcessingReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProcessingReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProcessingReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProcessingReport.FillColor = System.Drawing.Color.Transparent;
            this.btnProcessingReport.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnProcessingReport.ForeColor = System.Drawing.Color.White;
            this.btnProcessingReport.Image = global::ArticleManagementApp.Properties.Resources.report_processing_icon;
            this.btnProcessingReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProcessingReport.IndicateFocus = true;
            this.btnProcessingReport.Location = new System.Drawing.Point(3, 344);
            this.btnProcessingReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnProcessingReport.Name = "btnProcessingReport";
            this.btnProcessingReport.Size = new System.Drawing.Size(206, 40);
            this.btnProcessingReport.TabIndex = 35;
            this.btnProcessingReport.Text = "Danh sách đơn đang xử lý";
            this.btnProcessingReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProcessingReport.UseTransparentBackground = true;
            this.btnProcessingReport.Click += new System.EventHandler(this.Go_PendingReport);
            // 
            // btnProcessedReport
            // 
            this.btnProcessedReport.Animated = true;
            this.btnProcessedReport.BackColor = System.Drawing.Color.Transparent;
            this.btnProcessedReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProcessedReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProcessedReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProcessedReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProcessedReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProcessedReport.FillColor = System.Drawing.Color.Transparent;
            this.btnProcessedReport.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnProcessedReport.ForeColor = System.Drawing.Color.White;
            this.btnProcessedReport.Image = global::ArticleManagementApp.Properties.Resources.report_processed_icon;
            this.btnProcessedReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProcessedReport.IndicateFocus = true;
            this.btnProcessedReport.Location = new System.Drawing.Point(3, 417);
            this.btnProcessedReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnProcessedReport.Name = "btnProcessedReport";
            this.btnProcessedReport.Size = new System.Drawing.Size(206, 40);
            this.btnProcessedReport.TabIndex = 36;
            this.btnProcessedReport.Text = "Danh sách đơn đã xử lý";
            this.btnProcessedReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProcessedReport.UseTransparentBackground = true;
            this.btnProcessedReport.Click += new System.EventHandler(this.Go_PublishedReport);
            // 
            // btnStoreReport
            // 
            this.btnStoreReport.Animated = true;
            this.btnStoreReport.BackColor = System.Drawing.Color.Transparent;
            this.btnStoreReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStoreReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStoreReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStoreReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStoreReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStoreReport.FillColor = System.Drawing.Color.Transparent;
            this.btnStoreReport.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnStoreReport.ForeColor = System.Drawing.Color.White;
            this.btnStoreReport.Image = global::ArticleManagementApp.Properties.Resources.report_save_icon;
            this.btnStoreReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStoreReport.IndicateFocus = true;
            this.btnStoreReport.Location = new System.Drawing.Point(3, 490);
            this.btnStoreReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnStoreReport.Name = "btnStoreReport";
            this.btnStoreReport.Size = new System.Drawing.Size(206, 40);
            this.btnStoreReport.TabIndex = 37;
            this.btnStoreReport.Text = "Lưu trữ";
            this.btnStoreReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStoreReport.UseTransparentBackground = true;
            this.btnStoreReport.Click += new System.EventHandler(this.Go_StoredReport);
            // 
            // btnInfo
            // 
            this.btnInfo.Animated = true;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnInfo.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::ArticleManagementApp.Properties.Resources.info_icon;
            this.btnInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInfo.IndicateFocus = true;
            this.btnInfo.Location = new System.Drawing.Point(3, 563);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(206, 40);
            this.btnInfo.TabIndex = 38;
            this.btnInfo.Text = "Thông tin tài khoản";
            this.btnInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInfo.UseTransparentBackground = true;
            this.btnInfo.Click += new System.EventHandler(this.Go_AccountInfo);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::ArticleManagementApp.Properties.Resources.door_in_icon;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.IndicateFocus = true;
            this.btnLogout.Location = new System.Drawing.Point(3, 636);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 60);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(206, 40);
            this.btnLogout.TabIndex = 39;
            this.btnLogout.Text = " Đăng xuất";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::ArticleManagementApp.Properties.Resources.bot_icon;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(1319, 797);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(53, 61);
            this.guna2PictureBox2.TabIndex = 36;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::ArticleManagementApp.Properties.Resources.bot_icon;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1527, 799);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(57, 61);
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // GiangVienContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.giangVienSideBar);
            this.Controls.Add(this.giangVienHomeContainter);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "GiangVienContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiangVienHome";
            this.giangVienHomeContainter.ResumeLayout(false);
            this.giangVienSideBar.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel giangVienHomeContainter;
        private Guna.UI2.WinForms.Guna2Panel giangVienSideBar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnSubmittedReport;
        private Guna.UI2.WinForms.Guna2Button btnProcessingReport;
        private Guna.UI2.WinForms.Guna2Button btnProcessedReport;
        private Guna.UI2.WinForms.Guna2Button btnStoreReport;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}