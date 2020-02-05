using System;
using TheWeddingShop.Direction;

namespace TheWeddingShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var landscape = new Landscape(5, 0, 0);
            var rover = new Rover(landscape, new North(landscape));

            Console.WriteLine($"The current rover position: {rover}");
            WriteInstruction();
            var commandsToExecute = string.Empty;

            while (commandsToExecute != "E")
            {
                Console.Write("Enter Commands: ");
                commandsToExecute = Console.ReadLine();
                rover.ExecuteCommands(commandsToExecute?.ToUpper());
                Console.WriteLine();
                Console.WriteLine($"Current Rover Position Heading: {rover.ToString()}");
            }
        }

        private static void WriteInstruction()
        {
            Console.WriteLine("Valid Commands are:");
            Console.WriteLine("L - Turn Rover Left");
            Console.WriteLine("R - Turn Rover Right");
            Console.WriteLine("M - Move Rover Forward");
            Console.WriteLine("E - End");
            Console.WriteLine("Enter to execute commands");
        }
    }
}
