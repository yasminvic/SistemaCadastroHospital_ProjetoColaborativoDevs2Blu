using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastro
{
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente() { }
        
        #region Métodos
        public void MenuPaciente()
        {
            Console.Clear();
            Int32 opcao;

            do
            {
                Console.WriteLine("|*****     Menu Pacientes    *****|" +
                                  "\n|***** 1 - Lista de Pacientes    *****|" +
                                  "\n|***** 2 - Cadastro de Pacientes *****|" +
                                  "\n|***** 3 - Alterar Pacientes     *****|" +
                                  "\n|-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-|" +
                                  "\n|***** 0 - Sair do Sistema       *****|" +
                                  "\n|-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-|");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPaciente();
                        break;
                    default:
                        break;
                }

            } while (!(opcao.Equals((Int32)MenuEnums.SAIR)));
            Console.Clear();
        }

        public void ListarPaciente()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("------------------\n");
            }
        }

        public void CadastrarPaciente(Paciente novoPaciente)
        {
            Program.Mock.ListaPacientes.Add(novoPaciente);
        }

        public void AlterarPaciente(Mocks mock)
        {
        }

        public void ExcluirPaciente(Paciente paciente)
        {
        }
        #endregion
    }
}
