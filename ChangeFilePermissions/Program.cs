using System;

namespace ChangeFilePermissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Program Files (x86)\\Serge Vinogradoff\\Oven Thermoregulator\\OvenDatabase.mdf";
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);
            fileInfo.IsReadOnly = false;
        }
    }
}
