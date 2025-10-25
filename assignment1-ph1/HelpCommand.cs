using System;

namespace assignment1_ph1
{
    internal class HelpCommand : ICommand
    {
        public string Name => "help";

        public void Execute(CommandCenter center)
        {
            Console.WriteLine();
            Console.WriteLine("Available commands:");
            Console.WriteLine("help - Display available commands");
            Console.WriteLine("set_name - Set your user name");
            Console.WriteLine("status - Show current status");
            Console.WriteLine("exit - Exit the application");
            Console.WriteLine();
            center.DisplayMenu();
        }
    }
}
