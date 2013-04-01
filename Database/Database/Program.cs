using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    class Program
    {

        static void Main(string[] args)
        {

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "";
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT *  FROM Table1 WHERE Name == 'Payam'";
                        connection.Open();

                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("This is the error: {0}", e);
                }

            }

            
           


        }
    }
}
