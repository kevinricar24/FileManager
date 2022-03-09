using CommandLine;
using FileManager.Commands.Interfaces;

namespace FileManager.Commands
{
    [Verb("help", HelpText = "Show Current Directory")]
    public class HelpCommand : ICommand
    {
        public void Execute(string[] args)
        {
            //TODO: Add commands information Here
        }
    }
}
