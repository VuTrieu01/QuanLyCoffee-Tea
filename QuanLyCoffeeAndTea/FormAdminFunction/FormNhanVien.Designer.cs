
namespace QuanLyCoffeeAndTea
{
    partial class FormNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.NhanVienID = new System.Windows.Forms.Label();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.txtTennhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.TênNV = new System.Windows.Forms.Label();
            this.ChucVu = new System.Windows.Forms.Label();
            this.NgaSinh = new System.Windows.Forms.Label();
            this.GioiTinh = new System.Windows.Forms.Label();
            this.SDT = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.ChucVuNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.btnReset.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 30;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(12, 582);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReset.Size = new System.Drawing.Size(124, 33);
            this.btnReset.TabIndex = 68;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BackColor = System.Drawing.Color.White;
            this.dtpNgaySinh.BorderRadius = 8;
            this.dtpNgaySinh.BorderThickness = 1;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.CheckedState.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaySinh.HoverState.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.Location = new System.Drawing.Point(184, 265);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.ShadowDecoration.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.Size = new System.Drawing.Size(245, 36);
            this.dtpNgaySinh.TabIndex = 67;
            this.dtpNgaySinh.Value = new System.DateTime(2001, 3, 10, 0, 0, 0, 0);
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cmbChucVu.BorderColor = System.Drawing.Color.Black;
            this.cmbChucVu.BorderRadius = 8;
            this.cmbChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbChucVu.FocusedState.Parent = this.cmbChucVu;
            this.cmbChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbChucVu.HoverState.Parent = this.cmbChucVu;
            this.cmbChucVu.ItemHeight = 30;
            this.cmbChucVu.ItemsAppearance.Parent = this.cmbChucVu;
            this.cmbChucVu.Location = new System.Drawing.Point(184, 498);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.ShadowDecoration.Parent = this.cmbChucVu;
            this.cmbChucVu.Size = new System.Drawing.Size(245, 36);
            this.cmbChucVu.TabIndex = 66;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cmbGioiTinh.BorderColor = System.Drawing.Color.Black;
            this.cmbGioiTinh.BorderRadius = 8;
            this.cmbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.FocusedState.Parent = this.cmbGioiTinh;
            this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGioiTinh.HoverState.Parent = this.cmbGioiTinh;
            this.cmbGioiTinh.ItemHeight = 30;
            this.cmbGioiTinh.ItemsAppearance.Parent = this.cmbGioiTinh;
            this.cmbGioiTinh.Location = new System.Drawing.Point(184, 344);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.ShadowDecoration.Parent = this.cmbGioiTinh;
            this.cmbGioiTinh.Size = new System.Drawing.Size(245, 36);
            this.cmbGioiTinh.TabIndex = 65;
            // 
            // NhanVienID
            // 
            this.NhanVienID.AutoSize = true;
            this.NhanVienID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanVienID.Location = new System.Drawing.Point(30, 123);
            this.NhanVienID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NhanVienID.Name = "NhanVienID";
            this.NhanVienID.Size = new System.Drawing.Size(121, 20);
            this.NhanVienID.TabIndex = 53;
            this.NhanVienID.Text = "ID Nhân Viên ";
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(328, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnXoa.Size = new System.Drawing.Size(110, 46);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Animated = true;
            this.txtSDT.BorderColor = System.Drawing.Color.Black;
            this.txtSDT.BorderRadius = 8;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSDT.Location = new System.Drawing.Point(184, 421);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "Số Điện Thoại";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(245, 36);
            this.txtSDT.TabIndex = 64;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapNhat.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnCapNhat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapNhat.IconSize = 30;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(158, 20);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCapNhat.Size = new System.Drawing.Size(150, 46);
            this.btnCapNhat.TabIndex = 61;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Animated = true;
            this.txtTennhanvien.BorderColor = System.Drawing.Color.Black;
            this.txtTennhanvien.BorderRadius = 8;
            this.txtTennhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTennhanvien.DefaultText = "";
            this.txtTennhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTennhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTennhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTennhanvien.DisabledState.Parent = this.txtTennhanvien;
            this.txtTennhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTennhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTennhanvien.FocusedState.Parent = this.txtTennhanvien;
            this.txtTennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTennhanvien.ForeColor = System.Drawing.Color.Black;
            this.txtTennhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTennhanvien.HoverState.Parent = this.txtTennhanvien;
            this.txtTennhanvien.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtTennhanvien.Location = new System.Drawing.Point(184, 189);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.PasswordChar = '\0';
            this.txtTennhanvien.PlaceholderText = "Tên Nhân Viên";
            this.txtTennhanvien.SelectedText = "";
            this.txtTennhanvien.ShadowDecoration.Parent = this.txtTennhanvien;
            this.txtTennhanvien.Size = new System.Drawing.Size(245, 36);
            this.txtTennhanvien.TabIndex = 63;
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(12, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThem.Size = new System.Drawing.Size(124, 46);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // TênNV
            // 
            this.TênNV.AutoSize = true;
            this.TênNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TênNV.Location = new System.Drawing.Point(30, 197);
            this.TênNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TênNV.Name = "TênNV";
            this.TênNV.Size = new System.Drawing.Size(127, 20);
            this.TênNV.TabIndex = 54;
            this.TênNV.Text = "Tên Nhân Viên";
            // 
            // ChucVu
            // 
            this.ChucVu.AutoSize = true;
            this.ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVu.Location = new System.Drawing.Point(30, 506);
            this.ChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Size = new System.Drawing.Size(77, 20);
            this.ChucVu.TabIndex = 58;
            this.ChucVu.Text = "Chức Vụ";
            // 
            // NgaSinh
            // 
            this.NgaSinh.AutoSize = true;
            this.NgaSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaSinh.Location = new System.Drawing.Point(30, 273);
            this.NgaSinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NgaSinh.Name = "NgaSinh";
            this.NgaSinh.Size = new System.Drawing.Size(90, 20);
            this.NgaSinh.TabIndex = 55;
            this.NgaSinh.Text = "Ngày Sinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSize = true;
            this.GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh.Location = new System.Drawing.Point(30, 352);
            this.GioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(80, 20);
            this.GioiTinh.TabIndex = 56;
            this.GioiTinh.Text = "Giới Tính";
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT.Location = new System.Drawing.Point(30, 429);
            this.SDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(44, 20);
            this.SDT.TabIndex = 57;
            this.SDT.Text = "SĐT";
            // 
            // txtTimKiem
            // 
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
            this.txtTimKiem.Location = new System.Drawing.Point(461, 20);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tên nhân viên";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(407, 36);
            this.txtTimKiem.TabIndex = 44;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 30;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(874, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(155, 46);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // ChucVuNV
            // 
            this.ChucVuNV.DataPropertyName = "ChucVu";
            this.ChucVuNV.HeaderText = "Chức Vụ";
            this.ChucVuNV.MinimumWidth = 6;
            this.ChucVuNV.Name = "ChucVuNV";
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SDT";
            this.SoDT.HeaderText = "SĐT";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GioiTinh";
            this.GT.HeaderText = "Giới Tinh";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "NhanVienID";
            this.ID.FillWeight = 40F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // dgvNhanVien
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvNhanVien.ColumnHeadersHeight = 21;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenNV,
            this.NgaySinh,
            this.GT,
            this.SoDT,
            this.ChucVuNV});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(461, 67);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(568, 534);
            this.dgvNhanVien.TabIndex = 59;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvNhanVien.ThemeStyle.ReadOnly = false;
            this.dgvNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhanVien.ThemeStyle.RowsStyle.Height = 22;
            this.dgvNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhanVien.DoubleClick += new System.EventHandler(this.dgvNhanVien_DoubleClick);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 627);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.NhanVienID);
            this.Controls.Add(this.txtTennhanvien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.GioiTinh);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.NgaSinh);
            this.Controls.Add(this.ChucVu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.TênNV);
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnReset;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private Guna.UI2.WinForms.Guna2ComboBox cmbChucVu;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label NhanVienID;
        private FontAwesome.Sharp.IconButton btnXoa;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private FontAwesome.Sharp.IconButton btnCapNhat;
        private Guna.UI2.WinForms.Guna2TextBox txtTennhanvien;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Label TênNV;
        private System.Windows.Forms.Label ChucVu;
        private System.Windows.Forms.Label NgaSinh;
        private System.Windows.Forms.Label GioiTinh;
        private System.Windows.Forms.Label SDT;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVuNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhanVien;
    }
}