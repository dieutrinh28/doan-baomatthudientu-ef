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
using baomatthudientu.DTO;

namespace baomatthudientu
{
    public partial class FormReadMail : Form
    {
        string email = "1@gmail.com";
        public FormReadMail()
        {
            InitializeComponent();
            this.Load += FormReadMail_Load;
            dgv.CellClick += dgv_CellClick;
        }

        private void FormReadMail_Load(object sender, EventArgs e)
        {
            dgv.DataSource = (from p in MailBLL.getMail(email) select new { TrangThai = "chưa đọc", ChuDe = p.Subject, NguoiGui = p.Sender, NgayGui = p.Time }).ToList();
            //------------------------------------------------------------//

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<SpecialCharacter> SpecialChar = new List<SpecialCharacter>();
            List<UpperCharacter> IndexUpper = new List<UpperCharacter>();
            List<MailDTO> list = MailBLL.getMail(email);
            MailDTO Mail = list[e.RowIndex];
            dgv.Rows[e.RowIndex].Cells[0].Value = "Đã đọc";
            lbSender.Text = Mail.Sender;
            lbSubject.Text = Mail.Subject;
            string[] split = Mail.Context.TrimEnd().TrimStart().Split();
            string de = "";
            Helper.PopChar(ref SpecialChar, ref IndexUpper, ref split);
            for (int m = 0; m < split.Length; m++)
            {
                de += RailFence.Decipher(split[m], 2) + " ";
            }

            string result = "";
            string[] split2 = de.Split();
            Helper.PushChar(SpecialChar, IndexUpper, split2, ref result);
            txbMail.Text = result;
            /*EnMail Mail = Save.ListEnMail[e.RowIndex];
            dgv.Rows[e.RowIndex].Cells[0].Value = "Đã đọc";
            lbSender.Text = Mail.sender;
            lbSubject.Text = Mail.subject;
            string[] split = Mail.text.TrimEnd().TrimStart().Split(" ");
            string de = "";
            for (int m = 0; m < split.Length; m++)
            {
                de += PlayFair.Decipher(split[m], "key") + " ";
            }

            string result = "";
            string[] split2 = de.Split(" ");
            for (int i = 0; i < split2.Length; i++)
            {
                string s = split2[i];
                // Viết hoa các kí tự
                foreach (UpperCharacter item in Mail.IndexUpper)
                {
                    if (item.indexString == i)
                    {
                        s = s.Replace(s[item.indexUpper], char.ToUpper(s[item.indexUpper]));
                    }
                }
                //Thêm các kí tự khác
                foreach (SpecialCharacter item in Mail.SpecialChar)
                {
                    if (item.indexString == i)
                    {
                        s = s.Insert(item.indexInsert, item.c.ToString());
                    }
                }
                result += s + " ";
            }
            txbMail.Text = result;*/
        }
    }
}
