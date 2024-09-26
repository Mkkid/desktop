using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.Zmienne
{
     class Progra1
    {
        public static void ShowInfoA(string argument,
            [CallerMemberName]string memberName="",
            [CallerFilePath]string sourceFilePath="",
            [CallerLineNumber] int surceLineNumber = 0)
        {
            Console.WriteLine("Informacja o miejscu wywołania metody:");
            Console.WriteLine("nazwa elementu składowego: " + memberName);
            Console.WriteLine("Ścieżka pliku z kodem źródłowym: "+ sourceFilePath);
            Console.WriteLine("numer linii, w której nastąpiło wywołanie: " + surceLineNumber);
        }
    }
}
