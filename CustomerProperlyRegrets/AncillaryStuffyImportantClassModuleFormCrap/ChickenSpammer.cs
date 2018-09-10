using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus;
using CustomerProperlyRegrets.ViewsWindowsWhatever;

namespace CustomerProperlyRegrets.AncillaryStuffyImportantClassModuleFormCrap
{
    public class ChickenSpammer
    {
        public void ShowChicken(int numberOfWindows)
        {
            for (int i = 0; i <= numberOfWindows; i++)
            {
                var window = new ChickenWindow { StartPosition = GetRandomStartPosition() };
                window.Show();
            }

        }

        private FormStartPosition GetRandomStartPosition()
        {
            var bogus = new Faker();
            var randomNumber = bogus.Random.Int(0, 4);
            switch (randomNumber)
            {
                case 0:
                    return FormStartPosition.CenterParent;
                case 1:
                    return FormStartPosition.CenterScreen;
                case 2:
                    return FormStartPosition.Manual;
                case 3:
                    return FormStartPosition.WindowsDefaultBounds;
                case 4:
                    return FormStartPosition.WindowsDefaultLocation;
                default:
                    return FormStartPosition.CenterParent;
            }
        }
    }
}
