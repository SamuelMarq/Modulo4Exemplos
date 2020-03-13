using System;

namespace Common
{
    public class Printer
    {
        #region Headers
        public static void PrintHeader(string headerText, int edgeGap, int edgeSize, ConsoleColor edgeColor, ConsoleColor textColor, char @char)
        {
            var headerTextSize = headerText.Length;
            PrintHeaderEdge(headerTextSize + (edgeGap + edgeSize) * 2, ConsoleColor.Yellow, @char, true);
            PrintHeaderEdge(headerTextSize + (edgeGap + edgeSize) * 2, ConsoleColor.Yellow, @char, true);
            PrintHeaderEmptyRow(headerTextSize + (edgeGap + edgeSize) * 2, edgeSize, ConsoleColor.Yellow, @char);
            PrintHeaderText(headerText, edgeGap, edgeSize, edgeColor, textColor, @char);
            PrintHeaderEmptyRow(headerTextSize + (edgeGap + edgeSize) * 2, edgeSize, ConsoleColor.Yellow, @char);
            PrintHeaderEdge(headerTextSize + (edgeGap + edgeSize) * 2, ConsoleColor.Yellow, @char, true);
            PrintHeaderEdge(headerTextSize + (edgeGap + edgeSize) * 2, ConsoleColor.Yellow, @char, true);
        }

        private static void PrintHeaderText(string text, int edgeGap, int edgeSize, ConsoleColor edgeColor, ConsoleColor textColor, char @char)
        {
            PrintHeaderEdge(edgeSize, edgeColor, @char);
            PrintHeaderEdge(edgeGap, edgeColor, ' ');
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = textColor;
            Console.Write(text);
            Console.ForegroundColor = currentColor;
            PrintHeaderEdge(edgeGap, edgeColor, ' ');
            PrintHeaderEdge(edgeSize, edgeColor, @char);
            Console.WriteLine();
        }

        private static void PrintHeaderEmptyRow(int size, int edgeSize, ConsoleColor edgeColor, char @char)
        {
            PrintHeaderEdge(edgeSize, edgeColor, @char);
            PrintHeaderEdge(size - (2 * edgeSize), edgeColor, ' ');
            PrintHeaderEdge(edgeSize, edgeColor, @char);
            Console.WriteLine();
        }

        private static void PrintHeaderEdge(int edgeSize, ConsoleColor edgeColor, char @char, bool newLine = false)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = edgeColor;
            for (var edgeCounter = 0; edgeCounter < edgeSize; edgeCounter++)
            {
                Console.Write(@char);
            }
            Console.ForegroundColor = currentColor;
            if (newLine) Console.WriteLine();
        }
        #endregion

        #region Lists

        public static void PrintList(string[] items, bool ordered = false)
        {
            foreach (var item in items)
            {
                if (ordered) Console.Write((Array.IndexOf(items, item) + 1) + " - ");
                Console.WriteLine(item);
            }
        }

        #endregion
    }
}