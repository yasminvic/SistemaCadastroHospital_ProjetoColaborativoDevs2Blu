﻿using Devs2Blu.ProjetosAula.OOP3.Models.Model;
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
        public Pessoa Salve(Pessoa pessoa)
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
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PESSOA, conn); // vai inserir uma pessoa
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = pessoa.Nome;
                                    //nome parametro   //tipo    //tamanho     //o parametro Pessoa é um objeto
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 25).Value = pessoa.CGCCPF;
                cmd.Parameters.Add("@tipopessoa", MySqlDbType.Enum).Value = pessoa.TipoPessoa;
                cmd.ExecuteNonQuery();                                                                  
                return (Int32)cmd.LastInsertedId; //retorna o ultimo id inserido
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
 

        #region SQLS
        private const String SQL_INSERT_PESSOA = @"INSERT INTO pessoa (nome,
                                                                       cpf,
                                                                       tipopessoa,
                                                                       flstatus) 
                                                                VALUES (@nome,
                                                                        @cpf,
                                                                        @tipopessoa,
                                                                        'A')";
        private const String SQL_SELECT_PESSOA = @"SELECT id, nome, cpf, flstatus from pessoa";
        #endregion
    }
}
