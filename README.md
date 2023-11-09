# Folder Synchronization Application

## Description

The Folder Synchronization Application is a C# program that periodically synchronizes the content of a source folder with a replica folder. It ensures that the replica folder maintains an identical copy of the source folder.

The Logger class is responsible for logging, and the FolderSynchronizer class handles the synchronization logic. 
The Program class remains the entry point for the application.

## Features

- One-way synchronization from source to replica.
- Periodic synchronization at user-defined intervals.
- Logging of file creation, copying, and removal operations.

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

## Usage

1. Open a command prompt (Win + R, type "cmd," and press Enter to open a command prompt) or terminal (macOS or Linux).

2. Navigate to the folder where the executable is located.
   For example:
   ```
   cd path\to\your\exe\directory
   ```

4. Run the application with the following command-line arguments:

FolderSynchronizer.exe <sourceFolder> <replicaFolder> <synchronizationInterval> <logFilePath>

- `<sourceFolder>`: The path to the source folder you want to synchronize.
- `<replicaFolder>`: The path to the replica folder where the content will be synchronized.
- `<interval>`: The synchronization interval in milliseconds.
- `<logFilePath>`: The path to the log file where synchronization actions will be recorded.

4. The application will start synchronizing the folders. You can stop it by pressing Ctrl + C.

## Examples

Here are some example commands to run the application:

```
FolderSynchronizer.exe C:\SourceFolder D:\ReplicaFolder 60000 C:\Log\sync.log
```
This command synchronizes "C:\SourceFolder" with "D:\ReplicaFolder" every 60 seconds and logs the actions to "C:\Log\sync.log."

## Acknowledgments
Thanks to the Google and ChatGPT.
