using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Interface;
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
    public class PacienteRepository : IComanndSQL
    {
        private void PacienteSave(Paciente paciente, MySqlConnection conn)
        {
            Random rd = new Random();
            paciente.NumProntuario = rd.Next(1000, 9999);

            MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PACIENTE, conn);
            cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = paciente.Pessoa.Id;
            cmd.Parameters.Add("@id_convenio", MySqlDbType.Int32).Value = paciente.Convenio.Id;
            cmd.Parameters.Add("@numero_prontuario", MySqlDbType.Int32).Value = paciente.NumProntuario;
            cmd.Parameters.Add("@paciente_risco", MySqlDbType.VarChar, 5).Value = paciente.PacienteRisco;
            cmd.ExecuteNonQuery();
        }

        private void DeletePaciente(Int32 idpessoa)
        {
            String SQL_DELETE_PACIENTE = @"DELETE FROM paciente WHERE id_pessoa='" + idpessoa + "'";
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PACIENTE, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public Paciente InsertPac(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                PacienteSave(paciente, conn);
                return paciente;
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            } 
        }

        public void Delete(int idpessoa)
        {
            DeletePaciente(idpessoa);
        }

        public Pessoa InsertPes(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Endereco InsertEnd(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        #region SQLS
        private const String SQL_INSERT_PACIENTE = @"INSERT INTO paciente
                                                                        (id_pessoa,
                                                                        id_convenio,
                                                                        num_prontuario,
                                                                        paciente_risco,
                                                                        flstatus,
                                                                        obito)
                                                                        VALUES
                                                                        (@id_pessoa,
                                                                        @id_convenio,
                                                                        @numero_prontuario,
                                                                        @paciente_risco,
                                                                        'A',
                                                                        0);";
        #endregion
    }
}
