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
            Console.WriteLine("Komentarze można używać poprzez napisanie dwóch znaków '//':\n");
            Console.WriteLine("//Komentarz");
            Console.WriteLine("\nJest to komentarz obejmujący tylko jedną linię kodu\n");
            Console.WriteLine("Można także zakomentować jakąś część kodu poprzez użycie '/*' i '*/':\n");
            Console.WriteLine("/*\n *Komentarz 1\n *Komentarz 2\n */");
            Console.WriteLine("\nTaki komentarz obejmuje zbiór linii kodu zaczynając od momentu w którym zadelkarowany zostanie znak '/*'\ni będzie on komentarzem tak długo, aż nie zamkniemy zbioru znakiem '*/'");

            /*
             * Komentarz 1
             * Komentarz 2
             */

            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");

            //Skróty klawiszowe i snippety
            Console.WriteLine("Skróty klawiszowe i snippety\n");
            Console.WriteLine("Skróty klawiszowe:");
            Console.WriteLine("CTRL + S - zapisywanie programu");
            Console.WriteLine("CTRL + K, a następnie CTRL + D - ustawienie linii kodu do pozycji (za dużo spacji itp)");
            Console.WriteLine("CTRL + K, a następnie CTRL + C - zamiana zaznaczonego kodu w komentarz");
            Console.WriteLine("CTRL + K, a następnie CTRL + U - przywrócenie zaznaczonego komentarza w kod");


            Console.ReadKey();
        }
    }
}
