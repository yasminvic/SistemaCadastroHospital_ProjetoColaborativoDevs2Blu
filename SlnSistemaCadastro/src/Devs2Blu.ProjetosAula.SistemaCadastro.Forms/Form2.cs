using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class FormExcluir : Form
    {
        public FormExcluir()
        {
            InitializeComponent();
        }

        #region Methods
        
        #endregion

        #region Events
        private void FormExcluir_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int idPessoa = Int32.Parse(txtIdPessoa.Text);
                Excluir.ExcluirirPessoa(idPessoa);

                Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Digite um ID válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


    }
}
