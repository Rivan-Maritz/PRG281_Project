using System;
using System.Buffers.Text;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using PRG281_Project;
using Project281.InventoryManager;

//Rivan Maritz 601530
//Theart Jooste 601288
//Tetelop Phahladira 601950

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

public class Menu 
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
        InventoryManagerClass inventoryManager = new InventoryManagerClass();
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
