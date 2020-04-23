using System;
using Common;
using Ficha6;
using Ficha7;
using Ficha8;
using Ficha12;
using Ficha13;
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
                Console.WriteLine("Ficha 6 ou 10");
                Console.WriteLine("Ficha 7 ou 11");
                Console.WriteLine("Ficha 8 ou 14");
                Console.WriteLine("Ficha 9 ou 12");
                Console.WriteLine("Ficha 13");
                Console.WriteLine("Ficha 15");
                Console.WriteLine("Ficha 16\n");
                int f = Conversoes.ConverterStringParaInt(Console.ReadLine());

                switch (f)
                {
                    case 0:
                        return;
                    case 6:
                    case 10:
                        Ficha6solucao.Ficha6();
                        break;
                    case 11:
                    case 7:
                        Ficha7solucao.Ficha7();
                        break;
                    case 8:
                    case 14:
                        Ficha8solucao.Ficha8();
                        break;
                    case 9:
                    case 12:
                        Ficha12solucao.Ficha12();
                        break;
                    case 13:
                        Ficha13solucao.Ficha13();
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
