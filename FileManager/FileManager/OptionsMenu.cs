using CommandLine;
using FileManager.Commands.Directories;
using FileManager.Commands.Interfaces;

namespace FileManager
{
    public static class OptionsMenu
    {

        public static void MainMenu(string[] args)
        {
            Parser.Default.ParseArguments<PwdCommand, DirCommand, MkdirCommand, RndirCommand, CopydirCommand, MovedirCommand, RmdirCommand>(args)
                  .WithParsed<ICommand>(t => t.Execute(args));
        }

    }
}
