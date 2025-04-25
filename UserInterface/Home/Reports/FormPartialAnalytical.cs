using Gestin.Controllers;
using Gestin.Properties;
using Gestin.UI.Commons;
using Gestin.UI.Custom;
using HtmlAgilityPack;

namespace Gestin.UI.Home.Students
{
    public partial class FormPartialAnalytical : Form
    {
        careerEnrolmentController cntCareerEnrolment = careerEnrolmentController.getInstance();
        ImageSelectionController cntSetting = ImageSelectionController.getInstance();
        PartialAcademicTranscriptController cntAnalyticalPartial = PartialAcademicTranscriptController.getInstance();
        careerController cntCareer = careerController.getInstance();
        gradeController cntGrades = gradeController.getInstance();
        studentController cntStudent = studentController.getInstance();
        object selectedStudent;
        object selectedCareerEnrolment;
        HtmlNode imgElement;

        public FormPartialAnalytical(object sentStudent, object sentCareerEnrolment)
        {
            InitializeComponent();
            selectedStudent = sentStudent;
            selectedCareerEnrolment = sentCareerEnrolment;
            setStudentForm();
        }

        public void setStudentForm()
        {
            if (selectedStudent != null)
            {
                var dni = cntStudent.getUserTypeDNI(selectedStudent);
                int careerId = cntCareerEnrolment.getCareerEnrolmentCareerId(selectedCareerEnrolment);
                int studentId = cntStudent.getUserTypeId(selectedStudent);
                txtStudent.Text = cntStudent.getUserTypeFullName(selectedStudent);
                txtDni.Text = dni.ToString();
                var ListCareer = cntCareerEnrolment.searchCareerEnrolments(dni);
                
                if (cbbSpecialty.Items.Count == 0)
                {
                    foreach (object item in ListCareer)
                    {
                        cbbSpecialty.Items.Add(item);
                    }
                }

                if (ListCareer.Count > 0)
                {
                    int selectedIndex = ListCareer.FindIndex(obj => obj.CareerId == careerId);

                    if (selectedIndex != -1)
                    {
                        cbbSpecialty.SelectedIndex = selectedIndex;
                    }
                }
                txtResolution.Text = cntCareer.getCareerResolution(careerId);
                txtCantOfApprovedSubjects.Text = cntGrades.countApprovedSubjects(careerId, studentId).ToString();
                txtPercentageOfSubjects.Text = cntCareerEnrolment.careerCompletionPercentageByCareerId(careerId, dni).ToString();
            }
            if (cntSetting.ReadSelectedImagePathFromConfig() != null)
            {
                try
                {
                    UpdatePictureBox(cntSetting.ReadSelectedImagePathFromConfig());

                }catch (FileNotFoundException) 
                {
                    ChooseImagePath(imgElement);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = $"AnaliticoParcial-{txtStudent.Text.Replace(" ", "")}.pdf";

            if(noEmptyFields())
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    cntAnalyticalPartial.generateAnalyticPartial(save.FileName, txtNumberInsti.Text, txtStudent.Text, txtResolution.Text, txtCantOfApprovedSubjects.Text, txtDni.Text, cbbSpecialty.SelectedItem, txtCity.Text, txtPercentageOfSubjects.Text, cbbCourse.SelectedItem.ToString());
                    formShowInfo formInfo = new formShowInfo("El analitico parcial se genero correctamente", Resources.Done);
                    formInfo.ShowDialog();
                }
                else
                {
                    Dispose();
                }
            }
        }

        private bool noEmptyFields()
        {
            if (cbbCourse.SelectedItem == null) 
            { new MessageBoxDarkMode("Por favor seleccione año de cursada", "Error", "Ok", Resources.Error);  return false; }
            if (cbbSpecialty.SelectedItem == null)
            { new MessageBoxDarkMode("Por favor seleccione especialidad/tecnicatura", "Error", "Ok", Resources.Error); return false; }
            if (txtDni.Text == string.Empty)
            { new MessageBoxDarkMode("Por favor ingrese DNI del estudiante", "Error", "Ok", Resources.Error); return false; }
            if (txtStudent.Text == string.Empty)
            { new MessageBoxDarkMode("Por favor ingrese el nombre del estudiante", "Error", "Ok", Resources.Error); return false; }
            if (txtCity.Text == string.Empty)
            { new MessageBoxDarkMode("Por favor ingrese el nombre de la cuidad", "Error", "Ok", Resources.Error); return false; }
            if (txtNumberInsti.Text == string.Empty)
            { new MessageBoxDarkMode("Por favor ingrese el # del Instituto", "Error", "Ok", Resources.Error); return false; }
            if (txtResolution.Text == string.Empty)
            { new MessageBoxDarkMode("Por favor ingrese la resolución de la carrera", "Error", "Ok", Resources.Error); return false; }
            if (txtPercentageOfSubjects.Text == string.Empty)
            { new MessageBoxDarkMode("Por favor ingrese porcentaje de materias aprobadas", "Error", "Ok", Resources.Error); return false; }
            return true;
        }

        private void cbbSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            setStudentForm();
        }

        /// <summary>
        /// Actualiza la imagen en el pictureBox del form
        /// </summary>
        private void UpdatePictureBox(string PathImage)
        {
            if (cntSetting.ReadSelectedImagePathFromConfig() != null)
            {
                ptbLogo.Image = Image.FromFile(PathImage);
            }
        }

        private void modifyLogo_Click(object sender, EventArgs e)
        {
            ChooseImagePath(imgElement);
            UpdatePictureBox(cntSetting.ReadSelectedImagePathFromConfig());
        }

        public void ChooseImagePath(HtmlNode imgElement)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar Imagen";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string nuevaRutaImagen = openFileDialog.FileName;
                if (nuevaRutaImagen.Length > 0)
                {
                    cntSetting.SaveSelectedImagePathToConfig(nuevaRutaImagen);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
