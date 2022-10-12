using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastro
{
    public class CadastroRecepcionista
    {
        public CadastroRecepcionista() { }

        #region MÉTODOS
        public void MenuRecepcionista()
        {
            Console.Clear();
            Int32 opcao;

            do
            {
                Console.WriteLine("|*****     Cadastro Recepcionista      *****|" +
                                  "\n|***** 1 - Lista de Recepcionista    *****|" +
                                  "\n|***** 2 - Cadastro de Recepcionista *****|" +
                                  "\n|***** 3 - Alterar Recepcionista     *****|" +
                                  "\n|-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-|" +
                                  "\n|***** 0 - Sair do Sistema          *****|" +
                                  "\n|-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-|");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarRecepcionista();
                        break;
                    default:
                        break;
                }
            } while (!(opcao.Equals((Int32)MenuEnums.SAIR)));
            Console.Clear();
        }

        public void ListarRecepcionista()
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("------------------\n");
            }
        }

        public void CadastrarRecepcionista(Recepcionista novoRecepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);
        }

        public void AlterarRecepcionista(Mocks mock)
        {
        }

        public void ExcluirRecepcionista(Paciente paciente)
        {
        }
        #endregion
    }
}
