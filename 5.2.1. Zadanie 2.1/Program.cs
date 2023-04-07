﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._1._Zadanie_2._Rozwiązanie_1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //Gra w zgadywanie liczby wylosowanej przez komputer
            //Komputer losuje liczbe od 1 - 10
            //Użytkownik próbuje odgadnąć liczbę
            //Jeżeli podana liczba jest mniejsza lub większa od wylosowanej to wyświetl komunikat
            //Jeśli użytkownik trafi to pokaż komunikat wygranej

            Random rnd = new Random();

            int a = rnd.Next(1,11);
            Console.WriteLine("Komputer wygenerował pewną liczbę w przedziale 1-10, zgadnij jaką!");
            Console.WriteLine("Wpisz liczbę, którą podejrzewasz że komputer wylosował: ");
            int b;
            
            do
            {
                b = int.Parse(Console.ReadLine());

                if (b < a)
                {
                    Console.WriteLine("Liczba wygenerowana przez komputer jest większa");
                    Console.WriteLine("Wpisz kolejną liczbę:");
                }
                else if (b > a)
                {
                    Console.WriteLine("Liczba wygenerowana przez komputer jest mniejsza");
                    Console.WriteLine("Wpisz kolejną liczbę:");
                }
                else
                {
                    Console.WriteLine("Gratulacje! Odgadłeś liczbę!");
                }
            }
            while (b != a);
            // Pętla ma działać tak długo jak b będzie różne od a

            Console.ReadKey();
        }
    }
}
