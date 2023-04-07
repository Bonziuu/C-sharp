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

            //Zadanie : Wyświetl prostokąt złożony z '*' o wysokości Y i szerokości X, które wprowadzane są przez użytkownika
            Console.Write("Wpisz długość X = ");
            string x1 = Console.ReadLine();
            int x = int.Parse(x1);

            Console.Write("Wpisz długość Y = ");
            string y1 = Console.ReadLine();
            int y = int.Parse(y1);

            //Zadanie : Wyświetl obwód prostokąta złożony z '*' o wysokości Y i szerokości X, które wprowadzane są przez użytkownika
            // rysowanie górnej krawędzi
            Console.WriteLine("\nProstokąt:\n");
            Console.WriteLine("");
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();


            // rysowanie bocznych krawędzi i wypełnienie w środku
            for (int i = 0; i < y - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < x - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            // rysowanie dolnej krawędzi
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.WriteLine("\n\nPole prostokąta: " + (x * y));

            //Console.ReadKey();
        }
    }
}
