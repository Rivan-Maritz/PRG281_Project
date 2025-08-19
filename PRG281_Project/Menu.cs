using Project281.InventoryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    public class Menu
    {
        private AddCash addCash = new AddCash(); // Persistent instance
        private SubtractCash subtractCash = new SubtractCash(); // Persistent instance
        private CalculateCash calculateCash = new CalculateCash(); // Persistent instance
        private ASCII ascii = new ASCII();
        //Menu Title Display method
        //This method displays the title of the program in a stylized format

        //Main menu display
        public void MainMenuDisplay()
        {
            var options = Enum.GetValues<MainMenu>();
            int selectedIndex = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();
                ascii.Write();
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.WriteLine(options[i]);
                }
                Console.ResetColor();

                var keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0)
                        selectedIndex = options.Length - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= options.Length)
                        selectedIndex = 0;
                }
            }
            while (key != ConsoleKey.Enter);

            // Clear the console and switch to the selected menu
            Console.Clear();
            switch (options[selectedIndex])
            {
                case MainMenu.Inventory:
                    Animation.LoadingBar();
                    InventoryMenuDisplay();
                    break;
                case MainMenu.CashFlow_Manager:
                    Animation.LoadingBar();
                    CashFlowManagerMenuDisplay();
                    break;
                case MainMenu.Statistics:
                    Animation.LoadingBar();
                    StatisticsMenuDisplay();
                    break;
                case MainMenu.Exit:
                    Environment.Exit(0);
                    break;
            }
        }
        //inventory menu display
        public void InventoryMenuDisplay()
        {
            InventoryManagerClass inventoryManager = new InventoryManagerClass();
            var options = Enum.GetValues<InventoryMenu>();
            int selectedIndex = 0;
            ConsoleKey key;
            do
            {
                Console.Clear();
                ascii.Write();
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.WriteLine(options[i]);
                }
                Console.ResetColor();
                var keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;
                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0)
                        selectedIndex = options.Length - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= options.Length)
                        selectedIndex = 0;
                }
            }
            while (key != ConsoleKey.Enter);
            Console.Clear();
            switch (options[selectedIndex])
            {
                case InventoryMenu.Add_Item:
                    // Add item logic here
                    inventoryManager.AddProduct();
                    Animation.LoadingBar();
                    InventoryMenuDisplay();
                    break;
                case InventoryMenu.Remove_Item:
                    // Remove item logic here
                    inventoryManager.RemoveFrominventory();
                    Animation.LoadingBar();
                    InventoryMenuDisplay();
                    break;
                case InventoryMenu.View_Inventory:
                    // View inventory logic here
                    inventoryManager.ViewProduct();
                    Console.WriteLine("Press any key to return to the Inventory menu...");
                    Console.ReadKey();
                    Animation.LoadingBar();
                    InventoryMenuDisplay();
                    break;
                case InventoryMenu.Low_Stock_Inventory:
                    // Low stock inventory logic here
                    inventoryManager.ViewLowStock();
                    Console.WriteLine("Press any key to return to the Inventory menu...");
                    Console.ReadKey();
                    Animation.LoadingBar();
                    InventoryMenuDisplay();
                    break;
                case InventoryMenu.Return:
                    Animation.LoadingBar();
                    MainMenuDisplay();
                    break;
            }

        }
        //Statistics Menu Display
        public void StatisticsMenuDisplay()
        {
            InventoryManagerClass inventoryManager = new InventoryManagerClass();
            var options = Enum.GetValues<StatsMenu>();
            int selectedIndex = 0;
            ConsoleKey key;
            do
            {
                Console.Clear();
                ascii.Write();
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.WriteLine(options[i]);
                }
                Console.ResetColor();
                var keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;
                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0)
                        selectedIndex = options.Length - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= options.Length)
                        selectedIndex = 0;
                }
            }
            while (key != ConsoleKey.Enter);
            Console.Clear();
            switch (options[selectedIndex])
            {
                case StatsMenu.Cash_Chart:
                    // Display cash chart logic here
                    CashStatistics cashStatistics = new CashStatistics();
                    Animation.LoadingBar();
                    cashStatistics.displayCashCharts();
                    Console.WriteLine("Press any key to return to the Cash Flow Manager menu...");
                    Console.ReadKey();
                    Animation.LoadingBar();
                    StatisticsMenuDisplay();
                    break;
                case StatsMenu.Inventory_Data:
                    // Display inventory data logic here
                    inventoryManager.ViewProduct();
                    Console.WriteLine("Press any key to return to the Cash Flow Manager menu...");
                    Console.ReadKey();
                    Animation.LoadingBar();
                    StatisticsMenuDisplay();
                    break;
                case StatsMenu.Return:
                    Animation.LoadingBar();
                    MainMenuDisplay();
                    break;
            }
        }
        //cash flow manager menu display
        public void CashFlowManagerMenuDisplay()
        {
            CashMain cashmain = new CashMain();
            var options = Enum.GetValues<CashMenu>();
            int selectedIndex = 0;
            ConsoleKey key;
            do
            {
                Console.Clear();
                ascii.Write();
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.WriteLine(options[i]);
                }
                Console.ResetColor();
                var keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;
                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0)
                        selectedIndex = options.Length - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= options.Length)
                        selectedIndex = 0;
                }
            }
            while (key != ConsoleKey.Enter);
            Console.Clear();

            switch (options[selectedIndex])
            {
                case CashMenu.Add_Income:
                    // Income cash logic here
                    Animation.LoadingBar();
                    Console.Clear();
                    addCash.AddIncome();
                    Animation.LoadingBar();
                    CashFlowManagerMenuDisplay();
                    break;

                case CashMenu.Add_Expenses:
                    // Expenses cash logic here
                    Animation.LoadingBar();
                    Console.Clear();
                    subtractCash.AddExpenses();
                    Animation.LoadingBar();
                    CashFlowManagerMenuDisplay();
                    break;

                case CashMenu.Calculate_Cash:
                    // Calculate cash logic here
                    Animation.LoadingBar();
                    Console.Clear();
                    calculateCash.CalculateTotalCash();
                    Console.WriteLine("Press any key to return to the Cash Flow Manager menu...");
                    Console.ReadKey();
                    Animation.LoadingBar();
                    CashFlowManagerMenuDisplay();
                    break;

                case CashMenu.Display_Cash_Charts:
                    // Display cash charts logic here
                    CashStatistics cashStatistics = new CashStatistics();
                    Animation.LoadingBar();
                    cashStatistics.displayCashCharts();
                    Console.WriteLine("Press any key to return to the Cash Flow Manager menu...");
                    Console.ReadKey();
                    Animation.LoadingBar();
                    CashFlowManagerMenuDisplay();
                    break;

                case CashMenu.Return:
                    Animation.LoadingBar();
                    MainMenuDisplay();
                    break;
            }
        }
    }
}
