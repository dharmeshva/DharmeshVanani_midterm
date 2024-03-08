public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (QuantityInStock >= quantitySold)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Error: Not enough stock to sell the specified quantity.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Print details of all items
        Console.WriteLine("Item Details:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Sell some items and then print the updated details
        Console.WriteLine("\nSelling 5 Laptops...");
        item1.SellItem(5);
        Console.WriteLine("Updated Item Details:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Restock an item and print the updated details
        Console.WriteLine("\nRestocking 3 Smartphones...");
        item2.RestockItem(3);
        Console.WriteLine("Updated Item Details:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Check if an item is in stock and print a message accordingly
        Console.WriteLine("\nChecking if Laptop is in stock...");
        if (item1.IsInStock())
        {
            Console.WriteLine("Laptop is in stock.");
        }
        else
        {
            Console.WriteLine("Laptop is not in stock.");
        }

        Console.WriteLine("\nChecking if Smartphone is in stock...");
        if (item2.IsInStock())
        {
            Console.WriteLine("Smartphone is in stock.");
        }
        else
        {
            Console.WriteLine("Smartphone is not in stock.");
        }
    }
}