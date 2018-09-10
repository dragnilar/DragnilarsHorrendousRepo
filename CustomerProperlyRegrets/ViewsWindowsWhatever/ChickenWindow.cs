using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus;
using CustomerProperlyRegrets.AncillaryStuffyImportantClassModuleFormCrap;

namespace CustomerProperlyRegrets.ViewsWindowsWhatever
{
    public partial class ChickenWindow : Form
    {
        public ChickenWindow()
        {
            InitializeComponent();
            HookUpEvents();
        }

        private void HookUpEvents()
        {
            buttonNo.Click += (sender, args) => Close();
            buttonYes.Click += (sender, args) => new ChickenSpammer().ShowChicken(new Faker().Random.Int(1,3));
        }
    }
}
