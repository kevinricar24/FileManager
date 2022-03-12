namespace FileManager.Utilities
{
    public class Validators
    {

        public static bool HasArgsValid(string[] args, int count=0)
        {
            if (args.Length > 0)
            {
                CommandActions commands;
                Enum.TryParse(args[0], out commands);

                switch (commands)
                {
                    //Directories
                    case CommandActions.pwd:
                        break;
                    case CommandActions.dir:
                        return IsArgsNullOrEmpty(args, Messages.HelpTextDir);
                    case CommandActions.mkdir:
                        return IsArgsValid(args, count, Messages.HelpTextMkdir);
                    case CommandActions.rndir:
                        return IsArgsValid(args, count, Messages.HelpTextRndir);
                    case CommandActions.copydir:
                        return IsArgsValid(args, count, Messages.HelpTextCopydir);
                    case CommandActions.movedir:
                        return IsArgsValid(args, count, Messages.HelpTextMovedir);
                    case CommandActions.rmdir:
                        return IsArgsValid(args, count, Messages.HelpTextRmdir);

                    //Files
                    case CommandActions.mkfile:
                        return IsArgsValid(args, count, Messages.HelpTextMkfile);
                    case CommandActions.rnfile:
                        return IsArgsValid(args, count, Messages.HelpTextRnfile);
                    case CommandActions.copyfile:
                        return IsArgsValid(args, count, Messages.HelpTextCopyfile);
                    case CommandActions.movefile:
                        return IsArgsValid(args, count, Messages.HelpTextMovefile);
                    case CommandActions.rmfile:
                        return IsArgsValid(args, count, Messages.HelpTextRmfile);
   
                    default:
                        break;
                }

                return true;
            }
            return false;
        }

        private static bool IsArgsValid(string[] args, int count, string error)
        {
            if (args.Length == count)
            {
                return IsArgsNullOrEmpty(args, error);
            }
            else
            {
                Messages.printConsole(Messages.ErrorInvalidArgs, ConsoleColor.Red);
                Console.WriteLine();
                Messages.printConsole(error, ConsoleColor.Yellow);
                return false;
            }
        }

        private static bool IsArgsNullOrEmpty(string[] args, string error)
        {
            foreach (var item in args)
            {
                if (item.Equals(string.Empty))
                {
                    Messages.printConsole(Messages.ErrorInvalidArgs, ConsoleColor.Red);
                    Console.WriteLine();
                    Messages.printConsole(error, ConsoleColor.Yellow);
                    return false;
                }
            }
            return true;
        }

        public static bool IsPathValid(string path)
        {
            if (Path.IsPathRooted(path))
                return true;
            
            Messages.printConsole(Messages.ErrorValidationPath, ConsoleColor.Red);
            Messages.printConsole(Messages.ErrorValidationPathRelative, ConsoleColor.Red);
            Messages.printConsole(Messages.ErrorValidationPathAbsolute, ConsoleColor.Red);

            return false;
        }

        public static bool IsPathFileValid(string path)
        {
            if (Path.IsPathRooted(path))
            {
                if (Path.GetExtension(path).Equals(Messages.extension))
                    return true;
            }
            
            Messages.printConsole(Messages.ErrorValidationPathFile, ConsoleColor.Red);
            Messages.printConsole(Messages.ErrorValidationPathFileRelative, ConsoleColor.Red);
            Messages.printConsole(Messages.ErrorValidationPathFileAbsolute, ConsoleColor.Red);

            return false;
        }

    }
}
