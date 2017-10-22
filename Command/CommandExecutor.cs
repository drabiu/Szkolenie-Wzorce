using System;

namespace Jedzenie
{
    public class CommandExecutor
    {
        public void Execute(ICommand command)
        {
           command.Execute();
        }
    }
}