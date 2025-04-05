using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _orderProducts = new List<Product>();
    private Customer _orderCustomer;

    public Order(Customer customer)
    {
        _orderCustomer = customer;
    }

    public void AddProduct(Product product)
    {
        _orderProducts.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        // Loop through each product and add up total cost
        foreach (Product item in _orderProducts)
        {
            total += item.CalculateTotalCost();
        }

        // Add shipping based on location
        double shipping;
        if (_orderCustomer.IsLivingInUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }

        return total + shipping;
    }

    public string GeneratePackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Packing Label:");

        foreach (Product item in _orderProducts)
        {
            label.AppendLine(item.GetPackingInfo());
        }

        return label.ToString();
    }

    public string GenerateShippingLabel()
    {
        string customerName = _orderCustomer.GetCustomerName();
        string customerAddress = _orderCustomer.GetCustomerAddress().ToString(); // Assumes Address class has ToString method
        return $"Shipping Label:\n{customerName}\n{customerAddress}";
    }
}
