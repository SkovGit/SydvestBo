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
    }
}
