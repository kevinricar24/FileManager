using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;


namespace FileManager.Commands.Files
{
    [Verb(Messages.commandCopyfile, HelpText = Messages.HelpTextCopyfile)]
    public class CopyfileCommand : ICommand
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
                                File.Copy(fullPathNameSource, fullPathNameSourceExt);
                                Messages.printConsole($"{Messages.file} {fullPathNameSource} copied to {fullPathNameDestination}", ConsoleColor.Green);
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
