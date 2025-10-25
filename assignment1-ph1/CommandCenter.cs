using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_ph1
{ ///////////////////////////////////// PART 3 /////////////////////////////////////    
    internal class CommandCenter
    {
        public string userName { get; private set; }
        public bool isOperational { get; private set; }
        public int commandsProcessed { get; private set; }

        private readonly Dictionary<string, ICommand> commands;

        public CommandCenter()
        {
            this.userName = "Guest";
            this.isOperational = true;
            this.commandsProcessed = 0;

            // populate command dictionary
            commands = new Dictionary<string, ICommand>(StringComparer.OrdinalIgnoreCase)
            {
                { "help", new HelpCommand() },
                { "status", new StatusCommand() },
                { "set_name", new SetNameCommand() }
            };
        }

        public void run()
        {
            Console.WriteLine("Welcome to my first project -part3 *_*");
            Console.WriteLine(); // to make space between lines
            DisplayMenu();

            while (isOperational)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    // ignore empty input
                    continue;
                }

                // Handle exit separately
                if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    ExitApplication(userName);
                    isOperational = false;
                    break;
                }

                // Lookup command and execute
                if (commands.TryGetValue(input, out ICommand cmd))
                {
                    cmd.Execute(this);
                    IncrementCommandsProcessed();
                }
                else
                {
                    InvalidCommand(input);
                    IncrementCommandsProcessed();
                }
            }
        }

        // allow commands to set user name via CommandCenter instance
        public void SetUserName(string name)
        {
            this.userName = name;
        }

        // allow CommandCenter loop to increment
        public void IncrementCommandsProcessed()
        {
            this.commandsProcessed++;
        }

        // prints the available commands and prompt
        public void DisplayMenu()
        {
            Console.WriteLine($"Hello {userName} choose the listied command    ");
            Console.WriteLine("1. help - Display available commands");
            Console.WriteLine("2. set_name - Set your user name");
            Console.WriteLine("3. status - Show current status");
            Console.WriteLine("4. exit - Exit the application");
            Console.WriteLine();
            Console.Write("Enter command:  ");
        }

        // kept as helper methods for exit/invalid
        static void ExitApplication(string userName)
        {
            Console.WriteLine($"Goodbye, {userName}.");
        }

        static void InvalidCommand(string command)
        {
            Console.WriteLine($"Invalid command: '{command}'. Type 'help' to see available commands.");
            Console.WriteLine();
            Console.Write("Enter command:  ");
        }
    }
}
