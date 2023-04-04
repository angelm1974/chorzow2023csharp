using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class genericDict
    {
        Dictionary<int, string> slownik = new Dictionary<int, string>();
        Dictionary<string, obywatel> ludzie=new Dictionary<string, obywatel>();

        public genericDict()
        {
            slownik.Add(1, "Sok");
            slownik.Add(2, "Zupa");


            Console.WriteLine(slownik[1].ToString());
            
            foreach (var key in slownik.Keys)
                Console.WriteLine(key.ToString());
        }


        public void wyszukiwanie()
        {

            obywatel ob1=new obywatel();
            ob1.pesel = "32reewrwewr";
            ob1.imieNazwisko = "Jan Nowak";
            ob1.dataurodzenia = new DateTime(2020,03,13);

            obywatel ob2 = new obywatel();
            ob2.pesel = "22reewrwewr";
            ob2.imieNazwisko = "Ola Kowalska";
            ob2.dataurodzenia = new DateTime(2010, 01, 21);

            ludzie.Add("adam1", ob1);
            ludzie.Add("ola11", ob2);

            //   object znaleziony = ludzie.FirstOrDefault(l => l.Key.StartsWith("adam"));
            //   object znaleziony = ludzie.FirstOrDefault(l => l.Value.dataurodzenia < (new DateTime(2011, 01, 23)));
        }

    }
    struct obywatel
    {
        public string pesel;
        public DateTime dataurodzenia;
        public  string imieNazwisko;
    }
}
