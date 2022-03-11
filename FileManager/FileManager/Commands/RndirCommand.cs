using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands
{
    [Verb(Messages.commandRndir, HelpText = Messages.HelpTextRndir)]
    public class RndirCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine("Executing rename");
        }
    }
}
