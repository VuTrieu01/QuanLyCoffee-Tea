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
using Z.EntityFramework.Plus;

namespace QuanLyCoffeeAndTea.FormAdminFunction
{
    public partial class FormSanPhamAdmin : Form
    {
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        SANPHAM sanPham = new SANPHAM();
        private string currKey = "";
        private string newImg = @"..\..\Images\SanPham\";
        private string selectedFile;

        public FormSanPhamAdmin()
        {
            InitializeComponent();
        }

        public void loadData(int iDDM = -1)
        {
            var query = !currKey.Equals("")
                ? contextDB.SANPHAMs.Where(x => x.TenSanPham.Contains(currKey))
                : iDDM == -1 ?
                contextDB.SANPHAMs
                : contextDB.SANPHAMs.Where(x => x.DanhMucSPID == iDDM);

            dgvSanPham.DataSource = query.OrderByDescending(x => x.SanPhamID)
                .Select(x => new
                {
                    x.SanPhamID,
                    x.TenSanPham,
                    x.DANHMUCSANPHAM.TenDM,
                    x.QuyCach,
                    x.Gia,
                    x.HinhAnh
                }).ToList();
        }

        private void saveData()
        {
            sanPham.TenSanPham = txtTenSP.Text.Trim();
            sanPham.DanhMucSPID = Convert.ToInt32(cmbDanhMuc.SelectedValue);
            sanPham.QuyCach = txtQuyCach.Text.Trim();
            sanPham.Gia = Convert.ToDouble(txtGia.Text.Trim());
            sanPham.HinhAnh = ImageToByteArray(PictureBoxThucDon);
            contextDB.SANPHAMs.Add(sanPham);
            contextDB.SaveChanges();
            string fileExt = System.IO.Path.GetExtension(selectedFile);
            string resultFileCopy = newImg + sanPham.SanPhamID + fileExt;
            if (!resultFileCopy.Equals(selectedFile))
                System.IO.File.Copy(selectedFile, resultFileCopy);
        }

        private void updateData()
        {
            int a = Convert.ToInt32(dgvSanPham.SelectedRows[0].Cells[0].Value.ToString());
            contextDB.SANPHAMs
                .Where(item => item.SanPhamID == a)
                .Update(i => new SANPHAM
                {
                    TenSanPham = txtTenSP.Text,
                    DanhMucSPID = Convert.ToInt32(cmbDanhMuc.SelectedValue),
                    QuyCach = txtQuyCach.Text,
                    Gia = Convert.ToDouble(txtGia.Text),
                    HinhAnh = ImageToByteArray(PictureBoxThucDon)
                });
            string fileExt = System.IO.Path.GetExtension(selectedFile);
            string resultFileCopy = newImg + a + fileExt;
            if (!resultFileCopy.Equals(selectedFile))
                System.IO.File.Copy(selectedFile, resultFileCopy, true);
        }

        private void DeleteData()
        {
            int a = Convert.ToInt32(dgvSanPham.SelectedRows[0].Cells[0].Value.ToString());
            contextDB.SANPHAMs
                .Where(item => item.SanPhamID == a)
                .Delete(i => new SANPHAM
                {
                    TenSanPham = txtTenSP.Text,
                    DanhMucSPID = Convert.ToInt32(cmbDanhMuc.SelectedValue),
                    QuyCach = txtQuyCach.Text,
                    Gia = Convert.ToDouble(txtGia.Text),
                    HinhAnh = ImageToByteArray(PictureBoxThucDon)
                });

        }
        private void resetInput()
        {
            txtTenSP.Text = "";
            cmbDanhMuc.SelectedValue = -1;
            txtQuyCach.Text = "";
            txtGia.Text = "";
            txtTimKiem.Text = "";
            loadData();
            PictureBoxThucDon.Image = null;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!!!");
            }
            else if (cmbDanhMuc.Text == "--Chọn")
            {
                MessageBox.Show("Vui lòng chọn danh mục!!!");
            }
            else if (txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá!!!");
            }
            else if (txtQuyCach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập quy cách!!!");
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
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!!!");
            }
            else if (cmbDanhMuc.Text == "--Chọn")
            {
                MessageBox.Show("Vui lòng chọn danh mục!!!");
            }
            else if (txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá!!!");
            }
            else if (txtQuyCach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập quy cách!!!");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!!!");
            }
            else if (cmbDanhMuc.Text == "--Chọn")
            {
                MessageBox.Show("Vui lòng chọn danh mục!!!");
            }
            else if (txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá!!!");
            }
            else if (txtQuyCach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập quy cách!!!");
            }
            else if (PictureBoxThucDon.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh phù hợp!!!");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetInput();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.jpg)|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBoxThucDon.Image = new Bitmap(openFileDialog.FileName);
                selectedFile = openFileDialog.FileName;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            if (key.Equals(""))
                MessageBox.Show("Vui lòng nhập tên sản phẩm cần tìm!!!");
            else
            {
                currKey = key;
                loadData();
                currKey = "";
            }
        }

        private void dgvSanPham_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow.Index >= 0)
            {
                txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                cmbDanhMuc.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                txtQuyCach.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                txtGia.Text = Convert.ToString(dgvSanPham.CurrentRow.Cells[4].Value);
                if (dgvSanPham.CurrentRow.Cells[5].Value.ToString() != "")
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])dgvSanPham.CurrentRow.Cells[5].Value);
                    PictureBoxThucDon.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    PictureBoxThucDon.Image = null;
                }
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FormSanPhamAdmin_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = false;
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
            row["DanhMucSPID"] = -1;
            row["TenDM"] = "--Chọn";

            table.Rows.InsertAt(row, 0);
            cmbDanhMuc.DataSource = table;

            //Cho ảnh vừa datagridView
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvSanPham.Columns[5];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            loadData();
            resetInput();
        }
    }
}
