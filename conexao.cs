using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace clinicaVeterinaria
{
    internal class conexao
    {
        private const string server = "localhost";
        private const string bd = "clinica_veterinaria";
        private const string user = "root";
        private const string password = "";

        static public string strConexao = $"server={server}; uid={user}; database={bd}; password={password};";
    }
}
