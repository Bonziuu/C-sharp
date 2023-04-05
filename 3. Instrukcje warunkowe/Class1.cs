using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Instrukcje_warunkowe
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            
            //Deklaracje zmiennych
            int a = 5;
            bool b = true;
            bool c = false;


            //Instrukcje warunkowe

            Console.WriteLine("Instrukcje warunkowe\n-------------------------------------------\n\nif - jeżeli\nelse if - w przeciwnym razie, jeżeli\nelse - w przeciwnym razie\n\nFunkcja ta jest używana w sposób: (jeżeli b jest zmienną typu bool)\n\nif(b) \n{\n    Console.WriteLine();\n}\n\n\"JEŻELI B JEST TRUE (spełnione/prawdziwe) TO WYKONAJ KOMENDĘ WRITELINE\"");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("if (b == false) \n{\n    Console.WriteLine();\n}\n\n\"JEŻELI B JEST FALSE (niespełnione/fałszywe) TO NIE WYKONUJ WARUNKU IF\"");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("if (a > 0) \n{\n    Console.WriteLine(\"a jest większe od 0\");\n}\nelse if (a == 0)\n{\n    Console.WriteLine(\"a jest równe 0 \");\n}\nelse\n{\n    Console.WriteLine(\"a jest mniejsze od 0\");\n}\n\n\"JEŻELI A JEST WIĘKSZE OD 0 TO WYKONAJ WRITELINE 'a jest większe od 0'\nW PRZECIWNYM RAZIE WYKONAJ WRITELINE 'a nie jest większe od 0'\"");
            Console.WriteLine("-------------------------------------------\n");

            Console.ReadKey();

            if (b)
            {
                Console.WriteLine("\nZmienna b jest prawdziwa");
            }

            if (c == false)
            {
                Console.WriteLine("Zmienna c jest fałszywa");
            }
            
            if (a > 0)
            {
                Console.WriteLine("a jest większe od 0");
            }
            else if (a == 0)
            {
                Console.WriteLine("a jest równe 0");
            }
            else
            {
                Console.WriteLine("a jest mniejsze od 0");
            }
            Console.ReadKey();
        }
    }
}
