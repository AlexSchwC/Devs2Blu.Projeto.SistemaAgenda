namespace Devs2Blu.Projeto.SistemaAgenda
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGrid_Compromissos = new System.Windows.Forms.DataGridView();
            this.dataGrid_Contatos = new System.Windows.Forms.DataGridView();
            this.lbl_Contato = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_cNome = new System.Windows.Forms.Label();
            this.lbl_cEmail = new System.Windows.Forms.Label();
            this.lbl_cTelCel = new System.Windows.Forms.Label();
            this.lbl_cUF = new System.Windows.Forms.Label();
            this.txtb_cNome = new System.Windows.Forms.TextBox();
            this.txtb_Email = new System.Windows.Forms.TextBox();
            this.txtb_cTelCel = new System.Windows.Forms.MaskedTextBox();
            this.cbox_cUF = new System.Windows.Forms.ComboBox();
            this.btn_ContatoSalvar = new System.Windows.Forms.Button();
            this.btn_ContatoAlterar = new System.Windows.Forms.Button();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.txtb_ContatoNome = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtb_DescricaoCompromisso = new System.Windows.Forms.TextBox();
            this.btn_CompromissoSalvar = new System.Windows.Forms.Button();
            this.btn_CompromissoAlterar = new System.Windows.Forms.Button();
            this.btn_CompromissoExcluir = new System.Windows.Forms.Button();
            this.btn_ContatoExcluir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Compromissos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Contatos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CompromissoExcluir);
            this.groupBox1.Controls.Add(this.btn_CompromissoAlterar);
            this.groupBox1.Controls.Add(this.btn_CompromissoSalvar);
            this.groupBox1.Controls.Add(this.txtb_DescricaoCompromisso);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.txtb_ContatoNome);
            this.groupBox1.Controls.Add(this.lbl_Descricao);
            this.groupBox1.Controls.Add(this.lbl_Data);
            this.groupBox1.Controls.Add(this.lbl_Contato);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Compromisso";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGrid_Compromissos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(368, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Compromissos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGrid_Contatos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(368, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 264);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Contatos";
            // 
            // dataGrid_Compromissos
            // 
            this.dataGrid_Compromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Compromissos.Location = new System.Drawing.Point(11, 22);
            this.dataGrid_Compromissos.Name = "dataGrid_Compromissos";
            this.dataGrid_Compromissos.RowHeadersWidth = 51;
            this.dataGrid_Compromissos.Size = new System.Drawing.Size(623, 268);
            this.dataGrid_Compromissos.TabIndex = 0;
            // 
            // dataGrid_Contatos
            // 
            this.dataGrid_Contatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Contatos.Location = new System.Drawing.Point(11, 25);
            this.dataGrid_Contatos.Name = "dataGrid_Contatos";
            this.dataGrid_Contatos.RowHeadersWidth = 51;
            this.dataGrid_Contatos.Size = new System.Drawing.Size(623, 230);
            this.dataGrid_Contatos.TabIndex = 1;
            // 
            // lbl_Contato
            // 
            this.lbl_Contato.AutoSize = true;
            this.lbl_Contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contato.Location = new System.Drawing.Point(14, 40);
            this.lbl_Contato.Name = "lbl_Contato";
            this.lbl_Contato.Size = new System.Drawing.Size(61, 17);
            this.lbl_Contato.TabIndex = 0;
            this.lbl_Contato.Text = "Contato:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_ContatoExcluir);
            this.groupBox4.Controls.Add(this.btn_ContatoAlterar);
            this.groupBox4.Controls.Add(this.btn_ContatoSalvar);
            this.groupBox4.Controls.Add(this.cbox_cUF);
            this.groupBox4.Controls.Add(this.txtb_cTelCel);
            this.groupBox4.Controls.Add(this.txtb_Email);
            this.groupBox4.Controls.Add(this.txtb_cNome);
            this.groupBox4.Controls.Add(this.lbl_cUF);
            this.groupBox4.Controls.Add(this.lbl_cTelCel);
            this.groupBox4.Controls.Add(this.lbl_cEmail);
            this.groupBox4.Controls.Add(this.lbl_cNome);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 264);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cadastrar Contato";
            // 
            // lbl_cNome
            // 
            this.lbl_cNome.AutoSize = true;
            this.lbl_cNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cNome.Location = new System.Drawing.Point(14, 32);
            this.lbl_cNome.Name = "lbl_cNome";
            this.lbl_cNome.Size = new System.Drawing.Size(49, 17);
            this.lbl_cNome.TabIndex = 0;
            this.lbl_cNome.Text = "Nome:";
            // 
            // lbl_cEmail
            // 
            this.lbl_cEmail.AutoSize = true;
            this.lbl_cEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cEmail.Location = new System.Drawing.Point(14, 69);
            this.lbl_cEmail.Name = "lbl_cEmail";
            this.lbl_cEmail.Size = new System.Drawing.Size(46, 17);
            this.lbl_cEmail.TabIndex = 1;
            this.lbl_cEmail.Text = "Email:";
            // 
            // lbl_cTelCel
            // 
            this.lbl_cTelCel.AutoSize = true;
            this.lbl_cTelCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cTelCel.Location = new System.Drawing.Point(14, 105);
            this.lbl_cTelCel.Name = "lbl_cTelCel";
            this.lbl_cTelCel.Size = new System.Drawing.Size(64, 17);
            this.lbl_cTelCel.TabIndex = 2;
            this.lbl_cTelCel.Text = "Tel / Cel:";
            // 
            // lbl_cUF
            // 
            this.lbl_cUF.AutoSize = true;
            this.lbl_cUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cUF.Location = new System.Drawing.Point(14, 141);
            this.lbl_cUF.Name = "lbl_cUF";
            this.lbl_cUF.Size = new System.Drawing.Size(30, 17);
            this.lbl_cUF.TabIndex = 3;
            this.lbl_cUF.Text = "UF:";
            // 
            // txtb_cNome
            // 
            this.txtb_cNome.Location = new System.Drawing.Point(84, 29);
            this.txtb_cNome.Name = "txtb_cNome";
            this.txtb_cNome.Size = new System.Drawing.Size(244, 23);
            this.txtb_cNome.TabIndex = 5;
            // 
            // txtb_Email
            // 
            this.txtb_Email.Location = new System.Drawing.Point(84, 66);
            this.txtb_Email.Name = "txtb_Email";
            this.txtb_Email.Size = new System.Drawing.Size(244, 23);
            this.txtb_Email.TabIndex = 6;
            // 
            // txtb_cTelCel
            // 
            this.txtb_cTelCel.Location = new System.Drawing.Point(84, 102);
            this.txtb_cTelCel.Name = "txtb_cTelCel";
            this.txtb_cTelCel.Size = new System.Drawing.Size(137, 23);
            this.txtb_cTelCel.TabIndex = 7;
            // 
            // cbox_cUF
            // 
            this.cbox_cUF.FormattingEnabled = true;
            this.cbox_cUF.Location = new System.Drawing.Point(84, 138);
            this.cbox_cUF.Name = "cbox_cUF";
            this.cbox_cUF.Size = new System.Drawing.Size(72, 24);
            this.cbox_cUF.TabIndex = 8;
            // 
            // btn_ContatoSalvar
            // 
            this.btn_ContatoSalvar.Location = new System.Drawing.Point(17, 185);
            this.btn_ContatoSalvar.Name = "btn_ContatoSalvar";
            this.btn_ContatoSalvar.Size = new System.Drawing.Size(96, 57);
            this.btn_ContatoSalvar.TabIndex = 10;
            this.btn_ContatoSalvar.Text = "Salvar";
            this.btn_ContatoSalvar.UseVisualStyleBackColor = true;
            this.btn_ContatoSalvar.Click += new System.EventHandler(this.btn_ContatoSalvar_Click);
            // 
            // btn_ContatoAlterar
            // 
            this.btn_ContatoAlterar.Location = new System.Drawing.Point(124, 185);
            this.btn_ContatoAlterar.Name = "btn_ContatoAlterar";
            this.btn_ContatoAlterar.Size = new System.Drawing.Size(97, 57);
            this.btn_ContatoAlterar.TabIndex = 11;
            this.btn_ContatoAlterar.Text = "Alterar";
            this.btn_ContatoAlterar.UseVisualStyleBackColor = true;
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.Location = new System.Drawing.Point(14, 79);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(42, 17);
            this.lbl_Data.TabIndex = 1;
            this.lbl_Data.Text = "Data:";
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descricao.Location = new System.Drawing.Point(14, 115);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(75, 17);
            this.lbl_Descricao.TabIndex = 2;
            this.lbl_Descricao.Text = "Descrição:";
            // 
            // txtb_ContatoNome
            // 
            this.txtb_ContatoNome.Location = new System.Drawing.Point(81, 37);
            this.txtb_ContatoNome.Name = "txtb_ContatoNome";
            this.txtb_ContatoNome.Size = new System.Drawing.Size(248, 23);
            this.txtb_ContatoNome.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(81, 79);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(248, 23);
            this.dateTimePicker.TabIndex = 4;
            // 
            // txtb_DescricaoCompromisso
            // 
            this.txtb_DescricaoCompromisso.Location = new System.Drawing.Point(17, 143);
            this.txtb_DescricaoCompromisso.MaxLength = 250;
            this.txtb_DescricaoCompromisso.Multiline = true;
            this.txtb_DescricaoCompromisso.Name = "txtb_DescricaoCompromisso";
            this.txtb_DescricaoCompromisso.Size = new System.Drawing.Size(312, 80);
            this.txtb_DescricaoCompromisso.TabIndex = 5;
            // 
            // btn_CompromissoSalvar
            // 
            this.btn_CompromissoSalvar.Location = new System.Drawing.Point(17, 233);
            this.btn_CompromissoSalvar.Name = "btn_CompromissoSalvar";
            this.btn_CompromissoSalvar.Size = new System.Drawing.Size(96, 53);
            this.btn_CompromissoSalvar.TabIndex = 12;
            this.btn_CompromissoSalvar.Text = "Salvar";
            this.btn_CompromissoSalvar.UseVisualStyleBackColor = true;
            // 
            // btn_CompromissoAlterar
            // 
            this.btn_CompromissoAlterar.Location = new System.Drawing.Point(124, 233);
            this.btn_CompromissoAlterar.Name = "btn_CompromissoAlterar";
            this.btn_CompromissoAlterar.Size = new System.Drawing.Size(97, 53);
            this.btn_CompromissoAlterar.TabIndex = 13;
            this.btn_CompromissoAlterar.Text = "Alterar";
            this.btn_CompromissoAlterar.UseVisualStyleBackColor = true;
            // 
            // btn_CompromissoExcluir
            // 
            this.btn_CompromissoExcluir.Enabled = false;
            this.btn_CompromissoExcluir.Location = new System.Drawing.Point(232, 233);
            this.btn_CompromissoExcluir.Name = "btn_CompromissoExcluir";
            this.btn_CompromissoExcluir.Size = new System.Drawing.Size(97, 53);
            this.btn_CompromissoExcluir.TabIndex = 14;
            this.btn_CompromissoExcluir.Text = "Excluir";
            this.btn_CompromissoExcluir.UseVisualStyleBackColor = true;
            // 
            // btn_ContatoExcluir
            // 
            this.btn_ContatoExcluir.Enabled = false;
            this.btn_ContatoExcluir.Location = new System.Drawing.Point(232, 185);
            this.btn_ContatoExcluir.Name = "btn_ContatoExcluir";
            this.btn_ContatoExcluir.Size = new System.Drawing.Size(97, 57);
            this.btn_ContatoExcluir.TabIndex = 12;
            this.btn_ContatoExcluir.Text = "Excluir";
            this.btn_ContatoExcluir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 597);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sistema Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Compromissos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Contatos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGrid_Compromissos;
        private System.Windows.Forms.TextBox txtb_DescricaoCompromisso;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtb_ContatoNome;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_Contato;
        private System.Windows.Forms.DataGridView dataGrid_Contatos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_ContatoAlterar;
        private System.Windows.Forms.Button btn_ContatoSalvar;
        private System.Windows.Forms.ComboBox cbox_cUF;
        private System.Windows.Forms.MaskedTextBox txtb_cTelCel;
        private System.Windows.Forms.TextBox txtb_Email;
        private System.Windows.Forms.TextBox txtb_cNome;
        private System.Windows.Forms.Label lbl_cUF;
        private System.Windows.Forms.Label lbl_cTelCel;
        private System.Windows.Forms.Label lbl_cEmail;
        private System.Windows.Forms.Label lbl_cNome;
        private System.Windows.Forms.Button btn_CompromissoExcluir;
        private System.Windows.Forms.Button btn_CompromissoAlterar;
        private System.Windows.Forms.Button btn_CompromissoSalvar;
        private System.Windows.Forms.Button btn_ContatoExcluir;
    }
}

