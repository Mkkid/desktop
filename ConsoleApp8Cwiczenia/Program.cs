// See https://aka.ms/new-console-template for more information
using ConsoleApp8_Ćwiczenia.ins_Sterujace;
using ConsoleApp8_Ćwiczenia.Zmienne;

Console.WriteLine("Hello, World!");
/*Zmienne1.V();
Zakres.Zakres1();
St.Przyklad();
Console.WriteLine(St1.Example(10));
Console.WriteLine("Typ wyliczeniowy.................");
DniTygodnia nrdniTygodnia = DniTygodnia.Niedziela;
Console.WriteLine(nrdniTygodnia);
    Console.Out.WriteLine(nrdniTygodnia);
byte nrdniTygodnia1 = (byte)DniTygodnia.Poniedzialek;
Console.WriteLine($"Rzutowanie zmiennej wyliczającej wartosc: {nrdniTygodnia1}");
Console.WriteLine("Jak masz na imie?");
string name= Console.In.ReadLine();
Imie.Imie1(name);
BB.Obs();
Program1.Metoda();
Program1.Metoda("Alicja");

Color.col("Alicja w krainie czarów");
Color.col("Alicja i jej kot", ConsoleColor.Magenta);
Color.col(color: ConsoleColor.Yellow, text: "Kot w butach");
Color.col(text: "Królowa Śniegu", color: ConsoleColor.Green);
Console.WriteLine("Wpisz liczbę całkowitą");
int liczba = int.Parse(Console.ReadLine());
int liczba2 = Kwadrat.calculate(liczba);
Console.WriteLine($"liczba podniesiona do kwadratu to: {liczba2} tak ");
double min = 0, max =0;
Kwadrat.rangeDouble(out min,out max);
Console.WriteLine($"Przedział double to - dolny {min} - górny - {max}");
Progra1.ShowInfoA("jakiś argument");
Console.WriteLine(" *** Exercise ***");
try
{
    Console.Write("a = ");
    int a1 = int.Parse(Console.ReadLine());
    Console.Write("b = ");
    int b1 = int.Parse(Console.ReadLine());
    double srednia = Exercise.ObliczSrednia(a1, b1);
    Console.WriteLine("Średnia liczb: " + a1 + " i " + b1 + " to " + srednia);
}
catch (Exception exc)
{
    Console.Error.WriteLine("Wystąpił błąd: "+exc.Message);
}
Console.WriteLine("Wczytaj wartość do n");
int n=int.Parse(Console.ReadLine());
while (n>0)
{
    n--;
    
    Color.col(n.ToString(), ConsoleColor.Blue);
}


Console.WriteLine("****************Zamiana *********");
int a2 = 10, b2 = 5;
Console.WriteLine("a2 = " + a2 + "b2 = " + b2);
Exercise.Exercise1(ref a2, ref b2 );
Console.WriteLine("a2 = " + a2 + "b2 = " + b2);*/
Console.WriteLine(" *** Losowanie ***  ");
Condition.Losowanie();
Condition.Week();
Condition.Week2();
Condition.Week3();
Condition.Week4();
Exception1.Dzielenie();
Exception1.Dzielenie2();
Exception1.Dzielenie3();
Dfor.Dfor1();

long liczba = 5;
long liczba1 = Dfor.silnia(liczba);
Console.WriteLine($"wynik silni to: {liczba1}");
Dfor.Silnia1(liczba);
Dfor.Silnia2(liczba);