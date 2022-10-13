using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaAgenda.Data
{
    public class UFRepository
    {
        public MySqlDataReader FetchAllUFs(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand(GET_UFs, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }

        #region SQLs

        const String GET_UFs = "SELECT uf FROM estados";

        #endregion
    }
}
