namespace mod_1_assignment.animals 
{
    public abstract class Pet 
    {
        public string Name {get; internal set;}
        
        public Pet(string Name )
        {
            this.Name = Name;
        }

        public String GetName() {
            return Name;
        }  

    }
    
}