using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;

namespace SydvestBo
{
    class Starter
    {
        public static void Main(string[] args)
        {
            // Herfra startes applikationen ved at instantiere UI klassen

            
            SqlAccess.ConnectionOK();
            
            
            
        }
    }
}
