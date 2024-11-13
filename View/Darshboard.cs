using Microsoft.Data.SqlClient;
using portal_do_conhecimento.Controller;
using portal_do_conhecimento.Model;
using portal_do_conhecimento.View;
using System.Configuration;

namespace portal_do_conhecimento.pages
{
    public partial class Darshboard : Form
    {
        private readonly DashboardController _dashboardController;
        public readonly UserModel user;
        public Darshboard(UserModel user)
        {
            this.user = user;
            _dashboardController = new DashboardController();
            InitializeComponent();
            setUser();
            LoadClientData();
        }

        private void setUser()
        {

            labelUser.Text = user.Nome;
            labelEmail.Text = user.Email;
        }

        private void panelRegisterClient_Click(object sender, EventArgs e)
        {
            ShowUserRegistrationPopup();
        }

        private void ShowUserRegistrationPopup()
        {
            using (RegisterUser registrationForm = new RegisterUser())
            {
                // Exibe o formulário de cadastro como modal
                var result = registrationForm.ShowDialog();

                // Verifica se o usuário completou o cadastro e clicou em "OK"
                if (result == DialogResult.OK)
                {
                    // Criando uma instância da model Client
                    ClientModel client = new ClientModel
                    {

                        Name = registrationForm.UserName,
                        Email = registrationForm.UserEmail,
                        Phone = registrationForm.UserPhone,
                        Age = int.Parse(registrationForm.UserAge),
                        Neighborhood = registrationForm.UserNeighborhood,
                        Street = registrationForm.UserStreet
                    };
                    // Aqui você pode chamar uma função para salvar o usuário no banco de dados
                    _dashboardController.SaveNewClient(client);
                    LoadClientData();

                    MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }

        }

        private void LoadClientData()
        {
            // Limpar o ListBox antes de adicionar novos itens
            ListBoxUsers.Items.Clear();

            // Carregar os dados dos clientes
            List<string>? clientDataList = _dashboardController.LoadClientData();

            // Verificar se a lista retornada não é nula e contém dados
            if (clientDataList != null && clientDataList.Count > 0)
            {
                // Adicionar todos os itens da lista no ListBox
                ListBoxUsers.Items.AddRange(clientDataList.ToArray());
            }
            else
            {
                // Adicionar uma mensagem padrão se não houver dados
                ListBoxUsers.Items.Add("Nenhum cliente encontrado.");
            }
        }

    }
}
