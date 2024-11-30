public class Order
{
    private readonly Customer _customer;
    private readonly List<Product> _products = [];

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double GetTotalCost()
    {
        return _products.Select(product => product.GetTotalCost()).Sum() + (_customer.IsInUSA() ? 5 : 35);
    }

    public string CreatePackingLabel()
    {
        return string.Join("\n", _products.Select(product => product.GetDisplayText()));
    }

    public string CreateShippingLabel()
    {
        return _customer.GetDisplayText();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}