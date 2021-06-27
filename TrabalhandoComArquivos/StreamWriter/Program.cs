using System;
using System.IO;

namespace StreamWriter1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\OneDriveTemp\File1.txt";
            string targetpath = @"C:\OneDriveTemp\File3.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);
                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
