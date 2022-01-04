using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using QuanLyCoffeeAndTea.FormUserFunction;
using QuanLyCoffeeAndTea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.EntityFramework.Plus;

namespace QuanLyCoffeeAndTea.FormUserFunction
{
    public partial class FormSanPhamUser : Form
    {
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        private Size sizePic = new Size(100, 100);
        private string currKey = "";
        private int all = -1;
        private int nhanVienID = FormLogin.info.NhanVienID;
        int luuId = 0;
        float luuGia = 0;
        int luuHD = 0;

        public FormSanPhamUser()
        {
            InitializeComponent();
        }

        public void resetData()
        {
            txtSapPham.Text = "";
            nmFoodCount.Value = 0;

            dgvHoaDon.DataSource = null;
            btnThemSP.Enabled = false;
            btnThanhToan.Enabled = false;
        }

        public void loadData(int type)
        {
            pnlContainer.Controls.Clear();
            var query = contextDB.SANPHAMs;
            if (!currKey.Equals(""))
            {
                setLayout(query.Where(x => x.TenSanPham.Contains(currKey)).ToList());
                return;
            }
            if (type.Equals(this.all))
                setLayout(query.ToList());
            else
                setLayout(query.Where(x => x.DanhMucSPID == type).ToList());
        }

        //San Pham
        private void setLayout(List<SANPHAM> query)
        {
            string button = "CHỌN SẢN PHẨM";
            int height = 10, width = 10, count = 0;
            query.ForEach(x =>
            {
                if (count == 4)
                {
                    height += 250;
                    width = 10;
                    count = 0;
                }
                setPicture(x.SanPhamID, width, height, x.TenSanPham, x.QuyCach, (double)x.Gia, button);
                width += 150;
                count++;
            });
        }

        private void setPicture(int id, int width, int height, string title, string quyCach, double gia, string button)
        {
            Guna2PictureBox picture = new Guna2PictureBox();
            picture.Cursor = Cursors.Hand;
            picture.BorderRadius = 5;
            picture.ImageLocation = string.Format(@"..\..\Images\SanPham\" + id + ".jpg");
            picture.ImageRotate = 0F;
            picture.Location = new Point(width, height);
            picture.Name = "picture" + id;
            picture.ShadowDecoration.Parent = picture;
            picture.Size = sizePic;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabStop = false;
            picture.ShadowDecoration.BorderRadius = 10;
            picture.ShadowDecoration.Color = Color.FromArgb(229, 9, 20);
            picture.ShadowDecoration.Depth = 10;
            picture.ShadowDecoration.Enabled = true;
            this.pnlContainer.Controls.Add(picture);
            setLabel(id, title, picture);
            setQuyCach(id, quyCach, picture);
            setLabelGia(id, gia, picture);
            setButton(id, button, title, picture);
        }

        private void setLabel(int id, string label, Guna2PictureBox picture)
        {
            Guna2HtmlLabel lblTitle = new Guna2HtmlLabel();
            lblTitle.Text = label;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            int locationName = picture.Location.X + (picture.ClientSize.Width / 2 - lblTitle.Size.Width / 2);
            lblTitle.Location = new Point(locationName, picture.Location.Y + 105);
            lblTitle.Name = "name" + id;
            lblTitle.AutoSize = true;
            lblTitle.MaximumSize = new Size(150, 0);
            lblTitle.TextAlignment = ContentAlignment.MiddleCenter;
            lblTitle.Cursor = Cursors.Hand;
            this.pnlContainer.Controls.Add(lblTitle);
        }

        private void setQuyCach(int id, string quyCach, Guna2PictureBox picture)
        {
            Guna2HtmlLabel lblTitle = new Guna2HtmlLabel();
            lblTitle.Text = quyCach;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            int locationName = picture.Location.X + (picture.ClientSize.Width / 2 - lblTitle.Size.Width / 2);
            lblTitle.Location = new Point(locationName, picture.Location.Y + 136);
            lblTitle.Name = "name" + id;
            lblTitle.AutoSize = true;
            lblTitle.MaximumSize = new Size(150, 0);
            lblTitle.TextAlignment = ContentAlignment.MiddleCenter;
            lblTitle.Cursor = Cursors.Hand;
            this.pnlContainer.Controls.Add(lblTitle);
        }

        private void setLabelGia(int id, double label, Guna2PictureBox picture)
        {
            Guna2HtmlLabel lblTitle = new Guna2HtmlLabel();
            lblTitle.Text = Convert.ToString(label) + " đ";
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = Color.Green;
            int locationName = picture.Location.X + (picture.ClientSize.Width / 2 - lblTitle.Size.Width / 2);
            lblTitle.Location = new Point(locationName, picture.Location.Y + 156);
            lblTitle.Name = "gia" + id;
            lblTitle.AutoSize = true;
            lblTitle.MaximumSize = new Size(150, 0);
            lblTitle.TextAlignment = ContentAlignment.MiddleCenter;
            lblTitle.Cursor = Cursors.Hand;
            this.pnlContainer.Controls.Add(lblTitle);
        }

        private void setButton(int id, string buttonChon, string label, Guna2PictureBox picture)
        {
            IconButton button = new IconButton();
            button.Text = buttonChon;
            button.BackColor = Color.White;
            button.Font = new Font("Segoe UI", 9F);
            button.ForeColor = Color.Green;
            int locationName = picture.Location.X + 4;
            button.Location = new Point(locationName, picture.Location.Y + 181);
            button.Name = "chọn hàng" + id;
            button.AutoSize = true;
            button.MaximumSize = new Size(100, 0);
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.Cursor = Cursors.Hand;
            button.Click += btnChonMon_Click;
            button.Tag = id;
            this.pnlContainer.Controls.Add(button);
        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {
            int id = (int)(sender as IconButton).Tag;
            var query = contextDB.SANPHAMs.FirstOrDefault(x => x.SanPhamID == id);
            luuId = id;
            luuGia = (float)query.Gia;
            btnThemSP.Enabled = true;
            saveData(query.TenSanPham);
        }

        private void saveData(string label)
        {
            txtSapPham.Text = label;
        }

        private void cmbDanhMuc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            loadData((int)cmbDanhMuc.SelectedValue);
        }

        //Show Bill
        private void ShowBill()
        {
            var query = contextDB.CHITIETHOADONs;
            dgvHoaDon.DataSource = query.OrderByDescending(x => x.SanPhamID)
                .Where(x => x.HoaDonID == luuHD && x.HOADON.TrangThai == false)
                .Select(x => new
                {
                    x.SANPHAM.TenSanPham,
                    x.SoLuong,
                    x.SANPHAM.Gia,
                    x.ThanhTien
                }).ToList();

            float tongTien = 0;
            tongTien = (float)query.AsEnumerable()
                .Where(x => x.SanPhamID == luuId && x.HOADON.TrangThai == false)
                .Sum(x => x.ThanhTien);
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = tongTien.ToString("c", culture);
            if (txtTongTien.Text != "0,00 ₫")
                btnThanhToan.Enabled = true;
            else
                btnThanhToan.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            currKey = key;
            loadData(all);
            currKey = "";
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            HOADON hd = new HOADON();
            CHITIETHOADON cthd = new CHITIETHOADON();
            int sanPhamID = luuId;
            int count = (int)nmFoodCount.Value;
            float gia = luuGia;

            var query = contextDB.HOADONs
                .FirstOrDefault(x => x.HoaDonID == luuHD && x.TrangThai == false);

            var td = contextDB.CHITIETHOADONs
                .FirstOrDefault(x => x.SanPhamID == sanPhamID && x.HOADON.TrangThai == false);

            if (query == null)
            {
                if (nmFoodCount.Value == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!!!");
                }
                else
                {
                    hd.TrangThai = false;
                    contextDB.HOADONs.Add(hd);
                    contextDB.SaveChanges();

                    int maxIDHD = contextDB.HOADONs.Max(p => p.HoaDonID);
                    cthd.HoaDonID = maxIDHD;
                    cthd.SanPhamID = sanPhamID;
                    cthd.NhanVienID = nhanVienID;
                    cthd.SoLuong = count;
                    cthd.ThanhTien = count * gia;
                    contextDB.CHITIETHOADONs.Add(cthd);
                    contextDB.SaveChanges();
                    luuHD = maxIDHD;
                    MessageBox.Show("Thêm thành công");
                    ShowBill();
                }
            }
            else
            {
                if (td == null)
                {
                    if (nmFoodCount.Value == 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!!!");
                    }
                    else
                    {
                        cthd.HoaDonID = query.HoaDonID;
                        cthd.SanPhamID = sanPhamID;
                        cthd.NhanVienID = nhanVienID;
                        cthd.SoLuong = count;
                        cthd.ThanhTien = count * gia;
                        contextDB.CHITIETHOADONs.Add(cthd);
                        contextDB.SaveChanges();
                        MessageBox.Show("Thêm thực đơn mới thành công");
                        ShowBill();
                    }
                }
                else
                {
                    if (nmFoodCount.Value == 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!!!");
                    }
                    else
                    {
                        int a = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString());
                        int slMoi = a + count;
                        float thanhTienMoi = slMoi * gia;
                        contextDB.CHITIETHOADONs
                            .Where(x => x.SanPhamID == sanPhamID && x.HOADON.TrangThai == false)
                            .Update(i => new CHITIETHOADON
                            {
                                SoLuong = slMoi,
                                ThanhTien = thanhTienMoi
                            });
                        MessageBox.Show("Thêm thành công");
                        ShowBill();
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                string format = "yyyy/MM/dd HH:mm:ss";
                DateTime now = DateTime.Now;
                string s = now.ToString(format);

                contextDB.HOADONs
                    .Where(x => x.HoaDonID == luuHD && x.TrangThai == false)
                    .Update(i => new HOADON
                    {
                        NgayHD = Convert.ToDateTime(s),
                        TrangThai = true
                    });
                resetData();
            }
        }

        private void FormSanPhamUser_Load(object sender, EventArgs e)
        {
            //Gán danh mục vào comboBox
            List<DANHMUCSANPHAM> listDanhMuc = contextDB.DANHMUCSANPHAMs.ToList();
            cmbDanhMuc.DataSource = listDanhMuc;
            cmbDanhMuc.ValueMember = "DanhMucSPID";
            cmbDanhMuc.DisplayMember = "TenDM";
            DataTable table = new DataTable();
            table.Columns.Add("DanhMucSPID", typeof(int));
            table.Columns.Add("TenDM", typeof(string));

            listDanhMuc.ForEach(x =>
            {
                var rowDM = table.NewRow();
                rowDM["DanhMucSPID"] = x.DanhMucSPID;
                rowDM["TenDM"] = x.TenDM;
                table.Rows.Add(rowDM);
            });

            DataRow row = table.NewRow();
            row["DanhMucSPID"] = all;
            row["TenDM"] = "Tất cả";

            table.Rows.InsertAt(row, 0);
            cmbDanhMuc.DataSource = table;

            resetData();
            loadData(all);
        }
    }
}
