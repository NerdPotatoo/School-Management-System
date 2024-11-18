namespace SchoolManagement{
    public class StudentModel : Person{
        private string CLASS = "";
        public StudentModel(string name, int id, string Class) : base(name,id)
        {
            this.Class = Class;
        }

        public string Class{
            get{return CLASS;}
            set{CLASS = value;}
        }
    }
}