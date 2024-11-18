namespace SchoolManagement{
    public class Person{
        private string NAME = "";
        private int ID;

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        } 

        public string Name{
            get{return NAME;}
            set{NAME = value;}
        }
        public int Id{
            get{return ID;}
            set{ID = value;}
        }
    }
}