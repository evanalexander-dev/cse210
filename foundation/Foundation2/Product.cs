public class Product
{
    private readonly string _name;
    private readonly int _productId;
    private readonly double _price;
    private readonly int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }

    public string GetDisplayText()
    {
        return $"{_productId} | {_quantity} {_name}";
    }
}