using mod_1_assignment.animals;

namespace mod_1_assignment;

class Program
{
    
    private static string FileName = "animals.txt";
    private static FileOutput _fileOutput = new(FileName);
    // cant set up StreamReader at this point otherwise it will throw exception "is being used by another process" moved to line 32
    // private static FileInput _fileInput = new(FileName);

    public static void Main(string[] args)
    {
        List<ITalkable> zoo = new();
        // line to replace ->
            // zoo.Add(new Dog(true, "Bean"));
            // zoo.Add(new Cat(9, "Charlie"));
            // zoo.Add(new Teacher(44, "Stacy Read"));
        string input = "";
        while(input.ToLower() != "q")
        {
            var tempTalkable = UserInput.GetNewITalkable();
            if (tempTalkable != null) {
                zoo.Add(tempTalkable);
            }
            Console.WriteLine("\"q\" to quit, any key to add");
            Console.Write(">> ");
            input = Console.ReadLine();
        }

        // <- line to replace

        foreach (ITalkable thing in zoo) {
            PrintOut(thing);
        }

        // outFile.fileClose();
        _fileOutput.FileClose();
        // inFile.fileRead();

        FileInput _fileInput = new(FileName);
        _fileInput.FileRead();
        // inFile.fileClose();
        _fileInput.FileClose();


        FileInput InData = new FileInput("animals.txt");
        string line;
        while ((line = InData.FileReadLine()) != null) {
            Console.WriteLine(line);
        }
    }



    // public static void printOut
    public static void PrintOut(ITalkable p) {
        Console.WriteLine(p.GetName() + " says=" + p.Talk());
        _fileOutput.FileWrite(p.GetName() + " | " + p.Talk());
    }
}
