using QuanLyCoffeeAndTea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.EntityFramework.Plus;

namespace QuanLyCoffeeAndTea
{
    public partial class FormNhanVien : Form
    {
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        NHANVIEN nhanVien = new NHANVIEN();
        private string currKey = "";
        public FormNhanVien()
        {
            InitializeComponent();
        }
        public void loadData(int iDDM = -1)
        {
            var query = !currKey.Equals("")
                ? contextDB.NHANVIENs.Where(x => x.TenNV.Contains(currKey))
                : iDDM == -1 ?
                contextDB.NHANVIENs
                : contextDB.NHANVIENs.Where(x => x.NhanVienID == iDDM);

            dgvNhanVien.DataSource = query.OrderByDescending(x => x.NhanVienID)
                .Select(x => new
                {
                    x.NhanVienID,
                    x.TenNV,
                    x.NgaySinh,
                    x.GioiTinh,
                    x.SDT,
                    x.ChucVu,
                }).ToList();
        }

        private void saveData()
        {
            nhanVien.TenNV = txtTennhanvien.Text;
            nhanVien.NgaySinh = dtpNgaySinh.Value;
            nhanVien.GioiTinh = cmbGioiTinh.Text;
            nhanVien.SDT = txtSDT.Text;
            nhanVien.ChucVu = cmbChucVu.Text;
            contextDB.NHANVIENs.Add(nhanVien);
            contextDB.SaveChanges();
        }
        private void updateData()
        {
            int a = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString());
            contextDB.NHANVIENs
                .Where(item => item.NhanVienID == a)
                .Update(i => new NHANVIEN
                {
                    TenNV = txtTennhanvien.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = cmbGioiTinh.Text,
                    SDT = txtSDT.Text,
                    ChucVu = cmbChucVu.Text,

                });
        }
        private void DeleteData()
        {
            int a = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString());
            contextDB.NHANVIENs
                .Where(item => item.NhanVienID == a)
                .Delete(i => new NHANVIEN
                {
                    TenNV = txtTennhanvien.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = cmbGioiTinh.Text,
                    SDT = txtSDT.Text,
                    ChucVu = cmbChucVu.Text,
                }); ;
        }
        private void resetInput()
        {
            txtTennhanvien.Text = "";
            dtpNgaySinh.Text = "";
            cmbGioiTinh.SelectedValue = 0;
            txtSDT.Text = "";
            cmbChucVu.SelectedIndex = 0;
            txtTimKiem.Text = "";
            loadData();
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }


        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = false;

            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");

            cmbChucVu.Items.Add("Nhân viên");
            cmbChucVu.Items.Add("Quản lý");

            loadData();
            resetInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int nam = int.Parse(DateTime.Now.Year.ToString());
            int dtp = int.Parse(dtpNgaySinh.Value.Year.ToString());
            int namsinh = Convert.ToInt32((nam - dtp).ToString());
            System.Text.RegularExpressions.Regex ktSDT = new System.Text.RegularExpressions.Regex(@"^0.\d{8}$");

            if (txtTennhanvien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!!!");
            }
            else if (namsinh < 18)
            {
                MessageBox.Show("Bạn không đủ 18 tuổi!!!");
            }
            else if (cmbGioiTinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính!!!");
            }
            else if (!ktSDT.IsMatch(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đủ 10 số và bắt đầu từ 0!!!");
            }
            else if (cmbChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chức vụ!!!");
            }
            else
            {
                saveData();
                loadData();
                resetInput();
                MessageBox.Show("Thêm thành công");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int nam = int.Parse(DateTime.Now.Year.ToString());
            int dtp = int.Parse(dtpNgaySinh.Value.Year.ToString());
            int namsinh = Convert.ToInt32((nam - dtp).ToString());
            System.Text.RegularExpressions.Regex ktSDT = new System.Text.RegularExpressions.Regex(@"^0.\d{8}$");

            if (txtTennhanvien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!!!");
            }
            else if (namsinh < 18)
            {
                MessageBox.Show("Bạn không đủ 18 tuổi!!!");
            }
            else if (cmbGioiTinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính!!!");
            }
            else if (!ktSDT.IsMatch(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đủ 10 số và bắt đầu từ 0!!!");
            }
            else if (cmbChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chức vụ!!!");
            }
            else
            {
                updateData();
                loadData();
                resetInput();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int nam = int.Parse(DateTime.Now.Year.ToString());
            int dtp = int.Parse(dtpNgaySinh.Value.Year.ToString());
            int namsinh = Convert.ToInt32((nam - dtp).ToString());

            if (txtTennhanvien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!!!");
            }
            else if (namsinh < 18)
            {
                MessageBox.Show("Bạn không đủ 18 tuổi!!!");
            }
            else if (cmbGioiTinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính!!!");
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống!!!");
            }
            else if (cmbChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chức vụ!!!");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    DeleteData();
                }
                loadData();
                resetInput();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            if (key.Equals(""))
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm!!!");
            else
            {
                currKey = key;
                loadData();
                currKey = "";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetInput();
        }

        private void dgvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow.Index >= 0)
            {
                txtTennhanvien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                cmbGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells[4].Value);
                cmbChucVu.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
