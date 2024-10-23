namespace mod_1_assignment.animals 
{
    public class Dog : Pet, ITalkable
    {
        public bool Friendly {get; internal set;}

        public Dog(bool friendly, string name) : base(name)
        {
            this.Friendly = friendly;
        }

        public string Talk() {
            return "Bark";
        }

        public override string ToString()
        {
            return "Dog: " + "name=" + base.Name + " Friendly=" + Friendly;
        }

        
    }
}
