using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    public class Hermetyzacja
    {
        public void Otwarty() {
        }
        private void Zamkniety() { }

        protected void Dziedziczona() { }

        internal void wBibliotece() { }

        protected internal void miksowa() { }

        public void jedzMieso() {
            Console.WriteLine("jedz");

        }
    }
}
