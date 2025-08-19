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

            Animation.LoadingBar();
            Console.Clear();

            ASCII ascii = new ASCII();
            ascii.CashFlowDisplay();
        }
    }
}
