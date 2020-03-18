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
                        NnaturR(0);
                        break;
                    case 2:
                        Nnatur(0);
                        break;
                    case 3:
                        SomaN(0);
                        break;
                    case 4:
                        Pares();
                        break;
                    case 5:
                        FibonacciSeq();
                        break;
                    case 6:
                        Fact();
                        break;
                }
            }
        }

        /// <summary>
        /// ex1.2 Apresentar os n primeiros números naturais por ordem descendente
        /// </summary>
        private static void Nnatur(int n)
        {
            if (n==0)
            {
                Console.WriteLine("\nQuantos Numeros");
                n = Conversoes.ConverterStringParaInt(Console.ReadLine());
                while (n <= 0)
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
        /// ex1.1 Apresentar os n primeiros números naturais por ordem crescente
        /// </summary>
        private static void NnaturR(int n, int m=1)
        {
            if (n == 0)
            {
                Console.WriteLine("\nQuantos Numeros");
                n = Conversoes.ConverterStringParaInt(Console.ReadLine());
                while (n <= 0)
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

        /// <summary>
        /// ex1.3 Apresentar a soma dos n primeiros números naturais.
        /// </summary>
        private static int SomaN(int n, int s= 0)
        {
            if (n == 0)
            {
                n=Conversoes.ConverterStringParaInt(InputRequest.RequestString("\nQuantos Numeros"));
                while (n <=0)
                {
                    n = Conversoes.ConverterStringParaInt(InputRequest.RequestString("Escolha uma quantidade diferente"));
                }
                Console.WriteLine($"A soma dos {n} primeiros números naturais é { SomaN(n)}");
                return 0;
            }
            else if (n == 1)
            {
                s++;
                return(s);
            }
            else
            {
                s += n;
                return(SomaN(n - 1, s));
            }
        }

        /// <summary>
        /// ex1.4 Apresentar os números pares entre dois números
        /// </summary>
        private static void Pares(int n1=0, int n2=0)
        {
            if (n1==0&&n2==0)
            {
                n1 = Conversoes.ConverterStringParaInt(InputRequest.RequestString("\nEscolha um numero"));
                n2 = Conversoes.ConverterStringParaInt(InputRequest.RequestString("Escolha outro numero"));
                Pares(n1,n2);
            }
            if (n1 > n2)
            {
                Console.WriteLine("O primeiro numero tem de ser menor que o segundo");
                Pares();
            }
            else
            {
                if (n1 % 2 == 0)
                {
                    if (n1 == n2)
                        Console.Write(n1 + "; ");
                    else
                    { 
                        Console.Write(n1 + "; ");
                        Pares(n1 + 1, n2);
                    }
                }
                else
                {
                    if (n1 == n2)
                        return;
                    else
                        Pares(n1 + 1, n2);
                }
            }
        }


        /// <summary>
        /// ex1.5 Apresentar os n primeiros números da série de Fibonacci 
        /// </summary>
        private static void FibonacciSeq(int n = 0, int m=1)
        {
            if (n == 0)
            {
                n = Conversoes.ConverterStringParaInt(InputRequest.RequestString("\nQuantos Numeros"));
                while (n <= 0)
                {
                    n = Conversoes.ConverterStringParaInt(InputRequest.RequestString("Escolha uma quantidade diferente"));
                }
                FibonacciSeq(n);
            }
            else if (n == m)
                Console.Write(FibonacciVal(n));
            else
            {
                Console.Write(FibonacciVal(m) + "; ");
                FibonacciSeq(n, m+1);
            }
        }

        private static int FibonacciVal(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return FibonacciVal(n - 1) + FibonacciVal(n - 2);
        }

        /// <summary>
        /// ex1.6 Apresentar o fatorial de um número 
        /// </summary>
        private static int Fact(int n=0, int f=1, bool s=true)
        {
            if (s)
            {
                var ns = InputRequest.RequestString("\nQual o número?");
                if (!int.TryParse(ns, out n)||n<0)
                {
                    while (!int.TryParse(ns, out n) || n < 0)
                    {
                        ns = InputRequest.RequestString("Escolha um número diferente?");
                    }
                }
                if (n==0)
                    Console.Write($"{n}! = 1\n");
                else
                    Console.Write($"{n}! = { Fact(n, 1, false)}\n");
                return 0;
            }
            else
            {
                if (n == 0)
                    return f;
                else
                {
                    f *= n;
                    return Fact(n - 1, f, false);
                }
            }
        }
    }
}
