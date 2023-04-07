using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._Praktyka
{
    internal class Praktyka
    {
        static void Main(string[] args)
        {
            
            //Zamiana czarnego koloru konsoli na czerwony
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }

            //Zadanie : Wyświetl  prostokąt złożony z '*' o wysokości Y i szerokości X, które wprowadzane są przez użytkownika
                Console.Write("Wpisz długość X = ");
            string x1 = Console.ReadLine();
            int x = int.Parse(x1);
            
            Console.Write("Wpisz długość Y = ");
            string y1 = Console.ReadLine();
            int y = int.Parse(y1);

            int a = 0;
            int b = 0;
            int c = 0;
            
            Console.WriteLine("\nProstokąt:\n");
            Console.WriteLine("");

            while (a < x)
            {
                Console.Write("*");
                a++;
            }

            Console.WriteLine();

            while (b < (y-2))
            {
                Console.WriteLine("*");
                b++;
            }

            while (c < x)
            {
                Console.Write("*");
                c++;
            }

            Console.WriteLine("\n\nPole prostokąta: " + (x*y));

            Console.ReadKey();
        }
    }
}
