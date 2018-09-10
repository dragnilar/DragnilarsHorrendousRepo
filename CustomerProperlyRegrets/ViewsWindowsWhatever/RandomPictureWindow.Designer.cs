namespace CustomerProperlyRegrets.ViewsWindowsWhatever
{
    partial class RandomPictureWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomPictureWindow));
            this.pictureBoxRandomImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRandomImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRandomImage
            // 
            this.pictureBoxRandomImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRandomImage.ErrorImage = global::CustomerProperlyRegrets.Properties.Resources.CPR_Loading_Failed_Message;
            this.pictureBoxRandomImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRandomImage.Image")));
            this.pictureBoxRandomImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRandomImage.Name = "pictureBoxRandomImage";
            this.pictureBoxRandomImage.Size = new System.Drawing.Size(487, 402);
            this.pictureBoxRandomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRandomImage.TabIndex = 0;
            this.pictureBoxRandomImage.TabStop = false;
            // 
            // RandomPictureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 402);
            this.Controls.Add(this.pictureBoxRandomImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandomPictureWindow";
            this.Text = "Chickens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRandomImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRandomImage;
    }
}