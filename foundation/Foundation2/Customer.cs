public class Customer
{
    private readonly string _name;
    private readonly Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsUSA();
    }

    public string GetDisplayText()
    {
        return $"{_name}\n{_address.GetDisplayText()}";
    }
}