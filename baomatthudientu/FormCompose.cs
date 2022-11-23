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
        public string strValue = string.Empty;
        public FormCompose()
        {
            InitializeComponent();
            btnSendMail.Click += BtnSendMail_Click;
            txbFrom.Text = Helper.emailUser;
            txbFrom.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            txbTo.Text = "hoainam@gmail.com";
        }
        private void LoadForm()
        {
            //txbTo.Text = strValue;
        }
        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            int rd = (new Random()).Next(1, 6);
            List<SpecialCharacter> SpecialChar = new List<SpecialCharacter>();
            List<UpperCharacter> IndexUpper = new List<UpperCharacter>();
            string[] split = txbMail.Text.TrimEnd().TrimStart().Split();
            string EnText = "";
            Helper.PopChar(ref SpecialChar, ref IndexUpper, ref split);
            foreach (string s in split)
            {
                string en;
                rd = 2;
                //Mã hóa ở đây
                switch (rd)
                {
                    case 1: // Monoalphabetic
                        //string en = Vigenere.Encipher(s, (string)Helper.key);
                        //EnText += en + " ";
                        break;
                    case 2:
                        en = OneTimePad.Encipher(s.ToLower(), OneTimePad.key("DIEUTRINHBICHNGANVANHANHOAINAMQUANGMINH".ToLower(), s.Length));
                        EnText += en + " ";
                        break;
                    case 3:
                        en = Vigenere.Encipher(s, "dieutrinh");
                        EnText += en + " ";
                        break;
                    case 4:
                        en = RailFence.Encipher(s, 2);
                        EnText += en + " ";
                        break;
                    case 5:
                        en = PlayFair.Encipher(s, "hoainam");
                        EnText += en + " ";
                        break;
                }
            }
            split = EnText.TrimEnd().TrimStart().Split();
            string temp = "";
            foreach (string s in split)
            {
                temp += s + " ";
            }
            string result = "";
            Helper.PushChar(SpecialChar, IndexUpper, temp.Split(), ref result);
            MailBLL.addMail(txbSub.Text, result, txbFrom.Text, txbTo.Text, DateTime.Now, rd);
        }
        private void btnAddress_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormSelectAddress form = new FormSelectAddress();
            form.Show();
        }

        private void FormCompose_Load(object sender, EventArgs e)
        {
            try
            {
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
