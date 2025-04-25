using Gestin.Controllers;
using Gestin.LocalFiles;
using Gestin.Model;
using Gestin.Properties;
using Gestin.Reports;
using Gestin.UI.Commons;
using Gestin.UI.Custom;
using Gestin.UI.Home.ExamEnrolment;
using Gestin.Validators;
using System.IO;
using System.IO.Compression;

namespace Gestin.UI.Home.Exams
{
    public partial class formExams : Form
    {
#pragma warning disable CS4014 //remove aync warnings
        careerController cntCar = careerController.getInstance();
        subjectEnrolmentController cntSub = subjectEnrolmentController.getInstance();
        examController cntExam = examController.getInstance();
        examEnrolmentController cntExamEnrol = examEnrolmentController.getInstance();
        studentController cntStudent = studentController.getInstance();
        teacherController cntTeacher = teacherController.getInstance();
        subjectController cntSubject = subjectController.getInstance();
        int selectedStudentId = -1;
        string? selectedCareerText;
        bool careersLoaded = false; //prevents the careerSelectionChanged event from firing until the cbb has loaded

        public formExams()
        {
            InitializeComponent();
            dtSearchDate.Value = DateTime.Now;
            btnUnrol.Visible = false;
            btnUpdateExam.Enabled = false;
        }

        private void formExams_Load(object sender, EventArgs e)
        {
            cbbCareer.DataSource = cntCar.loadCareersActive();
            load_cbbToFilterExamsByCareer();
            loadAllExams();
        }

        public void loadAllExams()
        {
            dgvExams.Rows.Clear();
            foreach (object Exam in cntExam.loadExams())
            {
                loadExamDataTable(Exam);
            }
        }

        private void loadExamDataTable(object ex)
        {
            List<dynamic> loadExamData = cntExam.loadExamDataForTable(ex);

            dgvExams.Rows.Add();
            DataGridViewRow createdRow = dgvExams.Rows[dgvExams.Rows.Count - 1];

            for (int j = 0; j < dgvExams.Columns.Count; j++)
            {
                createdRow.Cells[j].Value = loadExamData[j];
            }
        }


        private void loadExamsByDate(DateTime date)
        {
            dgvExams.Rows.Clear();
            foreach (object exam in cntExam.obtainExamBySearchDate(date))
            {
                loadExamDataTable(exam);
            }
        }

        private void loadExamBySpecific(object exam)
        {
            dgvExams.Rows.Clear();
            loadExamDataTable(exam);
        }

        private void loadExamsByStudent(object student)
        {
            List<dynamic> studentExamEnrolments = new(cntExamEnrol.obtainTheExamsToWhichAStudentRegisters(student));
            foreach (object exam in studentExamEnrolments)
            {
                //examEnrolment's Exam doesn't have inner properties, as a result the database needs to be requeryed
                loadExamDataTable(cntExam.findExam(exam));
            }
        }

        private void btnNewExam_Click(object sender, EventArgs e)
        {
            lblMode.Text = "Crear nuevo examen";
            changeButtonsState();
            changeShowLabelState();
            changeNewExamState();
            btnSave.Visible = true;
            btnSaveUpdate.Visible = false;
        }
        private void changeNewExamState()
        {
            if (gbNewExam.BackColor == Color.FromArgb(54, 57, 63)) gbNewExam.BackColor = Color.FromArgb(84, 87, 93);
            else gbNewExam.BackColor = Color.FromArgb(54, 57, 63);
            dtDate.Value = DateTime.Now;
            cbbCareer.Visible = !cbbCareer.Visible;
            cbbSubject.Visible = !cbbSubject.Visible;
            cbb1Vowel.Visible = !cbb1Vowel.Visible;
            cbb2Vowel.Visible = !cbb2Vowel.Visible;
            cbb3Vowel.Visible = !cbb3Vowel.Visible;
            cbbTitular.Visible = !cbbTitular.Visible;
            txtPlace.Visible = !txtPlace.Visible;
            dtDate.Visible = !dtDate.Visible;
            dtTime.Visible = !dtTime.Visible;
            btnCancel.Enabled = !btnCancel.Visible;
            lblMode.Visible = !lblMode.Visible;
            btnCancel.Visible = !btnCancel.Visible;
        }
        private void changeShowLabelState()
        {
            lblShowCareer.Visible = !lblShowCareer.Visible;
            lblShowDate.Visible = !lblShowDate.Visible;
            lblShowFirst.Visible = !lblShowFirst.Visible;
            lblShowPlace.Visible = !lblShowPlace.Visible;
            lblShowSec.Visible = !lblShowSec.Visible;
            lblShowSubject.Visible = !lblShowSubject.Visible;
            lblShowThird.Visible = !lblShowThird.Visible;
            lblShowTime.Visible = !lblShowTime.Visible;
            lblShowTit.Visible = !lblShowTit.Visible;
        }
        private void clearAll()
        {
            lblShowCareer.Text = string.Empty;
            lblShowPlace.Text = string.Empty;
            lblShowSec.Text = string.Empty;
            lblShowSubject.Text = string.Empty;
            lblShowTime.Text = string.Empty;
            lblShowTit.Text = string.Empty;
            lblShowFirst.Text = string.Empty;
            lblShowDate.Text = string.Empty;
            lblShowThird.Text = string.Empty;
        }

        private void clearExamForm()
        {
            cbbCareer.SelectedIndex = 0;
            cbbSubject.SelectedIndex = -1;
            cbb1Vowel.SelectedIndex = -1;
            cbb2Vowel.SelectedIndex = -1;
            cbb3Vowel.SelectedIndex = -1;
            cbbTitular.SelectedIndex = -1;
            txtPlace.Text = "";
        }

        private (bool, string) verifyNewExamInfo()
        {
            string msg = "Cargado";
            bool loaded = true;
            if (cbbSubject.SelectedItem == null)
            {
                msg = "Error, elija una materia";
                loaded = false;
            }
            else if (!dtDate.Checked)
            {
                msg = "Error, elija una fecha";
                loaded = false;
            }
            return (loaded, msg);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var state = verifyNewExamInfo();
            if (!state.Item1) showError(state.Item2, state.Item1);
            else
            {
                DateTime examDateTime = DateTime.Parse(dtDate.Value.ToString("yyyy-MM-dd") + " " + dtTime.Value.ToString("HH:mm:00"));

                if (!cntExam.examExistsSameDateTime(cbbSubject.SelectedItem, examDateTime))
                {

                    if (cntExam.createExam(
                        cbbSubject.SelectedItem,
                        teacherSelection(cbbTitular),
                        teacherSelection(cbb1Vowel),
                        teacherSelection(cbb2Vowel),
                        teacherSelection(cbb3Vowel),
                        examDateTime,
                        txtPlace.Text
                        ))
                    {
                        showError("Creado correctamente", true);
                        loadAllExams();
                        clearExamForm();
                        changeStates();
                        changeButtonsState();
                        btnSave.Visible = false;
                    }
                }
                else
                {
                    ToolTip toolTip = new ToolTip();
                    toolTip.IsBalloon = true;
                    toolTip.Show("", dtTime, 1);
                    toolTip.Show("Un examen no puede tener el mismo horario a un examen de tal materia ya existente!", dtTime, 3000);
                }
            }
        }

        private void cbbCareer_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbSubject.Items.Clear();

            if (cbbCareer.SelectedItem != null)
            {
                var list = cntCar.loadSubjectsFromCareer(cbbCareer.SelectedItem);
                foreach (object subject in list)
                {
                    cbbSubject.Items.Add(subject);
                }
                loadTeachersCbb();
            }
        }

        private void loadTeachersCbb()
        {
            var list = cntTeacher.loadUserTypesExceptDeleted();
            List<ComboBox> listCbb = new() { cbbTitular, cbb1Vowel, cbb2Vowel, cbb3Vowel };

            foreach (ComboBox cbb in listCbb)
            {
                cbb.Items.Clear();
                cbb.Items.Add("--Vacio--");

                foreach (object teacher in list)
                {
                    cbb.Items.Add(teacher);
                }
            }
        }

        private object? teacherSelection(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null) return null;
            else return comboBox.SelectedItem;
        }

        private async Task showError(string msg, bool success)
        {
            if (!success)
            {
                lblError.ForeColor = Color.IndianRed;
                lblError.Image = Resources.ErrorSmall;
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

        private void changeButtonsState()
        {
            btnNewExam.Visible = !btnNewExam.Visible;
            btnUpdateExam.Visible = !btnUpdateExam.Visible;
            btnDeleteExam.Visible = !btnDeleteExam.Visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            changeStates();
            changeButtonsState();
            clearExamForm();
            btnSave.Visible = false;
            btnSaveUpdate.Visible = false;
        }

        private void btnUpdateExam_Click(object sender, EventArgs e)
        {
            if (generalValidator.checkIfThereAreRecordsInDataGrid("examen", dgvExams))
            {
                setBtnDetails();
            }
        }
        private void setBtnDetails()
        {
            lblMode.Text = "Actualizar examen existente";
            changeButtonsState();
            changeStates();
            loadEditExam();
            btnSaveUpdate.Visible = true;
            btnSave.Visible = false;
        }

        private void changeStates()
        {
            changeShowLabelState();
            changeNewExamState();
        }

        private void addExamInfoToLbl(int examCode)
        {
            object? exam = cntExam.findExam(examCode);

            if (exam != null)
            {
                List<string> examData = cntExam.loadExamData(exam);

                lblShowCareer.Text = examData[0];
                lblShowDate.Text = examData[1];
                lblShowTime.Text = examData[2];
                lblShowPlace.Text = examData[3];
                lblShowSubject.Text = examData[4];
                lblShowFirst.Text = examData[5];
                lblShowSec.Text = examData[6];
                lblShowThird.Text = examData[7];
                lblShowTit.Text = examData[8];
            }
        }

        private void dgvExams_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Delete)
            {
                unsubscribeOneOrManyExams();
            }
        }

        private void dgvExams_SelectionChanged(object sender, EventArgs e)
        {
            if (careersLoaded && dgvExams.SelectedRows != null && dgvExams.CurrentCell != null)
            {
                if (dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0] != null)
                {
                    int idExam = Convert.ToInt32(dgvExams.CurrentRow.Cells[0].Value);
                    addExamInfoToLbl(idExam);
                    btnUpdateExam.Enabled = true;
                }
            }
        }
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var state = verifyNewExamInfo();
                if (!state.Item1) showError(state.Item2, state.Item1);
                else
                {
                    DateTime examDateTime = DateTime.Parse(dtDate.Value.ToString("yyyy-MM-dd") + " " + dtTime.Value.ToString("HH:mm:00"));
                    if (!cntExam.examExistsSameDateTimeExceptSame(Int32.Parse(lblExamCode.Text), cbbSubject.SelectedItem, examDateTime))
                    {
                        if (cntExam.updateExam(Int32.Parse(lblExamCode.Text),
                                                cbbSubject.SelectedItem,
                                                teacherSelection(cbbTitular),
                                                teacherSelection(cbb1Vowel),
                                                teacherSelection(cbb2Vowel),
                                                teacherSelection(cbb3Vowel),
                                                examDateTime,
                                                txtPlace.Text
                                                ))
                        {
                            showError("Actualizado correctamente", true);
                            loadAllExams();

                            clearExamForm();
                            changeStates();
                            changeButtonsState();
                            btnSaveUpdate.Visible = false;
                        }
                    }
                    else
                    {
                        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
                        toolTip.IsBalloon = true;
                        toolTip.Show("", dtTime, 1);
                        toolTip.Show("Un examen no puede tener el mismo horario a un examen de tal materia ya existente!", dtTime, 3000);
                    }
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message, false);
            }

        }
        private void loadEditExam()
        {
            // Asignar valores iniciales a los controles
            lblExamCode.Text = dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0].Value.ToString();
            cbbCareer.SelectedIndex = cbbCareer.FindString(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[1].Value.ToString());
            cbbSubject.SelectedIndex = cbbSubject.FindString(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[3].Value.ToString());

            // Intentar obtener los profesores del examen seleccionado
            var ex = cntExam.getExamTeachers(Convert.ToInt32(dgvExams.Rows[dgvExams.SelectedRows[0].Index].Cells[0].Value));

            // Si se recupera un examen, asignar los valores de los profesores y lugar
            if (ex != null)
            {
                cbbTitular.SelectedIndex = getTeacherIndexInCbb(ex.Titular, cbbTitular);
                cbb1Vowel.SelectedIndex = getTeacherIndexInCbb(ex.FirstVowel, cbb1Vowel);
                cbb2Vowel.SelectedIndex = getTeacherIndexInCbb(ex.SecondVowel, cbb2Vowel);
                cbb3Vowel.SelectedIndex = getTeacherIndexInCbb(ex.ThirdVowel, cbb3Vowel);
                txtPlace.Text = ex.Place;
            }

            // Convertir y asignar la fecha y hora del examen
            string? date = Convert.ToString(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[4].Value);
            DateTime dateTime = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm", LocalGestinSettings.LocalLanguage);

            dtDate.Value = dateTime.Date;
            dtTime.Text = Convert.ToString(dateTime.TimeOfDay);
        }

        int getTeacherIndexInCbb(int? teacherId, ComboBox cbb)
        {
            int result = 0;
            if (cbb.Items.Count > 1 && teacherId != null)
            {
                for (int i = 1; i < cbb.Items.Count; ++i)
                {
                    if (cntTeacher.getUserTypeId(cbb.Items[i]) == teacherId)
                        result = i;
                }
            }
            return result;
        }

        // Método que verifica si hay exámenes en el DataGridView
        private void CheckIfExamsExist()
        {
            btnDeleteExam.Enabled = dgvExams.Rows.Count > 0;
        }

        // Evento Load del formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            loadAllExams();
            CheckIfExamsExist();
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            if (dgvExams.CurrentCell == null)
            {
                showError("Seleccione un examen antes de intentar eliminarlo.", false);
                return;
            }

            if (Convert.ToInt32(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells["enrollments"].Value) > 0)
            {
                showError("No se pueden eliminar examenes con estudiantes inscriptos. Primero delos de baja", false);
            }
            else
            {
                MessageBoxDarkMode messageBox = new MessageBoxDarkMode("¿Esta seguro que desea eliminar este examen?", "Confirmar", "OkCancel", Resources.advertencia, true);
                if (generalValidator.messageBoxDialogResult(messageBox) == true)
                {
                    if (cntExam.deleteExam(Int32.Parse(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0].Value.ToString())))
                    {
                        dgvExams.Rows.RemoveAt(dgvExams.CurrentCell.RowIndex);
                    }
                }
            }
            loadAllExams();
            CheckIfExamsExist();
        }


        private void btnOptions_Click(object sender, EventArgs e)
        {
            panelMoreOptions.Visible = !panelMoreOptions.Visible;
        }

        private void btnGenerateExams_Click(object sender, EventArgs e)
        {
            formGenerateMultipleExams formGenerate = new formGenerateMultipleExams();
            formGenerate.ShowDialog();
            panelMoreOptions.Visible = !panelMoreOptions.Visible;
        }

        private void dgvExams_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvExams.Rows.Count > 0 && dgvExams.Rows[dgvExams.SelectedRows[0].Index].Cells[0] != null)
            {
                Helpers.OpenChildForm(
                    new formGradeFromExam(
                    Convert.ToInt32(dgvExams.Rows[dgvExams.SelectedRows[0].Index].Cells[0].Value), this), this.Parent);
            }
        }

        private void cbbSubject_SelectedValueChanged(object sender, EventArgs e)
        {
            selectTitularTeacher();
        }

        void selectTitularTeacher()
        {
            try
            {
                if (cbbSubject.SelectedItem != null)
                {
                    object? thisTitular = cntTeacher.getMostRecentActiveTeacher(cbbSubject.SelectedItem);

                    if (thisTitular != null)
                    {
                        string teacherName = cntTeacher.getUserTypeFullName(thisTitular);
                        cbbTitular.SelectedIndex = cbbTitular.FindString(teacherName);
                    }
                    else
                    {
                        cbbTitular.SelectedIndex = cbbTitular.FindString("--Vacio--");
                    }
                }
            }
            catch (Exception exception) { MessageBox.Show($"{exception}"); }

        }

        private void toggDate_CheckedChanged(object sender, EventArgs e)
        {
            if (toggDate.Checked)
            {
                toggDateCheck();
            }
            else
            {
                toggDateNotCheck();
            }
        }

        private void toggDateCheck()
        {
            lblActiveSearch.Text = "Fecha :";
            labelDate.Text = "por fecha";
            dtSearchDate.Enabled = true;
            txtSearchCode.Enabled = false;
            dtSearchDate.Visible = true;
            txtSearchCode.Visible = false;
        }

        private void toggDateNotCheck()
        {
            lblActiveSearch.Text = "Código :";
            labelDate.Text = "por código";
            dtSearchDate.Enabled = false;
            txtSearchCode.Enabled = true;
            dtSearchDate.Visible = false;
            txtSearchCode.Visible = true;
        }

        private void btnSearchExam_Click(object sender, EventArgs e)
        {
            try
            {
                updateExamListBySelectedCareer();

                if (!string.IsNullOrWhiteSpace(txtSearchCode.Text))
                {
                    int examCode;
                    if (int.TryParse(txtSearchCode.Text, out examCode))
                    {
                        var exam = cntExam.findExam(examCode);
                        if (exam == null)
                        {
                            throw new Exception($"No se encontraron exámenes con el código {examCode}.");
                        }
                        loadExamBySpecific(exam);
                    }
                    else
                    {
                        throw new FormatException("El código del examen debe ser un número.");
                    }
                }
                else if (!string.IsNullOrWhiteSpace(txtSearchSubject.Text))
                {
                    var exam = cntExam.findExam(txtSearchSubject.Text);
                    if (exam == null)
                    {
                        throw new Exception($"No se encontraron exámenes con el nombre de asignatura '{txtSearchSubject.Text}'.");
                    }
                    loadExamBySpecific(exam);
                }
                else if (toggDate.Checked)
                {
                    string reformattedDate = dtSearchDate.Value.ToString("dd/MM/yyyy", LocalGestinSettings.LocalLanguage);
                    DateTime parsedDate = DateTime.ParseExact(reformattedDate, "dd/MM/yyyy", LocalGestinSettings.LocalLanguage);

                    var examsByDate = cntExam.loadExamsByDate(parsedDate);
                    if (examsByDate == null || !examsByDate.Any())
                    {
                        throw new Exception($"No se encontraron exámenes para la fecha {reformattedDate}.");
                    }
                    loadExamsByDate(parsedDate);
                }
                else
                {
                    throw new Exception("Por favor, ingrese un código de examen, asignatura, o seleccione una fecha para buscar.");
                }
            }
            catch (Exception ex)
            {
                showError($"{ex.Message}", false);
            }
        }

        /*  private void btnGenerateActaVolante_Click(object sender, EventArgs e)
          {
             try
             {
                 if (dgvExams.CurrentCell == null || dgvExams.CurrentRow == null)
                 {
                     throw new Exception("Por favor, selecciona un examen de la lista.");
                 }

                 int examId = Convert.ToInt32(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0].Value);

                 GenerateUnofficialTranscript genActaVolante = new();
                 genActaVolante.getActaVolante(examId);

                 showError($"Acta volante generada para: {examId}", true);
             }

             catch (Exception ex)
             {
                 showError($"{ex.Message}", false);
             }
          }*/


        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchStudent.Text.Length == 0) { lbSearchByStudent.Visible = false; }
            else
            {
                lbSearchByStudent.Visible = true;
                lbSearchByStudent.BringToFront();
                loadLbSeach();
                btnEnable(btnUnrol, true);
            }
        }

        private void loadLbSeach()
        {
            bool checkInt = Int32.TryParse(txtSearchStudent.Text, out _);
            if (checkInt)
            {
                lbSearchByStudent.DataSource = cntStudent.searchBoxUserTypeWithInt(Int32.Parse(txtSearchStudent.Text));
            }
            else
            {
                lbSearchByStudent.DataSource = cntStudent.searchBoxUserTypeWithString(txtSearchStudent.Text);
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lbSearchByStudent.Focus();
            }
        }

        private void lbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && lbSearchByStudent.SelectedIndex <= 0)
            {
                lbSearchByStudent.ClearSelected();
                txtSearchStudent.Focus();
            }
            if (e.KeyCode == Keys.Enter && lbSearchByStudent.SelectedIndex >= 0)
            {
                searchStudent();
            }
        }

        private void searchStudent()
        {
            object? selectedStudent = lbSearchByStudent.SelectedItem;

            if (selectedStudent != null)
            {
                lblStudent.Text = cntStudent.getUserTypeFullName(selectedStudent);
                lblDni.Text = Convert.ToString(cntStudent.getUserTypeDNI(selectedStudent));
                loadExamsByStudent(selectedStudent);
                txtSearchStudent.Clear();

            }
        }

        private void enableDisableBtnUnRol()
        {
            if (dgvExams.RowCount > 0)
            { btnVisible(btnUnrol, true); }
            else { btnVisible(btnUnrol, false); }
        }

        private void toggSearchByStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (toggSearchByStudent.Checked)
            {
                toggSearchByStudentCheck();
            }
            else
            {
                toggSearchByStudentNotCheck();
            }
        }
        private void toggSearchByStudentCheck()
        {
            labelOpcionTodos.Text = "Especifico";
            btnVisible(btnUnrol, true);
            btnEnable(btnUnrol, false);
            txtSearchStudent.Enabled = true;
            dgvExams.Rows.Clear();
            lbSearchByStudent.Visible = false;
            lbSearchBySubject.Visible = false;
            btnVisible(btnDeleteExam, false);
        }
        private void toggSearchByStudentNotCheck()
        {
            labelOpcionTodos.Text = "Todos";
            btnVisible(btnUnrol, false);
            txtSearchStudent.Enabled = false;
            cleanDniAndNameLabels();
            loadAllExams();
            lbSearchByStudent.Visible = false;
            lbSearchBySubject.Visible = false;
            btnVisible(btnDeleteExam, true);
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
            searchStudent();
            enableDisableBtnUnRol();
        }

        private void btnVisible(Button btn, bool estado)
        {
            if (estado) { btn.Visible = true; }
            else { btn.Visible = false; }
        }
        private void btnEnable(Button btn, bool estado)
        {
            if (estado) { btn.Enabled = true; }
            else { btn.Enabled = false; }
        }

        private void btnUnrol_Click(object sender, EventArgs e)
        {
            if (dgvExams.RowCount > 0)
            {
                if (dgvExams.RowCount > 0)
                {
                    unsubscribeOneOrManyExams();
                }
                enableDisableBtnUnRol();
            }
        }

        private void unsubscribeOneOrManyExams()
        {
            object? student = lbSearchByStudent.SelectedItem;

            if (student != null)
            {
                int stdId = cntStudent.getUserTypeId(student);
                string stdName = cntStudent.getUserTypeFullName(student);

                foreach (DataGridViewRow selectedExam in dgvExams.SelectedRows)
                {
                    int examId = Convert.ToInt32(selectedExam.Cells[0].Value);
                    Exam? exam = cntExam.findExam(examId);

                    if (exam != null)
                    {
                        string examSubjectName = exam.IdSubjectNavigation.Name;

                        var result = formConfirmation.ShowDialog(this, "¿Esta seguro que desea desinscribir este estudiante?",
                            $"El estudiante {stdName} sera dado de baja del examen de {examSubjectName}");

                        if (result == DialogResult.Yes)
                        {
                            var status = cntExamEnrol.unrolStudent(stdId, exam);
                            if (status.Item1) dgvExams.Rows.RemoveAt(dgvExams.SelectedRows[0].Index);
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

        private void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchSubject.Text.Length == 0) { lbSearchBySubject.Visible = false; }
            else
            {
                lbSearchBySubject.Visible = true;
                lbSearchBySubject.BringToFront();
                loadLbSubject();
            }
        }

        private void loadLbSubject()
        {
            lbSearchBySubject.DataSource = cntSub.searchBoxSubjectWithString(txtSearchSubject.Text);

        }

        private void txtSearchSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lbSearchBySubject.Focus();
            }
        }

        private void lbSearchBySubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && lbSearchBySubject.SelectedIndex <= 0)
            {
                lbSearchBySubject.ClearSelected();
                lbSearchBySubject.Focus();
            }
            if (e.KeyCode == Keys.Enter && lbSearchBySubject.SelectedIndex >= 0)
            {
                searchSubject();
            }
        }

        void searchSubject()
        {
            object? subject = lbSearchBySubject.SelectedItem;

            if (subject != null)
            {
                string subjectName = cntSubject.getSubjectName(subject);
                loadDataGridWithExamsBySubject(subjectName);
                txtSearchSubject.Clear();
            }
        }

        private void cleanDniAndNameLabels()
        {
            lblDni.Text = "---------";
            lblStudent.Text = "---------";
        }

        private void toggSearchBySubject_CheckedChanged(object sender, EventArgs e)
        {
            if (toggSearchBySubject.Checked)
            {
                toggSearchBySubjectCheck();
            }
            else
            {
                toggSearchBySubjectNotCheck();
            }
        }
        private void toggSearchBySubjectCheck()
        {
            labelSearchSubject.Text = "Especifica";
            txtSearchSubject.Enabled = true;
            cleanDniAndNameLabels();
            dgvExams.Rows.Clear();
            lbSearchBySubject.Visible = false;
            lbSearchByStudent.Visible = false;
        }
        private void toggSearchBySubjectNotCheck()
        {
            labelSearchSubject.Text = "Todas";
            txtSearchSubject.Enabled = false;
            cleanDniAndNameLabels();
            loadAllExams();
            lbSearchBySubject.Visible = false;
            lbSearchByStudent.Visible = false;
        }

        private void lbSearchBySubject_Click(object sender, EventArgs e)
        {
            searchSubject();
        }

        private void updateExamListBySelectedCareer()
        {
            selectedCareerText = cbbToFilterExamsByCareer.Text;
            dgvExams.ClearSelection();

            if (selectedCareerText != string.Empty && selectedCareerText == "TODAS LAS CARRERAS")
                loadAllExams();
            else
                loadDataGridWithExamsByCareer(selectedCareerText);

            dgvExams_SelectionChanged(this, null); //force a recheck
        }

        private void cbbToFilterExamsByCareer_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateExamListBySelectedCareer();
        }

        private void loadDataGridWithExamsByCareer(string career)
        {
            dgvExams.Rows.Clear();
            cleanDniAndNameLabels();
            int count = 0;

            foreach (object e in cntExam.obtainTheExamsToWhichACareer(career))
            {
                loadExamDataTable(e);
                count++;
            }

            if (count == 0) { new MessageBoxDarkMode($"No se encontraron exámenes para {career} !!", "Error", "Ok", Resources.BigErrorIcon, true); clearAll(); }
        }

        private void loadDataGridWithExamsBySubject(string subject)
        {
            dgvExams.Rows.Clear();
            cleanDniAndNameLabels();
            int count = 0;

            foreach (object e in cntExam.obtainTheExamsToWhichASubject(subject))
            {
                loadExamDataTable(e);
                count++;
            }

            if (count == 0) { new MessageBoxDarkMode($"No se encontraron exámenes para {subject} !!", "Error", "Ok", Resources.BigErrorIcon, true); clearAll(); }
        }

        public void load_cbbToFilterExamsByCareer()
        {
            try
            {
                foreach (var career in cntCar.loadCareersActive())
                {
                    cbbToFilterExamsByCareer.Items.Add(career);
                }
                cbbToFilterExamsByCareer.Items.Add("TODAS LAS CARRERAS");
                cbbToFilterExamsByCareer.SelectedIndex = cbbToFilterExamsByCareer.Items.Count - 1;
            }
            catch (Exception) { throw; }

            finally { careersLoaded = true; }
        }


        //Solución provisoria al no poder generarse actas libre y presenciales al mismo tiempo. Esto debe refactorizarse.
        private void BtnGenerarActasPresencialesFecha_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que cntExam no sea null
                if (cntExam == null)
                {
                    throw new Exception("El objeto cntExam no está inicializado.");
                }

                // Obtener la fecha seleccionada por el usuario (desde un DateTimePicker)
                DateTime fechaSeleccionada = dtSearchDate.Value;

                // Obtener los exámenes para la fecha seleccionada
                List<Exam> listExam = cntExam.obtainExamBySearchDate(fechaSeleccionada);

                // Verificar que la lista de exámenes no sea null
                if (listExam == null || !listExam.Any())
                {
                    throw new Exception($"No se encontraron actas volantes para la fecha seleccionada ({fechaSeleccionada.ToString("dd/MM/yyyy")}).");
                }

                // Crear un diálogo para que el usuario seleccione la carpeta de destino
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione la carpeta donde desea guardar las actas volantes";

                    // Si el usuario selecciona una carpeta y presiona OK
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaGuardado = folderDialog.SelectedPath;

                        // Generar un nombre único para el archivo ZIP
                        string zipFileName = $"ActasVolantes_{fechaSeleccionada.ToString("yyyyMMdd")}.zip";
                        string zipFilePath = Path.Combine(rutaGuardado, zipFileName);

                        int fileIndex = 1;
                        while (File.Exists(zipFilePath))
                        {
                            zipFileName = $"ActasVolantes_{fechaSeleccionada.ToString("yyyyMMdd")}_{fileIndex}.zip";
                            zipFilePath = Path.Combine(rutaGuardado, zipFileName);
                            fileIndex++;
                        }

                        // Crear el archivo ZIP para almacenar las actas volantes
                        using (ZipArchive zip = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
                        {
                            // Verificar que el objeto GenerateUnofficialTranscript esté inicializado
                            GenerateUnofficialTranscript genActaVolante = new();

                            // Generar y guardar cada acta volante
                            foreach (Exam exam in listExam)
                            {
                                if (exam == null)
                                {
                                    throw new Exception("El objeto exam no está inicializado.");
                                }

                                byte[] actaVolante = genActaVolante.getActaVolantePresential(exam.Id);

                                if (actaVolante != null && actaVolante.Length > 0)
                                {
                                    // Definir el nombre del archivo, basado en el ID del examen y la fecha seleccionada
                                    string nombreArchivo = $"ActaVolante_{exam.SubjectEnrolmentName()}_{fechaSeleccionada.ToString("yyyyMMdd")}.pdf";

                                    // Añadir el archivo al ZIP
                                    ZipArchiveEntry entry = zip.CreateEntry(nombreArchivo);
                                    using (var entryStream = entry.Open())
                                    {
                                        entryStream.Write(actaVolante, 0, actaVolante.Length);
                                    }
                                }
                                else
                                {
                                    // Manejar el caso en que no se pudo generar el PDF
                                    showError($"No se pudo generar el acta volante para el examen ID {exam.Id}.", false);
                                }
                            }
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show($"Las actas volantes se han descargado exitosamente en '{zipFilePath}'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                showError($"{ex.Message}", false);
            }
        }

        private void BtnGenerarActasLibresFecha_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que cntExam no sea null
                if (cntExam == null)
                {
                    throw new Exception("El objeto cntExam no está inicializado.");
                }

                // Obtener la fecha seleccionada por el usuario (desde un DateTimePicker)
                DateTime fechaSeleccionada = dtSearchDate.Value;

                // Obtener los exámenes para la fecha seleccionada
                List<Exam> listExam = cntExam.obtainExamBySearchDate(fechaSeleccionada);

                // Verificar que la lista de exámenes no sea null
                if (listExam == null || !listExam.Any())
                {
                    throw new Exception($"No se encontraron actas volantes para la fecha seleccionada ({fechaSeleccionada.ToString("dd/MM/yyyy")}).");
                }

                // Crear un diálogo para que el usuario seleccione la carpeta de destino
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione la carpeta donde desea guardar las actas volantes";

                    // Si el usuario selecciona una carpeta y presiona OK
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaGuardado = folderDialog.SelectedPath;

                        // Generar un nombre único para el archivo ZIP
                        string zipFileName = $"ActasVolantes_{fechaSeleccionada.ToString("dd-MM-yyyy")}.zip";
                        string zipFilePath = Path.Combine(rutaGuardado, zipFileName);

                        int fileIndex = 1;
                        while (File.Exists(zipFilePath))
                        {
                            zipFileName = $"ActasVolantes {fechaSeleccionada.ToString("dd-MM-yyyy")} - {fileIndex}.zip";
                            zipFilePath = Path.Combine(rutaGuardado, zipFileName);
                            fileIndex++;
                        }

                        // Crear el archivo ZIP para almacenar las actas volantes
                        using (ZipArchive zip = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
                        {
                            // Verificar que el objeto GenerateUnofficialTranscript esté inicializado
                            GenerateUnofficialTranscript genActaVolante = new();

                            // Generar y guardar cada acta volante
                            foreach (Exam exam in listExam)
                            {
                                if (exam == null)
                                {
                                    throw new Exception("El objeto exam no está inicializado.");
                                }

                                byte[] actaVolante = genActaVolante.getActaVolanteFree(exam.Id);

                                if (actaVolante != null && actaVolante.Length > 0)
                                {
                                    // Definir el nombre del archivo, basado en el ID del examen y la fecha seleccionada
                                    string nombreArchivo = $"ActaVolante {exam.SubjectEnrolmentName()} {fechaSeleccionada.ToString("dd-MM-yyyy")}.pdf";

                                    // Añadir el archivo al ZIP
                                    ZipArchiveEntry entry = zip.CreateEntry(nombreArchivo);
                                    using (var entryStream = entry.Open())
                                    {
                                        entryStream.Write(actaVolante, 0, actaVolante.Length);
                                    }
                                }
                                else
                                {
                                    // Manejar el caso en que no se pudo generar el PDF
                                    showError($"No se pudo generar el acta volante para el examen ID {exam.Id}.", false);
                                }
                            }
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show($"Las actas volantes se han descargado exitosamente en '{zipFilePath}'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                showError($"{ex.Message}", false);
            }
        }

        private void btnGenerateActaVolanteLibre_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvExams.CurrentCell == null || dgvExams.CurrentRow == null)
                {
                    throw new Exception("Por favor, selecciona un examen de la lista.");
                }

                // Obtener el ID del examen seleccionado en el DataGridView
                int examId = Convert.ToInt32(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0].Value);

                // Crear una instancia de la clase GenerateUnofficialTranscript
                GenerateUnofficialTranscript genActaVolante = new();

                // Generar el acta volante como un array de bytes
                byte[] actaVolante = genActaVolante.getActaVolanteFree(examId);

                if (actaVolante == null || actaVolante.Length == 0)
                {
                    throw new Exception($"No se pudo generar el acta volante para el examen ID {examId}.");
                }

                // Crear un diálogo para guardar el archivo
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Title = "Guardar Acta Volante";
                    saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveDialog.FileName = $"ActaVolante_{examId}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el archivo PDF en la ruta seleccionada
                        File.WriteAllBytes(saveDialog.FileName, actaVolante);
                        showError($"Acta volante generada y guardada correctamente en: {saveDialog.FileName}", true);
                    }
                    else
                    {
                        showError("El guardado del archivo fue cancelado por el usuario.", false);
                    }
                }
            }
            catch (Exception ex)
            {
                showError($"{ex.Message}", false);
            }
        }

        private void btnGenerateActaVolante_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvExams.CurrentCell == null || dgvExams.CurrentRow == null)
                {
                    throw new Exception("Por favor, selecciona un examen de la lista.");
                }

                // Obtener el ID del examen seleccionado en el DataGridView
                int examId = Convert.ToInt32(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0].Value);

                // Crear una instancia de la clase GenerateUnofficialTranscript
                GenerateUnofficialTranscript genActaVolante = new();

                // Generar el acta volante como un array de bytes
                byte[] actaVolante = genActaVolante.getActaVolantePresential(examId);

                if (actaVolante == null || actaVolante.Length == 0)
                {
                    throw new Exception($"No se pudo generar el acta volante para el examen ID {examId}.");
                }

                // Crear un diálogo para guardar el archivo
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Title = "Guardar Acta Volante";
                    saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveDialog.FileName = $"ActaVolante_{examId}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el archivo PDF en la ruta seleccionada
                        File.WriteAllBytes(saveDialog.FileName, actaVolante);
                        showError($"Acta volante generada y guardada correctamente en: {saveDialog.FileName}", true);
                    }
                    else
                    {
                        showError("El guardado del archivo fue cancelado por el usuario.", false);
                    }
                }
            }
            catch (Exception ex)
            {
                showError($"{ex.Message}", false);
            }
        }

        //Fin Solución provisoria /////////////////////////////////////////////////////////////////////////////////.
    }
}
