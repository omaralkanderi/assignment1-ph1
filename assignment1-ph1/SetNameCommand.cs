using System;

namespace assignment1_ph1
{
    internal class SetNameCommand : ICommand
    {
        public string Name => "set_name";

        public void Execute(CommandCenter center)
        {
            Console.WriteLine("Enter your new user name: ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrEmpty(newName))
            {
                center.SetUserName(newName);
            }
            center.DisplayMenu();
        }
    }
}
