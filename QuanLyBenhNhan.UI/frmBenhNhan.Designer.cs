namespace QuanLyBenhNhan.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbo1 = new GroupBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            rtxtGhiChu = new RichTextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtTenBN = new TextBox();
            txtMaBN = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            btnCapNhat = new Button();
            btnThoat = new Button();
            label6 = new Label();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            gbo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gbo1
            // 
            gbo1.Controls.Add(comboBox2);
            gbo1.Controls.Add(label1);
            gbo1.Controls.Add(rtxtGhiChu);
            gbo1.Controls.Add(label5);
            gbo1.Controls.Add(comboBox1);
            gbo1.Controls.Add(label4);
            gbo1.Controls.Add(label3);
            gbo1.Controls.Add(txtTenBN);
            gbo1.Controls.Add(txtMaBN);
            gbo1.Controls.Add(label2);
            gbo1.Location = new Point(12, 77);
            gbo1.Name = "gbo1";
            gbo1.Size = new Size(316, 416);
            gbo1.TabIndex = 1;
            gbo1.TabStop = false;
            gbo1.Text = "Thông tin bệnh nhân";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(105, 382);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 385);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 8;
            label1.Text = "Lây nhiễm từ";
            // 
            // rtxtGhiChu
            // 
            rtxtGhiChu.Location = new Point(105, 236);
            rtxtGhiChu.Name = "rtxtGhiChu";
            rtxtGhiChu.Size = new Size(207, 125);
            rtxtGhiChu.TabIndex = 7;
            rtxtGhiChu.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 239);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 6;
            label5.Text = "Ghi chú";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(105, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 184);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 4;
            label4.Text = "Tình trạng";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 128);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên BN";
            // 
            // txtTenBN
            // 
            txtTenBN.Location = new Point(105, 125);
            txtTenBN.Name = "txtTenBN";
            txtTenBN.Size = new Size(193, 27);
            txtTenBN.TabIndex = 2;
            // 
            // txtMaBN
            // 
            txtMaBN.Location = new Point(105, 67);
            txtMaBN.Name = "txtMaBN";
            txtMaBN.Size = new Size(125, 27);
            txtMaBN.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã BN";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(346, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(672, 438);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1018, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêToolStripMenuItem, thoátToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(85, 499);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(198, 499);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(255, 42);
            label6.Name = "label6";
            label6.Size = new Size(462, 32);
            label6.TabIndex = 6;
            label6.Text = "Thông tin ca bệnh COVID-19 tại Việt Nam";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            thốngKêToolStripMenuItem.Size = new Size(224, 26);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 540);
            Controls.Add(label6);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(dataGridView1);
            Controls.Add(gbo1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Quản lý thông tin bệnh nhân";
            Load += Form1_Load;
            gbo1.ResumeLayout(false);
            gbo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbo1;
        private TextBox txtTenBN;
        private TextBox txtMaBN;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private RichTextBox rtxtGhiChu;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private Button btnCapNhat;
        private Button btnThoat;
        private Label label6;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}
