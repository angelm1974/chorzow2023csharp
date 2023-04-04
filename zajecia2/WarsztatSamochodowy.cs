using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace zajecia2
{
    internal class WarsztatSamochodowy
    {
        List<string> mojeSTO = new List<string>();
        List<STO> info = new List<STO>();
        public void tworzGeneryki()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Podaj imię: ");
                string nazwa = Console.ReadLine();
                mojeSTO.Add(nazwa);
                Console.WriteLine("Wyjscie q, enter dalej: ");
                if (Console.ReadLine() == "q") { break; };
            }
            foreach (var item in mojeSTO)
            {
                Console.WriteLine("Podane imie: {0}", item);
            }
        }

        public void zbudujSTO()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Dodaj nową książkę do biblioteki: ");
                STO noweSTO = new STO();
                Console.WriteLine("Podaj nazwę: ");
                noweSTO.nazwa = Console.ReadLine();
                Console.WriteLine("Podaj wlascicielia: ");
                noweSTO.wlasciciel = Console.ReadLine();
                Console.WriteLine("Podaj rok zalozenia: ");
                noweSTO.rokZalozenia = int.Parse(Console.ReadLine());
                noweSTO.stanowisko = new List<Stanowisko>();

                while (true)
                {
                    Stanowisko stanow = new Stanowisko();
                    Console.WriteLine("Dodaj nazwę stanowiska: ");
                    stanow.nazwaStanowiska = Console.ReadLine();
                    Console.WriteLine("Czy jest zajete: ");
                    stanow.zajete = bool.Parse(Console.ReadLine());
                    stanow.samochodNaStanowisku = new List<Samochod>();
                    stanow.wyposazenie = new List<Wyposazenie>();
                    while (true)
                    {
                        Samochod samo = new Samochod();
                        Console.WriteLine("Dodaj numer: ");
                        samo.numer = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dodaj marke: ");
                        samo.marka = Console.ReadLine();
                        Console.WriteLine("Dodaj model: ");
                        samo.model = Console.ReadLine();
                        Console.WriteLine("Dodaj uszkodzenie: ");
                        samo.uszkodzenie = Console.ReadLine();
                        Console.WriteLine("Wyjscie k, enter dalej: ");
                        if (Console.ReadLine() == "k")
                        { break; };
                    }
                    while (true)
                    {
                        Wyposazenie wypo = new Wyposazenie();
                        Console.WriteLine("Dodaj nazwe sprzetu: ");
                        wypo.nazwaSprzentu = Console.ReadLine();
                        Console.WriteLine("Dodaj identyfikator: ");
                        wypo.identyfikator = Console.ReadLine();
                        Console.WriteLine("Wyjscie k, enter dalej: ");
                        if (Console.ReadLine() == "k")
                        {
                            break;
                        };
                    }
                    Console.WriteLine("Wyjscie k, enter dalej: ");
                    if (Console.ReadLine() == "k")
                    {
                        break;
                    };
                }
                info.Add(noweSTO);
                Console.WriteLine("Wyjscie q, enter dalej: ");
                if (Console.ReadLine() == "q")
                {
                    break;
                };
            }
            foreach (var item in info)
            {
                Console.WriteLine("STO: nazwa - {0}, Wlasciciel {1}, rok zalozenia {2}, stanowisko:{3}", item.nazwa, item.wlasciciel, item.rokZalozenia, item.stanowisko.Count());
            }
        }
    }

    struct STO
    {
        public string nazwa;
        public string wlasciciel;
        public int rokZalozenia;
        public List<Stanowisko> stanowisko;
    }
    struct Stanowisko
    {
        public string nazwaStanowiska;
        public bool zajete;
        public List<Samochod> samochodNaStanowisku;
        public List<Wyposazenie> wyposazenie;
    }

    struct Samochod
    {
        public int numer;
        public string marka;
        public string model;
        public string uszkodzenie;
    }

    struct Wyposazenie
    {
        public string nazwaSprzentu;
        public string identyfikator;
    }
}