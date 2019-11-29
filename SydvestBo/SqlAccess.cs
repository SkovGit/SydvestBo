using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;

namespace SydvestBo
{
    public class SqlAccess
    {

        //private static readonly string con = ConfigurationManager.ConnectionStrings["SydvestBoDB"].ConnectionString;
        private static readonly string con = "Server=tcp:sydvestbo.database.windows.net;Database=SydvestBo; User ID = h1root; Password=Sqlsydvestb0;Trusted_Connection=False;Encrypt=True;";


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
