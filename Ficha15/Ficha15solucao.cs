using System;
using System.Linq;
using Common;

namespace Ficha15
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
                        Soma();
                        break;
                    case 4:
                        Ex4();
                        break;
                    case 5:
                        Console.WriteLine("ver função Contar");
                        break;
                    case 6:
                        Repetidos();
                        break;
                    case 7:
                        Unicos();
                        break;
                    case 8:
                        Organizar();
                        break;
                    case 9:
                        Merge();
                        break;
                    case 10:
                        MaiorMenor();
                        break;
                    case 11:
                        ParImpar();
                        break;
                    case 12:
                        ex12();
                        break;
                    /*case 13:
                        ();
                        break;*/
                }
            }
        }

        /// <summary>
        /// ex1 Solicitar dez valores e armazená-los num array depois apresentar os vectores para cada índice do array.
        /// </summary>
        private static void Array1()
        {
            Array a = InputRequest.GetIntArray(10);
            Console.WriteLine();
            foreach (var item in a)
            {
                Console.Write($"{item}; ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// ex2 Solicitar dez valores e armazená-los num array depois apresentar os vectores para cada índice do array por ordem inversa.
        /// </summary>
        private static void ArrayR()
        {
            Array a = InputRequest.GetIntArray(10);
            Console.WriteLine();
            for (int i = a.Length-1; i >= 0; i--)
            {
                Console.Write($"{a.GetValue(i)}; ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// ex3  Apresentar a soma de todos os números de um array
        /// </summary>...4
        private static void Soma()
        {
            int[] a = InputRequest.GetIntArray(10);
            int s = 0;
            foreach (var item in a)
            {
                s += item;
            }
            Console.WriteLine("Soma = "+s);
        }

        /// <summary>
        /// ex4  Criar um array com dez posições, preenchê-lo e passar todo o conteúdo desse array para outro com doze posições
        /// </summary>...4
        private static void Ex4()
        {
            int[] a = InputRequest.GetIntArray(10);
            int[] b = new int[12];
            for (int i = 0; i < a.Length; i++)
            {
                b[i]= a[i];
            }
            foreach (var item in b)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// ex5 Criar um algoritmo que permita contar os elementos de um vetor
        /// </summary>
        private static int Contar(Array a)
        {
            int l = 0;
            foreach (var item in a)
            {
                l++;
            }
            return l;
        }

        /// <summary>
        /// ex6 Criar um algoritmo que apresente a contagem de todos os elementos repetidos num vetor
        /// </summary>
        private static void Repetidos()
        {
            string[] a = InputRequest.GetStrArray();
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
            Console.WriteLine("\nValores do Array repetidos:");
            for (int i = 0; i < n; i++)
            {
                var item = elements[i];
                var am = amount[i];
                if (item!=string.Empty&&am>1)
                {
                    Console.Write($"{item}: {am}\n");
                }
            }
        }

        /// <summary>
        /// ex7 Criar um algoritmo que apresente todos os elementos únicos num vetor
        /// </summary>
        private static void Unicos()
        {
            string[] a = InputRequest.GetStrArray();
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
            Console.WriteLine("\nValores Únicos do Array:");
            for (int i = 0; i < n; i++)
            {
                var item = elements[i];
                var am = amount[i];
                if (item!=string.Empty&&am==1)
                {
                    Console.Write($"{item}; ");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// ex8 Criar um algoritmo que organize os elementos de um array (ordena os elementos por ordem alfabética)
        /// </summary>
        private static void Organizar()
        {
            string[] a = InputRequest.GetStrArray();
            int c = Contar(a);
            int [][] v = new int[c][];
            for (int i = 0; i < c; i++)
            {
                int c_ai = a[i].Length;
                v[i] = new int[c_ai];
                for (int ii = 0; ii < c_ai; ii++)
                {
                    // a[i][ii] is the char in position ii on the string a[i]
                    // v[i][ii] is an int; a[i][ii] is a char, all chars have an int value and can be implicitly converted to int
                    v[i][ii] = a[i][ii];
                }
            }
            Array tempA;
            string temp = "";
            while (c>0)
            {
                c--;
                for (int i = 0; i < c; i++)
                {
                    if (a[i] == a[i + 1])
                        continue;
                    if (a[i].Length < a[i + 1].Length)
                        if (a[i] == a[i + 1].Substring(0, a[i].Length))
                            continue;
                    if (a[i].Length > a[i + 1].Length)
                        if (a[i].Substring(0, a[i + 1].Length) == a[i + 1])
                        {
                            temp = a[i];
                            tempA = v[i];
                            a[i] = a[i + 1];
                            v[i] = v[i + 1];
                            a[i + 1] = temp;
                            v[i + 1] = tempA.Cast<int>().ToArray();
                            continue;
                        }
                                
                    int v1 = 0, v2 = 0, ii = 0;
                    while (v1 == v2)
                    {
                        v1 = v[i][ii];
                        v2 = v[i+1][ii];
                        ii++;
                    }
                    if (v1 > v2)
                    {
                        temp = a[i];
                        tempA = v[i];
                        a[i] = a[i + 1];
                        v[i] = v[i + 1];
                        a[i + 1] = temp;
                        v[i + 1] = tempA.Cast<int>().ToArray();
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", a));
        }

        /// <summary>
        /// ex9 Faz o merge de dois int arrays
        /// </summary>
        private static void Merge()
        {
            int[] a = InputRequest.GetIntArray();
            int[] b = InputRequest.GetIntArray();
            int totalL = Contar(a) + Contar(b);
            int[] merged = new int[totalL];
            int c = 0, ca=0, cb=0;
            while (c<totalL)
            {
                if (ca>=a.Length)
                {
                    while (cb<b.Length)
                    {
                        merged[c] = b[cb];
                        cb++;
                        c++;
                    }
                }
                else if (cb >= b.Length)
                {
                    while (ca < a.Length)
                    {
                        merged[c] = a[ca];
                        ca++;
                        c++;
                    }
                }
                else if (a[ca] <= b[cb])
                {
                    merged[c] = a[ca];
                    ca++;
                }
                else
                {
                    merged[c] = b[cb];
                    cb++;
                }
                c++;
            }
            Console.WriteLine("[{0}]", string.Join(", ", merged));
        }

        /// <summary>
        /// ex10  encontrar o menor e o maior valor num array numérico
        /// </summary>
        private static void MaiorMenor()
        {
            double[] a = InputRequest.GetDoubleArray();
            double bigger=a[0], smaller=a[0];
            foreach (var item in a)
            {
                if (item > bigger)
                    bigger = item;
                else if (item < smaller)
                    smaller = item;
            }
            Console.WriteLine($"Menor Valor: {smaller}; Maior Valor: {bigger}");
        }

        /// <summary>
        /// ex11 separar os números ímpares dos pares num array numérico
        /// </summary>
        private static void ParImpar()
        {
            int[] a = InputRequest.GetIntArray();
            string p = "", i = "";
            foreach (var item in a)
            {
                if (item % 2 == 0)
                    p += $"{item}; ";
                else
                    i += $"{item}; ";
            }
            Console.WriteLine($"Pares: {p}");
            Console.WriteLine($"Ímpares: {i}");
        }

        private static void ex12()
        {

        }
    }
}
