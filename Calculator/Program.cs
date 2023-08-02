﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();      
        }

        static void Menu() {
            Console.Clear();

            Console.WriteLine("-------- MENU --------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("----------------------");
            Console.WriteLine("Escolha uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res) {
                case 1: Soma(); 
                break;
                case 2: Subtracao();
                break;
                case 3: Divisao();
                break;
                case 4: Multiplicacao();
                break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma() {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("O resultado da soma é: " + (v1+v2));

            Console.ReadKey();
            Menu();
        }

        static void Subtracao() {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("O resultado da subtração é: " + (v1-v2));
            Console.ReadKey();
            Menu();
        }
    
        static void Divisao() {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("O resultado da divisão é: " + (v1/v2));
            Console.ReadKey();
            Menu();
        }
    
        static void Multiplicacao(){
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("O resultado da multiplicação é: " + (v1*v2));

            Console.ReadKey();
            Menu();
        }
    }   
}