using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DigitalClassroom.Forms.AuthForms;
using DigitalClassroom.Forms.MainForms;

namespace DigitalClassroom.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
