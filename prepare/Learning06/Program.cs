class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];

        var square = new Square("Red", 3);
        shapes.Add(square);

        var rectangle = new Rectangle("Blue", 4, 5);
        shapes.Add(rectangle);

        var circle = new Circle("Green", 6);
        shapes.Add(circle);

        foreach (var s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}.");
        }
    }
}