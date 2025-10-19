using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_ph1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a friendly welcome message
            Console.WriteLine("Welcome to my first project *_*");

            //Declare variables
            string userName = "Guest";
            bool isOperational = true;
            int commandsProcessed = 0;
 Console.WriteLine($"Hello {userName} choose the listied command    ");
                Console.WriteLine("1. help - Display available commands");
                Console.WriteLine("2. set_name - Set your user name");
                Console.WriteLine("3. status - Show current status");
                Console.WriteLine("4. exit - Exit the application");
                Console.Write("Enter command:  ");
            while (isOperational)
            {
               
                // prompt the user for input
                string input = Console.ReadLine();
                switch (input) {
                
                case "help":
                        ShowHelp();
                     
                        commandsProcessed++;
                        break;
                    case "set_name":
                        userName = setUserNAme(userName);
                        //Console.WriteLine($"hello { userName}");
                        repeatcommand(userName);
                        commandsProcessed++;
                        break;
                    case "status":
                        ShowStatus( userName, isOperational, commandsProcessed);
                        commandsProcessed++;
                        repeatcommand(userName);
                        break;
                    case "exit":
                        ExitApplication(userName);
                        isOperational = false;
                        break;
                    default:
                        InvalidCommand(input);
                        commandsProcessed++;
                        //repeatcommand(userName);
                        break;





                }



            }
        }
        public static void ShowHelp()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("help - Display available commands");
            Console.WriteLine("set_name - Set your user name");
            Console.WriteLine("status - Show current status");
            Console.WriteLine("exit - Exit the application");
            Console.Write("Enter command:  ");
        }
        public static string setUserNAme(string name)
        {
            Console.WriteLine("Enter your new user name: ");
            string newName = Console.ReadLine();
            return newName;
        }
        static void ShowStatus(string userName, bool isOperational, int commandsProcessed)
        {
            Console.WriteLine("Current Status:");
            Console.WriteLine($"User Name: {userName}");
            Console.WriteLine($"Operational: {isOperational}");
            Console.WriteLine($"Commands Processed: {commandsProcessed}");
        }

        static void ExitApplication(string userName)
        {
            Console.WriteLine($"Goodbye, {userName}.");

        }
        static void InvalidCommand(string command)
        {
            Console.WriteLine($"Invalid command: '{command}'. Type 'help' to see available commands.");
        }
        static void repeatcommand(string userName)
        {
            Console.WriteLine($"Hello {userName} choose the listied command    ");
            Console.WriteLine("1. help - Display available commands");
            Console.WriteLine("2. set_name - Set your user name");
            Console.WriteLine("3. status - Show current status");
            Console.WriteLine("4. exit - Exit the application");
            Console.Write("Enter command:  ");
        }
    }

}
