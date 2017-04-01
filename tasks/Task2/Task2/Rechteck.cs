using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rechteck : Form
    {

        public float laengeRechteck { get; }
        public float breiteRechteck { get; }
        public float hoeheRechteck { get; }
        public string nameRechteck { get; }

        public Rechteck(string name,float laenge, float breite, float hoehe)
        {
            laengeRechteck = laenge;
            breiteRechteck = breite;
            hoeheRechteck = hoehe;
            nameRechteck = name;
         }


        public void werbinich()
        {
            Console.WriteLine("Ich bin ein Rechteck");
        }
    }
}
