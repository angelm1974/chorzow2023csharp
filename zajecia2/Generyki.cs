using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class Generyki
    {
        List<string> mojaLista=new List<string>();
        public void tworzGeneryki()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Podaj imię osoby: ");
                string osoba = Console.ReadLine();
                mojaLista.Add(osoba);

                Console.WriteLine("Wyjscie q, enter dalej: ");
                 if (Console.ReadLine() =="q" )
                    {
                    break;
                };
            }

            foreach (var item in mojaLista)
            {
                Console.WriteLine("Podane imię: {0}", item);
            }
        }
    }
}
