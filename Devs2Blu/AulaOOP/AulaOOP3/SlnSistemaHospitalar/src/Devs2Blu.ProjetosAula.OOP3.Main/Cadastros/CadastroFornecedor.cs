using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor() { }

        public void ListarFornecedor()
        {
            Console.Clear();
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Recepcionista: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Fornecimento: {fornecedor.TipoFornecedor}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

        public void CadastrarFornecedor(Fornecedor novoFornecedor)
        {
            Program.Mock.ListaFornecedores.Add(novoFornecedor);
        }

        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            var forne = Program.Mock.ListaFornecedores.Find(f => f.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(forne);
            Program.Mock.ListaFornecedores[index] = fornecedor;
        }

        public void ExcluirFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedores.Remove(fornecedor);
        }

        public void ListarFornecedorByCodeAndName()
        {
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine($"| {fornecedor.CodigoFornecedor} - {fornecedor.Nome}");
            }
            Console.WriteLine("\n");
        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("=-=-=-=-=     Menu de Fornecedor     =-=-=-=-=" +
                            "\n=-=-=-=-= 1 - Lista de Fornecedor    =-=-=-=-=" +
                            "\n=-=-=-=-= 2 - Cadastro de Fornecedor =-=-=-=-=" +
                            "\n=-=-=-=-= 3 - Alterar Fornecedor     =-=-=-=-=" +
                            "\n=-=-=-=-= 4 - Exluir Fornecedor      =-=-=-=-=" +
                            "\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=" +
                            "\n=-=-=-=-= 0 - Sair                =-=-=-=-=");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarFornecedor();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();

            Console.WriteLine("Informe o nome do fornecedor: ");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do fornecedor: ");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o fornecimento do fornecedor: ");
            fornecedor.TipoFornecedor = Console.ReadLine();

            Random rd = new Random();
            fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.CodigoFornecedor = Int32.Parse($"{fornecedor.CodigoFornecedor}{rd.Next(100, 999)}");

            CadastrarFornecedor(fornecedor);
        }

        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Informe o fornecedor que deseja alterar:");
            ListarFornecedorByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(f => f.CodigoFornecedor == codigoFornecedor);

            String opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Médico: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | " +
                                  $"CPF: {fornecedor.CGCCPF} | Fornecimento: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Qual campo vocÊ deseja alterar? ");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Fornecimento | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo fornecimento: ");
                        fornecedor.TipoFornecedor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dados alterados com sucesso!");
                }


            } while (alterar);

            AlterarFornecedor(fornecedor);
        }

        public void Excluir()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;
            String opcaoExcluir;
            bool excluir = true;

            do
            {
                String opcaoContinuar;
                Console.WriteLine("Informe o fornecedor que deseja excluir:\n");
                ListarFornecedorByCodeAndName();

                Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

                fornecedor = Program.Mock.ListaFornecedores.Find(f => f.CodigoFornecedor == codigoFornecedor);

                Console.WriteLine($"Médico: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | " +
                    $"CPF: {fornecedor.CGCCPF} | Fornecimento: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Você deseja excluir?");
                Console.WriteLine("01 - Sim | 02 - Não");
                opcaoExcluir = Console.ReadLine();

                switch (opcaoExcluir)
                {
                    case "01":
                        ExcluirFornecedor(fornecedor);
                        break;
                    case "02":
                    default:
                        excluir = false;
                        break;
                }

                if (excluir)
                {
                    Console.Clear();
                    Console.WriteLine("Dados exluído com sucesso!");
                }

                Console.WriteLine("Você deseja excluir outro médico? ");
                Console.WriteLine("01 - Sim | 02 - Não");
                opcaoContinuar = Console.ReadLine();

                switch (opcaoContinuar)
                {
                    case "01":
                        break;
                    case "02":
                    default:
                        excluir = false;
                        break;
                }
            } while (excluir);
        }

        #endregion
    }
}
