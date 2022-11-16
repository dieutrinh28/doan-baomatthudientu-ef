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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Thư nhận về");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Thư gửi đi");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Thư đã gửi");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Thư đã xóa");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Thư đang soạn");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Thư điện tử", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
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
            this.button4 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(799, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // hiểnThịToolStripMenuItem
            // 
            this.hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            this.hiểnThịToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.hiểnThịToolStripMenuItem.Text = "Hiển thị";
            // 
            // thưTínToolStripMenuItem
            // 
            this.thưTínToolStripMenuItem.Name = "thưTínToolStripMenuItem";
            this.thưTínToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.thưTínToolStripMenuItem.Text = "Thư tín";
            // 
            // cấuHìnhToolStripMenuItem
            // 
            this.cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            this.cấuHìnhToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.cấuHìnhToolStripMenuItem.Text = "Cấu hình";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.btnAddress);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnCompose);
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(800, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(290, 9);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "In thư";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(655, 9);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Tìm kiếm";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnAddress
            // 
            this.btnAddress.Location = new System.Drawing.Point(551, 9);
            this.btnAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(98, 23);
            this.btnAddress.TabIndex = 5;
            this.btnAddress.Text = "Sổ địa chỉ";
            this.btnAddress.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(464, 9);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Nhận thư";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Xóa thư";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Gửi tiếp";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Trả lời";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCompose
            // 
            this.btnCompose.Location = new System.Drawing.Point(0, 9);
            this.btnCompose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(121, 23);
            this.btnCompose.TabIndex = 0;
            this.btnCompose.Text = "Soạn thư mới";
            this.btnCompose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(231, 310);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thư điện tử";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 28);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Node1";
            treeNode13.Text = "Thư nhận về";
            treeNode14.Name = "Node2";
            treeNode14.Text = "Thư gửi đi";
            treeNode15.Name = "Node3";
            treeNode15.Text = "Thư đã gửi";
            treeNode16.Name = "Node4";
            treeNode16.Text = "Thư đã xóa";
            treeNode17.Name = "Node5";
            treeNode17.Text = "Thư đang soạn";
            treeNode18.Name = "Node0";
            treeNode18.Text = "Thư điện tử";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(219, 278);
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
            this.groupBox3.Location = new System.Drawing.Point(231, 90);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(569, 310);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // lbSubject
            // 
            this.lbSubject.Location = new System.Drawing.Point(146, 198);
            this.lbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSubject.Multiline = true;
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.ReadOnly = true;
            this.lbSubject.Size = new System.Drawing.Size(169, 17);
            this.lbSubject.TabIndex = 13;
            // 
            // lbSender
            // 
            this.lbSender.Location = new System.Drawing.Point(146, 174);
            this.lbSender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSender.Multiline = true;
            this.lbSender.Name = "lbSender";
            this.lbSender.ReadOnly = true;
            this.lbSender.Size = new System.Drawing.Size(169, 17);
            this.lbSender.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chủ đề thư: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Người gửi: ";
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(0, 225);
            this.txbMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMail.Multiline = true;
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(563, 81);
            this.txbMail.TabIndex = 9;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 28);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 10;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(563, 134);
            this.dgv.TabIndex = 8;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(569, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hệ thống thư điện tử mật";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReadMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Button button4;
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