using Devs2Blu.Projeto.SistemaAgenda.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.Projeto.SistemaAgenda.Data
{
    public class ContatoRepository
    {
        public void SaveContato(Contato contato, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_CONTATO, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 55).Value = contato.Nome;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 20).Value = contato.Telefone;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = contato.Email;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = contato.UF;
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Contato {contato.Nome} criado!", "Sucesso");
            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message, myEx.Code + " Erro de MySql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        internal MySqlDataReader GetAllContatos (MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ALL_CONTATOS, conn);
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

        const String SQL_INSERT_CONTATO = @"INSERT INTO contatos 
	(
		nome,
        telefone,
        email,
        uf,
        fl_status
	) VALUES 
    (
		@nome,
        @telefone,
        @email,
        @uf,
        'A'
    );";
        const String SQL_SELECT_ALL_CONTATOS = @"SELECT * FROM contatos";

        #endregion
    }
}
