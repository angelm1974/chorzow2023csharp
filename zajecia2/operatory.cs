using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    internal class operatory
    {
        public void Operator()
        {
            float a = 12.34f;
            float b = 7.66f;

            //OPERATORY ARYTMETYCZNE
            float wynik = a + b; //dodawanie argumentów
            wynik = a - b; //odejmowanie argumentów
            wynik = a * b; //mnożenie argumentów
            wynik = a / b; //dzielenie z resztą
            wynik = a % b; //modulo
            a++; //inkrementacja o 1
            a += 4; //ikrementujemy o 4
            a--; //dekrementacja
            a -= 4; //dekrementacja o 4

            //OPERATORY RELACYJNE
            bool czy_prawda;
            czy_prawda = a==b; // operator porównania true albo flase
            czy_prawda = a != b; //prównanie ale odwrotne czyli jak jest równe to bedzie false
            czy_prawda = a > b; //sprawdzenie czy ajest wieksze od b
            czy_prawda = a < b; //sprawdzenie czy a jest mniejsze od b
            czy_prawda = a >= b; //sprawdzenie czy a jest wieksze lub równe b
            czy_prawda = a <= b; //sprawdzenie czy a jest mniejsze lub równe b

            int O1 = 1;
            int O2 = 20;
            object dane;
            //OPERATORY LOGICZNE
            dane= O1==10 && O2==20; 
            dane= O1==10 || O2 == 20;

            if (O1 == 10 || O2 == 20)
            {
                Console.WriteLine("spełnione");
            }

            dane= !(O1 == 10 || O2 == 20);

            //OPERATORY PRZYPISANIA
            /*
             =  - do leweje strony przypisujemy wartosc po prawej
             += - dodawanie i przypisanie
             -=  -dekrementacja
             *= -multiplikacja, albo mnożenie z przypisaniem
             /= - dzielenie z przypisaniem
             %= -modulo z przypisaniem
             <<== przesunięcie bitów w lewo z przypisaniem
             >>== przesuniecie bitow w prawoz  przypisaniem
             &= bitowy zapis i
             ^= operacja xor - alternatywa wykluczająca
             |= operacja lub z przypisaniem 
             */

            //NOWE i INNE
            /*
            dane= sizeof(int);
            dane = typeof(int);
            & adres pamięci danej zmiennej
            * - wskaźnik do zmiennej
            ?: wyrażenie warunkowe
            is - sprawdzenie czy np zmienna jestr danego typu
            as -rzutowanie bez generowania wyjątku
             */
            
            var warunek = (10 < 4);
            int? qw = warunek ? 12 : (int?)null;
            dane = qw is int;
            
                }
    }
}
