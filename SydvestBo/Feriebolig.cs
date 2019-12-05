using System;
namespace SydvestBo
{
    // Klasse til at manipulere data fra Ferieboligtabellen i databasen
    public class Feriebolig
    {
        public string Adresse { get; set; }
        public int Postnr { get; set; }
        public int UdlejerId { get; set; }
        public DateTime OpretDato { get; set; }
        public string BoligType { get; set; }
        public int BoStatus { get; set; }
        public int Kalender { get; set; }


        public Feriebolig()
        {
            //Tom constructor
        }
        public void OpretFeriebolig()
        {
            Feriebolig fb1 = new Feriebolig();
            Console.WriteLine("indtast følgende oplysninger: ");
            Console.WriteLine("\nUdlejerID");
            fb1.UdlejerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPostnummer");
            fb1.Postnr = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("BoligType");
            fb1.BoligType = Console.ReadLine();
            Console.WriteLine("BoligStatus");
            fb1.BoStatus = Convert.ToInt32(Console.ReadKey());
        }
    }
}
