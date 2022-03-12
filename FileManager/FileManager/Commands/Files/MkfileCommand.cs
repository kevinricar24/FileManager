using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands.Files
{
    [Verb(Messages.commandMkfile, HelpText = Messages.HelpTextMkfile)]
    public class MkfileCommand : ICommand
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
                    if (!Directory.Exists(fullPathName))
                    {
                        try
                        {
                            File.Create(fullPathName);
                            Messages.printConsole($"{Messages.file} {fullPathName} created!", ConsoleColor.Green);
                        }
                        catch (Exception ex)
                        {
                            Messages.printConsole($"{ex.Message}", ConsoleColor.Red);
                        }
                    }
                    else
                    {
                        Messages.printConsole($"{Messages.file} {fullPathName} exist!", ConsoleColor.Yellow);
                    }
                }
            }
        }
    }
}
