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

namespace QuanLyCoffeeAndTea.FormAdminFunction
{
    public partial class FormTaiKhoan : Form
    {
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        ACCOUNT aCCOUNT = new ACCOUNT();
        private string currKey = "";
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        public void loadData(int iDDM = -1)
        {
            var query = !currKey.Equals("")
            ? contextDB.ACCOUNTs.Where(x => x.UserID.ToString().Contains(currKey))
            : iDDM == -1 ?
            contextDB.ACCOUNTs
            : contextDB.ACCOUNTs.Where(x => Convert.ToInt32(x.UserID) == iDDM);

            dgvTaiKhoan.DataSource = query.OrderByDescending(x => x.UserID)
                .Select(x => new
                {
                    x.UserID,
                    x.Password,
                    x.NHANVIEN.ChucVu,
                    x.NHANVIEN.TenNV,
                }).ToList();
        }

        private void loadQuyen(int id)
        {
            var query = contextDB.NHANVIENs.FirstOrDefault(x => x.NhanVienID == id);
            txtQuyen.Text = query.ChucVu;
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.AutoGenerateColumns = false;

            //Gán danh mục vào comboBox
            List<NHANVIEN> listDanhMuc = contextDB.NHANVIENs.ToList();
            cmbTenNV.DataSource = listDanhMuc;
            cmbTenNV.ValueMember = "NhanVienID";
            cmbTenNV.DisplayMember = "TenNV";
            DataTable table = new DataTable();
            table.Columns.Add("NhanVienID", typeof(int));
            table.Columns.Add("TenNV", typeof(string));

            listDanhMuc.ForEach(x =>
            {
                var rowDM = table.NewRow();
                rowDM["NhanVienID"] = x.NhanVienID;
                rowDM["TenNV"] = x.TenNV;
                table.Rows.Add(rowDM);
            });

            DataRow row = table.NewRow();
            row["NhanVienID"] = -1;
            row["TenNV"] = "--Chọn";

            table.Rows.InsertAt(row, 0);
            cmbTenNV.DataSource = table;

            loadData();
            resetInput();
        }

        private void cmbTenNV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadQuyen((int)cmbTenNV.SelectedValue);
        }

        private void saveData()
        {
            aCCOUNT.UserID = txtTaiKhoan.Text;
            aCCOUNT.Password = txtMatKhau.Text;
            if (txtQuyen.Text == "Nhân viên")
            {
                aCCOUNT.Quyen = false;
            }
            else
            {
                aCCOUNT.Quyen = true;
            }
            aCCOUNT.NhanVienID = Convert.ToInt32(cmbTenNV.SelectedValue);
            contextDB.ACCOUNTs.Add(aCCOUNT);
            contextDB.SaveChanges();
        }
        private void updateData()
        {
            string a = dgvTaiKhoan.SelectedRows[0].Cells[0].Value.ToString();
            if (txtQuyen.Text == "Nhân viên")
            {
                contextDB.ACCOUNTs
                .Where(item => item.UserID == a)
                .Update(i => new ACCOUNT
                {
                    UserID = txtTaiKhoan.Text,
                    Password = txtMatKhau.Text,
                    Quyen = false,
                    NhanVienID = Convert.ToInt32(cmbTenNV.SelectedValue),
                });
            }
            else
            {
                contextDB.ACCOUNTs
                .Where(item => item.UserID == a)
                .Update(i => new ACCOUNT
                {
                    UserID = txtTaiKhoan.Text,
                    Password = txtMatKhau.Text,
                    Quyen = true,
                    NhanVienID = Convert.ToInt32(cmbTenNV.SelectedValue),
                });
            }
        }
        private void DeleteData()
        {
            string a = dgvTaiKhoan.SelectedRows[0].Cells[0].Value.ToString();
            if (txtQuyen.Text == "Nhân viên")
            {
                contextDB.ACCOUNTs
                .Where(item => item.UserID == a)
                .Delete(i => new ACCOUNT
                {
                    UserID = txtTaiKhoan.Text,
                    Password = txtMatKhau.Text,
                    Quyen = false,
                    NhanVienID = Convert.ToInt32(cmbTenNV.SelectedValue),
                });
            }
            else
            {
                contextDB.ACCOUNTs
                .Where(item => item.UserID == a)
                .Delete(i => new ACCOUNT
                {
                    UserID = txtTaiKhoan.Text,
                    Password = txtMatKhau.Text,
                    Quyen = true,
                    NhanVienID = Convert.ToInt32(cmbTenNV.SelectedValue),
                });
            }
        }
        private void resetInput()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtQuyen.Text = "";
            txtTimKiem.Text = "";
            cmbTenNV.SelectedValue = -1;
            loadData();
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!!!");
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!!!");
            }
            else if (cmbTenNV.Text == "--Chọn")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!!");
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
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!!!");
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!!!");
            }
            else if (cmbTenNV.Text == "--Chọn")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!!");
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
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!!!");
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!!!");
            }
            else if (cmbTenNV.Text == "--Chọn")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!!");
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

        private void dgvTaiKhoan_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow.Index >= 0)
            {
                txtTaiKhoan.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                cmbTenNV.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString();
                txtQuyen.Text = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            if (key.Equals(""))
                MessageBox.Show("Vui lòng nhập tên món cần tìm!!!");
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
    }
}
