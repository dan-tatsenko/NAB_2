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
            NABFile file = new NABFile();
            frmMainForm form;
            ApplicationController controller;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new frmMainForm();
            controller = new ApplicationController(form, file);
            Application.Run(form);
        }
    }
}
