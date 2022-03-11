namespace FileManager.Utilities
{
    public class Validators
    {

        public static bool hasArgsValid(string[] args, int count=0)
        {
            if (args.Length > 0)
            {
                CommandActions commands;
                Enum.TryParse(args[0], out commands);

                switch (commands)
                {
                    case CommandActions.pwd:
                        break;
                    case CommandActions.dir:
                        foreach (var item in args)
                        {
                            if (item.Equals(string.Empty))
                            {
                                Messages.printConsole("invalid arguments", ConsoleColor.Red);
                                return false;
                            }
                        }
                        break;
                    case CommandActions.mkdir:
                        if (args.Length == count)
                        {
                            foreach (var item in args)
                            {
                                if (item.Equals(string.Empty))
                                {
                                    Messages.printConsole("invalid arguments", ConsoleColor.Red);
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            Messages.printConsole("invalid arguments", ConsoleColor.Red);
                            return false;
                        }
                        break;
                    case CommandActions.rndir:
                        break;
                    case CommandActions.rmdir:
                        break;
                    default:
                        break;
                }

                return true;
            }
            return false;
        }

        private static bool isArgsNullOrEmpty(string[] args)
        {
            foreach (var item in args)
            {
                if (item.Equals(string.Empty))
                {
                    Messages.printConsole("invalid arguments", ConsoleColor.Red);
                    return false;
                }
            }
            return true;
        }

        public static bool isPathValid(string path)
        {
            if (Path.IsPathRooted(path))
                return true;
            
            Messages.printConsole(Messages.ErrorValidationPath, ConsoleColor.Red);
            Messages.printConsole(Messages.ErrorValidationPathRelative, ConsoleColor.Red);
            Messages.printConsole(Messages.ErrorValidationPathAbsolute, ConsoleColor.Red);

            return false;
        }

    }
}
