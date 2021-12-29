using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyCoffeeAndTea.FormAdminFunction;
using QuanLyCoffeeAndTea.FormUserFunction;

namespace QuanLyCoffeeAndTea
{
    public partial class FormMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm;

        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,55);
            PanelMenu.Controls.Add(leftBorderBtn);
            // can giua man hinh
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            if(FormLogin.info.Quyen != true)
            {
                btnThucDon.Visible = false;
                btnSanPham.Visible = false;
                btnThietBi.Visible = false;
                btnDanhMuc.Visible = false;
                btnNhanVien.Visible = false;
                btnDoanhThu.Visible = false;
                btnTaiKhoan.Visible = false;
            }
            else
            {
                btnThucDonUser.Visible = false;
                btnSanPhamUser.Visible = false;
            }
        }

        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Green;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.FromArgb(0, 64, 0);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(0, 64, 0);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(childForm);
            PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(0, 64, 0);
            lblTitleChildForm.Text = "Home";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            if(activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btnThucDonUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            openChildForm(new FormThucDonUser());
        }

        private void btnSanPhamUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
            openChildForm(new FormSanPhamUser());
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            openChildForm(new FormThucDonAdmin());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
            openChildForm(new FormSanPhamAdmin());
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
            openChildForm(new FormThietBi());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
            openChildForm(new FormDanhMuc());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            openChildForm(new FormNhanVien());
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color6);
            openChildForm(new FormDoanhThu());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            openChildForm(new FormTaiKhoan());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi chương trình", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                FormLogin.instance.Visible = true;
                this.Dispose();
            }
        }
    }
}
