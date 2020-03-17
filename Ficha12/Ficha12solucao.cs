using System;
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
                    case 10:
                        Lucro();
                        break;
                    case 11:
                        Mes();
                        break;
                    case 12:
                        Arvore_taNal();
                        break;
                    case 13:
                        FaturaAgua();
                        break;
                    case 14:
                        NFibonacci();
                        break;
                    case 15:
                        Fibonice();
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
            int ano=0;
            while (ano<1)
            {
                Console.WriteLine("Qual o ano?");
                ano = Conversoes.ConverterStringParaInt(Console.ReadLine());
            }
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
        /// Ficha12 ex9 Verificar se um triângulo é isósceles, escaleno ou equilátero.
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
            double vI = Conversoes.ConverterStringParaDouble(InputRequest.RequestString("Qual o valor inicial?"));
            double vF = Conversoes.ConverterStringParaDouble(InputRequest.RequestString("Qual o valor final?"));
            if (vI<vF)
            {
                Console.WriteLine("Teve Lucro");
            }
            else if (vI==vF)
            {
                Console.WriteLine("Não teve Lucro nem Prejuizo");
            }
            else
            {
                Console.WriteLine("Teve Prejuizo");
            }
        }

        /// <summary>
        /// Ficha12 ex11 Retornar o nome do mês e o seu número de dias com base num valor numérico (1-12)
        /// </summary>
        private static void Mes()
        {
            string m=InputRequest.RequestString("\nQual o mês? (1-12)");
            switch (m)
            {
                case "1":
                    Console.WriteLine("Janeiro tem 31 dias");
                    break;
                case "2":
                    Console.WriteLine("Fevereiro tem 28 ou 29 dias");
                    break;
                case "3":
                    Console.WriteLine("Março tem 31 dias");
                    break;
                case "4":
                    Console.WriteLine("Abril tem 30 dias");
                    break;
                case "5":
                    Console.WriteLine("Maio tem 31 dias");
                    break;
                case "6":
                    Console.WriteLine("Junho tem 30 dias");
                    break;
                case "7":
                    Console.WriteLine("Julho tem 31 dias");
                    break;
                case "8":
                    Console.WriteLine("Agosto tem 31 dias");
                    break;
                case "9":
                    Console.WriteLine("Setembro tem 30 dias");
                    break;
                case "10":
                    Console.WriteLine("Outubro tem 31 dias");
                    break;
                case "11":
                    Console.WriteLine("Novembro tem 30 dias");
                    break;
                case "12":
                    Console.WriteLine("Dezembro tem 31 dias");
                    break;
                default:
                    Mes();
                    break;
            }
        }

        /// <summary>
        ///  Ficha12 ex12 árvore de taNal
        /// </summary>
        private static void Arvore_taNal()
        {
            Console.WriteLine("\nQual é a dimensão da árvore ? ");
            int n = Conversoes.ConverterStringParaInt(Console.ReadLine());
            int m = 0;
            int i = n*2-1;
            while (m < n)
            {
                int a = 0;
                while (a != m)
                {
                    Console.Write(" ");
                    a++;
                }
                int b = 0;
                while (b != i)
                {
                    Console.Write("*");
                    b++;
                }
                i -= 2;
                Console.Write("\n");
                m++;
            }
        }

        /// <summary>
        ///  Ficha12 ex13 árvore de taNal
        /// </summary>
        private static void FaturaAgua()
        {
            string reg=InputRequest.RequestString("\nQual a Região onde se encontra");
            double pre = 0;
            switch (reg)
            {
                case "A":pre = 2; break;
                case "B":pre = 1.2 ;break;
                case "C":pre = 1; break;
                case "D":pre = 0.75; break;
                default:
                    Console.WriteLine("Região não Válida!\nApenas existém as regiões A; B; C; D");
                    FaturaAgua();
                    return;
            }
            double qnt = Conversoes.ConverterStringParaDouble(InputRequest.RequestString("\nQuanta água foi consumida?"));
            Console.WriteLine($"O preço total é: {Math.Round(qnt * pre,2)}");
        }

        /// <summary>
        ///  Ficha12 ex14 Apresentar os primeiros n números de Fibonacci (sem recursividade)
        /// </summary>
        private static void NFibonacci()
        {
            int n = Conversoes.ConverterStringParaInt(InputRequest.RequestString("\nQuantos Numeros?"));
            Console.WriteLine(Fibonacci(n));
        }

        /// <summary>
        ///  Ficha12 ex15 Solicitar um número n, e caso este faça parte da série de Fibonacci, apresentar "n é Fibonice!"
        /// </summary>
        private static void Fibonice()
        {
            int n = Conversoes.ConverterStringParaInt(InputRequest.RequestString("\nQual o Numero?"));
            if (Fibonacci(n,1)=="0")
            {
                Console.WriteLine($"{n} é Fibonice!");
            }
            else
            {
                Console.WriteLine($"{n} não faz parte da sequência de Fibonacci");

            }
        }

        /// <summary>
        /// No modo default devolve os primeiros n numeros de fibonacci
        /// No modo 1 devolve "0" se n faz parte da sequencia e "1" se não fizer
        /// </summary>
        private static string Fibonacci(int n,int m=0)
        {
            string fib = "";
            int currentN = 1;
            int prevN = 0;
            int extra;
            for (int i = 1; true; i++)
            {
                fib += currentN.ToString() + "; ";
                extra = currentN;
                currentN += prevN;
                prevN = extra;
                if (m != 0)
                    if (n == currentN)
                    {
                        return "0";
                    }
                    else if (n <= currentN)
                    {
                        return "1";
                    }
                    else{}
                else if (n <= i)
                {
                    return fib;
                }
            }
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
