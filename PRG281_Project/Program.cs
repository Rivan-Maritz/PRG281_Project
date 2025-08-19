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

//enums for the main menu
//Consisting of Inventory, Cash Flow Manager, Statistics, and Exit
enum MainMenu
{
    Inventory,
    CashFlow_Manager,
    Statistics,
    Exit
}

//enums for the Inventory menu
//Consisting of Add Item, Remove Item, View Inventory, Low Stock Inventory, and Return
enum InventoryMenu
{
    Add_Item,
    Remove_Item,
    View_Inventory,
    Low_Stock_Inventory,
    Return
}

//enums for the Cash Flow Manager menu
//Consisting of Add Income, Add Expenses, Calculate Cash, Display Cash Charts, and Return
enum CashMenu
{
    Add_Income,
    Add_Expenses,
    Calculate_Cash,
    Display_Cash_Charts,
    Return
}

//enums for the Statistics menu
//Consisting of Cash Chart, Inventory Data, and Return
enum StatsMenu
{
    Cash_Chart,
    Inventory_Data,
    Return
}

public class Visual     //public since we want to access this class from the LoginDisplay class
{
    //Opening sequence display for the flowing cash program
    public void DisplayOpening()
    {
        LoginDisplay loginDisplay = new LoginDisplay();     //creating an instance of the LoginDisplay class to handle the login display
        loginDisplay.DisplayOpening();
    }
}

internal class Program  // Main class to run the application
{
    // Main method to start the application
    private static void Main(string[] args) 
    {
        Visual style = new Visual();
        Menu menu = new Menu();     //Just creating an instance of the Menu class to handle the main menu display

        style.DisplayOpening();     //Calling some methods to display the opening sequence of the application
        Console.Clear();
        menu.MainMenuDisplay();
    }
}
