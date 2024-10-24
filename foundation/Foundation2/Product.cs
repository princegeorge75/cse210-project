public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate the total cost of the product
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    // Getter for product name and ID (for the packing label)
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
}
