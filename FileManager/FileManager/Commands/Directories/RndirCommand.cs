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
                    string myPath = currentPath == null ? string.Empty : currentPath;
                    fullPathNameDestination = Path.Combine(myPath, args[2]);

                    if (Validators.IsPathValid(fullPathNameSource))
                    {
                        if (Directory.Exists(fullPathNameSource))
                        {
                            try
                            {
                                OperatingSystem os_info = Environment.OSVersion;
                                if (os_info.Platform.ToString().ToLower().Contains("win"))
                                {
                                    string fpSource = fullPathNameSource ?? string.Empty;
                                    string fpDestination = fullPathNameDestination ?? string.Empty;
#pragma warning disable CA1416 // Validate platform compatibility
                                    FileSystem.Rename(fpSource, fpDestination);
#pragma warning restore CA1416 // Validate platform compatibility
                                    Messages.printConsole($"{Messages.directory} {fullPathNameSource} renamed to {fullPathNameDestination}", ConsoleColor.Green);
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
