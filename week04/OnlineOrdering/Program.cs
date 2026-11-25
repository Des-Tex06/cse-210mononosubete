using System;

class Program
{
    static void Main(string[] args)
    {
        Customer cust1 = new Customer("Larry Howell");
        Address addresscust1 = new Address("1234 Poughskeepie St", "Walla Walla", "Washington", "USA");
        cust1.DisplayCustomer();
        addresscust1.DisplayAddress();
        
    }
}