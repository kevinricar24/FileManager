using CommandLine;
using FileManager.Commands.Interfaces;
using FileManager.Utilities;

namespace FileManager.Commands
{
    [Verb(Messages.commandDir, HelpText = Messages.HelpTextDir)]
    public class DirCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine();

            string myDir = Directory.GetCurrentDirectory();
            if (args.Length-1 > 0)
            {
                if (!args[1].Equals(string.Empty))
                {
                    myDir = args[1];
                }
            }

            string[] files = Directory.GetFiles(myDir);

            Messages.printConsole($"{Messages.directory}: {myDir}", ConsoleColor.Green);
            Console.WriteLine();

            string formatSpacing = "{0,-15} {1,-20} {2,-10} {3, -10}";
            String dataTitle = String.Format(formatSpacing, Messages.mode, Messages.lastWriteTime, Messages.length, Messages.name);
            String dataSeparator = String.Format(formatSpacing, Messages.separator4, Messages.separator12, Messages.separator6, Messages.separator4);

            Messages.printConsole(dataTitle, ConsoleColor.Green);
            Messages.printConsole(dataSeparator, ConsoleColor.Green);

            if (files.Length > 0)
            {
                foreach (string file in files)
                {
                    var fi = new FileInfo(file);

                    FileDetails details = new FileDetails();
                    details.mode = string.Empty;
                    details.lastWriteTime = fi.LastWriteTime;
                    details.length = fi.Length.ToString();
                    details.name = file.Replace(myDir + "\\", String.Empty);

                    String dataAttribute = String.Format(formatSpacing, details.mode, details.lastWriteTime, details.length, details.name);
                    Messages.printConsole(dataAttribute, ConsoleColor.Green);

                }
            }

            Console.WriteLine();
        }
    }
}
