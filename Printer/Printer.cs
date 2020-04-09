using System;

namespace Common
{
    public class Printer
    {
        #region Headers
        public static void PrintHeader(string headerText, int edgeGap, int edgeSize, ConsoleColor edgeColor, ConsoleColor textColor, char @char)
        {
            var headerTextSize = headerText.Length;
            PrintHeaderEdge(headerTextSize + (edgeGap + edgeSize) * 2, edgeColor, @char, true);
            PrintHeaderEdge(headerTextSize + (edgeGap + edgeSize) * 2, edgeColor, @char, true);
            PrintHeaderEmptyRow(headerTextSize + (edgeGap + edgeSize) * 2, edgeSize, edgeColor, @char);
            PrintHeaderText(headerText, edgeGap, edgeSize, edgeColor, textColor, @char);
            PrintHeaderEmptyRow(headerTextSize + (edgeGap + edgeSize) * 2, edgeSize, edgeColor, @char);
            PrintHeaderEdge(headerTextSize + (edgeGap + edgeSize) * 2, edgeColor, @char, true);
            PrintHeaderEdge(headerTextSize + (edgeGap + edgeSize) * 2, edgeColor, @char, true);
        }

        private static void PrintHeaderText(string text, int edgeGap, int edgeSize, ConsoleColor edgeColor, ConsoleColor textColor, char @char)
        {
            PrintHeaderEdge(edgeSize, edgeColor, @char);
            PrintHeaderEdge(edgeGap, edgeColor, ' ');
            var currentColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = textColor;
            System.Console.Write(text);
            System.Console.ForegroundColor = currentColor;
            PrintHeaderEdge(edgeGap, edgeColor, ' ');
            PrintHeaderEdge(edgeSize, edgeColor, @char);
            System.Console.WriteLine();
        }

        private static void PrintHeaderEmptyRow(int size, int edgeSize, ConsoleColor edgeColor, char @char)
        {
            PrintHeaderEdge(edgeSize, edgeColor, @char);
            PrintHeaderEdge(size - (2 * edgeSize), edgeColor, ' ');
            PrintHeaderEdge(edgeSize, edgeColor, @char);
            System.Console.WriteLine();
        }

        private static void PrintHeaderEdge(int edgeSize, ConsoleColor edgeColor, char @char, bool newLine = false)
        {
            var currentColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = edgeColor;
            for (var edgeCounter = 0; edgeCounter < edgeSize; edgeCounter++)
            {
                System.Console.Write(@char);
            }
            System.Console.ForegroundColor = currentColor;
            if (newLine) System.Console.WriteLine();
        }
        #endregion

        #region Lists

        public static void PrintList(string[] items, bool ordered = false)
        {
            foreach (var item in items)
            {
                if (ordered) System.Console.Write((Array.IndexOf(items, item) + 1) + " - ");
                System.Console.WriteLine(item);
            }
        }

        #endregion
    }
}