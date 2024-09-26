using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.Zmienne
{
    public class Imie
    {
        public static void Imie1(string name)
        {
            if (name.Length == 0)
            {
                Console.Error.WriteLine("/n/n*** Błąd nie podałeś imienia ***/n/n/n");
                return;
            }
            bool woman = name.ToLower()[name.Length - 1] == 'a';
            if (name == "Kuba" || name == "Barnaba")
                woman = false;
            Console.WriteLine("Niech zgadnę jesteś: " + (woman ? " " + "dzziewczyną" : "chłopakiem") + "!");
            Console.WriteLine("Naciśnij Enter ...");
            Console.In.ReadLine();
        }

    }
}
