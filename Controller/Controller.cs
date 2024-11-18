namespace SchoolManagement{

    
    public class Controller : IMethods{
        private static List<StudentModel> StudentList = new List<StudentModel>();
        private static List<TeacherModel> TeacherList = new List<TeacherModel>();
        public void AddStudent(){
            Console.Clear();
            Console.Write("Enter Student Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Student ID: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Class: ");
            var className = Console.ReadLine();
            StudentModel stud = new StudentModel(name, id, className);
            StudentList.Add(stud);
            // System.Console.WriteLine(name);
            System.Console.WriteLine("Congooooo tumi passs\n\n\n");
        }
         public void AddTeacher(){
            Console.WriteLine("Hello");
         }
        public void DeleteStudent(){
            Console.Write("Enter Student Id: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var dltUser = StudentList.FirstOrDefault(stud => stud.Id == id);
            if(dltUser != null) StudentList.Remove(dltUser);
            Console.WriteLine($"{dltUser.Name} Removed");
        }
        public void DeleteTeacher(){
            Console.WriteLine("Hello");
        }
        public void StudentDetails(){
            Console.WriteLine("Student List: " );
            foreach(var stud in StudentList)
            {
                Console.WriteLine($"Name: {stud.Name}\tID: {stud.Id}\tClass: {stud.Class}");
            }
        }
        public void TeacherDetails(){
            Console.WriteLine("Hello");
        }
    }
}