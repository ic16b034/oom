using System;
using System.Linq;


namespace Task2
{
    class Main_program
    {
        public static void Main(string[] args)
		{
            var koerper = new[]
        { 
            new Geometrie("Quadrat", "2D", 10, 20, 0, 0),
            new Geometrie("Pyramide", "3D", 5, 5, 10, 0),
            new Geometrie("Kreis", "2D", 0, 0, 0, 1),

        };

            Berechnungen rechteck = new Rechteck(1, 1, 1);
            Berechnungen wuerfel = new Würfel(1, 1, 1);


            foreach (var kor in koerper) 
 			{
                Console.WriteLine("Form: " + kor.Form + "\n" +
                                   "Dimesion: " + kor.Dimension + "\n" +
                                   "Länge: " + kor.Laenge + "\n" +
                                   "Breite: " + kor.Breite + "\n" +
                                   "Höhe: " + kor.Hoehe + "\n" +
                                   "Radius: " + kor.Radius + "\n");
 			} 
 
		} 

       
    }
}
