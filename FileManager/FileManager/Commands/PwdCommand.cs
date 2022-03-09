using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands
{
    [Verb("pwd", HelpText = "Show Current Directory")]
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
