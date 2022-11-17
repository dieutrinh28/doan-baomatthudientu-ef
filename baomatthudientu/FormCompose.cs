using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baomatthudientu.BLL;

namespace baomatthudientu
{
    public partial class FormCompose : Form
    {
        public FormCompose()
        {
            InitializeComponent();
            btnSendMail.Click += BtnSendMail_Click;
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            List<SpecialCharacter> SpecialChar = new List<SpecialCharacter>();
            List<UpperCharacter> IndexUpper = new List<UpperCharacter>();
            int key = 2;
            string[] split = txbMail.Text.TrimEnd().TrimStart().Split();
            string EnText = "";
            Helper.PopChar(ref SpecialChar, ref IndexUpper, ref split);
            foreach (string s in split)
            {
                string en = RailFence.Encipher(s, key);
                EnText += en + " ";
            }
            split = EnText.TrimEnd().TrimStart().Split();
            string temp = "";
            foreach (string s in split)
            {
                temp += s + " ";
            }
            string result = "";
            Helper.PushChar(SpecialChar, IndexUpper, temp.Split(), ref result);
            MailBLL.addMail(txbSub.Text, result, txbFrom.Text, txbTo.Text, DateTime.Now);

            FormReadMail frm = new FormReadMail();
            frm.Show();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormSelectAddress form = new FormSelectAddress();
            form.Show();
        }
    }
}
