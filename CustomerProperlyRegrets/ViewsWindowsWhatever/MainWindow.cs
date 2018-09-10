using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Bogus;
using CustomerProperlyRegrets.AncillaryStuffyImportantClassModuleFormCrap;

namespace CustomerProperlyRegrets.ViewsWindowsWhatever
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
            BindData();
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
            HookUpGridEvents();
            HookUpYears();
            HookUpWindowEvents();
        }



        private void HookUpYears()
        {
            for (int i = 0; i <= yearsToolStripMenuItem.DropDownItems.Count - 1; i++)
            {
                yearsToolStripMenuItem.DropDownItems[i].Click += OnYearClick;
            }
        }

        private void HookUpUseless()
        {
            chickensToolStripMenuItem.Click += (sender, args) => Errors.ShutDown();
            unknownToolStripMenuItem.Click += UnknownToolStripMenuItemOnClick;
        }

        private void HookUpButtons()
        {
            buttonCrash.Click += (sender, args) => Errors.Crash();
            buttonNothing.Click += (sender, args) => Errors.ThrowRandomException();
            buttonDirty.Click += ButtonDirtyOnClick;
        }

        private void HookUpfile()
        {
            crashToolStripMenuItem.Click += (sender, args) => Errors.Crash();
        }

        private void HookUpView()
        {
            minimizeToolStripMenuItem.Click += (sender, args) => this.WindowState = FormWindowState.Minimized;
            maximizeToolStripMenuItem.Click += (sender, args) => this.WindowState = FormWindowState.Maximized;
            errorToolStripMenuItem.Click += (sender, args) => Errors.ThrowRandomException();
        }

        private void HookUpThePengas()
        {
            spaghetToolStripMenuItem.Click += (sender, args) => BrowserLinks.Spaghett();
            nANIToolStripMenuItem.Click += (sender, args) => BrowserLinks.Nani();
            tHISMUSTBETHEWORKToolStripMenuItem.Click += (sender, args) => BrowserLinks.EnemyStand();
            whats910ToolStripMenuItem.Click += (sender, args) => BrowserLinks.NinePlusTen();
        }

        private void HookUpGridEvents()
        {
           dataGridViewTrash.DoubleClick += DataGridViewTrashOnDoubleClick;
        }

        private void HookUpWindowEvents()
        {
            Closing += (sender, args) => Errors.Crash();
        }



        #endregion

        private void BindData()
        {
            var bogus = new Faker();
            var generator = new DirtyDataGenerator();
            dataGridViewTrash.DataSource = generator.GetDirtyDataList(bogus.Random.Int(10,500));
            listBoxListOfCrap.DataSource = generator.GetDirtyDataList(bogus.Random.Int(10, 25));
        }

        private void DataGridViewTrashOnDoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewTrash.CurrentRow != null)
            {
                var selectedItem = dataGridViewTrash.CurrentRow.DataBoundItem as DirtyData;
                ShowDirtyClickMessage(selectedItem);

            }
        }

        private void ButtonDirtyOnClick(object sender, EventArgs e)
        {
            if (listBoxListOfCrap.Items.Count > 0 && listBoxListOfCrap.SelectedIndex >= 0)
            {
                var selectedItem = listBoxListOfCrap.SelectedItem as DirtyData;
                (dataGridViewTrash.DataSource as BindingList<DirtyData>)?.Add(selectedItem);
                ShowItsDirtyMessage(selectedItem);
                (listBoxListOfCrap.DataSource as BindingList<DirtyData>)?.RemoveAt(listBoxListOfCrap.SelectedIndex);
                listBoxListOfCrap.SelectedIndex = 0;
            }
        }

        private void UnknownToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            var window = new RandomPictureWindow {StartPosition = FormStartPosition.CenterParent};
            window.Show();

        }

        private void OnYearClick(object sender, EventArgs e)
        {
            new FakeConfigGenerator().CreateFakeConfigXmlFile();
            MessageBox.Show(
                "A new configuration file is now on your desktop. Please do not delete it, or the whole world will end.",
                "IMPORTANT CONFIG FILE CREATED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowItsDirtyMessage(DirtyData selectedItem)
        {
            MessageBox.Show($"EWWW, {selectedItem.Name} IS DIRTY!!!", "UNHANDLED MIND BLOWING EXCEPTION ERROR", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void ShowDirtyClickMessage(DirtyData selectedItem)
        {
            MessageBox.Show($"EWWW, {selectedItem.Name} IS DIRTY, WHY DID YOU SELECT IT!?!", "HOW DARE YOU ERROR ERROR ERROR #%)&(#@%#", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


    }
}
