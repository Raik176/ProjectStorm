using System;
using System.Windows.Forms;

namespace CloudLauncher {
    static class Program
    {
        public static string dll = "Rain.dll";
        public static string launcher = "FortniteLauncher.exe";
        public static string client = "FortniteClient-Win64-Shipping";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
