namespace portal_do_conhecimento.pages
{
    partial class Darshboard
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Darshboard));
            splitContainer1 = new SplitContainer();
            panelRegisterBook = new Panel();
            panel14 = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panelRegisterClient = new Panel();
            panel13 = new Panel();
            label3 = new Label();
            pictureBox7 = new PictureBox();
            panelHomePage = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            labelEmail = new Label();
            labelUser = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            panel10 = new Panel();
            labelQuantBoosEmp = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            panel8 = new Panel();
            panel11 = new Panel();
            labelQuantBooksVend = new Label();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            panel7 = new Panel();
            panel9 = new Panel();
            labelQuantBooks = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            ListBoxUsers = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelRegisterBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelRegisterClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panelHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(panelRegisterBook);
            splitContainer1.Panel1.Controls.Add(panelRegisterClient);
            splitContainer1.Panel1.Controls.Add(panelHomePage);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(1307, 554);
            splitContainer1.SplitterDistance = 236;
            splitContainer1.TabIndex = 0;
            // 
            // panelRegisterBook
            // 
            panelRegisterBook.BackColor = Color.White;
            panelRegisterBook.Controls.Add(panel14);
            panelRegisterBook.Controls.Add(label5);
            panelRegisterBook.Controls.Add(pictureBox3);
            panelRegisterBook.Dock = DockStyle.Top;
            panelRegisterBook.Location = new Point(0, 221);
            panelRegisterBook.Name = "panelRegisterBook";
            panelRegisterBook.Padding = new Padding(3);
            panelRegisterBook.Size = new Size(236, 46);
            panelRegisterBook.TabIndex = 3;
            // 
            // panel14
            // 
            panel14.BackColor = Color.DarkGray;
            panel14.Dock = DockStyle.Bottom;
            panel14.Location = new Point(3, 42);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(230, 1);
            panel14.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 15);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 1;
            label5.Text = "Adicionar Livro";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panelRegisterClient
            // 
            panelRegisterClient.BackColor = Color.White;
            panelRegisterClient.Controls.Add(panel13);
            panelRegisterClient.Controls.Add(label3);
            panelRegisterClient.Controls.Add(pictureBox7);
            panelRegisterClient.Dock = DockStyle.Top;
            panelRegisterClient.Location = new Point(0, 175);
            panelRegisterClient.Name = "panelRegisterClient";
            panelRegisterClient.Padding = new Padding(3);
            panelRegisterClient.Size = new Size(236, 46);
            panelRegisterClient.TabIndex = 2;
            panelRegisterClient.Click += panelRegisterClient_Click;
            // 
            // panel13
            // 
            panel13.BackColor = Color.DarkGray;
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(3, 42);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(230, 1);
            panel13.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 16);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 1;
            label3.Text = "Adicionar Cliente";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 6);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 31);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // panelHomePage
            // 
            panelHomePage.BackColor = Color.White;
            panelHomePage.Controls.Add(panel3);
            panelHomePage.Controls.Add(label1);
            panelHomePage.Controls.Add(pictureBox2);
            panelHomePage.Dock = DockStyle.Top;
            panelHomePage.Location = new Point(0, 129);
            panelHomePage.Name = "panelHomePage";
            panelHomePage.Padding = new Padding(3);
            panelHomePage.Size = new Size(236, 46);
            panelHomePage.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 42);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 1);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 15);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Página Inicial";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 129);
            panel1.TabIndex = 0;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Microsoft Sans Serif", 5.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = SystemColors.ControlDark;
            labelEmail.Location = new Point(78, 80);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 7);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "emerson@gmail.com";
            // 
            // labelUser
            // 
            labelUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelUser.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUser.Location = new Point(77, 55);
            labelUser.Margin = new Padding(0);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(74, 13);
            labelUser.TabIndex = 1;
            labelUser.Text = "Emerson Pires";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Controls.Add(ListBoxUsers, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.8086624F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.1913376F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1067, 554);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel5);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(1061, 208);
            panel6.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(labelQuantBoosEmp);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(pictureBox5);
            panel10.Location = new Point(352, 9);
            panel10.Name = "panel10";
            panel10.Size = new Size(334, 182);
            panel10.TabIndex = 3;
            // 
            // labelQuantBoosEmp
            // 
            labelQuantBoosEmp.AutoSize = true;
            labelQuantBoosEmp.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQuantBoosEmp.ForeColor = Color.MediumBlue;
            labelQuantBoosEmp.Location = new Point(127, 96);
            labelQuantBoosEmp.Name = "labelQuantBoosEmp";
            labelQuantBoosEmp.Size = new Size(20, 24);
            labelQuantBoosEmp.TabIndex = 2;
            labelQuantBoosEmp.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 43);
            label4.Name = "label4";
            label4.Size = new Size(127, 16);
            label4.TabIndex = 1;
            label4.Text = "Livros Emprestados";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(22, 25);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(68, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel11);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(705, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(356, 208);
            panel8.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Controls.Add(labelQuantBooksVend);
            panel11.Controls.Add(label6);
            panel11.Controls.Add(pictureBox6);
            panel11.Location = new Point(24, 9);
            panel11.Name = "panel11";
            panel11.Size = new Size(310, 182);
            panel11.TabIndex = 4;
            // 
            // labelQuantBooksVend
            // 
            labelQuantBooksVend.AutoSize = true;
            labelQuantBooksVend.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQuantBooksVend.ForeColor = Color.MediumBlue;
            labelQuantBooksVend.Location = new Point(127, 96);
            labelQuantBooksVend.Name = "labelQuantBooksVend";
            labelQuantBooksVend.Size = new Size(20, 24);
            labelQuantBooksVend.TabIndex = 2;
            labelQuantBooksVend.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(96, 43);
            label6.Name = "label6";
            label6.Size = new Size(104, 16);
            label6.TabIndex = 1;
            label6.Text = "Livros Vendidos";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(22, 25);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(68, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel9);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(334, 208);
            panel7.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(labelQuantBooks);
            panel9.Controls.Add(label2);
            panel9.Controls.Add(pictureBox4);
            panel9.Location = new Point(19, 9);
            panel9.Name = "panel9";
            panel9.Size = new Size(293, 182);
            panel9.TabIndex = 0;
            // 
            // labelQuantBooks
            // 
            labelQuantBooks.AutoSize = true;
            labelQuantBooks.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQuantBooks.ForeColor = Color.MediumBlue;
            labelQuantBooks.Location = new Point(127, 96);
            labelQuantBooks.Name = "labelQuantBooks";
            labelQuantBooks.Size = new Size(20, 24);
            labelQuantBooks.TabIndex = 2;
            labelQuantBooks.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 43);
            label2.Name = "label2";
            label2.Size = new Size(124, 16);
            label2.TabIndex = 1;
            label2.Text = "Livros Cadastrados";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 25);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(268, 208);
            panel5.TabIndex = 0;
            // 
            // ListBoxUsers
            // 
            ListBoxUsers.Dock = DockStyle.Fill;
            ListBoxUsers.FormattingEnabled = true;
            ListBoxUsers.ItemHeight = 15;
            ListBoxUsers.Location = new Point(3, 217);
            ListBoxUsers.Name = "ListBoxUsers";
            ListBoxUsers.Size = new Size(1061, 334);
            ListBoxUsers.TabIndex = 3;
            // 
            // Darshboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 554);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Darshboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Portal do Conhecimento";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelRegisterBook.ResumeLayout(false);
            panelRegisterBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelRegisterClient.ResumeLayout(false);
            panelRegisterClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panelHomePage.ResumeLayout(false);
            panelHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel8.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label labelUser;
        private PictureBox pictureBox1;
        private Panel panelHomePage;
        private Label labelEmail;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel8;
        private Panel panel7;
        private Panel panel5;
        private Panel panel9;
        private Label labelQuantBooks;
        private Label label2;
        private PictureBox pictureBox4;
        private Panel panel10;
        private Label labelQuantBoosEmp;
        private Label label4;
        private PictureBox pictureBox5;
        private Panel panel11;
        private Label labelQuantBooksVend;
        private Label label6;
        private PictureBox pictureBox6;
        private Panel panelRegisterClient;
        private Panel panel13;
        private Label label3;
        private PictureBox pictureBox7;
        private ListBox ListBoxUsers;
        private Panel panelRegisterBook;
        private Panel panel14;
        private Label label5;
        private PictureBox pictureBox3;
    }
}