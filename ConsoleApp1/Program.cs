using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model1Container model1 = new Model1Container();
            model1.ksiazkaSet.Add(new ksiazka() { isbn = "sadas", autor = "adam", rok_wydania = 1993, tytul = "Brak tytułu" });
            model1.SaveChanges();
        }
    }
}
