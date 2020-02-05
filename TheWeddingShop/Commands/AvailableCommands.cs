using System.Collections.Generic;
using TheWeddingShop.Interfaces;

namespace TheWeddingShop.Commands
{
    public static class AvailableCommands
    {
        public static Dictionary<string, ICommand> List
        {
            get
            {
                var commands = new Dictionary<string, ICommand>
                    {
                        {"M", new ForwardCommand()},
                        {"L", new TurnLeftCommand()},
                        {"R", new TurnRightCommand()}
                    };
                return commands;
            }
        }
    }
}