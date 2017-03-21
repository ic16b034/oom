using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rechteck : form
    {

        public float laengeRechteck { get; }
        public float breiteRechteck { get; }
        public float hoeheRechteck { get; }

        public Rechteck(float laenge, float breite, float hoehe)
        {
            laengeRechteck = laenge;
            breiteRechteck = breite;
            hoeheRechteck = hoehe;
         }


        public void werbinich()
        {
            Console.WriteLine("Ich bin ein Rechteck");
        }
    }
}
