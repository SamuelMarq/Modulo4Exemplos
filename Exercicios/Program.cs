using System;
using Common;
using Ficha10;
using Ficha11;
using Ficha12;
using Ficha13;
using Ficha14;
using Ficha15;
using Ficha16;


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();   
        }

        private static void Run()
        {
            Console.WriteLine("Módulo 4");
            while (true)
            {
                Console.WriteLine("\nQual a Ficha?");
                Console.WriteLine("Para sair escolha 0");
                Console.WriteLine("Fichas disponiveis:");
                Console.WriteLine("Ficha 10");
                Console.WriteLine("Ficha 11");
                Console.WriteLine("Ficha 12");
                Console.WriteLine("Ficha 13");
                Console.WriteLine("Ficha 14");
                Console.WriteLine("Ficha 15");
                Console.WriteLine("Ficha 16\n");
                int f = Conversoes.ConverterStringParaInt(Console.ReadLine());

                switch (f)
                {
                    case 0:
                        return;
                    case 10:
                        Ficha10solucao.Ficha10();
                        break;
                    case 11:
                        Ficha11solucao.Ficha11();
                        break;
                    case 12:
                        Ficha12solucao.Ficha12();
                        break;
                    case 13:
                        Ficha13solucao.Ficha13();
                        break;
                    case 14:
                        Ficha14solucao.Ficha14();
                        break;
                    case 15:
                        Ficha15solucao.Ficha15();
                        break;
                    case 16:
                        Ficha16solucao.Ficha16();
                        break;
                }
            }
        }
    }
}
