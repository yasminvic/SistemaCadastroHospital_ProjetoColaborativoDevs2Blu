using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient; //faz conexão com mysql
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();    //declarando uma proprienda e já instanciando ela
        public PessoaRepository PessoaRepository = new PessoaRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();
        public Form1()
        {
            InitializeComponent();
        }

        #region Methods

        private void PopulaComboConvenio()//criar novo form para add convenios
        {
            var listConvenios = ConvenioRepository.FetchAll();// chamando metodo da classe ConvenioRepository
            //pega as infromaçõees de um jeito mais inteligente
            cboConvenio.DataSource = new BindingSource(listConvenios, null);
            //pega o que estiver no nome, que seria o convenio
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }

        private void PopulaDataGridPessoa()
        {
            var listPessoas = PessoaRepository.GetPessoas();
            gridPaciente.DataSource = new BindingSource(listPessoas, null); 
        }

        private void PopulaGridEndereco()
        {
            var listEnderecos = EnderecoRepository.GetEndereco();
            gridEndereco.DataSource = new BindingSource(listEnderecos, null);
        }

        private bool ValidaFormCadastro()
        {

            //RETORNAR QUAL CAMPO ESTÁ FALTANDO (fazer messagebox)
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Campo Nome não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboConvenio.SelectedIndex == -1) //combobox gera indices para cada item
            {
                MessageBox.Show("Campo Convênio não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtRisco.Text.Equals(""))
            {
                MessageBox.Show("Campo Risco não foi preenchido", "Cadastro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNum.Text.Equals(""))
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
            //cria Pessoa
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;
            pessoa.CGCCPF = txtCGCCPF.Text.Replace(',', '.');//substituir virgula por ponto
            return pessoa;
        }

        private Paciente CriaPaciente()
        {
            //cria Paciente
            Paciente paciente = new Paciente();
            paciente.Convenio.Id = (int)cboConvenio.SelectedValue; //instanciar id do convenio
            return paciente;
        }

        private Endereco CriaEndereco()
        {
            //cria Endereço
            Endereco endereco = new Endereco();
            endereco.CEP = mskCEP.Text.Replace(',', '.');
            endereco.Rua = txtRua.Text;
            endereco.Numero = Int32.Parse(txtNum.Text);
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.UF = cboUF.Text;
            return endereco;
        }

        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            #region TesteConexao
            /*Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão efetuada com sucesso !", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conn.Close();
            }  */
            #endregion
            PopulaComboConvenio();
            PopulaDataGridPessoa();
            PopulaGridEndereco();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CPF:";
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CNPJ:";
        
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCGCCPF.Clear();
            txtRisco.Clear();
            mskCEP.Clear();
            txtNum.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
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
                PacienteRepository.Save(paciente);
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
