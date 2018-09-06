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
    public partial class AwfulSplash : Form
    {
        public AwfulSplash(bool startUp = false)
        {
            InitializeComponent();
            Shown += OnShown;

        }

        private void OnShown(object sender, EventArgs e)
        {
            var randomMessages = new RandomMessages();
            var rand = new Random();
            var index = rand.Next(randomMessages.Messages.Count);
            labelRandomMessage.Text = randomMessages.Messages[index];
        }

    }
}
