using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AplikacjaPokazowa
{
    internal class Obliczenia
    {
        public Obliczenia() {
            Console.WriteLine("to jest podstawowa wersja");
        }
        public Obliczenia(string name) {
            Console.WriteLine("to jest string {0}", name);
        }

        public static void policz(int a,int b)
        {
            Console.WriteLine(a + b);
            policz_dobrze(a, b);
        }


        static void policz_dobrze(int a, int b)
        {
            Console.WriteLine(a + b + 1);
        }

    }

    enum DniTygodnia
    {
        Poniedziałek=1,
        Wtorek,
        Środa,
        Czwartek,
        Piątek,
        Sobota,
        Niedziela
    }
}
