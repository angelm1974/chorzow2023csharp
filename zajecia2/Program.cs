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
            //Rectangle r1 = new Rectangle();
            //r1.WyswietlPodsumowanie();
            //r1.mojByte = 0;
            //r1.mojChar = 'a';
            //r1.mojDecimal = 0.23M;
            //r1.mojFloat = 230.4F;
            //r1.mojInt = 567215332;
            //r1.mojLong = 783283764368L;
            //r1.mojSByte = -123;
            //r1.mojShort = -32768;


            //Przykład opakowania zmiennej różnych typów w obiekt -referencyjnie
            //int liczba = 10;

            //object ob = liczba;

            //ob = "12";

            //Console.WriteLine(ob);
            //int liczba2 = (int)ob;

            dynamic liczba = 23;

            liczba =  Convert.ToString(liczba) + "abc";
            Console.WriteLine(liczba);
            Console.ReadLine();
        }
    }

    class Rectangle
    {
        public double x { get ; set; }
        public bool light { get; set; } //false/true
        public byte mojByte { get; set; } //0-255
        public char mojChar { get; set; } //16 bitowy znak U + 0000 do U +ffff
        public decimal mojDecimal { get; set; } //128 bitowy za liczbą wstawiamy M
        public double y { get; set; } //-3.4 x 10^38 do + 3.4 x 10^38
        public float mojFloat { get; set; } //32 bitowy za liczbą wstawiamy F
        public int mojInt { get; set; } //32 bitowy liczb całkowitych
        public long mojLong { get; set; } //64 bitowy liczb całkowitych za liczbą wstawiamy L
        public sbyte mojSByte { get; set; } // od -127 do 127
        public short mojShort { get; set; } //-32768 do 32767
        public uint mojUInt { get; set; } //32 bity 0 do 4294967295
        public ulong mojULong { get; set; } //64 bitowy liczb dodatnich 0 do 8446744073709551615
        public ushort mojUShort { get; set; } //0 do 65535
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
            Console.WriteLine("Szerokość: {0}", y);
            Console.WriteLine("Rectangle field : " + CalculateRectangleField());
        }
    }
}
