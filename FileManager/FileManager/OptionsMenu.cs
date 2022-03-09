using CommandLine;
using FileManager.Commands;
using FileManager.Commands.Interfaces;

namespace FileManager
{
    public static class OptionsMenu
    {

        public static void MainMenu(string[] args)
        {
            Parser.Default.ParseArguments<PwdCommand, DirCommand, CreateCommand, HelpCommand>(args)
                  .WithParsed<ICommand>(t => t.Execute(args));
        }

    }
}
