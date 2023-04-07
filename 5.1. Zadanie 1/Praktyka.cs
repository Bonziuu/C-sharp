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


            Console.WriteLine("\nProstokąt:\n");
            Console.WriteLine("");

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            // Dla liczby równej 0, mniejszej od Y (wprowadzonej przez użytkownika) i co pętlę dodawaną o 1
            // jest robiona pętla, która za każdym razem będzie wykonywała się od 0 do x, a po każdej mniejszej pętli robiona jest komenda WRITELINE

            Console.WriteLine("\n\nPole prostokąta: " + (x*y));

            //Console.ReadKey();
        }
    }
}
