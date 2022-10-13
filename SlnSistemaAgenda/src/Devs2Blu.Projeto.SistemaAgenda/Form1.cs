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
        public CompromissoRepository CompromissoRepository { get; set; }
        public UFRepository UFRepository { get; set; }
        public Contato Contato { get; set; }
        public Compromisso Compromisso { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            ContatoRepository = new ContatoRepository();
            CompromissoRepository = new CompromissoRepository();
            UFRepository = new UFRepository();

            PopulaUFs();
            cbox_cUF.Text = "";

            PopulaGridContatos();
            PopulaGridCompromissos();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetFormContato();
            ResetFormCompromissos();
            Contato = new Contato();
            Compromisso = new Compromisso();
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
            ResetFormContato();
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
                txtb_ContatoNome.Text = Contato.Nome;
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
            ResetFormContato();
            PopulaGridContatos();
        }

        private void btn_ContatoExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            ContatoRepository.DeleteContato(Contato, conn);
            conn.Close();
            ResetFormContato();
            PopulaGridContatos();
        }

        #endregion

        #region CompromissosEvents

        private void btn_CompromissoSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            Compromisso compromisso = new Compromisso();
            if(txtb_ContatoNome.Text != "")
            {
                compromisso.Contato = Contato;
            }
            compromisso.Descricao = txtb_DescricaoCompromisso.Text;
            compromisso.Data = dateTimePicker.Value.Date;
            CompromissoRepository.SaveCompromisso(compromisso, conn);
            conn.Close();
            PopulaGridCompromissos();
            ResetFormCompromissos();
        }

        private void dataGrid_Compromissos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_Compromissos.SelectedCells[0].RowIndex != -1)
            {
                DataGridViewRow row = dataGrid_Compromissos.SelectedCells[0].OwningRow;
                GetCompromissoClicked(row);
                //MessageBox.Show($"{Compromisso.Contato.Id}");
                dateTimePicker.Value = Compromisso.Data;
                txtb_DescricaoCompromisso.Text = Compromisso.Descricao;

                if (Compromisso.Contato.Id > 0)
                {
                    foreach (DataGridViewRow rows in dataGrid_Contatos.Rows)
                    {
                        if (rows.Cells[0].Value.Equals(Compromisso.Contato.Id))
                        {
                            txtb_ContatoNome.Text = rows.Cells["nome"].Value.ToString();
                            break;
                        }
                    }
                }

                btn_CompromissoAlterar.Enabled = true;
                btn_CompromissoExcluir.Enabled = true;
            }
        }

        private void btn_CompromissoAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            if (txtb_ContatoNome.Text != "")
            {
                Compromisso.Contato = Contato;
            }
            Compromisso.Descricao = txtb_DescricaoCompromisso.Text;
            Compromisso.Data = dateTimePicker.Value.Date;
            CompromissoRepository.UpdateCompromisso(Compromisso, conn);
            conn.Close();
            PopulaGridCompromissos();
            ResetFormCompromissos();
        }

        private void btn_CompromissoExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            CompromissoRepository.DeleteCompromisso(Compromisso, conn);
            conn.Close();
            PopulaGridCompromissos();
            ResetFormCompromissos();
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

        private void PopulaGridCompromissos()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            MySqlDataReader listCompromissos = CompromissoRepository.GetAllCompromissos(conn);
            dataGrid_Compromissos.DataSource = new BindingSource(listCompromissos, null);

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
            //Não sei como converter para Enum
            //Contato.Status = row.Cells["fl_status"].Value.ToString();
        }

        private void GetCompromissoClicked(DataGridViewRow row)
        {
            Compromisso = new Compromisso();
            Compromisso.Contato = new Contato();
            Contato = new Contato();
            Compromisso.Id = (int)row.Cells["id"].Value;


            bool compromissoPossuiContato = true;
            if (row.Cells["id_contato"].Value == System.DBNull.Value)
            {
                compromissoPossuiContato = false;
                txtb_ContatoNome.Clear();
                Contato = new Contato();
            }

            if (compromissoPossuiContato == true)
            {
                Compromisso.Contato.Id = (int)row.Cells["id_contato"].Value;
            }

            Compromisso.Descricao = row.Cells["descricao"].Value.ToString();
            Compromisso.Data = Convert.ToDateTime(row.Cells["data"].Value.ToString());
        }
        
        private void ResetFormContato()
        {
            LimpaFormContato();
            btn_ContatoAlterar.Enabled = false;
            btn_ContatoExcluir.Enabled = false;
        }

        private void ResetFormCompromissos()
        {
            LimpaFormCompromisso();
            btn_CompromissoAlterar.Enabled = false;
            btn_CompromissoExcluir.Enabled = false;
        }

        private void LimpaFormContato()
        {
            txtb_cNome.Clear();
            txtb_cTelCel.Clear();
            txtb_Email.Clear();
            cbox_cUF.Text = "";
        }

        private void LimpaFormCompromisso()
        {
            txtb_ContatoNome.Clear();
            txtb_DescricaoCompromisso.Clear();
            dateTimePicker.Refresh();
        }



        #endregion

        
    }
}
