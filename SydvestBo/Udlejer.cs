using System;
namespace SydvestBo
{
    // Klasse til at manipulere data fra Udlejertabellen i databasen
    public class Udlejer
    {
        public int UdlejerId { get; set; }
        public int Cpr { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Adresse { get; set; }
        public int Postnr { get; set; }
        public DateTime DatoOprettet { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }


        public Udlejer()
        {
        }
    }
}
