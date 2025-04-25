namespace Gestin.UI.Commons
{
    public partial class formShowInfo : Form
    {
        public formShowInfo(string txt, Image img)
        {
            InitializeComponent();
            lblText.Text = txt;
            pictureBox1.Image = img;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
