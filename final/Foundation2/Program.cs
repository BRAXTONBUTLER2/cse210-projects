using System;

class Program
{

    //I used AI to help come up with fake adresses and customer names
    static void Main(string[] args)
    {
        Address address1 = new Address("456 Main St", "Miami", "FL", "USA");
        Customer customer1 = new Customer("John McEnroe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Tennis Shoes", "TS202", 100.0, 2));
        order1.AddProduct(new Product("Tennis Balls", "TB303", 8.0, 4));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

       
        Address address2 = new Address("15 Royal Avenue", "Manchester", "Greater Manchester", "UK");
        Customer customer2 = new Customer("Roger Federer", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tennis Bag", "TB101", 75.0, 1));
        order2.AddProduct(new Product("Overgrip Rolls", "OG999", 5.0, 5));
        order2.AddProduct(new Product("Socks (3-pack)", "SO111", 20.0, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");
    }
}
