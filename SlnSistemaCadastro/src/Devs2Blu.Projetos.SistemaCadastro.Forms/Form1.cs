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
            var listPessoa = PessoaRepository.GetPessoas();
            gridPacientes.DataSource = new BindingSource(listPessoa, null);
        }

        private void PopulaGridEndereco()
        {
            var listEnderecos = EnderecoRepository.GetEndereco();
            gridEndereco.DataSource = new BindingSource(listEnderecos, null);
        }

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

        private Pessoa CriaPessoa()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;
            pessoa.CGCCPF = txtCGCCPF.Text.Replace(',', '.');
            return pessoa;
        }

        private Paciente CriaPaciente()
        {
            Paciente paciente = new Paciente();
            paciente.Convenio.Id = (int)cboConvenio.SelectedValue; 
            return paciente;
        }

        private Endereco CriaEndereco()
        {
            //cria Endereço
            Endereco endereco = new Endereco();
            endereco.CEP = mskCEP.Text.Replace(',', '.');
            endereco.Rua = txtRua.Text;
            endereco.Numero = Int32.Parse(txtNumero.Text);
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.UF = cboUF.Text;
            return endereco;
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
            PopulaGridEndereco();
        }

        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CPF";
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CNPJ";
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparFormCadastro();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                Pessoa pessoa = CriaPessoa();
                Paciente paciente = CriaPaciente();
                Endereco endereco = CriaEndereco();

                //Adiciona no banco de dados
                var pacienteResult = PessoaRepository.Salve(pessoa);
                int idPessoa = pacienteResult.Id;
                paciente.Pessoa.Id = idPessoa;
                endereco.Pessoa.Id = idPessoa;
                PacienteRepositorry.Save(paciente);
                EnderecoRepository.Salve(endereco);

                if (pacienteResult.Id > 0)
                {
                    MessageBox.Show($"Pessoa {pessoa.Id} - {pessoa.Nome} salva com sucesso", "Adicionar pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion


    }
}