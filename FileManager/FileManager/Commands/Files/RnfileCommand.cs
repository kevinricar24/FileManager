using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands.Files
{
    [Verb(Messages.commandRnfile, HelpText = Messages.HelpTextRnfile)]
    public class RnfileCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine();

            string fullPathNameSource, fullPathNameDestination = string.Empty;

            if (Validators.HasArgsValid(args, 3))
            {
                fullPathNameSource = Path.GetFullPath(args[1]);

                if (Validators.IsPathFileValid(fullPathNameSource))
                {
                    if (File.Exists(fullPathNameSource))
                    {
                        try
                        {

                            string? currentPath = Path.GetDirectoryName(fullPathNameSource) ?? null;
                            string myPath = currentPath == null ? string.Empty : currentPath;
                            fullPathNameDestination = Path.Combine(myPath, args[2]);
                            fullPathNameDestination += Messages.extension;
                            File.Move(fullPathNameSource, fullPathNameDestination);
                            Messages.printConsole($"{Messages.file} {fullPathNameSource} renamed to {fullPathNameDestination}", ConsoleColor.Green);
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
