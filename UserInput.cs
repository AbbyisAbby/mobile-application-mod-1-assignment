using System.Collections.Specialized;
using mod_1_assignment.animals;

namespace mod_1_assignment;

class UserInput
{
    public static ITalkable GetNewITalkable()
    {
        string? petOrPerson;
        do {
            petOrPerson = PromptInput("Create a (1) pet (2) Person");
        }while (petOrPerson != "1" && petOrPerson != "2");

        string? name;
        do{
            name = PromptInput("Name");
        } while (name == null);


        // pet
        if (petOrPerson.Substring(0,1) == "1")
        {
            string? catOrDog;
            do {
                catOrDog = PromptInput("Create a (1) cat (2) Dog");

                if (catOrDog.Substring(0,1) == "1")
                {
                    // cat
                    int? mouseKilled;
                    do {
                        try{
                            mouseKilled = Int32.Parse(PromptInput("mouse killed"));
                        }
                        catch
                        {
                            Console.WriteLine("Invalid number, try again");
                            mouseKilled = null;
                        } 
                    } while (mouseKilled == null);
                    Console.WriteLine("Cat added");
                    return new Cat((int)mouseKilled, name);
                }

                if (catOrDog.Substring(0,1) == "2")
                {
                    //dog
                    bool? isFriendly;
                    do {
                        try{
                            isFriendly = bool.Parse(PromptInput("(true) friendly (false) not friendly"));
                        }
                        catch
                        {
                            Console.WriteLine("Try again");
                            isFriendly = null;
                        } 
                    } while (isFriendly == null);
                    Console.WriteLine("Dog added");
                    return new Dog((bool)isFriendly, name);
                }


            } while (catOrDog == null);
        }

        // person
        if  (petOrPerson.Substring(0,1) == "2")
        {
            int? age;
            do {
                try{
                    age = Int32.Parse(PromptInput("Age"));
                }
                catch
                {
                    Console.WriteLine("Invalid number, try again");
                    age = null;
                } 
            } while (age == null);

            Console.WriteLine("Teacher added");
            return new Teacher((int)age, name);
        }
        return null;
    }

    public static string? PromptInput(string prompt)
    {
        Console.WriteLine(prompt);
        Console.Write(">> ");
        return Console.ReadLine();
    }
}