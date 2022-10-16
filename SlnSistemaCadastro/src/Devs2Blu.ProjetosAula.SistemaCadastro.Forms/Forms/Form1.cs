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
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PessoaRepository PessoaRepository = new PessoaRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();
        
        public Form1()
        {
            InitializeComponent();
        }

        #region Methods

        #region Popula

        private void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();
            cboConvenio.DataSource = new BindingSource(listConvenios, null);
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

        #endregion
        
        #region Create

        private Pessoa CreatePessoa()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;
            pessoa.CGCCPF = txtCGCCPF.Text.Replace(',', '.');
            return pessoa;
        }

        private Paciente CreatePaciente()
        {
            Paciente paciente = new Paciente();
            paciente.Convenio.Id = (int)cboConvenio.SelectedValue; 
            return paciente;
        }

        private Endereco CreateEndereco()
        {
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

        private void LimparFormCadastro()
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

        #region Buttons

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormCadastro();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                Pessoa pessoa = CreatePessoa();
                Paciente paciente = CreatePaciente();
                Endereco endereco = CreateEndereco();

                //Adiciona no banco de dados
                var pacienteResult = PessoaRepository.Save(pessoa);
                int idPessoa = pacienteResult.Id;
                paciente.Pessoa.Id = idPessoa;
                endereco.Pessoa.Id = idPessoa;
                PacienteRepository.Save(paciente);
                EnderecoRepository.Save(endereco);

                if (pacienteResult.Id > 0)
                {
                    MessageBox.Show($"Pessoa {pessoa.Id} - {pessoa.Nome} salva com sucesso", "Adicionar pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            LimparFormCadastro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        
        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        #endregion

        #endregion


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            PopulaGridEndereco();
            PopulaDataGridPessoa();
        }


    }
}
