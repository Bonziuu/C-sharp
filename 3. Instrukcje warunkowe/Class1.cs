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

            Console.WriteLine("Instrukcje warunkowe\n-------------------------------------------\n\nif - jeżeli\n\nFunkcja ta jest używana w sposób:\n\nif(b) {\n    Console.WriteLine()\n      }\n\n\"JEŻELI B JEST TRUE (spełnione/prawdziwe) TO WYKONAJ KOMENDĘ WRITELINE\"\n");

            if (b) {
                Console.WriteLine("\nZmienna b jest prawdziwa");
            }

            Console.WriteLine("\nif(b == false) {\n    Console.WriteLine()\n      }\n\n\"JEŻELI B JEST FALSE (niespełnione/fałszywe) TO NIE WYKONUJ WARUNKU\"\n");

            if (c == false)
            {
                Console.WriteLine("Zmienna c jest fałszywa");
            }
            
            
            Console.ReadKey();
        }
    }
}
