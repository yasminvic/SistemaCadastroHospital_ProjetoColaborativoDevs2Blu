using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExerciciosSwitch
{
    public class Program
    {
        const String EXE1 = "1";
        const String EXE2 = "2";
        const String EXE3 = "3";
        const String EXE4 = "4";
        const String EXE5 = "5";
        const String EXE6 = "6";
        const int PT7 = 10;
        const int PT14 = 20;
        const int PT21 = 30;
        const int PT1a6 = 1;
        const int PT8a13 = 5;
        const int PT15a20 = 6;

        static void Main(string[] args)
        {
            String opcaoEscolha;
            Console.WriteLine("=-=-=-=-= Menu Exercicios =-=-=-=-=\n" +
                              "=-=-=-=-= 1 - Exercicio 1 =-=-=-=-=\n" +
                              "=-=-=-=-= 2 - Exercicio 2 =-=-=-=-=\n" +
                              "=-=-=-=-= 3 - Exercicio 3 =-=-=-=-=\n" +
                              "=-=-=-=-= 4 - Exercicio 4 =-=-=-=-=\n" +
                              "=-=-=-=-= 5 - Exercicio 5 =-=-=-=-=\n" +
                              "=-=-=-=-= 6 - Exercicio 6 =-=-=-=-=\n" );
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
            Console.WriteLine("=-=-=-=-= Tabela de frutas =-=-=-=-=\n" +
                              "=-=-=-=-=      Maçã        =-=-=-=-=\n" +
                              "=-=-=-=-=      Kiwi        =-=-=-=-=\n" +
                              "=-=-=-=-=    Melancia      =-=-=-=-=\n");
            String fruta = Console.ReadLine();
            switch (fruta.ToLower())
            {
                case "maçã":
                    Console.WriteLine("Não vendemos esta fruta aqui");
                    break;
                case "kiwi":
                    Console.WriteLine("Estamos com escassez de kiwis");
                    break;
                case "melancia":
                    Console.WriteLine("Aqui está, são 3 reais o quilo");
                    break;
                default:
                    break;
            }
        }

        static void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 2 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Console.WriteLine("=-=-=-=-= Tabela modelos de carro =-=-=-=-=\n" +
                              "=-=-=-=-=         Hatch           =-=-=-=-=\n" +
                              "=-=-=-=-=         Sedans          =-=-=-=-=\n" +
                              "=-=-=-=-=      Motocicletas       =-=-=-=-=\n" +
                              "=-=-=-=-=      Caminhonetes       =-=-=-=-=\n");
            String modeloCarro = Console.ReadLine();
            switch (modeloCarro.ToLower())
            {
                case "hatch":
                    Console.WriteLine("Compra efetuada com sucesso");
                    break;
                case "sedans":
                case "motocicletas":
                case "caminhonetes":
                    Console.WriteLine("Tem certeza que não prefere este modelo?");
                    break;
                default:
                    Console.WriteLine("Não trabalhamos com este tipo de automóvel aqui");
                    break;
            }
        }
        
        static void Exercicio3()
        {
            Int32 num1, num2;
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 3 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Console.WriteLine("=-=-=-=-= Calculadora =-=-=-=-=\n" +
                              "=-=-=-=-=  (+) Soma   =-=-=-=-=\n" +
                              "=-=-=-=-=  (-) Menos  =-=-=-=-=\n" +
                              "=-=-=-=-=  (*) Vezes  =-=-=-=-=\n" +
                              "=-=-=-=-=  (/) Dividi =-=-=-=-=\n");
            String opcaoCalcular = Console.ReadLine();
            Console.WriteLine("Digite o primeiro valor: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Digite o segundo valor: ");
            Int32.TryParse(Console.ReadLine(), out num2);
            switch (opcaoCalcular)
            {
                case "+":
                    Console.WriteLine($"Soma: {num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Subtração: {num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Multiplicação: {num1} x {num2} = {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"Divisão: {num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Não existe essa operação na calculadora");
                    break;
            }
        }

        static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 4 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
            Console.WriteLine("=-=-=-=-=       Tabela de produtos     =-=-=-=-=\n" +
                              "=-=-=-=-= 1 - Produtos Não-perecíveis  =-=-=-=-=\n" +
                              "=-=-=-=-= 2 - Frutas                   =-=-=-=-=\n" +
                              "=-=-=-=-= 3 - Bebidas                  =-=-=-=-=\n");
            String tipoProduto = Console.ReadLine();
            switch (tipoProduto)
            {
                case "1":
                    Console.WriteLine("Arroz\nCafé\nFeijão");
                    break;
                case "2":
                    Console.WriteLine("Manga\nBanana\nMaçã");
                    break;
                case "3":
                    Console.WriteLine("Leite\nSuco\nRefrigerante");
                    break;
                default:
                    Console.WriteLine("Não existe esse tipo de produto");
                    break;
            }
        }
        
        static void Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Bem vindo ao exercicio 5 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                              "=-=-=-=-= Jogo do 21 =-=-=-=-=\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");


        }

    }
}
