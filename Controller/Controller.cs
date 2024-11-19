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
            Console.WriteLine($"{name} Added to the Student List\n\n\n");
        }
         public void AddTeacher(){
            Console.Clear();
            Console.Write("Enter Teacher Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Teacher ID: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Teacher's Course: ");
            var course = Console.ReadLine();
            TeacherModel teach = new TeacherModel(name, id, course);
            TeacherList.Add(teach);
            System.Console.WriteLine($"{name} Added to the Teacher List\n\n\n");
         }
        public void DeleteStudent(){
            Console.Clear();
            Console.Write("Enter Student Id: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var dltUser = StudentList.FirstOrDefault(stud => stud.Id == id);
            if(dltUser != null) StudentList.Remove(dltUser);
            Console.WriteLine($"{dltUser.Name} Removed");
        }
        public void DeleteTeacher(){
            Console.Clear();
            Console.Write("Enter Teacher Id: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var dltUser = TeacherList.FirstOrDefault(teach => teach.Id == id);
            if(dltUser != null) TeacherList.Remove(dltUser);
            Console.WriteLine($"{dltUser.Name} Removed");
        }
        public void StudentDetails(){
            Console.Clear();
            Console.WriteLine("Student List: " );
            foreach(var stud in StudentList)
            {
                Console.WriteLine($"Name: {stud.Name}\tID: {stud.Id}\tClass: {stud.Class}");
            }
        }
        public void TeacherDetails(){
            Console.Clear();
            Console.WriteLine("Teacher List: " );
            foreach(var teach in TeacherList)
            {
                Console.WriteLine($"Name: {teach.Name}\tID: {teach.Id}\tCourse: {teach.Course}");
            }
        }
    }
}