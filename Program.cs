using System;
using System.IO;
using System.Threading;

class Program
{
	static void Main(string[] args)
	{
		if (args.Length != 4)
		{
			Console.WriteLine("Invalid number of arguments! Please, try again with 4 arguments.");
			Console.WriteLine("Correct usage: Program.exe <source_folder> <replica_folder> <sync_interval_seconds> <log_file_path>");
			return;
		}

		string sourceFolder = args[0];
		string replicaFolder = args[1];
		int syncIntervalSeconds = int.Parse(args[2]);
		string logFilePath = args[3];

		while (true)
		{
			if (Console.KeyAvailable)
			{
				ConsoleKeyInfo key = Console.ReadKey(intercept: true);
				if (key.Key == ConsoleKey.Enter)
				{
					Console.WriteLine("Quitting...");
					break;
				}
			}

			SynchronizeFolders(sourceFolder, replicaFolder, logFilePath);
			Thread.Sleep(syncIntervalSeconds * 1000);
		}
	}

	static void SynchronizeFolders(string sourceFolder, string replicaFolder, string logFilePath)
	{
		try
		{
			string[] sourceFiles = Directory.GetFiles(sourceFolder, "*", SearchOption.AllDirectories);

			foreach (string sourceFilePath in sourceFiles)
			{
				string replicaFilePath = sourceFilePath.Replace(sourceFolder, replicaFolder);
				string replicaFileFolder = Path.GetDirectoryName(replicaFilePath);

				if (!Directory.Exists(replicaFileFolder))
				{
					Directory.CreateDirectory(replicaFileFolder);
				}

				File.Copy(sourceFilePath, replicaFilePath, true);

				LogToFile(logFilePath, $"<<Success>> Copied: {sourceFilePath} to {replicaFilePath}");
				Console.WriteLine($"<<Success>> Copied: {sourceFilePath} to {replicaFilePath}");
				Console.WriteLine("Press <ENTER> to quit.");
			}
		}
		catch (Exception ex)
		{
			LogToFile(logFilePath, $"Error: {ex.Message}");
			Console.WriteLine($"Error: {ex.Message}");
		}
	}

	static void LogToFile(string logFilePath, string message)
	{
		try
		{
			using (StreamWriter sw = File.AppendText(logFilePath))
			{
				sw.WriteLine($"{DateTime.Now}: {message}");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error writing to log file: {ex.Message}");
		}
	}
}



