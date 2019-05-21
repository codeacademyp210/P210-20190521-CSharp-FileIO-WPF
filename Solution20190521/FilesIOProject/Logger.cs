using System.IO;
using System;

namespace FilesIOProject
{
    class Logger
    {
        static string lPath = @"C:\Users\Sattar\Desktop\Test";


        public static void Write(string text, string status)
        {
            //FileStream fileStream = File.Open(Path.Combine(lPath, "log.txt"), FileMode.OpenOrCreate);
            //fileStream.Close();

            using (StreamWriter writer = File.AppendText(Path.Combine(lPath, "log.txt")))
            {
                writer.WriteLine(DateTime.Now + " " + status.ToUpper() + " " + text);
            }
        }
    }
}
