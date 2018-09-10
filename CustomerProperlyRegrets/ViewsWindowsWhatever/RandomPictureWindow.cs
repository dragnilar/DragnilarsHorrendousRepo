using System;
using System.Windows.Forms;
using CustomerProperlyRegrets.Properties;

namespace CustomerProperlyRegrets.ViewsWindowsWhatever
{
    public partial class RandomPictureWindow : Form
    {
        public RandomPictureWindow()
        {
            InitializeComponent();
            LoadRandomImageFromUrl();
        }

        private void LoadRandomImageFromUrl()
        {
            var randomImageUrl = "https://picsum.photos/480/640";
            var loadFailed = false;
            try
            {
                GetRandomImage(randomImageUrl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                loadFailed = true;
            }
            finally
            {
                if (loadFailed)
                {
                    pictureBoxRandomImage.Image = Resources.CPR_Loading_Failed_Message;
                }
            }

        }

        private void GetRandomImage(string url)
        {
            pictureBoxRandomImage.LoadAsync(url);
        }

    }
}
