using Microsoft.Data.SqlClient;
using portal_do_conhecimento.Model;
using System.Configuration;

namespace portal_do_conhecimento.Controller
{
    public class DashboardController
    {
        private readonly string _connectionString;

        public DashboardController()
        {
            // Obtém a string de conexão do arquivo de configuração App.config
            _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        }

        public void SaveNewClient(ClientModel client)
        {
            string dbConnectionString = _connectionString;
            using (SqlConnection conn = new SqlConnection(dbConnectionString))
            {
                conn.Open();

                string createTableQuery = @"
                        IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Client' AND TABLE_SCHEMA = 'dbo')
                        BEGIN
                            CREATE TABLE Client (
                                Id INT IDENTITY(1,1) PRIMARY KEY,
                                Name NVARCHAR(150) NOT NULL,
                                Email NVARCHAR(150) NOT NULL,
                                Phone NVARCHAR(11) UNIQUE NOT NULL,
                                Age INT NOT NULL CHECK (Age BETWEEN 1 AND 120),
                                Neighborhood NVARCHAR(100) NOT NULL,
                                Street NVARCHAR(100) NOT NULL
                            );
                        END
                    ";

                SqlCommand createTableCmd = new SqlCommand(createTableQuery, conn);
                createTableCmd.ExecuteNonQuery();

                // Adicionar um usuário de teste se ele não existir
                string insertQuery = @"
                        BEGIN
                            INSERT INTO Client (Name, Email,Phone,Age,Neighborhood,Street) VALUES (@Name, @Email,@Phone,@Age,@Neighborhood,@Street);
                        END
                    ";

                // Prepare o comando para inserir o usuário
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@Name", client.Name);
                insertCmd.Parameters.AddWithValue("@Email", client.Email);
                insertCmd.Parameters.AddWithValue("@Phone", client.Phone);
                insertCmd.Parameters.AddWithValue("@Age", client.Age);
                insertCmd.Parameters.AddWithValue("@Neighborhood", client.Neighborhood);
                insertCmd.Parameters.AddWithValue("@Street", client.Street);
                insertCmd.ExecuteNonQuery();
            }
        }

        public List<string>? LoadClientData()
        {
          
            // Consulta para obter os dados da tabela Client
            string query = "SELECT Id, Name, Email, Phone, Age, Neighborhood, Street FROM Client";

            List<string> result = new List<string>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Loop através dos registros retornados
                        while (reader.Read())
                        {
                            // Monta uma string formatada para cada cliente
                            string clientData = $"ID: {reader["Id"]} | Nome: {reader["Name"]} | Email: {reader["Email"]} | " +
                                                $"Telefone: {reader["Phone"]} | Idade: {reader["Age"]} | " +
                                                $"Bairro: {reader["Neighborhood"]} | Rua: {reader["Street"]}";

                            // Adiciona a string ao ListBox
                            result.Add(clientData);
                        }
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
