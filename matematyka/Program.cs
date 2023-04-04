using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace matematyka
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.Write("Podaj pierwszą liczbę całkowitą dodatnią: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Podaj drugą liczbę całkowitą dodatnią: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Wybierz operację arytmetyczną: \n '+' - dodawanie \t '-' - odejmowanie \n '*' - mnozenie  \t '/' - dzielenie \n '%' dzielienie modulo \t '^' - potegowanie");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (op)
                {
                    case '+':
                        Console.WriteLine("Wynik dodawania: " + (a + b));
                        break;
                    case '-':
                        Console.WriteLine("Wynik odejmowania: " + (a - b));
                        break;
                    case '*':
                        Console.WriteLine("Wynik mnożenia: " + (a * b));
                        break;
                    case '/':
                        if (b == 0)
                        {
                            Console.WriteLine("Nie można dzielić przez zero!");
                        }
                        else
                        {
                            Console.WriteLine("Wynik dzielenia: " + ((double)a / b).ToString("0.00"));
                        }
                        break;
                    case '%':
                        Console.WriteLine("Wynik modulo: " + (a % b));
                        break;
                    case '^':
                        Console.WriteLine("Wynik potegowania: " + Math.Pow(a, b));
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy znak operacji.");
                        break;
                }
                
                Console.WriteLine("Czy kontynuować?(t/n)");
                var odp= Console.ReadLine();
                if (odp != "t")
                {
                    Environment.Exit(0);
                }

                


            }
        }
    }
}
