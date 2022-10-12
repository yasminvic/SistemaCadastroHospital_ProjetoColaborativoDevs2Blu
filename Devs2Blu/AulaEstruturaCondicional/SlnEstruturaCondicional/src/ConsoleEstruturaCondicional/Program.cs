using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEstruturaCondicional
{
    public class Program
    {
        const int MENOR_VALOR = 999999999;
        static void Main(string[] args)
        {
            Exemplo1();
            Exemplo2();
            Exemplo3();
            Exemplo4();
        }

        static void Exemplo1()
        {
            int valor1, valor2, valor3, valor4;
            int menorValor = MENOR_VALOR;

            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exemplo 2 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");

            Console.WriteLine("Informar o Valor 1");
            Int32.TryParse(Console.ReadLine(), out valor1);

            Console.WriteLine("Informar o Valor 2");
            Int32.TryParse(Console.ReadLine(), out valor2);

            Console.WriteLine("Informar o Valor 3");
            Int32.TryParse(Console.ReadLine(), out valor3);

            Console.WriteLine("Informar o Valor 4");
            Int32.TryParse(Console.ReadLine(), out valor4);

            if (valor1 < menorValor)
            {
                menorValor = valor1;
            }
            if (valor2 < menorValor)
            {
                menorValor = valor2;
            }
            if (valor3 < menorValor)
            {
                menorValor = valor3;
            }
            if (valor4 < menorValor)
            {
                menorValor = valor4;
            }

            Console.WriteLine($"O Menor valor é {menorValor}");
        }

        static void Exemplo2()
        {
            int valor1, valor2, valor3, valor4;
            String textoSaida = "";

            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exemplo 3 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");

            Console.WriteLine("Informar o Valor 1");
            Int32.TryParse(Console.ReadLine(), out valor1);

            Console.WriteLine("Informar o Valor 2");
            Int32.TryParse(Console.ReadLine(), out valor2);

            Console.WriteLine("Informar o Valor 3");
            Int32.TryParse(Console.ReadLine(), out valor3);

            Console.WriteLine("Informar o Valor 4");
            Int32.TryParse(Console.ReadLine(), out valor4);

            if (valor1 < valor2 &&
                valor1 < valor3 &&
                valor1 < valor4)
            {
                Console.WriteLine($"Valor 1 ({valor1}) é o menor!");
            }
            else if (valor2 < valor3 &&
                       valor2 < valor4)
            {
                textoSaida = $"Valor 2 ({valor2}) é o menor!";
            }
            else if (valor3 < valor4)
            {
                textoSaida = $"Valor 3 ({valor3}) é o menor!";
            }
            else
            {
                textoSaida = $"Valor 4 ({valor4}) é o menor!";
            }

            Console.WriteLine(textoSaida);
        }

        static void Exemplo3()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exemplo 4 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            int primeiroValor, segundoValor;
            String textoSaida = "";

            Console.WriteLine("Informe o primeiro valor:");
            Int32.TryParse(Console.ReadLine(), out primeiroValor);

            Console.WriteLine("Informe o segundo valor:");
            Int32.TryParse(Console.ReadLine(), out segundoValor);

            if (primeiroValor > segundoValor)
            {
                textoSaida = $"O primeiro valor é maior! ({primeiroValor})";
            }
            else if (segundoValor > primeiroValor)
            {
                textoSaida = $"O segundo valor é maior! ({segundoValor})";
            }
            else
            {
                textoSaida = "Os dois números são iguais!";
            }
        }

        static void Exemplo4()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exemplo 4 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            string textoSaida;
            string nomeCandidato;
            int idadeCandidato, notaCandidato;


            Console.WriteLine("Informe o Nome do Candidato:");
            nomeCandidato = Console.ReadLine();

            Console.WriteLine("Informe a Idade do Candidato:");
            string idadeSTR = Console.ReadLine();

            if (idadeSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para Idade!");
                return;
            }
            else
            {
                idadeCandidato = Int16.Parse(idadeSTR);
            }

            Console.WriteLine("Informe a Nota do Candidato:");
            string notaSTR = Console.ReadLine();

            if (notaSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para Nota!");
                return;
            }
            else
            {
                notaCandidato = Int16.Parse(notaSTR);
            }

            textoSaida = $"Candidato: {nomeCandidato}\n";
            textoSaida += $"Idade: {idadeCandidato}";

            if (idadeCandidato < 18)
            {
                textoSaida += "(Menor de idade)\n";
            }
            else
            {
                textoSaida += "(Maior de idade)\n";
            }

            textoSaida += $"Nota Final: {notaCandidato}\n\n";

            if (notaCandidato > 5)
            {
                textoSaida += @"*******************
                               *** APROVADO!!! ***
                               *******************";
            }
            else
            {
                textoSaida += "| REPROVADO! :( |";
            }

            Console.WriteLine(textoSaida);
        }
    }
}
