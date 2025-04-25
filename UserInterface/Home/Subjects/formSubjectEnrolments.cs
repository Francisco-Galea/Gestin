using Gestin.Controllers;
using Gestin.Properties;
using Gestin.UI.Custom;

namespace Gestin.UI.Home.Subjects
{
    public partial class formSubjectEnrolments : Form
    {
        careerEnrolmentController cntCareerEnrolment = careerEnrolmentController.getInstance();
        subjectEnrolmentController cntSubjectEnrolment = subjectEnrolmentController.getInstance();
        studentController cntStudentController = studentController.getInstance();
        List<DataGridViewRow> modifiedRows = new List<DataGridViewRow>();

        List<int> columnIndexDragDomain = new() { 3, 4, 5 }; //EnrolmentYear, Presential, Approved
        private bool isDragging = false;
        private dynamic? initialCellValue = null;
        private int initialColumnIndex = -1;

        public formSubjectEnrolments()
        {
            InitializeComponent();
            dgvSubjects.Enabled = false;
            dgvSubjects.CellContentClick += CheckBoxVerification;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text.Length == 0) { lbSearch.Visible = false; }
            else
            {
                dgvSubjects.Enabled = true;
                lbSearch.Visible = true;
                lbSearch.BringToFront();
                loadLbSeach();
            }
        }

        private void loadLbSeach()
        {
            bool checkInt = Int32.TryParse(searchBox.Text, out _);
            if (checkInt)
            {
                lbSearch.DataSource = cntStudentController.searchBoxUserTypeWithInt(Int32.Parse(searchBox.Text));
            }
            else
            {
                lbSearch.DataSource = cntStudentController.searchBoxUserTypeWithString(searchBox.Text);
            }
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            var student = lbSearch.SelectedItem;
            int modifiedCounter = 0;
            bool errorYear = false;

            foreach (DataGridViewRow modifiedRow in dgvSubjects.Rows)
            {
                if (student != null)
                {
                    string? yearOfEnrollment = Convert.ToString(modifiedRow.Cells[3].Value);
                    bool presential = (bool)modifiedRow.Cells[4].Value;
                    bool approved = (bool)modifiedRow.Cells[5].Value;

                    if (!string.IsNullOrEmpty(yearOfEnrollment))
                    {
                        int enrollmentYear = isValidEnrollmentYear(yearOfEnrollment);

                        if (enrollmentYear != -1)
                        {
                            cntSubjectEnrolment.enrolToSubject(
                            student,
                            modifiedRow.Cells[2].Value,
                            enrollmentYear,
                            presential,
                            approved
                            );

                            actualizarTabla(modifiedRow);
                            modifiedCounter++;
                        }
                        else { errorYear = true; }
                    }
                }
            }

            if (errorYear)
            {
                new MessageBoxDarkMode("Asegúrese de ingresar un año de matriculación válido para las materia modificadas.", "Advertencia", "Ok", Resources.advertencia, true);
            }

            AddSubjectsEnrolsToDgvSubjects();
            if (modifiedCounter > 0)
                new MessageBoxDarkMode("Datos actualizados correctamente", "Aviso", "Ok", Resources.Done, true);
        }


        private int isValidEnrollmentYear(string year)
        {
            int validYear = -1;

            if (!string.IsNullOrEmpty(year) && year.All(char.IsDigit) && int.TryParse(year, out validYear))
            {
                return validYear;
            }
            return validYear;
        }

        private void actualizarTabla(DataGridViewRow modifiedRow)
        {
            if (!modifiedRows.Contains(modifiedRow))
            {
                modifiedRows.Add(modifiedRow);
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lbSearch.Focus();
            }
        }

        private void lbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dgvSubjects.Rows.Clear();
            int index = this.lbSearch.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                txtStudent.Text = cntStudentController.getUserTypeFullName(lbSearch.SelectedItem);
                int dni = cntStudentController.getUserTypeDNI(lbSearch.SelectedItem);
                txtStudentDni.Text = $"{dni}";
                getStudentCareerInfo(dni);
                //AddSubjectsEnrolsToDgvSubjects();
            }
            lbSearch.Visible = false;

        }

        private void AddSubjectsEnrolsToDgvSubjects()
        {
            dgvSubjects.Rows.Clear();
            var career = cbbCareer.SelectedItem;
            if (career != null && txtStudentDni.Text != "") //subject.YearInCareer
            {
                var ListSubjects = cntSubjectEnrolment.availableEnrolments(Convert.ToInt32(txtStudentDni.Text), career);
                foreach (var subject in ListSubjects) //SubjectEnrolment
                {
                    dgvSubjects.Rows.Add(subject.Id, subject.YearInCareer, subject, "", false, false);
                }
            }
        }

        private void getStudentCareerInfo(int dni)
        {
            cbbCareer.Items.Clear();
            dgvSubjects.Rows.Clear();
            var ListCareer = cntCareerEnrolment.searchCareerEnrolments(dni);

            if (ListCareer.Count > 0)
            {
                cbbCareer.ValueMember = "Id";
                cbbCareer.DisplayMember = "Name";
                foreach(var career in ListCareer)
                {
                    cbbCareer.Items.Add(career);
                }

                cbbCareer.SelectedIndex = 0;
            }
            else
            {
                new MessageBoxDarkMode("El estudiante no esta inscripto en ninguna carrera", "Error", "Ok", Resources.BigErrorIcon, true);
                searchBox.Clear();
                txtStudent.Clear();
                txtStudentDni.Clear();
            }
        }

        private void CheckBoxVerification(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 5)
                {
                    if (dgvSubjects.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dgvSubjects.Rows[e.RowIndex].Cells[4].Value = true;

                    }
                }
                else if (e.ColumnIndex == 4)
                {
                    if (dgvSubjects.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dgvSubjects.Rows[e.RowIndex].Cells[5].Value = false;

                    }
                }
            }
        }

        private void cbbCareer_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddSubjectsEnrolsToDgvSubjects();
        }

        private void dgvSubjects_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count > 0 && columnIndexDragDomain.Any(x => x == dgvSubjects.SelectedCells[0].ColumnIndex))
            {
                if (e.Button == MouseButtons.Left)
                {
                    var hitTestInfo = dgvSubjects.HitTest(e.X, e.Y);
                    if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                    {
                        isDragging = true;
                        dgvSubjects.CurrentCell = dgvSubjects[hitTestInfo.ColumnIndex, hitTestInfo.RowIndex];
                        initialCellValue = dgvSubjects.CurrentCell.Value;
                        initialColumnIndex = hitTestInfo.ColumnIndex; // Save the initial column index if needed
                        dgvSubjects.BeginEdit(false);
                    }
                }
            }
        }


        private void dgvSubjects_MouseUp(object sender, MouseEventArgs e)
        {
            if (initialCellValue != null && isDragging)
            {
                isDragging = false;
                foreach (DataGridViewCell selectedCell in dgvSubjects.SelectedCells)
                {
                    if (initialColumnIndex == -1 || selectedCell.ColumnIndex == initialColumnIndex)
                    {
                        selectedCell.Value = initialCellValue;
                    }
                }
                dgvSubjects.EndEdit();
            }
        }

       
    }
}
