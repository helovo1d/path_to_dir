# path_to_dir


Windows Forms low effort program that creates directories from path string.


Adding to context menu

win+r 
type in regedit.exe

Navitate to:
   HKEY_CLASSES_ROOT\Directory\Background\shell

1.Right click on "shell" New > key .
2.Key name = "Path to Dir" // creates a key entry
3.Right click the created key and add a new key called "command" // exactly that name
4.Change the (default) value to path of executable ex: "D:\programming\path_to_dir\ptd\ptd\bin\Debug\ptd.exe"


more on adding to context menu:
https://medium.com/analytics-vidhya/creating-cascading-context-menus-with-the-windows-10-registry-f1cf3cd8398f
