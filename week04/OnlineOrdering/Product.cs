public class Product
{
    private string _productName;
    private string _productID;
    private int _price;
    private int _quantity;

    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string productName)
    {
        _productName = productName;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public void SetProductID(string productID)
    {
        _productID = productID;
    }

    public int GetPrice()
    {
        return _price;
    }

    public void SetPrice(int price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int ReturnCost()
    {
        int cost = _price * _quantity;
        return cost;
    }

    public void DisplayProduct()
    {
        Console.WriteLine(_productName, _productID);
    }
}