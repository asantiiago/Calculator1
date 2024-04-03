using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Seja bem vindo a calculadora dos cria\n");
        Console.WriteLine("Pressione qualquer tecla para iniciar");
        Console.ReadKey();
        Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha sua opção:");
            Console.WriteLine("Opção 1 - Soma");
            Console.WriteLine("Opção 2 - Subtração");
            Console.WriteLine("Opção 3 - Divisão");
            Console.WriteLine("Opção 4 - Multiplicação");
            Console.WriteLine("Opção 5 - Sair");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma() 
        {
        Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            int  a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            int a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"Segue o resultado da soma: {a1 + a2}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

        Console.WriteLine("Primeiro Valor:");
        int a1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor:");
        int a2 = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine($"Segue o resultado da subtração: {a1 - a2}");
        Console.ReadKey();
        Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            int a2 = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine($"Segue o resultado da divisão: {a1 / a2}");
        Console.ReadKey();
        Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro Valor:");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            int a2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Segue o resultado da multiplicação: {a1 *a2}");
            Console.ReadKey();
            Menu();
        }
    }
}
