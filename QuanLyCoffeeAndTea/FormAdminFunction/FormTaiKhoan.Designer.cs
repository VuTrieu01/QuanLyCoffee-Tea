
namespace QuanLyCoffeeAndTea.FormAdminFunction
{
    partial class FormTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.dgvTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.TaiKhoan = new System.Windows.Forms.Label();
            this.IDNhanVien = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.Quyen = new System.Windows.Forms.Label();
            this.MatKhau = new System.Windows.Forms.Label();
            this.cmbTenNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtQuyen = new Guna.UI2.WinForms.Guna2TextBox();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
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
            this.txtTimKiem.Location = new System.Drawing.Point(501, 33);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(366, 36);
            this.txtTimKiem.TabIndex = 93;
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
            this.btnReset.Location = new System.Drawing.Point(11, 572);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReset.Size = new System.Drawing.Size(123, 33);
            this.btnReset.TabIndex = 98;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(327, 28);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnXoa.Size = new System.Drawing.Size(120, 46);
            this.btnXoa.TabIndex = 97;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvTaiKhoan
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTaiKhoan.ColumnHeadersHeight = 21;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNV,
            this.NgaySinh,
            this.ID,
            this.GT});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTaiKhoan.Location = new System.Drawing.Point(501, 93);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(528, 522);
            this.dgvTaiKhoan.TabIndex = 100;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvTaiKhoan.ThemeStyle.ReadOnly = false;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTaiKhoan.DoubleClick += new System.EventHandler(this.dgvTaiKhoan_DoubleClick);
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
            this.btnCapNhat.Location = new System.Drawing.Point(157, 28);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCapNhat.Size = new System.Drawing.Size(153, 46);
            this.btnCapNhat.TabIndex = 96;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(873, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(156, 46);
            this.btnTimKiem.TabIndex = 94;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnThem.Location = new System.Drawing.Point(19, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThem.Size = new System.Drawing.Size(123, 46);
            this.btnThem.TabIndex = 95;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Animated = true;
            this.txtMatKhau.BorderColor = System.Drawing.Color.Black;
            this.txtMatKhau.BorderRadius = 8;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.Parent = this.txtMatKhau;
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.FocusedState.Parent = this.txtMatKhau;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.HoverState.Parent = this.txtMatKhau;
            this.txtMatKhau.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtMatKhau.Location = new System.Drawing.Point(161, 255);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PlaceholderText = "Mật Khẩu";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.ShadowDecoration.Parent = this.txtMatKhau;
            this.txtMatKhau.Size = new System.Drawing.Size(292, 36);
            this.txtMatKhau.TabIndex = 92;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.AutoSize = true;
            this.TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoan.Location = new System.Drawing.Point(13, 170);
            this.TaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(89, 20);
            this.TaiKhoan.TabIndex = 87;
            this.TaiKhoan.Text = "Tài Khoản";
            // 
            // IDNhanVien
            // 
            this.IDNhanVien.AutoSize = true;
            this.IDNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNhanVien.Location = new System.Drawing.Point(15, 364);
            this.IDNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDNhanVien.Name = "IDNhanVien";
            this.IDNhanVien.Size = new System.Drawing.Size(121, 20);
            this.IDNhanVien.TabIndex = 90;
            this.IDNhanVien.Text = "Tên nhân viên";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Animated = true;
            this.txtTaiKhoan.BorderColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.BorderRadius = 8;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.DefaultText = "";
            this.txtTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.DisabledState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.FocusedState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.HoverState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtTaiKhoan.Location = new System.Drawing.Point(161, 162);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.PlaceholderText = "Tài Khoản";
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.ShadowDecoration.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.Size = new System.Drawing.Size(292, 36);
            this.txtTaiKhoan.TabIndex = 91;
            // 
            // Quyen
            // 
            this.Quyen.AutoSize = true;
            this.Quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quyen.Location = new System.Drawing.Point(12, 465);
            this.Quyen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quyen.Name = "Quyen";
            this.Quyen.Size = new System.Drawing.Size(60, 20);
            this.Quyen.TabIndex = 89;
            this.Quyen.Text = "Quyền";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau.Location = new System.Drawing.Point(15, 263);
            this.MatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(83, 20);
            this.MatKhau.TabIndex = 88;
            this.MatKhau.Text = "Mật khẩu";
            // 
            // cmbTenNV
            // 
            this.cmbTenNV.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenNV.BorderColor = System.Drawing.Color.Black;
            this.cmbTenNV.BorderRadius = 8;
            this.cmbTenNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenNV.FocusedState.Parent = this.cmbTenNV;
            this.cmbTenNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTenNV.HoverState.Parent = this.cmbTenNV;
            this.cmbTenNV.ItemHeight = 30;
            this.cmbTenNV.ItemsAppearance.Parent = this.cmbTenNV;
            this.cmbTenNV.Location = new System.Drawing.Point(161, 356);
            this.cmbTenNV.Name = "cmbTenNV";
            this.cmbTenNV.ShadowDecoration.Parent = this.cmbTenNV;
            this.cmbTenNV.Size = new System.Drawing.Size(292, 36);
            this.cmbTenNV.TabIndex = 101;
            this.cmbTenNV.SelectionChangeCommitted += new System.EventHandler(this.cmbTenNV_SelectionChangeCommitted);
            // 
            // txtQuyen
            // 
            this.txtQuyen.Animated = true;
            this.txtQuyen.BorderColor = System.Drawing.Color.Black;
            this.txtQuyen.BorderRadius = 8;
            this.txtQuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuyen.DefaultText = "";
            this.txtQuyen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuyen.DisabledState.Parent = this.txtQuyen;
            this.txtQuyen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuyen.Enabled = false;
            this.txtQuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuyen.FocusedState.Parent = this.txtQuyen;
            this.txtQuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuyen.ForeColor = System.Drawing.Color.Black;
            this.txtQuyen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuyen.HoverState.Parent = this.txtQuyen;
            this.txtQuyen.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtQuyen.Location = new System.Drawing.Point(161, 457);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.PasswordChar = '\0';
            this.txtQuyen.PlaceholderText = "";
            this.txtQuyen.SelectedText = "";
            this.txtQuyen.ShadowDecoration.Parent = this.txtQuyen;
            this.txtQuyen.Size = new System.Drawing.Size(292, 36);
            this.txtQuyen.TabIndex = 102;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "UserID";
            this.TenNV.HeaderText = "Tài Khoản";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "Password";
            this.NgaySinh.HeaderText = "Mật Khẩu";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "TenNV";
            this.ID.FillWeight = 130F;
            this.ID.HeaderText = "Tên chủ tài khoản";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // GT
            // 
            this.GT.DataPropertyName = "ChucVu";
            this.GT.FillWeight = 90F;
            this.GT.HeaderText = "Quyền";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 627);
            this.Controls.Add(this.txtQuyen);
            this.Controls.Add(this.cmbTenNV);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.TaiKhoan);
            this.Controls.Add(this.IDNhanVien);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.Quyen);
            this.Controls.Add(this.MatKhau);
            this.Name = "FormTaiKhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnXoa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTaiKhoan;
        private FontAwesome.Sharp.IconButton btnCapNhat;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private System.Windows.Forms.Label TaiKhoan;
        private System.Windows.Forms.Label IDNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtTaiKhoan;
        private System.Windows.Forms.Label Quyen;
        private System.Windows.Forms.Label MatKhau;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
    }
}