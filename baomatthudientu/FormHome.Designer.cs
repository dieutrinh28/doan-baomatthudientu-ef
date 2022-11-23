using System.Windows.Forms;

namespace baomatthudientu
{
    partial class FormHome
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thư nhận về");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Thư gửi đi");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Thư đã gửi");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Thư đã xóa");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Thư đang soạn");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Thư điện tử", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thưTínToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấuHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCompose = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linklblAddress = new System.Windows.Forms.LinkLabel();
            this.lbXemThu = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linklblCompose = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnCompose);
            this.groupBox1.Location = new System.Drawing.Point(0, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(600, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(218, 6);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 27);
            this.button8.TabIndex = 7;
            this.button8.Text = "In thư";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(521, 6);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 27);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(283, 6);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "Nhận thư";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(150, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Gửi tiếp";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(95, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Trả lời";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCompose
            // 
            this.btnCompose.Location = new System.Drawing.Point(0, 6);
            this.btnCompose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(91, 27);
            this.btnCompose.TabIndex = 0;
            this.btnCompose.Text = "Soạn thư mới";
            this.btnCompose.UseVisualStyleBackColor = true;
            this.btnCompose.Click += new System.EventHandler(this.btnCompose_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(4, 22);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Thư nhận về";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Thư gửi đi";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Thư đã gửi";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Thư đã xóa";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Thư đang soạn";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Thư điện tử";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(219, 278);
            this.treeView1.TabIndex = 3;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(173, 252);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel6);
            this.groupBox3.Controls.Add(this.linklblAddress);
            this.groupBox3.Controls.Add(this.lbXemThu);
            this.groupBox3.Controls.Add(this.linkLabel3);
            this.groupBox3.Controls.Add(this.linklblCompose);
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(173, 70);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(427, 248);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Enabled = false;
            this.linkLabel6.LinkColor = System.Drawing.Color.Black;
            this.linkLabel6.Location = new System.Drawing.Point(50, 223);
            this.linkLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(131, 13);
            this.linkLabel6.TabIndex = 15;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Mở danh sách người dùng";
            // 
            // linklblAddress
            // 
            this.linklblAddress.AutoSize = true;
            this.linklblAddress.Enabled = false;
            this.linklblAddress.LinkColor = System.Drawing.Color.Black;
            this.linklblAddress.Location = new System.Drawing.Point(50, 199);
            this.linklblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklblAddress.Name = "linklblAddress";
            this.linklblAddress.Size = new System.Drawing.Size(131, 13);
            this.linklblAddress.TabIndex = 14;
            this.linklblAddress.TabStop = true;
            this.linklblAddress.Text = "Mở danh sách các địa chỉ";
            this.linklblAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblAddress_LinkClicked);
            // 
            // lbXemThu
            // 
            this.lbXemThu.AutoSize = true;
            this.lbXemThu.LinkColor = System.Drawing.Color.Black;
            this.lbXemThu.Location = new System.Drawing.Point(54, 121);
            this.lbXemThu.Name = "lbXemThu";
            this.lbXemThu.Size = new System.Drawing.Size(50, 13);
            this.lbXemThu.TabIndex = 13;
            this.lbXemThu.TabStop = true;
            this.lbXemThu.Text = "Xem Thư";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Enabled = false;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(50, 141);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(67, 13);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Tìm kiếm thư";
            // 
            // linklblCompose
            // 
            this.linklblCompose.AutoSize = true;
            this.linklblCompose.LinkColor = System.Drawing.Color.Black;
            this.linklblCompose.Location = new System.Drawing.Point(50, 101);
            this.linklblCompose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklblCompose.Name = "linklblCompose";
            this.linklblCompose.Size = new System.Drawing.Size(63, 13);
            this.linklblCompose.TabIndex = 11;
            this.linklblCompose.TabStop = true;
            this.linklblCompose.Text = "Tạo thư mới";
            this.linklblCompose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCompose_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(195, 82);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(Inbox)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Xem các thư trong hộp thư";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PeachPuff;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(427, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Các chức năng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Người sử dụng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thư điện tử";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 321);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHome";
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private Button btnLogout;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button btnCompose;
        private TreeView treeView1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private LinkLabel linklblCompose;
        private LinkLabel linkLabel1;
        private Label label6;
        private LinkLabel linkLabel6;
        private LinkLabel linklblAddress;
        private LinkLabel lbXemThu;
        private LinkLabel linkLabel3;
        private Button button8;
    }
}