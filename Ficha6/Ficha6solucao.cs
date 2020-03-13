using System;
using Common;

namespace Ficha6
{
    public class Ficha6solucao
    {
        /// <summary>
        /// Ficha6 ex1.1
        /// lê um nome e escreve olá nome
        /// </summary>
        private static void OlaNome()
        {
            Console.WriteLine("Escreve o teu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("\nOlá " + nome);
        }

        /// <summary>
        /// Ficha6 ex1.2
        /// soma 2 numeros
        /// </summary>
        private static void Soma1()
        {
            Console.WriteLine("Escreva um numero: ");
            var n1 = Console.ReadLine();
            Console.WriteLine("Escreva um numero: ");
            var n2 = Console.ReadLine();
            Console.WriteLine(n1 + "+" + n2 + "=" + (Conversoes.ConverterStringParaInt(n1) + Conversoes.ConverterStringParaInt(n2)));
        }

        /// <summary>
        /// Ficha6 ex1.3 soma 10 numeros
        /// </summary>

        private static void Soma2()
        {   
            int soma = 0;
            /* for (int i = 0; i < 10; i++)
             {
                 soma += LerNumEConverter();
             }*/
            soma += LerNumEConverter();
            soma += LerNumEConverter();
            soma += LerNumEConverter();
            soma += LerNumEConverter();
            soma += LerNumEConverter();
            soma += LerNumEConverter();
            soma += LerNumEConverter();
            soma += LerNumEConverter();
            soma += LerNumEConverter();
            soma += LerNumEConverter();
            Console.WriteLine("Resultado: " + Convert.ToString(soma));
        }

        /// <summary>
        /// Usado para ler uma linha, converte-la para um numero e devolver esse numero
        /// </summary>
        /// <returns></returns>
        private static int LerNumEConverter()
        {
            Console.WriteLine("Escreva um numero: ");
            return Conversoes.ConverterStringParaInt(Console.ReadLine());
        }

        /// <summary>
        /// Ficha6 ex1.4 trac dois numeros
        /// </summary>
        private static void Troca()
        {
            Console.WriteLine("Escreva um numero A: ");
            int A = Conversoes.ConverterStringParaInt(Console.ReadLine());
            Console.WriteLine("Escreva um numero B: ");
            int B = Conversoes.ConverterStringParaInt(Console.ReadLine());
            int C = A;
            A = B;
            B = C;
            Console.WriteLine("A=" + A + " e B=" + B);
        }

        /// <summary>
        /// Ficha6 ex1.5 uma opcao para cada alinea; cada alinea tem uma operação associada
        /// </summary>
        private static void Operacoes(string opc="")
        {
            if (opc=="")
            {
                Console.WriteLine("Escolha a alinea: ");
                opc = Console.ReadLine();
                switch (opc)
                {
                    case "a":
                        Operacoes("a");
                        break;
                    case "b":
                        Operacoes("b");
                        break;
                    case "c":
                        Operacoes("c");
                        break;
                    case "d":
                        Operacoes("d");
                        break;
                    default:
                        return;
                }
            }
            else
            {
                switch (opc)
                {
                    case "a":
                        int n1 = LerNumEConverter();
                        int n2 = LerNumEConverter();
                        int n3 = LerNumEConverter();
                        double calc = n1 + n2 * n3;
                        Console.WriteLine("Resultado: "+calc);
                        break;
                    case "b":
                        n1 = LerNumEConverter();
                        n2 = LerNumEConverter();
                        n3 = LerNumEConverter();
                        calc = (n1 + n2) % n3;
                        Console.WriteLine("Resultado: " + calc);
                        break;
                    case "c":
                        n1 = LerNumEConverter();
                        n2 = LerNumEConverter();
                        n3 = LerNumEConverter();
                        int n4 = LerNumEConverter();
                        calc = n1 + n2 * n3 / n4;
                        Console.WriteLine("Resultado: " + calc);
                        break;
                    case "d":
                        n1 = LerNumEConverter();
                        n2 = LerNumEConverter();
                        n3 = LerNumEConverter();
                        n4 = LerNumEConverter();
                        int n5 = LerNumEConverter();
                        int n6 = LerNumEConverter();
                        calc = n1 + n2 / n3 * n4 - n5 % n6;
                        Console.WriteLine("Resultado: " + calc);
                        break;
                }
            }
        }

        /// <summary>
        /// Ficha6 ex1.6 dá a tabuada até ao 10 de um numero
        /// </summary>
        private static void Tabuada()
        {
            Console.WriteLine("Escreve um numero");
            int n = Conversoes.ConverterStringParaInt(Console.ReadLine());
            Console.WriteLine("1 x " + n + " = " + (n * 1));
            Console.WriteLine("2 x " + n + " = " + (n * 2));
            Console.WriteLine("3 x " + n + " = " + (n * 3));
            Console.WriteLine("4 x " + n + " = " + (n * 4));
            Console.WriteLine("5 x " + n + " = " + (n * 5));
            Console.WriteLine("6 x " + n + " = " + (n * 6));
            Console.WriteLine("7 x " + n + " = " + (n * 7));
            Console.WriteLine("8 x " + n + " = " + (n * 8));
            Console.WriteLine("9 x " + n + " = " + (n * 9));
            Console.WriteLine("10 x " + n + " = " + (n * 10));
        }

        /// <summary>
        /// Ficha6 ex 1.7 dá a media de 2nº
        /// </summary>
        private static void Media()
        {
            double n1, n2;
            
            n1 = LerNumEConverter();
            n2 = LerNumEConverter();
            Console.WriteLine("\nMédia = "+((n1+n2)/2));
        }

        /// <summary>
        /// Ficha6 ex 1.8 e 1.9 dá a media de vários nº
        /// </summary>
        /// <param name="nm"></param>
        private static void Media2(int nm)
        {
            int c;
            double media, soma;

            c = 0;
            soma = 0;
            
            while (c<nm)
            {
                soma += LerNumEConverter();
                c++;
            }

            if (nm < 1){
                media = nm;
            } else
            {
                media = soma / nm;
            }

            Console.WriteLine("\nMédia = " +media);
        }

        /// <summary>
        /// Ficha6 ex 1.10 pede uma letra e escreve uma tabela 3x3 dessa letra
        /// </summary>
        private static void Tabela()
        {
            Char C;

            Console.WriteLine("Escreve uma letra");
            C = Convert.ToChar(Console.ReadLine()[0]); //converte o primeiro caracter inserido para char
            Console.WriteLine(C + " " + C + " " + C + "\n" + C + " " + C + " " + C + "\n" + C + " " + C + " " + C);
        }

        /// <summary>
        /// Ficha6 ex 1.11 apresentar valor total de uma compra
        /// </summary>
        private static void Compra()
        {
            decimal Total=0;
            Total += ProdPreco();
            Total += ProdPreco();
            Total += ProdPreco();
            Total += ProdPreco();
            Total += ProdPreco();
            Console.WriteLine("Preço Total da compra: " + Total);
        }

        /// <summary>
        /// devolve o preço de um producto
        /// </summary>
        private static decimal ProdPreco()
        {
            String Prod = "";
            decimal Preco = 0, TotalP = 0;
            int Qnt = 0;

            Console.WriteLine("\nQual o Producto?");
            Prod = Console.ReadLine();
            Console.WriteLine($"Qual o Preço de {Prod}?");
            Preco = Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            Console.WriteLine($"Qual a Quantidade de {Prod}?");
            Qnt = Conversoes.ConverterStringParaInt(Console.ReadLine());
            TotalP = Preco * Qnt;
            Console.WriteLine($"\nPreço Total de {Prod} é {TotalP}");
            return TotalP;
        }


        /// <summary>
        /// Ficha6 ex 2.1
        /// </summary>
        private static void Diz()
        {
            Console.WriteLine("Diz me algo que eu não saiba");
            Console.WriteLine("Eu já sabia que "+Console.ReadLine());
        }

        /// <summary>
        /// Ficha6 ex 2.2
        /// </summary>
        private static void DoisNs()
        {
            int n1, n2;

            n1 = LerNumEConverter();
            n2 = LerNumEConverter();

            Console.WriteLine("O 1º número é "+n1+ " e o 2º número é " + n2);
        }

        /// <summary>
        /// Ficha6 ex 2.3 Converte a Temperatura de ºC para ºK e ºF
        /// </summary>
        private static void TmpConv()
        {
            decimal Temp, TempK, TempF;
            
            Console.WriteLine("Introduz a temperatura");
            Temp = Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            TempF = Temp * 9 / 5 + 32;
            TempK = Conversoes.ConverterStringParaDecimal("273,15");
            TempK += Temp;

            Console.WriteLine("“A temperatura "+ Temp +"ºC é "+TempF+"ºF e "+TempK+"ºK");
        }

        /// <summary>
        /// Ficha6 ex 3.1
        /// </summary>
        private static void Horas()
        {
            int horas, minutos, segundos, Total;

            Console.WriteLine("Quantas Horas?");
            horas = Conversoes.ConverterStringParaInt(Console.ReadLine());
            Console.WriteLine("Quantas Minutos?");
            minutos = Conversoes.ConverterStringParaInt(Console.ReadLine());
            Console.WriteLine("Quantas Segundos?");
            segundos = Conversoes.ConverterStringParaInt(Console.ReadLine());
            Total = horas * 3600 + minutos * 60 + segundos;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos + " é equivalente a " + Total + " segundos");
        }

        /// <summary>
        /// Ficha 6 ex 3.2 Calcula a area e perimetro de um circulo
        /// </summary>
        private static void Area()
        {
            decimal raio, perim, area;

            Console.WriteLine("\nQual é o raio?");
            raio=Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            perim = 2 * Conversoes.ConverterStringParaDecimal("3,14") * raio;
            area = Conversoes.ConverterStringParaDecimal("3,14") * raio * raio;
            Console.WriteLine("A área do circulo é "+area+" e o perimetro é "+perim);
        }

        /// <summary>
        /// Corre todos os exercicios da ficha 6
        /// </summary>
        public static void Ficha6()
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
                                OlaNome();
                                break;
                            case 2:
                                Soma1();
                                break;
                            case 3:
                                Soma2();
                                break;
                            case 4:
                                Troca();
                                break;
                            case 5:
                                Operacoes();
                                break;
                            case 6:
                                Tabuada();
                                break;
                            case 7:
                                Media();
                                break;
                            case 8:
                                Media2(5);
                                break;
                            case 9:
                                Media2(10);
                                break;
                            case 10:
                                Tabela();
                                break;
                            case 11:
                                Compra();
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nQual a alinea?");
                        al = Conversoes.ConverterStringParaInt(Console.ReadLine());
                        switch (al)
                        {
                            case 1:
                                Diz();
                                break;
                            case 2:
                                DoisNs();
                                break;
                            case 3:
                                TmpConv();
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nQual a alinea?");
                        al = Conversoes.ConverterStringParaInt(Console.ReadLine());
                        if (al == 1)
                            Horas();
                        else
                            Area();
                        break;
                }
            }
        }
    }
}
