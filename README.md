# Folder Synchronization Application

## Description

The Folder Synchronization Application is a C# program that periodically synchronizes the content of a source folder with a replica folder. It ensures that the replica folder maintains an identical copy of the source folder.

The LogToFile method is responsible for logging, and the SynchronizeFolders method handles the synchronization logic. 

## Features

- One-way synchronization from source to replica.
- Periodic synchronization at user-defined intervals (in seconds).
- Logging of file creation and copyin operations.

## Requirements

- .NET Framework or .NET Core
- Visual Studio (for development)

## Installation

1. Clone this repository to your local machine:
```
https://github.com/JakubMachu/FolderSynchronizer
```

3. Open the solution in Visual Studio.

4. Build the solution to generate the executable.
   To do so:
   - Open Developer Command Prompt in Visual Studio and use:
    ```
   csc Program.cs
    ```
    - That will create Program.exe in your repository.
5. Create LogFile.txt in your reository after you generate your executable.
   
## Usage

1. Open a command prompt (Win + R, type "cmd," and press Enter to open a command prompt) or terminal (macOS or Linux).

2. Navigate to the folder where the executable is located.
   For example:
   ```
   cd path\to\your\exe\directory
   ```

4. Run the application with the following command-line arguments:

Program.exe <sourceFolder> <replicaFolder> <syncIntervalSeconds> <logFilePath>

- `<sourceFolder>`: The path to the source folder you want to synchronize.
- `<replicaFolder>`: The path to the replica folder where the content will be synchronized.
- `<syncIntervalSeconds>`: The synchronization interval in milliseconds.
- `<logFilePath>`: The path to the log file where synchronization actions will be recorded.

4. The application will start synchronizing the folders. You can stop it by pressing <ENTER>.

## Examples

Here are some example commands to run the application:

```
Program.exe "C:\MyFiles\SourceFolder" "D:\MyFiles\ReplicaFolder" 10 "C:\MyFiles\GitRepository\LogFile.txt"
```
That command synchronizes "C:\MyFiles\SourceFolder"  with "D:\MyFiles\ReplicaFolder" every 10 seconds and logs the actions to "C:\MyFiles\GitRepository\LogFile.txt" and console.

## Acknowledgments
Thanks to the Google and ChatGPT <3
