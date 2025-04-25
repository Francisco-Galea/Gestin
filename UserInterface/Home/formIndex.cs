using Gestin.Properties;

namespace Gestin.UI.Home
{
    public partial class formIndex : Form
    {
        Image activeImage = Resources.Index;
        public formIndex()
        {
            InitializeComponent();
            panelContainer.BackgroundImage = activeImage;
        }
    }
}
