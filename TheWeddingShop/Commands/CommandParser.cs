using System.Collections.Generic;
using TheWeddingShop.Interfaces;

namespace TheWeddingShop.Commands
{
    public class CommandParser
    {
        private readonly Dictionary<string, ICommand> _commands;

        public CommandParser(Dictionary<string, ICommand> commands)
        {
            _commands = commands;
        }

        public ICommand ParseCommand(string command)
        {
            return _commands.ContainsKey(command) ? _commands[command] : new NotFoundCommand();
        }
    }
}
