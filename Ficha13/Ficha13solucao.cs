using System;
using Conversoes_;

namespace Ficha13
{
    public class Ficha13solucao
    {
        /// <summary>
        /// Corre todos os exercicios da ficha 13
        /// </summary>
        public static void Ficha13()
        {
            int ex;

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
                        Calculadora();
                        break;
                }
            }
        }


        private static decimal LerNumEConverter2()
        {
            decimal n = 0;
            Console.WriteLine("\nEscreva um numero: ");
            while (69!=420)
            {
                try
                {
                    n = Convert.ToDecimal(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nEntrada inválida: ");
                    Console.WriteLine("\nEscreva um numero: ");
                }
            }
            return n;
        }

        /// <summary>
        /// Calculadora
        /// </summary>
        public static void Calculadora()
        {
            char op;
            decimal n=0;
            bool firstrun = true;

            Console.WriteLine("\nCalculadora");
            while (true)
            {
                if (firstrun)
                {
                    n = LerNumEConverter2();
                    firstrun = false;
                }
                Console.WriteLine("\nPara sair escolha 'X'");
                Console.WriteLine("Para apagar escolha 'C'\n");
                Console.WriteLine("Qual a operação\n");
                op = Console.ReadLine()[0];
                
                switch (op)
                {
                    case 'X':
                        return;
                    case 'C':
                        n = 0;
                        firstrun = true;
                        Console.Clear();
                        break;
                    case '+':
                        n=Soma(n);
                        break;
                    case '-':
                        n = Minus(n);
                        break;
                    case '*':
                        n = Times(n);
                        break;
                    case '/':
                        n = Div(n);
                        break;
                }
            }
        }

        public static Decimal Soma(decimal n1)
        {
            decimal n2;
            Console.WriteLine("Numero");
            n2 = LerNumEConverter2();
            var n3 = n1 + n2;
            Console.WriteLine($"{n1}+{n2}={n3}");
            return n3;
        }

        public static Decimal Minus(decimal n1)
        {
            decimal n2;
            Console.WriteLine("Numero");
            n2 = LerNumEConverter2();
            var n3 = n1 - n2;
            Console.WriteLine($"{n1}-{n2}={n3}");
            return n3;
        }

        public static Decimal Times(decimal n1)
        {
            decimal n2;
            Console.WriteLine("Numero");
            n2 = LerNumEConverter2();
            var n3 = n1 * n2;
            Console.WriteLine($"{n1}*{n2}={n3}");
            return n3;
        }

        public static Decimal Div(decimal n1)
        {
            decimal n2, n3;
            n3 = 0;
            while (true)
            {
                try
                {
                    n2 = LerNumEConverter2();
                    n3 = n1 / n2;
                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Can't divide by 0");
                    Console.WriteLine("Choose another number");
                }
            }
            Console.WriteLine($"{n1}/{n2}={n3}");
            return n3;
        }
    }
}
