using Gestin.Controllers;
using Gestin.Model;
using Gestin.Properties;
using Gestin.UI.Commons;
using Gestin.UI.Custom;
using Gestin.UI.Home.Exams;

namespace Gestin.UI.Home.ExamEnrolment
{
    public partial class formGradeFromExam : Form
    {
        #pragma warning disable CS4014 //remove async warnings
        careerEnrolmentController cntCarEnrol = careerEnrolmentController.getInstance();
        examEnrolmentController cntExamEnrol = examEnrolmentController.getInstance();
        examController cntExam = examController.getInstance();
        gradeController cntGrade = gradeController.getInstance();
        subjectEnrolmentController cntSubEnrol = subjectEnrolmentController.getInstance();
        Exam exam;
        formExams formExams;
        string bookRecordPresential;
        string bookRecordFree;
        public formGradeFromExam(int IdExam, formExams formExam)
        {
            InitializeComponent();
            formExams = formExam;
            exam = cntExam.findExam(IdExam);
            lblExam.Text = exam.IdSubjectNavigation.Name + " " + exam.Date.ToString("dd-MM-yyyy");
            foreach (Student item in cntExamEnrol.getEnroledStudent(IdExam))
            {
                addExam(item);
            }
            txtFreeBook.Text = bookRecordFree;
            txtPresentialBook.Text = bookRecordPresential;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            formExams.loadAllExams();
        }

        private void btnUnrol_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentCell == null)
            {
                new MessageBoxDarkMode("No hay un estudiante en la lista.", "Aviso", "Ok", Resources.Error, true);
                return;
            }

            int? stdId = (int?)dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells["studentId"].Value;
            string? stdName = dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells["name"].Value.ToString();

            if (stdId != null)
            {
                if (!string.IsNullOrEmpty(dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells["grade"].Value.ToString()))
                {
                    new MessageBoxDarkMode("No se puede dar de baja a un examen que ya se rindió", "Aviso", "Ok", Resources.Error, true);
                }
                else
                {
                    var result = formConfirmation.ShowDialog(this, "¿Está seguro que desea desinscribir este estudiante?",
                        "El estudiante " + stdName + " será dado de baja del examen de " + exam.IdSubjectNavigation.Name);

                    if (result == DialogResult.Yes)
                    {
                        var status = cntExamEnrol.unrolStudent((int)stdId, exam);
                        updateUnenrolLabel(status.Item2, status.Item1);

                        if (status.Item1)
                        {
                            if (dgvStudents.SelectedRows.Count > 0)
                            {
                                dgvStudents.Rows.RemoveAt(dgvStudents.SelectedRows[0].Index);
                            }
                        }
                    }
                }
            }
        }
        private async Task updateUnenrolLabel(string msg, bool success)
        {
            if (!success)
            {
                lblError.ForeColor = Color.IndianRed;
                lblError.Image = Resources.Error;
            }
            else
            {
                lblError.ForeColor = Color.FromArgb(75, 181, 67);
                lblError.Image = Resources.TickIcon;
            }
            lblError.Text = "         " + msg;
            lblError.Visible = true;
            await Task.Delay(2000);
            lblError.Visible = false;
        }
        private void addExam(Student std)
        {
            try
            {
                var grade = cntGrade.getStudentGradeForExams(std.Id, exam.IdSubject, exam.Date);
                var accType = cntSubEnrol.getAccreditationType(std.User.Dni, exam.IdSubject);

                if (grade == null)
                    dgvStudents.Rows.Add(std.Id, std.User.fullName(), accType, "");
                else if (grade.Grade1 == -1)
                    dgvStudents.Rows.Add(std.Id, std.User.fullName(), accType, "AUSENTE");
                else
                    dgvStudents.Rows.Add(std.Id, std.User.fullName(), accType, grade?.Grade1);
                if (accType == "Presencial" && grade != null)
                    bookRecordPresential = grade.BookRecord;
                if (accType == "Libre" && grade != null)
                    bookRecordFree = grade.BookRecord;
            }
            catch (Exception ex)
            {
                updateUnenrolLabel(ex.Message, false);
            }
        }
        private void btnAddGrades_Click(object sender, EventArgs e)
        {
            int _grade;
            string bookRecord;
            var result = formConfirmation.ShowDialog(this, "¿Esta seguro que desea agregar notas?",
                    ("Se actualizaran TODAS las notas."));
            if (result == DialogResult.Yes)
            {
                (bool, string) state = (true, "Notas cargadas correctamente");
                try
                {
                    foreach (DataGridViewRow row in dgvStudents.Rows)
                    {
                        _grade = -1;

                        if (row.Cells["condition"].Value.ToString() == "Libre")
                            bookRecord = txtFreeBook.Text;
                        else
                            bookRecord = txtPresentialBook.Text;

                        if (row.Cells["grade"].Value != "AUSENTE" && row.Cells["grade"].Value != null && row.Cells["grade"].Value != "")
                            _grade = Convert.ToInt32(row.Cells["grade"].Value);

                        Grade grade = cntGrade.getStudentGradeForExams(
                                        (int)row.Cells["studentId"].Value,
                                        exam.IdSubject,
                                        (DateTime)exam.Date
                                        );

                        if (grade == null)
                        {
                            if (!cntGrade.addGrade(
                                (int)row.Cells["studentId"].Value,
                                exam.IdSubjectNavigation,
                                _grade,
                                bookRecord,
                                exam.Date,
                                cntSubEnrol.getAccreditationTypeWithStudentId((int)row.Cells["studentId"].Value, exam.IdSubject)
                            ))
                                state = (false, "Error en la fila" + row.Index.ToString());
                        }
                        else
                        {
                            if (!cntGrade.updateGrade(grade,
                                _grade,
                                bookRecord
                                   ))
                                state = (false, "Error en la fila" + row.Index.ToString());
                        }
                    }
                    updateUnenrolLabel(state.Item2, state.Item1);
                    notifyGraduate(exam.IdSubjectNavigation.CareerId, exam.IdSubjectNavigation.Career.Name, getStudentIds(), getStudentFullNames());
                }
                catch (Exception ex) { updateUnenrolLabel(ex.Message, false); }
            }

        }
        private List<int> getStudentIds()
        {
            List<int> studentIds = new List<int>();
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                int studentId = (int)row.Cells["studentId"].Value;
                studentIds.Add(studentId);
            }
            return studentIds;
        }
        private List<string> getStudentFullNames()
        {
            List<string> studentNames = new List<string>();
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                string studentName = (string)row.Cells["name"].Value;
                studentNames.Add(studentName);
            }
            return studentNames;
        }
        private void notifyGraduate(int careerId, string careerName, List<int> studentIds, List<string> studentNames)
        {
            string graduatesNames = "";
            int aux = 0;
            int countGraduates = 0;
            foreach (int studentId in studentIds)
            {
                if (cntCarEnrol.verifyIfTheStudentIsGraduate(careerId, studentId))
                {
                    graduatesNames += $"[{studentNames[aux]}]";
                    countGraduates++;
                }
                aux++;
            }
            if (countGraduates == 1)
                MessageBox.Show($"Estudiante {graduatesNames} está graduado de la carrera {careerName}");
            else if (countGraduates > 1)
                MessageBox.Show($"Estudiantes {graduatesNames} están graduados de la carrera {careerName}");
        }
    }
}
