using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Net.Http.Headers;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class FormCadastro : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();
        public PessoaRepository PessoaRepository = new PessoaRepository();

        public Random random = new Random();
        public DateTime dateTime = new DateTime();

        public FormCadastro()
        {
            InitializeComponent();
        }

        #region Methods
        private void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();
            cboConvenio.DataSource = new BindingSource(listConvenios, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }

        private void PopulaDataGridPessoa()
        {
            var listPessoa = PessoaRepository.FetchAll();
            gridPacientes.DataSource = new BindingSource(listPessoa, null);
        }

        private bool ValidaFormCadastro()
        {
            if (txtNome.Text.Equals(""))
            {
                return false;
            }
            if (txtCGCCPF.Text.Equals(""))
            {
                return false;
            }
            /*if (cboConvenio.SelectedIndex == -1)
            {
                return false;
            }
            if (mskCEP.Text.Equals(""))
            {
                return false;
            }
            if (cboUF.SelectedIndex == -1)
            {
                return false;
            }
            if (txtCidade.Text.Equals(""))
            {
                return false;
            }
            if (txtRua.Text.Equals(""))
            {
                return false;
            }
            if (txtNumero.Text.Equals(""))
            {
                return false;
            }
            if (txtBairro.Text.Equals(""))
            {
                return false;
            }*/

            return true;
        }

        private void LimparForm()
        {
            txtNome.Clear();
            txtCGCCPF.Clear();
            rdFisica.Checked = true;

            mskCEP.Clear();
            //cboUF
            txtCidade.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtNumero.Clear();

            //cboConvenio
            txtPacienteRisco.Clear();
            txtNmrProntuario.Clear();
        }
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulaComboConvenio();
            PopulaDataGridPessoa();
        }

        #region TipoPessoa
        public TipoPessoa tipoPessoa { get; set; } 
        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CPF";
            lblCGCCPF.Visible = true;
            tipoPessoa = TipoPessoa.PF;
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CNPJ";
            lblCGCCPF.Visible = true;
            tipoPessoa = TipoPessoa.PJ;
        }
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = txtNome.Text;
                pessoa.CGCCPF = txtCGCCPF.Text.Replace(",", ".");
                pessoa.TipoPessoa = tipoPessoa;

                Endereco endereco = new Endereco();
                endereco.CEP = mskCEP.Text.Replace(",", ".");
                endereco.Rua = txtRua.Text;
                endereco.Bairro = txtBairro.Text;
                endereco.UF = cboUF.Text;
                endereco.Cidade = txtCidade.Text;
                endereco.Numero = Int32.Parse(txtNumero.Text);

                Paciente paciente = new Paciente();
                paciente.Convenio.Id = (int)cboConvenio.SelectedValue;
                //paciente.NrProntuario = Int32.Parse($"{dateTime.Day}" + $"{random.Next(100, 999)}");
                paciente.NrProntuario = Int32.Parse(txtNmrProntuario.Text);
                paciente.PacienteRisco = txtPacienteRisco.Text;

                int idPessoa = PessoaRepository.SavePessoa(pessoa);   // Salva a pessoa e retorna o seu ID
                paciente.Pessoa.Id = idPessoa;
                EnderecoRepository.SaveEndereco(endereco, idPessoa);  // Salva o endereço
                PacienteRepository.SavePaciente(paciente);            // Salva o Paciente



                if (paciente.Pessoa.Id > 0)
                {
                    MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} - {paciente.Pessoa.CGCCPF} salva com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FormExcluir formExcluir = new FormExcluir();
            formExcluir.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
        #endregion
    }
}
