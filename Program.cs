using System;
namespace SchoolManagement{
    public class Program{
        static void Main()
        {
            Console.Clear();
            Controller sManagement = new Controller();
            Console.WriteLine("\tSchool Management System");
        Console.WriteLine("       |------------------------|\n\n");
            while(true)
            {
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("1. Add new Student");
                Console.WriteLine("2. Add new Teacher");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Delete Teacher");
                Console.WriteLine("5. Show Student List");
                Console.WriteLine("6. Show Teacher List");
                Console.WriteLine("7. Exit tata bye bye");
                Console.Write("Input: ");
                var op = Console.ReadLine();
                switch(op)
                {
                    case "1" : 
                        sManagement.AddStudent();
                        break;
                    case "2" : 
                        sManagement.AddTeacher();
                        break;
                    case "3" :
                        sManagement.DeleteStudent();
                        break;
                    case "4" :
                        sManagement.DeleteTeacher();
                        break;
                    case "5" :
                        sManagement.StudentDetails();
                        break;
                    case "6" :
                        sManagement.TeacherDetails();
                        break;
                    case "7" :
                        Console.WriteLine("Program Ended :') "); 
                        return;
                    default :
                        Console.WriteLine("Invalid Input Try Again!!");
                        break;
                }
            }
        }
    }
}