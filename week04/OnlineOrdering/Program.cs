using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Widget", 101, 10.99m, 2);
        Product product2 = new Product("Gadget", 102, 5.49m, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPacking());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}");
        Console.WriteLine();

        Address address2 = new Address("1745 Lavalle St", "Buenos Aires", "Zrt", "ARG");
        Customer customer2 = new Customer("Jose Ovalle", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Cell Phone", 201, 5.59m, 1);
        Product product4 = new Product("USB Cable", 202, 5m, 3);
        Product product5 = new Product("Mouse", 203, 15m, 2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPacking());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
        Console.WriteLine();
    }
}