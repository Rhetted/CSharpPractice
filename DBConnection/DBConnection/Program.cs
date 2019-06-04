using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            // database configure
            const string connectionString = @"data source = RHETT-SURFACE\SQLEXPRESS; initial catalog = learnsql; Trusted_Connection = SSPI";
            using (var myCon = new SqlConnection(connectionString))
            {
                // open database
                myCon.Open();

                //database query
                try
                {
                    var myCommand = new SqlCommand("select * from Student where name = 'Bruce'", myCon);
                    var myReader = myCommand.ExecuteReader();
                    while(myReader.Read())
                    {
                        Console.WriteLine(myReader["Grade"].ToString());
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
