using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class typy_puste
    {
        int? num1 = null;
        public static void puste()
        {
            double? mojdouble = new double?();
            double? mojdouble2 = 3.141;
            Console.WriteLine(mojdouble2.ToString());
        }

        public void porownanie_pustych()
        {
            double? l1 = null;
            double? l2=3.141;
            double l3=new double();

            l3 = l1 ?? 5.33;
            l3 = (double)(l1 ?? l2);
            Console.WriteLine(l3.ToString());

        }
    }
}
