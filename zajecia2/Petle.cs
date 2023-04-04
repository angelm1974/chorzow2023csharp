using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class Petle
    {
        public void petlaWhile()
        {
            int i = 0;

            while (true)
            {
                Console.WriteLine("Krok w pętli {0}", i);
                i++;
                Console.WriteLine("czy zakończyć program? ");
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.KeyChar.ToString().ToLower() == "y")
                {
                    break;
                }
            }
        }

        public void petlaFor(int length) {

            //for (int i = 0; i < length; i++)
            for (int i = length; i > 0; i--)
            {
                Console.WriteLine("Krok w pętli for {0}", i);
            }
        
        }
        
        public void petlaDoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Krok w pętli dowhile {0}", i);
                i++;
            }
            while (i < 10);
    
        }
        //1,1 2,2 3,3
        //1,3 2,2 3,1

        public void zagniezdzaniePetli()
        {
            int i = 0;
            int j = 10;

            while ( i < 4) {
                j = 10;
                while (j > 0) {
                    Console.WriteLine("({0},{1})",i,j);
                    j--;
                }
                i++;
            }
        }

        public void petlaforEach()
        {
            string[] samochody = { "Opel", "Volvo", "Mazda" };
            
            foreach (string samochod in samochody){
                Console.WriteLine("Ten samochód " + samochod + " jest szybki");
            }
        }

        public void szachyPlansza()
        {
            string[] litery= { "A", "B", "C", "D", "E", "F", "G", "H" };
             for (int i = 8; i >0; i--)
                {

                foreach (var item in litery)
                {
                    Console.Write("{0}{1}, ",item,i);
                }
                Console.Write("\n");
               
            }
        }

    }
}
