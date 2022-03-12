using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;


namespace FileManager.Commands.Files
{
    [Verb(Messages.commandRmfile, HelpText = Messages.HelpTextRmfile)]
    public class RmfileCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine();

            string fullPathName = string.Empty;

            if (Validators.HasArgsValid(args, 2))
            {
                fullPathName = Path.GetFullPath(args[1]);

                if (Validators.IsPathFileValid(fullPathName))
                {
                    if (!File.Exists(fullPathName))
                    {
                        Messages.printConsole($"{Messages.file} {fullPathName} not exist!", ConsoleColor.Red);
                    }
                    else
                    {
                        try
                        {
                            File.Delete(fullPathName);
                            Messages.printConsole($"{Messages.file} {fullPathName} removed!", ConsoleColor.Green);
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
