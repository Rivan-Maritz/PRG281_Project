using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    class CashMain
    {
        ASCII Ascii = new ASCII(); 

        private static double amount;
        protected static double[] IncomeCashArr = new double[500]; // Array to store income cash values
        protected static double[] ExpenseCashArr = new double[500]; // Array to store income cash values
        protected static int incomeIndex = 0; // Index for income cash array
        protected static int expenseIndex = 0; // Index for expense cash array


        public static double Amount
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
        public static double AmountValue
        {
            get { return amount; }
        }
    }

    class AddCash : CashMain
    {
        public void AddIncome()
        {

            ASCII display = new ASCII();
            bool continueAdding = true;

            display.IncomeModuleDisplay();

            while (continueAdding)
            {
                double income;

                Console.WriteLine("Please enter the amount of cash to add :");
                if (!double.TryParse(Console.ReadLine(), out income) || income < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid amount. Please enter a positive number.");
                    Console.ResetColor();
                    continue;
                }

                Amount += income;
                IncomeCashArr[incomeIndex] = income;
                incomeIndex++;

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
            ASCII display = new ASCII();                                                                            //Instantiate the ASCII class to display the module art

            bool continueAdding = true;
            const double VAT = 0.15;                                                                                //Constant VAT rate of 15% 

            display.ExpenseModuleDisplay();                                                                         //We call the ExpenseModuleDisplay method to display the ASCII art for the expense module

            while (continueAdding)                                                                                  //We use loops to control the amount of expense inputs we would like to add
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("                   Is this purchase VAT-inclusive? [Y/N]                   ");
                Console.ResetColor();
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("            Y - will automaticly add VAT to the amount entered             ");
                Console.WriteLine("            N - will ensure the purchase was not VAT-inclusive             ");
                Console.ResetColor();
                Console.WriteLine("---------------------------------------------------------------------------");

                string inputVAT = Console.ReadLine().Trim().ToUpper();                                              //Receives user input for VAT inclusion
                Console.WriteLine("");

                double finalExpense;
                double expenses;

                Console.WriteLine("Please enter the amount of cash expenses:");
                if (!double.TryParse(Console.ReadLine(), out expenses) || expenses < 0)                             //ensures that the user inputs a valid amount for expenses
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid amount. Please enter a positive number.");
                    Console.ResetColor();
                    continue;
                }

                if (inputVAT == "Y")                                                                                //checks if the user input for VAT is Y or N
                {
                    finalExpense = expenses * (1 + VAT);                                                            //adds VAT to the entered amount
                }
                else if (inputVAT == "N")
                {
                    finalExpense = expenses;                                                                        //ignores VAT if the user input is N
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid VAT option. Please enter Y or N.");
                    Console.ResetColor();
                    continue;
                }

                Amount -= finalExpense;
                ExpenseCashArr[expenseIndex] = finalExpense;
                expenseIndex++;

                Console.Write("Expenses added: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"-{finalExpense:C}");
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
            ASCII display = new ASCII();                              //Instantiate the ASCII class to display the module art
            display.CashModuleDisplay();                              //We call the CashModuleDisplay method to display the ASCII art for the net cash module

            Console.Write("The current amount of net cash is: ");

            if (Amount < 0)                                           //We use if statements to determine the color of the text based on the amount
                Console.ForegroundColor = ConsoleColor.Red;           //This is for user experience, to easily identify if the amount is negative, positive, or zero
            else if (Amount > 0)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (Amount == 0)
                Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{Amount:C}");                         //The {amount:C} format specifier is used to display the amount as a currency value
            Console.ResetColor();
        }
    }

    class CashStatistics : CashMain
    {
        public void displayCashCharts()
        {

        }
    }
}
