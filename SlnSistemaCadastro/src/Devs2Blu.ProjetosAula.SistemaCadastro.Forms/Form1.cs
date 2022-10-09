using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
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

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; private set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();
        public MySqlException myExc { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        #region Methods

        private void PopulaComboConveio()
        {
            var listConvenios = ConvenioRepository.FetchAll();
            cboConvenio.DataSource = new BindingSource(listConvenios, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }
        private void PopulaDataGridPessoa()
        {
            var listPacientes = PacienteRepository.GetPessoas();
            gridPacientes.DataSource = new BindingSource(listPacientes, null);
        }
        private bool ValidaFormCadastro()
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe seu Nome!");
                return false;
            }
            if (txtCGCCPF.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe seu CPF!");
                return false;
            }
            if (cboConvenio.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor, Informe seu Convenio!");
                return false;
            }
            if (mskCEP.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe seu CEP!");
                return false;
            }
            if (cboUF.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor, Informe seu UF!");
                return false;
            }
            if (txtCidade.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe sua Cidade!");
                return false;
            }
            if (txtRua.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe sua Rua!");
                return false;
            }
            if (txtNumero.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe seu Numero!");
                return false;
            }
            if (txtBairro.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe seu Bairro!");
                return false;
            }
            if (txtNumeroProntuario.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe o Numero de Prontuario!");
                return false;
            }
            if (txtPacienteRisco.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe o Risco do Paciente!");
                return false;
            }

            return true;
        }
        private void LimpaForms()
        {
            txtNome.Text = "";
            txtCGCCPF.Text = "";

            if (lblCGCCPF.Text == "CPF")
            {
                txtCGCCPF.Mask = "000.000.000-00";
            }
            else if (lblCGCCPF.Text == "CNPJ")
            {
                txtCGCCPF.Mask = "00.000.000/000-00";
            }

            cboConvenio.SelectedValue = 0;

            mskCEP.Text = "";
            mskCEP.Mask = "00.000-000";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cboUF.Text = "";

            txtNumeroProntuario.Text = "";
            txtPacienteRisco.Text = "";
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            LimpaForms();
            #region TesteConexao
            /*Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.Close();
            }*/
            #endregion
            PopulaComboConveio();
            PopulaDataGridPessoa();
        }
        private void rdTipoPessoaPF_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CPF";
            lblCGCCPF.Visible = true;
            txtCGCCPF.Mask = "000.000.000-00";
        }
        private void rdTipoPessoaPJ_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CNPJ";
            lblCGCCPF.Visible = true;
            txtCGCCPF.Mask = "00.000.000/000-00";
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = txtNome.Text;
                pessoa.CGCCPF = txtCGCCPF.Text.Replace(',', '.');

                Convenio convenio = new Convenio();
                convenio.Id = (int)cboConvenio.SelectedValue;

                Endereco endereco = new Endereco();
                endereco.CEP = mskCEP.Text.Replace(',', '.');
                endereco.Rua = txtRua.Text;
                endereco.Numero = Int32.Parse(txtNumero.Text);
                endereco.Bairro = txtBairro.Text;
                endereco.Cidade = txtCidade.Text;
                endereco.UF = cboUF.Text;

                Paciente paciente = new Paciente();
                paciente.NrProntuario = Int32.Parse(txtNumeroProntuario.Text);
                paciente.PacienteRisco = txtPacienteRisco.Text;

                var pacienteResult = PacienteRepository.Save(pessoa, endereco, paciente, convenio);

                if (pacienteResult.Id > 0)
                {
                    MessageBox.Show($"Paciente {paciente.Pessoa.Id} - {pessoa.Nome} salvo com sucesso!", "Adicionar paciente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                    LimpaForms();
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaForms();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        #endregion

    }
}