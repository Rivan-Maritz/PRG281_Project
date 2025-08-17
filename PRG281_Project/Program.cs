using System;
using System.Buffers.Text;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

//Rivan Maritz 601530
//Theart Jooste 601288

//enums for the main menu, inventory menu, cash flow manager menu, and statistics menu
enum MainMenu
{
    Inventory,
    CashFlow_Manager,
    Statistics,
    Exit
}

enum InventoryMenu
{
    Add_Item,
    Remove_Item,
    View_Inventory,
    Low_Stock_Inventory,
    Inventory_Statistics,
    Return
}

enum CashMenu
{
    Add_Income,
    Add_Expenses,
    Calculate_Cash,
    Display_Cash_Charts,
    Return
}

enum StatsMenu
{
    Cash_Chart,
    Inventory_Data,
    Return
}

public class Data
{
    // Sample cash flow data
    private int[] Cashflow = [45, 20, 35, 26, 51, 61, 23, 56, 45];
    // Method to get the cash flow data
    public int[] GetCashFlowData()
    {
        return Cashflow;
    }
    // Sample inventory data
    private string[] Inventory = ["Item1", "Item2", "Item3", "Item4", "Item5"];
    private int[] InventoryQuantities = [10, 5, 15, 3, 8];
    private double[] InventoryPrices = [12.99, 8.49, 15.00, 5.99, 10.50];
    private DateTime[] InventoryAddDates =
    {
        new DateTime(2024, 12, 31),
        new DateTime(2025, 1, 15),
        new DateTime(2024, 11, 30),
        new DateTime(2025, 2, 28),
        new DateTime(2024, 10, 20)
    };
    // Method to get the inventory items, quantities, prices, and add dates
    public string[] GetInventoryItems()
    {
        return Inventory;
    }
    public int[] GetInventoryQuantities()
    {
        return InventoryQuantities;
    }
    public double[] GetInventoryPrices()
    {
        return InventoryPrices;
    }

    public DateTime[] GetInventoryAddDates()
    {
        return InventoryAddDates;
    }
}

public class Menu : Data
{
    private AddCash addCash = new AddCash(); // Persistent instance
    private SubtractCash subtractCash = new SubtractCash(); // Persistent instance
    private CalculateCash calculateCash = new CalculateCash(); // Persistent instance

    //Menu Title Display method
    //This method displays the title of the program in a stylized format
    public void Write()
    {
        Console.WriteLine("    ███████ ██       ██████  ██     ██ ██ ███    ██  ██████       ██████  █████  ███████ ██   ██ \r\n"+ 
                          "   ██      ██      ██    ██ ██     ██ ██ ████   ██ ██           ██      ██   ██ ██      ██   ██ \r\n" +
                          "  █████   ██      ██    ██ ██  █  ██ ██ ██ ██  ██ ██   ███     ██      ███████ ███████ ███████ \r\n" +
                          " ██      ██      ██    ██ ██ ███ ██ ██ ██  ██ ██ ██    ██     ██      ██   ██      ██ ██   ██ \r\n" +
                          "██      ███████  ██████   ███ ███  ██ ██   ████  ██████       ██████ ██   ██ ███████ ██   ██ \r\n\r\n" +

                           "████████████████████████████████████████████████████████████████████████████████████████████████ \r\n\r\n"+
                           "Use the arrow keys to navigate the menu and press Enter to select an option.\r\n" 
                      );
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
            Write();
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
        var options = Enum.GetValues<InventoryMenu>();
        int selectedIndex = 0;
        ConsoleKey key;
        do
        {
            Console.Clear();
            Write();
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
                break;
            case InventoryMenu.Remove_Item:
                // Remove item logic here
                break;
            case InventoryMenu.View_Inventory:
                // View inventory logic here
                break;
            case InventoryMenu.Low_Stock_Inventory:
                // Low stock inventory logic here
                break;
            case InventoryMenu.Inventory_Statistics:
                // Inventory statistics logic here
                DisplayStats.CreateInventoryTable();
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
        var options = Enum.GetValues<StatsMenu>();
        int selectedIndex = 0;
        ConsoleKey key;
        do
        {
            Console.Clear();
            Write();
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
                DisplayStats.DrawLineGraph(GetCashFlowData());
                Console.WriteLine("Press any key to return to the Cash Flow Manager menu...");
                Console.ReadKey();
                Animation.LoadingBar();
                StatisticsMenuDisplay();
                break;
            case StatsMenu.Inventory_Data:
                // Display inventory data logic here
                DisplayStats.CreateInventoryTable();
                Console.WriteLine("Press any key to return to the Statistics menu...");
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
            Write();
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
                addCash.AddIncome();
                Animation.LoadingBar();
                CashFlowManagerMenuDisplay();
                break;
            case CashMenu.Add_Expenses:
                subtractCash.AddExpenses();
                Animation.LoadingBar();
                CashFlowManagerMenuDisplay();
                break;
            case CashMenu.Calculate_Cash:
                // Calculate cash logic here
                calculateCash.CalculateTotalCash();
                Console.WriteLine("Press any key to return to the Cash Flow Manager menu...");
                Console.ReadKey();
                Animation.LoadingBar();
                CashFlowManagerMenuDisplay();
                break;
            case CashMenu.Display_Cash_Charts:
                // Display cash charts logic here
                DisplayStats.DrawLineGraph(GetCashFlowData());
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

public class  DisplayStats
{
    // Method to draw a line graph based on the provided data
    public static void DrawLineGraph(int[] data)
    {
        int maxHeight = 10;
        int maxData = 0;
        foreach (int d in data)
            if (d > maxData) maxData = d;

        double scale = maxHeight / (double)maxData;

        // For each row from top to bottom
        for (int row = maxHeight; row >= 1; row--)
        {
            foreach (var point in data)
            {
                int pointHeight = (int)(point * scale);
                if (pointHeight == row)
                    Console.Write("* ");
                if (pointHeight < row)
                    Console.Write("  ");
                if (pointHeight > row)
                    Console.Write("| ");
            }
            Console.WriteLine();
        }

        // Draw X-axis line
        for (int i = 0; i < data.Length; i++)
            Console.Write("--");
        Console.WriteLine();

        // Draw indices or labels below x-axis
        for (int i = 0; i < data.Length; i++)
            Console.Write($"{i+1} ");
        Console.WriteLine();
    }
    // Method to create an inventory table with items, quantities, prices, and add dates
    public static void CreateInventoryTable()
    {
        Console.Clear();
        string[] items = new Data().GetInventoryItems();
        int[] quantities = new Data().GetInventoryQuantities();
        double[] prices = new Data().GetInventoryPrices();
        DateTime[] addDates = new Data().GetInventoryAddDates();
        Console.WriteLine("Item\tQuantity\tPrice\tAdd Date");
        Console.WriteLine("-----------------------------------------");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{items[i]}\t{quantities[i]}\t\t{prices[i]:C}\t{addDates[i]:d}");
        }
        Console.WriteLine("-----------------------------------------");
    }
}

public class Animation
{
    //method to display text in the center of the console window
    public static void DisplayCenteredText(string text, int row)
    {
        int col = (Console.WindowWidth - text.Length) / 2;
        Console.SetCursorPosition(col, row);
        Console.Write(text);
    }
    //method to animate typing effect for text in the center of the console window
    public static void AnimateCenteredTyping(string text, int row, int promptLength)
    {
        int startCol = (Console.WindowWidth - (promptLength + 1 + text.Length)) / 2 + promptLength + 7;
        Console.SetCursorPosition(startCol, row);

        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(150);
        }
    }

    public static void LoadingBar()
    {
        Console.Clear();
        int totalWidth = 50; 
        int windowWidth = Console.WindowWidth;
        int windowHeight = Console.WindowHeight;

        // Calculate the starting position for vertical centering
        int topPosition = windowHeight / 2;

        for (int percent = 0; percent <= 100; percent++)
        {
            int blocksToFill = (percent * totalWidth) / 100;

            string bar = new string('█', blocksToFill) + new string(' ', totalWidth - blocksToFill);

            int leftPosition = (windowWidth - (totalWidth + 5)) / 2;

            Console.SetCursorPosition(leftPosition, topPosition);

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{bar}");
            Console.ResetColor();
            Console.Write($"] ");
            Console.Write($"{percent,3}%");

            Thread.Sleep(10);
        }
    }
}
public class Visual
{
    //Opening sequence display for the flowing cash program
    public void DisplayOpening()
    {
        //text for the password and username animation in the center of the console window
        string usernamePrompt = "Enter username:";
        string passwordPrompt = "Enter password:";
        string username = "T.Chinyerere";
        string password = "***********";
        //calculation for the total number of lines to be displayed in the center of the console window
        int totalLines = 2;
        int startRow = (Console.WindowHeight / 2) - (totalLines / 2);

        Animation.DisplayCenteredText(usernamePrompt, startRow);
        Animation.DisplayCenteredText(passwordPrompt, startRow + 1);

        Animation.AnimateCenteredTyping(username, startRow, usernamePrompt.Length);

        Animation.AnimateCenteredTyping(password, startRow + 1, passwordPrompt.Length);

        Console.Clear();

        Animation.LoadingBar();
        Console.Clear();

        string Title = @"
___________.__                .__                 _________               .__     
\_   _____/|  |   ______  _  _|__| ____    ____   \_   ___ \_____    _____|  |__  
 |    __)  |  |  /  _ \ \/ \/ /  |/    \  / ___\  /    \  \/\__  \  /  ___/  |  \ 
 |     \   |  |_(  <_> )     /|  |   |  \/ /_/  > \     \____/ __ \_\___ \|   Y  \
 \___  /   |____/\____/ \/\_/ |__|___|  /\___  /   \______  (____  /____  >___|  /
     \/                               \//_____/           \/     \/     \/     \/ 
                       ";


        //determining the middle point of the console window
        var lines = Title.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        int longestLength = lines.Max(line => line.Length);
        int windowWidth = Console.WindowWidth;
        int windowHeight = Console.WindowHeight;

        int verticalPadding = (windowHeight - lines.Length) / 2;

        Console.CursorTop = verticalPadding;

        foreach (var line in lines)
        {
            int horizontalPadding = (windowWidth - line.Length) / 2;

            Console.SetCursorPosition(horizontalPadding, Console.CursorTop);

            Console.WriteLine(line);
            Thread.Sleep(50); // Adding a slight delay for effect
        }
        Thread.Sleep(1500); // Pause before clearing the console
    }
}

    class CashMain
    {
        private static double amount;

        public double Amount 
            {
                get                     //Encapsulation for amount variable
                { 
                    return amount; 
                }  
                set     
                { 
                    amount = value; 
                }
            }
    }

class AddCash : CashMain
{
    public void AddIncome()
    {
        bool continueAdding = true;
        while (continueAdding)
        {
            Console.WriteLine("Please enter the amount of cash to add:");
            double income;
            if (!double.TryParse(Console.ReadLine(), out income) || income < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid amount. Please enter a positive number.");
                Console.ResetColor();
                continue;
            }
            Amount += income;
            Console.Write("Income added: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{income:C}");
            Console.ResetColor();
            Console.Write(". Total amount: ");
            if (Amount < 0)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (Amount > 0)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (Amount == 0)
                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Amount:C}");
            Console.ResetColor();

            Console.Write("Would you like to add more cash? ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Y/N]");
            Console.ResetColor();
            string input = Console.ReadLine().Trim().ToUpper();
            continueAdding = (input == "Y");
        }
    }
}
class SubtractCash : CashMain
{
    public void AddExpenses()
    {
        bool continueAdding = true;
        while (continueAdding)
        {
            Console.WriteLine("Please enter the amount of cash expenses:");
            double expenses;
            if (!double.TryParse(Console.ReadLine(), out expenses) || expenses < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid amount. Please enter a positive number.");
                Console.ResetColor();
                continue;
            }
            Amount -= expenses;
            Console.Write("Expenses added: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"-{expenses:C}");
            Console.ResetColor();
            Console.Write(". Total amount: ");
            if (Amount < 0)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (Amount > 0)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (Amount == 0)
                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Amount:C}");
            Console.ResetColor();

            Console.Write("Would you like to add more expenses? ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Y/N]");
            Console.ResetColor();
            string input = Console.ReadLine().Trim().ToUpper();
            continueAdding = (input == "Y");
        }
    }
}

    class CalculateCash : CashMain
    {
        public void CalculateTotalCash()
        {
        Console.WriteLine("The current amount of net cash is: R" + Amount);
        }
    }

internal class Program
{
    // Main method to start the application
    private static void Main(string[] args)
    {
        Visual style = new Visual();
        Menu menu = new Menu();

        style.DisplayOpening();
        Console.Clear();
        menu.MainMenuDisplay();
    }
}
