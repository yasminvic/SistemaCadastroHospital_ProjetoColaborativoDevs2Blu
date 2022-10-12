using Devs2Blu.ProjetosAula.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev2Blu.ProjetosAula.AulaOOP1Int
{
    public partial class Form1 : Form
    {
        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DiretorsList { get; set; }
        public Form1()
        {
            RecepcionistasList = new List<Recepcionista>();
            DiretorsList = new List<Diretor>();
            InitializeComponent();
        }

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
            {
                MessageBox.Show(this, "Preencha todos os campos!", "Erro - Formulário de contato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rdDiretor.Checked)
            {
                Diretor diretor = new Diretor(txtNome.Text, txtSobreNome.Text, 5000.00);
                /*diretor.Nome = txtNome.Text;
                diretor.SobreNome = txtSobreNome.Text;*/
                txtStatus.Text += $"\r\n{txtNome.Text} {txtSobreNome.Text}, novo diretor cadastrado";
                SalvarDiretor(diretor);
            } else if (rdRecepcionista.Checked)
            {
                Recepcionista recepcionista = new Recepcionista(txtNome.Text, txtSobreNome.Text);
                txtStatus.Text += $"\r\n{txtNome.Text} {txtSobreNome.Text}, novo recepcionista cadastrado";
                SalvarRecepcionista(recepcionista);
            }
            LimparFormulario();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Int32 anoSistema = DateTime.Now.Year;
            Int32 anoNascimento = Int32.Parse(txtNascimento.Text);
            Int32 idade = anoSistema - anoNascimento;
            lblIdade.Text = idade.ToString();
        }
        
        private void btnLimparStatus_Click(object sender, EventArgs e)
        {
            LimparStatus();
        }
        #endregion

        #region Metodos
        private void SalvarRecepcionista(Recepcionista recepcionista)
        {
            RecepcionistasList.Add(recepcionista);
        }

        private void SalvarDiretor(Diretor diretor)
        {
            DiretorsList.Add(diretor);
        }

        private void LimparFormulario()
        {
            txtNome.Text = "";
            txtSobreNome.Text = "";
            txtEndereco.Text = "";
            txtNascimento.Text = "";
            lblIdade.Text = "";
            if (rdDiretor.Checked == true)
            {
                rdDiretor.Checked = false;
            }
            if (rdRecepcionista.Checked == true)
            {
                rdRecepcionista.Checked = false;
            }
        }

        private void LimparStatus()
        {
            txtStatus.Text = "";
        }

        private bool ValidaForm()
        {
            if (txtNome.Text.Equals("")) return false;
            if (txtSobreNome.Text.Equals("")) return false;
            if (txtEndereco.Text.Equals("")) return false;
            if (txtNascimento.Text.Equals("")) return false;
            return true;
        }

        #endregion
    }
}
