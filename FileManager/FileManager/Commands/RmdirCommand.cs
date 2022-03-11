using CommandLine;
using FileManager.Utilities;

namespace FileManager.Commands
{
    [Verb(Messages.commandRmdir, HelpText = Messages.HelpTextRmdir)]
    public class RmdirCommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine("Executing remove");
        }
    }
}
