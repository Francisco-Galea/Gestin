using Gestin.Controllers;

namespace Gestin.UI.Home.Exams
{
    public partial class formGenerateMultipleExams : Form
    {
        examController examCnt = examController.getInstance();
        careerController careerController = careerController.getInstance();
        public formGenerateMultipleExams()
        {
            InitializeComponent();
            cbbCareer.DataSource = careerController.loadCareers();
        }
        #region "Minimizar,cerrar y arrastrar"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            string msg = Verification();
            if (!msg.Equals(""))
            {
                lblError.Text = msg;
            }
            else
            {
                DateTime dt = DateTime.Parse(dtDate.Value.ToString("yyyy-MM-dd") + " " + dtTime.Value.ToString("HH:mm:00"));
                if (examCnt.generateAllExamsFromCareer(cbbCareer.SelectedItem, dt))
                {
                    await showSuccessStatus(true);
                    this.Close();
                }
                else await showSuccessStatus(false);
            }
        }
        string Verification()
        {
            string msg = "";
            if (cbbCareer.SelectedItem == null) msg = "Error, elija una materia";
            else if (!dtDate.Checked) msg = "Error, elija una fecha";
            else if (!dtTime.Checked) msg = "Error, elija un horario";
            return msg;
        }
        private async Task showSuccessStatus(bool success)
        {
            if (success) pbSuccess.Visible = true;
            else pbFail.Visible = true;
            await Task.Delay(750);
            pbSuccess.Visible = false;
            pbFail.Visible = false;
        }
    }
}
