namespace ShoppingBasketKata;

public class Item
{
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }

    public Item(string name, decimal unitPrice, int quantity)
    {
        Name = name;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    public decimal Subtotal => UnitPrice * Quantity;
}
