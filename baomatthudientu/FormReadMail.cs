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
        string email = Helper.emailUser;
        public FormReadMail()
        {
            InitializeComponent();
            this.Load += FormReadMail_Load;
            dgv.CellClick += dgv_CellClick;
        }

        private void FormReadMail_Load(object sender, EventArgs e)
        {
            setDatasource();
            //------------------------------------------------------------//

        }
        private void setDatasource()
        {
            dgv.DataSource = null;
            dgv.DataSource = (from p in MailBLL.getMail(email) select new { id = p.Id, TrangThai = p.Status, ChuDe = p.Subject, NguoiGui = p.Sender, NgayGui = p.Time }).ToList();
            this.dgv.Columns[0].Visible = false;
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<SpecialCharacter> SpecialChar = new List<SpecialCharacter>();
            List<UpperCharacter> IndexUpper = new List<UpperCharacter>();
            List<MailDTO> list = MailBLL.getMail(email);
            MailDTO Mail = list[e.RowIndex];
            MailBLL.changeStatus((int)dgv.Rows[e.RowIndex].Cells[0].Value);
            setDatasource();
            
            dgv.Rows[e.RowIndex].Selected = true;
            this.dgv.Columns[0].Visible = false;
            lbSender.Text = Mail.Sender;
            lbSubject.Text = Mail.Subject;
            string[] split = Mail.Context.TrimEnd().TrimStart().Split();
            string de = "";
            Helper.PopChar(ref SpecialChar, ref IndexUpper, ref split);
            for (int m = 0; m < split.Length; m++)
            {
                de += Vigenere.Decipher(split[m], "lemon") + " ";
            }

            string result = "";
            string[] split2 = de.Split();
            Helper.PushChar(SpecialChar, IndexUpper, split2, ref result);
            txbMail.Text = result;
            
        }
    }
}
