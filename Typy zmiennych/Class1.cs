using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy_zmiennych
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liczby całkowite
            int maxintiger = int.MaxValue;
            int minintiger = int.MinValue;
            int sprawdzenie = maxintiger - minintiger;

            byte minbajt = byte.MinValue;
            byte maxbajt = byte.MaxValue;

            short minshort = short.MinValue;
            short maxshort = short.MaxValue;

            sbyte minsbajt = sbyte.MinValue;
            sbyte maxsbajt = sbyte.MaxValue;

            long minlong = long.MinValue;
            long maxlong = long.MaxValue;

            uint maxuintiger = uint.MaxValue;
            uint minuintiger = uint.MinValue;

            Console.WriteLine("Typy zmiennych\n");
            Console.WriteLine("Int\nLiczby całkowite\nZmienna typu int może przyjmować wartość od " + minintiger + " do " + maxintiger);
            Console.WriteLine("\nByte\nLiczby całkowite\nZmienna typu byte może przyjmować wartość od " + minbajt + " do " + maxbajt);
            Console.WriteLine("\nSbyte\nLiczby całkowite\nZmienna typu sbyte może przyjmować wartość od " + minsbajt + " do " + maxsbajt);
            Console.WriteLine("\nShort\nLiczby całkowite\nZmienna typu short może przyjmować wartość od " + minshort + " do " + maxshort);
            Console.WriteLine("\nLong\nLiczby całkowite\nZmienna typu long może przyjmować wartość od " + minlong + " do " + maxlong);
            Console.WriteLine("\nuint ushort ulong\nLiczby całkowite\nDodanie litery 'u' przed typami zmiennych powoduje podwojenie się zakresu przestrzeni liczb dodatnich \n(liczby ujemne zamieniane są na dodatnie) i może przyjmować wartość od " + minuintiger + " do " + maxuintiger + "\nSprawdzenie: maxintiger - minintiger = " + sprawdzenie);
            Console.Write("\n------------------------------------------------------------------------------");

            //Liczby zmiennoprzecinkowe
            float maxfloat = float.MaxValue;
            float minfloat = float.MinValue;
            //float zmiennaf = 212323213213.1532f;

            double maxdouble = double.MaxValue;
            double mindouble = double.MinValue;
            //double zmiennad = 4.1553532523432432d;

            decimal maxdecimal = decimal.MaxValue;
            decimal mindecimal = decimal.MinValue;
            //decimal zmiennam = 5.54765487564865486546546546465445m;

            Console.WriteLine("\nFloat\nLiczby zmiennoprzecinkowe\nZmienna typu float może przyjmować wartości od " + minfloat + " do " + maxfloat + "\nDo zmiennej typu float w deklaracji dopisujemy f lub F na końcu np: float zmienna = 1.2535456435f, \nponieważ bez litery f program będzie traktował zmienną jak double.\nTyp float pozwala osiągać duże liczby przed przecinkiem, przez co powoduje pogorszenie się czytania liczb po przecinku. (6-9 cyfr)");
            Console.WriteLine("\nDouble\nLiczby zmiennoprzecinkowe\nZmienna typu double może przyjmować wartości od " + mindouble + " do " + maxdouble +"\nDo double można dopisać na koncu d lub D, lecz nie trzeba, bo domyślnie liczbę przecinkową program rozumie jako zmienną double.\nZmienna typu double pozwala osiągać dużą dokładność liczb po przecinku, jednak kosztem osiągania małych cyfr \nprzed przecinkiem. (15-17 cyfr)");
            Console.WriteLine("\nDecimal\nLiczby zmiennoprzecinkowe\nZmienna typu decimal może przyjmować wartości od " + mindecimal + " do " + maxdecimal + "\nDo zmiennej typu decimal w deklaracji dopisujemy m lub M na końcu np: decimal zmienna = 1.2535456435M.\nZmienna typu decimal pozwala osiągać jeszcze większą dokładność liczb po przecinku niż double. (28-29 cyfr)");
            Console.Write("\n------------------------------------------------------------------------------\n");

            //Typy zmiennych tekstowych
            string konrad = "Mistrz świata";
            char znak = 'B';

            Console.WriteLine("String\nZmienna tekstowa\nPrzykład zastosowania: string konrad = \"Mistrz świata\";\nPrzykład użycia: Console.WriteLine(konrad);\nPrzykład rozwiązania: Mistrz świata");
            Console.WriteLine("\nChar\nZmienna tekstowa, która przechowuje tylko jeden znak!\nPrzykład zastosowania: char znak = 'B';\nPrzykład użycia: Console.WriteLine(znak);\nPrzykład rozwiązania: B");
            Console.Write("\n------------------------------------------------------------------------------\n");

            //Zmienne typu logicznego
            bool zmiennalogiczna = false;
            bool zmiennalogiczna2 = true;
            bool zmiennalogiczna3 = 5 > 2;

            Console.WriteLine("Bool\nZmienna typu logicznego\nPrzyjmuje wartości True lub False (prawda lub fałsz)\nMoże także sprawdzać prawdziwość argumentów\nPrzykład zastosowania: bool zmiennalogiczna3 = 5 > 2;\nPrzykład użycia: Console.WriteLine(zmiennalogiczna3);\nPrzykład rozwiązania: 5\nTrue");
            Console.Write("\n------------------------------------------------------------------------------\n");

            //Stała Const
            const int stala = 10;

            Console.Write("Stała Const");
            Console.Write("\nJeśli chcemy, aby przez cały program wartość pewnej zmiennej nigdy się nie zmieniała to deklarujemy \nprzed jej typem const\nPrzykład zastosowania: const int stala = 10;\n");


            //Zmienna inteligentna
            Console.Write("\nZmienna Var");
            Console.Write("\nUżywanie var przy deklaracji pomaga dostosować się do zmiennej. Program sam wyczytuje jakim typem zmiennej \njest konkretnie zdefiniowana dana zmienna.");

            Console.ReadKey();
        }
    }
}
