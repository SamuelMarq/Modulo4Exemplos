using System;
using System.Collections.Generic;
using Recodme.Formacao.Modulo4Fichas.Common;

namespace Recodme.Formacao.Modulo4Fichas.Fichas.Exercicios
{
    public class Ficha17solucao
    {

        /// <summary>
        /// Corre todos os exercicios da ficha 17
        /// </summary>
        public static void Ficha17()
        {
            int ex;

            Console.Clear();
            Printer.PrintHeader("Ficha 17", 2, 3, ConsoleColor.Yellow, ConsoleColor.White, '#');
            while (true)
            {
                Console.WriteLine("\nQual o exercicio?");
                Console.WriteLine("Para voltar escolha 0");
                Console.WriteLine("Para fechar a aplicação escolha -1");
                ex = Conversoes.ConverterStringParaInt(Console.ReadLine());
                switch (ex)
                {
                    case -1:
                        Environment.Exit(0);
                        break;
                    case 0:
                        return;
                    case 1:
                        Ex1();
                        break;
                    case 3:
                        Ex3();
                        break;
                    case 10:
                        Ex10();
                        break;/*
                    case 4:
                        ();
                        break;*/
                }
            }
        }

        /// <summary>
        /// ex1 Solicitar uma string e um índice. Apresentar o caracter correspondente ao índice com base na string. 
        /// </summary>
        static void Ex1()
        {
            var s = InputRequest.RequestString("Escreve algo");
            var l = s.Length;
            int i;
            do
            {
                i = InputRequest.RequestInt("Escolha o indice de um caracter da string", true);
            } while (i >= l);
            Console.WriteLine($"{s}[{i}]= {s[i]}");
        }


        /// <summary>
        /// ex3 Solicitar uma string e apresentar a contagem de palavras
        /// </summary>
        static void Ex3()
        {
            var s = InputRequest.RequestString("Escreve algo");
            var l = s.Trim().Split(' ');
            Console.WriteLine($"A string \"{@s}\" contém {l.Length} palavras");
        }


        /// <summary>
        /// ex10 Solicitar uma string e apresentar o número de letras, números e caracteres especiais
        /// </summary>
        static void Ex10()
        {
            var s = InputRequest.RequestString("Escreve algo");
            s = s.ToLower();
            var letras = "abcdefghijklmnopqrstuvxwyz";
            var numeros = "1234567890";
            int l = 0, n = 0, e = 0;
            foreach (var letra in s)
            {
                if (letras.Contains(letra)) l++;
                else if (numeros.Contains(letra)) n++;
                else e++;
            }
            Console.WriteLine($"\nLetras: {l}");
            Console.WriteLine($"Números: {n}");
            Console.WriteLine($"Caracteres Especiais: {e}");
        }
    }
}
