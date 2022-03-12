using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands.Files
{
    [Verb(Messages.commandMovefile, HelpText = Messages.HelpTextMovefile)]
    public class MovefileCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine();

            string fullPathNameSource, fullPathNameDestination = string.Empty;

            if (Validators.HasArgsValid(args, 3))
            {
                fullPathNameSource = Path.GetFullPath(args[1]);
                fullPathNameDestination = Path.GetFullPath(args[2]);

                if (Validators.IsPathFileValid(fullPathNameSource) && Validators.IsPathValid(fullPathNameDestination))
                {
                    if (File.Exists(fullPathNameSource))
                    {
                        try
                        {
                            File.Move(fullPathNameSource, fullPathNameDestination + Messages.extension);
                            Messages.printConsole($"{Messages.file} {fullPathNameSource} moved to {fullPathNameDestination}", ConsoleColor.Green);
                        }
                        catch (Exception ex)
                        {
                            Messages.printConsole($"{ex.Message}", ConsoleColor.Red);
                        }
                    }
                    else
                    {
                        Messages.printConsole($"{Messages.file} {fullPathNameSource} not exist!", ConsoleColor.Red);
                    }
                }
            }
        }
    }
}
