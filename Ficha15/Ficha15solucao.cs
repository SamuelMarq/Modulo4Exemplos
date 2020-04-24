using System;
using System.Linq;
using Recodme.Formacao.Modulo4Fichas.Common;

namespace Recodme.Formacao.Modulo4Fichas.Fichas.Exercicios
{
    public class Ficha15solucao
    {
        /// <summary>
        /// Corre todos os exercicios da ficha 15
        /// </summary>
        public static void Ficha15()
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
                        Array1();
                        break;
                    case 2:
                        ArrayR();
                        break;
                    case 3:
                        Ex3();
                        break;
                    case 4:
                        Console.WriteLine("ver função Contar");
                        break;
                    case 5:
                        Repetidos();
                        break;
                    case 6:
                        Unicos();
                        break;
                    case 7:
                        MaiorMenor();
                        break;
                    case 8:
                        ParImpar();
                        break;
                    case 9:
                        Console.WriteLine("ver função Existe");
                        break;
                }
            }
        }

        /// <summary>
        /// ex1 Solicitar dez valores e armazená-los num array depois apresentar os vectores para cada índice do array.
        /// </summary>
        private static void Array1()
        {
            int[] a = InputRequest.GetIntArray(10);
            Console.WriteLine($"\n{IntArrayParaString(a)}");
        }

        /// <summary>
        /// ex2 Solicitar dez valores e armazená-los num array depois apresentar os vectores para cada índice do array por ordem inversa.
        /// </summary>
        private static void ArrayR()
        {
            int[] a = InputRequest.GetIntArray(10);
            Console.WriteLine($"\n{IntArrayParaString(a,true)}");
        }

        /// <summary>
        /// Recebe um int[] e devolve uma string com os vários elementos
        /// </summary>
        public static string IntArrayParaString(int[] a, bool reverse=false)
        {
            string s="";

            if (!reverse)
            {
                foreach (var item in a)
                {
                    s+=($"{item}; ");
                }
            }
            else
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    s+=($"{a.GetValue(i)}; ");
                }
            }
            return s;
        }

        /// <summary>
        /// ex3 Solicitar dez números e armazená-los num array. Apresentar a soma de todos os números.
        /// </summary>...4
        private static void Ex3()
        {
            int[] a = InputRequest.GetIntArray(10);
            Console.WriteLine("Soma = " + SomaIntArray(a));
        }

        /// <summary>
        /// Apresenta a soma de todos os números de um array
        /// </summary>
        public static int SomaIntArray(int[] a)
        {
            int s = 0;
            foreach (var item in a)
            {
                s += item;
            }
            return s;
        }

        /// <summary>
        /// ex4 Criar um algoritmo que permita contar os elementos de um vetor
        /// </summary>
        public static int Contar(Array a)
        {
            int l = 0;
            foreach (var item in a)
            {
                l++;
            }
            return l;
        }

        /// <summary>
        /// ex5 Criar um algoritmo que apresente a contagem de todos os elementos repetidos num vetor
        /// </summary>
        private static void Repetidos()
        {
            string[] a = InputRequest.GetStrArray();
            Console.WriteLine("\nValores do Array repetidos:");
            Console.WriteLine(RepeatedElements(a));
        }

        /// <summary>
        /// gets a string[] and returns a string with the count of repeated elements
        /// </summary>
        public static string RepeatedElements(string[] a)
        {
            string s = "";
            int n = Contar(a);
            string[] elements = new string[n];
            int[] amount = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (elements.Contains(a[i]))
                {
                    amount[Array.IndexOf(elements, a[i])]++;
                }
                else
                {
                    elements[i] = a[i];
                    amount[i]++;
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                var item = elements[i];
                var am = amount[i];
                if (item != string.Empty && am > 1)
                {
                    s+=($"{item}: {am}\n");
                }
            }
            return s;
        }

        /// <summary>
        /// ex6 Criar um algoritmo que apresente todos os elementos únicos num vetor
        /// </summary>
        private static void Unicos()
        {
            string[] a = InputRequest.GetStrArray();
            Console.WriteLine("\nValores Únicos do Array:");
            Console.WriteLine(UniqueElements(a));
        }

        /// <summary>
        /// gets a string[] and returns a string with the unique elements
        /// </summary>
        public static string UniqueElements(string[] a)
        {
            string s="";
            int n = Contar(a);
            string[] elements = new string[n];
            int[] amount = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (elements.Contains(a[i]))
                {
                    amount[Array.IndexOf(elements, a[i])]++;
                }
                else
                {
                    elements[i] = a[i];
                    amount[i]++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                var item = elements[i];
                var am = amount[i];
                if (item != string.Empty && am == 1)
                {
                    Console.Write($"{item}; ");
                }
            }
            return s;
        }

        
        /// <summary>
        /// ex7  encontrar o menor e o maior valor num array numérico
        /// </summary>
        private static void MaiorMenor()
        {
            double[] a = InputRequest.GetDoubleArray();
            var sma_big = MaiorMenor(a);
            Console.WriteLine($"Menor Valor: {sma_big[0]}; Maior Valor: {sma_big[1]}");
        }

        /// <summary>
        /// recebe um double[] e devolve um double[2] em que [0] é o valor mais pequeno e [1] o maior
        /// </summary>
        public static double[] MaiorMenor(double[] a)
        {
            double smaller = a[0], bigger = a[0];
            foreach (var item in a)
            {
                if (item > bigger)
                    bigger = item;
                else if (item < smaller)
                    smaller = item;
            }
            var res = new double[2] { smaller, bigger };
            return res;
        }

        /// <summary>
        /// ex8 separar os números ímpares dos pares num array numérico
        /// </summary>
        private static void ParImpar()
        {
            int[] a = InputRequest.GetIntArray();
            Console.WriteLine($"\nPares: {Even(a)}");
            Console.WriteLine($"Ímpares: {Odd(a)}");
        }

        /// <summary>
        /// gets an int[] and returns a string with the Even numbers of the array
        /// </summary>
        public static string Even(int[] a)
        {
            string s = "";
            foreach (var item in a)
            {
                if (item % 2 == 0)
                    s += $"{item}; ";
            }
            return s;
        }

        /// <summary>
        /// gets an int[] and returns a string with the Odd numbers of the array
        /// </summary>
        public static string Odd(int[] a)
        {
            string s = "";
            foreach (var item in a)
            {
                if (item % 2 != 0)
                    s += $"{item}; ";
            }
            return s;
        }

        /// <summary>
        /// Ex9 Criar um algoritmo que verifique se um elemento se encontra num array.
        /// </summary>
        public static bool Existe(string[] a, string s)
        {
            foreach (var item in a)
            {
                if (item == s) 
                    return true;
            }
            return false;
        }
    }
}
