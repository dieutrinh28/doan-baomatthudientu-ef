using baomatthudientu.BLL;
using baomatthudientu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baomatthudientu
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public bool Login()
        {
            List<UserDTO> listUser = UserBLL.getAll();
            int count = 0;
            for(int i = 0; i < listUser.Count; i++)
            {
                if(txtUsername.Text.Trim() == listUser[i].UserName.Trim() && txtPassword.Text.Trim() == listUser[i].Password.Trim())
                {
                    count++;
                    break;
                }
                
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Login())
            {
                Helper.user = UserBLL.getUser(txtUsername.Text);
                this.Hide();
                FormHome form = new FormHome();
                form.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
