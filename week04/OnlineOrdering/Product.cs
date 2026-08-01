using System;

public class Product
{
    private string _name;

    private int _productId;

    private decimal _price;

    private int _quantity;


    public Product(string name,int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public int CalculateTotalCost()
    {
        return _quantity * (int)_price;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}