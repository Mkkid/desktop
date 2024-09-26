using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.Zmienne
{
    public class St1
    {
        public static string Example(int count)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<count; i++)
            {
                sb.Append('f');
            }
            return sb.ToString();
        }

    }
}
