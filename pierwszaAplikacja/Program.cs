using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pierwszaAplikacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Slonko("Uruchomił się! " + Math.PI);
            Slonko("Abc");
            Console.ReadKey();
        }

        static void Slonko(string liczba) 
        { 
            Console.WriteLine(liczba);
        }
    }
}
