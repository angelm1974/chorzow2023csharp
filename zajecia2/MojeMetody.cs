using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class MojeMetody
    {
        public string ZnajdzMaksimum(int a, int b)
        {
            string wynik;
            if (a > b)
            {
                wynik = a.ToString();
            }
            else if(b == a) 
            {
                wynik = "Liczby są równe";
            }
            else 
            {
                wynik = b.ToString();

            }
            return wynik;

        }

        public int? ObliczSilnie(int liczba)
        {
            int? wynik=null;
            if (liczba == 1) {
                return 1;
            }
            else
            {

                wynik = ObliczSilnie(liczba - 1) * liczba;
                return wynik;
            }
        }
    }


}
