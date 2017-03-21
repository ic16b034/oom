using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Rechteck : Berechnungen
    {

        public float laenge_rechteck { get; }
        public float breiteRechteck { get; }
        public float hoeheRechteck { get; }

        public Rechteck(float laenge, float breite, float hoehe)
        {
            laenge_rechteck = laenge;
            breiteRechteck = breite;
            hoeheRechteck = hoehe;
    }

        public float grundfläche(float a, float b)
        {
            return a * b;
        }

        public float mantelfläche(float a, float b, float h)
        {
            return (a * b) * 2 + (a * h) * 2 + (b * h) + 2;
        }

        public float volumen(float a, float b, float c)
        {
            return a * b * c;
        }

        public void werbinich()
        {
            Console.WriteLine("Ich bin ein Rechteck");
        }
    }
}
