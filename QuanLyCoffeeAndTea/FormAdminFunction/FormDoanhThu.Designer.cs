
namespace QuanLyCoffeeAndTea.FormAdminFunction
{
    partial class FormDoanhThu
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
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            this.chart = new Guna.Charts.WinForms.GunaChart();
            this.pnlMonth = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblMoneyMonth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMonth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlYear = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblMoneyYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlMonth.SuspendLayout();
            this.pnlYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.White;
            chartFont1.FontName = "Arial";
            this.chart.Legend.LabelFont = chartFont1;
            this.chart.Location = new System.Drawing.Point(12, 173);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1017, 442);
            this.chart.TabIndex = 0;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chart.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            this.chart.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chart.Tooltips.TitleFont = chartFont4;
            this.chart.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            this.chart.XAxes.Ticks = tick1;
            this.chart.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            this.chart.YAxes.Ticks = tick2;
            this.chart.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            this.chart.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            this.chart.ZAxes.Ticks = tick3;
            // 
            // pnlMonth
            // 
            this.pnlMonth.BackColor = System.Drawing.Color.Transparent;
            this.pnlMonth.Controls.Add(this.lblMoneyMonth);
            this.pnlMonth.Controls.Add(this.lblMonth);
            this.pnlMonth.FillColor = System.Drawing.Color.White;
            this.pnlMonth.Location = new System.Drawing.Point(56, 18);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Radius = 5;
            this.pnlMonth.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlMonth.ShadowDepth = 200;
            this.pnlMonth.Size = new System.Drawing.Size(395, 138);
            this.pnlMonth.TabIndex = 1;
            // 
            // lblMoneyMonth
            // 
            this.lblMoneyMonth.AutoSize = false;
            this.lblMoneyMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneyMonth.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblMoneyMonth.ForeColor = System.Drawing.Color.Black;
            this.lblMoneyMonth.Location = new System.Drawing.Point(72, 77);
            this.lblMoneyMonth.Name = "lblMoneyMonth";
            this.lblMoneyMonth.Size = new System.Drawing.Size(251, 29);
            this.lblMoneyMonth.TabIndex = 43;
            this.lblMoneyMonth.Text = "VNĐ";
            this.lblMoneyMonth.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = false;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMonth.ForeColor = System.Drawing.Color.Black;
            this.lblMonth.Location = new System.Drawing.Point(26, 33);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(343, 34);
            this.lblMonth.TabIndex = 42;
            this.lblMonth.Text = "Doanh thu trong tháng";
            this.lblMonth.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlYear
            // 
            this.pnlYear.BackColor = System.Drawing.Color.Transparent;
            this.pnlYear.Controls.Add(this.lblMoneyYear);
            this.pnlYear.Controls.Add(this.lblYear);
            this.pnlYear.FillColor = System.Drawing.Color.White;
            this.pnlYear.Location = new System.Drawing.Point(589, 18);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Radius = 5;
            this.pnlYear.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlYear.ShadowDepth = 200;
            this.pnlYear.Size = new System.Drawing.Size(395, 138);
            this.pnlYear.TabIndex = 2;
            // 
            // lblMoneyYear
            // 
            this.lblMoneyYear.AutoSize = false;
            this.lblMoneyYear.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneyYear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblMoneyYear.ForeColor = System.Drawing.Color.Black;
            this.lblMoneyYear.Location = new System.Drawing.Point(72, 77);
            this.lblMoneyYear.Name = "lblMoneyYear";
            this.lblMoneyYear.Size = new System.Drawing.Size(251, 29);
            this.lblMoneyYear.TabIndex = 43;
            this.lblMoneyYear.Text = "VNĐ";
            this.lblMoneyYear.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = false;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(26, 33);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(343, 34);
            this.lblYear.TabIndex = 42;
            this.lblYear.Text = "Doanh thu trong năm";
            this.lblYear.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 627);
            this.Controls.Add(this.pnlYear);
            this.Controls.Add(this.pnlMonth);
            this.Controls.Add(this.chart);
            this.Name = "FormDoanhThu";
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.FormDoanhThu_Load);
            this.pnlMonth.ResumeLayout(false);
            this.pnlYear.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.Charts.WinForms.GunaChart chart;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlMonth;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMoneyMonth;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMonth;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMoneyYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYear;
    }
}