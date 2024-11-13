using portal_do_conhecimento.Controller;
using portal_do_conhecimento.Model;
using portal_do_conhecimento.pages;

namespace portal_do_conhecimento
{
    public partial class Login : Form
    {

        private readonly LoginController _loginController;

        public Login()
        {
            InitializeComponent();
            _loginController = new LoginController();
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuario = tfUser.Text;
            string senha = tfPassword.Text;

            UserModel? user = _loginController.Login(usuario, senha);

            if (user != null)
            {
                // Fechar o formulário de Login
                this.Hide();

                // Criar e mostrar o formulário Dashboard
                Darshboard dashboard = new Darshboard(user);
                dashboard.Show();

            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }
    }
}
