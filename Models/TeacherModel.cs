namespace SchoolManagement{
    public class TeacherModel : Person{
        private string SUBJECT = "";
        public TeacherModel(string name, int id, string subject) : base(name,id)
        {
            Subject = subject;
        }

        public string Subject{
            get{return SUBJECT;}
            set{SUBJECT = value;}
        }
    }
}