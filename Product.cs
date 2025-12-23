using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4;

internal class Product
{
    public string Name { get; set; }
    private int amount;
    private int price;

    public int Amount
    {
        get { return amount; }
        set
        {
            if(value >= 0)
            {
                amount = value;
            }
            else
            {
                throw new Exception("Value cannot be negative");
            }
        }
    }

    public int Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
            {
                price = value;
            }
            else
            {
                throw new Exception("Value cannot be negative");
            }
        }
    }

    public Product(string name, int a, int p)
    {
        Name = name;
        Amount = a; 
        Price = p;
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name} ");
        Console.WriteLine($"amount: {amount} ");
        Console.WriteLine($"price: {price} ");
    }

    public static Product operator+(Product p, int val) 
    {
        p.Amount += val;
        return p;
    }

    public static Product operator -(Product p, int val)
    {
        p.Amount -= val;
        return p;
    }

    public static bool operator ==(Product p, Product p2)
    {
        return p.Price == p2.Price;
    }

    public static bool operator !=(Product p, Product p2)
    {
        return p.Price != p2.Price;

    }

    public static bool operator <(Product p, Product p2)
    {
        return p.Amount < p2.Amount;

    }

    public static bool operator >(Product p, Product p2)
    {
        return p.Amount > p2.Amount;

    }
}
