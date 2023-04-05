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

            Console.WriteLine("Instrukcje warunkowe\n-------------------------------------------\n\nif - jeżeli\n\nFunkcja ta jest używana w sposób:\n\nif(b) \n{\n    Console.WriteLine()\n}\n\n\"JEŻELI B JEST TRUE (spełnione/prawdziwe) TO WYKONAJ KOMENDĘ WRITELINE\"");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("if (b == false) \n{\n    Console.WriteLine()\n}\n\n\"JEŻELI B JEST FALSE (niespełnione/fałszywe) TO NIE WYKONUJ WARUNKU IF\"");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("if (a > 0) \n{\n    Console.WriteLine(\"a jest większe od 0\")\n}\nelse\n{\n    Console.WriteLine(\"a nie jest większe od 0\")\n}\n\n\"JEŻELI A JEST WIĘKSZE OD 0 TO WYKONAJ WRITELINE 'a jest większe od 0'\nA JEŚLI NIE TO WYKONAJ WRITELINE 'a nie jest większe od 0' IF\"");
            Console.WriteLine("-------------------------------------------\n");
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
            else
            {
                Console.WriteLine("a nie jest większe od 0");
            }
            Console.ReadKey();
        }
    }
}
