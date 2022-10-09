﻿using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();

        public Form1()
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
            var listPessoa = PacienteRepository.GetPessoas();
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
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulaComboConvenio();
            PopulaDataGridPessoa();
        }

        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CPF";
            lblCGCCPF.Visible = true;
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CNPJ";
            lblCGCCPF.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                Paciente paciente = new Paciente();
                paciente.Pessoa.Nome = txtNome.Text;
                paciente.Pessoa.CGCCPF = txtCGCCPF.Text.Replace(",", ".");
                paciente.Convenio.Id = (int)cboConvenio.SelectedValue;

                Endereco endereco = new Endereco();
                endereco.CEP = mskCEP.Text;
                endereco.Rua = txtRua.Text;
                endereco.Bairro = txtBairro.Text;
                endereco.UF = cboUF.Text;
                endereco.Cidade = txtCidade.Text;
                endereco.Numero = Int32.Parse(txtNumero.Text);

                var pacienteResult = PacienteRepository.Save(paciente, endereco);
                if (pacienteResult.Pessoa.Id > 0)
                {
                    MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} - {paciente.Pessoa.CGCCPF} salva com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
