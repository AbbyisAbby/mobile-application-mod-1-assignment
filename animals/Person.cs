namespace mod_1_assignment.animals 
{
    public abstract class Person
    {
        public string Name {get; internal set;}

        public Person(string Name) 
        {
            this.Name = Name;
        }

        public String GetName() {
            return Name;
        }    
    }
}