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
        /// Creates an array of numbers
        /// </summary>
        public static int[] GetIntArray(int t=-1)
        {
            if (t==-1)
                t = Conversoes.ConverterStringParaInt(RequestString("Quantos elementos tem o Array?"));
            string[] a = new String[t];
            for (int i = 0; i < t; i++)
            {
                var s = InputRequest.RequestString("Introduza um Número");
                a.SetValue(s, i);
            }
            int[] b = new int[10];
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
                t = Conversoes.ConverterStringParaInt(RequestString("Quantos elementos tem o Array?"));
            string[] a = new String[t];
            for (int i = 0; i < t; i++)
            {
                var s = InputRequest.RequestString("Escreva algo: ");
                a[i] = s;
            }
            return a;
        }

        
    }
}
