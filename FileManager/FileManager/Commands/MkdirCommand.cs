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
            Console.WriteLine();

            string fullPathName = string.Empty;

            if (Validators.HasArgsValid(args, 2))
            {
                fullPathName = Path.GetFullPath(args[1]);

                if (Validators.IsPathValid(fullPathName))
                {
                    if (!Directory.Exists(fullPathName))
                    {
                        Directory.CreateDirectory(fullPathName);
                        Messages.printConsole($"{Messages.directory} {fullPathName} created!", ConsoleColor.Green);
                    }
                    else
                    {
                        Messages.printConsole($"{Messages.directory} {fullPathName} exist!", ConsoleColor.Yellow);
                    }
                }
            }
        }
    }
}
