using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;


namespace SydvestBo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Herfra startes applikationen ved at instantiere UI klassen

            
            SqlAccess.ConnectionOK();
            Udlejer Henrik = new Udlejer();
            Henrik.Fornavn = Console.ReadLine();
            Henrik.Efternavn = Console.ReadLine();

            SqlAccess access = new SqlAccess();
            access.insert($"insert into Udlejer values('{Henrik.Fornavn}','{Henrik.Efternavn}')");
            
            
            var kør = new UIface();

            kør.KørMenu();

            
            SqlAccess.ConnectionOK();
            Udlejer Henrik = new Udlejer();
            Henrik.Fornavn = Console.ReadLine();
            Henrik.Efternavn = Console.ReadLine();

            SqlAccess access = new SqlAccess();
            access.insert($"insert into Udlejer values('{Henrik.Fornavn}','{Henrik.Efternavn}')");
            
            
        }
    }
}
