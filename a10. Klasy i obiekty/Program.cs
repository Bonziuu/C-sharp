using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10.Klasy_i_obiekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------\nKlasy i obiekty\n--------------------------------------");
            Console.WriteLine("\nTworzenie nowej klasy musi być umiejscowione w przestrzeni nazw 'namespace' \n" +
                "i może byc utworzone w tym samym pliku .cs lub w nowej utworzonej klasie za pomocą prawego przycisku myszy \n" +
                "na rozwiązaniu w 'Eksploratorze rozwiązań' -> Dodaj -> Nowy element -> Klasa C#\n" +
                "\nPrzykładem nowej klasy może byc deklaracja 'class Nowaklasa{}''\n\n" +
                "Jeśli mamy zadeklarowane jakieś zmienne w 'Nowaklasa' i chcielibyśmy z tych zmiennych korzystać w innej klasie \n" +
                "np w Main to domyślnie nie jest to możliwe. W takim wypadku trzeba dodać przed zmiennymi słowo 'public' \n" +
                "np: 'public string zmienna1;'\n\n\n" +
                "Korzystanie z takiej zmiennej w innej klasie wyglądałoby w następujący sposób:\n\n" +
                "Nowaklasa nazwa_obiektu = new Nowaklasa();\n" +
                "nazwa_obiektu.zmienna1 = 10\n\nPrzykład:\n\n" +
                "class Nowaklasa\r\n    {\r\n        public int zmienna1;\r\n    }\n" +
                "\nstatic void Main(string[] args)\r\n    {\r\n        Nowaklasa nazwa_obiektu = new Nowaklasa();\n        nazwa_obiektu.zmienna1 = 10\r\n    }");
            Console.WriteLine("\n'Nazwa_obiektu' to nazwa lokalna działająca tylko w obrębie metody w której została utworzona \n" +
                "i takich obiektów można stworzyć więcej niż jeden.\n" +
                "Podobnie robi się z metodami gdzie także używamy słowka public np 'public void Metoda{}' \n" +
                "i wtedy utworzony w innej klasie obiekt można wywołać jako:\n" +
                "nazwa_obiektu.");
            Console.ReadKey();
        }
    }

    class Nowaklasa
    {
        public int zmienna1;
    }
}
