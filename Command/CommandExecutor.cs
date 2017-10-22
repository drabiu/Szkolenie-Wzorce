using System;
using System.Collections.Generic;

namespace Jedzenie
{
    public class CommandExecutor
    {
        private readonly IList<string> _commandHistory;

        public CommandExecutor()
        {
            _commandHistory = new List<string>();
        }

        public void Execute(ICommand command)
        {
           command.Execute();
           _commandHistory.Add(command.ToString());
        }

        public IEnumerable<string> GetCommandHistory()
        {
            return _commandHistory;
        }
    }
}