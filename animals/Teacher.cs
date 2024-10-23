namespace mod_1_assignment.animals 
{
    public class Teacher : Person, ITalkable
    {
        public int Age {get; set;}
        public Teacher(int Age, string name) : base(name)
        {
            this.Age = Age;
        }

        public string Talk() 
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}