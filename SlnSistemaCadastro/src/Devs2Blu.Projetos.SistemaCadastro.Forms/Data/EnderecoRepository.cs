using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.Projetos.SistemaCadastro.Forms.Data
{
    public class EnderecoRepository
    {
        public static void saveEndereco(Endereco endereco, MySqlConnection conn, Int32 idPessoa)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_ENDERECO, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = idPessoa;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 15).Value = endereco.CEP;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = endereco.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = endereco.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = endereco.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = endereco.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = endereco.UF;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /*internal MySqlDataReader GetPessoas()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PESSOAS, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }*/

        #region SQLs
        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco (id_pessoa, CEP, rua, numero, bairro, cidade, uf) 
                                                     VALUES (@id_pessoa, @CEP, @rua, @numero, @bairro, @cidade, @uf)";
        private const String SQL_SELECT_ENDERECO = @"SELECT endereco (id_pessoa, CEP, rua, numero, bairro, cidade, uf) 
                                                     VALUES (@id_pessoa, @CEP, @rua, @numero, @bairro, @cidade, @uf)";
        #endregion
    }
}
