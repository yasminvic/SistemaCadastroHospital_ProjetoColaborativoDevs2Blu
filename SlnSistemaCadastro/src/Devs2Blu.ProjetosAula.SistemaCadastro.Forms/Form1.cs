using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using Correios;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            // Regex para validar CPF
            Regex regexCPF = new Regex(@"([/^\d{3}\.\d{3}\.\d{3}\-\d{2}$/])");
            Regex regexCNPJ = new Regex(@"([/^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$/])");

            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe seu Nome!");
                return false;
            }

            #region CGCCPF
            if (lblCGCCPF.Text == "CPF")
            {
                if (!regexCPF.IsMatch(txtCGCCPF.Text))
                {
                    MessageBox.Show("Informe um CFP válido!!");
                    return false;
                }
            }
            else if (txtCGCCPF.Text == "CPF")
            {
                if (!regexCNPJ.IsMatch(txtCGCCPF.Text))
                {
                    MessageBox.Show("Informe um CNPJ válido!");
                        return false;
                }
            }
            #endregion

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
            if (txtNmrProntuario.Text.Equals(""))
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
            txtCGCCPF.Mask = "000.000.000-00";
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CNPJ";
            lblCGCCPF.Visible = true;
            tipoPessoa = TipoPessoa.PJ;
            txtCGCCPF.Mask = "00.000.000/0000-00";
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
                paciente.Pessoa = pessoa;
                paciente.Convenio.Id = (int)cboConvenio.SelectedValue;
                paciente.NrProntuario = Int32.Parse(txtNmrProntuario.Text);
                paciente.PacienteRisco = txtPacienteRisco.Text;
                //paciente.NrProntuario = Int32.Parse($"{dateTime.Day}" + $"{random.Next(100, 999)}");
                paciente.NrProntuario = Int32.Parse(txtNmrProntuario.Text);
                paciente.PacienteRisco = txtPacienteRisco.Text;

                int idPessoa = PessoaRepository.SavePessoa(pessoa);   // Salva a pessoa e retorna o seu ID
                paciente.Pessoa.Id = idPessoa;
                EnderecoRepository.SaveEndereco(endereco, idPessoa);  // Salva o endereço
                PacienteRepository.SavePaciente(paciente);            // Salva o Paciente

                MessageBox.Show($"Pessoa {paciente.Pessoa.Id} salva com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PopulaDataGridPessoa();
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

        private void FormCadastro_Activated(object sender, EventArgs e)
        {
            PopulaDataGridPessoa();
        }

        private void mskCEP_TextChanged(object sender, EventArgs e)
        {
            if (mskCEP.Text.Length == 10)
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(mskCEP.Text);
                    txtBairro.Text = retorno.bairro;
                    txtCidade.Text = retorno.cidade;
                    txtRua.Text = retorno.end;
                    cboUF.Text = retorno.uf;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("CEP não encontrado!", erro.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskCEP.Text = "";
                    mskCEP.Focus();
                }
            }
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


    }
}
