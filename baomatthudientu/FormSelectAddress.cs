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
    public partial class FormSelectAddress : Form
    {
        public FormSelectAddress()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public string email = String.Empty;
        private void LoadForm()
        {
            List<MailDTO> mailList = MailBLL.getAll(Helper.emailUser);
            List<string> list = new List<string>();
            foreach(MailDTO mail in mailList)
            {
                list.Add(mail.Receiver.ToString());
            }
           // dataGridView1.DataSource = mailList;

            var newlist = new HashSet<string>(list);// return a list without duplicate element.
            List<string> list2 = new List<string>();
            foreach(string item in newlist)
            {
                list2.Add(item);
            }
            var result = list2.Select(email => new { email }).ToList();
            dataGridView1.DataSource = result;
          
            
        }

        private void FormSelectAddress_Load(object sender, EventArgs e)
        {
            try
            {
                LoadForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            FormCompose formCp = new FormCompose();
            formCp.strValue = txtTo.Text.ToString();
            formCp.Show();
            this.Hide();
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
<<<<<<< HEAD
        txtTo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


=======
            txtTo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
>>>>>>> a1bf1896d1e252aab211f080361c556feaa0b55f
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTo.Text = "";
        }
    }
}
