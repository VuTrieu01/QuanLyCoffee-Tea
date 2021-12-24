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

namespace QuanLyCoffeeAndTea
{
    public partial class FormLogin : Form
    {
        public static Form instance;
        public static ACCOUNT info;
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        public FormLogin()
        {
            InitializeComponent();
            instance = this;
            // can giua man hinh
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private Boolean checkAccount()
        {
            try
            {
                ACCOUNT account = contextDB.ACCOUNTs.Where(u => u.UserID == gtxtUserName.Text &&
                u.Password == gtxtPassword.Text).FirstOrDefault();
                if (account == null)
                    return false;
                info = account;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void gbtnLogin_Click(object sender, EventArgs e)
        {
            if (gtxtUserName.Text == "" || gtxtPassword.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else if(!checkAccount())
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");   
            else
            {
                FormMainMenu menu = new FormMainMenu();
                menu.Show();
                this.Visible = false;
            }
        }

        private void gtsShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (gtsShowPassword.Checked)
                gtxtPassword.UseSystemPasswordChar = false;
            else
                gtxtPassword.UseSystemPasswordChar = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            gtxtPassword.UseSystemPasswordChar = true;
        }
    }
}
