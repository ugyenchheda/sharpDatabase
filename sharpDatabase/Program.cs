﻿using System;
using System.Data.SqlClient;

namespace OOPTask13
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Dentist;Integrated Security=true;";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string insertNew = "INSERT INTO Dentist (Name, TelNum) VALUES (@newName, @newTelNum)";
                    SqlCommand command = new SqlCommand(insertNew, sqlConnection);
                    SqlParameter sqlParameter = new SqlParameter
                    {
                        ParameterName = "@newName",
                        Value = "Reijo Vuohelainen",
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    };
                    command.Parameters.Add(sqlParameter);





                    sqlParameter = new SqlParameter
                    {
                        ParameterName = "@newTelNum",
                        Value = "040 1119991",
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    };
                    command.Parameters.Add(sqlParameter);
                    int numberOfRows = command.ExecuteNonQuery();
                    if (numberOfRows > 0)
                        Console.WriteLine("Successfully inserted information.");
                    else if (numberOfRows == 0)
                        Console.WriteLine("No such employee in the company.");

                    //Did anything go to the database table?

                    Console.WriteLine("After possibly inserting a row:");
                    string queryString = "SELECT * FROM Dentist";
                    command = new SqlCommand(queryString, sqlConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0}, {1}, {2}",
                                reader[0], reader[1], reader[2]));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
