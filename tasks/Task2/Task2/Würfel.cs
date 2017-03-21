using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Würfel : Berechnungen 
    {

        public float seitenlaengeWuerfel { get; }

        public Würfel(float seitenlaenge)
        {
            seitenlaengeWuerfel = seitenlaenge;
        }


        public float grundfläche(float a, float b)
        {
            return a * b;
        }

        public float mantelfläche(float a, float b, float c)
        {
            return (a * a) * 6;
        }

        public float volumen(float a, float b, float c)
        {
            return a * a * a;
        }

        public void werbinich()
        {
            Console.WriteLine("Ich bin ein Würfel");
        }
    }
}
