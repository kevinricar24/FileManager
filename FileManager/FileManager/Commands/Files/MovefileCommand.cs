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
                        if (Directory.Exists(fullPathNameDestination))
                        {
                            try
                            {
                                string fullPathNameSourceExt = Path.Combine(fullPathNameDestination, Path.GetFileName(fullPathNameSource));
                                File.Move(fullPathNameSource, fullPathNameSourceExt, true);
                                Messages.printConsole($"{Messages.file} {fullPathNameSource} moved to {fullPathNameDestination}", ConsoleColor.Green);
                            }
                            catch (Exception ex)
                            {
                                Messages.printConsole($"{ex.Message}", ConsoleColor.Red);
                            }
                        }
                        else
                        {
                            Messages.printConsole($"{Messages.directory} {fullPathNameDestination} not exist!", ConsoleColor.Red);
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
