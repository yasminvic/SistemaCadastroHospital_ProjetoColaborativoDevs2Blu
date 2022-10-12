using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista() { }

        public void ListarRecepcionista()
        {
            Console.Clear();
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

        public void CadastrarRecepcionista(Recepcionista novoRecepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);
        }

        public void AlterarRecepcionista(Recepcionista recepcionista)
        {
            var recep = Program.Mock.ListaRecepcionistas.Find(r => r.CodigoRecepcionista == recepcionista.CodigoRecepcionista);
            int index = Program.Mock.ListaRecepcionistas.IndexOf(recep);
            Program.Mock.ListaRecepcionistas[index] = recepcionista;
        }

        public void ExcluirRecepcionista(Recepcionista recepcionista)
        {
            Program.Mock.ListaRecepcionistas.Remove(recepcionista);
        }

        public void ListarRecepcionistaByCodeAndName()
        {
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine($"| {recepcionista.CodigoRecepcionista} - {recepcionista.Nome}");
            }
            Console.WriteLine("\n");
        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("=-=-=-=-=     Menu de Recepcionista     =-=-=-=-=" +
                            "\n=-=-=-=-= 1 - Lista de Recepcionista    =-=-=-=-=" +
                            "\n=-=-=-=-= 2 - Cadastro de Recepcionista =-=-=-=-=" +
                            "\n=-=-=-=-= 3 - Alterar Recepcionista     =-=-=-=-=" +
                            "\n=-=-=-=-= 4 - Exluir Recepcionista      =-=-=-=-=" +
                            "\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=" +
                            "\n=-=-=-=-= 0 - Sair                =-=-=-=-=");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarRecepcionista();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();

            Console.WriteLine("Informe o nome do recepcionista: ");
            recepcionista.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do recepcionista: ");
            recepcionista.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o Setor do recepcionista: ");
            recepcionista.Setor = Console.ReadLine();

            Random rd = new Random();
            recepcionista.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            recepcionista.CodigoRecepcionista = Int32.Parse($"{recepcionista.CodigoRecepcionista}{rd.Next(100, 999)}");

            CadastrarRecepcionista(recepcionista);
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("Informe o recepcionsita que deseja alterar:");
            ListarRecepcionistaByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(r => r.CodigoRecepcionista == codigoRecepcionista);

            String opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Médico: {recepcionista.Codigo}/{recepcionista.CodigoRecepcionista} | Nome: {recepcionista.Nome} | " +
                                  $"CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}");
                Console.WriteLine("Qual campo vocÊ deseja alterar? ");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Setor | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo setor: ");
                        recepcionista.Setor = Console.ReadLine();
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

            AlterarRecepcionista(recepcionista);
        }

        public void Excluir()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;
            String opcaoExcluir;
            bool excluir = true;

            do
            {
                String opcaoContinuar;
                Console.WriteLine("Informe o recepcionista que deseja excluir:\n");
                ListarRecepcionistaByCodeAndName();

                Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

                recepcionista = Program.Mock.ListaRecepcionistas.Find(r => r.CodigoRecepcionista == codigoRecepcionista);

                Console.WriteLine($"Médico: {recepcionista.Codigo}/{recepcionista.CodigoRecepcionista} | Nome: {recepcionista.Nome} | " +
                    $"CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}");
                Console.WriteLine("Você deseja excluir?");
                Console.WriteLine("01 - Sim | 02 - Não");
                opcaoExcluir = Console.ReadLine();

                switch (opcaoExcluir)
                {
                    case "01":
                        ExcluirRecepcionista(recepcionista);
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
