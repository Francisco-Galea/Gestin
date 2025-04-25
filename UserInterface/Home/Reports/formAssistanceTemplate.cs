using Gestin.Controllers;
using Gestin.Controllers.Controllers_Report;
using Gestin.Properties;
using Gestin.UI.Custom;

namespace Gestin.UserInterface.Home.Assistance
{
    public partial class formAssistanceTemplate : Form
    {
        subjectEnrolmentController subjectEnrolmentController = subjectEnrolmentController.getInstance();
        subjectController subjectController = subjectController.getInstance();
        careerController careerController = careerController.getInstance();
        teacherSubjectController teacherSubjectController = teacherSubjectController.getInstance();
        object receivedCareer;
        object receivedSubject;
        object? subjectEnrolment;
        string? imageRoute;
        bool startingSubject = true;

        public formAssistanceTemplate(object career, object subject)
        {
            InitializeComponent();
            receivedCareer = career;
            receivedSubject = subject;
        }

        private void formAssistanceTemplate_Load(object sender, EventArgs e)
        {
            if (receivedCareer != null && receivedSubject != null)
            {
                loadComboBox(receivedCareer);
                cbbSubjectCareer.SelectedIndex = cbbSubjectCareer.FindStringExact(subjectController.getSubjectName(receivedSubject));
                loadData(receivedSubject);
            }
            loadSubjectEnrolmentData();

            // Cargar la imagen guardada
            string savedImagePath = ImageSelectionController.getInstance().ReadSelectedImagePathFromConfig();
            if (!string.IsNullOrEmpty(savedImagePath))
            {
                pictureBoxLogo.Image = Image.FromFile(savedImagePath);
                imageRoute = savedImagePath;
            }
        }

        private void loadData(object selectedSubject)
        {
            subjectEnrolment = subjectEnrolmentController.getEnrolment(selectedSubject, receivedCareer);
            lblCareerName.Text = careerController.getCareerName(receivedCareer);
            txtCourseYear.Text = Convert.ToString(subjectController.getSubjectYearInCareer(selectedSubject));
            loadCbbTeacherSubjects(selectedSubject);
            loadCbbYearEnrolments(selectedSubject);
        }

        private void loadComboBox(object receivedCareer)
        {
            cbbSubjectCareer.DataSource = subjectController.getSubjectsFromCareer(receivedCareer);
            cbbSubjectCareer.DisplayMember = "NAME";
            cbbSubjectCareer.ValueMember = "ID";
            startingSubject = false;
        }

        private void loadCbbYearEnrolments(object selectedSubject)
        {
            cbbSubjectEnrolmentYear.DataSource = subjectEnrolmentController.getSubjectEnrolmentsYear(selectedSubject);
        }

        private void loadCbbTeacherSubjects(object selectedSubject)
        {
            cbbTeacherSubject.DataSource = teacherSubjectController.getTeachersFromSubject(selectedSubject);
        }

        private void loadSubjectEnrolmentData()
        {
            if (subjectEnrolment != null && cbbSubjectEnrolmentYear.SelectedItem != null)
            {
                int year = Convert.ToInt32(cbbSubjectEnrolmentYear.SelectedItem);
                List<int> subjectEnrolmentData = subjectEnrolmentController.subjectEnrolmentCountData(subjectEnrolment, year);

                if (subjectEnrolmentData.Any())
                {
                    lblPresential.Text = Convert.ToString(subjectEnrolmentData[0]);
                    lblSelfStudy.Text = Convert.ToString(subjectEnrolmentData[1]);
                    lblTotal.Text = Convert.ToString(subjectEnrolmentData[2]);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (verifyInputs())
            {
                string selectedYear = Convert.ToString(cbbSubjectEnrolmentYear.SelectedItem);
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = $"Asistencia-{cbbSubjectCareer.Text.Replace(" ", "_")}-{selectedYear}.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    assistanceModelTemplateController assistanceModelTemplate = assistanceModelTemplateController.getInstance();

                    assistanceModelTemplate.setupAssistanceModelTemplate(
                        save.FileName,
                        txtInstitute.Text,
                        receivedCareer,
                        receivedSubject,
                        Convert.ToString(cbbTeacherSubject.SelectedItem),
                        selectedYear,
                        txtCourseYear.Text,
                        imageRoute
                        );

                    assistanceModelTemplateController.destroyInstance();
                }
            }
        }

        private bool verifyInputs()
        {
            if (receivedSubject == null)
            { new MessageBoxDarkMode("Por favor seleccione una materia", "Error", "Ok", Resources.Error); return false; }
            if (cbbSubjectEnrolmentYear.SelectedItem == null)
            { new MessageBoxDarkMode("Por favor seleccione año de cursada", "Error", "Ok", Resources.Error); return false; }
            if (string.IsNullOrEmpty(txtInstitute.Text))
            { new MessageBoxDarkMode("Por favor ingrese el nombre del Instituto", "Error", "Ok", Resources.Error); return false; }
            if (pictureBoxLogo.Image == null || string.IsNullOrEmpty(imageRoute))
            { new MessageBoxDarkMode("Por favor seleccione un logo", "Error", "Ok", Resources.Error); return false; }

            return true;
        }

        private void cbbSubjectEnrolmentYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSubjectEnrolmentData();

            if (cbbSubjectEnrolmentYear.Text != DateTime.Now.Year.ToString())
            {
                cbbSubjectEnrolmentYear.ForeColor = Color.Red;
            }
            else
            {
                cbbSubjectEnrolmentYear.ForeColor = Color.White;
            }
        }

        private void btnModifyImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.Title = "Seleccionar Imagen";

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                imageRoute = openFile.FileName;
                if (imageRoute.Length > 0)
                {
                    pictureBoxLogo.Image = Image.FromFile(imageRoute);
                    ImageSelectionController.getInstance().SaveSelectedImagePathToConfig(imageRoute); // Guardar la ruta en la configuración
                }
            }
        }

        private void cbbSubjectCareer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSubjectCareer.SelectedItem != null)
            {
                object selectedSubject = cbbSubjectCareer.SelectedItem;

                if (!startingSubject)
                {
                    receivedSubject = selectedSubject;
                    loadData(selectedSubject);
                }
            }
        }
    }
}
