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
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico() { }

        public void ListarMedico()
        {
            Console.Clear();
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Paciente: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"ESpecialidade: {medico.Especialidade}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

        public void CadastrarMedico(Medico novoMedico)
        {
            Program.Mock.ListaMedicos.Add(novoMedico);
        }

        public void AlterarMedico(Medico medico)
        {
            var med = Program.Mock.ListaMedicos.Find(m => m.CodigoMedico == medico.CodigoMedico);
            int index = Program.Mock.ListaMedicos.IndexOf(med);
            Program.Mock.ListaMedicos[index] = medico;
        }

        public void ExcluirMedico(Medico medico)
        {
            Program.Mock.ListaMedicos.Remove(medico);
        }

        public void ListarMedicoByCodeAndName()
        {
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine($"| {medico.CodigoMedico} - {medico.Nome}");
            }
            Console.WriteLine("\n");
        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("=-=-=-=-=     Menu de Medicos     =-=-=-=-=" +
                            "\n=-=-=-=-= 1 - Lista de Medicos    =-=-=-=-=" +
                            "\n=-=-=-=-= 2 - Cadastro de Medicos =-=-=-=-=" +
                            "\n=-=-=-=-= 3 - Alterar Medicos     =-=-=-=-=" +
                            "\n=-=-=-=-= 4 - Exluir Medicos      =-=-=-=-=" +
                            "\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=" +
                            "\n=-=-=-=-= 0 - Sair                =-=-=-=-=");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;

        }
        
        public void Listar()
        {
            ListarMedico();       
        }

        public void Cadastrar()
        {
            Console.Clear();
            Medico medico = new Medico();
            
            Console.WriteLine("Informe o nome do médico: ");
            medico.Nome = Console.ReadLine();
            
            Console.WriteLine("Informe o CPF do médico: ");
            medico.CGCCPF = Console.ReadLine();
            
            Console.WriteLine("Informe o CRM do médico: ");
            medico.CRM = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a especialidade do medico: ");
            medico.Especialidade = Console.ReadLine();

            Random rd = new Random();
            medico.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            medico.CodigoMedico = Int32.Parse($"{medico.CodigoMedico}{rd.Next(100, 999)}");

            CadastrarMedico(medico);
        }

        public void Alterar()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("Informe o médico que deseja alterar:");
            ListarMedicoByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(m => m.CodigoMedico == codigoMedico);

            String opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Médico: {medico.Codigo}/{medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | " +
                                  $"CRM: {medico.CRM} | Especialidade: {medico.Especialidade}");
                Console.WriteLine("Qual campo vocÊ deseja alterar? ");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - CRM | 04 - Especialidade | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo CRM: ");
                        medico.CRM = Int32.Parse(Console.ReadLine());
                        break;
                    case "04":
                        Console.WriteLine("Informe uma nova especialidade: ");
                        medico.Especialidade = Console.ReadLine();
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

            AlterarMedico(medico);
        }

        public void Excluir()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;
            String opcaoExcluir;
            bool excluir = true;

            do
            {
                String opcaoContinuar;
                Console.WriteLine("Informe o médico que deseja excluir:\n");
                ListarMedicoByCodeAndName();

                Int32.TryParse(Console.ReadLine(), out codigoMedico);
                
                medico = Program.Mock.ListaMedicos.Find(m => m.CodigoMedico == codigoMedico);

                Console.WriteLine($"Médico: {medico.Codigo}/{medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | " +
                                  $"CRM: {medico.CRM} | Especialidade: {medico.Especialidade}");
                Console.WriteLine("Você deseja excluir?");
                Console.WriteLine("01 - Sim | 02 - Não");
                opcaoExcluir = Console.ReadLine();
                
                switch (opcaoExcluir)
                {
                    case "01":
                        ExcluirMedico(medico);
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
