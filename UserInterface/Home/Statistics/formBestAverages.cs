using Gestin.Controllers;

namespace Gestin.UI.Home
{
    public partial class formBestAverages : Form
    {
        private careerController careerController = careerController.getInstance();
        private subjectController subjectController = subjectController.getInstance();
        private careerEnrolmentController careerEnrolmentController = careerEnrolmentController.getInstance();
        private bool mostrarSoloEgresados = false; // Variable de estado para controlar la visualización
        private object receivedCareer;
        private int receivedCareerIndex;
        private int careerSubjectCount;

        public formBestAverages()
        {
            InitializeComponent();
        }

        public formBestAverages(int selectedCareerIndex)
        {
            InitializeComponent();
            receivedCareerIndex = selectedCareerIndex;
        }

        public formBestAverages(object selectedCareer)
        {
            InitializeComponent();
            receivedCareer = selectedCareer;
        }

        private void formBestAverages_Load(object sender, EventArgs e)
        {
            fillCbbCareer();
            filldgvAverages();

            if (cbbCareers.SelectedIndex >= 0)
            {
                if (receivedCareerIndex >= 0) { cbbCareers.SelectedIndex = receivedCareerIndex; cbbCareers.Enabled = false; }
                else if (receivedCareer != null && cbbCareers.Items.Contains(receivedCareer)) { cbbCareers.SelectedItem = receivedCareer; cbbCareers.Enabled = false; }
            }
        }
        /// <summary>
        /// Muesta los datos en el Dgv segun el estado del chekbox 
        /// </summary>
        private void filldgvAverages()
        {
            if(cbbCareers.SelectedItem != null)
            {
                object careerSelected = cbbCareers.SelectedItem;
                lblCantidadMaterias.Text = Convert.ToString(subjectController.countSubjectsFromCareer(careerSelected));
                dgvAverages.Rows.Clear();

                List<dynamic> averagesList = new(careerEnrolmentController.getAverageListByOption(careerSelected, mostrarSoloEgresados));

                foreach (object enrol in averagesList)
                {
                    List<dynamic> enrolData = careerEnrolmentController.getAverageData(careerSubjectCount, enrol, careerSelected);

                    dgvAverages.Rows.Add();
                    DataGridViewRow createdRow = dgvAverages.Rows[dgvAverages.Rows.Count - 1];

                    for (int j = 0; j < dgvAverages.Columns.Count; j++)
                    {
                        createdRow.Cells[j].Value = enrolData[j];
                    }
                }
            }
        }

        private void chkOnlyGraduated_CheckedChanged(object sender, EventArgs e)
        {
            mostrarSoloEgresados = chkOnlyGraduated.Checked; // Usamos la variable global para determinar que mostramos
            filldgvAverages();
        }

        private void fillCbbCareer()
        {
            if(careerController.countCareers() > 0)
            {
                cbbCareers.DataSource = careerController.loadCareers(); //May show non active careers as well
            }

        }

        private void cbbCareers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCareers.SelectedItem != null) { careerSubjectCount = subjectController.getSubjectsFromCareerCount(cbbCareers.SelectedItem); }
            filldgvAverages();
        }
    }
}
