using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerProperlyRegrets.AncilliaryStuffyImportantClassModuleFormCrap;

namespace CustomerProperlyRegrets
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Thread.Sleep(5000);
            BringToFront();
            GetYearsForToolStrip();
            HookUpEvents();
        }

        private void GetYearsForToolStrip()
        {
            var futureDate = DateTime.Now.AddYears(+1);
            yearsToolStripMenuItem.DropDownItems.Add(futureDate.Year.ToString());

            yearsToolStripMenuItem.DropDownItems.Add(DateTime.Now.Year.ToString());

            for (int i = 1; i < 7; i++)
            {
                var date = DateTime.Now.AddYears(-i);
                yearsToolStripMenuItem.DropDownItems.Add(date.Year.ToString());
            }
        }

        #region Event Hook Ups

        private void HookUpEvents()
        {
            HookUpButtons();
            HookUpfile();
            HookUpView();
            HookUpThePengas();
            HookUpUseless();
        }

        private void HookUpUseless()
        {
            chickensToolStripMenuItem.Click += (sender, args) => Errors.ShutDown();
        }

        private void HookUpButtons()
        {
            buttonCrash.Click += (sender, args) => Errors.Crash();
            buttonNothing.Click += (sender, args) => Errors.Error();
        }

        private void HookUpfile()
        {
            crashToolStripMenuItem.Click += (sender, args) => Errors.Crash();
        }

        private void HookUpView()
        {
            minimizeToolStripMenuItem.Click += (sender, args) => this.WindowState = FormWindowState.Minimized;
            maximizeToolStripMenuItem.Click += (sender, args) => this.WindowState = FormWindowState.Maximized;
            errorToolStripMenuItem.Click += (sender, args) => Errors.Error();
        }

        private void HookUpThePengas()
        {
            spaghetToolStripMenuItem.Click += (sender, args) => BrowserLinks.Spaghett();
            nANIToolStripMenuItem.Click += (sender, args) => BrowserLinks.Nani();
            tHISMUSTBETHEWORKToolStripMenuItem.Click += (sender, args) => BrowserLinks.EnemyStand();
            whats910ToolStripMenuItem.Click += (sender, args) => BrowserLinks.NinePlusTen();
        }

        #endregion
    }
}
