using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static List<Klient>Klienci=new List<Klient>();
        static void Main(string[] args)
        {
            Klient c1 = new Klient();
            c1.Name = "Adam";
            c1.Description = "Dostawca";
            c1.City = "Katowice";
            Klienci.Add(c1);
            Klient c2 = new Klient();
            c2.Name = "Mariusz";
            c2.Description = "Odbiorca";
            c2.City = "Warszawa";
            Klienci.Add(c2);

            Klient c3 = new Klient();
            c3.Name = "Jan";
            c3.Description = "Dostawca";
            c3.City = "Katowice";
            Klienci.Add(c3);
            Klient c4 = new Klient();
            c4.Name = "Mariusz";
            c4.Description = "Dostawcą";
            c4.City = "Warszawa";
            Klienci.Add(c4);



            var kwerenda = from k in Klienci 
                           group k by k.City;

            
            
            
            //wykonanie kwerendy

            foreach (var grupa in kwerenda)
            {
                Console.WriteLine(grupa.Key);
                foreach (Klient item in grupa)
                {
                    Console.WriteLine("  - " + item.Name);
                }
            }

            Console.ReadLine();
        }

        static void abc()
        {
            List<string> words = new List<string>() { "an", "apple", "a", "day" };
            var query = from word in words
            select word.Substring(0, 1);

            foreach (string s in query)
            { Console.WriteLine(s); }

        }

    }
    struct Klient
    {
        public int Id;
        public string Name;
        public string Description;
        public string City;
    }
}
