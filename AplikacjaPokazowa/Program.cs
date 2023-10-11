using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPokazowa
{
    internal class Program
    {
        const int stala1 = 444;
        static void Main(string[] args)
        {
            //Implicit type conversion
            //Niejawna();
            //Explicit type conversion
            //Jawna();
            //warunki(int.Parse(Console.ReadLine()),Console.ReadLine());
            //petle();
            //tablice();
            //dodawanie();

            //foreach (Ksiazka x in ksiazki) 
            //{
            //    Console.WriteLine(x.autor);
            //    Console.WriteLine(x.strony.Count());
            //    Console.WriteLine("Ilość słów na poszczególnych stronach:");
            //    foreach (Strona s in x.strony)
            //    {
            //        Console.WriteLine(s.numer + "-" + s.ilosc_slow);

            //        Console.WriteLine("il. OBRAZÓW: " + (s.ilosc_obrazkow ?? 0));
            //    }

            //}
            //int a = 32;
            //int b = 32;

            //var intowa = MetodaGeneryczna<int>(a+b);
            //Console.WriteLine(intowa);

            //var stringowa = MetodaGeneryczna<string>(a.ToString()  + b.ToString());
            //Console.WriteLine(stringowa);

            int wynik = sumuj(2, 5);
            Console.WriteLine("WYNIK: " + wynik);
            Console.ReadLine();

        }

        private static void Niejawna()
        {
            int mojawartosc1 = 10;
            byte mojawartosc2 = 14;

            mojawartosc1 = mojawartosc2;
            Console.WriteLine(mojawartosc1);
            Console.ReadLine();
        }

        private static void Jawna()
            {
            double mojaliczba = 32432.324;
            int i;
            i = (int)mojaliczba;
            Console.WriteLine(i);
            Console.ReadLine();
            
            }

        private static void czas()
        {
            DateTime date1 = DateTime.Now;
            string dane= Convert.ToString(date1);
            Console.WriteLine(dane);
            Console.ReadLine();
        }

        private static void zmienne()
        {
            int? a= null;
            int b = a ?? -1;
            Console.WriteLine(b);
            Console.ReadLine();
            
        }

        private static void stale()
        {
            float a = 23.44F;
            string d= "podzielone to znak  i już";
        }
        private static void operatory()
        {
            int a = 4;
            int b = 2;
            Console.WriteLine(!(a<0 || b>0));
            Console.WriteLine(sizeof(int));
            Console.ReadLine();
 
        }
        private static void warunki(int zmienna,string zm2)
        {
 
            //int x =21, y = 20;
            ////var result = x>y ? 1 : 0;
            ////Console.WriteLine(result);

            //if (x > y)
            //{
            //    Console.WriteLine("X jest większy od y");
            //}
            //else if (x==y)
            //{
            //    Console.WriteLine("X jest równy y");

            //}
            //else
            //{
            //    Console.WriteLine("X mniejszy od y");
            //        }

            switch (zmienna)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    switch (zm2)
                    {
                        case "A":
                            Console.WriteLine("to jesst a");
                            break;
                        case "B":
                            Console.WriteLine("to jesst b");
                            break;
                        default:
                            Console.WriteLine("to jest nie wiem co");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("trzy");
                    break;
                default:
                    Console.WriteLine("kto to wie");
                    break;
            }

            Console.ReadLine();
        }

        private static void petle()
        {
            //int i = 1;

            ////while (a<=20)
            ////{
            ////    Console.WriteLine("liczba to: {0}", a);
            ////    a--;
            ////}
            ////
            //int length = 100;

            //for (int i = 0; i <= length; i++)
            //{
            //    Console.WriteLine("liczba to: {0}", i);
            //}

            //do
            //{
            //    Console.WriteLine("liczba to: {0}", i);
            //    i++;
            //}
            //while (i < 100);

            //Console.ReadLine();

            ;

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 10; j >= 1; j--)
            //    {
            //        Console.WriteLine("{0}, {1}", i, j);
            //    }

            //}
            
            while (true) {
                Console.WriteLine("Czy chcesz grać dalej? y/n");
                string odp = Console.ReadLine().ToLower();
                if (odp != null)
                {
                    if (odp == "n")
                    {
                        break;
                    }
                }
            }
            //Console.ReadLine();
        }

        struct Ksiazka
        {
            public Ksiazka(string tytul,
            string autor,
            string opis,
            int rok_wydania,
            int identyfikator,
            DniTygodnia dzien,
            List<Strona>strony)
            {
                this.tytul = tytul.ToUpper();
                this.autor = autor.ToLower();
                this.opis = opis;
                this.rok_wydania = rok_wydania;
                this.identyfikator = identyfikator;
                this.strony = strony;
                this.dzien = dzien; 
            }

            public string tytul;
            public string autor;
            public string opis;
            public int rok_wydania;
            public int identyfikator;
            public List<Strona> strony;
            public DniTygodnia dzien;
        }


        struct Strona {
            public int numer;
            public int ilosc_slow;
            public int? ilosc_obrazkow;
        }


        static List<Ksiazka> ksiazki = new List<Ksiazka>();

        static void dodawanie()
        {
            Ksiazka ks1;
            Ksiazka ks2;

            ks1.autor = "Minister Czarnek";
            ks1.rok_wydania = 2002;
            ks1.opis = "Ksiązka o matematyce";
            ks1.tytul = "Matematyka dla klas 1-2";
            ks1.identyfikator = 1;
            ks1.strony = new List<Strona>();
            ks1.strony.Add(new Strona() { ilosc_obrazkow = 2, ilosc_slow = 23, numer = 1 });
            ks1.strony.Add(new Strona() { ilosc_obrazkow = 4, ilosc_slow = 43, numer = 2 });
            ks1.strony.Add(new Strona() { ilosc_obrazkow = 6, ilosc_slow = 233, numer = 3 });
            ks1.dzien = DniTygodnia.Poniedziałek;
            ksiazki.Add(ks1);
            
            ks2.autor = "ola";
            ks2.rok_wydania = 2022;
            ks2.opis = "Ksiązk21212a o matematyce";
            ks2.tytul = "Matematyka212dla klas 1-2";
            ks2.identyfikator = 2;
            ks2.dzien = DniTygodnia.Piątek;
            ks2.strony = new List<Strona>();
            ks2.strony.Add(new Strona() { ilosc_obrazkow = null, ilosc_slow = 23, numer = 1 });
            ksiazki.Add(ks2);

            
            List<Strona> dlaKsiażki3 = new List<Strona>();
            dlaKsiażki3.Add(new Strona() { ilosc_obrazkow = 2, ilosc_slow = 23, numer = 1 });
            
            Ksiazka ks3 = new Ksiazka("Start","Brak","Abc",1922,1,DniTygodnia.Środa,dlaKsiażki3);
            ksiazki.Add(ks3);
        }

        public static void tablice()
        {
            double[] mojatablica;
            double[] platnosci=new double[10] {3,2,1,1,1,1,1,1,5,6};
            platnosci[0] = 12.33;
            Strona[] mojestrony = new Strona[2] { new Strona() { ilosc_obrazkow = 2, ilosc_slow = 23, numer = 3 }, new Strona() { ilosc_obrazkow = 1, ilosc_slow = 223, numer = 1 } };
            System.Array.Resize<Strona>(ref mojestrony, 4);

            int[,] macierz = new int[2, 2] { { 1, 1 }, { 2,2} };


            int[][] tbl = new int[][]
            {
                new int[] { 1, 1,},
                new int[] { 1, 1,4,5,6 },

            };
        }

        public static T MetodaGeneryczna<T>(T parametr)
        {
            return parametr;
        }

        static int sumuj(int a, int b)
        {
            return a + b;
        }
    }
}
