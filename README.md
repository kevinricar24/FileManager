# FileManager
File manager CRUD operations in .NET 6

FileManager 1.0.0
Copyright (C) 2022 FileManager

  pwd         Show Current Directory

  mkdir       Create folder on directory
              --> Use mkdir <fullPath\\FolderName>
              --> Example: mkdir C:\\Test\\NewFolder

  rndir       Rename folder on directory
              --> Use rndir <fullPath\\FolderName> <newFolderName>
              --> Example: rndir C:\\Test\\myFolder myFolderTest

  copydir     Copy folder on directory
              --> Use copydir <fullPath\\FolderNameSource> <fullPath\\FolderNameDestination>
              --> Example: copydir C:\\Test\\myFolder C:\\Test\\myFolderTest

  movedir     Move folder on directory
              --> Use movedir <fullPath\\FolderNameSource> <fullPath\\FolderNameDestination>
              --> Example: movedir C:\\Test\\myFolder C:\\Test\\myFolderTest

  rmdir       Remove folder on directory
              --> Use rmdir <fullPath\\FolderName>
              --> Example: rmdir C:\\Test\\myFolder

  mkfile      Create file on directory
              --> Use mkfile <fullPath\\FileName.txt>
              --> Example: mkfile C:\\Test\\FileName.txt

  rnfile      Rename file on directory
              --> Use rnfile <fullPath\\FileName.txt> <newFileName>
              --> Example: rnfile C:\\Test\\FileName.txt myFileName

  copyfile    Copy file on directory
              --> Use copyfile <fullPath\\FolderNameSource\\FileName.txt> <fullPath\\FolderNameDestination>
              --> Example: copyfile C:\\Test\\myFolder\\FileName.txt C:\\Test\\myFolderTest

  movefile    Move file on directory
              --> Use movefile <fullPath\\FolderNameSource\\FileName.txt> <fullPath\\FolderNameDestination>
              --> Example: movefile C:\\Test\\myFolder\\FileName.txt C:\\Test\\myFolderTest

  rmfile      Remove file on directory
              --> Use rmfile <fullPath\\FileName.txt>
              --> Example: rmfile C:\\Test\\FileName.txt

  help        Display more information on a specific command.

  version     Display version information.
