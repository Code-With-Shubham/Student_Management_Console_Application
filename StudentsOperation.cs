using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Console_Application
{
    internal class StudentsOperation
    {
        public Student bank = new Student();
        StudentServices ss = new StudentServices();

        int choice = 0;
        public void home()
        {
            Console.WriteLine("********Welcome To Student Management Application*********");
            Console.WriteLine();
            Console.WriteLine("1. Addmit Student.");
            Console.WriteLine("2. Show Students.");
            Console.WriteLine("3. Delete Student.");
            Console.WriteLine("4. Update Students.");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.WriteLine();


            Console.Write("Enter Choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1: ss.create();
                    break;

                case 2 : ss.show();
                    break;
               
                case 3: ss.delete(); 
                    break;

                case 4: ss.update();
                    break;

                case 5: break;
                        
            }
        
        }
    }
}
