using Devs2Blu.Projetos.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.Projetos.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PacienteRepositorry PacienteRepositorry = new PacienteRepositorry();
        public MySqlException myExc { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        #region Methods
        
        private void PopulaComboConvenio()
        {
            var listConvenio = ConvenioRepository.FetchAll();
            cboConvenio.DataSource = new BindingSource(listConvenio, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }

        private void PopulaDataGridPessoa()
        {
            var listPessoa = PacienteRepositorry.GetPessoas();
            gridPacientes.DataSource = new BindingSource(listPessoa, null);
        }

        private bool ValidaFormCadastro()
        {
            if (txtNome.Text.Equals("")) return false;
            if (txtCGCCPF.Text.Equals("")) return false;
            /*if (cboConvenio.SelectedIndex == -1) return false;
            if (mskCEP.Text.Equals("")) return false;
            if (cboUF.SelectedIndex == -1) return false;
            if (txtCidade.Text.Equals("")) return false;
            if (txtRua.Text.Equals("")) return false;
            if (txtNumero.Text.Equals("")) return false;
            if (txtBairro.Text.Equals("")) return false;*/
            return true;
        }

        private void LimparFormCadastro()
        {
            txtNome.Text = "";
            cboConvenio.Text = "";
            txtCGCCPF.Text = "";
            mskCEP.Text = "";
            cboUF.Text = "";
            txtCidade.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
        }

        #endregion

        #region Events
        
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Teste Conexão
            /*Conn = ConnectionMySQL.GetConnection();
            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conn.Close();
            }*/
            #endregion
            PopulaComboConvenio();
            PopulaDataGridPessoa();
        }

        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CPF";
            lblCGCCPF.Visible = true;
            txtCGCCPF.Visible = true;
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CNPJ";
            lblCGCCPF.Visible = true;
            txtCGCCPF.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                Paciente paciente = new Paciente();
                paciente.Pessoa.Nome = txtNome.Text;
                paciente.Pessoa.CGCCPF = txtCGCCPF.Text.Replace(',', '.');
                var pacienteResult = PacienteRepositorry.Save(paciente);
                if (pacienteResult.Pessoa.Id > 0)
                {
                    MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} salva com sucesso!",
                                     "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                }













            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparFormCadastro();   
        }

        #endregion


    }
}