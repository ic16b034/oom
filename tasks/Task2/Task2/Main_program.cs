using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            
            var koerper = new[]
            {
                new Rechteck("Test_1",2,1,1),
                new Rechteck("Test_2",2,1,1),
                new Rechteck("Test_3",1,1,2),
                new Rechteck("Test_4",3,1,1)

            };
       
            string s = JsonConvert.SerializeObject(koerper);
            Console.WriteLine(s);

            Rechteck[] rechtecke = JsonConvert.DeserializeObject<Rechteck[]>(s);
           
            foreach (var x in rechtecke) 
 			{
                Console.WriteLine("Name: " + x.nameRechteck + "Länge: " + x.laengeRechteck + "Breite: " + x.breiteRechteck + "Höhe: " + x.hoeheRechteck);
 			}

        }


    }
}
