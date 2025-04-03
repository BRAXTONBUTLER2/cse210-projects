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
        double totalAmount = 0;
        foreach (Product product in _orderProducts)
        {
            totalAmount += product.CalculateTotalCost();
        }

        double shippingCost = _orderCustomer.IsLivingInUSA() ? 5 : 35;
        return totalAmount + shippingCost;
    }

    public string GeneratePackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        packingLabel.AppendLine("Packing Label:");
        foreach (Product product in _orderProducts)
        {
            packingLabel.AppendLine(product.GetPackingInfo());
        }
        return packingLabel.ToString();
    }

    public string GenerateShippingLabel()
    {
        return $"Shipping Label:\n{_orderCustomer.GetCustomerName()}\n{_orderCustomer.GetCustomerAddress()}";
    }
}
