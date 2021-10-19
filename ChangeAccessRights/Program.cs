using System;
using System.Diagnostics;

namespace ChangeAccessRights
{
    class Program
    {
        static void Main(string[] args)
        {
            Process installProcess = new Process();

            installProcess.StartInfo.FileName = $"{Environment.CurrentDirectory}\\GrantAccessToFiles.bat";

            installProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            installProcess.Start();

            installProcess.WaitForExit();
        }
    }
}
