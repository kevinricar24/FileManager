namespace FileManager.Utilities
{
    public class Messages
    {

        public const string commandPwd = "pwd";
        public const string commandDir = "dir";
        public const string commandMkdir = "mkdir";
        public const string commandRndir = "rndir";
        public const string commandRmdir = "rmdir";

        public const string HelpTextDir = "List current or any directory\n" +
                                          "--> Use dir or dir <fullPathFolderName>\n" +
                                          "--> Example: dir C:\\\\Test";

        public const string HelpTextMkdir = "Create folder on directory\n" +
                                          "--> Use mkdir <fullPath\\\\FolderName>\n" +
                                          "--> Example: mkdir C:\\\\Test\\\\NewFolder";

        public const string HelpTextRndir = "Rename folder on directory\n" +
                                      "--> Use rndir <fullPath\\\\FolderName> <newFolderName>\n" +
                                      "--> Example: rndir C:\\\\Test\\\\myFolder C:\\\\Test\\\\myFolderTest";

        public const string HelpTextRmdir = "Remove folder on directory\n" +
                                "--> Use rmdir <fullPath\\\\FolderName>\n" +
                                "--> Example: rmdir C:\\\\Test\\\\myFolder";


        public const string path = "Path";
        public const string directory = "Directory";

        public const string mode = "Mode";
        public const string lastWriteTime = "LastWriteTime";
        public const string length = "Length";
        public const string name = "Name";

        public const string separator4 = "----";
        public const string separator5 = "-----";
        public const string separator6 = "------";
        public const string separator7 = "-------";
        public const string separator8 = "--------";
        public const string separator9 = "---------";
        public const string separator10 = "----------";
        public const string separator11 = "-----------";
        public const string separator12 = "------------";
        public const string separator13 = "-------------";
        public const string separator14 = "--------------";

        public static void printConsole(string msg, ConsoleColor consoleColor = ConsoleColor.White)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
