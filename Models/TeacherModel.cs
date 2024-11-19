namespace SchoolManagement{
    public class TeacherModel : Person{
        private string COURSE = "";
        public TeacherModel(string name, int id, string course) : base(name,id)
        {
            Course = course;
        }

        public string Course{
            get{return COURSE;}
            set{COURSE = value;}
        }
    }
}