using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Gestin.Controllers;
using Gestin.Controllers.Controllers_Reports;
using Gestin.Model;
using Gestin.Properties;
using Gestin.Reports;
using Gestin.UI.Custom;
using Gestin.UI.Home.Grades;
using Gestin.UserInterface.Custom;
using Gestin.Validators;
using Microsoft.VisualBasic.ApplicationServices;
using OfficeOpenXml;
using System.Data;

namespace Gestin.UI.Home.Students
{
    public partial class formAcademicRecord : Form
    {
        studentReportController instance = studentReportController.getInstance();
        studentController cntStudent = studentController.getInstance();
        careerEnrolmentController cntCareerEnrolment = careerEnrolmentController.getInstance();
        subjectEnrolmentController cntSubjectEnrolment = subjectEnrolmentController.getInstance();
        gradeController cntGrades = gradeController.getInstance();
        careerController cntCareer = careerController.getInstance();
        subjectController cntSubject = subjectController.getInstance();
        examEnrolmentController cntExamEnrolment = examEnrolmentController.getInstance();
        CancellationTokenSource cancellationTokenSource;
        CancellationToken cancellationToken;
        PictureBoxLoading pictureBoxLoading;

        List<dynamic> listStudentRecords;
        object? selectedCareerEnrolment;
        object selectedStudent;
        object? selectedRecord;
        int nationalIdentityNumber;

        public formAcademicRecord()
        {
            InitializeComponent();
            gbAcademicStatus.Visible = false;
            dgvSubjectsRecord.AutoGenerateColumns = false;
            dgvSubjectsRecord.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void formAcademicRecord_Load(object sender, EventArgs e)
        {
        }

        private void newCancellationTokenSource()
        {
            if (cancellationTokenSource != null)
                cancellationTokenSource.Dispose();

            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
        }


        private void studentLoad()
        {
            if (lbSearch.SelectedItem != null)
            {
                selectedStudent = lbSearch.SelectedItem;
                setStudent(selectedStudent);
                getStudentCareerInfo();
            }
        }

        public void setStudent(object student)
        {
            List<dynamic?> studentValues = cntStudent.getUserTypeValuesFormAcademicRecord(student);

            lblStudentId.Text = studentValues[0];
            txtStudent.Text = studentValues[1];
            txtStudentDni.Text = studentValues[2];
            txtStudentPhoneNumber.Text = studentValues[3];
            txtStudentEmail.Text = studentValues[4];
            txtBirthDate.Text = studentValues[5];
            txtBirthPlace.Text = studentValues[6];
            txtEmergencyContact.Text = studentValues[7];
            txtGender.Text = studentValues[8];

            chkAnalitic.Checked = studentValues[9];
            chkBirthCert.Checked = studentValues[10];
            chkCuil.Checked = studentValues[11];
            chkDni.Checked = studentValues[12];
            chkMedicCerf.Checked = studentValues[13];
            chkPhotos.Checked = studentValues[14];

            nationalIdentityNumber = Convert.ToInt32(txtStudentDni.Text);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text.Length == 0) { lbSearch.Visible = false; }
            else
            {
                lbSearch.Visible = true;
                lbSearch.BringToFront();
                loadLbSeach();
            }
        }
        private void loadLbSeach()
        {
            bool checkInt = Int32.TryParse(searchBox.Text, out _);
            if (checkInt)
                lbSearch.DataSource = cntStudent.searchBoxUserTypeWithInt(Int32.Parse(searchBox.Text));
            else
                lbSearch.DataSource = cntStudent.searchBoxUserTypeWithString(searchBox.Text);
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lbSearch.Focus();
            }
        }


        private async void lbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && lbSearch.SelectedIndex <= 0)
            {
                lbSearch.ClearSelected();
                searchBox.Focus();
            }
            if (e.KeyCode == Keys.Enter && lbSearch.SelectedIndex >= 0)
            {
                studentLoad();
                gbAcademicStatus.Visible = true;
                lbSearch.Visible = false;
                //gbSeeRegistration.Visible = true;
            }
        }

        private async void lbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gbAcademicStatus.Visible = true;
            int index = lbSearch.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                studentLoad();
                lbSearch.Visible = false;
                gbSeeRegistration.Visible = true;
            }
        }

        private void getStudentCareerInfo()
        {
            if (cbbCareerEnrolment.Items.Count > 0) { cbbCareerEnrolment.Items.Clear(); }

            foreach (object item in cntCareerEnrolment.searchCareerEnrolments(nationalIdentityNumber))
            {
                cbbCareerEnrolment.Items.Add(item);
            }
            cbbCareerEnrolment.SelectedIndex = 0;
        }

        private void ShowEnrolledSubjects()
        {
            var listSubjectsEnroled = cntSubjectEnrolment.getEnrolments(nationalIdentityNumber, selectedCareerEnrolment);
            /*var studentGrades = cntGrades.getStudentGrades(dni);

            var approvedSubjects = studentGrades.Where(grade => grade.Grade1 >= 4).Select(grade => grade.Subject).ToList();*/

            var enroledSubjects = listSubjectsEnroled.Select(enrolment => enrolment.Subject).ToList();

            foreach (var subject in enroledSubjects)
            {
                //AddSubjectEnrolment(subject.YearInCareer, subject);
            }
        }

        private bool getAllStudentGrades()
        {
            return setDataSource(listStudentRecords);
        }

        private bool getCurrentStudentGrades()
        {
            List<dynamic> filteredStudentRecords = new(cntGrades.getCurrentStudentRecords(listStudentRecords));
            return setDataSource(filteredStudentRecords);
        }

        private bool setDataSource(List<object> studentRecord)
        {
            if (dgvSubjectsRecord.DataSource != null)
            {
                dgvSubjectsRecord.DataSource = null;
            }
            dgvSubjectsRecord.DataSource = studentRecord;

            return dgvSubjectsRecord.DataSource != null;
        }

        private void dgvSubjectsRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvSubjectsRecord.CurrentRow != null)
                {
                    int index = dgvSubjectsRecord.CurrentRow.Index;
                    formEditGrade formEditGrade_ = new formEditGrade(selectedRecord, txtStudent.Text, Convert.ToInt32(lblStudentId.Text));
                    formEditGrade_.ShowDialog();
                    resetStudentRecords(index);
                    showGradesByToggleable();
                    showAcademicStatus();
                }
            }
            catch (ArgumentNullException) { throw; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRecord != null)
                {
                    DataGridViewRow rowData = dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex];

                    int gradeId = Convert.ToInt32(rowData.Cells[0].Value);
                    int subjectEnrolmentId = Convert.ToInt32(rowData.Cells[9].Value);
                    bool status = false;

                    // Verify if subject has a grade
                    if (gradeId != 0)
                    {
                        /*string warningMessage = "No se eliminarán registros académicos que contengan notas de estudiantes.";
                        MessageBoxDarkMode warningBox = new MessageBoxDarkMode(warningMessage, "Advertencia", "Accept", Resources.advertencia, true, Color.Yellow);
                        warningBox.ShowDialog();*/
                        btnDelete.Enabled = false;
                        return;
                    }
                    else
                    {
                        string confirm = "Atención, esto eliminará la matriculación del estudiante y la inscripción del estudiante al examen (si existe). \r\r ¿Está seguro de que desea proceder?";
                        MessageBoxDarkMode confirmBox = new MessageBoxDarkMode(confirm, "Confirme la eliminación", "YesNo", Resources.Error, true, System.Drawing.Color.Red);
                        if (generalValidator.messageBoxDialogResult(confirmBox))
                        {
                            if (cntExamEnrolment.checkStudentInExams(selectedStudent, selectedRecord))
                            {
                                status = cntExamEnrolment.unrolStudentAllExams(selectedStudent, selectedRecord);
                            }

                            status = cntSubjectEnrolment.deleteEnrolment(subjectEnrolmentId);

                            if (status)
                            {
                                selectedRecord = null;
                                resetStudentRecords(0);
                                showGradesByToggleable();
                                new MessageBoxDarkMode("Registro Eliminado", "Éxito", "Yes", Resources.Error, true);
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }
            }
            catch (Exception caughtException)
            {
                MessageBox.Show(caughtException.Message);
            }
        }

        private async void cbbCareer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCareerEnrolment.SelectedItem != null)
            {
                selectedCareerEnrolment = cbbCareerEnrolment.SelectedItem;
                await loadDataAsync();
            }
        }

        private async Task loadDataAsync()
        {
            newCancellationTokenSource();

            try
            {
                if (!cancellationTokenSource.IsCancellationRequested)
                {
                    pictureBoxLoading = new PictureBoxLoading(this);

                    await Task.Delay(500); //A short delay must be given, otherwise the thread executes too quickly

                    await loadStudentRecordDataAsync(0);
                }
                pictureBoxLoading.destroyLoadingPictureBox();
            }
            catch (Exception) { throw; }
        }

        private async Task loadStudentRecordDataAsync(int index)
        {
            if (selectedCareerEnrolment != null)
            {
                await Task.Run(async () =>
                {
                    listStudentRecords = new(cntGrades.getAllStudentRecords(nationalIdentityNumber, selectedCareerEnrolment));
                }, cancellationToken);


                if (!cancellationToken.IsCancellationRequested)
                {
                    selectedRecord = null;
                    selectedCareerEnrolment = cbbCareerEnrolment.SelectedItem;
                    showGradesByToggleable();
                    if (index > 0) { dgvSubjectsRecord.Rows[index].Selected = true; }
                    showAcademicStatus();
                }
            }
        }

        private void resetStudentRecords(int index)
        {
            loadStudentRecordDataAsync(index);
        }

        private void showAcademicStatus()
        {
            if (selectedCareerEnrolment != null)
            {
                List<dynamic> listGrades = new(cntGrades.requestStudentGrades(nationalIdentityNumber, selectedCareerEnrolment));

                if (listGrades.Count > 0)
                    txtAverage.Text = $"{cntGrades.calculateAverage(listGrades)}";
                else
                    txtAverage.Text = string.Empty;

                if (listGrades.Count == cntCareerEnrolment.getCareerSubjectNumber(selectedCareerEnrolment))
                    txtAcademicStatus.Text = "Finalizada";
                else
                    txtAcademicStatus.Text = "En Cursada";

                txtAccreditedSubjects.Text = $"{listGrades.Count}";

                txtPendingSubjects.Text = $"{cntSubject.getSubjectCountFromCareerEnrolment(selectedCareerEnrolment) - listGrades.Count}";
            }
        }

        private void btnEmitRegularStudentCertificate_Click(object sender, EventArgs e)
        {
            if (selectedStudent != null && selectedCareerEnrolment != null)
            {
                new formRegularStudentCertificate(selectedStudent, selectedCareerEnrolment).ShowDialog();
            }
        }

        private void toggSearchRegistrations_CheckedChanged(object sender, EventArgs e)
        {
            if (toggSearchRegistrations.Checked)
            {
                lbSearchRegistration.Text = "Años anteriores";
                getAllStudentGrades();
            }
            else
            {
                lbSearchRegistration.Text = "Año actual";
                getCurrentStudentGrades();
            }
        }

        private void showGradesByToggleable()
        {
            if (toggSearchRegistrations.Checked ? getAllStudentGrades() : getCurrentStudentGrades()) ;
        }

        private void btnPartialAnalytical_Click(object sender, EventArgs e)
        {
            if (lbSearch.SelectedItem != null)
            {
                FormPartialAnalytical formPartialAnalytical = new FormPartialAnalytical(selectedStudent, selectedCareerEnrolment);
                formPartialAnalytical.ShowDialog();
            }
        }

        private void dgvSubjectsRecord_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSubjectsRecord.CurrentRow != null)
            {
                DataGridViewRow rowData = dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex];
                int gradeId = Convert.ToInt32(rowData.Cells[0].Value);
                int subjectEnrolmentId = Convert.ToInt32(rowData.Cells[9].Value);

                selectedRecord = cntGrades.rebuildStudentRecord(gradeId, subjectEnrolmentId);

                btnDelete.Enabled = gradeId == 0;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void dgvSubjectsRecord_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        { // I really really really hate reformatting dateTimes
            if (e.ColumnIndex == 6 && e.Value != null && e.Value is DateTime)
            {
                DateTime dateValue = (DateTime)e.Value;
                if (dateValue == DateTime.MinValue)
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

    }

    
}