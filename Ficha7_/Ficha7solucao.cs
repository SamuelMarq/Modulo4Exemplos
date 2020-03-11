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
                                break;/*
                            case 2:
                                DoisNs();
                                break;
                            case 3:
                                TmpConv();
                                break;*/
                        }
                        break;/*
                    case 3:
                        Horas();
                        break;*/
                        }
            }
        }


        /// <summary>
        /// Ficha7 ex1.1 recebe uma nota e dz se passou ou chumbou
        /// </summary>
        private static void Nota()
        {
            decimal nota;

            Console.WriteLine("\nEscreva a nota");
            nota=Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            if (nota > Conversoes.ConverterStringParaDecimal("9,44"))
                Console.WriteLine("Passou");
            else
                Console.WriteLine("Chumbou");
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
                    TempF = Temp * 9 / 5 + 32;
                    Console.WriteLine($"{Temp}ºC é equivalente a {TempK}K e {TempF}ºF");
                    break;
                case 'K':
                    TempC = Temp - Conversoes.ConverterStringParaDecimal("273,15");
                    TempF = Temp * 9 / 5 - Conversoes.ConverterStringParaDecimal("359,67");
                    Console.WriteLine($"{Temp}K é equivalente a {TempC}ºC e {TempF}ºF");
                    break;
                case 'F':
                    TempC = (Temp - 32) *5 / 9;
                    TempK = (Temp + Conversoes.ConverterStringParaDecimal("459,67")) *5 / 9;
                    Console.WriteLine($"{Temp}ºF é equivalente a {TempC}ºC e {TempK}K");
                    break;
            }
        }
    }
}
