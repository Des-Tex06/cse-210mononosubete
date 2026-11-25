using System.Net.Sockets;

public class Customer
{
    private string _customerName;
    Address _address;
    Address ReturnAddressInUSA;

    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
    public Customer(string customerName)
    {
        _customerName = customerName;
    }
    public void DisplayCustomer()
    {
        Console.WriteLine($"Customer: {_customerName}");
        Console.WriteLine($"Address: {_address}");
    }
    public void ReturnLiveinUSA()
    {
        if (_address == ReturnAddressInUSA)
        {
            Console.WriteLine("Lives in USA");
        }
        else
        {
            Console.WriteLine("Does not live in USA");
        }
    }
}