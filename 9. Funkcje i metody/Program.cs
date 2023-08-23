using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _9.Funkcje_i_metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[3];
            tab[0] = 1;
            tab[1] = 2;
            tab[2] = 3;
            int a = 5;
            //Console.WriteLine($"Tablica przed wywołaniem funkcji:{tab[0]}, {tab[1]}, {tab[2]}.");
            //Tablica(tab);
            //Console.WriteLine($"Tablica po wywołaniu funkcji:{tab[0]}, {tab[1]}, {tab[2]}.");

            //Zmienna(ref a);
            //Console.WriteLine(a);

            //ZmiennaOut(out a);
            //Console.WriteLine(a);

            Tekst();
            
            Przeciazanie();
            
            //Funkcja(2,1);
            //Funkcja(3,8,5);
            
            Void();
            
            Referencje();
            Referencje2();
            Console.ReadKey();
        }

        static void Funkcja(int a, int b)
        {
            int wynik = a + b;
            Console.WriteLine("\nWynik dodawania a i b: " + wynik);
        }

        static void Funkcja(int a, int b, int c)
        {
            int wynik = a + b + c;
            Console.WriteLine("\nWynik dodawania a, b i c: " + wynik);
        }

        static void Funkcja1(int a, int b, int c = 0)
        {
            int wynik = a + b + c;
            Console.WriteLine("\nWynik dodawania a, b i c: " + wynik);
        }
        static int Funkcja2(int a, int b)
        {
            int wynik = a + b;
            return wynik;
        }
        static string Funkcja3(int a, int b)
        {
            int wynik = a + b;
            if (wynik > 10)
            {
                return "wynik mniejszy od 10";
            }
            else
            {
                return "wynik większy od 10";
            }
        }
        static void Zmienna(ref int b)
        {
            b += 5;
        }

        static void ZmiennaOut(out int b)
        {
            b = 5;
            b += 5;
        }
        static void Tablica(int[] tab)
        {
            tab[0] = 8;
            tab[1] = 9;
            tab[2] = 10;
        }

        static void Tekst()
        {
            Console.WriteLine("--------------------------------------\nFunkcje i metody\n--------------------------------------");
            Console.WriteLine("Metodami nazywamy funkcje, które zawierają się w poszczególnych klasach i są one definiowane, \n" +
                "a następnie mogą być wywołane w innych funkcjach lub w funkcji Main. \n\n" +
                "Przykładem jest właśnie funkcja main która jest zdefiniowana jako 'static void Main(string[] args)'.\n" +
                "Funkcja Main przyjmuje tablice argumentów string o nazwie 'args' i jest to wykorzystywane podczas \n" +
                "uruchomienia programu/projektu z konsoli komputera.\n\n" +
                "Modyfikator 'static' oznacza, że wybrana metoda są elementem klasy a nie instancją obiektu,\n" +
                "czyli w tej metodzie można korzystać z elementów metody bez tworzenia obiektu danej klasy.\n\n" +
                "Słowo 'void' w tej sytuacji oznacza, że metoda nie zwraca żadnej wartości, czyli wykonuje określone działania, \n" +
                "ale nie zwraca wyniku, który można by przypisać do zmiennej.\n\n\n" +
                "Przykład deklaracji metody i wywołania jej w funkcji main:\n");
            Console.WriteLine("static void Funkcja(int a, int b)\r\n{\r\n    int wynik = a + b;\r\n    Console.WriteLine(\"Wynik dodawania a i b: \" + wynik);\r\n}\n");
            Console.WriteLine("static void Main(string[] args)\r\n{\r\n    Funkcja(3,6);\r\n    Console.ReadKey();\r\n}" +
                "\n\nRozwiązanie:\nWynik dodawania a i b: 9\n\n");
            Console.WriteLine("Wszystkie zadeklarowane argumenty w funkcji 'Funkcja' (w tym przypadku a, b i wynik)\n" +
                "są dostępne jedynie w obrębie tej funkcji i poza nią te argumenty nie istnieją \n" +
                "i można w innych funkcjach zadeklarować dokładnie te same nazwy argumentów bez wywołania błędu w programie.\n");
        }
        static void Przeciazanie()
        {
            Console.WriteLine("--------------------------------------\nPrzeciążanie funkcji\n");
            Console.WriteLine("Przeciążanie (overloading)  pozwala na definiowanie wielu wersji metody lub konstruktora o tej samej nazwie, \n" +
                "ale różniących się parametrami. Dzięki temu można tworzyć bardziej elastyczne i użyteczne funkcje, \n" +
                "które działają w zależności od rodzaju i liczby argumentów przekazywanych do nich.\n\n" +
                "Polega to na tym, że dana metoda może nazywać się dokładnie tak samo jak inna metoda już występująca w programie,\n" +
                "ale korzysta z innej ilości argumentów przez co można robic różne warianty takiej metody.\n\n");
            Console.WriteLine("Przykład:\nstatic void Funkcja(int a, int b)\r\n{\r\n    int wynik = a + b;\r\n    Console.WriteLine(\"\\nWynik dodawania a i b: \" + wynik);\r\n}\n" +
                "static void Funkcja(int a, int b, int c)\r\n{\r\n    int wynik = a + b + c;\r\n    Console.WriteLine(\"\\nWynik dodawania a, b i c: \" + wynik);\r\n}\n" +
                "static void Main(string[] args)\r\n{\r\n    Funkcja(2,1); //'Funkcja' z dwoma argumentami\r\n    Funkcja(3,8,5); //'Funkcja' z trzema argumentami\r\n}\n\n");
            Console.WriteLine("Można także zastosowac przypadek w którym przypiszemy jednemu argumentowi jakąś wartość:\n" +
                "static void Funkcja1(int a, int b, int c = 0)\r\n{\r\n    int wynik = a + b + c;\r\n    Console.WriteLine(\"\\nWynik dodawania a, b i c: \" + wynik);\r\n}\n" +
                "static void Main(string[] args)\r\n{\r\n    Funkcja1(2,1); //W tym przypadku parametr c osiągnie wartość 0\r\n    Funkcja1(3,8,5); //W tym przypadku parametr c osiągnie wartość 5\r\n}\n" +
                "Jeśli przypiszemy już jakąś wartośc do argumentu to WSZYSTKIE inne argumenty stojące po prawej stronie deklaracji \n" +
                "od pierwszego przypisanego także muszą mieć przypisane wartości!\n");
        }
        static void Void()
        {
            Console.WriteLine("--------------------------------------\nVoid i zamienniki\n");
            Console.WriteLine("Słowo 'void' w deklaracji metody nie zwracające żadnej wartości tej metody oznacza, \n" +
                "że w żadnym miejscu w tej metodzie nie używamy słowa 'return'. \n" +
                "Alternatywą do 'void' jest każdy typ danych jak np 'int' lub 'string' \n" +
                "i jeśli zostanie to tak zadeklarowane to zawsze trzeba zwrócić jakąś wartość za pomocą 'return'.\n\n" +
                "Przykład:\nstatic int Funkcja2(int a, int b)\r\n{\r\n    int wynik = a + b;\r\n    return wynik;\r\n}\n\nlub\n\n" +
                "static string Funkcja3(int a, int b)\r\n{\r\n    int wynik = a + b;\r\n    if(wynik > 10)\r\n    {" +
                "\r\n        return \"wynik mniejszy od 10\";\r\n    }\r\n    else\r\n    {\r\n        return \"wynik większy od 10\";\r\n    }\r\n}\n");
        }

        static void Referencje()
        {
            Console.WriteLine("--------------------------------------\nReferencje\n");
            Console.WriteLine("Jeśli mamy w jednej metodzie zadeklarowaną zmienną np 'a' która równa się 5 (int a = 5),\n" +
                "i wyślemy ją innej metody, w której przeprowadzona jest jakaś operacja na tej zmiennej 'a' \n" +
                "to w tej pierwszej metodzie 'a' nigdy się nie zmienia i to nawet po wywołaniu funkcji.\n\n" +
                "Jeśli chcemy, aby ta zmienna zmieniła swoją wartość po wywołaniu metody \n" +
                "musimy dodac słowko 'ref' przed deklaracją danej zmiennej\n\n" +
                "Przykład:\nstatic void Main(string[] args)\r\n{\r\n    int a = 5;\r\n    Zmienna(ref a);\r\n}\r\nstatic void Zmienna(ref int a)\r\n{\r\n    a += 5;\r\n}\n" +
                "W tym przykładzie w metodzie 'Main' przed wywołaniem metody 'Zmienna' \n" +
                "to 'a' równa się 5 a po wywołaniu metody a równa się 10. \n" +
                "Bez wypisania referencji 'ref' zmienna 'a' w mainie cały czas równałaby się 5.\n\n");
            Console.WriteLine("Jeśli chcemy przypisać wartość jakiejś zmiennej w pierwszej metodzie za pomocą metody drugiej, \n" +
                "czyli kiedy nie wiemy z góry jaką wartość przypisać do zmiennej \n" +
                "i właśnie ta druga funkcja nam zadeklaruje tą liczbę to używamy słowa 'out'.\n\n" +
                "Przykład: \nstatic void Main(string[] args)\r\n{\r\n    int a;\r\n    Zmienna(out a);\r\n}\r\nstatic void Zmienna(out int b)\r\n{\r\n    b = 5;\r\n}\n" +
                "Nazwa zmiennej w metodzie drugiej, czyli 'b' może różnić się od wysłanej nazwy zmiennej z metody Main, czyli 'a', \n" +
                "ponieważ 'b' jest tylko nazwą zmiennej lokalnej wewnątrz funkcji, a prawidłową nazwę zmiennej \n" +
                "wysłaliśmy za pomocą 'Zmienna(out a);'");
        }
        static void Referencje2()
        {
            Console.WriteLine("--------------------------------------\nReferencje złożone\n");
            Console.WriteLine("W przypadku zmiennych zastosowanie 'ref' w argumencie innej metody pozwala nadpisać zmienną główną w metodzie pierwszej,\n" +
                "natomiast inaczej jest już w przypadku np. tablic, w których język został stworzony w taki sposób,\n" +
                "aby tablice nadpisywały sie od razu bez dopisywania 'ref' do argumentu.\n\nPrzykład:\n" +
                "    static void Tablica(int[] tab)\r\n        {\r\n            tab[0] = 8;\r\n            tab[1] = 9;\r\n            tab[2] = 10;\r\n        }" +
                "\n    static void Main(string[] args)\r\n        {\r\n            int[] tab = new int[3];\r\n            tab[0] = 1;\r\n            tab[1] = 2;\r\n            tab[2] = 3;\r\n            Console.WriteLine($\"Tablica przed wywołaniem funkcji:{tab[0]}, {tab[1]}, {tab[2]}.\");\r\n            Tablica(tab);\r\n            Console.WriteLine($\"Tablica po wywołaniu funkcji:{tab[0]}, {tab[1]}, {tab[2]}.\");\r\n        }\n" +
                "    Tablica przed wywołaniem funkcji: 1, 2, 3.\n" +
                "    Tablica po wywołaniu funkcji: 8, 9, 10.\n");
            Console.WriteLine("Inaczej będzie natomiast w przypadku kiedy utworzymy sobie nową tablicę w drugiej metodzie" +
                "\n\nPrzykład:\n" +
                "    static void Tablica(int[] tab)\r\n        {\r\n            tab = new int[3];\r\n            tab[0] = 8;\r\n            tab[1] = 9;\r\n            tab[2] = 10;\r\n        }" +
                "\n    static void Main(string[] args)\r\n        {\r\n            int[] tab = new int[3];\r\n            tab[0] = 1;\r\n            tab[1] = 2;\r\n            tab[2] = 3;\r\n            Console.WriteLine($\"Tablica przed wywołaniem funkcji:{tab[0]}, {tab[1]}, {tab[2]}.\");\r\n            Tablica(tab);\r\n            Console.WriteLine($\"Tablica po wywołaniu funkcji:{tab[0]}, {tab[1]}, {tab[2]}.\");\r\n        }\n" +
                "    Tablica przed wywołaniem funkcji: 1, 2, 3.\n" +
                "    Tablica po wywołaniu funkcji: 1, 2, 3.\n");
            Console.WriteLine("Tutaj pierwotna tablica nie zmieniła wartości swoich danych, \n" +
                "ponieważ 'static void Tablica(int[] tab)' dokładnie w argumencie 'int[] tab' nie kopiuje całej tablicy, \n" +
                "jak to było w przypadku zmiennych które były kopiowane, lecz argument zachowuje jedynie adres do prawdziwej tablicy. \n" +
                "W momencie pisania 'tab = new int[3];' w metodzie 'Tablica' przechowywany adres jest nadpisywany przez nową tablicę, \n" +
                "która jest zawarta jedynie lokalnie w obrębie danej metody \n" +
                "i właśnie dlatego tablica w pierwszej metodzie nie jest nadpisana.");
        }
    }
}
