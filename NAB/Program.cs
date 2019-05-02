using System;
using System.Windows.Forms;

namespace NAB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Transaction CurrentTransaction = new Transaction();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NABCreator());
        }
    }
}
