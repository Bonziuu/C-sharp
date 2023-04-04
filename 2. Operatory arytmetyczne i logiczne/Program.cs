using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Operatory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaracja zmiennych
            float a = 10;
            float b = 20;
            float c;
            float d;
            float e;
            float f;
            float g;

            //Dodawanie
            c = a + b;
            Console.WriteLine("A = 10\n\nB = 20\n\nC = A + B = "+c);

            //Odejmowanie
            d = a - b;
            Console.WriteLine("\nD = A - B = " + d);

            //Mnożenie
            e = a * b;
            Console.WriteLine("\nE = A * B = " + e);

            //Dzielenie
            f = a / b;
            Console.WriteLine("\nF = A / B = " + f);

            //Reszta z dzielenia
            g = a % b;
            Console.WriteLine("\nG = A % B = " + g + " - reszta z dzielenia");

















            Console.ReadKey();
        }
    }
}