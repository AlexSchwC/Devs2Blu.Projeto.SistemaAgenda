using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.Projeto.SistemaAgenda.Data
{
    public static class ConnectionMySQL
    {
        public static String ConnectionString { get; set; }
        public static String Server { get; set; }
        public static String Database { get; set; }
        public static String User { get; set; }
        public static String Password { get; set; }

        public static MySqlConnection GetConnection()
        {
            Server = "localhost";
            Database = "syslistacontatos";
            User = "root";
            Password = "root";
            ConnectionString = $"Persist Security Info=False;server={Server};database={Database};uid={User};server={Server};uid={User};pwd='{Password}'";
            var conn = new MySqlConnection(ConnectionString);

            try
            {
                conn.Open();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message, "Erro ao Conectar");
                throw;
            }

            return conn;
        }
    }
}
