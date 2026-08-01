using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

   public Order(Customer customer)
   {
    _customer = customer;
    _products = new List<Product>();
   }

   public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.CalculateTotalCost();
        }

        decimal shippingCost = _customer.livesInUSA() ? 5m : 35m;

        return totalCost + shippingCost;
    }

    public string GetPacking()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"Customer: {_customer.GetName()}\n";
        label += $"Address: {_customer.GetFormattedAddress()}\n";

        return label;
    }

  
}