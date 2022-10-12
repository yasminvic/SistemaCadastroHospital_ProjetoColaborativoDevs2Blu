using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercicioWhile
{
    internal class Program
    {
        const String EXE1 = "1";
        const String EXE2 = "2";
        const String EXE3 = "3";
        const String EXE4 = "4";
        const String EXE5 = "5";
        const String EXE6 = "6";
        const String EXE7 = "7";

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
                              "=-=-=-=-= 7 - Exercicio 7 =-=-=-=-=\n");
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
            Int32 i = 0;
            while (i <= 100)
            {
                if (!(i % 2 == 0))
                {
                    Console.WriteLine($"| {i} |");
                }
                i++;
            }
        }

        static void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 2 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Int32 i = 0;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"| {i} |");
                }
                i++;
            }
        }

        static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 3 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Int32 i = 0, numeroMaximo;
            String textoSaidaPar = "| PARES |\n", textoSaidaImpar = "| IMPARES |\n";
            Console.Write("Digite o limite do looping: ");
            Int32.TryParse(Console.ReadLine(), out numeroMaximo);
            while (i <= numeroMaximo)
            {
                if (i % 2 == 0)
                {
                    textoSaidaPar += $"| {i} |\n";
                }
                else
                {
                    textoSaidaImpar += $"| {i} |\n";
                }
                i++;
            }
            Console.WriteLine(textoSaidaPar);
            Console.WriteLine(textoSaidaImpar);
        }

        static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 4 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Int32 qtdAlunos, i = 0;
            Console.Write("Quantidade de alunos que realizaram a prova: ");
            Int32.TryParse(Console.ReadLine(), out qtdAlunos);
            Double notaAluno, soma = 0, media = 0;
            while (i < qtdAlunos)
            {
                Console.WriteLine($"Digite a nota do {i + 1} aluno: ");
                Double.TryParse(Console.ReadLine(), out notaAluno);
                soma += notaAluno;
                i++;
            }
            media = soma / i;
            Console.WriteLine($"Media de nota dos alunos: {media}");
        }

        static void Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 5 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            String textoAbaixo = "", textoLado = "";
            Int32 i = 0;
            while (i <= 20)
            {
                textoAbaixo += $"| {i} |\n";
                textoLado += $"| {i} | ";
                i++;
            }
            Console.WriteLine(textoAbaixo);
            Console.WriteLine(textoLado);
        }

        static void Exercicio6()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 6 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Int32 i = 1000;
            String textoSaida = "| RESTO DE 5 |\n";
            while (i <= 1999)
            {
                if ((i % 11) == 5)
                {
                    textoSaida += $"| {i} |\n";
                }
                i++;
            }
            Console.WriteLine(textoSaida);
        }

        static void Exercicio7()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 7 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Random rd = new Random();
            Int32 numAleatorio = rd.Next(1, 20), i = 0;
            Int32 numDigitadoUser;
            String textoSaida = "| RESULTADO |\n";
            while (i < 3)
            {
                Console.WriteLine($"Digite a {i + 1} tentativa: ");
                Int32.TryParse(Console.ReadLine(), out numDigitadoUser);
                if (numDigitadoUser == numAleatorio)
                {
                    textoSaida += "| Você acertou o número! |\n";
                    i = 3;
                }
                if (i == 2)
                {
                    textoSaida += "| Tente novamente na próxima! | \n";
                }
                i++;
            }
            Console.WriteLine(textoSaida);
        }
    }
}
