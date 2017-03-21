using System;
using System.Linq;


namespace Task2
{
    class Main_program 
    {
         public static void Main(string[] args)
         {
            var wuerfel = new[]
        {
             new Würfel(1),
             new Würfel(2),
             new Würfel(3),
             new Würfel(4)

         };

            var rechtecke = new[]
            {
                new Rechteck(2,1,1),
                new Rechteck(1,2,1),
                new Rechteck(1,1,2),
                new Rechteck(3,1,1)

             };


            foreach (var wuer in wuerfel) 
 			{
                wuer.werbinich();
                Console.WriteLine("Sseitenlänge: " + wuer.seitenlaengeWuerfel + "\n");
 			}

            foreach (var rechteck in rechtecke)
            {
                rechteck.werbinich();
                Console.WriteLine("Länge: " + rechteck.laengeRechteck + "\n");
            }
        } 

       
    }
}
