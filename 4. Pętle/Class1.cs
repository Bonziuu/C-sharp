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
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Pętla while \n\nwhile (a < 10)\n{\n    Console.WriteLine(a);\n    a++;\n}\n\nRozwiązanie:\n");
            while (a < 5)
            {
                Console.WriteLine(a);
                a++;
            }
            //Wykonuj pętlę while dopóki a będzie mniejsze od 5, w której wypisz aktualną wartość zmiennej 'a', a następnie powiększ zmienną o 1 (inkrementacja)
            
            Console.WriteLine("\nDopóki zmienna 'a' będzie mniejsza od 5 to wykonaj pętlę, w której wypisz wartość zmiennej 'a', \na następnie zwiększ wartość zmiennej o 1 (inkrementacja)");
            Console.WriteLine("\n--------------------------------");


            //Pętla FOR - dla
            Console.WriteLine("Pętla for \n\nfor (int b = 0; b < 5; b++)\n{\n    Console.WriteLine(b);\n    b++;\n}\n\nRozwiązanie:\n");
            for (int b = 0; b < 5; b++)
            {
                Console.WriteLine(b);
            }
            //Zadeklarowana zmienna int b w nawiasie pętli for jest zadeklarowana WYŁĄCZNIE dla pętli i poza nia nie istnieje!

            Console.WriteLine("\nDla zadeklarowanej zmiennej 'b' rownej 0 i dla 'b' mniejszego od 5 wykonaj pętlę, \nw której za każdym razem zwiększ wartość 'b' o 1 (inkrementacja) i wypisz wartość zmiennej 'b'");
            Console.WriteLine("\nPętlę for można zadeklarować także:\nint c = 0;\nfor (; c < 5; c++)\n\nlub\n\nint d;\nfor (d = 0; d < 5; d++)");
            Console.WriteLine("\n--------------------------------");

            /*
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
            */

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
