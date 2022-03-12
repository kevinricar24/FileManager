using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands.Directories
{
    [Verb(Messages.commandMovedir, HelpText = Messages.HelpTextMovedir)]
    public class MovedirCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine();

            string fullPathNameSource, fullPathNameDestination = string.Empty;

            if (Validators.HasArgsValid(args, 3))
            {
                fullPathNameSource = Path.GetFullPath(args[1]);
                fullPathNameDestination = Path.GetFullPath(args[2]);

                if (Validators.IsPathValid(fullPathNameSource) && Validators.IsPathValid(fullPathNameDestination))
                {
                    if (Directory.Exists(fullPathNameSource))
                    {
                        try
                        {
                            Directory.Move(fullPathNameSource, fullPathNameDestination);
                            Messages.printConsole($"{Messages.directory} {fullPathNameSource} moved to {fullPathNameDestination}", ConsoleColor.Green);
                        }
                        catch (Exception ex)
                        {
                            Messages.printConsole($"{ex.Message}", ConsoleColor.Red);
                        }
                    }
                    else
                    {
                        Messages.printConsole($"{Messages.directory} {fullPathNameSource} not exist!", ConsoleColor.Red);
                    }
                }
            }
        }
    }
}
