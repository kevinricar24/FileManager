using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands.Directories
{
    [Verb(Messages.commandRmdir, HelpText = Messages.HelpTextRmdir)]
    public class RmdirCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine();

            string fullPathName = string.Empty;

            if (Validators.HasArgsValid(args, 2))
            {
                fullPathName = Path.GetFullPath(args[1]);

                if (Validators.IsPathValid(fullPathName))
                {
                    if (!Directory.Exists(fullPathName))
                    {
                        Messages.printConsole($"{Messages.directory} {fullPathName} not exist!", ConsoleColor.Red);
                    }
                    else
                    {
                        try
                        {
                            Directory.Delete(fullPathName);
                            Messages.printConsole($"{Messages.directory} {fullPathName} removed!", ConsoleColor.Yellow);
                        }
                        catch (Exception ex)
                        {
                            Messages.printConsole($"{ex.Message}", ConsoleColor.Red);
                        }
                    }
                }
            }
        }
    }
}
