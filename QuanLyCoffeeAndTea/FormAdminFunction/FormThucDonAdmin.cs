using QuanLyCoffeeAndTea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffeeAndTea
{
    public partial class FormThucDonAdmin : Form
    {
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        THUCDON thucDon = new THUCDON();
        public FormThucDonAdmin()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            var query = from thucDon in contextDB.THUCDONs
                        join danhMuc in contextDB.DANHMUCs on thucDon.DanhMucID equals danhMuc.DanhMucID
                        select new {thucDonID = thucDon.ThucDonID, tenThucDon = thucDon.TenThucDon, gia = thucDon.Gia, danhmuc = danhMuc.TenDM, anh = thucDon.HinhAnh};
            dgvThucDon.DataSource = query.ToList();
        }

        private void saveData()
        {
            thucDon.TenThucDon = txtTenThucDon.Text.Trim();
            thucDon.Gia = Convert.ToDouble(txtGia.Text.Trim());
            thucDon.DanhMucID = Convert.ToInt32(cmbDanhMuc.SelectedValue);
            thucDon.HinhAnh = ImageToByteArray(PictureBoxThucDon);
            contextDB.THUCDONs.Add(thucDon);
            contextDB.SaveChanges();
        }

        private void updateData()
        {
            thucDon.TenThucDon = txtTenThucDon.Text;
            thucDon.Gia = Convert.ToDouble(txtGia.Text);
            thucDon.DanhMucID = Convert.ToInt32(cmbDanhMuc.SelectedValue);
            thucDon.HinhAnh = ImageToByteArray(PictureBoxThucDon);
            contextDB.SaveChanges();
        }

        private void resetInput()
        {
            txtTenThucDon.Text = "";
            txtGia.Text = "";
            cmbDanhMuc.Refresh();
            PictureBoxThucDon.Image = null;
            btnThucDonUser.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void FormThucDonAdmin_Load(object sender, EventArgs e)
        {
            //Gán danh mục vào comboBox
            List<DANHMUC> listDanhMuc = contextDB.DANHMUCs.ToList();
            cmbDanhMuc.DataSource = listDanhMuc;
            cmbDanhMuc.ValueMember = "DanhMucID";
            cmbDanhMuc.DisplayMember = "TenDM";

            //Cho ảnh vừa datagridView
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvThucDon.Columns[4];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvThucDon.AutoGenerateColumns = false;
            dgvThucDon.Columns["ThucDonID"].DataPropertyName = "thucDonID";
            dgvThucDon.Columns["TenThucDon"].DataPropertyName = "tenThucDon";
            dgvThucDon.Columns["Gia"].DataPropertyName = "gia";
            dgvThucDon.Columns["TenDanhMuc"].DataPropertyName = "danhmuc";
            dgvThucDon.Columns["HinhAnh"].DataPropertyName = "anh";
            loadData();
            resetInput();
        }

        private void txtTenThucDon_TextChanged(object sender, EventArgs e)
        {

        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBoxThucDon.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnThucDonUser_Click(object sender, EventArgs e)
        {
            if (txtTenThucDon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thực đơn!!!");
            }
            else if (txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá!!!");
            }
            else if (PictureBoxThucDon.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh phù hợp!!!");
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
            if (txtTenThucDon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thực đơn!!!");
            }
            else if (txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá!!!");
            }
            else if (PictureBoxThucDon.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh phù hợp!!!");
            }
            else
            {
                updateData();
                loadData();
                resetInput();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                var entry = contextDB.Entry(thucDon);
                if (entry.State == EntityState.Detached)
                    contextDB.THUCDONs.Attach(thucDon);
                contextDB.THUCDONs.Remove(thucDon);
                contextDB.SaveChanges();
                loadData();
                resetInput();
            }
        }

        private void dgvThucDon_DoubleClick(object sender, EventArgs e)
        {
            if (dgvThucDon.CurrentRow.Index >= 0)
            {
                thucDon.ThucDonID = Convert.ToInt32(dgvThucDon.CurrentRow.Cells["ThucDonID"].Value);
                thucDon = contextDB.THUCDONs.Where(x => x.ThucDonID == thucDon.ThucDonID).FirstOrDefault();
                txtTenThucDon.Text = thucDon.TenThucDon;
                txtGia.Text = Convert.ToString(thucDon.Gia);
                cmbDanhMuc.SelectedItem = Convert.ToString(thucDon.DanhMucID);
                if (dgvThucDon.SelectedRows[0].Cells[4].Value.ToString() != "")
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])thucDon.HinhAnh);
                    PictureBoxThucDon.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    PictureBoxThucDon.Image = null;
                }
                btnThucDonUser.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}
