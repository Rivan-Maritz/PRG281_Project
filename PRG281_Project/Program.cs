using System;
using System.Buffers.Text;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

public class Visual
{
    //Opening sequence display for the flowing cash program
    public void DisplayOpening()
    {




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
            Thread.Sleep(100); // Adding a slight delay for effect
        }
    }
}

internal class Program
{

    private static void Main(string[] args)
    {
        Visual style = new Visual();

        style.DisplayOpening();
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("\r\n    ███████ ██       ██████  ██     ██ ██ ███    ██  ██████       ██████  █████  ███████ ██   ██ \r\n" +
                              "   ██      ██      ██    ██ ██     ██ ██ ████   ██ ██           ██      ██   ██ ██      ██   ██ \r\n" +
                              "  █████   ██      ██    ██ ██  █  ██ ██ ██ ██  ██ ██   ███     ██      ███████ ███████ ███████ \r\n" +
                              " ██      ██      ██    ██ ██ ███ ██ ██ ██  ██ ██ ██    ██     ██      ██   ██      ██ ██   ██ \r\n" +
                              "██      ███████  ██████   ███ ███  ██ ██   ████  ██████       ██████ ██   ██ ███████ ██   ██ \r\n\r\n" +
                              "████████████████████████████████████████████████████████████████████████████████████████████████ \r\n" +
                              " ████████████████████████████████████████████████████████████████████████████████████████████████"
                              );
    }
}
