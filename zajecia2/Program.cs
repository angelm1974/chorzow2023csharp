using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.WyswietlPodsumowanie();
          
            
            Console.ReadLine();
        }
    }

    class Rectangle
    {
        public double x { get; set; }
        public double y { get; set; }

        public Rectangle()
        {
            Console.WriteLine("Podaj pierwszy bok: ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugi bok: ");
            y = double.Parse(Console.ReadLine());
        }

        double CalculateRectangleField()
        {
            return x * y;
        }

        public void WyswietlPodsumowanie()
        {
            Console.WriteLine("Długość: {0}", x);
            Console.WriteLine("Szerokość: {1}", y);
            Console.WriteLine("Rectangle field : " + CalculateRectangleField());
        }
    }
}
