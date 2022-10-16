using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class ConvenioRepository
    {
        public MySqlDataReader FetchAll() //pega tudo
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();//faz a conexão

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_Convenio, conn); //vai executar a query nessa conexão (pode ter varias)
                                                   //comando        //conexão que possibilita comando

                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader; //retorna tudo oq estiver na base
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        #region SQLS
        private const String SQL_SELECT_Convenio = "SELECT * FROM convenio";
        #endregion

    }

}
