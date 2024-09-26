using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.Zmienne
{
    public class Color
    {
        public static void col(string text, ConsoleColor color = ConsoleColor.White)
        {
            ConsoleColor biezacy = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = biezacy;
        }
    }
}
