using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Würfel : Form 
    {

        public float seitenlaengeWuerfel { get; }

        public Würfel(float seitenlaenge)
        {
            seitenlaengeWuerfel = seitenlaenge;
        }

        public void werbinich()
        {
            Console.WriteLine("Ich bin ein Würfel");
        }
    }
}
