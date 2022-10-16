using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
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
    public partial class Form4 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PessoaRepository PessoaRepository = new PessoaRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();

        public Form4()
        {
            InitializeComponent();
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

        private void Form4_Load(object sender, EventArgs e)
        {
            PopulaGridEndereco();
            PopulaDataGridPessoa();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
