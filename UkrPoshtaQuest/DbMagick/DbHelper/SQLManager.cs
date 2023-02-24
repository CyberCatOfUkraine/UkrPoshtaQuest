using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace UkrPoshtaQuest.DbMagick.DbHelper
{
    public class SQLManager
    {
        private string _connectionString
        {
            get
            {
                var directoryName = "AbraCadabra";
                var fileDefault = @"Data Source=DESKTOP-LSAUK28\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), directoryName);
                var fileName = "connectionString.txt";


                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                if (!File.Exists(Path.Combine(directoryPath, fileName)))
                {
                    File.WriteAllText(Path.Combine(directoryPath, fileName), fileDefault);

                }
                var file = File.ReadAllText(Path.Combine(directoryPath, fileName));

                return file;
            }
        }// @"Data Source=DESKTOP-LSAUK28\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<object[]> GetValuesFromDatabase(string query)
        {
            /* using (SqlConnection connection = new SqlConnection(_connectionString))
             {
                 connection.Open();

                 using (SqlTransaction transaction = connection.BeginTransaction())
                 {
                     SqlCommand command = connection.CreateCommand();
                     command.Transaction = transaction;
                     command.CommandText = query;

                     try
                     {
                         var result = command.ExecuteScalar();
                         transaction.Commit();
                         return result;
                     }
                     catch (Exception ex)
                     {
                         transaction.Rollback();
                         throw ex;
                     }
                 }
             }*/
            List<object[]> list = new List<object[]>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandText = query;

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            object[] values = new object[reader.FieldCount];
                            reader.GetValues(values);

                            /*Department department = new Department();
                            department.Id = (int)values[0];
                            department.Name = (string)values[1];
                            department.Location = (string)values[2]*/
                            list.Add(values);
                            //departments.Add(department);
                        }
                        /*
                                                if (departments.Count == 0)
                                                {
                                                    departments = new List<Department>();
                                                }*/

                        reader.Close();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }

            return list;
        }

        public void UpdateDatabase(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandText = query;

                    try
                    {
                        command.ExecuteNonQuery();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        /*public bool? IsExist(string tableName)
        {
            string query = $"IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'))" +
                $"BEGIN " +
                $"PRINT 'EXIST' " +
                $"END " +
                $"ELSE " +
                 $"BEGIN " +
                $"PRINT 'NOTEXIST'" +
                 $"END ";

            StringBuilder stringBuilder = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandText = query;
                    try
                    {
                        // SqlDataReader reader = command.ExecuteReader();
                        //var schema = reader.GetSchemaTable();
                        //while (reader.Read())
                        //{

                        //    for (int i = 0; i < reader.FieldCount; i++)
                        //    {
                        //        stringBuilder.AppendLine(reader.GetValue(i).ToString());
                        //    }
                        //}
                        var reader = command.ExecuteReader(CommandBehavior.KeyInfo);
                        var schema = reader.GetSchemaTable();
                        *//*var myReader = reader;
                        while (myReader.Read())
                        {
                            if (myReader["BaseForm"].ToString().ToLower().Contains(tableName.ToLower()) ||
                                 myReader["PastForm"].ToString().ToLower().Contains(tableName.ToLower()) ||
                                 myReader["PastPartForm"].ToString().ToLower().Contains(tableName.ToLower()))
                            {
                                stringBuilder.AppendLine(Convert.ToString(myReader["BaseForm"]));
                                stringBuilder.AppendLine(Convert.ToString(myReader["PastForm"]));
                                stringBuilder.AppendLine(Convert.ToString(myReader["PastPartForm"]));

                                break;
                            }
                        }*//*
                        reader.Close();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }

            }
            var s = stringBuilder.ToString();
            return false;
        }*/
        public bool IsExist(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public int Count(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                int count = (int)command.ExecuteScalar();

                return count;
            }
        }
    }
}
