using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Dodatkowe_pojęcia_teoretyczne
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            //Komentarze
            Console.WriteLine("Komentarze\n");
            Console.WriteLine("Komentarze można używać poprzez napisanie dwóch znaków '//':");
            Console.WriteLine("//Komentarz");
            Console.WriteLine("Jest to komentarz obejmujący tylko jedną linię kodu\n");
            Console.WriteLine("Można także zakomentować jakąś część kodu poprzez użycie '/*' i '*/':");
            Console.WriteLine("/*\n *Komentarz 1\n *Komentarz 2\n */");
            Console.WriteLine("Taki komentarz obejmuje zbiór linii kodu zaczynając od momentu w którym zadelkarowany zostanie znak '/*'\ni będzie on komentarzem tak długo, aż nie zamkniemy zbioru znakiem '*/'");

            /*
             * Komentarz 1
             * Komentarz 2
             */
            Console.ReadKey();
        }
    }
}
