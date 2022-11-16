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
    public partial class FormReadMail : Form
    {
        public FormReadMail()
        {
            InitializeComponent();
            this.Load += FormReadMail_Load;
            dgv.CellClick += dgv_CellClick;
        }

        private void FormReadMail_Load(object sender, EventArgs e)
        {
            dgv.DataSource = Save.ListEnMail;
            dgv.DataSource = (from p in Save.ListEnMail select new { TrangThai = p.state, ChuDe = p.subject, NguoiGui = p.sender, NgayGui = p.date }).ToList();
            //------------------------------------------------------------//

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
