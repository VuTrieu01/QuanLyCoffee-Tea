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
        private Size sizePic = new Size(240, 240);
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

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            if (btnThucDon.Text == "Thực đơn")
            {
                //Thuc don
                pnlContainer.Visible = true;
                pnlThanhTieuDe.Visible = true;

                //Thiet bi
                btnThucDon.Text = "Thiết bị";
            
            }
            else
            {
                //Thuc don
                btnThucDon.Text = "Thực đơn";
                btnThucDon.Enabled = false;
                pnlContainer.Visible = false;
                pnlThanhTieuDe.Visible = false;
            
            }
        }

        public void resetData()
        {
            txtThucDon.Text = "";
            nmFoodCount.Value = 0;
            lblThietBi.Text = "";

            dgvHoaDon.DataSource = null;

            pnlThanhTieuDe.Visible = false;
            pnlContainer.Visible = false;

            btnThucDon.Enabled = false;
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
                setLayout(query.Where(x => x.DanhMucID == type).ToList());
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
                    height += 410;
                    width = 10;
                    count = 0;
                }
                setPicture(x.ThucDonID, width, height, x.TenThucDon, (double)x.Gia, button);
                width += 260;
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
            lblTitle.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            int locationName = picture.Location.X + (picture.ClientSize.Width / 2 - lblTitle.Size.Width / 2);
            lblTitle.Location = new Point(locationName, picture.Location.Y + 250);
            lblTitle.Name = "name" + id;
            lblTitle.AutoSize = true;
            lblTitle.MaximumSize = new Size(280, 0);
            lblTitle.TextAlignment = ContentAlignment.MiddleCenter;
            lblTitle.Cursor = Cursors.Hand;
            this.pnlContainer.Controls.Add(lblTitle);
        }

        private void setLabelGia(int id, double label, Guna2PictureBox picture)
        {
            Guna2HtmlLabel lblTitle = new Guna2HtmlLabel();
            lblTitle.Text = Convert.ToString(label) + " đ";
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = Color.Green;
            int locationName = picture.Location.X + (picture.ClientSize.Width / 2 - lblTitle.Size.Width / 2);
            lblTitle.Location = new Point(locationName, picture.Location.Y + 290);
            lblTitle.Name = "gia" + id;
            lblTitle.AutoSize = true;
            lblTitle.MaximumSize = new Size(280, 0);
            lblTitle.TextAlignment = ContentAlignment.MiddleCenter;
            lblTitle.Cursor = Cursors.Hand;
            this.pnlContainer.Controls.Add(lblTitle);
        }

        private void setButton(int id, string buttonChon, string label, Guna2PictureBox picture)
        {
            IconButton button = new IconButton();
            button.Text = buttonChon;
            button.BackColor = Color.White;
            button.Font = new Font("Segoe UI", 20F);
            button.ForeColor = Color.Green;
            int locationName = picture.Location.X + 25;
            button.Location = new Point(locationName, picture.Location.Y + 335);
            button.Name = "chọn hàng" + id;
            button.AutoSize = true;
            button.MaximumSize = new Size(280, 0);
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
            btnThucDon.Enabled = true;
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
            if (cmbDanhMuc.SelectedIndex != all)
            {
                loadData(cmbDanhMuc.SelectedIndex);
               
            }
            else
            {
                loadData(all);
                MessageBox.Show("sda");
            }
        }

        //ThietBi
        public void loadThietBi()
        {
            pnlThietBi.Controls.Clear();
            var query = contextDB.THIETBIs.ToList();
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
                test.Text = Convert.ToString(x.TrangThai);
                width += 98;
                count++;
            });
            MessageBox.Show("fasfsaf");
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
            button.Font = new Font("Segoe UI", 10F);
            button.ForeColor = Color.White;
            button.Location = new Point(width, height);
            button.Name = "ThietBi" + idd;
            button.AutoSize = true;
            button.MaximumSize = new Size(100, 0);
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
           /* MessageBox.Show(Convert.ToString(td));*/

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
                    resetData();
                    loadThietBi();
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
                        resetData();
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
                        resetData();
                    }
                }
            }
        }

        private void FormThucDonUser_Load(object sender, EventArgs e)
        {
            //Gán danh mục vào comboBox
            List<DANHMUC> listDanhMuc = contextDB.DANHMUCs.ToList();
            cmbDanhMuc.DataSource = listDanhMuc;
            cmbDanhMuc.ValueMember = "DanhMucID";
            cmbDanhMuc.DisplayMember = "TenDM";
            DataTable table = new DataTable();
            table.Columns.Add("DanhMucID", typeof(int));
            table.Columns.Add("TenDM", typeof(string));

            listDanhMuc.ForEach(x =>
            {
                var rowDM = table.NewRow();
                rowDM["DanhMucID"] = x.DanhMucID;
                rowDM["TenDM"] = x.TenDM;
                table.Rows.Add(rowDM);
            });

            DataRow row = table.NewRow();
            row["DanhMucID"] = all;
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
                int a = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString());
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
                loadThietBi();
            }
        }
    }
}
