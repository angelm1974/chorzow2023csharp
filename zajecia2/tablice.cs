using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class tablice
    {
        double[] podatki;

        public void tworzenie_tablic()
        {
            podatki = new double[2];
            podatki[0] = 15624165.12;
            podatki[1] = 637.33;

            foreach (double podatek in podatki) 
            {
                Console.WriteLine("Mój podatek: "+ podatek);
            }
            Array.Resize(ref podatki, 10);
            podatki[7] = 324.33;
            double y= podatki.Min();

            string[,] nazwy;
            nazwy=new string[2, 2]
            {
                {"Adam","Olek" },
                {"Jola","Ania" }
            };

            //tablica postrzepiona
            int[][] a = new int[][]
            {
                new int[] { 1, 2},
                new int[] { 3, 4},
                new int[] { 5, 6}
            };

            Console.WriteLine(a[1][0]);
            Console.WriteLine(nazwy[1,1]);
            Console.WriteLine(y);
        }
    }
}
