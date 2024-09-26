using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.Zmienne
{
    public class Kwadrat
    {
        public static int calculate(int nomber)
        {
            if(nomber == 0) { Console.Error.WriteLine("Błąd"); }
            else
            {
                nomber = nomber * nomber;
            }
            return nomber;
        }
        public static void rangeDouble(out double min, out double max)
        {
            max = double.MaxValue;
            min = double.MinValue;
            Console.WriteLine("liczby double mogą należeć do przedziału (" + min + "," + max + ")");
        }
    }
}
