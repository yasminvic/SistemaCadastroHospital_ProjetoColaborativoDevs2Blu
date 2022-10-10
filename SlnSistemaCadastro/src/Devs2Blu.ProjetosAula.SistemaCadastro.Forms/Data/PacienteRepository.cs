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
        public Pessoa Save(Pessoa pessoa, Endereco endereco, Paciente paciente, Convenio convenio)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                pessoa.Id = SavePessoa(pessoa, conn);
                EnderecoRepository.SaveEndereco(endereco, conn, pessoa.Id);
                paciente.Id = SavePaciente(paciente, conn, pessoa.Id, convenio.Id);

                return pessoa;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private Int32 SavePaciente(Paciente paciente, MySqlConnection conn, Int32 idPessoa, Int32 idConvenio)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PACIENTE, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = idPessoa;
                cmd.Parameters.Add("@id_convenio", MySqlDbType.Int32).Value = idConvenio;
                cmd.Parameters.Add("@numero_prontuario", MySqlDbType.Int32).Value = paciente.NrProntuario;
                cmd.Parameters.Add("@paciente_risco", MySqlDbType.VarChar, 5).Value = paciente.PacienteRisco;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader GetPessoas()
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
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

        #region SQLs
        private const string SQL_INSERT_PESSOA = @"INSERT INTO pessoa
(nome,
cgccpf,
tipopessoa,
flstatus)
VALUES
(@nome,
@cgccpf,
@tipopessoa,
'A')";
        private const string SQL_INSERT_PACIENTE = @"INSERT INTO paciente
(id_pessoa,
id_convenio,
numero_prontuario,
paciente_risco,
flstatus,
flobito)
VALUES
(@id_pessoa,
@id_convenio,
@numero_prontuario,
@paciente_risco,
'A',
0)";
        private const string SQL_SELECT_PESSOA = @"SELECT id, nome, cgccpf, tipopessoa, flstatus FROM pessoa";
        private const string SQL_SELECT_PACIENTE = @"SELECT id_pessoa, id_convenio, numero_prontuario, paciente_risco, flstatus, flobito FROM paciente";
        private const string SQL_SELECT_PESSOA_ENDERECO = @"SELECT p.ID, p.Nome, p.CGCCPF, p.TipoPessoa, p.FlStatus, e.CEP, e.Rua, e.Numero, e.Bairro, e.Cidade, e.UF FROM pessoa p JOIN endereco e ON p.id = e.id_pessoa";
        private const string SQL_SELECT_ALL = @"SELECT p.ID,
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
INNER JOIN convenio c ON pa.id_convenio = c.id && p.id = pa.id_pessoa";
        #endregion
    }
}
