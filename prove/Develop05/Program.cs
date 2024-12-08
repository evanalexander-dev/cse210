// I added some code in ReflectingActivity to make it so the questions don't repeat themselves, until it has run out of questions to ask, then it resets the used questions and can use any of them again.

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    var breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    var reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case 3:
                    var listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 4);
    }
}