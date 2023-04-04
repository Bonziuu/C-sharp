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
            Console.WriteLine("A = 10\nB = 20\n\nC = A + B = "+c);

            //Odejmowanie
            d = a - b;
            Console.WriteLine("D = A - B = " + d);

            //Mnożenie
            e = a * b;
            Console.WriteLine("E = A * B = " + e);

            //Dzielenie
            f = a / b;
            Console.WriteLine("F = A / B = " + f);

            //Reszta z dzielenia
            g = a % b;
            Console.WriteLine("G = A % B = " + g + " - reszta z dzielenia");

            //Nadpisanie nowej wartości zmiennej intiger a1
            Console.WriteLine("\n-------------------------------------------\nNadpisanie nowej wartości zmiennej A1:");
            int a1 = 5;
            int b1 = 8;
            Console.WriteLine("\nA1 = " + a1 + "\nB1 = " + b1);

            a1 += b1;
            Console.WriteLine("\n\"A1 += B1\"\nA1 = " + a1 +"\nB1 = "+b1);

            a1 -= b1;
            Console.WriteLine("\n\"A1 -= B1\"\nA1 = " + a1 + "\nB1 = " + b1);

            a1 *= b1;
            Console.WriteLine("\n\"A1 *= B1\"\nA1 = " + a1 + "\nB1 = " + b1);

            a1 /= b1;
            Console.WriteLine("\n\"A1 /= B1\"\nA1 = " + a1 + "\nB1 = " + b1);
            
            b1 %= a1;
            Console.WriteLine("\n\"B1 %= A1\"\nA1 = " + a1 + "\nB1 = " + b1);

            //Inkrementacja
            
            int a2 = 1;
            Console.WriteLine("\n-------------------------------------------\nInkrementacja\n\nJest to zwiększanie wartości zmiennej o 1. A2=" + a2);
            a2 += 1;
            Console.WriteLine("\nZwiększenie tej zmiennej o 1 można zapisać jako A2+=1; A2=" + a2);
            a2++;
            Console.WriteLine("\nPowszechnie inkrementację zapisuje się jako po prostu A2++; A2=" + a2);

            //Inkrementacja

            a2--;
            Console.WriteLine("\n\nDekrementacja A2--; A2=" + a2);

            //Operatory logiczne

            Console.WriteLine("\n-------------------------------------------\nOperatory logiczne\n\n>= - Większy równy\n<= - Mniejszy równy\n== - Równy (porównywanie zmiennych)");
            Console.WriteLine("!  - Negacja np !(1 == 1) = false, mimo że (1 == 1) = true\n!= - Różny");
            


            Console.ReadKey();
        }
    }
}