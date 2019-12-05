using System;
using System.Collections.Generic;

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
        public string DatoOprettet { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public PostNrBy Bynavn;


        public List<Udlejer> udlejerListe = new List<Udlejer>();
        public string FullUdlejer
        {
            get
            {
                return $" { UdlejerId } { Fornavn } { Efternavn } { Adresse } { Postnr }" +
                    $"{ DatoOprettet } { Email } {Telefon} ";
            }
        }

        public Udlejer()
        {
            
        }
        public void opretUdlejer()
        {
            Udlejer udl1 = new Udlejer();
            Console.WriteLine( "indtast følgende oplysninger: ");
            Console.Write("\nCpr nummer: ");
            udl1.Cpr = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nFornavn: ");
            udl1.Fornavn = Console.ReadLine();
            Console.WriteLine("\nEfternavn");
            udl1.Efternavn = Console.ReadLine();
            Console.WriteLine("\nAdresse");
            udl1.Adresse = Console.ReadLine();
            Console.WriteLine("\n Postnummer");
            udl1.Postnr = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nEmail");
            udl1.Email = Console.ReadLine();
            Console.WriteLine("\nTelefon");
            udl1.Telefon = Console.ReadLine();

            udlejerListe.Add(udl1);

        }

        

        public void visUdlejer()
        {
            int i = 1;
            foreach (var item in udlejerListe)
            {
                Console.WriteLine($"Udlejer{i}\n{item.ToString()}\n");

                i++;
            }
        }
        

        public Udlejer(int cpr, string fnavn, string enavn, string adr, int postnr, string email, string telefon)
        {
            Cpr = cpr;
            Fornavn = fnavn;
            Efternavn = enavn;
            Adresse = adr;
            Postnr = postnr;
            Email = email;
            Telefon = telefon;
            DatoOprettet = "default";

        }

        public override string ToString()
        {
            return $@"Cpr: {Cpr}
Fornavn: {Fornavn}
Efternavn: {Efternavn}
Adresse: {Adresse}
PostNr: {Postnr}
Email: {Email}
Telefon {Telefon}";
        }
    }
}
