using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Instrukcje_skoku
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            //Instrukcje skoku
            //Break - przerwij, przydaje się gdy jest pętla w pętli i przerywa całą pętlę, gdy warunek w małej pętli zostanie spełniony

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Instrukcje skoku\n");
            Console.WriteLine("Break - przerwij, przydaje się gdy jest pętla w pętli i przerywa całą pętlę, \ngdy warunek w małej pętli zostanie spełniony\n");
            Console.WriteLine("Przykład użycia:\n\nint a = 0;\nwhile (true)\n{\n    if (a > 10)\n    {\n        Console.WriteLine(\"Pętla przerwana\");\n        break;\n        Console.WriteLine(\"To polecenie się nigdy nie wykona\")\n    }\n    Console.WriteLine(a);\na++;\n}\n");
            int a = 0;
            Console.WriteLine("Rozwiązanie:\n");
            while (true)
            {



                if (a > 10)
                {
                    Console.WriteLine("Pętla przerwana");
                    break;
                    Console.WriteLine("hehe");
                    Console.WriteLine(a); 
                }
                Console.WriteLine(a);
                a++;
            }

            //Dopóki wartość jest prawdziwa to wykonaj pętlę jeżeli, w której jeśli a będzie większe od 10 to przerwij całą pętlę
            //Cały kod w pętli po komendzie break nie zostanie nigdy wykonany

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
