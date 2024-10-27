namespace portal_do_conhecimento
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tfUser_TextChanged(object sender, EventArgs e)
        {

            // Converte o sender para TextBox
            TextBox? textBox = sender as TextBox;
            if (textBox != null)
                if (tfUser.Text.Length >= 7 && tfUser.Text.Substring(0, 7) == "Usuário")
                {
                    tfUser.Text = textBox.Text.Substring(7);
                    textBox.SelectionStart = textBox.Text.Length;
                }
        }

        private void tfPassword_TextChanged(object sender, EventArgs e)
        {
            // Converte o sender para TextBox
            TextBox? textBox = sender as TextBox;
            if (textBox != null)
                if (tfPassword.Text.Length >= 5 && tfPassword.Text.Substring(0, 5) == "Senha")
                {
                    tfPassword.Text = textBox.Text.Substring(5);
                    textBox.SelectionStart = textBox.Text.Length;
                }
        }

        private void buttonCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
