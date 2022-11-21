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
            //nhớ xóa
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
    }
}
