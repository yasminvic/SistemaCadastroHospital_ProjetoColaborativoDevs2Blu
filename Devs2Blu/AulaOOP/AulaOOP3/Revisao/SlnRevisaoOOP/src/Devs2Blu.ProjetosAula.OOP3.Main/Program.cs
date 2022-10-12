using Devs2Blu.ProjetosAula.OOP3.Main.Cadastro;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    class Program
    {
        public static Mocks Mock { get; set; }

        static void Main(string[] args)
        {
            Int32 opcao;
            Mock = new Mocks();
            do
            {
                Console.WriteLine("|*****    Sistema Hospital              *****|" +
                                  "\n|***** 10 - Cadastro de Pacientes     *****|" +
                                  "\n|***** 20 - Cadastro de Médico        *****|" +
                                  "\n|***** 30 - Cadastro Recepcionista    *****|" +
                                  "\n|***** 40 - Cadastro Fornecedor       *****|" +
                                  "\n|***** 50 - Agenda                    *****|" +
                                  "\n|***** 60 - Prontuário                *****|" +
                                  "\n|***** 70 - Financeiro                *****|" +
                                  "\n|-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*|" +
                                  "\n|***** 0 - Sair do Sistema            *****|");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
                        CadastroPaciente moduloCadastroPacientes = new CadastroPaciente();
                        moduloCadastroPacientes.MenuPaciente();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        CadastroMedico moduloCadastroMedico = new CadastroMedico();
                        moduloCadastroMedico.MenuMedico();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        CadastroRecepcionista moduloCadastroRecepcionista = new CadastroRecepcionista();
                        moduloCadastroRecepcionista.MenuRecepcionista();
                        break;
                    case (int)MenuEnums.CAD_FOR:
                        CadastroFornecedor moduloCadastroFornecedor = new CadastroFornecedor();
                        moduloCadastroFornecedor.MenuFornecedor();
                        break;
                    default:
                        break;
                }
            } while (!(opcao.Equals((Int32)MenuEnums.SAIR)));
        }
    }
}
