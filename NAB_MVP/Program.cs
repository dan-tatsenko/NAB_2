using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAB_MVC.Models;
using NAB_MVC.Controllers;

namespace NAB_MVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BankingFile File = new BankingFile();
            frmMainForm Form;
            ApplicationController Controller;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form = new frmMainForm();
            Controller = new ApplicationController(Form, File);
            Application.Run(Form);
        }
    }
}
