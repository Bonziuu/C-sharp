﻿using System;
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
            Console.WriteLine("CTRL + Z - poprzedni krok");
            Console.WriteLine("CTRL + Y - następny krok");
            Console.WriteLine("CTRL + K, a następnie CTRL + D - ustawienie linii kodu do pozycji (za dużo spacji itp)");
            Console.WriteLine("CTRL + K, a następnie CTRL + C - zamiana zaznaczonego kodu w komentarz");
            Console.WriteLine("CTRL + K, a następnie CTRL + U - przywrócenie zaznaczonego komentarza w kod\n");
            Console.WriteLine("Snippety: (po wpisaniu skrótu kodowego i naciśnięciu 2x TAB wpisze się cała linia kodu)");
            Console.WriteLine("cw - Console.WriteLine()");
            Console.WriteLine("for - utworzenie przykładowej pętli for\ninne pętle");

            //for (int i = 0; i < length; i++)
            //{

            //}

            //Rzutowanie zmiennych
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Rzutowanie zmiennych - konwersja jawna i niejawna\n");
            Console.WriteLine("Konwersja niejawna to automatyczne przekształcenie przez program zmiennej jednego typu na inny typ bez utraty danych");
            Console.WriteLine("Konwersja jawna to wymuszone przez programistę przekształcenie przez program zmiennej jednego typu na inny typ wraz z utratą częsci danych");
            Console.WriteLine("Rzutowanie zmiennych polega na nadpisaniu wartości zmiennej jednego typu np. int \nza wartość zmiennej drugiego typu np double. \n\nPrzykład:");
            Console.WriteLine("int i = 500000;\ndouble d = 35.348;\n\ni = (int)d;\n");

            int i = 500000;
            double d = 35.348;
            Console.WriteLine("Wartość 'i' przed rzutowaniem zmiennej = " + i);
            i = (int)d;
            Console.WriteLine("Wartość 'i' po rzutowaniu zmiennej = " + i);
            Console.WriteLine("W tym przypadki rzutowanie spowodowało przekształcenie wartości zmiennej double na int, \nczyli liczby zmiennoprzecinkowej na całkowitą\n");
            Console.WriteLine("Jest to przykład konwersji jawnej");

            //Wczytywanie danych z konsoli
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Wczytywanie danych z konsoli\n");
            Console.WriteLine("Console.ReadLine(); - komenda która pozwala na wpisywanie znaków dla użytkownika\n");
            Console.WriteLine("Przykład użycia:\nstring s = Console.ReadLine();\nConsole.WriteLine(s);\n");
            Console.WriteLine("Rozwiązanie:\nProgram najpierw będzie chciał aby użytkownik coś wpisał, a po wpisaniu \ni naciśnięciu ENTER program wypisze to co użytkownik wpisał");

            //Console.ReadLine();

            //string s = Console.ReadLine();
            //Console.WriteLine(s);

            Console.WriteLine("\n\nConsole.ReadKey(); - komenda, która wymaga naciśnięcia klawisza przez użytkownika\n");
            Console.WriteLine("Przykład użycia:\nif (Console.ReadKey().Key == ConsoleKey.D2)\n{\n     Console.WriteLine(\"PRAWDA\");\n}\nelse\n{\n     Console.WriteLine(\"FAŁSZ\")\n}\n");
            Console.WriteLine("Rozwiązanie:\nJeżeli użytkownik wciśnie przycisk '2' na klawiaturze to wypisz PRAWDA, \na jeśli wciśnie inny przycisk to wypisz FAŁSZ");

            //if (Console.ReadKey().Key == ConsoleKey.D2)
            //{
            //    Console.WriteLine("\nPRAWDA");
            //}
            //else
            //{
            //    Console.WriteLine("\nFAŁSZ");
            //}

            //Konwersja typów
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Konwersja typów\n");

            Console.ReadKey();
        }
    }
}
