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
    public partial class FormDanhMuc : Form
    {
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        DANHMUC danhMuc = new DANHMUC();
        private string currKey = "";
        public FormDanhMuc()
        {
            InitializeComponent();
        }

        public void loadData(int iDDM = -1)
        {
            var query = !currKey.Equals("")
                ? contextDB.DANHMUCs.Where(x => x.TenDM.Contains(currKey))
                : iDDM == -1 ?
                contextDB.DANHMUCs
                : contextDB.DANHMUCs.Where(x => x.DanhMucID == iDDM);

            dgvDanhMuc.DataSource = query.OrderByDescending(x => x.DanhMucID)
                .Select(x => new
                {
                    x.DanhMucID,
                    x.TenDM,
                }).ToList();
        }

        private void saveData()
        {
            danhMuc.TenDM = txtDanhMuc.Text.Trim();
            contextDB.DANHMUCs.Add(danhMuc);
            contextDB.SaveChanges();
        }

        private void updateData()
        {
            int a = Convert.ToInt32(dgvDanhMuc.SelectedRows[0].Cells[0].Value.ToString());
            contextDB.DANHMUCs
                .Where(item => item.DanhMucID == a)
                .Update(i => new DANHMUC
                {
                    TenDM = txtDanhMuc.Text
                });
        }

        private void DeleteData()
        {
            int a = Convert.ToInt32(dgvDanhMuc.SelectedRows[0].Cells[0].Value.ToString());
            contextDB.DANHMUCs
                .Where(item => item.DanhMucID == a)
                .Delete(i => new DANHMUC
                {
                    TenDM = txtDanhMuc.Text
                });
        }

        private void resetInput()
        {
            txtDanhMuc.Text = "";
            loadData();
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvDanhMuc_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow.Index >= 0)
            {
                txtDanhMuc.Text = dgvDanhMuc.CurrentRow.Cells[1].Value.ToString();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!!!");
            }
            else
            {
                saveData();
                MessageBox.Show("Thêm thành công");
                loadData();
                resetInput();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!!!");
            }
            else
            {
                updateData();
                MessageBox.Show("Cập nhật thành công");
                loadData();
                resetInput();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                DeleteData();
            }
            loadData();
            resetInput();
        }

        private void btnResetAD_Click(object sender, EventArgs e)
        {
            resetInput();
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            loadData();
            resetInput();
        }
    }
}
