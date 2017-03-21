using System; 
using System.Collections.Generic; 
using System.Globalization; 
using System.Net; 

 
 namespace Task2
 { 
 	public class Geometrie
    { 

        private static int faktor  = 1;

        public Geometrie(string form, string dimension, float laenge, float breite, float hoehe, float radius)
 		{ 
             
			Form = form;
            Dimension = dimension;
            Laenge = laenge;
            Breite = breite;
            Hoehe = hoehe;
            Radius = radius;

        }

   


 		public string Form { get; }
        public string Dimension { get; }
        public float Laenge { get; }
        public float Breite { get; }
        public float Hoehe { get; }
        public float Radius { get; }

 
    } 
} 

