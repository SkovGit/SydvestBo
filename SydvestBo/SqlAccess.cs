using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;

namespace SydvestBo
{
    public class SqlAccess
    {

        private static readonly string con = ConfigurationManager.ConnectionStrings["SydvestBoDB"].ConnectionString;
        
        public static bool ConnectionOK()
        {
            
            using (SqlConnection cnn = new SqlConnection(con))
            {

                try
                { 
                    cnn.Open();
                    Console.WriteLine("Der er forbindelse til DB!");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }




        public SqlAccess()
        {

        }
    }
    
    
}
