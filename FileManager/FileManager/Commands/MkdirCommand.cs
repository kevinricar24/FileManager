using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands
{
    [Verb(Messages.commandMkdir, HelpText=Messages.HelpTextMkdir)]
    public class MkdirCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine("Executing create");
        }
    }
}
