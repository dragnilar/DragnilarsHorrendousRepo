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
using Bogus;
using CustomerProperlyRegrets.AnciliaryStuffyImportantClassModuleFormCrap;
using CustomerProperlyRegrets.AncilliaryStuffyImportantClassModuleFormCrap;

namespace CustomerProperlyRegrets
{
    public partial class AwfulSplash : Form
    {
        public AwfulSplash(bool startUp = false)
        {
            InitializeComponent();
            Shown += OnShown;
            linkLabelIcons8.Click += LinkLabelIcons8OnClick;

        }

        private void LinkLabelIcons8OnClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://icons8.com");
        }

        private void OnShown(object sender, EventArgs e)
        {
            var bogus = new Faker();
            labelRandomMessage.Text = RandomMessages.SplashScreenMessages[bogus.Random.Int(0, RandomMessages.SplashScreenMessages.Count - 1)];
        }

    }
}
