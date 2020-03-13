﻿using System;
using Common;

namespace Ficha12
{
    public class Ficha12solucao
    {
        /// <summary>
        /// Corre todos os exercicios da ficha 12
        /// </summary>
        public static void Ficha12()
        {
            int ex;

            while (true)
            {
                Console.WriteLine("\nQual o exercicio?");
                Console.WriteLine("Para voltar escolha 0\n");
                ex = Conversoes.ConverterStringParaInt(Console.ReadLine());
                switch (ex)
                {
                    case -1:
                        Environment.Exit(0);
                        break;
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
                        Dist();
                        break;
                    case 7:
                        Bissexto();
                        break;
                    case 8:
                        Beers();
                        break;
                    case 9:
                        Trian();
                        break;
                    case 16:
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
                    Console.WriteLine();
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
        /// Ficha12 ex6 Solicitar uma quantidade de itens e distribuí-los entre duas pessoas 
        /// </summary>
        private static void Dist()
        {
            int items;
            Console.WriteLine("Quantos items?");
            items = Conversoes.ConverterStringParaInt(Console.ReadLine());
            for (int i = 0; i < items; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Um pra mim");
                }
                else
                {
                    Console.WriteLine("Um pra ti");
                }
            }
        }

        /// <summary>
        /// Ficha12 ex7 Solicitar um ano e determinar se é bissexto. 
        /// </summary>
        private static void Bissexto()
        {
            int ano;
            Console.WriteLine("Qual o ano?");
            ano = Conversoes.ConverterStringParaInt(Console.ReadLine());
            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                Console.WriteLine("O ano é Bissexto");
            }
            else
            {
                Console.WriteLine("O ano não é Bissexto");
            }
        }

        /// <summary>
        /// Ficha12 ex8 Apresentar a letra para a música “99 beers on the wall”.
        /// </summary>
        private static void Beers()
        {
            int n = 99;
            while (n>1)
            {
                Console.WriteLine($"{n} bottles of beer on the wall, {n} bottles of beer.");
                n--;
                Console.WriteLine($"Take one down and pass it around, {n} bottles of beer on the wall.\n");
            }
            Console.WriteLine($"{n} bottle of beer on the wall, {n} bottle of beer.");
            Console.WriteLine($"Take one down and pass it around, no more bottles of beer on the wall.\n");
            Console.WriteLine($"Go to the store and buy some more, 99 bottles of beer on the wall.");
            string res = InputRequest.RequestString("Continue?");
            if (res == "S" || res == "s" || res == "Y" || res == "y" || res == "Sim" || res == "sim" || res == "Yes" || res == "yes")
                Beers();
        }

        /// <summary>
        /// Ficha12 ex9 Verificar se um triângulo é isóscele, escaleno ou equilátero.
        /// </summary>
        private static void Trian()
        {
            string l1, l2, l3;
            l1=InputRequest.RequestString("\nQual o tamanho dos lados do triângulo?\nPrimeiro Lado:");
            l2=InputRequest.RequestString("Segundo Lado:");
            l3=InputRequest.RequestString("Terceiro Lado:");
            if (l1==l2&&l1==l3)
            {
                Console.WriteLine("O triângulo é equilátero.");
            }
            else if (l1==l2||l1==l3||l2==l3)
            {
                Console.WriteLine("O triângulo é isósceles.");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno.");
            }
        }

        /// <summary>
        /// Ficha12 ex10 Verificar com base em dois valores se uma operação deu lucro ou prejuízo
        /// </summary>
        private static void Lucro()
        {

        }

        /// <summary>
        /// Ficha12 ex16 Adivinhar numero
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
            if (res!="S" && res != "s")
            {
                Console.WriteLine($"É {a+1}?");
                res = Console.ReadLine();
                if (res != "S" && res != "s")
                    Console.WriteLine($"É {a-1}?");
            }
        }

    }
}
