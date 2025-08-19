using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
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
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{bar}");
                Console.ResetColor();
                Console.Write($"] ");
                Console.Write($"{percent,3}%");

                Thread.Sleep(10);
            }
        }
    }
}
