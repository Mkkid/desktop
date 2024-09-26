using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.Zmienne
{
     public class Zakres
    {
        public static void Zakres1() 
        {
            int i = 10;
            string s =i.ToString();
            Console.WriteLine($"Zakres typu int od {int.MinValue},do {int.MaxValue}");
            Console.WriteLine($"Zakres typu sbyte od {sbyte.MinValue}, do {sbyte.MaxValue}");
            Console.WriteLine($"Zakres typu byte od {byte.MinValue}, do {byte.MaxValue}");
            Console.WriteLine($"Zakres typu short od {short.MinValue}, do{short.MaxValue}");
            var ii = 100;//nadawanie typu przez wartość
            Console.WriteLine(ii);
            Console.WriteLine(ii.GetType().FullName);
            double x = (int)1;
            Console.WriteLine("indeksator - " + "Hala"[1]);
            Console.WriteLine("Helena".Equals("Help"));
            bool name = "Agnieszka".Equals("Agnieszka");
            Console.WriteLine(name);
            Console.WriteLine("LLaLaLa".IndexOf('a'));
            Console.WriteLine("Alicja".ToLower());
            Console.WriteLine("ala".ToUpper());
            string ss = "Hello";
            ss += " World!";
            Console.WriteLine("Łańcuch "+ss);
            Console.WriteLine("Długość: " + ss.Length);
            Console.WriteLine("Drukowanymi" + ss.ToUpper());
            string r = ss.ToUpper().Replace('L', 'l').Replace('O', '0').Replace('E', '3');
            Console.WriteLine("Zmodyfikowany Łańcuch:" + r);
            char[] litery= ss.ToCharArray();
        }
    }
}
