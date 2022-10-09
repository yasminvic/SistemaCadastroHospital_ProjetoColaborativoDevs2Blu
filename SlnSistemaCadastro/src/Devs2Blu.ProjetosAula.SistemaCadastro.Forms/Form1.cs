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
            /*if (txtNome.Text.Equals(""))
                return false;
            if (txtCGCCPF.Text.Equals(""))
                return false;
            if (cboConvenio.SelectedIndex == -1)
                return false;
            if (mskCEP.Text.Equals(""))
                return false;
            if (cboUF.SelectedIndex == -1)
                return false;
            if (txtCidade.Text.Equals(""))
                return false;
            if (txtRua.Text.Equals(""))
                return false;
            if (txtNumero.Text.Equals(""))
                return false;
            if (txtBairro.Text.Equals(""))
                return false;
            if (txtNumeroProntuario.Text.Equals(""))
                return false;
            if (txtPacienteRisco.Text.Equals(""))
                return false;*/

            return true;
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
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
                pessoa.CGCCPF = txtCGCCPF.Text.Replace(',','.');

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
                }
            }
        }

        #endregion
    }
}