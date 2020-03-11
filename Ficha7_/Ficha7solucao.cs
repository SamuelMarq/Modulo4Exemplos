using System;
using Conversoes_;


namespace Ficha7
{
    public class Ficha7solucao
    {
        /// <summary>
        /// Corre todos os exercicios da ficha 7
        /// </summary>
        public static void Ficha7()
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
                        Console.WriteLine("\nQual a alinea?");
                        al = Conversoes.ConverterStringParaInt(Console.ReadLine());
                        switch (al)
                        {
                            case 1:
                                Nota();
                                break;
                            case 2:
                                BMI();
                                break;
                            case 3:
                                Multi3ou7();
                                break;
                            case 4:
                                Verif1();
                                break;
                            case 5:
                                Verif2();
                                break;
                            case 6:
                                Elevador();
                                break;
                            case 7:
                                Soma10();
                                break;
                            case 8:
                                Compra();
                                break;
                            case 9:
                                Media();
                                break;
                            case 10:
                                Operacao();
                                break;
                            case 11:
                                Tabela();
                                break;
                            case 12:
                                Tabela2();
                                break;
                            case 13:
                                Tabela3();
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nQual a alinea?");
                        al = Conversoes.ConverterStringParaInt(Console.ReadLine());
                        switch (al)
                        {
                            case 1:
                                TmpConv();
                                break;
                            case 2:
                                Limite();
                                break;
                            case 3:
                                JuntarVarios();
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nQual a alinea?");
                        al = Conversoes.ConverterStringParaInt(Console.ReadLine());
                        switch (al)
                        {
                            case 1:
                                Mult();
                                break;
                            case 2:
                                Trian();
                                break;
                        }
                        break;
                        }
            }
        }


        /// <summary>
        /// Ficha7 ex1.1 recebe uma nota e diz se passou ou chumbou
        /// </summary>
        private static void Nota()
        {
            decimal nota;

            Console.WriteLine("\nEscreva a nota");
            nota=Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            if (nota > Conversoes.ConverterStringParaDecimal("9,44"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Passou");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Chumbou");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /// <summary>
        /// Ficha7 ex1.2 Calcula o BMI e classifica-o
        /// </summary>
        private static void BMI()
        {
            decimal altura, peso, bmi;

            Console.WriteLine("\nQual a Altura?");
            altura = Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            Console.WriteLine("\nQual o Peso?");
            peso = Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            bmi = peso / (altura * altura);
            if (bmi < Conversoes.ConverterStringParaDecimal("18,5"))
                Console.WriteLine("Abaixo do peso: "+bmi);
            else if (bmi < Conversoes.ConverterStringParaDecimal("25"))
                Console.WriteLine("Normal: " + bmi);
            else if (bmi < Conversoes.ConverterStringParaDecimal("30"))
                Console.WriteLine("Acima do peso: " + bmi);
            else
                Console.WriteLine("Obeso: " + bmi);
        }

        /// <summary>
        /// Ficha7 ex1.3 Pede um número e valida se é múltiplo de 3 e / ou 7
        /// </summary>
        private static void Multi3ou7()
        {
            int n;

            Console.WriteLine("\nEscreva um numero");
            n = Conversoes.ConverterStringParaInt(Console.ReadLine());
            if (n%3==0||n%7==0)
                Console.WriteLine(n+ " é múltiplo de 3 e / ou 7");
            else
                Console.WriteLine(n + " não é múltiplo de 3 e / ou 7");
        }

        /// <summary>
        /// Ficha7 ex1.4 Pede um número e valida se está entre 30 e 50, inclusive
        /// </summary>
        private static void Verif1()
        {
            int n;

            Console.WriteLine("\nEscreva um numero");
            n = Conversoes.ConverterStringParaInt(Console.ReadLine());
            if (n <= 50 && n >= 30)
                Console.WriteLine(n + " está entre 30 e 50, inclusive");
            else
                Console.WriteLine(n + " não está entre 30 e 50, inclusive");
        }

        /// <summary>
        /// Ficha7 ex1.5 Pede um número e valida se está entre 10 e 20, exclusive
        /// </summary>
        private static void Verif2()
        {
            int n;

            Console.WriteLine("\nEscreva um numero");
            n = Conversoes.ConverterStringParaInt(Console.ReadLine());
            if (n < 20 && n > 10)
                Console.WriteLine(n + " está entre 10 e 20, inclusive");
            else
                Console.WriteLine(n + " não está entre 10 e 20, inclusive");
        }

        /// <summary>
        /// Ficha7 ex1.6 elevador piso -2 a 6, mas 3 e 5 estão avariados
        /// </summary>
        private static void Elevador()
        {
            int n;

            Console.WriteLine("\nQual o andar");
            n = Conversoes.ConverterStringParaInt(Console.ReadLine());
            if (n!=3&&n!=5&&n>-3&&n<7)
            {
                Console.WriteLine("Piso disponível");
            }
            else
            {
                Console.WriteLine("Piso indisponível");
            }
        }

        /// <summary>
        /// Ficha7 ex1.7 soma 10 numeros
        /// </summary>
        private static void Soma10()
        {
            int c = 0, soma = 0;
            
            //do ... while
/*
            do
            {
                soma += LerNumEConverter();
                c++;
            } while (c < 10);
            */

            //while

            while (c < 10)
            {
                soma += LerNumEConverter();
                c++;
            }


            //for
            /*
            for (int i = 0; i < 10; i++)
            {
                soma += LerNumEConverter();
            }
            */

            Console.WriteLine("Soma = " + soma);
        }

        private static int LerNumEConverter()
        {
            Console.WriteLine("\nEscreva um numero: ");
            return Conversoes.ConverterStringParaInt(Console.ReadLine());
        }

        /// <summary>
        /// Ficha7 ex 1.8 apresentar valor total de uma compra
        /// </summary>
        private static void Compra()
        {
            decimal total = 0;
            string compra="";

            Console.WriteLine("\nQuantos productos?");
            int c = Conversoes.ConverterStringParaInt(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                string item = ProdPreco();
                compra += item;
                String[] strlist = item.Split("é ", StringSplitOptions.None);
                total += Conversoes.ConverterStringParaDecimal(strlist[strlist.Length - 1]);
            }
            Console.WriteLine(compra);
            Console.WriteLine("Preço Total da compra: " + total);
        }

        private static string ProdPreco()
        {
            String Prod, s;
            decimal Preco = 0, TotalP = 0;
            int Qnt = 0;

            Console.WriteLine("\nQual o Producto?");
            Prod = Console.ReadLine();
            Console.WriteLine("Qual o Preço?");
            Preco = Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            Console.WriteLine("Qual a Quantidade?");
            Qnt = Conversoes.ConverterStringParaInt(Console.ReadLine());
            TotalP = Preco * Qnt;
            s="\nPreço Total de " + Prod + " é " + TotalP;
            return s;
        }

        /// <summary>
        /// Ficha7 ex 1.9 Solicitar números até que seja inserido 0, e apresentar a média
        /// </summary>
        private static void Media()
        {
            int c;
            double media, val, soma;

            c = 0;
            soma = 0;

            while (true)
            {
                val = LerNumEConverter();
                if (val == 0)
                    break;
                soma += val;
                c++;
            }
            media = soma / c;
            Console.WriteLine("\nMédia = " + media);
        }

        /// <summary>
        /// Ficha7 ex 1.10 Solicitar dois números e uma operação. Apresentar o resultado da operação com base nos números inseridos
        /// </summary>
        private static void Operacao()
        {
            string op;

            while (7 != 23)
            {
                decimal n1 = LerNumEConverter();
                decimal n2 = LerNumEConverter();
                Console.WriteLine("Qual a operação?");
                op = Console.ReadLine();

                switch (op)
                {
                    case "0":
                        return;
                    case "+":
                        Console.WriteLine(n1+op+n2+"="+(n1+n2));
                        break;
                    case "-":
                        Console.WriteLine(n1 + op + n2 + "=" + (n1 - n2));
                        break;
                    case "*":
                        Console.WriteLine(n1 + op + n2 + "=" + (n1 * n2));
                        break;
                    case "/":
                        Console.WriteLine(n1 + op + n2 + "=" + (n1 / n2));
                        break;
                    case "%":
                        Console.WriteLine(n1 + op + n2 + "=" + (n1 % n2));
                        break;
                }
            }
        }

        /// <summary>
        /// Ficha7 ex 1.11 pede uma letra e escreve uma tabela 3x3 dessa letra
        /// </summary>
        private static void Tabela()
        {
            Console.WriteLine("\nEscreve uma letra");
            char l = Console.ReadLine()[0];
            Console.WriteLine(tabelaSTR(l, 3, 3));
        }

        private static string tabelaSTR(char l, int n, int m, char ll='0')
        {
            string str="";
            if (ll == '0')
                ll = l;

            for (int i = 0; i < m; i++)
            {
                str += '\n';
                for (int j = 0; j < n; j++)
                {
                    if (Convert.ToBoolean(j % 2))
                        str += l;
                    else
                        str += ll;
                }
            }
            return str;
        }

        /// <summary>
        /// Ficha7 ex 1.12 pede uma letra e escreve uma tabela nxm dessa letra
        /// </summary>
        private static void Tabela2()
        {
            Console.WriteLine("\nEscreve uma letra");
            char l = Console.ReadLine()[0];
            int n1 = LerNumEConverter();
            int n2 = LerNumEConverter();
            Console.WriteLine(tabelaSTR(l, n1, n2));
        }

        /// <summary>
        /// Ficha7 ex 1.13 pede duas letras e escreve uma tabela nxm dessa letra
        /// </summary>
        private static void Tabela3()
        {
            Console.WriteLine("\nEscreve uma letra");
            char l = Console.ReadLine()[0];
            Console.WriteLine("\nEscreve uma letra");
            char ll = Console.ReadLine()[0];
            int n1 = LerNumEConverter();
            int n2 = LerNumEConverter();
            Console.WriteLine(tabelaSTR(l, n1, n2, ll));
        }

        /// <summary>
        /// Ficha7 ex 2.1 Converte a Temperatura de e para ºC, K e ºF
        /// </summary>
        private static void TmpConv()
        {
            decimal Temp, TempC, TempK, TempF;
            char escala='l';

            Console.WriteLine("\nIntroduz a temperatura");
            Temp = Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            while (escala != 'C' && escala != 'K' && escala != 'F')
            {
                Console.WriteLine("Em que escala? (C, K ou F)");
                escala = Console.ReadLine()[0];
            }
            switch (escala)
            {
                case 'C':
                    TempK = Temp + Conversoes.ConverterStringParaDecimal("273,15");
                    TempK = Math.Round(TempK, 2);
                    TempF = Temp * 9 / 5 + 32;
                    TempF = Math.Round(TempF, 2);
                    Console.WriteLine($"{Temp}ºC é equivalente a {TempK}K e {TempF}ºF");
                    break;
                case 'K':
                    TempC = Temp - Conversoes.ConverterStringParaDecimal("273,15");
                    TempC = Math.Round(TempC, 2);
                    TempF = Temp * 9 / 5 - Conversoes.ConverterStringParaDecimal("359,67");
                    TempF = Math.Round(TempF, 2);
                    Console.WriteLine($"{Temp}K é equivalente a {TempC}ºC e {TempF}ºF");
                    break;
                case 'F':
                    TempC = (Temp - 32) *5 / 9;
                    TempC = Math.Round(TempC, 2);
                    TempK = (Temp + Conversoes.ConverterStringParaDecimal("459,67")) *5 / 9;
                    TempK = Math.Round(TempK, 2);
                    Console.WriteLine($"{Temp}ºF é equivalente a {TempC}ºC e {TempK}K");
                    break;
            }
        }

        /// <summary>
        /// Ficha7 ex 2.2 Escrever numeros impares até ao limeite escolhido
        /// </summary>
        private static void Limite()
        {
            int lim = LerNumEConverter();
            for (int cont = 0; cont < lim; cont++)
            {
                if (cont % 2 == 1)
                {
                    Console.WriteLine(cont);
                }
            }
        }

        /// <summary>
        /// Ficha7 ex 2.3 Junta numeros até ser persionado enter
        /// </summary>
        private static void JuntarVarios()
        {
            string caracteres="", caracter="";
            do
            {
                Console.WriteLine("\nIntroduz um número, ou enter para terminar");
                caracter=Console.ReadLine();
                caracteres = caracter + caracteres;

            } while (caracter!="");
            Console.WriteLine(caracteres);
        }

        /// <summary>
        /// Ficha7 ex 3.1 multiplica por 3 se for par e por 2 se não
        /// </summary>
        private static void Mult()
        {
            int n = LerNumEConverter();
            if (n%2==0)
            {
                Console.WriteLine(n * 3);
            }
            else
            {
                Console.WriteLine(n * 2);
            }
        }
        
        /// <summary>
        /// Ficha7 ex 3.2 Faz um triangulo com o tamanho escolhido
        /// </summary>
        private static void Trian()
        {
            Console.WriteLine("\nQual é a dimensão do triangulo ? ");
            int n = Conversoes.ConverterStringParaInt(Console.ReadLine());
            int i = 1;
            while (n > 0) //O fluxograma tem n>=0 o que causa um loop infinito
            {
                n--;
                int a = 0;
                while (a != n)
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
                i += 2;
                Console.Write("\n");
            }
        }
    }
}
