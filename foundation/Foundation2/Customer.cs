public class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Getter for customer name
    public string GetName()
    {
        return _name;
    }

    // Getter for customer's address
    public Address GetAddress()
    {
        return _address;
    }
}
