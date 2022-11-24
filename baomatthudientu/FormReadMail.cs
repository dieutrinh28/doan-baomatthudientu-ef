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
using baomatthudientu.Lớp_hỗ_trợ;

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
            this.StartPosition = FormStartPosition.CenterScreen;
            btnXoa.Click += BtnXoa_Click;
            btnCompose.Click += BtnCompose_Click;
        }

        private void BtnCompose_Click(object sender, EventArgs e)
        {
            FormCompose frm = new FormCompose();
            frm.Show();
            this.Hide();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count > 0)
            {
                int id = (int)dgv.SelectedRows[0].Cells[0].Value;
                MailBLL.deleteMail(id);
                setDatasource();
            }
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
            int id = (int)dgv.Rows[e.RowIndex].Cells[0].Value;
            int rd = MailBLL.getNumEn(id);
            List<SpecialCharacter> SpecialChar = new List<SpecialCharacter>();
            List<UpperCharacter> IndexUpper = new List<UpperCharacter>();
            List<MailDTO> list = MailBLL.getMail(email);
            MailDTO Mail = list[e.RowIndex];
            MailBLL.changeStatus(id);
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
                switch (rd)
                {
                    case 1: // Monoalphabetic
                        de += MonoAlphabeticCipher.Decrypt(split[m].ToLower(), "dkvqfibjwpescxhtmyauolrgzn") +" ";
                        break;
                    case 2:
                        de += OneTimePad.Decipher(split[m].ToLower(), OneTimePad.key("DIEUTRINHBICHNGANVANHANHOAINAMQUANGMINH".ToLower(), split[m].Length)) + " ";
                        break;
                    case 3:
                        de += Vigenere.Decipher(split[m], "dieutrinh") + " ";
                        break;
                    case 4:
                        de += RailFence.Decipher(split[m], 2) + " ";
                        break;
                    case 5:
                        de += PlayFair.Decipher(split[m], "hoainam") + " ";
                        break;
                }
            }

            string result = "";
            string[] split2 = de.Split();
            Helper.PushChar(SpecialChar, IndexUpper, split2, ref result);
            txbMail.Text = result;

        }
    }
}
