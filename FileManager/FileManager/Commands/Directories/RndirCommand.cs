using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;
using Microsoft.VisualBasic;

namespace FileManager.Commands.Directories
{
    [Verb(Messages.commandRndir, HelpText = Messages.HelpTextRndir)]
    public class RndirCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine();

            string fullPathNameSource, fullPathNameDestination = string.Empty;

            if (Validators.HasArgsValid(args, 3))
            {
                fullPathNameSource = Path.GetFullPath(args[1]);

                if (args[2].Contains("/") || args[2].Contains("//") || args[2].Contains(@"\") || args[2].Contains("\\"))
                {
                    Messages.printConsole($"{Messages.error} {args[2]}, {Messages.ErrorValidationFolderName}", ConsoleColor.Red);
                }
                else
                {
                    string? currentPath = Path.GetDirectoryName(fullPathNameSource) ?? null;
                    fullPathNameDestination = Path.Combine(currentPath, args[2]);

                    if (Validators.IsPathValid(fullPathNameSource))
                    {
                        if (Directory.Exists(fullPathNameSource))
                        {
                            try
                            {
                                OperatingSystem os_info = Environment.OSVersion;
                                if (os_info.Platform.ToString().ToLower().Contains("win"))
                                {
                                    FileSystem.Rename(fullPathNameSource, fullPathNameDestination);
                                    Messages.printConsole($"{Messages.directory} {fullPathNameSource} moved to {fullPathNameDestination}", ConsoleColor.Green);
                                }
                                else
                                {
                                    //TODO: search other implementation
                                    Messages.printConsole($"Command only supported on Windows OS!", ConsoleColor.Red);
                                }
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
}
