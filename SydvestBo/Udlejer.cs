using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Reflection;
using System.Linq;
=======
>>>>>>> 0d0617eb54bd9a43d3d5ee7f1d1b2683974421d4

namespace SydvestBo
{
    // Klasse til at manipulere data fra Udlejertabellen i databasen
    public class Udlejer
    {
<<<<<<< HEAD
        UIface uiface = new UIface();

        public int GetUnderKat { get; set; }
        public int GetOverKat { get; set; }
=======
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

        public string FullUdlejer
        {
            get
            {
                return $" { UdlejerId } { Fornavn } { Efternavn } { Adresse } { Postnr }" +
                    $"{ DatoOprettet } { Email } {Telefon} ";
            }
        }

        UIface uiface = new UIface();

namespace SydvestBo
{
    // Klasse til at manipulere data fra Udlejertabellen i databasen
    public class Udlejer
    {
<<<<<<< HEAD
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

        public string FullUdlejer
        {
            get
            {
                return $" { UdlejerId } { Fornavn } { Efternavn } { Adresse } { Postnr }" +
                    $"{ DatoOprettet } { Email } {Telefon} ";
            }
        }

>>>>>>> 0d0617eb54bd9a43d3d5ee7f1d1b2683974421d4
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
        public void PlayTask()
        {
            string methodName = $"{uiface.UnderKats[GetUnderKat]}";

            Type thisType = this.GetType();
            MethodInfo myMethod = thisType.GetMethod(methodName);

            try
            {

                myMethod.Invoke(this, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }

            Console.Clear();

        }
        List<string> opret = new List<string> { "Navn       :", "Cpr        :", "Postnummer :", "Email      :", "Telefon    :" };
        List<string> gemOpretInput = new List<string>();

        public void Opret()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            List<int> gemOpretTop = new List<int>();
            List<int> gemOpretBredde = new List<int>();
            for (int i = opret.IndexOf(opret.First<string>()); i <= opret.IndexOf(opret.Last<string>()); i++)
            {
                Console.Write(opret[i]);
                gemOpretTop.Add(Console.CursorTop +1);
                gemOpretBredde.Add(Console.CursorLeft +2);
                
                Console.WriteLine();
                


            }
            for (int i = opret.IndexOf(opret.First<string>()); i <= opret.IndexOf(opret.Last<string>()); i++)
            {
                Console.SetCursorPosition(gemOpretBredde[i], gemOpretTop[i]);
                gemOpretInput.Add(Console.ReadLine());

            }
            Console.ReadKey();
        }



        public void Vis()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();
            
            for (int i = opret.IndexOf(opret.First<string>()); i <= opret.IndexOf(opret.Last<string>()); i++)
            {
                Console.Write(opret[i]);
                Console.WriteLine(gemOpretInput[i]);
            }
            Console.ReadKey();
        }
        public void Slet()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public void Opdater()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }

    }
}