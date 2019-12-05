using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

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

        public void insert(string query)
        {
            SqlConnection sql = new SqlConnection(con);
            SqlCommand command = new SqlCommand(query,sql);
            sql.Open();
            command.ExecuteNonQuery();

        }

        //2a
        public DataTable searchForName(string nameLike) {
            string sql = $"select * from Udlejer were Name like '{nameLike}'";

            using (SqlConnection connection = new SqlConnection(con))
            {
                DataTable dt = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(sql,connection))
                {
                    connection.Open();
                    adapter.Fill(dt);
                }
                return dt;
            }
            




        }

        



        public SqlAccess()
        {

        }
    }
    
    
}
