using System;
using System.Collections.Generic;
using Common;

namespace Ficha16
{
    public class Ficha16solucao
    {
        /// <summary>
        /// Corre todos os exercicios da ficha 16
        /// </summary>
        public static void Ficha16()
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
                        Listar();
                        break;
                    case 2:
                        Listar(true);
                        break;
                    case 3:
                        Ex3();
                        break;
                    case 4:
                        Ex4();
                        break;
                    case 5:
                        Ex5();
                        break;
                    case 6:
                        Ex6();
                        break;
                    case 7:
                        Ex7();
                        break;
                    case 8:
                        Console.WriteLine("ver função Existe"); ;
                        break;
                }
            }
        }

        /// <summary>
        /// ex1 e ex2 Solicitar dez valores e armazená-los numa lista depois lista todos os elementos
        /// </summary>
        public static void Listar(bool reverse=false, int n = 10)
        {
            List<int> l = InputRequest.GetIntList(10);
            string s="";
            if (!reverse)
            {
                foreach (var item in l)
                {
                    s += ($"{item}; ");
                }
            }
            else
            {
                for (int i = ContarLista(l) - 1; i >= 0; i--)
                {
                    s += ($"{l[i]}; ");
                }
            }
            Console.WriteLine(s);
        }

        /// <summary>
        /// ex3 soma 10 numeros
        /// </summary>
        private static void Ex3()
        {
            var l = InputRequest.GetIntList(10);
            Console.WriteLine($"Soma: {SomaLista(l)}");
        }

        /// <summary>
        /// Apresenta a soma de todos os números de uma lista
        /// </summary>
        public static double SomaLista(List<int> l)
        {
            double s = 0;
            foreach (var item in l)
            {
                s += Convert.ToDouble(item);
            }
            return s;
        }

        /// <summary>
        /// takes a list and returns nº of elements = to .Count
        /// </summary>
        public static int ContarLista(List<int> l)
        {
            int c = 0;
            foreach (var item in l)
            {
                c++;
            }
            return c;
        }

        /// <summary>
        /// ex4 Criar um algoritmo que apresente a contagem de todos os elementos repetidos numa lista
        /// </summary>
        private static void Ex4()
        {
            var l = InputRequest.GetIntList();
            Console.WriteLine("\nValores do Array repetidos:");
            Console.WriteLine(Repeated(l));
        }

        private static string Repeated(List<int> l)
        {
            string s = "";
            int n = l.Count;
            List<int> elements = new List<int>();
            int[] amount = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (elements.Contains(l[i]))
                {
                    amount[elements.IndexOf(l[i])]++;
                }
                else
                {
                    elements.Add(l[i]);
                    amount[elements.IndexOf(l[i])]++;
                }
            }

            foreach (var item in elements)
            {
                var am = amount[elements.IndexOf(item)];
                if (am > 1)
                {
                    s += ($"{item}: {am}\n");
                }
            }
            return s;
        }

        /// <summary>
        /// ex5 Criar um algoritmo que apresente todos os elementos únicos numa lista.
        /// </summary>
        private static void Ex5()
        {
            var l = InputRequest.GetIntList();
            Console.WriteLine("\nValores do Array repetidos:");
            Console.WriteLine(Unique(l));
        }

        private static string Unique(List<int> l)
        {
            string s = "";
            int n = l.Count;
            var elements = new List<int>();
            int[] amount = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (elements.Contains(l[i]))
                {
                    amount[elements.IndexOf(l[i])]++;
                }
                else
                {
                    elements.Add(l[i]);
                    amount[elements.IndexOf(l[i])]++;
                }
            }

            foreach (var item in elements)
            {
                var am = amount[elements.IndexOf(item)];
                if (am == 1)
                {
                    s += ($"{item}: {am}\n");
                }
            }
                return s;
        }

        /// <summary>
        /// ex6 Criar um algoritmo para encontrar o menor e o maior valor numa lista.
        /// </summary>
        static void Ex6()
        {
            var l = InputRequest.GetDoubleList();
            Console.WriteLine($"Minimo: {MinMax(l, true)}\nMáximo: {MinMax(l, false)}");
        }

        /// <summary>
        /// Devolve o valor Maximo ou Minimo de uma lista
        /// </summary>
        public static Double MinMax(List<double> l, bool Min)
        {
            double val = l[0];
            foreach (var item in l)
            {
                if (Min)
                    val = (item < val) ? item : val;
                else
                    val = (item > val) ? item : val;
            }
            return val;
        }

        /// <summary>
        /// ex7 separar os números ímpares dos pares numa lista
        /// </summary>
        static void Ex7()
        {
            var l = InputRequest.GetIntList();
            Console.WriteLine($"\nPares: {Even(l)}");
            Console.WriteLine($"Ímpares: {Odd(l)}");
        }

        /// <summary>
        /// gets a List<int> and returns a string with the Even numbers of the array
        /// </summary>
        public static string Even(List<int> l)
        {
            string s = "";
            foreach (var item in l)
            {
                if (item % 2 == 0)
                    s += $"{item}; ";
            }
            return s;
        }

        /// <summary>
        /// gets a List<int> and returns a string with the Odd numbers of the array
        /// </summary>
        public static string Odd(List<int> l)
        {
            string s = "";
            foreach (var item in l)
            {
                if (item % 2 != 0)
                    s += $"{item}; ";
            }
            return s;
        }

        /// <summary>
        /// Ex9 Criar um algoritmo que verifique se um elemento se encontra num lista.
        /// </summary>
        public static bool Existe(List<string> l, string s)
        {
            foreach (var item in l)
            {
                if (item == s)
                    return true;
            }
            return false;
        }
    }
}
