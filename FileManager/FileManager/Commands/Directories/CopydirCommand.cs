using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands.Directories
{
    [Verb(Messages.commandCopydir, HelpText = Messages.HelpTextCopydir)]
    public class CopydirCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine();

            string fullPathNameSource, fullPathNameDestination = string.Empty;

            if (Validators.HasArgsValid(args, 3))
            {
                fullPathNameSource = Path.GetFullPath(args[1]);
                fullPathNameDestination = Path.GetFullPath(args[2]);

                if (Validators.IsPathValid(fullPathNameSource) && Validators.IsPathValid(fullPathNameDestination))
                {
                    if (Directory.Exists(fullPathNameSource))
                    {
                        try
                        {
                            CopyDirectory(fullPathNameSource, fullPathNameDestination, true);
                            Messages.printConsole($"{Messages.directory} {fullPathNameSource} copied to {fullPathNameDestination}", ConsoleColor.Green);
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

        private void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            var dir = new DirectoryInfo(sourceDir);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath, true);
            }

            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
    }
}
