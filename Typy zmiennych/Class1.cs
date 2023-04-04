using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy_zmiennych
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxintiger = int.MaxValue;
            int minintiger = int.MinValue;

            byte minbajt = byte.MinValue;
            byte maxbajt = byte.MaxValue;

            short minshort = short.MinValue;
            short maxshort = short.MaxValue;

            sbyte minsbajt = sbyte.MinValue;
            sbyte maxsbajt = sbyte.MaxValue;

            Console.WriteLine("Typy zmiennych\n");
            Console.WriteLine("Int\nLiczby całkowite\nZmienna typu int może przyjmować wartość od " + minintiger + " do " + maxintiger);
            Console.WriteLine("\nByte\nLiczby całkowite\nZmienna typu byte może przyjmować wartość od " + minbajt + " do " + maxbajt);
            Console.WriteLine("\nSbyte\nLiczby całkowite\nZmienna typu sbyte może przyjmować wartość od " + minsbajt + " do " + maxsbajt);
            Console.WriteLine("\nShort\nLiczby całkowite\nZmienna typu short może przyjmować wartość od " + minshort + " do " + maxshort);
            Console.ReadKey();
        }
    }
}
