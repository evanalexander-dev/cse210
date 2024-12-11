public class Circle(string color, double radius) : Shape(color)
{
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}