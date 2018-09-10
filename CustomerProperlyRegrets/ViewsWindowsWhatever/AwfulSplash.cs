using System;
using System.Windows.Forms;
using Bogus;
using CustomerProperlyRegrets.AncillaryStuffyImportantClassModuleFormCrap;

namespace CustomerProperlyRegrets.ViewsWindowsWhatever
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
