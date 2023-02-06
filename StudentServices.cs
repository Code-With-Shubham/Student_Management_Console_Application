using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Console_Application
{
    internal class StudentServices
    {
        Student s = new Student();
        
        
        SqlConnection scon;
        SqlCommand scmd;
        SqlDataAdapter sda;
        DataSet ds;

               


        public void create()
        {
            Console.Write("Roll Number : ");
            s.rollno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name : ");
            s.name = Console.ReadLine();
            Console.Write("Mobile : ");
            s.mobile = Console.ReadLine();
            Console.Write("Age : ");
            s.age = Convert.ToInt32(Console.ReadLine());


                try
                {
                    string connectionString = "Data Source=MANOHARES-5279\\SQLEXPRESS;Initial Catalog=ConsoleApp;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string sql = "insert into Student" + "(rollno,name,mobile,age)" +
                            "values(@rollno,@name,@mobile,@age);";
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@rollno", s.rollno);
                            cmd.Parameters.AddWithValue("@name", s.name);
                            cmd.Parameters.AddWithValue("@mobile", s.mobile);
                            cmd.Parameters.AddWithValue("@age", s.age);
                            cmd.ExecuteNonQuery();
                        Console.WriteLine("Registration Successful");
                        }
                    }

                }
                catch (Exception)
                {
                Console.WriteLine("Failed");
            }
            
        }
        public void show()
        {
            try
            {
                String connectionString = "Data Source=MANOHARES-5279\\SQLEXPRESS;Initial Catalog=ConsoleApp;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "SELECT *  FROM Student";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                 Student student = new Student();
                                Console.WriteLine(student.rollno = reader.GetInt32(0));
                                Console.WriteLine(student.name = reader.GetString(1));
                                Console.WriteLine(student.mobile = reader.GetString(2));
                                Console.WriteLine(student.age = reader.GetInt32(3));

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }
        }

        public void delete()
        {

            Console.Write("Roll Number : ");
            s.rollno = Convert.ToInt32(Console.ReadLine());
            try
            {
                string connectionString = "Data Source=MANOHARES-5279\\SQLEXPRESS;Initial Catalog=ConsoleApp;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "delete from Student where rollno=@rollno;";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@rollno", s.rollno);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Student Deletion Successful");
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }
        }

        public void update()
        {
            try
            {
                string connectionString = "Data Source=MANOHARES-5279\\SQLEXPRESS;Initial Catalog=ConsoleApp;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "delete from Student where rollno=@rollno;";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@rollno", s.rollno);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Student Deletion Successful");
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }

        }

       
        public void deleteAll()
        {
            try
            {
                string connectionString = "Data Source=MANOHARES-5279\\SQLEXPRESS;Initial Catalog=ConsoleApp;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "delete from Student;";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Deletion Successful");
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
