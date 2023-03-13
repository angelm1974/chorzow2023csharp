using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class instrukcjeWarunkowe
    {
        public void WykonajIf()
        {
            var rand = new Random();
            var mojaLiczba = rand.Next(10);

            if (mojaLiczba>5)
            {
                Console.WriteLine("moja liczba to: {0}", mojaLiczba);
                if (mojaLiczba % 2 == 0)
                {
                    Console.WriteLine("i jest parzysta");
                }
            }
            else if (mojaLiczba == 5)
            {
                Console.WriteLine("moja liczba jest równa 5");
            }
            else
            {
                Console.WriteLine("moja liczba mniejsza od 5 to: {0}", mojaLiczba);
            }
        }

        public void WykonajSwitch(string imie)
        {
            switch (imie)
            {
                case "Adam":
                    Console.WriteLine("Cześć Adam!");
                    break;
                case "Olek":
                    Console.WriteLine("Siema Olek");
                    break;
                default:
                    Console.WriteLine("Dziwne imię!");
                    break;

            }
        }


    }
}
