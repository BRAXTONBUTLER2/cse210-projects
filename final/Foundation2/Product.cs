public class Product
{
    private string _productName;
    private string _productCode;
    private double _unitPrice;
    private int _productQuantity;

    public Product(string productName, string productCode, double unitPrice, int productQuantity)
    {
        _productName = productName;
        _productCode = productCode;
        _unitPrice = unitPrice;
        _productQuantity = productQuantity;
    }

    public double CalculateTotalCost()
    {
        return _unitPrice * _productQuantity;
    }

    
    public string GetPackingInfo()
    {
        return $"{_productName} (ID: {_productCode}) - Qty: {_productQuantity}";
    }
}
