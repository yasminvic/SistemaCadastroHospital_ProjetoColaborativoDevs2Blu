using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class Excluir
    {
        public Excluir excluir { get; set; }

        public Excluir ExcluirPessoa(Pessoa pessoa)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();

                MySqlCommand cmdEndereco = new MySqlCommand(SQL_DELETE_ENDERECO, conn);
                cmdEndereco.Parameters.Add("@id", MySqlDbType.Int32).Value = pessoa.Id;
                cmdEndereco.ExecuteNonQuery();

                MySqlCommand cmdPaciente = new MySqlCommand(SQL_DELETE_PACIENTE, conn);
                cmdPaciente.Parameters.Add("@id", MySqlDbType.Int32).Value = pessoa.Id;
                cmdPaciente.ExecuteNonQuery();

                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PESSOA, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = pessoa.Id;
                cmd.ExecuteNonQuery();

                return excluir;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private const string SQL_DELETE_PESSOA = @"DELETE FROM pessoa WHERE id = @id";
        private const string SQL_DELETE_ENDERECO = @"DELETE FROM endereco WHERE id_pessoa = @id";
        private const string SQL_DELETE_PACIENTE = @"DELETE FROM paciente WHERE id_pessoa = @id";
    }
}
