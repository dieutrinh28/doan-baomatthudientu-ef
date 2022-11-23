using System.Windows.Forms;

namespace baomatthudientu
{
    partial class FormReadMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Thư nhận về");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Thư gửi đi");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Thư đã gửi");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Thư đã xóa");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Thư đang soạn");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Thư điện tử", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thưTínToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấuHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAddress = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCompose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSubject = new System.Windows.Forms.TextBox();
            this.lbSender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.hiểnThịToolStripMenuItem,
            this.thưTínToolStripMenuItem,
            this.cấuHìnhToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // hiểnThịToolStripMenuItem
            // 
            this.hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            this.hiểnThịToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.hiểnThịToolStripMenuItem.Text = "Hiển thị";
            // 
            // thưTínToolStripMenuItem
            // 
            this.thưTínToolStripMenuItem.Name = "thưTínToolStripMenuItem";
            this.thưTínToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.thưTínToolStripMenuItem.Text = "Thư tín";
            // 
            // cấuHìnhToolStripMenuItem
            // 
            this.cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            this.cấuHìnhToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cấuHìnhToolStripMenuItem.Text = "Cấu hình";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.btnAddress);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnCompose);
            this.groupBox1.Location = new System.Drawing.Point(0, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(600, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(218, 7);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 19);
            this.button8.TabIndex = 7;
            this.button8.Text = "In thư";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(491, 7);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 19);
            this.button7.TabIndex = 6;
            this.button7.Text = "Tìm kiếm";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnAddress
            // 
            this.btnAddress.Enabled = false;
            this.btnAddress.Location = new System.Drawing.Point(413, 7);
            this.btnAddress.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(74, 19);
            this.btnAddress.TabIndex = 5;
            this.btnAddress.Text = "Sổ địa chỉ";
            this.btnAddress.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(348, 7);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 19);
            this.button5.TabIndex = 4;
            this.button5.Text = "Nhận thư";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(283, 7);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 19);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa thư";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(150, 7);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 19);
            this.button3.TabIndex = 2;
            this.button3.Text = "Gửi tiếp";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(95, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 19);
            this.button2.TabIndex = 1;
            this.button2.Text = "Trả lời";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCompose
            // 
            this.btnCompose.Location = new System.Drawing.Point(0, 7);
            this.btnCompose.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(91, 19);
            this.btnCompose.TabIndex = 0;
            this.btnCompose.Text = "Soạn thư mới";
            this.btnCompose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 73);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(173, 252);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thư điện tử";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(4, 23);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Thư nhận về";
            treeNode8.Name = "Node2";
            treeNode8.Text = "Thư gửi đi";
            treeNode9.Name = "Node3";
            treeNode9.Text = "Thư đã gửi";
            treeNode10.Name = "Node4";
            treeNode10.Text = "Thư đã xóa";
            treeNode11.Name = "Node5";
            treeNode11.Text = "Thư đang soạn";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Thư điện tử";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(165, 227);
            this.treeView1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbSubject);
            this.groupBox3.Controls.Add(this.lbSender);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txbMail);
            this.groupBox3.Controls.Add(this.dgv);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(173, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(427, 252);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // lbSubject
            // 
            this.lbSubject.Location = new System.Drawing.Point(108, 161);
            this.lbSubject.Margin = new System.Windows.Forms.Padding(2);
            this.lbSubject.Multiline = true;
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.ReadOnly = true;
            this.lbSubject.Size = new System.Drawing.Size(128, 18);
            this.lbSubject.TabIndex = 13;
            // 
            // lbSender
            // 
            this.lbSender.Location = new System.Drawing.Point(108, 136);
            this.lbSender.Margin = new System.Windows.Forms.Padding(2);
            this.lbSender.Multiline = true;
            this.lbSender.Name = "lbSender";
            this.lbSender.ReadOnly = true;
            this.lbSender.Size = new System.Drawing.Size(128, 21);
            this.lbSender.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chủ đề thư: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Người gửi: ";
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(0, 183);
            this.txbMail.Margin = new System.Windows.Forms.Padding(2);
            this.txbMail.Multiline = true;
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(423, 67);
            this.txbMail.TabIndex = 9;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 23);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 10;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(422, 109);
            this.dgv.TabIndex = 8;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hệ thống thư điện tử mật";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReadMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 330);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReadMail";
            this.Text = "Xem thư";
            this.Load += new System.EventHandler(this.FormReadMail_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem hiểnThịToolStripMenuItem;
        private ToolStripMenuItem thưTínToolStripMenuItem;
        private ToolStripMenuItem cấuHìnhToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private GroupBox groupBox1;
        private Button button8;
        private Button button7;
        private Button btnAddress;
        private Button button5;
        private Button btnXoa;
        private Button button3;
        private Button button2;
        private Button btnCompose;
        private GroupBox groupBox2;
        private Label label1;
        private TreeView treeView1;
        private GroupBox groupBox3;
        private TextBox lbSubject;
        private TextBox lbSender;
        private Label label3;
        private Label label2;
        private TextBox txbMail;
        private DataGridView dgv;
        private Label label4;
    }
}