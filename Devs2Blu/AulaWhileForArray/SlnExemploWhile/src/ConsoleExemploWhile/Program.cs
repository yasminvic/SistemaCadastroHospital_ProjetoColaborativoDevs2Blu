using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExemploWhile
{
    internal class Program
    {
        const String EXE1 = "1";
        const String EXE2 = "2";

        static void Main(string[] args)
        {
            String opcaoEscolha;
            Console.WriteLine("=-=-=-=-= Menu Exercicios =-=-=-=\n" +
                              "=-=-=-=-= 1 - Exemplo 1 =-=-=-=-=\n" +
                              "=-=-=-=-= 2 - Exemplo 2 =-=-=-=-=\n");
            opcaoEscolha = Console.ReadLine();

            switch (opcaoEscolha)
            {
                case EXE1:
                    Exemplo1();
                    break;
                case EXE2:
                    Exemplo2();
                    break;
                default:
                    break;
            }
        }
            static void Exemplo1()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exemplo 1 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            int numero = 1;

            while (numero <= 100)
            {
                if (!(numero - numero / 2 * 2 == 0)) // !(numero % 2 == 0)
                {
                    Console.Write($"| {numero} |\n");
                }

                numero++;
            }
        }

        static void Exemplo2()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exemplo 2 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            int somaValores = 0, quantidadeValores, contador = 1;
            Random rd = new Random();

            Console.WriteLine("Informe a quantidade de valores para serem somados:");
            Int32.TryParse(Console.ReadLine(), out quantidadeValores);

            while (contador <= quantidadeValores)
            {
                int valor = rd.Next(5, 10);
                Console.Write($"{valor}, ");
                somaValores += valor;
                contador++;
            }

            int mediaAlunos = somaValores / quantidadeValores;

            Console.WriteLine($"\nSomatório = {somaValores}");
        }
    }
}
