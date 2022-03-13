# How to run

1. Open windows terminal
2. Set your directory on the FileManager solution
   --> cd C:\<YourLocalMachine>\FileManager\FileManager\FileManager
3. Excute any command, could you show all commands using:
   --> dotnet run help

# FileManager
File manager CRUD operations in .NET 6

FileManager 1.0.0
Copyright (C) 2022 FileManager

  pwd         Show Current Directory

  mkdir       Create folder on directory
              --> Use dotnet run mkdir <fullPath\\FolderName>
              --> Example: dotnet run mkdir C:\\Test\\NewFolder

  rndir       Rename folder on directory
              --> Use dotnet run rndir <fullPath\\FolderName> <newFolderName>
              --> Example: dotnet run rndir C:\\Test\\myFolder myFolderTest

  copydir     Copy folder on directory
              --> Use dotnet run copydir <fullPath\\FolderNameSource> <fullPath\\FolderNameDestination>
              --> Example: dotnet run copydir C:\\Test\\myFolder C:\\Test\\myFolderTest

  movedir     Move folder on directory
              --> Use dotnet run movedir <fullPath\\FolderNameSource> <fullPath\\FolderNameDestination>
              --> Example: dotnet run movedir C:\\Test\\myFolder C:\\Test\\myFolderTest

  rmdir       Remove folder on directory
              --> Use dotnet run rmdir <fullPath\\FolderName>
              --> Example: dotnet run rmdir C:\\Test\\myFolder

  mkfile      Create file on directory
              --> Use dotnet run mkfile <fullPath\\FileName.txt>
              --> Example: dotnet run mkfile C:\\Test\\FileName.txt

  rnfile      Rename file on directory
              --> Use dotnet run rnfile <fullPath\\FileName.txt> <newFileName>
              --> Example: dotnet run rnfile C:\\Test\\FileName.txt myFileName

  copyfile    Copy file on directory
              --> Use dotnet run copyfile <fullPath\\FolderNameSource\\FileName.txt> <fullPath\\FolderNameDestination>
              --> Example: dotnet run copyfile C:\\Test\\myFolder\\FileName.txt C:\\Test\\myFolderTest

  movefile    Move file on directory
              --> Use dotnet run movefile <fullPath\\FolderNameSource\\FileName.txt> <fullPath\\FolderNameDestination>
              --> Example: dotnet run movefile C:\\Test\\myFolder\\FileName.txt C:\\Test\\myFolderTest

  rmfile      Remove file on directory
              --> Use dotnet run rmfile <fullPath\\FileName.txt>
              --> Example: dotnet run rmfile C:\\Test\\FileName.txt

  help        Display more information on a specific command.

  version     Display version information.
