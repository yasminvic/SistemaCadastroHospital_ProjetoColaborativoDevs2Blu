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
    public class PacienteRepository
    {
        public Paciente Save(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                PacienteSave(paciente, conn);

            }catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
            return paciente;
        }

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
