using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oven_Interface
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
    }
}

// оно кажись должно выглядеть как-то так чтобы работать с таймерами и т.п.
// мол один тред это форма, второй тред - таймер. и т.п.
//
//using System;
//using System.Threading;

//public class Example
//{
//    static Object obj = new Object();

//    public static void Main()
//    {
//        ThreadPool.QueueUserWorkItem(ShowThreadInformation);
//        var th1 = new Thread(ShowThreadInformation);
//        th1.Start();
//        var th2 = new Thread(ShowThreadInformation);
//        th2.IsBackground = true;
//        th2.Start();
//        Thread.Sleep(500);
//        ShowThreadInformation(null);
//    }

//    private static void ShowThreadInformation(Object state)
//    {
//        lock (obj)
//        {
//            var th = Thread.CurrentThread;
//            Console.WriteLine("Managed thread #{0}: ", th.ManagedThreadId);
//            Console.WriteLine("   Background thread: {0}", th.IsBackground);
//            Console.WriteLine("   Thread pool thread: {0}", th.IsThreadPoolThread);
//            Console.WriteLine("   Priority: {0}", th.Priority);
//            Console.WriteLine("   Culture: {0}", th.CurrentCulture.Name);
//            Console.WriteLine("   UI culture: {0}", th.CurrentUICulture.Name);
//            Console.WriteLine();
//        }
//    }
//}
