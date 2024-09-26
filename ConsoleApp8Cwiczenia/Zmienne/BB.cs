using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.Zmienne
{
    public class BB
    {
        public static void Obs()
        {
            try
            {
                Console.Write("a= ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b ");
                int b = int.Parse(Console.ReadLine());
                double srednia = (a + b) / 2.0;
                Console.WriteLine("Średnia liczb " + a + "i " + b + " to " + srednia);
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine("Wystąpił błąd:" +exc. Message);
                }
        }
    }
}
