
namespace QuanLyCoffeeAndTea.FormUserFunction
{
    partial class FormSanPhamUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.txtSapPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.nmFoodCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnThemSP = new FontAwesome.Sharp.IconButton();
            this.cmbDanhMuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlThanhTieuDe = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.pnlThanhTieuDe.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHoaDon.ColumnHeadersHeight = 21;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.SoLuong,
            this.Gia,
            this.ThanhTien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(600, 71);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(429, 438);
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
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSanPham";
            this.TenSP.FillWeight = 120F;
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
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
            // btnThanhToan
            // 
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnThanhToan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.IconSize = 29;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(864, 569);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThanhToan.Size = new System.Drawing.Size(165, 46);
            this.btnThanhToan.TabIndex = 40;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtSapPham
            // 
            this.txtSapPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSapPham.Animated = true;
            this.txtSapPham.BorderColor = System.Drawing.Color.Black;
            this.txtSapPham.BorderRadius = 8;
            this.txtSapPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSapPham.DefaultText = "";
            this.txtSapPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSapPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSapPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSapPham.DisabledState.Parent = this.txtSapPham;
            this.txtSapPham.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSapPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSapPham.FocusedState.Parent = this.txtSapPham;
            this.txtSapPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSapPham.ForeColor = System.Drawing.Color.Black;
            this.txtSapPham.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSapPham.HoverState.Parent = this.txtSapPham;
            this.txtSapPham.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSapPham.Location = new System.Drawing.Point(750, 21);
            this.txtSapPham.Name = "txtSapPham";
            this.txtSapPham.PasswordChar = '\0';
            this.txtSapPham.PlaceholderText = "Tên sản phẩm";
            this.txtSapPham.SelectedText = "";
            this.txtSapPham.ShadowDecoration.Parent = this.txtSapPham;
            this.txtSapPham.Size = new System.Drawing.Size(213, 36);
            this.txtSapPham.TabIndex = 41;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.BackColor = System.Drawing.Color.Transparent;
            this.nmFoodCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmFoodCount.DisabledState.Parent = this.nmFoodCount;
            this.nmFoodCount.FocusedState.Parent = this.nmFoodCount;
            this.nmFoodCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmFoodCount.ForeColor = System.Drawing.Color.Black;
            this.nmFoodCount.Location = new System.Drawing.Point(970, 22);
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.ShadowDecoration.Parent = this.nmFoodCount;
            this.nmFoodCount.Size = new System.Drawing.Size(59, 36);
            this.nmFoodCount.TabIndex = 43;
            // 
            // btnThemSP
            // 
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemSP.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThemSP.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemSP.IconSize = 25;
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(597, 22);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThemSP.Size = new System.Drawing.Size(140, 36);
            this.btnThemSP.TabIndex = 44;
            this.btnThemSP.Text = "Thêm SP";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
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
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Location = new System.Drawing.Point(0, 71);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.ShadowDecoration.Parent = this.pnlContainer;
            this.pnlContainer.Size = new System.Drawing.Size(594, 556);
            this.pnlContainer.TabIndex = 52;
            // 
            // pnlThanhTieuDe
            // 
            this.pnlThanhTieuDe.Controls.Add(this.cmbDanhMuc);
            this.pnlThanhTieuDe.Controls.Add(this.txtTimKiem);
            this.pnlThanhTieuDe.Controls.Add(this.lblDanhMuc);
            this.pnlThanhTieuDe.Location = new System.Drawing.Point(0, 1);
            this.pnlThanhTieuDe.Name = "pnlThanhTieuDe";
            this.pnlThanhTieuDe.ShadowDecoration.Parent = this.pnlThanhTieuDe;
            this.pnlThanhTieuDe.Size = new System.Drawing.Size(594, 70);
            this.pnlThanhTieuDe.TabIndex = 40;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.dgvHoaDon);
            this.pnlMain.Controls.Add(this.txtTongTien);
            this.pnlMain.Controls.Add(this.btnThanhToan);
            this.pnlMain.Controls.Add(this.pnlContainer);
            this.pnlMain.Controls.Add(this.pnlThanhTieuDe);
            this.pnlMain.Controls.Add(this.nmFoodCount);
            this.pnlMain.Controls.Add(this.txtSapPham);
            this.pnlMain.Controls.Add(this.btnThemSP);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(1041, 627);
            this.pnlMain.TabIndex = 49;
            // 
            // FormSanPhamUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 627);
            this.Controls.Add(this.pnlMain);
            this.Name = "FormSanPhamUser";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.FormSanPhamUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.pnlThanhTieuDe.ResumeLayout(false);
            this.pnlThanhTieuDe.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private Guna.UI2.WinForms.Guna2TextBox txtSapPham;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmFoodCount;
        private FontAwesome.Sharp.IconButton btnThemSP;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label lblDanhMuc;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlThanhTieuDe;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}