namespace portal_do_conhecimento
{
    internal static class Program
    {
        [STAThread]
        /// Funcao inicial da aplicacao, é a primeira a ser chamada quando executa o projeto
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            /// exibe a tela de Login
            Application.Run(new Login());
        }
    }
}