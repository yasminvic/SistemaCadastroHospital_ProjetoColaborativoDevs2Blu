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
    public class PessoaRepository
    {
        public static MySqlDataReader FetchAll()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ALL, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static Int32 SavePessoa(Pessoa pessoa)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PESSOA, conn);

                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 25).Value = pessoa.CGCCPF;
                cmd.Parameters.Add("@tipopessoa", MySqlDbType.Enum).Value = pessoa.TipoPessoa;

                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQL's
        private const String SQL_SELECT_PESSOA = "SELECT * FROM pessoa";

        private const String SQL_INSERT_PESSOA = @"INSERT INTO pessoa
                                                (nome,
                                                cgccpf,
                                                tipopessoa,
                                                flstatus)
                                                VALUES
                                                (@nome,
                                                @cgccpf,
                                                @tipopessoa,
                                                'A')";

        private const string SQL_SELECT_ALL = @"SELECT p.id AS idpessoa,
                                                pa.id AS idpaciente,
                                                p.Nome,
                                                p.CGCCPF,
                                                p.TipoPessoa,
                                                pa.Numero_Prontuario,
                                                pa.Paciente_Risco,
                                                c.nome as Convenio,
                                                e.CEP,
                                                e.Rua,
                                                e.Numero,
                                                e.Bairro,
                                                e.Cidade,
                                                e.UF
                                                FROM pessoa p 
                                                INNER JOIN endereco e ON p.id = e.id_pessoa
                                                INNER JOIN paciente pa ON p.id = pa.id_pessoa
                                                INNER JOIN convenio c ON pa.convenio_id = c.id && p.id = pa.id_pessoa";
        #endregion
    }
}
