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

        public bool Delete(int id)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PACIENTE, conn);
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

        public MySqlDataReader GetPacientes()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PACIENTES, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public MySqlDataReader GetPacienteById(int idPaciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PACIENTE_BY_ID, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idPaciente;
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        #region SQLS
        private const String SQL_INSERT_PACIENTE = @"INSERT INTO paciente
                                                                        (id_pessoa,
                                                                        id_convenio,
                                                                        numero_prontuario,
                                                                        paciente_risco,
                                                                        flobito)
                                                                        VALUES
                                                                        (@id_pessoa,
                                                                        @id_convenio,
                                                                        @numero_prontuario,
                                                                        @paciente_risco, 
                                                                        0);";
        private const String SQL_SELECT_PACIENTES = @"SELECT * from paciente";
        private const String SQL_DELETE_PACIENTE = @"DELETE from paciente WHERE id_pessoa = @id";
        private const String SQL_SELECT_PACIENTE_BY_ID = @"select p.id,
	   pa.id as id_paciente,
       p.nome,
       p.cgccpf,
       p.tipopessoa,
       pa.numero_prontuario,
       pa.id_convenio,
       c.nome,
       e.CEP,
       e.rua,
       e.numero,
       e.bairro,
       e.cidade,
       e.uf
from pessoa p
join paciente pa 
	on pa.id_pessoa = p.id
join convenio c 
	on pa.id_convenio = c.id
join endereco e 
	on e.id_pessoa = p.id
WHERE p.id = @id";
        #endregion
    }
}
