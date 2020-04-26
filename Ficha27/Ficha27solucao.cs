using System;
using System.Collections.Generic;
using System.Linq;
using Recodme.Formacao.Modulo4Fichas.Common;

namespace Recodme.Formacao.Modulo4Fichas.Fichas.Exercicios
{
    public class Ficha27solucao
    {

        public static void Ficha27()
        {
            int ex;

            Console.Clear();
            Printer.PrintHeader("Ficha 27", 2, 3, ConsoleColor.Yellow, ConsoleColor.White, '#');
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
                    case 3:
                        Ex3();
                        break;
                    case 5:
                        Ex5();
                        break;/*
                    case 3:
                        ();
                        break;
                    case 4:
                        ();
                        break;*/
                }
            }
        }

        /// <summary>
        /// Cria uma função que retorna uma lista com o quadrado de cada número.
        /// </summary>
        static void Ex3()
        {

            int[] a = new int[] { 3, 4, 6, 8 };
            var pow = a.Select(n => Math.Pow(n, 2)).ToArray();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}^2 = {pow[i]}");
            }
        }

        /// <summary>
        /// Numa string, apresenta a listagem de todos os caracteres maiúsculos.
        /// </summary>
        static void Ex5()
        {

            var s = InputRequest.RequestString("Escreve algo");
            var m = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";
            var letrasM = s.Where(l => m.Contains(l)).ToArray();
            s = "";

            foreach (var l in letrasM)
            {
                s += $"{l}; ";
            }
            Console.WriteLine(s);
        }
    }
}
