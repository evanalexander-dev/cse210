// I made the program only hide words that aren't already hidden. (Scripture.cs, HideRandomWords method)

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(3);
        } while (choice != "quit");
    }
}