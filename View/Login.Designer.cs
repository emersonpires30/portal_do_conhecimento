namespace portal_do_conhecimento
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            tfUser = new TextBox();
            tfPassword = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            buttonLogin = new Button();
            buttonCloseApplication = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonCloseApplication).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(94, 230);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 1;
            label2.Text = "v1.0.0";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 330);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(377, 151);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 1);
            panel2.TabIndex = 1;
            // 
            // tfUser
            // 
            tfUser.BackColor = Color.FromArgb(15, 15, 15);
            tfUser.BorderStyle = BorderStyle.None;
            tfUser.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tfUser.ForeColor = Color.DarkGray;
            tfUser.Location = new Point(377, 129);
            tfUser.Name = "tfUser";
            tfUser.Size = new Size(272, 20);
            tfUser.TabIndex = 2;
            tfUser.Text = "Usuário";
            tfUser.TextChanged += tfUser_TextChanged;
            // 
            // tfPassword
            // 
            tfPassword.BackColor = Color.FromArgb(15, 15, 15);
            tfPassword.BorderStyle = BorderStyle.None;
            tfPassword.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tfPassword.ForeColor = Color.DarkGray;
            tfPassword.Location = new Point(377, 178);
            tfPassword.Name = "tfPassword";
            tfPassword.Size = new Size(272, 20);
            tfPassword.TabIndex = 4;
            tfPassword.Text = "Senha";
            tfPassword.UseSystemPasswordChar = true;
            tfPassword.TextChanged += tfPassword_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(377, 200);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 1);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(469, 61);
            label1.Name = "label1";
            label1.Size = new Size(80, 35);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(477, 244);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Entrar";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCloseApplication
            // 
            buttonCloseApplication.BackColor = Color.Black;
            buttonCloseApplication.Image = (Image)resources.GetObject("buttonCloseApplication.Image");
            buttonCloseApplication.Location = new Point(757, 4);
            buttonCloseApplication.Name = "buttonCloseApplication";
            buttonCloseApplication.Size = new Size(15, 15);
            buttonCloseApplication.SizeMode = PictureBoxSizeMode.Zoom;
            buttonCloseApplication.TabIndex = 7;
            buttonCloseApplication.TabStop = false;
            buttonCloseApplication.Click += buttonCloseApplication_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 5);
            ClientSize = new Size(780, 330);
            Controls.Add(buttonCloseApplication);
            Controls.Add(buttonLogin);
            Controls.Add(label1);
            Controls.Add(tfPassword);
            Controls.Add(panel3);
            Controls.Add(tfUser);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonCloseApplication).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox tfUser;
        private TextBox tfPassword;
        private Panel panel3;
        private Label label1;
        private Button buttonLogin;
        private PictureBox buttonCloseApplication;
        private Label label2;
        private PictureBox pictureBox2;
    }
}
