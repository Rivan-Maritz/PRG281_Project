using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project281.InventoryField
{
    public class Inventory
    {
        // class that handles the adding and removing of a specified product from the inventory


        public string ProductID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string SupplierID { get; set; }


    }
}
