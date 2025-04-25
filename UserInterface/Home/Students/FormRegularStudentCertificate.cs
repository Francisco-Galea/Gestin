using Gestin.Controllers;
using HtmlAgilityPack;
using Gestin.UI.Commons;
using Gestin.Properties;
using Gestin.UI.Custom;

namespace Gestin.UI.Home.Students
{
    public partial class formRegularStudentCertificate : Form
    {
        careerEnrolmentController cntCareerEnrolment = careerEnrolmentController.getInstance();
        studentController cntStudent = studentController.getInstance();
        regularStudentCertificateController cntRegularStudentCertificate = regularStudentCertificateController.getInstance();
        ImageSelectionController cntSetting = ImageSelectionController.getInstance();
        HtmlNode imgElement;
        object selectedStudent;
        object selectedCareerEnrolment;

        public formRegularStudentCertificate(object sentStudent, object sentCareerEnrolment)
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
                var careerId = cntCareerEnrolment.getCareerEnrolmentCareerId(selectedCareerEnrolment);
                txtStudent.Text = cntStudent.getUserTypeFullName(selectedStudent);
                txtDni.Text = dni.ToString();
                var ListCareer = cntCareerEnrolment.searchCareerEnrolments(dni);

                foreach (object item in ListCareer)
                {
                    cbbSpecialty.Items.Add(item);
                }

                if (ListCareer.Count > 0)
                {
                    int indiceSeleccionado = ListCareer.FindIndex(obj => obj.CareerId == careerId);

                    if (indiceSeleccionado != -1)
                    {
                        cbbSpecialty.SelectedIndex = indiceSeleccionado;
                    }
                }
            }
            if (cntSetting.ReadSelectedImagePathFromConfig() != null)
            {
                try
                {
                    UpdatePictureBox(cntSetting.ReadSelectedImagePathFromConfig());

                }
                catch (FileNotFoundException)
                {
                    ChooseImagePath(imgElement);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = $"CertRegular-{txtStudent.Text.Replace(" ", "")}.pdf";

            if(noEmptyFields())
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    cntRegularStudentCertificate.generateRegularStudentCertificate(txtStudent.Text, txtNumberInsti.Text, txtDni.Text, cbbCourse.SelectedItem.ToString(), cbbSpecialty.SelectedItem.ToString(), txtCity.Text, save.FileName);
                    Dispose();
                    formShowInfo formInfo = new formShowInfo("El certificado se genero exitosamente", Resources.Done);
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
            { new MessageBoxDarkMode("Por favor seleccione año de cursada", "Error", "Ok", Resources.Error); return false; }
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
            if (ptbLogo.Image == null)
            { new MessageBoxDarkMode("Por favor seleccione una imagen con el logo del instituto", "Error", "Ok", Resources.Error); return false; }
            return true;
        }


        private void modifyLogo_Click_1(object sender, EventArgs e)
        {
            ChooseImagePath(imgElement);
            UpdatePictureBox(cntSetting.ReadSelectedImagePathFromConfig());
        }


        private void UpdatePictureBox(string PathImage)
        {
            if (cntSetting.ReadSelectedImagePathFromConfig() != null)
            {
                ptbLogo.Image = Image.FromFile(PathImage);
            }
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


        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
