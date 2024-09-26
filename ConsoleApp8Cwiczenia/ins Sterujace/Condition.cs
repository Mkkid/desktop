using ConsoleApp8_Ćwiczenia.Zmienne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Ćwiczenia.ins_Sterujace
{
    public class Condition
    {
        public static void Losowanie()
        {
            Random r = new Random();
            int n = r.Next(1, 7);
            Console.WriteLine(n.ToString());
            if (n <= 3)
                {
                Console.WriteLine("mniejsza od 3");
            }
            if (n < 5)
            {
                Console.WriteLine("mniejsza od 5");
            }
            else
            {
                Console.WriteLine("Wylosowana liczba jest większa lub równa 5");
            }
        }
        public static void Week()
        {
            Console.WriteLine("Dni tygodnia warunek 1");
            Random r = new Random();
            int n = r.Next(8);
            DniTygodnia day = (byte)0;
            if (n == 1) day = DniTygodnia.Niedziela;
            else if (n == 2) day = DniTygodnia.Poniedzialek;
            else if (n == 3) day = DniTygodnia.Wtorek;
            else if (n == 4) day = DniTygodnia.Sroda;
            else if (n == 5) day = DniTygodnia.Czwartek;
            else if (n == 6) day = DniTygodnia.Piatek;
            else if (n == 7) day = DniTygodnia.Sobota;
            else if (n == 0) Console.WriteLine("Błąd");

            Console.WriteLine(day.ToString() + " Piękny dzień");
        }
        public static void Week2()
        {
            Console.WriteLine("Dni tygodnia warunek 2");
            Random r= new Random();
            int n = r.Next(8);
            string opis;
            if (n == 1 || n == 7) opis = "Weekend";
            else if (n >= 2 && n <= 6) opis = "Dni robocze";
            else opis = "błąd";

            Console.WriteLine("typ dnia: "+n+", "+opis);
        }
        public static void Week3()
        {
            Console.WriteLine("Dni tygodnia warunek 3");
            Random r =new Random();
            int n = r.Next(8);
            string opis;
            switch (n)
            {
                case 1: opis = "niedziela"; break;
                case 2: opis = "poniedziałek"; break;
                case 3: opis = "wtorek"; break;
                case 4: opis = "sreoda"; break;
                case 5: opis = "czwartek"; break;
                case 6: opis = "piątek"; break;
                case 7: opis = "sobota"; break;
                default: opis = "blad!"; break;
            }
                    Console.WriteLine("Dzień tygodnia:" + n + "," + opis);
            
        } 
        public static void Week4()
        {
            Console.WriteLine("Dni tygodnia warunek 4");
            Random r = new Random();
            int n = r.Next(8);
            string opis;
            switch (n)
            {
                case 1: 
                case 7: opis = "Weekend"; break;
                case 2: 
                case 3: 
                case 4: 
                case 5: 
                case 6: opis = "dni robocze";break;
                
                default: opis = "blad!"; break;
            }
            Console.WriteLine("Dzień tygodnia:" + n + "," + opis);
        }
        public static void Week5()
        {
            Console.WriteLine("Dni tygodnia warunek 5");
            Random r = new Random();
            int n = r.Next(8); //losowanie od 0 do 8
            string opis = n switch
            {
                1 => "niedziela",
                2 => "poniedziałek",
                3 => "wtorek",
                4 => "środa",
                5 => "czwartek",
                6 => "piątek",
                7 => "sobota",
                _ => "błąd "
            };
            Console.WriteLine("dzień tygodnia " + n + ", " + opis);
        }
    }
    }

