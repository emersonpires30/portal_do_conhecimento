using Microsoft.Data.SqlClient;
using portal_do_conhecimento.pages;
using System.Configuration;

namespace portal_do_conhecimento
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}