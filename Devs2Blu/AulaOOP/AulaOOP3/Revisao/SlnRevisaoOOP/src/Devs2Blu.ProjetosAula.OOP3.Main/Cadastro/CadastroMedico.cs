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
    public class CadastroMedico
    {
        public CadastroMedico() { }

        #region Métodos
        public void MenuMedico()
        {
            Console.Clear();
            Int32 opcao;

            do
            {
                Console.WriteLine("|*****     Menu Medico    *****|" +
                                  "\n|***** 1 - Lista de Médico     *****|" +
                                  "\n|***** 2 - Cadastro de Médicos *****|" +
                                  "\n|***** 3 - Alterar Médicos     *****|" +
                                  "\n|-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-" +
                                  "\n|***** 0 - Sair do Sistema     *****|" +
                                  "\n|-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedico();
                        break;
                    default:
                        break;
                }

            } while (!(opcao.Equals((Int32)MenuEnums.SAIR)));
            Console.Clear();
        }

        public void ListarMedico()
        {
            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Médico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine("------------------\n");
            }
        }

        public void CadastrarMedico(Medico novoMedico)
        {
            Program.Mock.ListaMedicos.Add(novoMedico);
        }

        public void AlterarPaciente(Mocks mock)
        {
        }

        public void ExcluirPaciente(Mocks mock)
        {
        }
        #endregion
    }
}
