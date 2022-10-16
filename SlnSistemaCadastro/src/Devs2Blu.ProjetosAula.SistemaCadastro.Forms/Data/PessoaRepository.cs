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
    public class PessoaRepository
    {
        public Pessoa Save(Pessoa pessoa)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                pessoa.Id = SavePessoa(pessoa, conn);
                //como a gente nao esta instanciando id quando inserimos a pessoa
                //e precisamos dele para criar o paciente
                //entao estamo pegando ele atraves dessa funcão

                return pessoa;               
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
      
        private Int32 SavePessoa(Pessoa pessoa, MySqlConnection conn)
        {
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PESSOA, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 25).Value = pessoa.CGCCPF;
                cmd.Parameters.Add("@tipopessoa", MySqlDbType.Enum).Value = pessoa.TipoPessoa;
                cmd.ExecuteNonQuery();                                                                  
                return (Int32)cmd.LastInsertedId; 
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        public MySqlDataReader GetPessoas()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PESSOA, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;

            }catch (MySqlException myexc)
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
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PESSOA, conn);
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


        #region SQLS
        private const String SQL_INSERT_PESSOA = @"INSERT INTO pessoa (nome,
                                                                       cgccpf,
                                                                       tipopessoa) 
                                                                VALUES (@nome,
                                                                        @cgccpf,
                                                                        @tipopessoa)";
        private const String SQL_SELECT_PESSOA = @"SELECT id, nome, cgccpf from pessoa";
        private const String SQL_DELETE_PESSOA = @"DELETE FROM pessoa WHERE id = @id";
        #endregion
    }
}
