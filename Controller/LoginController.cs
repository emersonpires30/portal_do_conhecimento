using Microsoft.Data.SqlClient;
using System.Configuration;
using portal_do_conhecimento.Model;
using System.Data;

namespace portal_do_conhecimento.Controller
{
    public class LoginController
    {
        private readonly string _connectionString;

        public LoginController()
        {
            // Obtém a string de conexão do arquivo de configuração App.config
            _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString + ";Database=DBSenac";

            // Cria a tabela no banco de dados se ela ainda não existir
            CriarTabelaSeNaoExistir();
        }

        private void CriarTabelaSeNaoExistir()
        {
            string dbConnectionString = _connectionString;
            using (SqlConnection conn = new SqlConnection(dbConnectionString))
            {
                conn.Open();

                string createTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Users' AND TABLE_SCHEMA = 'dbo')
                    BEGIN
                        CREATE TABLE Users (
                            Id INT IDENTITY(1,1) PRIMARY KEY,
                            Email NVARCHAR(50) UNIQUE NOT NULL,
                            Password NVARCHAR(50) NOT NULL,
                            Name NVARCHAR(150) NOT NULL
                        );
                    END
                ";

                SqlCommand createTableCmd = new SqlCommand(createTableQuery, conn);
                createTableCmd.ExecuteNonQuery();

                // Adicionar um usuário de teste se ele não existir
                string insertQuery = @"
                        IF NOT EXISTS (SELECT * FROM Users WHERE Email = @Email)
                        BEGIN
                            INSERT INTO Users (Email, Password,Name) VALUES (@Email, @Password, @Name);
                        END
                    ";

                // Prepare o comando para inserir o usuário
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@Email", "pdc.senac@gmail.com");
                insertCmd.Parameters.AddWithValue("@Password", "123456");
                insertCmd.Parameters.AddWithValue("@Name", "Admin");
                insertCmd.ExecuteNonQuery();
            }
        }


        public UserModel? Login(string email, string senha)
        {
            string query = "SELECT Id, Name, Email FROM Users WHERE Email = @Email AND Password = @Password";

            // Usando a string de conexão do App.config
            

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();

                    // Preparando o comando SQL para a consulta
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Adicionando parâmetros para evitar SQL Injection
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = email;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = senha;

                        // Executando a consulta e lendo os dados retornados
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Se um usuário for encontrado
                            {
                                // Criando uma instância da model Usuario e preenchendo com os dados retornados
                                UserModel usuario = new UserModel
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    Nome = reader.GetString(reader.GetOrdinal("Name")),
                                    Email = reader.GetString(reader.GetOrdinal("Email"))
                                };

                                // Retornando o usuário
                                return usuario;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ou consultar banco de dados: {ex.Message}");
                    return null;
                }
            }

            // Retorna null se nenhum usuário for encontrado
            return null;
        }
    }

}
