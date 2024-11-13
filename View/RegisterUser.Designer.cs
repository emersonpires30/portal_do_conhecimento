namespace portal_do_conhecimento.View
{
    partial class RegisterUser
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Formulários do Windows

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            btnRegister = new Button();
            lblStreet = new Label();
            lblNeighborhood = new Label();
            lblAge = new Label();
            txtStreet = new TextBox();
            txtNeighborhood = new TextBox();
            txtAge = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 23);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 66);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(88, 103);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(176, 23);
            txtPhone.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(26, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 68);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(26, 106);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(54, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Telefone:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(264, 166);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(88, 28);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(352, 109);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(30, 15);
            lblStreet.TabIndex = 12;
            lblStreet.Text = "Rua:";
            // 
            // lblNeighborhood
            // 
            lblNeighborhood.AutoSize = true;
            lblNeighborhood.Location = new Point(352, 71);
            lblNeighborhood.Name = "lblNeighborhood";
            lblNeighborhood.Size = new Size(41, 15);
            lblNeighborhood.TabIndex = 11;
            lblNeighborhood.Text = "Bairro:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(352, 34);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 15);
            lblAge.TabIndex = 10;
            lblAge.Text = "Idade:";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(414, 106);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(176, 23);
            txtStreet.TabIndex = 9;
            // 
            // txtNeighborhood
            // 
            txtNeighborhood.Location = new Point(414, 69);
            txtNeighborhood.Name = "txtNeighborhood";
            txtNeighborhood.Size = new Size(176, 23);
            txtNeighborhood.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(414, 31);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(176, 23);
            txtAge.TabIndex = 7;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 206);
            Controls.Add(lblStreet);
            Controls.Add(lblNeighborhood);
            Controls.Add(lblAge);
            Controls.Add(txtStreet);
            Controls.Add(txtNeighborhood);
            Controls.Add(txtAge);
            Controls.Add(btnRegister);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "RegisterUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnRegister;
        private Label lblStreet;
        private Label lblNeighborhood;
        private Label lblAge;
        private TextBox txtStreet;
        private TextBox txtNeighborhood;
        private TextBox txtAge;
    }
}