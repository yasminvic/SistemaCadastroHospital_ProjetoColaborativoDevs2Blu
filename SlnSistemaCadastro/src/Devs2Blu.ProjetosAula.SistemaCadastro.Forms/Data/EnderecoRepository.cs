using Devs2Blu.ProjetosAula.OOP3.Models.Model;
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
    public class EnderecoRepository
    {

        public void Save (Endereco endereco)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                SalveEndereco(endereco, conn);

            }catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void SalveEndereco(Endereco endereco, MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand(SQL_INSERT_ENDERECO, conn);
            cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = endereco.Pessoa.Id;
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = endereco.CEP;
            cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = endereco.Rua;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar, 45).Value = endereco.Numero;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = endereco.Bairro;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = endereco.UF;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = endereco.Cidade;
            cmd.ExecuteNonQuery();
        }

        public MySqlDataReader GetEndereco()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ENDERECO, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool Delete(int id)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_ENDERECO, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco
                                                                        (id_pessoa,
                                                                        cep,
                                                                        rua,
                                                                        numero,
                                                                        bairro,
                                                                        uf,
                                                                        cidade)
                                                                        VALUES
                                                                        (@id_pessoa,
                                                                        @cep,
                                                                        @rua,
                                                                        @numero,
                                                                        @bairro,
                                                                        @uf,
                                                                        @cidade);";
        private const String SQL_SELECT_ENDERECO = @"SELECT id_pessoa, cep, rua, numero, bairro, uf, cidade from endereco";
        private const String SQL_DELETE_ENDERECO = @"DELETE from endereco WHERE id_pessoa = @id";
    }
}
