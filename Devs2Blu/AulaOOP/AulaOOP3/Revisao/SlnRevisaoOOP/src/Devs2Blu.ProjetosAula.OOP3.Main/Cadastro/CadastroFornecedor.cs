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
    public class CadastroFornecedor
    {
        public CadastroFornecedor() { }

        public void MenuFornecedor()
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
                        ListarFornecedor();
                        break;
                    default:
                        break;
                }


            } while (!(opcao.Equals((Int32)MenuEnums.SAIR)));
            Console.Clear();
        }

        public void ListarFornecedor()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Paciente: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Convenio: {fornecedor.TipoFornecedor}");
                Console.WriteLine("------------------\n");
            }
        }

        public void CadastrarFornecedor(Fornecedor novoFornecedor)
        {
            Program.Mock.ListaFornecedores.Add(novoFornecedor);
        }

        public void AlterarRecepcionista(Mocks mock)
        {
        }

        public void ExcluirRecepcionista(Paciente paciente)
        {
        }
    }
}
