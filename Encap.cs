public class Product
{
    private double price;
    private int quantity;

    public Product(double price, int quantity)
    {
        this.price = price;
        SetQuantity(quantity);
    }

    public double GetPrice()
    {
        return price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public void SetQuantity(int quantity)
    {
        if (quantity >= 0)
        {
            this.quantity = quantity;
        }
        else
        {
            Console.WriteLine("Quantity cannot be negative.");
        }
    }
}
