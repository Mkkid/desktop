using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.ins_Sterujace
{
    public class Dfor
    {
        public static void Dfor1()
        {
            Console.WriteLine("Podaj imie!");
            string name = Console.ReadLine();

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{name} Po raz {i}");
                if (i == 9) Console.WriteLine("*************");

            }
            for(int i=10; i >= 0; i--)
            {
                Console.WriteLine($"{name} po raz {i}");
            }
        }
        public static long silnia(long n) 
        {
            long wartosc = 1;
            if (n <= 1) wartosc = 1;
            for(int i = 2; i <= n; i++)
            {
                wartosc *= i;
            }
            return wartosc;
        }
        public static void Silnia1(long n)
        {
            long wartosc = 1;
            int i = 2;
            if (n <= 1) wartosc = 1;
            while (n >= i)
            {
                wartosc *= i;
                i++;
            }
            Console.WriteLine($"wynik to: {wartosc}");
        }
        public static void Silnia2(long n)
        {
            int i = 1;
            long wartosc = 1;
            do
            {
                if (n <= 1)
                {
                    wartosc = 1;
                    break;
                }
                wartosc *= i;
                i++;
            }
            while (n >= i);
            Console.WriteLine($"Trzecia pętla do.. dała wynik--{wartosc}");
        }
    }
}
