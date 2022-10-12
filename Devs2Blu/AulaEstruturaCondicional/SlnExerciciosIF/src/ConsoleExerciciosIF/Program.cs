using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleExerciciosIF
{

    class Program
    {
        const String EXE1 = "1";
        const String EXE2 = "2";
        const String EXE3 = "3";
        const String EXE4 = "4";
        const String EXE5 = "5";
        const String EXE6 = "6";
        const String EXE7 = "7";
        const String EXE8 = "8";

        static void Main(string[] args)
        {
            String opcaoEscolha;
            Console.WriteLine("=-=-=-=-= Menu Exercicios =-=-=-=-=\n" +
                              "=-=-=-=-= 1 - Exercicio 1 =-=-=-=-=\n" +
                              "=-=-=-=-= 2 - Exercicio 2 =-=-=-=-=\n" +
                              "=-=-=-=-= 3 - Exercicio 3 =-=-=-=-=\n" +
                              "=-=-=-=-= 4 - Exercicio 4 =-=-=-=-=\n" +
                              "=-=-=-=-= 5 - Exercicio 5 =-=-=-=-=\n" +
                              "=-=-=-=-= 6 - Exercicio 6 =-=-=-=-=\n" +
                              "=-=-=-=-= 7 - Exercicio 7 =-=-=-=-=\n" +
                              "=-=-=-=-= 8 - Exercicio 8 =-=-=-=-=\n");
            opcaoEscolha = Console.ReadLine();

            switch (opcaoEscolha)
            {
                case EXE1:
                    Exercicio1();
                    break;
                case EXE2:
                    Exercicio2();
                    break;
                case EXE3:
                    Exercicio3();
                    break;
                case EXE4:
                    Exercicio4();
                    break;
                case EXE5:
                    Exercicio5();
                    break;
                case EXE6:
                    Exercicio6();
                    break;
                case EXE7:
                    Exercicio7();
                    break;
                case EXE8:
                    Exercicio8();
                    break;
                default:
                    break;
            }
        }

        static void Exercicio1()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 1 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Int32 numero1, numero2;
            Console.WriteLine("Digite primeiro valor: ");
            Int32.TryParse(Console.ReadLine(), out numero1);
            Console.WriteLine("Digite segundo valor: ");
            Int32.TryParse(Console.ReadLine(), out numero2);
            if (numero1 > numero2)
            {
                Console.WriteLine($"{numero1} é maior que {numero2}");
            }
            else
            {
                Console.WriteLine($"{numero2} é maior que {numero2}");
            }
        }

        static void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 2 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Int32 num1, num2, num3, num4;
            Console.WriteLine("Digite primeiro valor: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Digite segundo valor: ");
            Int32.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("Digite terceiro valor: ");
            Int32.TryParse(Console.ReadLine(), out num3);
            Console.WriteLine("Digite quarto valor: ");
            Int32.TryParse(Console.ReadLine(), out num4);

            if((num1 > num2) && (num1 > num3) && (num1 > num4))
            {
                Console.WriteLine($"{num1} maior numero!");
            }
            else if((num2 > num1) && (num2 > num3) && (num2 > num4))
            {
                Console.WriteLine($"{num2} maior numero!");
            }
            else if((num3 > num1) && (num3 > num2) && (num3 > num4))
            {
                Console.WriteLine($"{num3} maior numero!");
            }
            else if((num4 > num1) && (num4 > num2) && (num4 > num3))
            {
                Console.WriteLine($"{num4} maior numero!");
            }
            else
            {
                Console.WriteLine("Todos os numeros iguais");
            }
        }

        static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 3 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Int32 num;
            Console.WriteLine("Digite um valor: ");
            Int32.TryParse(Console.ReadLine(), out num);
            if (num - num / 2*2 == 0)
            {
                Console.WriteLine("Numero par");
            }
            else
            {
                Console.WriteLine("Numero impar");
            }
        }

        static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 4 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Console.WriteLine("=-=-=-=-= Tabela Produtos =-=-=-=-=\n" +
                              "=-=-=-=-= 001 - Arroz     =-=-=-=-=\n" +
                              "=-=-=-=-= 002 - Feijão    =-=-=-=-=\n" +
                              "=-=-=-=-= 003 - Farinha   =-=-=-=-=\n");
            String opcaoProduto;
            opcaoProduto = Console.ReadLine();
            if (opcaoProduto.Equals("001"))
            {
                Console.WriteLine("Você selecionou arroz!");
            }
            else if (opcaoProduto.Equals("002"))
            {
                Console.WriteLine("Você selecionou feijão!");
            }
            else if (opcaoProduto.Equals("003"))
            {
                Console.WriteLine("Você selecionou farinha!");
            }
            else
            {
                Console.WriteLine("Você selecionou diversos!");
            }
        }

        static void Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 5 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Int32 anoSistema = DateTime.Now.Year, anoNascimentoUsuario;
            Console.WriteLine("Digite o ano que você nasceu: ");
            Int32.TryParse(Console.ReadLine(), out anoNascimentoUsuario);
            Int32 idade = anoSistema - anoNascimentoUsuario;
            if (idade >= 16)
            {
                Console.WriteLine($"Você tem {idade} anos");
                Console.WriteLine("Você pode votar");
            }
            else
            {
                Console.WriteLine($"Você tem {idade} anos");
                Console.WriteLine("Você não pode votar");
            }
        }

        static void Exercicio6()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 6 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            const String SENHA = "1234";
            Console.WriteLine("Digite a senha: ");
            String senhaUsuario = Console.ReadLine();
            if (senhaUsuario.Equals(SENHA))
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO");
            }
        }

        static void Exercicio7()
        {
            Int32 qtdMaca;
            Double precoPagar;
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 7 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n" +
                              "=-=-=-=-=  Menu Tabela de preço maçãs   =-=-=-=-=\n" +
                              "=-=-=-=-=   R$0.30 menos de uma duzia   =-=-=-=-=\n" +
                              "=-=-=-=-=   R$0.25 uma duzia ou mais    =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n\n");
            Console.WriteLine("Digite quantidade de maçãs para comprar: ");
            Int32.TryParse(Console.ReadLine(), out qtdMaca);
            if (qtdMaca < 12)
            {
                precoPagar = qtdMaca * 0.30;
            }
            else
            {
                precoPagar = qtdMaca * 0.25;
            }
            Console.WriteLine($"Valor a pagar: R${precoPagar}");
        }

        static void Exercicio8()
        {
            Int32 num1, num2, num3;
            String textoSaida;
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 8 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Console.WriteLine("Digite o primeiro valor:");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Digite o segundo valor:");
            Int32.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("Digite o terceiro valor:");
            Int32.TryParse(Console.ReadLine(), out num3);

            if (num1 < num2)
            {
                textoSaida = $"{num1}, ";
                if (num2 < num3)
                {
                    textoSaida += $"{num2}, {num3}";
                }
                else 
                {
                    textoSaida += $"{num3}, {num2}";
                }
            }
            else if (num2 < num1)
            {
                textoSaida = $"{num2}, ";
                if (num1 < num3)
                {
                    textoSaida += $"{num1}, {num3}";
                }
                else
                {
                    textoSaida += $"{num3}, {num1}";
                }
            }
            else
            {
                textoSaida = $"{num3}, ";
                if (num1 < num2)
                {
                    textoSaida += $"{num1}, {num2}";
                }
                else
                {
                    textoSaida += $"{num2}, {num1}";
                }
            }
            Console.WriteLine(textoSaida);
        }
    }
}