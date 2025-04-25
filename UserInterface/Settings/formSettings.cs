using Gestin.Controllers;
using Gestin.UI.Custom;

namespace Gestin.UI.Settings
{
    public partial class formSettings : Form
    {
        examController examController = examController.getInstance();
        studentController studentController = studentController.getInstance();
        public formSettings()
        {
            InitializeComponent();
        }

        private void btnLoginDataDelete_Click(object sender, EventArgs e)
        {
            if (LocalFiles.LocalSecurity.Instance.deleteUserCredentialsFile())
            {
                new MessageBoxDarkMode("Archivo borrado, reiniciando...", "Exitoso", "Ok", Properties.Resources.Done, true);
                Application.Restart();
            }
        }




        private void btnConnectionSetter_Click(object sender, EventArgs e)
        {
            new formConnectionSetter().ShowDialog();
        }

        private void btnUpdateExams_Click(object sender, EventArgs e)
        {
            var Exams = examController.getAllExams();

            if (examController.updateExamsPeriods(Exams) && examController.updateExamsCalls(Exams))
            {
                new MessageBoxDarkMode("Examenes fueron actualizados", "Update Successful", "Ok", Properties.Resources.Done);
            }
            else
            {
                new MessageBoxDarkMode("Cada examen ya esta actualizado", "Error", "Ok", Properties.Resources.BigErrorIcon);
            }

        }

        private void deleteDuplicateStudents_Click(object sender, EventArgs e)
        {
            studentController.deleteDuplicateStudents();
        }
    }
}
