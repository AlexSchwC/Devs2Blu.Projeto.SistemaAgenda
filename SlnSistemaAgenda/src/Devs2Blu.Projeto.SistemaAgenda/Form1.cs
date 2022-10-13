using Devs2Blu.Projeto.SistemaAgenda.Classes;
using Devs2Blu.Projeto.SistemaAgenda.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
        public UFRepository UFRepository { get; set; }
        public Contato Contato { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            ContatoRepository = new ContatoRepository();
            UFRepository = new UFRepository();

            cbox_cUF.Text = "";

            PopulaUFs();
            PopulaGridContatos();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            btn_ContatoAlterar.Enabled = false;
            btn_ContatoExcluir.Enabled = false;
            Contato = new Contato();
            LimpaFormContato();
        }

        #region ContatoEvents

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

        private void dataGrid_Contatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_Contatos.SelectedCells[0].RowIndex != -1)
            {
                DataGridViewRow row = dataGrid_Contatos.SelectedCells[0].OwningRow;
                GetContatoClicked(row);
                txtb_cNome.Text = Contato.Nome;
                txtb_cTelCel.Text = Contato.Telefone;
                txtb_Email.Text = Contato.Email;
                cbox_cUF.Text = Contato.UF;
                btn_ContatoAlterar.Enabled = true;
                btn_ContatoExcluir.Enabled = true;
            }
        }

        private void btn_ContatoAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            Contato.Nome = txtb_cNome.Text;
            Contato.Telefone = txtb_cTelCel.Text;
            Contato.Email = txtb_Email.Text;
            Contato.UF = cbox_cUF.Text;
            ContatoRepository.UpdateContato(Contato, conn);
            conn.Close();
            PopulaGridContatos();
        }

        private void btn_ContatoExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            ContatoRepository.DeleteContato(Contato, conn);
            conn.Close();
            LimpaFormContato();
            PopulaGridContatos();
        }

        #endregion

        #endregion

        #region Methods

        private void PopulaGridContatos()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            MySqlDataReader listContatos = ContatoRepository.GetAllContatos(conn);
            dataGrid_Contatos.DataSource = new BindingSource(listContatos, null);
            
            conn.Close();
        }

        private void PopulaUFs()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            MySqlDataReader listUFs = UFRepository.FetchAllUFs(conn);
            cbox_cUF.DataSource = new BindingSource(listUFs, null);
            cbox_cUF.DisplayMember = "UF";
            cbox_cUF.ValueMember = "UF";
            conn.Close();
        }

        private void GetContatoClicked(DataGridViewRow row)
        {
            Contato = new Contato();
            Contato.Id = (int)row.Cells["id"].Value;
            Contato.Nome = row.Cells["nome"].Value.ToString();
            Contato.Telefone = row.Cells["telefone"].Value.ToString();
            Contato.Email = row.Cells["email"].Value.ToString();
            Contato.UF = row.Cells["uf"].Value.ToString();
            //contato.Status = row.Cells["fl_status"].Value.ToString();
        }

        private void LimpaFormContato()
        {
            txtb_cNome.Clear();
            txtb_cTelCel.Clear();
            txtb_Email.Clear();
            cbox_cUF.Text = "";
        }


        #endregion

    }
}
