

namespace portal_do_conhecimento.View
{
    public partial class RegisterUser : Form
    {
        public string UserName { get; private set; }
        public string UserEmail { get; private set; }
        public string UserPhone { get; private set; }
        public string UserAge { get; private set; }
        public string UserNeighborhood { get; private set; }
        public string UserStreet { get; private set; }

        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validações básicas (por exemplo, verificar se os campos não estão vazios)
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtNeighborhood.Text) ||
                string.IsNullOrWhiteSpace(txtStreet.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Atribuindo os valores aos campos públicos para serem acessados depois
            UserName = txtName.Text;
            UserEmail = txtEmail.Text;
            UserPhone = txtPhone.Text;
            UserAge = txtAge.Text;
            UserNeighborhood = txtNeighborhood.Text;
            UserStreet = txtStreet.Text;

            // Fecha o formulário com resultado OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
