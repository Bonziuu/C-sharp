using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Pętle
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //Pętla WHILE - dopóki
            int a = 0;
            Console.WriteLine("Pętla while \n\nwhile (a < 10)\n{\n    Console.WriteLine(a);\n    a++;\n}\n\nRozwiązanie:\n");
            while (a < 5)
            {
                Console.WriteLine(a);
                a++;
            }
            //Wykonuj pętlę while dopóki a będzie mniejsze od 5, w której wypisz aktualną wartość zmiennej 'a', a następnie powiększ zmienną o 1 (inkrementacja)
            
            Console.WriteLine("\nDopóki zmienna 'a' będzie mniejsza od 10 to wykonaj pętlę, w której wypisz wartość zmiennej 'a', \na następnie zwiększ wartość zmiennej o 1 (inktementacja)");
            Console.WriteLine("--------------------------------");


            //Pętla FOR - dla
            for (int b = 0; b < 5; b++)
            {
                Console.WriteLine(b);
            }
            //Zadeklarowana zmienna int b w nawiasie pętli for jest zadeklarowana WYŁĄCZNIE dla pętli i poza nia nie istnieje!
            
            Console.WriteLine();
            int c = 0;
            for (; c < 5; c++)
            {
                Console.WriteLine(c);
            }
            
            Console.WriteLine();
            int d;
            for (d = 0; d < 5; d++)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
