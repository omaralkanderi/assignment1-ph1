using System;

namespace assignment1_ph1
{
    internal class StatusCommand : ICommand
    {
        public string Name => "status";

        public void Execute(CommandCenter center)
        {
            Console.WriteLine("Current Status:");
            Console.WriteLine($"User Name: {center.userName}");
            Console.WriteLine($"Operational: {center.isOperational}");
            Console.WriteLine($"Commands Processed: {center.commandsProcessed}");
            Console.WriteLine();
            center.DisplayMenu();
        }
    }
}
