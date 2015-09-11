using System;
using System.Windows.Forms;

namespace Mp3TagEditor.UI
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
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run(new MainForm()); 
            
            //RestartFormIfLangageChaned();
        }

        private static void RestartFormIfLangageChaned()
        {
            try
            {
                Application.Run(new MainForm());
            }
            catch (ApplicationException)
            {
                RestartFormIfLangageChaned();
            }
        }
    }
}