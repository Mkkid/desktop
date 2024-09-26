using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.ins_Sterujace
{
    public class Exception1
    {
        public static void Dzielenie()
        {
            Console.WriteLine("Nie ma dzielenia przez 0");
            try
            {
                int x = 0;
                int y = 1 / x;
                Console.WriteLine($"Wynik: {y}");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Wyjątek: " + exc.Message);
            }
        }
        public static void Dzielenie2()
        {
            try
            {
                int x = 0;
                int y = 1 / x;
                Console.WriteLine($"Wynik: {y}");
            }
            catch (DivideByZeroException exc)
            {
                Console.WriteLine("Dzielenie przez 0(" + exc.Message + ")");
            }
            catch(ArithmeticException exc)
            {
                Console.WriteLine("Błąd arytmetyki( "+exc.Message+")");
            }
            catch(Exception exc)
            {
                Console.WriteLine("Wyjątki: (" + exc.Message + ")");
            }
        }
        public static void Dzielenie3()
        {
            try
            {
                int x = 0;
                int y = 1 / x;
                Console.WriteLine($"Wynik: {y}");
            }
            catch (DivideByZeroException exc)
            {
                Console.WriteLine("Dzielenie przez 0(" + exc.Message + ")");
                return;
            }
            catch (ArithmeticException exc)
            {
                Console.WriteLine("Błąd arytmetyki (" + exc.Message + ")");
                return;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Wyjątek: " + exc.Message + ")");
                return;
            }
            finally
            {
                Console.WriteLine("Kod wykonywany w każdym przypadku");
            }
        }
        public static void Dzielenie4()
        {
            Console.WriteLine("nie ma dzielenia przez 0");
            try
            {
                int x = 0;
                if (x == 0) throw new DivideByZeroException("Nie pozwala na dzielenie przez zero");
                double y = 1 / x;
                Console.WriteLine($"Wynik: {y}");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Wyjątek:" + exc.Message);
            }
        }
    }
}
