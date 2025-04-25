namespace Gestin.UI.Commons
{
    public partial class formConfirmation : Form
    {
        // This static method is the equivalent of MessageBox.Show
        public static DialogResult ShowDialog(IWin32Window owner, string caption, string text)
        {
            // Setting the DialogResult does not close the form, it just hides it. 
            // This is why I'm disposing it. see the link at the end of my answer for details.
            using (var customDialog = new formConfirmation(caption, text))
            {
                return customDialog.ShowDialog(owner);
            }
        }
        public formConfirmation(string title, string msg)
        {
            InitializeComponent();
            lblMsg.Text = msg;
            lblTitle.Text = title;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // This will automatically close the form
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
