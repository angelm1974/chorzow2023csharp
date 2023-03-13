using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class jawnaKonwersja
    {
        double liczba = 2344.44;
        int i;

        public void Konwertuj()
        {
            i = 23;
            float f = 32.006f;
            bool b=false;
            
            i=(int)liczba;
            Decimal a = (Decimal)i;
            a= Convert.ToDecimal(i);
 
            Console.WriteLine(i.ToString()+"\n" + f.ToString() + "\n" + b.ToString());
 
        }
    }
}
