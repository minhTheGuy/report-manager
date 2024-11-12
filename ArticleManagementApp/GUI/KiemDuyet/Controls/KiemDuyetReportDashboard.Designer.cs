namespace ArticleManagementApp.GUI.KiemDuyet.Controls
{
    partial class KiemDuyetReportDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reportList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblReportListTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPublishedReport = new System.Windows.Forms.Label();
            this.lbllPublishedReportTitle = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPendingReport = new System.Windows.Forms.Label();
            this.lblPendingReportTitle = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.searchBarContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportList)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.reportList);
            this.panel4.Controls.Add(this.lblReportListTitle);
            this.panel4.Location = new System.Drawing.Point(27, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1318, 624);
            this.panel4.TabIndex = 24;
            // 
            // reportList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.reportList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reportList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(169)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reportList.ColumnHeadersHeight = 30;
            this.reportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportList.DefaultCellStyle = dataGridViewCellStyle3;
            this.reportList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reportList.Location = new System.Drawing.Point(6, 42);
            this.reportList.Name = "reportList";
            this.reportList.RowHeadersVisible = false;
            this.reportList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.reportList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.reportList.RowTemplate.Height = 30;
            this.reportList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reportList.Size = new System.Drawing.Size(1301, 570);
            this.reportList.TabIndex = 18;
            this.reportList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.reportList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.reportList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.reportList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.reportList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.reportList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.reportList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reportList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.reportList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reportList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reportList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.reportList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.reportList.ThemeStyle.HeaderStyle.Height = 30;
            this.reportList.ThemeStyle.ReadOnly = false;
            this.reportList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.reportList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.reportList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reportList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.reportList.ThemeStyle.RowsStyle.Height = 30;
            this.reportList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reportList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblReportListTitle
            // 
            this.lblReportListTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportListTitle.AutoSize = true;
            this.lblReportListTitle.Font = new System.Drawing.Font("Inter Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportListTitle.Location = new System.Drawing.Point(-5, 9);
            this.lblReportListTitle.Name = "lblReportListTitle";
            this.lblReportListTitle.Size = new System.Drawing.Size(400, 30);
            this.lblReportListTitle.TabIndex = 19;
            this.lblReportListTitle.Text = "Danh sách đơn bài báo giảng viên nộp";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel7);
            this.guna2Panel1.Location = new System.Drawing.Point(27, 81);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1318, 111);
            this.guna2Panel1.TabIndex = 25;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.Controls.Add(this.lblPublishedReport);
            this.guna2Panel2.Controls.Add(this.lbllPublishedReportTitle);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(493, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(329, 100);
            this.guna2Panel2.TabIndex = 18;
            // 
            // lblPublishedReport
            // 
            this.lblPublishedReport.AutoSize = true;
            this.lblPublishedReport.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishedReport.Location = new System.Drawing.Point(18, 54);
            this.lblPublishedReport.Name = "lblPublishedReport";
            this.lblPublishedReport.Size = new System.Drawing.Size(58, 27);
            this.lblPublishedReport.TabIndex = 3;
            this.lblPublishedReport.Text = "1200";
            // 
            // lbllPublishedReportTitle
            // 
            this.lbllPublishedReportTitle.AutoSize = true;
            this.lbllPublishedReportTitle.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllPublishedReportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(171)))));
            this.lbllPublishedReportTitle.Location = new System.Drawing.Point(18, 18);
            this.lbllPublishedReportTitle.Name = "lbllPublishedReportTitle";
            this.lbllPublishedReportTitle.Size = new System.Drawing.Size(293, 27);
            this.lbllPublishedReportTitle.TabIndex = 2;
            this.lbllPublishedReportTitle.Text = "Tổng số đơn duyệt thành công";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.Controls.Add(this.lblPendingReport);
            this.guna2Panel3.Controls.Add(this.lblPendingReportTitle);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(984, 5);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(329, 100);
            this.guna2Panel3.TabIndex = 19;
            // 
            // lblPendingReport
            // 
            this.lblPendingReport.AutoSize = true;
            this.lblPendingReport.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingReport.Location = new System.Drawing.Point(19, 54);
            this.lblPendingReport.Name = "lblPendingReport";
            this.lblPendingReport.Size = new System.Drawing.Size(24, 27);
            this.lblPendingReport.TabIndex = 5;
            this.lblPendingReport.Text = "2";
            // 
            // lblPendingReportTitle
            // 
            this.lblPendingReportTitle.AutoSize = true;
            this.lblPendingReportTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblPendingReportTitle.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingReportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(171)))));
            this.lblPendingReportTitle.Location = new System.Drawing.Point(19, 18);
            this.lblPendingReportTitle.Name = "lblPendingReportTitle";
            this.lblPendingReportTitle.Size = new System.Drawing.Size(223, 27);
            this.lblPendingReportTitle.TabIndex = 4;
            this.lblPendingReportTitle.Text = "Tổng số đơn chờ duyệt";
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.White;
            this.guna2Panel7.BorderRadius = 15;
            this.guna2Panel7.Controls.Add(this.lblReport);
            this.guna2Panel7.Controls.Add(this.lblReportTitle);
            this.guna2Panel7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.Location = new System.Drawing.Point(2, 5);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(329, 100);
            this.guna2Panel7.TabIndex = 17;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(15, 54);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(46, 27);
            this.lblReport.TabIndex = 1;
            this.lblReport.Text = "100";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblReportTitle.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(171)))));
            this.lblReportTitle.Location = new System.Drawing.Point(15, 18);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(218, 27);
            this.lblReportTitle.TabIndex = 0;
            this.lblReportTitle.Text = "Tổng số đơn được nộp";
            // 
            // searchBarContainer
            // 
            this.searchBarContainer.BackColor = System.Drawing.Color.White;
            this.searchBarContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBarContainer.Location = new System.Drawing.Point(0, 0);
            this.searchBarContainer.Name = "searchBarContainer";
            this.searchBarContainer.Size = new System.Drawing.Size(1375, 62);
            this.searchBarContainer.TabIndex = 26;
            // 
            // KiemDuyetReportDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchBarContainer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "KiemDuyetReportDashboard";
            this.Size = new System.Drawing.Size(1375, 861);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportList)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView reportList;
        private System.Windows.Forms.Label lblReportListTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblPublishedReport;
        private System.Windows.Forms.Label lbllPublishedReportTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblPendingReport;
        private System.Windows.Forms.Label lblPendingReportTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblReportTitle;
        private Guna.UI2.WinForms.Guna2Panel searchBarContainer;
    }
}
