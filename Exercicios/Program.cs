using System;
using Ficha6;
using Ficha7;
using Conversoes_;


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //test();
            run();
            
        }

        private static void run()
        {
            while (true)
            {
                Console.WriteLine("\nQual a Ficha?");
                Console.WriteLine("Para sair escolha 0\n");
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
                }
            }
        }

        private static void test()
        {
            Console.WriteLine("Valor");
            var val=Console.ReadLine();
            Console.WriteLine("Caracter");
            var cha = Console.Read();
            Console.WriteLine("Tecla");
            var tec = Console.ReadKey();
            Console.WriteLine($"Valor {val} \nCaracter {cha} \nTecla {tec.Key}");
            Console.WriteLine(@"Valor {0} \nCaracter {1} \nTecla {2}",val,cha,tec.Key);
        }
    }
}
