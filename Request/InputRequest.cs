using System; 

namespace Common
{
    public class InputRequest
    {
        /// <summary>
        /// Requests an input for an text value
        /// </summary>
        /// <param name="message">The message that should be presented to the user</param>
        /// <returns>The inputted value or "" by default</returns>
        public static string RequestString(string message)
        {
            Console.WriteLine("\n"+message);
            return Console.ReadLine();
        }

        /// <summary>
        /// Requests an input for an int value
        /// </summary>
        public static int RequestInt(string message, bool biggerThan0=false)
        {
            
            Console.WriteLine("\n" + message);
            int n=Conversoes.ConverterStringParaInt(Console.ReadLine());
            if (biggerThan0&&n<1)
            {
                Console.WriteLine("O Valor tem de ser maior que zero!");
                n=RequestInt(message, true);
            }
            return n;
        }

        /// <summary>
        /// Requests an input for an double value
        /// </summary>
        public static double RequestDouble(string message)
        {
            Console.WriteLine("\n" + message);
            return Conversoes.ConverterStringParaDouble(Console.ReadLine());
        }

        /// <summary>
        /// Creates an array of ints
        /// </summary>
        public static int[] GetIntArray(int t=-1)
        {
            if (t==-1)
                t = RequestInt("Quantos elementos tem o Array?",true);
            string[] a = new String[t];
            for (int i = 0; i < t; i++)
            {
                var s = InputRequest.RequestString("Introduza um Número");
                a.SetValue(s, i);
            }
            int[] b = new int[t];
            for (int i = 0; i < a.Length; i++)
            {
                string v = a.GetValue(i).ToString();
                b.SetValue(Conversoes.ConverterStringParaInt(v), i);
            }
            return b;
        }

        /// <summary>
        /// Creates an array of strings
        /// </summary>
        public static string[] GetStrArray(int t=-1)
        {
            if (t == -1)
                t = RequestInt("Quantos elementos tem o Array?", true);
            string[] a = new String[t];
            for (int i = 0; i < t; i++)
            {
                var s = InputRequest.RequestString("Escreva algo: ");
                a[i] = s;
            }
            return a;
        }

        /// <summary>
        /// Creates an array of doubles
        /// </summary>
        public static double[] GetDoubleArray(int t = -1)
        {
            if (t == -1)
                t = RequestInt("Quantos elementos tem o Array?", true);
            double[] a = new double[t];
            for (int i = 0; i < t; i++)
            {
                double d = InputRequest.RequestDouble("Introduza um Número");
                a.SetValue(d, i);
            }
            return a;
        }
    }
}
