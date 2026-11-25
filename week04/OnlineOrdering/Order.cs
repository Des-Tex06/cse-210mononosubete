public class Order
{
    private List<Product> _products = new List<Product>();
    Product ReturnCost;
    Customer DisplayCustomer;
    Address AddressIntheUSA;
    
    public void ReturnPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine("Products purchased: ");
            product.DisplayProduct();
        }
    }
    public void ReturnShippingLabel()
    {
        Console.WriteLine(DisplayCustomer);
    }

    public void GetTotalPrice()
    {
        
    }
}