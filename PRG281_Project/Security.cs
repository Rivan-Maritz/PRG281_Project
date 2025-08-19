using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PRG281_Project
{
    class Security
    {
        const string storeID = "MTIzNA=="; // PS: SUPER HIDDEN, the password is "1234"

        public event EventHandler AccessGranted; //EVENT for acces that has been granted to the user  //EVENTTT HERE <------
        public event EventHandler AccessDenied; //EVENT for access that has been denied to the user   //EVENTTT HERE <------

        public void GetInformation()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
                                                |\                     /)
                                              /\_\\__               (_//
                                             |   `>\-`     _._       //`)
                                              \ /` \\  _.-`:::`-._  //
                                               `    \|`    :::    `|/
                                                     |     :::     |
                                                     |.....:::.....|
                                                     |:::::::::::::|
                                                     |     :::     |
                                                     \     :::     /
                                                      \    :::    /
                                                       `-. ::: .-'
                                                        //`:::`\\
                                                       //   '   \\
                                                      |/         \\");
            Console.WriteLine(" ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                             Application Security Measures                                             ");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

            int attempts = 0;
            const int maxAttempts = 3;

            while (attempts < maxAttempts)
            {
                Console.Write("                                             Please enter store password: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string password = Console.ReadLine();
                Console.ResetColor();

                string encoded = HashPassword(password);

                if (TestPassword(encoded))
                {
                    AccessGranted?.Invoke(this, EventArgs.Empty); //Raise event for access granted
                    return;
                }
                else
                {
                    AccessDenied?.Invoke(this, EventArgs.Empty); // Raise event fr access denied
                    attempts++;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($" {maxAttempts - attempts}");
                    Console.WriteLine(" ");
                    Console.ResetColor();
                }
            }

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                       Too many failed attempts. Exiting program...");
            Console.ResetColor();
            Environment.Exit(0);
        }

        public string HashPassword(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            string encoded = Convert.ToBase64String(bytes);
            return encoded;
        }

        public bool TestPassword(string encodedPassword)
        {
            return encodedPassword == storeID;
        }
    }
}