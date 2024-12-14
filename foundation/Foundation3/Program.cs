class Program
{
    static void Main(string[] args)
    {
        var a1 = new Running("12 Dec 2024", 30, (float)5.2);
        Console.WriteLine(a1.GetSummary());

        var a2 = new Cycling("15 Dec 2024", 50, (float)14.2);
        Console.WriteLine(a2.GetSummary());

        var a3 = new Swimming("17 Dec 2024", 70, 43);
        Console.WriteLine(a3.GetSummary());
    }
}