using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------\nTablice\n--------------------------------------");
            Console.WriteLine("Tablice w programowaniu są to struktury, " +
                "za pomocą których można przechować informacje o zbiorach danych, \nktóre muszą byc tego samego typu (int/string)" +
                " i umożliwiają nam dostęp do wielu wartości tych danych \nza pomocą jednej zmiennej.");
            Console.WriteLine("\nBARDZO WAŻNA UWAGA\nW tablicy deklarujemy jej wielkość, a jej elementy są numerowane indeksami od zera!!!\n" +
                "Przykładowo jeśli ustawimy rozmiar tablicy na 20 to jej wyrazy będą w przedziale od 0 do 19!");

            Console.WriteLine("\nDeklaracje tablic wyglądają tak:\n\nint[] nazwa_tablicy1 = new int[20];\nint[] nazwa_tablicy2 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};\n" +
                "string[] nazwa_tablicy3 = new string[20];\nstring[] nazwa_tablicy4 = {''jeden'', ''dwa'', ''trzy''};\n");

            Console.WriteLine("Można wykorzystywać długość tablic typu string stawiająć kropkę po nazwie tej tablicy \ni wpisująć lenghtn np: nazwa_tablicy.Lenght\n\n" +
                "Przykład:\nfor (int i = 0; i < tablica1.Length; i++)\n{\n    Console.WriteLine(tablica1[i]);\n}\nW tym przypadku jeśli indeksujemy od 0 to dajemy mniejsze od tablicy, \n" +
                "a jeśli od 1 to dajemy mniejsze równe rozmiarowi tablicy");

            //int[] nowatablica = new int[1000];
            //int[] innatablica = { 3, 5, 7, 4, 8, 1, 2, 3, 4, 6, 2, 3 };
            //string[] tablicastring = new string[5];
            //string[] tablicastring2 = { "osiem", "trzy", "jeden", "cztery" };

            //nowatablica[0] = 15;
            //nowatablica[1] = 14;

            //tablicastring[0] = "apud";
            //tablicastring[2] = "apudapudapud";

            //Console.WriteLine($"{nowatablica[0]} i {nowatablica[1]}, {tablicastring2[3]},{tablicastring[0]},{tablicastring[1]} ,{tablicastring[2]}");



            Console.ReadKey();
        }
    }
}
