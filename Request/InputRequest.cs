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
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
