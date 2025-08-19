using PRG281_Project;
using Project281.InventoryManager;
using System;
using System.Buffers.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

public class Visual
{
    //Opening sequence display for the flowing cash program
    public void DisplayOpening()
    {
        LoginDisplay loginDisplay = new LoginDisplay();
        loginDisplay.DisplayOpening();
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
