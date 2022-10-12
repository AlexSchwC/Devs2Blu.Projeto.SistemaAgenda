using Devs2Blu.Projeto.SistemaAgenda.Classes;
using Devs2Blu.Projeto.SistemaAgenda.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.Projeto.SistemaAgenda
{
    public partial class Form1 : Form
    {
        public ContatoRepository ContatoRepository { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContatoRepository = new ContatoRepository();

            PopulaGridContatos();
        }

        private void btn_ContatoSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            Contato contato = new Contato();
            contato.Nome = txtb_cNome.Text;
            contato.Telefone = txtb_cTelCel.Text;
            contato.Email = txtb_Email.Text;
            contato.UF = cbox_cUF.Text;
            ContatoRepository.SaveContato(contato, conn);
            conn.Close();
            PopulaGridContatos();
        }

        #region Methods

        private void PopulaGridContatos()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            MySqlDataReader listContatos = ContatoRepository.GetAllContatos(conn);
            dataGrid_Contatos.DataSource = new BindingSource(listContatos, null);
            
            conn.Close();
        }

        #endregion
    }
}
