namespace mod_1_assignment.animals 
{
    public class Cat : Pet, ITalkable
    {
        public int MouseKilled {get; internal set;}

        public Cat(int MouseKilled, string name) : base(name)
        {
            this.MouseKilled = MouseKilled;
        }

        public void AddMouse()
        {
            MouseKilled++;
        }

        public string Talk() {
            return "Meow";
        }

        public override string ToString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + MouseKilled;
        }

    }
}
