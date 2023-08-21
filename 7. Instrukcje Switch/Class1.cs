using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Instrukcje_Switch
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------------------\nInstrukcje Switch\n--------------------------------------");
            Console.WriteLine("Instrukcje Switch są używane w podobnych przypadkach co instrukcje if-else jednak przydają się, " +
                "\ngdy chce się poprawić czytelność kodu a stopień skomplikowania wyboru takiej instrukcji jest niski." +
                "\nSwitch jest wykorzystywany np. w stworzeniu menu, gdzie każda z opcji tworzy jakiś konkretny skutek.\n\nPrzykład: Wybór operacji matematycznej\n\n");
            Console.WriteLine("char operacja = '*';\ndouble a = 5.0, b = 3.0;\ndouble wynik;\n\nswitch (operacja)\n{\n    case '+':\n        wynik = a + b;\n        break;\n" +
                "    case '-':\n        wynik = a - b;\n        break;\n    case '*':\n        wynik = a * b;\n        break;\n    case '/':\n        wynik = a / b;\n" +
                "    default:\n        Console.WriteLine(\"Nieznana operacja\");\n        return;\n}\n");
            Console.WriteLine("Console.WriteLine($''Wynik: {wynik}'');");
            char operacja = '*';
            double a = 5.0, b = 3.0;
            double wynik;

            switch (operacja)
            {
                case '+':
                    wynik = a + b;
                    break;
                case '-':
                    wynik = a - b;
                    break;
                case '*':
                    wynik = a * b;
                    break;
                case '/':
                    wynik = a / b;
                    break;
                default:
                    Console.WriteLine("Nieznana operacja");
                    return;
            }

            Console.WriteLine($"Wynik: {wynik}");

            Console.WriteLine("\n\nNa początku piszemy operację 'switch()' " +
                "\ni dajemy argument którego wartość będzie przypisana do jednego z kejsow, czyli 'case', " +
                "\nktóry jest możliwym do osiągnięcia wynikiem, a każdy taki case musi zostać zakończony za pomocą break albo goto\n" +
                "po wypisaniu wszystkich opcji podobnie jak w if-else stawiamy else, który zawiera wszystkie inne przypadki \nniż przewidziane przez program.");

            Console.WriteLine("\nSposób zapisu instrukcji Switch jest dość ograniczony, ponieważ nie można przyjmować żadnych warunków ani && lub ||," +
                "\nco powoduje, że w bardziej skomplikowanych przykładach lepiej jest wykorzystać if-else.\n\n(Drugi przykład jest zakomentowany w kodzie)");

            
            
            //Przykład drugi zakomentowany, aby odkomentować CRTL + K i CTRL + U
            
            //int dzienTygodnia = 1;

            //switch (dzienTygodnia)
            //{
            //    case 1:
            //        Console.WriteLine("Poniedziałek");
            //        goto koniec;
            //    case 2:
            //        Console.WriteLine("Wtorek");
            //        break;
            //    case 3:
            //        Console.WriteLine("Środa");
            //        break;
            //    case 4:
            //        Console.WriteLine("Czwartek");
            //        goto case 7;
            //    case 5:
            //        Console.WriteLine("Piątek");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sobota");
            //        break;
            //    case 7:
            //        Console.WriteLine("Niedziela");
            //        break;
            //    default:
            //        Console.WriteLine("Nieprawidłowy dzień tygodnia");
            //        break;
            //}
            //Console.WriteLine("Koniec pętli");
        
            //koniec:
            //Console.WriteLine("Koniec z goto");

            //Console.WriteLine($"Wynik: {dzienTygodnia}");

            Console.ReadKey();
        }
    }
}
