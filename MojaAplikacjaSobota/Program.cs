using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaAplikacjaSobota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string adresIp = Properties.Settings.Default.adresIp;
            //string Imie= Properties.Settings.Default.imie;
            //string Nazwisko=Properties.Settings.Default.nazwisko;
            //int krowa = 12;
            //Console.WriteLine("Hello");
            //Console.WriteLine(adresIp);
            //Console.WriteLine(Imie);
            //Console.WriteLine(Nazwisko);
            //for (int i=0; i<10; i++)
            //{
            //    krowa+= i;
            //    Console.WriteLine(krowa);
            //}

            //Console.WriteLine(krowa.ToString());
            //string abc = Console.ReadLine();

            PrintOnConsole("Czy chcesz dodać dwie liczby?");
            if (GetDataFromConsole("Napisz Y/N") == "Y")
            {
                int wynik = Sumowanie(GetDataFromConsole("podaj pierwszą liczbę:"), GetDataFromConsole("podaj drugą liczbę:"));
                Console.WriteLine("Wynik to:{0}", wynik);
                GetDataFromConsole("TO JUZ KONIEC!");
            }


        }

        static void PrintOnConsole(string tekst) 
        {
            Console.WriteLine(tekst);
        }

        static string GetDataFromConsole(string tekst)
        {
            PrintOnConsole(tekst);
            return Console.ReadLine();
        }
        
        static int Sumowanie(string l1, string l2) 
        { 
           return int.Parse(l1) + int.Parse(l2);
        }

    }
}
