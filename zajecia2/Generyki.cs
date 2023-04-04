using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class Generyki
    {
        List<string> mojaLista = new List<string>();
        List<Ksiazka> biblioteka = new List<Ksiazka>();

        public void tworzGeneryki()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Podaj imię osoby: ");
                string osoba = Console.ReadLine();
                mojaLista.Add(osoba);

                Console.WriteLine("Wyjscie q, enter dalej: ");
                if (Console.ReadLine() == "q")
                {
                    break;
                };
            }

            foreach (var item in mojaLista)
            {
                Console.WriteLine("Podane imię: {0}", item);
            }
        }


        public void zbudujBiblioteke()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Dodaj nową książkę do biblioteki: ");

                Ksiazka nowaKsiazka = new Ksiazka();
                Console.WriteLine("Podaj tytuł: ");
                nowaKsiazka.tytul = Console.ReadLine();
                Console.WriteLine("Podaj autora: ");
                nowaKsiazka.autor = Console.ReadLine();
                Console.WriteLine("Podaj rok wydania: ");
                nowaKsiazka.rokWydania = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj ISBN: ");
                nowaKsiazka.ISBN = Console.ReadLine();
                Console.WriteLine("Czy książka jest zniszczona: ");
                nowaKsiazka.zniszczona = bool.Parse(Console.ReadLine());
                nowaKsiazka.rozdzialy = new List<Rozdzial>();

                while (true)
                {
                    Rozdzial rozdz = new Rozdzial();
                    Console.WriteLine("Dodaj tytuł rozdziału: ");
                    rozdz.tytul = Console.ReadLine();
                    Console.WriteLine("Dodaj stronę poczatkową: ");
                    rozdz.stronaPoczatkowa = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dodaj il. stron: ");
                    rozdz.iloscStron = int.Parse(Console.ReadLine());

                    nowaKsiazka.rozdzialy.Add(rozdz);

                    Console.WriteLine("Wyjscie k, enter dalej: ");
                    if (Console.ReadLine() == "k")
                    {
                        break;
                    };
                }

                biblioteka.Add(nowaKsiazka);

                Console.WriteLine("Wyjscie q, enter dalej: ");
                if (Console.ReadLine() == "q")
                {
                    break;
                };
            }

            foreach (var item in biblioteka)
            {

                Console.WriteLine("Książka: tytuł - {0}, Autor {1}, rok wydania {2}, ilość rozdziałów:{3}",
                    item.tytul, item.autor, item.rokWydania, item.rozdzialy.Count());

            }
        }
    }

    struct Ksiazka
    {
        public string tytul;
        public string autor;
        public int rokWydania;
        public string ISBN;
        public bool zniszczona;
        public List<Rozdzial> rozdzialy;

    }
    struct Rozdzial
    {
        public string tytul;
        public int stronaPoczatkowa;
        public int iloscStron;
    }


}
