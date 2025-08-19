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

        public static void RunLoadingBar()
        {
            Animation animation = new Animation(); // Create an instance of Animation
            Thread loadingThread = new Thread(() => animation.LoadingBar());  //CUSTOM THREADING
            loadingThread.Start();                                            //STARTS CUSTOM THREADING
            loadingThread.Join();                                             //WAITS FOR THE LOADING BAR TO FINISH
        }

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
                Console.WriteLine("");
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
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    InventoryMenuDisplay();
                    break;
                case MainMenu.CashFlow_Manager:
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    CashFlowManagerMenuDisplay();
                    break;
                case MainMenu.Statistics:
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    StatisticsMenuDisplay();
                    break;
                case MainMenu.Exit:
                    RunLoadingBar();                //CALLS CUSTOM THREADING
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
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    inventoryManager.AddProduct();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    InventoryMenuDisplay();
                    break;
                case InventoryMenu.Remove_Item:
                    // Remove item logic here
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    inventoryManager.RemoveFrominventory();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    InventoryMenuDisplay();
                    break;
                case InventoryMenu.View_Inventory:
                    // View inventory logic here
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    inventoryManager.ViewProduct();
                    Console.WriteLine("Press any key to return to the Inventory menu...");
                    Console.ReadKey();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    InventoryMenuDisplay();
                    break;
                case InventoryMenu.Low_Stock_Inventory:
                    // Low stock inventory logic here
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    inventoryManager.ViewLowStock();
                    Console.WriteLine("Press any key to return to the Inventory menu...");
                    Console.ReadKey();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    InventoryMenuDisplay();
                    break;
                case InventoryMenu.Return:
                    RunLoadingBar();                //CALLS CUSTOM THREADING
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
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    cashStatistics.displayCashCharts();
                    Console.WriteLine("Press any key to return to the Cash Flow Manager menu...");
                    Console.ReadKey();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    StatisticsMenuDisplay();
                    break;
                case StatsMenu.Inventory_Data:
                    // Display inventory data logic here
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    inventoryManager.ViewProduct();
                    Console.WriteLine("Press any key to return to the Cash Flow Manager menu...");
                    Console.ReadKey();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    StatisticsMenuDisplay();
                    break;
                case StatsMenu.Return:
                    RunLoadingBar();                //CALLS CUSTOM THREADING
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
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    Console.Clear();
                    addCash.AddIncome();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    CashFlowManagerMenuDisplay();
                    break;

                case CashMenu.Add_Expenses:
                    // Expenses cash logic here
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    Console.Clear();
                    subtractCash.AddExpenses();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    CashFlowManagerMenuDisplay();
                    break;

                case CashMenu.Calculate_Cash:
                    // Calculate cash logic here
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    Console.Clear();
                    calculateCash.CalculateTotalCash();
                    Console.WriteLine("Press any key to return to the Cash Flow Manager menu...");
                    Console.ReadKey();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    CashFlowManagerMenuDisplay();
                    break;

                case CashMenu.Display_Cash_Charts:
                    // Display cash charts logic here
                    CashStatistics cashStatistics = new CashStatistics();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    cashStatistics.displayCashCharts();
                    Console.WriteLine("Press any key to return to the Cash Flow Manager menu...");
                    Console.ReadKey();
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    CashFlowManagerMenuDisplay();
                    break;

                case CashMenu.Return:
                    RunLoadingBar();                //CALLS CUSTOM THREADING
                    MainMenuDisplay();
                    break;
            }
        }
    }
}
