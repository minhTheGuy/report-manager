namespace ArticleManagementApp.GUI.GiamSat.Controls
{
    partial class GiamSatHome
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
            Guna.Charts.WinForms.ChartFont chartFont57 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont58 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont59 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont60 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid22 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick22 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont61 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid23 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick23 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont62 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid24 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel8 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont63 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick24 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont64 = new Guna.Charts.WinForms.ChartFont();
            this.searchBarContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dashboardContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dashboardChart = new Guna.Charts.WinForms.GunaChart();
            this.chartContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBarContainer
            // 
            this.searchBarContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBarContainer.Location = new System.Drawing.Point(0, 0);
            this.searchBarContainer.Name = "searchBarContainer";
            this.searchBarContainer.Size = new System.Drawing.Size(1375, 120);
            this.searchBarContainer.TabIndex = 0;
            // 
            // dashboardContainer
            // 
            this.dashboardContainer.BackColor = System.Drawing.Color.Transparent;
            this.dashboardContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboardContainer.BorderRadius = 15;
            this.dashboardContainer.BorderThickness = 1;
            this.dashboardContainer.FillColor = System.Drawing.Color.White;
            this.dashboardContainer.Location = new System.Drawing.Point(73, 178);
            this.dashboardContainer.Name = "dashboardContainer";
            this.dashboardContainer.Size = new System.Drawing.Size(1228, 151);
            this.dashboardContainer.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Biểu đồ thống kê";
            // 
            // dashboardChart
            // 
            chartFont57.FontName = "Arial";
            this.dashboardChart.Legend.LabelFont = chartFont57;
            this.dashboardChart.Location = new System.Drawing.Point(42, 41);
            this.dashboardChart.Name = "dashboardChart";
            this.dashboardChart.Size = new System.Drawing.Size(1168, 390);
            this.dashboardChart.TabIndex = 1;
            chartFont58.FontName = "Arial";
            chartFont58.Size = 12;
            chartFont58.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.dashboardChart.Title.Font = chartFont58;
            chartFont59.FontName = "Arial";
            this.dashboardChart.Tooltips.BodyFont = chartFont59;
            chartFont60.FontName = "Arial";
            chartFont60.Size = 9;
            chartFont60.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.dashboardChart.Tooltips.TitleFont = chartFont60;
            this.dashboardChart.XAxes.GridLines = grid22;
            chartFont61.FontName = "Arial";
            tick22.Font = chartFont61;
            this.dashboardChart.XAxes.Ticks = tick22;
            this.dashboardChart.YAxes.GridLines = grid23;
            chartFont62.FontName = "Arial";
            tick23.Font = chartFont62;
            this.dashboardChart.YAxes.Ticks = tick23;
            this.dashboardChart.ZAxes.GridLines = grid24;
            chartFont63.FontName = "Arial";
            pointLabel8.Font = chartFont63;
            this.dashboardChart.ZAxes.PointLabels = pointLabel8;
            chartFont64.FontName = "Arial";
            tick24.Font = chartFont64;
            this.dashboardChart.ZAxes.Ticks = tick24;
            // 
            // chartContainer
            // 
            this.chartContainer.BackColor = System.Drawing.Color.Transparent;
            this.chartContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chartContainer.BorderRadius = 15;
            this.chartContainer.BorderThickness = 1;
            this.chartContainer.Controls.Add(this.dashboardChart);
            this.chartContainer.Controls.Add(this.label7);
            this.chartContainer.FillColor = System.Drawing.Color.White;
            this.chartContainer.Location = new System.Drawing.Point(73, 376);
            this.chartContainer.Name = "chartContainer";
            this.chartContainer.Size = new System.Drawing.Size(1228, 450);
            this.chartContainer.TabIndex = 2;
            // 
            // GiamSatHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartContainer);
            this.Controls.Add(this.dashboardContainer);
            this.Controls.Add(this.searchBarContainer);
            this.Name = "GiamSatHome";
            this.Size = new System.Drawing.Size(1375, 861);
            this.chartContainer.ResumeLayout(false);
            this.chartContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel searchBarContainer;
        private Guna.UI2.WinForms.Guna2Panel dashboardContainer;
        private System.Windows.Forms.Label label7;
        private Guna.Charts.WinForms.GunaChart dashboardChart;
        private Guna.UI2.WinForms.Guna2Panel chartContainer;
    }
}
