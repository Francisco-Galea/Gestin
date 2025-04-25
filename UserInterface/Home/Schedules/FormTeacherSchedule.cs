using Gestin.Controllers;
using Gestin.Controllers.Controllers_Reports;
using Gestin.Model;
using Gestin.Properties;
using Gestin.UI.Custom;

namespace Gestin.UI.Home.Schedules
{
    public partial class formTeacherSchedule : Form
    {
        careerController careerCnt = careerController.getInstance();
        scheduleController scheduleCnt = scheduleController.getInstance();
        teacherController teacherController = teacherController.getInstance();
        teacherSubjectController teacherSubjectCnt = teacherSubjectController.getInstance();

        public formTeacherSchedule()
        {
            InitializeComponent();
            dgvTeacherSchedule.AllowUserToAddRows = false;
        }

        private void textBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchBar.Text.Length == 0)
            {
                listBoxSearchResults.Visible = false;
            }
            else
            {
                listBoxSearchResults.Visible = true;
                loadSearchResults();
            }
        }

        private void loadSearchResults()
        {
            bool checkState = Int32.TryParse(textBoxSearchBar.Text, out _);

            if (checkState)
            {
                listBoxSearchResults.DataSource = teacherController.searchBoxUserTypeWithInt(Int32.Parse(textBoxSearchBar.Text));
            }
            else
            {
                listBoxSearchResults.DataSource = teacherController.searchBoxUserTypeWithString(textBoxSearchBar.Text);
            }
        }

        private void listBoxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSearchResults.SelectedIndex >= 0)
            {
                var teacher = teacherController.getUserType(listBoxSearchResults.SelectedItem);
                lbTeacherName.Text = teacherController.getUserTypeFullName(teacher);
                RefreshTableSubjects(teacher as Teacher);
            }

        }

        public void RefreshTableSubjects(Teacher teach)
        {
            var teacherSub = teacherSubjectCnt.getTeacherSubjects(teach);
            List<Schedule> scheduleList = new();
            foreach (var sub in teacherSub)
            {
                var teachSchedule = scheduleCnt.getTeacherSchedule(sub);
                scheduleList.AddRange(teachSchedule);

            }

            if (listBoxSearchResults.SelectedItem != null)
            {
                try
                {
                    dgvTeacherSchedule.Rows.Clear();
                    var dgvSchedulesDS = scheduleCnt.getTeacherScheduleValues(scheduleList);
                    foreach (var schedule in dgvSchedulesDS)
                    {
                        string subjectName = schedule[0];
                        TimeSpan scheduleTime = TimeSpan.Parse(schedule[1]);
                        string scheduleDay = schedule[2];
                        loadSchedule(scheduleDay, scheduleTime, subjectName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                dgvTeacherSchedule.DataSource = null;
            }
        }

        private void loadSchedule(string subName, TimeSpan schedTime, string schedDay)
        {
            dgvTeacherSchedule.Rows.Add(subName, schedTime, schedDay);
        }
        
        private void btnGenerateScheduleReport_Click_Click(object sender, EventArgs e)
        {
            // Crea una instancia de SaveFileDialog
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.Title = "Guardar Informe de Horarios";
                sfd.FileName = $"Informe_Horarios_{DateTime.Now.ToString("yyyyMMdd")}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo seleccionada por el usuario
                    string filePath = sfd.FileName;

                    // Crea una instancia del controlador y exporta los datos
                    var scheduleExporter = ScheduleReportController.GetInstance();
                    scheduleExporter.ExportTeacherSchedulesToExcel(filePath);

                    // Muestra un mensaje indicando que el archivo ha sido exportado correctamente
                     new MessageBoxDarkMode($"{sfd.FileName} exportado a Excel exitosamente", "Aviso", "Ok", Resources.Done, true);
                }
            }
        }
    }
}
