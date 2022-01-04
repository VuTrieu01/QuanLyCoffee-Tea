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

namespace QuanLyCoffeeAndTea
{
    public partial class FormThucDonUser : Form
    {
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        private Form activeForm;
        private Size sizePic = new Size(100, 100);
        private string currKey = "";
        private int all = -1;
        private int nhanVienID = FormLogin.info.NhanVienID;
        int luuId = 0;
        float luuGia = 0;
        int luuTB = 0;

        public FormThucDonUser()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            FormThucDonUser thucDonUser = new FormThucDonUser();
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = thucDonUser;
            thucDonUser.TopLevel = false;
            thucDonUser.FormBorderStyle = FormBorderStyle.None;
            thucDonUser.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(thucDonUser);
            pnlMain.Tag = thucDonUser;
            thucDonUser.BringToFront();
            thucDonUser.Show();
        }

        public void resetData()
        {
            txtThucDon.Text = "";
            nmFoodCount.Value = 0;
            lblThietBi.Text = "";

            dgvHoaDon.DataSource = null;

            pnlThanhTieuDe.Visible = false;
            pnlContainer.Visible = false;
            btnThemMon.Enabled = false;
            btnThanhToan.Enabled = false;
        }

        public void loadData(int type)
        {
            pnlContainer.Controls.Clear();
            var query = contextDB.THUCDONs;
            if (!currKey.Equals(""))
            {
                setLayout(query.Where(x => x.TenThucDon.Contains(currKey)).ToList());
                return;
            }
            if (type.Equals(this.all))
                setLayout(query.ToList());
            else
                setLayout(query.Where(x => x.DanhMucTDID == type).ToList());
        }

        //Thuc Don
        private void setLayout(List<THUCDON> query)
        {
            string button = "CHỌN MÓN";
            int height = 10, width = 10, count = 0;
            query.ForEach(x =>
            {
                if (count == 4)
                {
                    height += 210;
                    width = 10;
                    count = 0;
                }
                setPicture(x.ThucDonID, width, height, x.TenThucDon, (double)x.Gia, button);
                width += 150;
                count++;
            });
        }

        private void setPicture(int id, int width, int height, string title, double gia, string button)
        {
            Guna2PictureBox picture = new Guna2PictureBox();
            picture.Cursor = Cursors.Hand;
            picture.BorderRadius = 5;
            picture.ImageLocation = string.Format(@"..\..\Images\ThucDon\" + id + ".jpg");
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
            lblTitle.Location = new Point(locationName, picture.Location.Y + 100);
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
            lblTitle.Location = new Point(locationName, picture.Location.Y + 120);
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
            int locationName = picture.Location.X + 7;
            button.Location = new Point(locationName, picture.Location.Y + 145);
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
            var query = contextDB.THUCDONs.FirstOrDefault(x => x.ThucDonID == id);
            luuId = id;
            luuGia = (float)query.Gia;
            btnThemMon.Enabled = true;
            saveData(query.TenThucDon);
        }

        private void saveData(string label)
        {
            txtThucDon.Text = label;
        }

        private void cmbDanhMuc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            loadData((int)cmbDanhMuc.SelectedValue);
        }

        //ThietBi
        public void loadThietBi()
        {
            pnlThietBi.Controls.Clear();
            var query = contextDB.THIETBIs.ToList();
            query.Clear();
            query = contextDB.THIETBIs.ToList();
            int height = 10, width = 10, count = 0;
            query.ForEach(x =>
            {
                if (count == 6)
                {
                    height += 100;
                    width = 10;
                    count = 0;
                }
                setThietBi(x.ThietBiID, width, height, x.TrangThai);
                width += 98;
                count++;
            });
        }

        private void setThietBi(int idd, int width, int height, bool trangThai)
        {
            IconButton button = new IconButton();
            button.Cursor = Cursors.Hand;
            button.Text = "Thiết bị " + idd;
            if (trangThai == false)
                button.BackColor = Color.LightGray;
            else
                button.BackColor = Color.Green;
            button.Font = new Font("Segoe UI", 9F);
            button.ForeColor = Color.White;
            button.Location = new Point(width, height);
            button.Name = "ThietBi" + idd;
            button.AutoSize = true;
            button.MaximumSize = new Size(90, 0);
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.Click += btn_Click;
            button.Tag = idd;
            this.pnlThietBi.Controls.Add(button);
        }

        //Show Bill
        private void btn_Click(object sender, EventArgs e)
        {
            int idd = (int)(sender as IconButton).Tag;
            luuTB = idd;
            pnlContainer.Visible = true;
            pnlThanhTieuDe.Visible = true;
            lblThietBi.Text = "Thiết bị " + Convert.ToString(idd);
            ShowBill(idd, false);
        }

        private void ShowBill(int idd, bool tt)
        {
            var query = contextDB.CHITIETHOADONs;
            dgvHoaDon.DataSource = query.OrderByDescending(x => x.HOADON.ThietBiID)
                .Where(x => x.HOADON.ThietBiID == idd)
                .Where(x=> x.HOADON.TrangThai == tt)
                .Select(x => new
                {
                    x.THUCDON.TenThucDon,
                    x.SoLuong,
                    x.THUCDON.Gia,
                    x.ThanhTien
                }).ToList();

            float tongTien = 0;
            tongTien = (float)query.AsEnumerable()
                .Where(x => x.HOADON.ThietBiID == idd && x.HOADON.TrangThai == false)
                .Sum(x => x.ThanhTien);
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = tongTien.ToString("c", culture);
            if(txtTongTien.Text != "0,00 ₫")
                btnThanhToan.Enabled = true;
            else
                btnThanhToan.Enabled = false;
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            HOADON hd = new HOADON();
            CHITIETHOADON cthd = new CHITIETHOADON();
            int thucDonID = luuId;
            int count = (int)nmFoodCount.Value;
            float gia = luuGia;
            var query = contextDB.HOADONs
                .FirstOrDefault(x => x.ThietBiID == luuTB && x.TrangThai == false);
            var td = contextDB.CHITIETHOADONs
                .FirstOrDefault(x => x.HOADON.ThietBiID == luuTB && x.HOADON.TrangThai == false && x.ThucDonID == thucDonID);

            if (query == null)
            {
                if (nmFoodCount.Value == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!!!");
                }
                else
                {
                    hd.ThietBiID = luuTB;
                    hd.TrangThai = false;
                    contextDB.HOADONs.Add(hd);
                    contextDB.SaveChanges();

                    contextDB.THIETBIs
                            .Where(x => x.ThietBiID == luuTB && x.TrangThai == false)
                            .Update(i => new THIETBI
                            {
                                TrangThai = true
                            });

                    int maxIDHD = contextDB.HOADONs.Max(p => p.HoaDonID);
                    cthd.HoaDonID = maxIDHD;
                    cthd.ThucDonID = thucDonID;
                    cthd.NhanVienID = nhanVienID;
                    cthd.SoLuong = count;
                    cthd.ThanhTien = count * gia;
                    contextDB.CHITIETHOADONs.Add(cthd);
                    contextDB.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    ShowBill(luuTB, false);
                    Reset();
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
                        cthd.ThucDonID = thucDonID;
                        cthd.NhanVienID = nhanVienID;
                        cthd.SoLuong = count;
                        cthd.ThanhTien = count * gia;
                        contextDB.CHITIETHOADONs.Add(cthd);
                        contextDB.SaveChanges();
                        MessageBox.Show("Thêm thực đơn mới thành công");
                        ShowBill(luuTB, false);
                        Reset();
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
                            .Where(x => x.ThucDonID == thucDonID && x.HOADON.ThietBiID == luuTB && x.HOADON.TrangThai == false)
                            .Update(i => new CHITIETHOADON
                            {
                                SoLuong = slMoi,
                                ThanhTien = thanhTienMoi
                            });
                        MessageBox.Show("Thêm thành công");
                        ShowBill(luuTB, false);
                        Reset();
                    }
                }
            }
        }

        private void FormThucDonUser_Load(object sender, EventArgs e)
        {
            //Gán danh mục vào comboBox
            List<DANHMUCTHUCDON> listDanhMuc = contextDB.DANHMUCTHUCDONs.ToList();
            cmbDanhMuc.DataSource = listDanhMuc;
            cmbDanhMuc.ValueMember = "DanhMucTDID";
            cmbDanhMuc.DisplayMember = "TenDM";
            DataTable table = new DataTable();
            table.Columns.Add("DanhMucTDID", typeof(int));
            table.Columns.Add("TenDM", typeof(string));

            listDanhMuc.ForEach(x =>
            {
                var rowDM = table.NewRow();
                rowDM["DanhMucTDID"] = x.DanhMucTDID;
                rowDM["TenDM"] = x.TenDM;
                table.Rows.Add(rowDM);
            });

            DataRow row = table.NewRow();
            row["DanhMucTDID"] = all;
            row["TenDM"] = "Tất cả";

            table.Rows.InsertAt(row, 0);
            cmbDanhMuc.DataSource = table;

            resetData();
            loadThietBi();
            loadData(all);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                string format = "yyyy/MM/dd HH:mm:ss";
                DateTime now = DateTime.Now;
                string s = now.ToString(format);

                contextDB.THIETBIs
                     .Where(x => x.ThietBiID == luuTB && x.TrangThai == true)
                     .Update(i => new THIETBI
                     {
                         TrangThai = false
                     });

                contextDB.HOADONs
                    .Where(x => x.ThietBiID == luuTB && x.TrangThai == false)
                    .Update(i => new HOADON
                    {
                        NgayHD = Convert.ToDateTime(s),
                        TrangThai = true
                    });
                resetData();
                Reset();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            currKey = key;
            loadData(all);
            currKey = "";
        }
    }
}
