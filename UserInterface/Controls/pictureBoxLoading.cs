using Gestin.Properties;

namespace Gestin.UserInterface.Custom
{
    internal class PictureBoxLoading : PictureBox
    {
        private PictureBox pictureBoxLoading;
        Control parentControl;

        public PictureBoxLoading(Control control)
        {
            parentControl = control;
            createLoadingPictureBox();
        }

        private void createLoadingPictureBox()
        {
            pictureBoxLoading = new PictureBox();
            pictureBoxLoading.Height = 250;
            pictureBoxLoading.Width = 250;
            pictureBoxLoading.Visible = true;
            pictureBoxLoading.Anchor = AnchorStyles.None;
            pictureBoxLoading.BackColor = Color.Transparent;
            pictureBoxLoading.Location = new Point((1600 - pictureBoxLoading.Width) / 2, (900 - pictureBoxLoading.Height) / 2);
            pictureBoxLoading.Image = Resources.LoadingGif;
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            parentControl.Controls.Add(pictureBoxLoading);
            pictureBoxLoading.BringToFront();
        }

        internal void updateLoadingPictureBox()
        {
            if (pictureBoxLoading != null)
                pictureBoxLoading.Refresh();
        }

        internal void destroyLoadingPictureBox()
        {
            if (pictureBoxLoading != null)
            {
                parentControl.Controls.Remove(pictureBoxLoading);
                pictureBoxLoading.Dispose();
            }
        }
    }
}
