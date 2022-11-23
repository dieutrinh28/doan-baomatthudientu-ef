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

        }
        private void LoadForm()
        {
            List<MailDTO> mailList = MailBLL.getAll();
            dataGridView1.DataSource = mailList;

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
            txtTo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTo.Text = "";
        }
    }
}
