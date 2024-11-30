class Program
{
    static void Main(string[] args)
    {
        var order1 = new Order(new Customer("John Doe", new Address(
                "1600 Pennsylvania Avenue, N.W.",
                "Washington",
                "DC",
                "USA"
            )
        ));
        order1.AddProduct(new Product("Bananas", 4011, 0.59, 4));
        order1.AddProduct(new Product("Gala Apples", 4133, 1.29, 2));
        order1.AddProduct(new Product("Navel Oranges", 3107, 1.09, 1));
        Console.WriteLine("----------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.CreateShippingLabel());
        Console.WriteLine("Total Price:");
        Console.WriteLine(order1.GetTotalCost());
        Console.WriteLine("----------");

        var order2 = new Order(new Customer("John Doe", new Address(
                "Kentmanni 20",
                "Tallinn",
                "N/A",
                "Estonia"
            )
        ));
        order2.AddProduct(new Product("Strawberries", 4028, 2.99, 3));
        order2.AddProduct(new Product("Kiwis", 4030, 0.69, 5));
        order2.AddProduct(new Product("Pineapples", 4430, 2.49, 2));
        Console.WriteLine("----------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.CreateShippingLabel());
        Console.WriteLine("Total Price:");
        Console.WriteLine(order2.GetTotalCost());
        Console.WriteLine("----------");
    }
}