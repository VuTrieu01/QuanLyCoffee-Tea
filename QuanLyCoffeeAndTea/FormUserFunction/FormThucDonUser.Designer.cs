
namespace QuanLyCoffeeAndTea
{
    partial class FormThucDonUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TenTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblThietBi = new System.Windows.Forms.Label();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlThanhTieuDe = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbDanhMuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.nmFoodCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pnlThietBi = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHienThi = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtThucDon = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemMon = new FontAwesome.Sharp.IconButton();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.pnlThanhTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.pnlHienThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.dgvHoaDon);
            this.pnlMain.Controls.Add(this.txtTongTien);
            this.pnlMain.Controls.Add(this.lblThietBi);
            this.pnlMain.Controls.Add(this.btnThanhToan);
            this.pnlMain.Controls.Add(this.pnlContainer);
            this.pnlMain.Controls.Add(this.pnlThanhTieuDe);
            this.pnlMain.Controls.Add(this.nmFoodCount);
            this.pnlMain.Controls.Add(this.pnlThietBi);
            this.pnlMain.Controls.Add(this.pnlHienThi);
            this.pnlMain.Controls.Add(this.txtThucDon);
            this.pnlMain.Controls.Add(this.btnThemMon);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(1041, 627);
            this.pnlMain.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(601, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tổng tiền";
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeight = 21;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTD,
            this.SoLuong,
            this.Gia,
            this.ThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(600, 94);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(429, 415);
            this.dgvHoaDon.TabIndex = 38;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TenTD
            // 
            this.TenTD.DataPropertyName = "TenThucDon";
            this.TenTD.FillWeight = 120F;
            this.TenTD.HeaderText = "Tên thực đơn";
            this.TenTD.Name = "TenTD";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 80F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Animated = true;
            this.txtTongTien.BorderColor = System.Drawing.Color.Black;
            this.txtTongTien.BorderRadius = 8;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.DisabledState.Parent = this.txtTongTien;
            this.txtTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.FocusedState.Parent = this.txtTongTien;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.HoverState.Parent = this.txtTongTien;
            this.txtTongTien.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtTongTien.Location = new System.Drawing.Point(704, 527);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.PlaceholderText = "0,00 ₫";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.ShadowDecoration.Parent = this.txtTongTien;
            this.txtTongTien.Size = new System.Drawing.Size(325, 36);
            this.txtTongTien.TabIndex = 42;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblThietBi
            // 
            this.lblThietBi.AutoSize = true;
            this.lblThietBi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblThietBi.Location = new System.Drawing.Point(790, 19);
            this.lblThietBi.Name = "lblThietBi";
            this.lblThietBi.Size = new System.Drawing.Size(0, 21);
            this.lblThietBi.TabIndex = 45;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnThanhToan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.IconSize = 28;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(865, 569);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThanhToan.Size = new System.Drawing.Size(164, 46);
            this.btnThanhToan.TabIndex = 40;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Location = new System.Drawing.Point(0, 350);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.ShadowDecoration.Parent = this.pnlContainer;
            this.pnlContainer.Size = new System.Drawing.Size(594, 277);
            this.pnlContainer.TabIndex = 52;
            // 
            // pnlThanhTieuDe
            // 
            this.pnlThanhTieuDe.Controls.Add(this.cmbDanhMuc);
            this.pnlThanhTieuDe.Controls.Add(this.txtTimKiem);
            this.pnlThanhTieuDe.Controls.Add(this.lblDanhMuc);
            this.pnlThanhTieuDe.Location = new System.Drawing.Point(0, 280);
            this.pnlThanhTieuDe.Name = "pnlThanhTieuDe";
            this.pnlThanhTieuDe.ShadowDecoration.Parent = this.pnlThanhTieuDe;
            this.pnlThanhTieuDe.Size = new System.Drawing.Size(594, 70);
            this.pnlThanhTieuDe.TabIndex = 40;
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.cmbDanhMuc.BorderColor = System.Drawing.Color.Black;
            this.cmbDanhMuc.BorderRadius = 8;
            this.cmbDanhMuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanhMuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDanhMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDanhMuc.FocusedState.Parent = this.cmbDanhMuc;
            this.cmbDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDanhMuc.HoverState.Parent = this.cmbDanhMuc;
            this.cmbDanhMuc.ItemHeight = 30;
            this.cmbDanhMuc.ItemsAppearance.Parent = this.cmbDanhMuc;
            this.cmbDanhMuc.Location = new System.Drawing.Point(99, 17);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.ShadowDecoration.Parent = this.cmbDanhMuc;
            this.cmbDanhMuc.Size = new System.Drawing.Size(222, 36);
            this.cmbDanhMuc.TabIndex = 36;
            this.cmbDanhMuc.SelectionChangeCommitted += new System.EventHandler(this.cmbDanhMuc_SelectionChangeCommitted);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Animated = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderRadius = 8;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtTimKiem.Location = new System.Drawing.Point(357, 17);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(223, 36);
            this.txtTimKiem.TabIndex = 40;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDanhMuc.Location = new System.Drawing.Point(5, 25);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(88, 21);
            this.lblDanhMuc.TabIndex = 35;
            this.lblDanhMuc.Text = "Danh mục";
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.BackColor = System.Drawing.Color.Transparent;
            this.nmFoodCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmFoodCount.DisabledState.Parent = this.nmFoodCount;
            this.nmFoodCount.FocusedState.Parent = this.nmFoodCount;
            this.nmFoodCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmFoodCount.ForeColor = System.Drawing.Color.Black;
            this.nmFoodCount.Location = new System.Drawing.Point(970, 52);
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.ShadowDecoration.Parent = this.nmFoodCount;
            this.nmFoodCount.Size = new System.Drawing.Size(59, 36);
            this.nmFoodCount.TabIndex = 43;
            // 
            // pnlThietBi
            // 
            this.pnlThietBi.AutoScroll = true;
            this.pnlThietBi.Location = new System.Drawing.Point(0, 64);
            this.pnlThietBi.Name = "pnlThietBi";
            this.pnlThietBi.ShadowDecoration.Parent = this.pnlThietBi;
            this.pnlThietBi.Size = new System.Drawing.Size(594, 216);
            this.pnlThietBi.TabIndex = 50;
            // 
            // pnlHienThi
            // 
            this.pnlHienThi.Controls.Add(this.label3);
            this.pnlHienThi.Controls.Add(this.label2);
            this.pnlHienThi.Controls.Add(this.guna2Panel3);
            this.pnlHienThi.Controls.Add(this.guna2Panel2);
            this.pnlHienThi.Location = new System.Drawing.Point(0, 0);
            this.pnlHienThi.Name = "pnlHienThi";
            this.pnlHienThi.ShadowDecoration.Parent = this.pnlHienThi;
            this.pnlHienThi.Size = new System.Drawing.Size(594, 64);
            this.pnlHienThi.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(416, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Đang xử lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(149, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Trống";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Green;
            this.guna2Panel3.Location = new System.Drawing.Point(344, 16);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(66, 31);
            this.guna2Panel3.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel2.Location = new System.Drawing.Point(77, 16);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(66, 31);
            this.guna2Panel2.TabIndex = 0;
            // 
            // txtThucDon
            // 
            this.txtThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThucDon.Animated = true;
            this.txtThucDon.BorderColor = System.Drawing.Color.Black;
            this.txtThucDon.BorderRadius = 8;
            this.txtThucDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThucDon.DefaultText = "";
            this.txtThucDon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThucDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThucDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThucDon.DisabledState.Parent = this.txtThucDon;
            this.txtThucDon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThucDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThucDon.FocusedState.Parent = this.txtThucDon;
            this.txtThucDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThucDon.ForeColor = System.Drawing.Color.Black;
            this.txtThucDon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThucDon.HoverState.Parent = this.txtThucDon;
            this.txtThucDon.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtThucDon.Location = new System.Drawing.Point(760, 52);
            this.txtThucDon.Name = "txtThucDon";
            this.txtThucDon.PasswordChar = '\0';
            this.txtThucDon.PlaceholderText = "Tên thực đơn";
            this.txtThucDon.SelectedText = "";
            this.txtThucDon.ShadowDecoration.Parent = this.txtThucDon;
            this.txtThucDon.Size = new System.Drawing.Size(213, 36);
            this.txtThucDon.TabIndex = 41;
            // 
            // btnThemMon
            // 
            this.btnThemMon.FlatAppearance.BorderSize = 0;
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemMon.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThemMon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemMon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemMon.IconSize = 25;
            this.btnThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMon.Location = new System.Drawing.Point(597, 52);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThemMon.Size = new System.Drawing.Size(160, 36);
            this.btnThemMon.TabIndex = 44;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // FormThucDonUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 627);
            this.Controls.Add(this.pnlMain);
            this.Name = "FormThucDonUser";
            this.Text = "Thực đơn";
            this.Load += new System.EventHandler(this.FormThucDonUser_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.pnlThanhTieuDe.ResumeLayout(false);
            this.pnlThanhTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.pnlHienThi.ResumeLayout(false);
            this.pnlHienThi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlThietBi;
        private Guna.UI2.WinForms.Guna2Panel pnlHienThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblThietBi;
        private FontAwesome.Sharp.IconButton btnThemMon;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmFoodCount;
        private Guna.UI2.WinForms.Guna2TextBox txtThucDon;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlThanhTieuDe;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label lblDanhMuc;
    }
}