using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace PW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=PW1db;Integrated Security = true;";
            SqlConnection connection = new SqlConnection(ConStr);


            #region task2
            //Console.Write("1.Connect\n2.Disconnect\nChoose: ");
            //int key = Convert.ToInt32(Console.ReadLine());
            //switch(key)
            //{
            //    case 1:
            //        Console.WriteLine("State: " + ConnectToDB(connection));
            //        break;
            //    case 2:
            //        Console.WriteLine("State: " + DisconnectFromDB(connection));
            //        break;
            //    default:
            //        break;
            //}
            #endregion
            #region task3
            //Console.Write("Enter task number: ");
            //int key = Convert.ToInt32(Console.ReadLine());
            //switch (key)
            //{
            //    case 1:
            //        #region 1
            //        {
            //            connection.Open();
            //            string showAll = @"SELECT * FROM Students; SELECT * FROM Marks";
            //            SqlCommand command = new SqlCommand(showAll, connection);
            //            SqlDataReader reader = command.ExecuteReader();
            //            do
            //            {
            //                for (int i = 0; i < reader.FieldCount; i++)
            //                {
            //                    Console.Write(reader.GetName(i) + " ");
            //                }
            //                Console.WriteLine();
            //                while (reader.Read())
            //                {
            //                    for (int i = 0; i < reader.FieldCount; i++)
            //                    {
            //                        Console.Write(reader[i].ToString() + " ");
            //                    }
            //                    Console.WriteLine();
            //                }
            //                Console.WriteLine();
            //            } while (reader.NextResult());
            //            reader.Close();
            //            connection.Close();
            //        }   
            //        break;
            //        #endregion
            //    case 2:
            //        #region 2
            //        {
            //            connection.Open();
            //            string showAll = @"SELECT FirstName, LastName FROM Students;";
            //            SqlCommand command = new SqlCommand(showAll, connection);
            //            SqlDataReader reader = command.ExecuteReader();
            //            while (reader.Read())
            //            {
            //                for (int i = 0; i < reader.FieldCount; i++)
            //                {
            //                    Console.Write(reader[i].ToString() + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //            reader.Close();
            //            connection.Close();
            //        }
            //        break;
            //        #endregion
            //    case 3:
            //        #region 3
            //        {
            //            connection.Open();
            //            string showAll = @"SELECT AVG(Mark) FROM Students, Marks WHERE Students.Id=Marks.StudentId GROUP BY Students.FirstName, Students.LastName;";
            //            SqlCommand command = new SqlCommand(showAll, connection);
            //            SqlDataReader reader = command.ExecuteReader();
            //            while (reader.Read())
            //            {
            //                for (int i = 0; i < reader.FieldCount; i++)
            //                {
            //                    Console.Write(reader[i].ToString() + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //            reader.Close();
            //            connection.Close();
            //        }
            //        break;
            //        #endregion
            //    case 4:
            //        #region 4
            //        {
            //            connection.Open();
            //            string avgQuery = @"SELECT AVG(Mark) FROM Marks";
            //            SqlCommand command = new SqlCommand(avgQuery, connection);
            //            double avg = Convert.ToDouble(command.ExecuteScalar());
            //            Console.WriteLine($"Average: {avg}");
            //            string studentAvg = @"SELECT Students.FirstName, Students.LastName, AVG(Mark) AS AvgMark FROM Students, Marks WHERE Students.Id=Marks.StudentId GROUP BY Students.FirstName, Students.LastName;";
            //            command = new SqlCommand(studentAvg, connection);
            //            SqlDataReader reader = command.ExecuteReader();
            //            while (reader.Read())
            //            {
            //                if (Convert.ToDouble(reader["AvgMark"]) > avg)
            //                {
            //                    for (int i = 0; i < reader.FieldCount; i++)
            //                    {
            //                        Console.Write(reader[i].ToString() + " ");
            //                    }
            //                    Console.WriteLine();
            //                }
            //            }
            //            reader.Close();
            //            connection.Close();
            //        }
            //        break;
            //        #endregion
            //    case 5:
            //        #region 5
            //        {
            //            connection.Open();
            //            string minMarks = @"SELECT Subjects.Name, MIN(Mark) FROM Subjects JOIN Marks ON Subjects.Id=Marks.SubjectId GROUP BY Subjects.Name";
            //            SqlCommand command = new SqlCommand(minMarks, connection);
            //            SqlDataReader reader = command.ExecuteReader();
            //            while (reader.Read())
            //            {
            //                for (int i = 0; i < reader.FieldCount; i++)
            //                {
            //                    Console.Write(reader[i].ToString() + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //            reader.Close();
            //            connection.Close();
            //        }
            //        break;
            //        #endregion
            //    default:
            //        break;
            //}
            #endregion
            #region task4
            Console.Write("Enter task number: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    #region 1
                    {
                        connection.Open();
                        string showAll = @"SELECT MIN(Mark) FROM Marks";
                        SqlCommand command = new SqlCommand(showAll, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        do
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader.GetName(i) + " ");
                            }
                            Console.WriteLine();
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.Write(reader[i].ToString() + " ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                        } while (reader.NextResult());
                        reader.Close();
                        connection.Close();
                    }
                    break;
                #endregion
                case 2:
                    #region 2
                    {
                        connection.Open();
                        string showAll = @"SELECT MAX(Mark) FROM Marks";
                        SqlCommand command = new SqlCommand(showAll, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i].ToString() + " ");
                            }
                            Console.WriteLine();
                        }
                        reader.Close();
                        connection.Close();
                    }
                    break;
                #endregion
                case 3:
                    #region 3
                    {
                        connection.Open();
                        string showAll = @"SELECT COUNT(*) FROM Students 
                                           JOIN Marks ON Students.Id = Marks.StudentId 
                                           JOIN Subjects ON Subjects.Id = Marks.SubjectId 
                                           WHERE Marks.Mark = (SELECT MIN(Mark) FROM Marks WHERE SubjectID = 1) AND Subjects.Name = 'Chemistry'";
                        SqlCommand command = new SqlCommand(showAll, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i].ToString() + " ");
                            }
                            Console.WriteLine();
                        }
                        reader.Close();
                        connection.Close();
                    }
                    break;
                #endregion
                case 4:
                    #region 4
                    {
                        connection.Open();
                        string showAll = @"SELECT COUNT(*) FROM Students 
                                           JOIN Marks ON Students.Id = Marks.StudentId 
                                           JOIN Subjects ON Subjects.Id = Marks.SubjectId 
                                           WHERE Marks.Mark = (SELECT MAX(Mark) FROM Marks WHERE SubjectID = 2) AND Subjects.Name = 'Physics'";
                        SqlCommand command = new SqlCommand(showAll, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i].ToString() + " ");
                            }
                            Console.WriteLine();
                        }
                        reader.Close();
                        connection.Close();
                    }
                    break;
                #endregion
                case 5:
                    #region 5
                    {
                        connection.Open();
                        string minMarks = @"SELECT COUNT(Students.Id), GroupName FROM Students JOIN Groups ON Groups.Id = Students.GroupId GROUP BY GroupName";
                        SqlCommand command = new SqlCommand(minMarks, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i].ToString() + " ");
                            }
                            Console.WriteLine();
                        }
                        reader.Close();
                        connection.Close();
                    }
                    break;
                #endregion
                case 6:
                    #region 6
                    {
                        connection.Open();
                        string minMarks = @"SELECT AVG(Mark), GroupName FROM Students 
                                            JOIN Groups ON Groups.Id = Students.GroupId 
                                            JOIN Marks ON Marks.StudentId = Students.Id 
                                            GROUP BY GroupName";
                        SqlCommand command = new SqlCommand(minMarks, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i].ToString() + " ");
                            }
                            Console.WriteLine();
                        }
                        reader.Close();
                        connection.Close();
                    }
                    break;
                #endregion
                default:
                    break;
            }
            #endregion
        }

        static string ConnectToDB(SqlConnection connection)
        {
            connection.Open();
            return connection.State.ToString();
        }
        static string DisconnectFromDB(SqlConnection connection)
        {
            connection.Close();
            return connection.State.ToString();
        }
    }
}
