using System;
using Ficha6;
using Ficha7;
using Ficha12;
using Ficha13;
using Conversoes_;


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            run();   
        }

        private static void run()
        {
            Console.WriteLine("Módulo 4");
            while (true)
            {
                Console.WriteLine("\nQual a Ficha?");
                Console.WriteLine("Para sair escolha 0");
                Console.WriteLine("Fichas disponiveis:");
                Console.WriteLine("Ficha 6");
                Console.WriteLine("Ficha 7");
                Console.WriteLine("Ficha 9 ou 12");
                Console.WriteLine("Ficha 13\n");
                int f = Conversoes.ConverterStringParaInt(Console.ReadLine());

                switch (f)
                {
                    case 0:
                        return;
                    case 6:
                        Ficha6solucao.Ficha6();
                        break;
                    case 7:
                        Ficha7solucao.Ficha7();
                        break;
                    case 9:
                    case 12:
                        Ficha12solucao.Ficha12();
                        break;
                    case 13:
                        Ficha13solucao.Ficha13();
                        break;
                }
            }
        }
    }
}
