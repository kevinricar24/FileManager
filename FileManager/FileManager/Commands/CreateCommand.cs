using CommandLine;
using FileManager.Commands.Interfaces;

namespace FileManager.Commands
{
    [Verb("create", HelpText = "Save all your commits to the cloud")]
    public class CreateCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine("Executing create");
        }
    }
}
