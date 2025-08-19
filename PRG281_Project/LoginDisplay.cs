using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    class LoginDisplay
    {
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

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Animation.DisplayCenteredText(usernamePrompt, startRow);
            Animation.DisplayCenteredText(passwordPrompt, startRow + 1);
            Console.ResetColor();

            Animation.AnimateCenteredTyping(username, startRow, usernamePrompt.Length);

            Animation.AnimateCenteredTyping(password, startRow + 1, passwordPrompt.Length);

            Console.Clear();

            Security security = new Security(); // Instantiate the Security class to handle login validation

            //Subscribe to events both Access Grated and denied
            security.AccessGranted += OnAccessGranted;
            security.AccessDenied += OnAccessDenied;

            security.GetInformation(); // Call the method to get user input for login validation

            Thread loadingThread = new Thread(Animation.LoadingBar);                //CUSTOM THREADING
            loadingThread.Start();      // Starting the thread loadingThread
            loadingThread.Join();       // Wait for the loading bar to finish

            Console.Clear();

            ASCII ascii = new ASCII();                                                  
            Thread displaythread = new Thread(ascii.CashFlowDisplay);               //CUSTOM THREADING
            displaythread.Start();      // Starting the thread displaythread
            displaythread.Join();       // Wait for the display thread to finish



            //These below are the event methods that will be called when the events are raised
            static void OnAccessGranted(object sender, EventArgs e)                 //EVENT METHODS   <-------------------------
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                           Access granted! Welcome to the system.");
                Console.WriteLine(" ");
                Console.ResetColor();
                Console.WriteLine("Please wait...");
                Thread.Sleep(3000);
            }

            static void OnAccessDenied(object sender, EventArgs e)                  //EVENT METHODS   <-------------------------
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("                              Access denied. Please try again later. Total Attempts Left");
                Console.ResetColor();
            }
        }
    }
}
