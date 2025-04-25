using Gestin.Controllers;
using Gestin.Model;
using Gestin.Properties;
using Gestin.UI.Commons;
using Gestin.UI.Custom;
using Gestin.Validators;

namespace Gestin.UI.Home.ExamEnrolment
{
    public partial class formExamEnrolmentAdmin : Form
    {
        studentController cntStudent = studentController.getInstance();
        examController examCnt = examController.getInstance();
        examEnrolmentController examEnrolCnt = examEnrolmentController.getInstance();
        int selectedStudentId = -1;

        public formExamEnrolmentAdmin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the exams available for a given student, clears previous entries, and updates UI labels.
        /// </summary>
        /// <param name="studentDni">Student DNI.</param>
        /// <param name="studentName">Student full name.</param>
        /// <param name="studentId">Student ID.</param>
        private void loadExams(int studentDni, string studentName, int studentId)
        {
            selectedStudentId = studentId;
            lblDni.Text = studentDni.ToString();
            lblStudent.Text = studentName;
            dgvExams.Rows.Clear();

            var list = examCnt.loadEnableEnrolmentExams(studentDni);
            if (list.Item1 == null)
            {
                ShowErrorMessage(list.Item2);
            }
            else if (list.Item1.Count == 0)
            {
                ShowNoExamsAvailableMessage();
            }
            else
            {
                foreach (Exam e in list.Item1)
                {
                    addExam(e);
                }
            }
        }

        /// <summary>
        /// Adds a single exam to the DataGridView.
        /// </summary>
        /// <param name="ex">Exam object to add.</param>
        private void addExam(Exam ex)
        {
            dgvExams.Rows.Add(
                ex.Id,
                ex.IdSubjectNavigation.Career.Id,
                ex.IdSubjectNavigation.Id,
                ex.IdSubjectNavigation.Career.Name,
                ex.IdSubjectNavigation.Name,
                ex.Date,
                ex.Call
            );
        }

        /// <summary>
        /// Updates visibility of search label and loads search results if input is not empty.
        /// </summary>
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            lbSearch.Visible = searchBox.Text.Length > 0;
            if (lbSearch.Visible)
            {
                lbSearch.BringToFront();
                loadSearchResults();
            }
        }

        /// <summary>
        /// Loads search results based on input type (numeric or text).
        /// </summary>
        private void loadSearchResults()
        {
            bool isNumeric = int.TryParse(searchBox.Text, out int numericValue);
            lbSearch.DataSource = isNumeric
                ? cntStudent.searchBoxUserTypeWithInt(numericValue)
                : cntStudent.searchBoxUserTypeWithString(searchBox.Text);
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lbSearch.Focus();
            }
        }

        private void lbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && lbSearch.SelectedIndex <= 0)
            {
                lbSearch.ClearSelected();
                searchBox.Focus();
            }
            else if (e.KeyCode == Keys.Enter && lbSearch.SelectedIndex >= 0)
            {
                searchStudent();
            }
        }

        /// <summary>
        /// Searches for the selected student and loads their exams.
        /// </summary>
        private void searchStudent()
        {
            if (lbSearch.SelectedItem is Student student)
            {
                loadExams(student.User.Dni, $"{student.User.Name} {student.User.LastName}", student.Id);
                searchBox.Clear();
            }
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            var messageBox = new MessageBoxDarkMode("¿Está seguro que desea realizar la inscripción?", "Confirmar", "OkCancel", Resources.advertencia, true);
            if (generalValidator.messageBoxDialogResult(messageBox))
            {
                EnrolSelectedExams();
            }
        }

        /// <summary>
        /// Iterates over selected exams and enrols the student, verifying correlatives.
        /// </summary>
        private void EnrolSelectedExams()
        {
            foreach (DataGridViewRow item in dgvExams.SelectedRows)
            {
                int subjectId = Convert.ToInt32(item.Cells[2].Value);
                int examId = Convert.ToInt32(item.Cells[0].Value);

                if (CanEnrolStudent(subjectId, examId))
                {
                    dgvExams.Rows.Remove(item);
                }
            }
        }

        /// <summary>
        /// Checks if student can enrol to the exam based on correlatives.
        /// </summary>
        /// <param name="subjectId">The subject ID.</param>
        /// <param name="examId">The exam ID.</param>
        /// <returns>True if enrolled, otherwise false.</returns>
        private bool CanEnrolStudent(int subjectId, int examId)
        {
            bool hasCorrelatives = examEnrolCnt.verifyCorrelatives(subjectId, selectedStudentId).Item1;

            if (!hasCorrelatives)
            {
                var confirmInscription = MessageBox.Show("El estudiante no cumple los requisitos para inscribirse en este examen. ¿Desea continuar?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmInscription != DialogResult.Yes)
                {
                    return false;
                }
            }

            return examEnrolCnt.enrolStudentToExam(selectedStudentId, examId);
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
            searchStudent();
        }

        /// <summary>
        /// Shows an error message in a MessageBox.
        /// </summary>
        /// <param name="message">Error message text.</param>
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// Shows a modal dialog indicating no exams are available for the student.
        /// </summary>
        private void ShowNoExamsAvailableMessage()
        {
            var forminfo = new formShowInfo("No hay exámenes disponibles para este estudiante", Resources.CloudError);
            forminfo.ShowDialog();
        }
    }
}

