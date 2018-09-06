using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerProperlyRegrets
{
    static class Program
    {
        public static AwfulSplash splashForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ShowSplash();
            ShowMain();
        }

        private static void ShowSplash()
        {
            var splashThread = new Thread(new ThreadStart(delegate
            {
                splashForm = new AwfulSplash();
                Application.Run(splashForm);
            }));
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();
        }

        private static void ShowMain()
        {
            var mainWindow = new MainWindow();
            mainWindow.Load += MainWindowOnLoad;
            Application.Run(mainWindow);
        }

        private static void MainWindowOnLoad(object sender, EventArgs e)
        {
            if (splashForm == null)
            {
                return;
            }

            splashForm.Invoke(new Action(splashForm.Close));
            splashForm.Dispose();
            splashForm = null;
        }
    }
}
