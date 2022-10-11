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
        public PessoaRepository PessoaRepository = new PessoaRepository();
        public PacienteRepositorry PacienteRepositorry = new PacienteRepositorry();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();
        public Pessoa PessoaRefresh = new Pessoa();
        public Paciente PacienteRefresh = new Paciente();
        public Endereco EnderecoRefresh = new Endereco();

        public Form1()
        {
            InitializeComponent();
        }

        #region Methods

        #region Popula
        private void PopulaComboConvenio()
        {
            var listConvenio = ConvenioRepository.FetchAll();
            cboConvenio.DataSource = new BindingSource(listConvenio, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }

        private void PopulaDataGridPessoa()
        {
            var listPessoa = PessoaRepository.GetPessoas();
            gridPacientes.DataSource = new BindingSource(listPessoa, null);
        }

        private void PopulaGridEndereco()
        {
            var listEnderecos = EnderecoRepository.GetEnderecos();
            gridEndereco.DataSource = new BindingSource(listEnderecos, null);
        }
        #endregion

        #region Forms
        private bool ValidaFormCadastro()
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Campo Nome não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboConvenio.SelectedIndex == -1)
            {
                MessageBox.Show("Campo Convênio não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtRisco.Text.Equals(""))
            {
                MessageBox.Show("Campo Risco não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNumero.Text.Equals(""))
            {
                MessageBox.Show("Campo Numéro não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtRua.Text.Equals(""))
            {
                MessageBox.Show("Campo Rua não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtBairro.Text.Equals(""))
            {
                MessageBox.Show("Campo Bairro não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCidade.Text.Equals(""))
            {
                MessageBox.Show("Campo Cidade não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboUF.SelectedIndex == -1)
            {
                MessageBox.Show("Campo UF não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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

        private void AtualizaCamposForm()
        {
            PacienteRefresh.Pessoa.Nome = txtNome.Text;
            PacienteRefresh.Pessoa.CGCCPF = txtCGCCPF.Text.Replace(',', '.');
            PacienteRefresh.Convenio.Id = (int)cboConvenio.SelectedValue;

            EnderecoRefresh.CEP = mskCEP.Text;
            EnderecoRefresh.Rua = txtRua.Text;
            EnderecoRefresh.Numero = Int32.Parse(txtNumero.Text);
            EnderecoRefresh.Bairro = txtBairro.Text;

        }
        #endregion

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
        }

        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CPF";
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CNPJ";
        }

        #region Buttons

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparFormCadastro();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                AtualizaCamposForm();


                var pacienteResult = PacienteRepositorry.Save(PacienteRefresh, EnderecoRefresh);
                if (pacienteResult.Pessoa.Id > 0)
                {
                    MessageBox.Show($"Pessoa {pacienteResult.Pessoa.Id} - {pacienteResult.Pessoa.Nome} salva com sucesso!", 
                                     "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                }
            }
        }

        #endregion

        #endregion
    }
}