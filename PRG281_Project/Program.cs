using System;
using System.Buffers.Text;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;


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

public class Menu : Animation
{

    
    public void Write()
    {
        Console.WriteLine("    ███████ ██       ██████  ██     ██ ██ ███    ██  ██████       ██████  █████  ███████ ██   ██ \r\n"+ 
                          "   ██      ██      ██    ██ ██     ██ ██ ████   ██ ██           ██      ██   ██ ██      ██   ██ \r\n" +
                          "  █████   ██      ██    ██ ██  █  ██ ██ ██ ██  ██ ██   ███     ██      ███████ ███████ ███████ \r\n" +
                          " ██      ██      ██    ██ ██ ███ ██ ██ ██  ██ ██ ██    ██     ██      ██   ██      ██ ██   ██ \r\n" +
                          "██      ███████  ██████   ███ ███  ██ ██   ████  ██████       ██████ ██   ██ ███████ ██   ██ \r\n\r\n" +

                          "████████████████████████████████████████████████████████████████████████████████████████████████ \r\n"+
                           " ████████████████████████████████████████████████████████████████████████████████████████████████ \r\n"
                      );
    }

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

        Console.Clear();
        switch (options[selectedIndex])
        {
            case MainMenu.Inventory:
                LoadingBar();
                InventoryMenuDisplay();
                break;
            case MainMenu.CashFlow_Manager:
                LoadingBar();
                CashFlowManagerMenuDisplay();
                break;
            case MainMenu.Statistics:
                LoadingBar();
                StatisticsMenuDisplay();
                break;
            case MainMenu.Exit:
                Environment.Exit(0);
                break;
        }
    }

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
                break;
            case InventoryMenu.Return:
                LoadingBar();
                MainMenuDisplay();
                break;
        }

    }

    public void CashFlowManagerMenuDisplay()
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
                // Add income logic here
                break;
            case StatsMenu.Inventory_Data:
                // Add expenses logic here
                break;
            case StatsMenu.Return:
                LoadingBar();
                MainMenuDisplay();
                break;
        }
    }

    public void StatisticsMenuDisplay()
    {
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
                // Add income logic here
                break;
            case CashMenu.Add_Expenses:
                // Add expenses logic here
                break;
            case CashMenu.Calculate_Cash:
                // Calculate cash logic here
                break;
            case CashMenu.Display_Cash_Charts:
                // Display cash charts logic here
                break;
            case CashMenu.Return:
                LoadingBar();
                MainMenuDisplay();
                break;
        }
    }
}

public class Animation
{
    //method to display text in the center of the console window
    public void DisplayCenteredText(string text, int row)
    {
        int col = (Console.WindowWidth - text.Length) / 2;
        Console.SetCursorPosition(col, row);
        Console.Write(text);
    }
    //method to animate typing effect for text in the center of the console window
    public void AnimateCenteredTyping(string text, int row, int promptLength)
    {
        int startCol = (Console.WindowWidth - (promptLength + 1 + text.Length)) / 2 + promptLength + 7;
        Console.SetCursorPosition(startCol, row);

        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(150);
        }
    }

    public void LoadingBar()
    {
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
            Console.Write($"[{bar}] {percent,3}%");

            Thread.Sleep(10);
        }
    }
}
public class Visual : Animation
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

        DisplayCenteredText(usernamePrompt, startRow);
        DisplayCenteredText(passwordPrompt, startRow + 1);

        AnimateCenteredTyping(username, startRow, usernamePrompt.Length);

        AnimateCenteredTyping(password, startRow + 1, passwordPrompt.Length);

        Console.Clear();

        LoadingBar();
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

    private static void Main(string[] args)
    {
        Visual style = new Visual();
        Menu menu = new Menu();

        style.DisplayOpening();
        Console.Clear();
        menu.MainMenuDisplay();
    }
}
