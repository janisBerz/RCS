using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Day_21_MD
{
    class DBConnection
    {
        private static MySqlConnection mySqlConnection { get; set; }
        private static string server { get; set; }
        private static string database { get; set; }
        private static string user { get; set; }
        private static string password { get; set; }
        private static string port { get; set; }
        private static string connectionString { get; set; }
        private static string SslMode { get; set; }

        public DBConnection()
        {
            server = "riga-coding-school.mysql.database.azure.com";
            database = "augstskola";
            user = "jb_admin";
            password = "VuDdVfJdpMK9fCf";
            port = "3306";
            SslMode = "Preferred";
            connectionString = $"Server={server};Port={port};Uid={user}@riga-coding-school; Pwd={password}; Database={database}; SslMode={SslMode}";
            mySqlConnection = new MySqlConnection(connectionString);
        }


        public static void GetStudents()
        {
            try
            {
                string queryString = $"SELECT studentId, studentName, studentSurname, studentCourse FROM students";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                mySqlConnection.Open();
                dataAdapter.SelectCommand = new MySqlCommand(queryString, mySqlConnection);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"ID: {row.Field<int>(0)} Name: {row.Field<String>(1)} Surname: {row.Field<String>(2)} Course: {row.Field<int>(3)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Kluda: {ex.Message}");
            }
            finally
            {
                if (mySqlConnection != null)
                    mySqlConnection.Close();
            }
        }

        public static void AddStudent()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Student student = new Student(name, surname, year);

            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = mySqlConnection;
                cmd.CommandText = "INSERT INTO students (studentName, studentSurname, studentCourse) Values(@studentName, @studentSurname, @studentCourse)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@studentName", student.Name);
                cmd.Parameters.AddWithValue("@studentSurname", student.Surname);
                cmd.Parameters.AddWithValue("@studentCourse", student.Course);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (mySqlConnection != null)
                    mySqlConnection.Close();
            }
        }


        public static void RemoveStudent()
        {
            Console.WriteLine();
            Console.Write("Student ID: ");
            int studentID = int.Parse(Console.ReadLine());
            try
            {
                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = mySqlConnection;
                cmd.CommandText = $"delete from students where studentId='{studentID}';";
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (mySqlConnection != null)
                    mySqlConnection.Close();
            }
        }
    }


}
