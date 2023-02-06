using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            StudentsOperation so = new StudentsOperation();
            StudentServices ss = new StudentServices();
            so.home();

            
            Console.ReadLine();
        }
    }
}
