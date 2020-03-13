using System;
using Common;

namespace Ficha8
{
    public class Ficha8solucao
    {
        /// <summary>
        /// Corre todos os exercicios da ficha 8
        /// </summary>
        public static void Ficha8()
        {
            int ex;

            while (true)
            {
                Console.WriteLine("\n\nQual o exercicio?");
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
                        Nnatur(0);
                        break;
                    case 2:
                        NnaturR(0);
                        break;
                }
            }
        }

        /// <summary>
        /// ex1.1 Apresentar os n primeiros números naturais
        /// </summary>
        private static void Nnatur(int n)
        {
            if (n==0)
            {
                Console.WriteLine("\nQuantos Numeros");
                n = Conversoes.ConverterStringParaInt(Console.ReadLine());
                while (n==0)
                {
                    Console.WriteLine("Escolha um numero diferente");
                    n = Conversoes.ConverterStringParaInt(Console.ReadLine());
                }
                Nnatur(n);
            }
            else if (n==1)
            {
                Console.Write("; 1");
            }
            else
            {
                Console.Write($"{n}");
                Console.Write("; ");
                Nnatur(n - 1);
            }
        }

        /// <summary>
        /// ex1.1 Apresentar os n primeiros números naturais
        /// </summary>
        private static void NnaturR(int n, int m=1)
        {
            if (n == 0)
            {
                Console.WriteLine("\nQuantos Numeros");
                n = Conversoes.ConverterStringParaInt(Console.ReadLine());
                while (n == 0)
                {
                    Console.WriteLine("Escolha um numero diferente");
                    n = Conversoes.ConverterStringParaInt(Console.ReadLine());
                }
                NnaturR(n);
            }
            else if (n == m)
            {
                Console.Write($"{n}");
            }
            else
            {
                Console.Write($"{m}");
                Console.Write("; ");
                NnaturR(n,m+1);
            }
        }
    }
}
