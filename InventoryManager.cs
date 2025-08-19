using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Project281.InventoryField;

namespace Project281.InventoryManager
{
    public class InventoryManagerClass

    {
        public int totalItem;
        public int mostStockedItem;
        public int lowStockAlert;
        public List<Inventory> inventory = new List<Inventory>();

        //object to access the inventory class
        Inventory accessInventory = new Inventory();

        //method to add a product to the inventory
        public void AddProduct()
        {
            bool isValid = true;    
            //loop to allow user to load more products to inventory
            string confirmRenter = "yes";

            while(isValid)
            {

                Console.WriteLine("Please enter the bar code of the product");
                string ProductID = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please enter the name of the product");
                string name = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please enter the description");
                string description = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please enter the supplier ID");
                string SupplierID = Console.ReadLine();
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


                //Object is created to hold every instance of a new product created 

                Inventory additem = new Inventory
                {

                    ProductID = ProductID,
                    name = name,
                    description = description,
                    SupplierID = SupplierID,
                    price = price,
                    quantity = quantity,

                };


                inventory.Add(additem);
                //confirmation message to show that product has been added to the inventory
                Console.WriteLine($"{name} with productID; {ProductID} has been added");
                Console.WriteLine("");
                Console.WriteLine("Do want to add another product: Yes/No");
                confirmRenter = Console.ReadLine().ToLower();

                if( confirmRenter == "yes" )
                {
                    isValid = true;
                }
                else if (confirmRenter == "no")
                {
                    isValid = false;
                }
                else
                {
                    Console.WriteLine("❌ ERROR: Input is invalid. Please try again.");
                }

            }

        }

        //method to remove a product by user inputting the product ID
        public void RemoveFrominventory()
        {
            Console.WriteLine("Please enter the product ID");
            //specify a new variable for the user input that this new one might be validated with the existing product IDs
            string productID = Console.ReadLine();

            if (productID == accessInventory.ProductID)
            {
                Console.WriteLine($"Product {accessInventory.name} removed form inventory");
                accessInventory.ProductID = null;
                accessInventory.name = null;
                accessInventory.description = null;
                accessInventory.price = 0;
                accessInventory.quantity = 0;
                accessInventory.SupplierID = null;
            }
            else
            {
                Console.WriteLine("product could not be found");
            }
        }

        //method to check reorder levels 
        public void ReorderLevel()
        {
            Console.WriteLine("Please enter the reorder level for the product");
            int reorderLevel;
            //loop to ask user to enter a valid text. loop stops executing when the text is valid
            while (!int.TryParse(Console.ReadLine(), out reorderLevel))
            {
                Console.WriteLine("❌ ERROR: Input is invalid. Please try again.");
            }
            lowStockAlert = reorderLevel;
            Inventory inventory = new Inventory();
            if (inventory.quantity < lowStockAlert)   // example reorder level

            {
                Console.WriteLine($"The product {inventory.name} is almost out of stock.");
            }

        }

        //method to view all products in the inventory
        public void ViewProduct()
        {
            foreach (var item in inventory)
            {
                Console.WriteLine($"Product ID: {item.ProductID}, Name: {item.name}, Description: {item.description}, Price: {item.price}, Quantity: {item.quantity}, suppliedBy: {item.SupplierID}");
            }
        }
        

    }

    //internal class InventoryManager
    //{
    //}
}
