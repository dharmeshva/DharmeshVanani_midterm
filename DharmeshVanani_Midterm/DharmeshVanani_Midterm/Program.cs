
using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructo
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Error: Insufficient quantity in stock to sell.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Item: {ItemName}, ID: {ItemId}, Price: {Price:C}, Quantity in Stock: {QuantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Print details of all items.
        Console.WriteLine("Item Details:");
        item1.PrintDetails();
        item2.PrintDetails();


        // Update price 
        item1.UpdatePrice(1900.00);
        Console.WriteLine($"\nUpdating price of item1:");
        item1.PrintDetails();

        
        // Sell some items and then print the updated details.
        item1.SellItem(5);
        item2.SellItem(8);
        Console.WriteLine("\nAfter selling items:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Restock an item and print the updated details.
        item1.RestockItem(3);
        Console.WriteLine("\nAfter restocking item 1:");
        item1.PrintDetails();

        // Check if an item is in stock and print a message accordingly.
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

