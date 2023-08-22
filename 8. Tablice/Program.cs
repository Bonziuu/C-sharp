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

            Console.WriteLine("\nTablice w języku C# są często używane do przechowywania zbiorów danych, takich jak kolekcje liczb, \nciągów znaków czy inne obiekty. Przy ich pomocy można efektywnie zarządzać danymi i wykonywać różne operacje, \n" +
                "takie jak sortowanie, wyszukiwanie i przetwarzanie elementów.");
            
            Console.WriteLine("\nBARDZO WAŻNA UWAGA\nW tablicy deklarujemy jej wielkość, a jej elementy są numerowane indeksami od zera!!!\n" +
                "Przykładowo jeśli ustawimy rozmiar tablicy na 20 to jej wyrazy będą w przedziale od 0 do 19!");

            Console.WriteLine("\nDeklaracje tablic wyglądają tak:\n\nint[] nazwa_tablicy1 = new int[20];\nint[] nazwa_tablicy2 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};\n" +
                "string[] nazwa_tablicy3 = new string[20];\nstring[] nazwa_tablicy4 = {''jeden'', ''dwa'', ''trzy''};\n");

            Console.WriteLine("Przypisać dane do tablic można tak:\nnazwa_tablicy1[0] = 15;\nnazwa_tablicy3[14] = ''tekst'';\n");
            
            
            Console.WriteLine("Można wykorzystywać długość tablic typu string stawiając kropkę po nazwie tej tablicy \ni wpisująć lenght np: nazwa_tablicy.Lenght\n\n" +
                "Przykład:\nfor (int i = 0; i < tablica1.Length; i++)\n{\n    Console.WriteLine(tablica1[i]);\n}\n\nW tym przypadku jeśli indeksujemy od 0 to dajemy mniejsze od tablicy, \n" +
                "a jeśli od 1 to dajemy mniejsze równe rozmiarowi tablicy \n(jednak wtedy zaczniemy od drugiego wyrazu a ostatni wyraz bedzie 0!)");

            //int[] nowatablica = new int[1000];
            //int[] innatablica = { 3, 5, 7, 4, 8, 1, 2, 3, 4, 6, 2, 3 };
            //string[] tablicastring = new string[5];
            //string[] tablicastring2 = { "osiem", "trzy", "jeden", "cztery" };

            //nowatablica[0] = 15;
            //nowatablica[1] = 14;

            //tablicastring[0] = "apud";
            //tablicastring[2] = "apudapudapud";

            //Console.WriteLine($"{nowatablica[0]} i {nowatablica[1]}, {tablicastring2[3]},{tablicastring[0]},{tablicastring[1]} ,{tablicastring[2]}");

            Console.WriteLine("\n\n--------------------------------------\nTablice wielowymiarowe\n\n" +
                "Tablice wielowymiarowe to tablice które posiadają co najmniej dwa wymiary (poprzednie tablice są jednowymiarowe)\n" +
                "\nTablice dwuwymiarowe:\nint[,] tablica = new int[2,3];\ntablica[0,1] = 12;\n\nPrzecinki oznaczają wymiary, w tym przypadku 2 jest wierszem, \na 3 jest kolumną i mamy tablicę 2x3\n" +
                "oraz przypisaliśmy wartość 12 w tablicy dla wiersza 0 i kolumny 1.");

            Console.WriteLine("\nJeśli chcielibyśmy wypisać wartości z dwuwymiarowych tablic to 'tablica.Lenght' już będzie niewystarczająca.\n" +
                "W tym przypadku trzeba użyć metody '.GetLenght' z dwoma pętlami np: tablica.GetLenght(0);\n\nConsole.WriteLine(tablica.GetLenght(0)); - W przypadku tej tablicy 2x3 zwrócone zostanie '2', \n" +
                "ponieważ metoda zczytuje pierwszą długość tablicy czyli wierszy, która tez jest indeksowana od 0, \n" +
                "natomiast 'Console.WriteLine(tablica.GetLenght(1));' byłoby już '3', \n" +
                "a kolejne wartości zczytują kolejne wymiary tablic.\n");

            Console.WriteLine("\nPrzykład wypisania wszystkich wyrazów w tablicy dwuwymiarowej:");
            Console.WriteLine("\nint[,] tablica = new int[2, 3];\ntablica[0, 0] = 1;\r\ntablica[0, 1] = 2;\r\ntablica[0, 2] = 3;\r\ntablica[1, 0] = 4;\r\ntablica[1, 1] = 5;\r\ntablica[1, 2] = 6;");
            Console.WriteLine("\nfor (int i = 0; i < tablica.GetLength(0); i++)\r\n{\r\n    for (int j = 0; j < tablica.GetLength(1); j++)\r\n    {\r\n        Console.Write(tablica[i, j] + \" \");\r\n    }\n    Console.WriteLine();\r\n}");
            Console.WriteLine("\nWynik:\n");

            int[,] tablica = new int[2, 3];
            tablica[0, 0] = 1;
            tablica[0, 1] = 2;
            tablica[0, 2] = 3;
            tablica[1, 0] = 4;
            tablica[1, 1] = 5;
            tablica[1, 2] = 6;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nW praktyce bardzo rzadko stosuje się tablice trójwymiarowe, które robi się analogicznie do tych dwuwymiarowych \noraz prawie w ogóle nie wykorzystuje się już tablic więcejwymiarowych.");
            
            Console.WriteLine("\n\n--------------------------------------\nTablice tablic\n\n" +
                "Tablice tablic, znane również jako tablice wielowymiarowe nieregularne lub jagged arrays\n" +
                "umożliwiają tworzenie nieregularnych i zagnieżdżonych struktur danych, \n" +
                "gdzie każda wewnętrzna tablica może mieć różny rozmiar.\n\nDeklaracja:\n\n" +
                "int[][] tabliceTablic = new int [3][];");
            Console.WriteLine("tabliceTablic[0] = new int[] { 1, 2, 3 };\r\ntabliceTablic[1] = new int[] { 4, 5 };\r\ntabliceTablic[2] = new int[] { 6, 7, 8, 9 };\n\n" +
                "Dostęp do elementów tablic tablic:\n\nint wartość = tabliceTablic[0][1]; // wartość = 2\n");

            Console.WriteLine("Dla tablicy tablic metoda '.GetLenght' wyświetli tylko dobrą pierwszą długość, \n" +
                "czyli 'tabliceTablic.GetLenght(0)' wyświetli '3', \nwięc zamiast niej w pętli ZEWNĘTRZNEJ można skorzystać po prostu z metody '.Lenght',\n" +
                "natomiast w pętli zewnętrznej warunkiem będzie jakaś zmienna mniejsza od tabliceTablic[i].Lenght, \ngdzie i jest zmienną pętli zewnętrznej, " +
                "czyli np: 'j < tabliceTablic[i].Lenght'\n");

            Console.WriteLine("Przykład wypisania wszystkich wyrazów tablicy tablic o różnych rozmiarach:\n\n" +
                "int[][] tabliceTablic = new int[3][];\r\ntabliceTablic[0] = new int[] { 1,2,3 };\r\ntabliceTablic[1] = new int[] { 4,5 };\r\ntabliceTablic[2] = new int[] { 6,7,8,9 };\r\n\r\nfor (int i = 0; i < tabliceTablic.Length; i++)\r\n{\r\n    " +
                "for (int j = 0; j < tabliceTablic[i].Length; j++)\r\n    {\r\n        Console.Write(tabliceTablic[i][j] + \" \");\r\n    }\r\n    Console.WriteLine();\r\n}\n\nWynik:\n");

            int[][] tabliceTablic = new int[3][];
            tabliceTablic[0] = new int[] { 1,2,3 };
            tabliceTablic[1] = new int[] { 4,5 };
            tabliceTablic[2] = new int[] { 6,7,8,9 };

            for (int i = 0; i < tabliceTablic.Length; i++)
            {
                for (int j = 0; j < tabliceTablic[i].Length; j++)
                {
                    Console.Write(tabliceTablic[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nW kontekście programowania słowo 'Array' to tablica \ni za pomocą tej komendy można łatwo zastosować metody przypisane do tablic jak np sortowanie:\n" +
                "Array.Sort(tablica);\npo wpisaniu słowa 'Array.' wyświetlą się różne metody działan na tablicach.");

            Console.ReadKey();
        }
    }
}
