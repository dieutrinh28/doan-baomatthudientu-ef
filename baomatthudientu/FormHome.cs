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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            lbXemThu.Click += LbXemThu_Click;
        }

        private void LbXemThu_Click(object sender, EventArgs e)
        {
            FormReadMail form = new FormReadMail();
            form.Show();
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormCompose form = new FormCompose();
            form.Show();
        }

        private void linklblCompose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            FormCompose form = new FormCompose();
            form.Show();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormSelectAddress form = new FormSelectAddress();
            form.Show();
        }

        private void linklblAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            FormSelectAddress form = new FormSelectAddress();
            form.Show();
        }

        /*private void CloseAllForm()
        {
            foreach (Form frm in Application.OpenForms)
            {
                FormLogin form = new FormLogin();
                form.Show();
                frm.Close();
            }
        }*/

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
