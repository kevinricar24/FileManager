using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands
{
    [Verb(Messages.commandPwd, HelpText = Messages.HelpTextPwd)]
    public class PwdCommand : ICommand
    {
        
        public void Execute(string[] args)
        {
            Console.WriteLine();
            Messages.printConsole(Messages.path, ConsoleColor.Green);
            Messages.printConsole(Messages.separator4, ConsoleColor.Green);
            Messages.printConsole(Directory.GetCurrentDirectory(), ConsoleColor.Green);
            Console.WriteLine();
        }
    }
}
