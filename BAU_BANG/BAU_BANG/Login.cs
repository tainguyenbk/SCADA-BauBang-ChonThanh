using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAU_BANG
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string username = "admin";
        string password = "1234";
        string username1 = "guest";
        string password1 = "1234";
        string username2 = "admin_nm";
        string password2 = "1234";
        string username3 = "guest_nm";
        string password3 = "1234";
        private void bt_Submit_Click(object sender, EventArgs e)
        {
            if (txb_User.Text == username && txb_Pass.Text == password)
            {
                Program.Role = 1;
                this.Hide();
                Program.home.Show();
            }
            else if (txb_User.Text == username1 && txb_Pass.Text == password1)
            {
                Program.Role = 2;
                this.Hide();
                Program.home.Show();
            }
            else if (txb_User.Text == username2 && txb_Pass.Text == password2)
            {
                Program.Role = 1;
                this.Hide();
                Program.home_nm.Show();
            }
            else if (txb_User.Text == username3 && txb_Pass.Text == password3)
            {
                Program.Role = 2;
                this.Hide();
                Program.home_nm.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
    }
}
