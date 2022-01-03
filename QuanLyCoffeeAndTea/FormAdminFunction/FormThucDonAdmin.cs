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

namespace QuanLyCoffeeAndTea
{
    public partial class FormThucDonAdmin : Form
    {
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        THUCDON thucDon = new THUCDON();
        private string currKey = "";
        private string newImg = @"..\..\Images\ThucDon\";
        private string selectedFile;

        public FormThucDonAdmin()
        {
            InitializeComponent();
        }
        public void loadData(int iDDM = -1)
        {
            var query = !currKey.Equals("")
                ? contextDB.THUCDONs.Where(x => x.TenThucDon.Contains(currKey))
                : iDDM == -1 ?
                contextDB.THUCDONs
                : contextDB.THUCDONs.Where(x => x.DanhMucID == iDDM);

            dgvThucDon.DataSource = query.OrderByDescending(x => x.ThucDonID)
                .Select(x => new
                {
                    x.ThucDonID,
                    x.TenThucDon,
                    x.DANHMUC.TenDM,
                    x.KichCo,
                    x.Gia,
                    x.HinhAnh
                }).ToList();
        }

        private void FormThucDonAdmin_Load(object sender, EventArgs e)
        {
            dgvThucDon.AutoGenerateColumns = false;
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
            row["DanhMucID"] = -1;
            row["TenDM"] = "--Chọn món";

            table.Rows.InsertAt(row, 0);
            cmbDanhMuc.DataSource = table;

            //Thêm dữ liệu vào cmbKichCo
            cmbKichCo.Items.Add("Không có");
            cmbKichCo.Items.Add("Ice regular size");
            cmbKichCo.Items.Add("Big size ice");

            //Cho ảnh vừa datagridView
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvThucDon.Columns[5];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            loadData();
            resetInput();
        }

        private void saveData()
        {
            thucDon.TenThucDon = txtTenThucDon.Text.Trim();
            thucDon.Gia = Convert.ToDouble(txtGia.Text.Trim());
            thucDon.DanhMucID = Convert.ToInt32(cmbDanhMuc.SelectedValue);
            thucDon.KichCo = cmbKichCo.Text;
            thucDon.HinhAnh = ImageToByteArray(PictureBoxThucDon);
            contextDB.THUCDONs.Add(thucDon);
            contextDB.SaveChanges();
                string fileExt = System.IO.Path.GetExtension(selectedFile);
                string resultFileCopy = newImg + thucDon.ThucDonID + fileExt;
                if (!resultFileCopy.Equals(selectedFile))
                    System.IO.File.Copy(selectedFile, resultFileCopy);
        }

        private void updateData()
        {
            int a = Convert.ToInt32(dgvThucDon.SelectedRows[0].Cells[0].Value.ToString());
            contextDB.THUCDONs
                .Where(item => item.ThucDonID == a)
                .Update(i => new THUCDON { 
                    TenThucDon = txtTenThucDon.Text,
                    Gia = Convert.ToDouble(txtGia.Text),
                    DanhMucID = Convert.ToInt32(cmbDanhMuc.SelectedValue),
                    KichCo = cmbKichCo.Text,
                    HinhAnh = ImageToByteArray(PictureBoxThucDon)
                });
                string fileExt = System.IO.Path.GetExtension(selectedFile);
                string resultFileCopy = newImg + a + fileExt;
            if (!resultFileCopy.Equals(selectedFile))
                System.IO.File.Copy(selectedFile, resultFileCopy, true);
        }

        private void DeleteData()
        {
            int a = Convert.ToInt32(dgvThucDon.SelectedRows[0].Cells[0].Value.ToString());
            contextDB.THUCDONs
                .Where(item => item.ThucDonID == a)
                .Delete(i => new THUCDON
                {
                    TenThucDon = txtTenThucDon.Text,
                    Gia = Convert.ToDouble(txtGia.Text),
                    DanhMucID = Convert.ToInt32(cmbDanhMuc.SelectedValue),
                    KichCo = cmbKichCo.Text,
                    HinhAnh = ImageToByteArray(PictureBoxThucDon)
                });

        }
        private void resetInput()
        {
            txtTenThucDon.Text = "";
            txtGia.Text = "";
            cmbDanhMuc.SelectedValue = -1;
            cmbKichCo.SelectedIndex=0;
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

        private void btnThucDonUser_Click(object sender, EventArgs e)
        {
            if (txtTenThucDon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thực đơn!!!");
            }
            else if (cmbDanhMuc.Text == "--Chọn món")
            {
                MessageBox.Show("Vui lòng chọn danh mục!!!");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                DeleteData();
            }
            loadData();
            resetInput();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetInput();
        }

        private void dgvThucDon_DoubleClick(object sender, EventArgs e)
        {
            if (dgvThucDon.CurrentRow.Index >= 0)
            {
                txtTenThucDon.Text = dgvThucDon.CurrentRow.Cells[1].Value.ToString();
                cmbDanhMuc.Text = dgvThucDon.CurrentRow.Cells[2].Value.ToString();
                cmbKichCo.Text = dgvThucDon.CurrentRow.Cells[3].Value.ToString();
                txtGia.Text = Convert.ToString(dgvThucDon.CurrentRow.Cells[4].Value);
                if (dgvThucDon.CurrentRow.Cells[5].Value.ToString() != "")
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])dgvThucDon.CurrentRow.Cells[5].Value);
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
    }
}
