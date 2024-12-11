public class Square(string color, double side) : Shape(color)
{
    public override double GetArea()
    {
        return side * side;
    }
}