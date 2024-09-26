using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.Zmienne
{
     class Exercise
    {
        public static double ObliczSrednia(double a, double b)
        {
            return (a + b) / 2.0;
        }
        public static void Exercise1(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
