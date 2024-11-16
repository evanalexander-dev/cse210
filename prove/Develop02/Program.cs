// I made the journal file save as json instead. The new code for loading and saving is in the Journal class.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        int choice = 0;
        var promptGenerator = new PromptGenerator();
        var journal = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            try {
                choice = Convert.ToInt32(Console.ReadLine());
            } catch (Exception) {
                Console.WriteLine("Invalid choice");
                continue;
            }
            switch (choice)
            {
                case 1:
                    var prompt = promptGenerator.SelectPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    var entryText = Console.ReadLine();
                    var entry = new Entry()
                    {
                        _prompt = prompt,
                        _response = entryText
                    };
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    Console.WriteLine("What is the filename?");
                    var filename = Console.ReadLine();
                    journal.Load(filename);
                    break;
                case 4:
                    Console.WriteLine("What is the filename?");
                    filename = Console.ReadLine();
                    journal.Save(filename);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 5);
    }
}