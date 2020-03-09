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
                                break;/*
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
                                break;*/
                        }
                        break;
                    /*case 2:
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
            decimal Altura, Peso, Bmi;

            Console.WriteLine("\nQual a Altura?");
            Altura = Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            Console.WriteLine("\nQual o Peso?");
            Peso = Conversoes.ConverterStringParaDecimal(Console.ReadLine());
            Bmi = Peso / (Altura * Altura);
            if (Bmi < Conversoes.ConverterStringParaDecimal("18,5"))
                Console.WriteLine("Abaixo do peso: "+Bmi);
            else if (Bmi < Conversoes.ConverterStringParaDecimal("25"))
                Console.WriteLine("Normal: " + Bmi);
            else if (Bmi < Conversoes.ConverterStringParaDecimal("30"))
                Console.WriteLine("Acima do peso: " + Bmi);
            else
                Console.WriteLine("Obeso: " + Bmi);
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

        }
    }
}
