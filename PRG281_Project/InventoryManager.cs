using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project281.InventoryManager
{
    public class Inventory
    {
        // class that handles the adding and removing of a specified product from the inventory
        public string ProductID { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }


    }

    public class InventoryManagerClass

    {
        public int totalItem;
        public int mostStockedItem;
        public int lowStockAlert;
        static List<Inventory> inventory = new List<Inventory>();

        //object to access the inventory class

        //method to add a product to the inventory
        public void AddProduct()
        {
            bool isValid = true;    
            //loop to allow user to load more products to inventory
            string confirmRenter = "yes";

            while(isValid)
            {
                Console.Clear();
                Console.WriteLine("Please enter the bar code of the product");
                string ProductID = Console.ReadLine();
                Console.WriteLine("");

                var existingItem = inventory.FirstOrDefault(i => i.ProductID.Equals(ProductID, StringComparison.OrdinalIgnoreCase));

                if (existingItem != null)
                {
                    Console.WriteLine("How much of this product do you want to add to inventory?");
                    int quantity;
                    //loop to ask user to enter a valid text. loop stops executing when the text is valid
                    while (!int.TryParse(Console.ReadLine(), out quantity))
                    {
                        Console.WriteLine("❌ ERROR: Input is invalid. Please try again.");
                    }
                    existingItem.quantity += quantity;
                    Console.WriteLine($"{quantity} of {existingItem.name} has been added to inventory.");

                }
                else
                {
                    Console.WriteLine("Please enter the name of the product");
                    string name = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Please enter the product type");
                    string type = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("What is the price of the product");
                    double price;
                    //exception handling to make sure user input is in the requested format
                    while (!double.TryParse(Console.ReadLine(), out price))
                    {
                        Console.WriteLine("❌ ERROR: Input is invalid. Please try again.");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("How much of this product do you want to add to inventory?");
                    int quantity;
                    //loop to ask user to enter a valid text. loop stops executing when the text is valid
                    while (!int.TryParse(Console.ReadLine(), out quantity))
                    {
                        Console.WriteLine("❌ ERROR: Input is invalid. Please try again.");
                    }
                    inventory.Add(new Inventory { name = name, quantity = quantity, ProductID = ProductID, type = type, price = price });
                    //confirmation message to show that product has been added to the inventory
                    Console.WriteLine($"{name} with productID; {ProductID} has been added");
                }

                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do want to add another product: [Y/N]");
                    confirmRenter = Console.ReadLine().ToLower();

                    if (confirmRenter == "y")
                    {
                        break;
                    }

                    if (confirmRenter == "n")
                    {
                        isValid = false;
                        break;
                    }
                    if(confirmRenter != "y" || confirmRenter != "n")
                    {
                        //if the user input is not valid, the loop will continue to ask for a valid input
                        Console.WriteLine("");
                        Console.WriteLine("❌ ERROR: Input is invalid. Please try again.");
                    }

                }

            }

        }

        //method to remove a product by user inputting the product ID
        public void RemoveFrominventory()
        {
            Console.WriteLine("Please enter the product Product Barcode");
            //specify a new variable for the user input that this new one might be validated with the existing product IDs
            string ProductID = Console.ReadLine();

            var item = inventory.FirstOrDefault(i => i.ProductID.Equals(ProductID, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                Console.WriteLine("How much of this product do you want to remove from inventory?");
                int quantity;
                //loop to ask user to enter a valid text. loop stops executing when the text is valid
                while (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("❌ ERROR: Input is invalid. Please try again.");
                }
                if (quantity > item.quantity)
                {
                    Console.WriteLine("❌ ERROR: Quantity to remove exceeds available stock.");
                }
                else
                {
                    item.quantity -= quantity;
                    Console.WriteLine($"{quantity} of {item.name} has been removed from inventory.");
                }
            }
            else
            {
                Console.WriteLine("❌ ERROR: Product not found in inventory.");
            }

        }

        //method to check reorder levels 
        public void ViewLowStock()
        {
            // Check if there are any items in the inventory
            Console.Write("Enter stock threshold to define low stock: ");
            if (int.TryParse(Console.ReadLine(), out int threshold))
            {
                var lowStockItems = inventory.Where(i => i.quantity < threshold).ToList();

                if (lowStockItems.Count == 0)
                {
                    Console.WriteLine("No items are low on stock.");
                    return;
                }
                // Display low stock items
                Console.WriteLine("\nLow Stock Items:");
                foreach (var item in lowStockItems)
                {
                    Console.WriteLine($"- {item.ProductID} {item.name}: {item.quantity}");
                }
            }
            else
            {
                // If the input is not a valid integer, display an error message
                Console.WriteLine("Invalid threshold value.");
            }
        
        }

        //method to view all products in the inventory
        public void ViewProduct()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            Console.WriteLine("\nAll Inventory Items:");
            Console.WriteLine("Barcode\t\tItem\tType\tPrice\tQuantity");
            Console.WriteLine("------------------------------------------------------");
            foreach (var item in inventory)
            {
                    Console.WriteLine($"{item.ProductID}\t{item.name}\t{item.type}\t{item.price:C}\t{item.quantity:n}");
            }
            Console.WriteLine("------------------------------------------------------");
        }
        

    }

}
