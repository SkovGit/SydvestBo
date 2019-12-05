using System;
using System.Reflection;

namespace SydvestBo
{
    public class Kontrakt
    {
        public int Id { get; set; }
        public string Adresse { get; set; }
        public int Postnr { get; set; }
        public int UdlejerID { get; set; }
        public string Kontrakttype { get; set; }

        public Kontrakt()
        {
        }

        public void hentUdlejer()
        {
            //retunere datatabeller
        }
        public void hentFeriebolig()
        {
            //
        }
        public void opretKontrakt()
        {

            Kontrakt kt1 = new Kontrakt();
            Console.WriteLine("indtast følgende oplysninger: ");
            Console.Write("\nAdresse");
            kt1.Adresse = Console.ReadLine();
            Console.WriteLine("\nPostnummer");
            kt1.Postnr = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nUdlejerID");
            kt1.UdlejerID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nKontraktType");
            kt1.Kontrakttype = Console.ReadLine();

        }

    }
}
