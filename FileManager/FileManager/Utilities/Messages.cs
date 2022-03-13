namespace FileManager.Utilities
{
    public class Messages
    {
        public const string ErrorInvalidArgs = "Invalid arguments";
        public const string path = "Path";
        public const string directory = "Directory";
        public const string file = "File";
        public const string error = "Error";
        public const string extension = ".txt";

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

        //Directories
        public const string commandPwd = "pwd";
        public const string commandDir = "dir";
        public const string commandMkdir = "mkdir";
        public const string commandRndir = "rndir";
        public const string commandCopydir = "copydir";
        public const string commandMovedir = "movedir";
        public const string commandRmdir = "rmdir";

        public const string ErrorValidationPath = "Please use a valid path, Examples:";
        public const string ErrorValidationPathRelative = "Relative: C:\\\\Test";
        public const string ErrorValidationPathAbsolute = "Absolute: .\\\\Test or ..\\\\otherFolder\\\\Test";

        public const string ErrorValidationFolderName = "Please use only forlder name\n Example: Test";

        public const string HelpTextPwd = "Show Current Directory";

        public const string HelpTextDir = "List current or any directory\n" +
                                          "--> Use dotnet run dir or dotnet run dir <fullPathFolderName>\n" +
                                          "--> Example: dotnet run dir C:\\\\Test";

        public const string HelpTextMkdir = "Create folder on directory\n" +
                                          "--> Use dotnet run mkdir <fullPath\\\\FolderName>\n" +
                                          "--> Example: dotnet run mkdir C:\\\\Test\\\\NewFolder";

        public const string HelpTextRndir = "Rename folder on directory\n" +
                                      "--> Use dotnet run rndir <fullPath\\\\FolderName> <newFolderName>\n" +
                                      "--> Example: dotnet run rndir C:\\\\Test\\\\myFolder myFolderTest";

        public const string HelpTextCopydir = "Copy folder on directory\n" +
                                      "--> Use dotnet run copydir <fullPath\\\\FolderNameSource> <fullPath\\\\FolderNameDestination>\n" +
                                      "--> Example: dotnet run copydir C:\\\\Test\\\\myFolder C:\\\\Test\\\\myFolderTest";

        public const string HelpTextMovedir = "Move folder on directory\n" +
                                      "--> Use dotnet run movedir <fullPath\\\\FolderNameSource> <fullPath\\\\FolderNameDestination>\n" +
                                      "--> Example: dotnet run movedir C:\\\\Test\\\\myFolder C:\\\\Test\\\\myFolderTest";

        public const string HelpTextRmdir = "Remove folder on directory\n" +
                                "--> Use dotnet run rmdir <fullPath\\\\FolderName>\n" +
                                "--> Example: dotnet run rmdir C:\\\\Test\\\\myFolder";

        //Files
        public const string commandMkfile = "mkfile";
        public const string commandRnfile = "rnfile";
        public const string commandCopyfile = "copyfile";
        public const string commandMovefile = "movefile";
        public const string commandRmfile = "rmfile";

        public const string ErrorValidationPathFile = "Please use a (.txt) valid file, Examples:";
        public const string ErrorValidationPathFileRelative = "Relative: C:\\\\Test.txt";
        public const string ErrorValidationPathFileAbsolute = "Absolute: .\\\\Test.txt or ..\\\\otherFolder\\\\Test.txt";

        public const string HelpTextMkfile = "Create file on directory\n" +
                                          "--> Use dotnet run mkfile <fullPath\\\\FileName.txt>\n" +
                                          "--> Example: dotnet run mkfile C:\\\\Test\\\\FileName.txt";

        public const string HelpTextRnfile = "Rename file on directory\n" +
                                      "--> Use dotnet run rnfile <fullPath\\\\FileName.txt> <newFileName>\n" +
                                      "--> Example: dotnet run rnfile C:\\\\Test\\\\FileName.txt myFileName";

        public const string HelpTextCopyfile = "Copy file on directory\n" +
                                      "--> Use dotnet run copyfile <fullPath\\\\FolderNameSource\\\\FileName.txt> <fullPath\\\\FolderNameDestination>\n" +
                                      "--> Example: dotnet run copyfile C:\\\\Test\\\\myFolder\\\\FileName.txt C:\\\\Test\\\\myFolderTest";

        public const string HelpTextMovefile = "Move file on directory\n" +
                                      "--> Use dotnet run movefile <fullPath\\\\FolderNameSource\\\\FileName.txt> <fullPath\\\\FolderNameDestination>\n" +
                                      "--> Example: dotnet run movefile C:\\\\Test\\\\myFolder\\\\FileName.txt C:\\\\Test\\\\myFolderTest";

        public const string HelpTextRmfile = "Remove file on directory\n" +
                                "--> Use dotnet run rmfile <fullPath\\\\FileName.txt>\n" +
                                "--> Example: dotnet run rmfile C:\\\\Test\\\\FileName.txt";

        public static void printConsole(string msg, ConsoleColor consoleColor = ConsoleColor.White)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
