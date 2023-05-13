using System;
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
                    string queryString = "SELECT * FROM Dentist";
                    SqlCommand command = new SqlCommand(queryString, sqlConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0}, {1}, {2}",
                                reader[0], reader[1], reader[2]));
                        }
                    }
                }

                //Insert Into Database

                //        string insertNew = "INSERT INTO Dentist (Name, TelNum) VALUES (@newName, @newTelNum)";
                //        SqlCommand command = new SqlCommand(insertNew, sqlConnection);
                //        SqlParameter sqlParameter = new SqlParameter
                //        {
                //            ParameterName = "@newName",
                //            Value = "Reijo Vuohelainen",
                //            SqlDbType = System.Data.SqlDbType.NVarChar
                //        };
                //        command.Parameters.Add(sqlParameter);

                //        sqlParameter = new SqlParameter
                //        {
                //            ParameterName = "@newTelNum",
                //            Value = "040 1119991",
                //            SqlDbType = System.Data.SqlDbType.NVarChar
                //        };
                //        command.Parameters.Add(sqlParameter);
                //        int numberOfRows = command.ExecuteNonQuery();
                //        if (numberOfRows > 0)
                //            Console.WriteLine("Successfully inserted information.");
                //        else if (numberOfRows == 0)
                //            Console.WriteLine("No such employee in the company.");

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


                // This will look for a person in database


                //    string findOne = "SELECT * FROM Dentist WHERE Name=@personInInterest";
                //    SqlCommand command = new SqlCommand(findOne, sqlConnection);

                //    SqlParameter sqlParameter = new SqlParameter
                //    {
                //        ParameterName = "@personInInterest",
                //        Value = "Reijo Vuohelainen",
                //        SqlDbType = System.Data.SqlDbType.NVarChar
                //    };
                //    command.Parameters.Add(sqlParameter);





                //    //Do we have the person????                 

                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        if (reader.HasRows)
                //        {
                //            while (reader.Read())
                //            {
                //                Console.WriteLine(String.Format("{0}, {1}, {2}",
                //                    reader[0], reader[1], reader[2]));
                //            }
                //        }
                //        else
                //            Console.WriteLine("No such employee here.");
                //    }
                //}



                //Modify information

                //    string modify = "UPDATE Dentist SET TelNum=@newTelNum WHERE Name=@dName";

                //    SqlCommand command = new SqlCommand(modify, sqlConnection);

                //    SqlParameter sqlParameter = new SqlParameter
                //    {
                //        ParameterName = "@dName",
                //        Value = "Jukka Ikonen",
                //        SqlDbType = System.Data.SqlDbType.NVarChar
                //    };

                //    command.Parameters.Add(sqlParameter);

                //    sqlParameter = new SqlParameter
                //    {
                //        ParameterName = "@newTelNum",
                //        Value = "050 12344444",
                //        SqlDbType = System.Data.SqlDbType.NVarChar
                //    };
                //    command.Parameters.Add(sqlParameter);

                //    int numberOfRows = command.ExecuteNonQuery();
                //    if (numberOfRows > 0)
                //        Console.WriteLine("Successfully updated information.");
                //    else if (numberOfRows == 0)
                //        Console.WriteLine("No such employee in the company.");

                //    //Did anything go to the database table?

                //    Console.WriteLine("After possibly updating information:");
                //    string queryString = "SELECT * FROM Dentist";
                //    command = new SqlCommand(queryString, sqlConnection);
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            Console.WriteLine(String.Format("{0}, {1}, {2}",
                //                reader[0], reader[1], reader[2]));
                //        }
                //    }
                //}


                //Delete from Database


                //  string remove = "DELETE FROM Dentist WHERE Name=@dName";

                //    SqlCommand command = new SqlCommand(remove, sqlConnection);

                //    SqlParameter sqlParameter = new SqlParameter
                //    {
                //        ParameterName = "@dName",
                //        Value = "Paula Oksanen",
                //        SqlDbType = System.Data.SqlDbType.NVarChar
                //    };
                //    command.Parameters.Add(sqlParameter);



                //    int numberOfRows = command.ExecuteNonQuery();
                //    //NOTICE: Go back to previous cases, and make a change!
                //    if (numberOfRows > 0)
                //        Console.WriteLine("Successfully removed information.");
                //    else if (numberOfRows == 0)
                //        Console.WriteLine("No such employee in the company.");

                    //Did anything go to the database table?

                   Console.WriteLine("After possibly removing information:");
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
