using System;
using Conversoes_;

namespace Ficha12
{
    public class Ficha12solucao
    {
        /// <summary>
        /// Corre todos os exercicios da ficha 12
        /// </summary>
        public static void Ficha12()
        {
            int ex, al;

            while (true)
            {
                Console.WriteLine("\nQual o exercicio?");
                Console.WriteLine("Para sair escolha 0\n");
                ex = Conversoes.ConverterStringParaInt(Console.ReadLine());
                switch (ex)
                {
                    case 0:
                        return;
                    case 1:
                        TreN();
                        break;
                    case 2:
                        DoisN();
                        break;
                    case 3:
                        Resul();
                        break;
                    case 4:
                        Primos();
                        break;
                    case 5:
                        Hello();
                        break;
                    case 6:
                        Guess();
                        break;
                }
            }
        }

        private static int LerNumEConverter()
        {
            Console.WriteLine("\nEscreva um numero: ");
            return Conversoes.ConverterStringParaInt(Console.ReadLine());
        }

        /// <summary>
        /// Ficha12 ex1 Solicitar três números e apresentar o seu produto.
        /// </summary>
        private static void TreN()
        {
            int n = 1;

            for (int i = 0; i < 3; i++)
            {
                n *= LerNumEConverter();
            }
            Console.WriteLine($"Producto: {n}");
        }

        /// <summary>
        /// Ficha12 ex2 Solicitar dois números e apresentar os valores de cada operação aritmética
        /// </summary>
        private static void DoisN()
        {
            int n=0;

            for (int i = 0; i < 2; i++)
            {
                if (i==0)
                {
                    n = LerNumEConverter();
                }
                else
                {
                    int m = LerNumEConverter();
                    Console.WriteLine($"{n}+{m}={n+m}");
                    Console.WriteLine($"{n}-{m}={n-m}");
                    Console.WriteLine($"{n}*{m}={n*m}");
                    Console.WriteLine($"{n}/{m}={n/m}");
                    Console.WriteLine($"{n}%{m}={n%m}");
                }
                
            }
            
        }

        /// <summary>
        /// Ficha12 ex3 Solicitar três números e apresentar o resultado de (x+y).z and x.y + y.z
        /// </summary>
        private static void Resul()
        {
            int n = 0;
            int m = 0;

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    n = LerNumEConverter();
                }
                else if (i==1)
                {
                    m = LerNumEConverter();
                }
                else
                {
                    int l = LerNumEConverter();
                    Console.WriteLine($"({n}+{m})*{l}={(n + m)*l}");
                    Console.WriteLine($"{n}*{m}+{m}*{l}={n * m+m*l}");
                }

            }

        }

        /// <summary>
        /// Ficha12 ex4 Solicitar um número e apresentar todos os números primos até ao indicado
        /// </summary>
        private static void Primos()
        {
            int n = LerNumEConverter();
            string primos = "";
            bool primo = true;

            for (int i = 2; i < n; i++)
            {
                if (n==2)
                {
                    primos += n.ToString() +"; " ;
                }
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i%j==0)
                        {
                            primo=false;
                            break;
                        }
                    }
                    if (primo==true)
                    {
                        primos += i.ToString() + "; ";
                    }
                }
                primo = true;
            }
            Console.WriteLine(primos);
        }

        /// <summary>
        /// Ficha12 ex5 
        /// </summary>
        private static void Hello()
        {
            Console.WriteLine("\nHello?");
            var r = Console.ReadLine();
            if (r == "Is it me you're looking for?")
            {
                Console.WriteLine("I can see it in your eyes");
            }
        }

        /// <summary>
        /// Ficha12 ex6 Adivinhar numero
        /// </summary>
        private static void Guess()
        {
            Console.WriteLine("\nPense num número de 1 a 100. É maior que 50?");
            string res = Console.ReadLine();
            int a = 50, b = 50;
            do
            {
                b -= b / 2;
                if (res == "S" || res == "s")
                {
                    a += b;
                }
                else
                {
                    a -= b;
                }
                if (b != 1)
                {
                    Console.WriteLine($"É maior que {a}?");
                    res = Console.ReadLine();
                }
            } while (b > 1);
            Console.WriteLine($"É {a}?");
            res = Console.ReadLine();
            if (res!="S")
            {
                Console.WriteLine($"É {a+1}?");
                res = Console.ReadLine();
                if (res != "S")
                    Console.WriteLine($"É {a-1}?");
            }
        }
    }
}
