using FontAwesome.Sharp;
using Guna.UI2.WinForms;
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

namespace QuanLyCoffeeAndTea.FormUserFunction
{
    public partial class FormThemThucDon : Form
    {
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        private Size sizePic = new Size(240, 240);
        private string currKey = "";
        private int all = -1;
        public static THUCDON luuId;
        public static THUCDON luuGia;
        public FormThemThucDon(int ID)
        {
            InitializeComponent();
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
            /*ACCOUNT account = contextDB.ACCOUNTs.Where(u => u.UserID == gtxtUserName.Text &&
                u.Password == gtxtPassword.Text).FirstOrDefault();*/

            int id = (int)(sender as IconButton).Tag;

            THUCDON thucDon = contextDB.THUCDONs.Where(x => x.ThucDonID == id).FirstOrDefault();
            float a = (float)thucDon.Gia;
            luuId = thucDon;
           
        }

        private void saveData(string label)
        {
   
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
    }
}
