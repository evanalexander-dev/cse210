public class Rectangle(string color, double length, double width) : Shape(color)
{
    public override double GetArea()
    {
        return length * width;
    }
}