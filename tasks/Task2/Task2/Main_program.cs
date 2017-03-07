using System;
using System.Linq;


namespace Task2
{
    class Main_program
    {
        public static void Main(string[] args)
		{
            var studenten = new[]
        { 
            new Studenten("Friedrich", "Nemec", "27.11.1981", "XXX"),
            new Studenten("Anoton", "Huber", "01.10.192", "YYY"),
            new Studenten("Robert", "Franzen", "20.01.1971", "ZZZ"),
            new Studenten("Anna", "Berger", "07.03.1990", "VVV"),
            new Studenten("Leo", "Hauer", "06.04.1995", "WWW")
        }; 
 
 
 			foreach (var student in studenten) 
 			{ 
 				Console.WriteLine(  "Name: "+student.Vorname +" "+ student.Nachname +"\n" + 
                                    "Geburtsdatum: "+ student.Geburtsdatum +"\n" + 
                                    "Lieblingsfach: "+student.Lieblingsfach+"\n" + 
                                    "Matrikelnummer: "+ student.Matrikelnummer+"\n" ); 
 			} 
 
		} 

       
    }
}
