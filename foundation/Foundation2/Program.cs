using System;
using System.Collections.Generic;

// Address class definition
public class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public bool IsUSA()
    {
        return country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}, {stateProvince}\n{country}";
    }
}

// Customer class definition
public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsUSA()
    {
        return address.IsUSA();
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}

// Product class definition
public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }
}

// Order class definition
public class Order
{
    private List<Product> products;
    private Customer customer;
    private const decimal USA_SHIPPING_COST = 5.00m;
    private const decimal INTERNATIONAL_SHIPPING_COST = 35.00m;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal subtotal = 0;
        foreach (Product product in products)
        {
            subtotal += product.GetTotalCost();
        }
        return customer.IsUSA() ? subtotal + USA_SHIPPING_COST : subtotal + INTERNATIONAL_SHIPPING_COST;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += $"{product.GetName()} ({product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}

class Program
{
    static void Main()
    {
        // Create customers
        Address address1 = new Address("42 Main St", "Downtown", "CA", "USA");
        Customer customer1 = new Customer("Ugochukwu Onunkwo", address1);

        Address address2 = new Address("456 Elm St", "Othertown", "Ontario", "Canada");
        Customer customer2 = new Customer("Ezinne Onunkwo", address2);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to orders
        order1.AddProduct(new Product("Product 1", "P001", 10.99m, 2));
        order1.AddProduct(new Product("Product 2", "P002", 5.99m, 3));
        order1.AddProduct(new Product("Product 3", "P003", 7.99m, 1));

        order2.AddProduct(new Product("Product 4", "P004", 12.99m, 1));
        order2.AddProduct(new Product("Product 5", "P005", 8.99m, 2));

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}