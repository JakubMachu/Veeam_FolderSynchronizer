using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Veeam_FolderSynchronizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3) 
            {
                Console.WriteLine("Warning: Wrong usage!");
                Console.WriteLine("Correct usage: FolderSync.exe \"<sourceFolder>\" \"<replicaFolder>\" <syncInterval> \"<logFile>\"")
                    return;
            }

            var sourceFolder = args[0];
            var replicaFolder = args[1];    
            var syncInterval = int.Parse(args[2]);
            var logFile = args[3];

            Console.WriteLine($"Synchronization of folders: {sourceFolder} and {replicaFolder} with interval: {syncInterval} ms");
        }
    }
}
