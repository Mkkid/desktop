using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.Zmienne
{
     public class St
    {
   public static void Przyklad()
        {
            Console.WriteLine("Użycie klasy String");
            string s = "abc---";
            s += "def";
            s = s.Replace("---", "ghi");
            Console.WriteLine(s);
            Console.WriteLine("Użycie StringBilder'a ........");
            System.Text.StringBuilder sb = new System.Text.StringBuilder("abc---");
            sb.Append("def");
            sb.Replace("---", "ghi");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("efekt otrzymujemy dokładnie ten sam");
        }
    }
}
