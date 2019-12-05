using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;
using System.Text;

namespace SydvestBo
{
    class MainClass
    {
        

        public static void Main(string[] args)
        {
            //bruger utf8 for hele programmet
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Herfra startes applikationen ved at instantiere UI klassen

            var kør = new UIface();
            kør.KørMenu();

			Console.ReadKey();
            SqlAccess.ConnectionOK();
            Udlejer Henrik = new Udlejer();
            Henrik.Fornavn = Console.ReadLine();
            Henrik.Efternavn = Console.ReadLine();

            SqlAccess access = new SqlAccess();
            access.insert($"insert into Udlejer values('{Henrik.Fornavn}','{Henrik.Efternavn}')");
            
            
        }
    }
}
