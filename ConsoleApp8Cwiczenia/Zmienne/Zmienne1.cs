using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.Zmienne
{
    public class Zmienne1
    {
        public static void V()
        {
            Console.WriteLine("Podamy tyy nadawane zmiennym");
            int i = 10;
            string s = "Alicja";
            long l = 100000;
            float f = 1.0f;
            double g = 1.0;
            Console.WriteLine($"zmienne: {i} {s} {l} {f} {g}");
            string s1 = i.ToString();

        }
    }
}
