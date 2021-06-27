using System;
using System.IO;
using System.Collections.Generic;

namespace Directory2Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\OneDriveTemp\myfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(@"C:\OneDriveTemp\myfolder\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
