using Devs2Blu.Projeto.SistemaAgenda.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.Projeto.SistemaAgenda.Data
{
    public class CompromissoRepository
    {
        public void SaveCompromisso(Compromisso compromisso, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd;
                if(compromisso.Contato != null)
                {
                    cmd = new MySqlCommand(SQL_INSERT_COMPROMISSO_CONTATO, conn);
                    cmd.Parameters.Add("@id_contato", MySqlDbType.Int32).Value = compromisso.Contato.Id;
                } else
                {
                    cmd = new MySqlCommand(SQL_INSERT_COMPROMISSO, conn);
                }
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 125).Value = compromisso.Descricao;
                cmd.Parameters.Add("@data", MySqlDbType.Date).Value = compromisso.Data;
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Compromisso criado!", "Sucesso");
            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message, myEx.Code + " Erro de MySql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void UpdateCompromisso(Compromisso compromisso, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd;
                if (compromisso.Contato.Id != 0)
                {
                    cmd = new MySqlCommand(SQL_UPDATE_COMPROMISSO_CONTATO, conn);
                    cmd.Parameters.Add("@id_contato", MySqlDbType.Int32).Value = compromisso.Contato.Id;
                } else
                {
                    cmd = new MySqlCommand(SQL_UPDATE_COMPROMISSO, conn);
                }
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 125).Value = compromisso.Descricao;
                cmd.Parameters.Add("@data", MySqlDbType.DateTime).Value = compromisso.Data;
                cmd.Parameters.Add("@id_compromisso", MySqlDbType.Int32).Value = compromisso.Id;
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Coompromisso Alterado!", "Sucesso");
            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message, myEx.Code + " Erro de MySql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void UpdateStatusCompromisso(String status, DataGridViewRow row, MySqlConnection conn)
        {
            MySqlCommand cmd;
            if (status.Equals("SIM"))
            {
                try
                {
                    cmd = new MySqlCommand(SQL_UPDATE_STATUS_ToNAO, conn);
                    cmd.Parameters.Add("@id_compromisso", MySqlDbType.Int32).Value = (int)row.Cells["id"].Value;
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException myEx)
                {
                    MessageBox.Show(myEx.Message, myEx.Code + " Erro de MySql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            } else if (status.Equals("NAO"))
            {
                try
                {
                    cmd = new MySqlCommand(SQL_UPDATE_STATUS_ToSIM, conn);
                    cmd.Parameters.Add("@id_compromisso", MySqlDbType.Int32).Value = (int)row.Cells["id"].Value;
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException myEx)
                {
                    MessageBox.Show(myEx.Message, myEx.Code + " Erro de MySql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        public void DeleteCompromisso(Compromisso compromisso, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_COMPROMISSO, conn);
                cmd.Parameters.Add("@id_compromisso", MySqlDbType.Int32).Value = compromisso.Id;
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Compromisso excluido!", "Sucesso");
            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message, myEx.Code + " Erro de MySql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader GetAllCompromissos(MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ALL_COMPROMISSOS, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message, myEx.Code + " Erro de MySql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLs

        const String SQL_SELECT_ALL_COMPROMISSOS = "SELECT * FROM compromisso;";

        const String SQL_INSERT_COMPROMISSO = @"INSERT INTO compromisso
(
    descricao,
    data,
    fl_concluido
) VALUES 
(
    @descricao,
    @data,
    'NAO'
)";
        const String SQL_INSERT_COMPROMISSO_CONTATO = @"INSERT INTO compromisso
(
	id_contato,
    descricao,
    data,
    fl_concluido
) VALUES 
(
	@id_contato,
    @descricao,
    @data,
    'NAO'
)";

        const String SQL_UPDATE_COMPROMISSO_CONTATO = @"UPDATE compromisso
SET
id_contato = @id_contato,
descricao = @descricao,
data = @data
WHERE id = @id_compromisso;";
        const String SQL_UPDATE_COMPROMISSO = @"UPDATE compromisso
SET
descricao = @descricao,
data = @data
WHERE id = @id_compromisso;";
        const String SQL_UPDATE_STATUS_ToSIM = "UPDATE compromisso SET fl_concluido = 'SIM' WHERE id = @id_compromisso";
        const String SQL_UPDATE_STATUS_ToNAO = "UPDATE compromisso SET fl_concluido = 'NAO' WHERE id = @id_compromisso";

        const String SQL_DELETE_COMPROMISSO = @"DELETE FROM compromisso WHERE id = @id_compromisso";

        #endregion
    }
}
