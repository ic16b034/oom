using System; 
using System.Collections.Generic; 
using System.Globalization; 
using System.Net; 

 
 namespace Task2
 { 
 	public class Studenten
    { 

        private static int zaehler  = 1000;

        public Studenten(string vorname, string nachname, string geburtsdatum, string lieblingsfach)
 		{ 
             
			Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
            Lieblingsfach = lieblingsfach;

            Matrikelnummer = zaehlerup(1);

        } 

        public int zaehlerup(int x)
 		{
            zaehler = zaehler + 1;
            return zaehler;
 		} 
 

 		public string Vorname { get; }
        public string Nachname { get; }
        public string Geburtsdatum { get; }
        public string Lieblingsfach { get; }
        public int Matrikelnummer { get; }


    } 
} 

