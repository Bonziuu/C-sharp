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

            //Continue - kontynuuj, przydaje się gdy jest pętla w pętli i komenda ta powtórzy całą pętlę i ominie kroki po tej komendzie (nie wykonają się w bieżącej pętli 
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("Continue - kontynuuj, przydaje się gdy jest pętla w pętli i komenda ta powtórzy całą pętlę \ni ominie kroki po tej komendzie (nie wykonają się w bieżącej pętli)\n");
            Console.WriteLine("Przykład użycia (wypisanie liczb parzystych do 10):\n\nfor (int i = 0; i < 10; i++)\n{\n    if (i % 2 == 1)\n    {\n        continue;\n    }\n    Console.WriteLine(i);\n}\n");
            Console.WriteLine("Rozwiązanie:\n");

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            //Dla wartości i od 0 do 9 jeśli reszta z dzielenia przez 2 wyniesie 1 to kontynuuj czyli wróć do początku pętli, a jeśli nie wyniesie 1 to wykonaj kolejne kroki bieżącej pętli
            Console.WriteLine("\nDla wartości i od 0 do 9 jeśli reszta z dzielenia przez 2 wyniesie 1 to kontynuuj czyli wróć do początku pętli, \na jeśli nie wyniesie 1 to wykonaj kolejne kroki bieżącej pętli");
            Console.ReadKey();
        }
    }
}
