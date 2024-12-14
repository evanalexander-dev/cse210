public class Cycling(string date, int minutes, float speed) : Activity("Cycling", date, minutes)
{
    protected override float GetDistance()
    {
        return (_minutes / (float)60) * GetSpeed();
    }

    protected override float GetSpeed()
    {
        return speed;
    }
}