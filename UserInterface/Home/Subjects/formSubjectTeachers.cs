using Gestin.Controllers;
using Gestin.UI.EventHandlers;

namespace Gestin.UI.Home.Subjects
{
    public partial class formSubjectTeachers : Form
    {
        public event EventHandler<ResponseEventHandler> updateParentEvent;
        formSubject parentFormSubject;
        careerController careerController = careerController.getInstance();
        teacherController teacherController = teacherController.getInstance();
        subjectController subjectController = subjectController.getInstance();
        teacherSubjectController teacherSubjectController = teacherSubjectController.getInstance();
        object receivedSubject;
        object selectedTeacherCharge;

        public formSubjectTeachers(object sentSubject, formSubject receivedFormSubject)
        {
            parentFormSubject = receivedFormSubject;
            receivedSubject = sentSubject;
            InitializeComponent();
        }

        private void formSubjectTeachers_Load(object sender, EventArgs e)
        {
            ListboxSearchResults.Visible = false;
            refreshTableTeachersSubject();
            refreshLableSubjectName();
        }

        private void formSubjectTeachers_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateParentEvent.Invoke(this, new ResponseEventHandler(true));
            parentFormSubject.Show();
        }

        private void refreshTableTeachersSubject()
        {
            try
            {
                if (!chkInactive.Checked)
                {
                    bindingSourceTeachersSubject.DataSource = teacherSubjectController.getTeachersFromSubject(receivedSubject);
                }
                else
                {
                    bindingSourceTeachersSubject.DataSource = teacherSubjectController.getAllTeachersFromSubject(receivedSubject);
                }
                bindingSourceTeachersSubject.ResetBindings(true);
                dataGridViewTeachers.DataSource = bindingSourceTeachersSubject;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void refreshLableSubjectName()
        {
            try
            {
                lblmateriaName.Text = $"{subjectController.getSubjectName(receivedSubject)}";
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        public void refreshLableTeacherName()
        {
            try
            {
                if (dataGridViewTeachers.Rows.Count > 0 && dataGridViewTeachers.SelectedRows != null)
                {
                    object teacher = dataGridViewTeachers.CurrentRow.Cells[1].Value;
                    lblteachername.Text = teacher.ToString();
                }

            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        public void refreshLableTeacherName(string? teachername)
        {
            try
            {
                lblteachername.Text = teachername;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListboxSearchResults.SelectedItem != null && verifyCondition())
                {
                    if (teacherSubjectController.assignTeacherCharge(ListboxSearchResults.SelectedItem, receivedSubject, cmbCondition.GetItemText(cmbCondition.SelectedItem)))
                    {
                        refreshTableTeachersSubject();
                        clearAll();
                    }
                }
                else
                {
                    toolTip.Show("", ListboxSearchResults, 1);
                    toolTip.Show("Seleccione un usuario!", ListboxSearchResults, 3000);
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private bool verifyCondition()
        {
            if (string.IsNullOrEmpty(cmbCondition.GetItemText(cmbCondition.SelectedItem)))
            {
                toolTip.Show("", cmbCondition, 1);
                toolTip.Show("Agregar Condición!", cmbCondition, 3000);
                return false;
            }
            return true;
        }

        private void btnModifyDates_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTeacherCharge != null)
                {
                    teacherSubjectController.changeChargeDates(selectedTeacherCharge, dateTimePickerSince.Value.Date, dateTimePickerUntil.Value.Date);
                    refreshTableTeachersSubject();
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void btnDeactivateTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTeachers.Rows.Count > 0 && dataGridViewTeachers.SelectedRows != null)
                {
                    string? condition = Convert.ToString(dataGridViewTeachers.CurrentRow.Cells[1].Value);
                    if (condition != null)
                    {
                        int selectedTeacherID = Convert.ToInt32(dataGridViewTeachers.CurrentRow.Cells[0].Value);
                        teacherSubjectController.deactivateTeacherCharge(selectedTeacherID, condition);
                        refreshTableTeachersSubject();
                        clearAll();
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void loadSearchResults()
        {
            bool checkState = Int32.TryParse(txtSearchbar.Text, out _);
            if (checkState)
            {
                ListboxSearchResults.DataSource = teacherController.searchBoxUserTypeWithInt(Int32.Parse(txtSearchbar.Text));
            }
            else
            {
                ListboxSearchResults.DataSource = teacherController.searchBoxUserTypeWithString(txtSearchbar.Text);
            }
        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchbar.Text.Length == 0)
            {
                ListboxSearchResults.Visible = false;
            }
            else
            {
                ListboxSearchResults.Visible = true;
                loadSearchResults();
            }
        }

        private void txtSearchbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                ListboxSearchResults.Focus();
            }
        }

        private void ListboxSearchResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && ListboxSearchResults.SelectedIndex <= 0)
            {
                ListboxSearchResults.ClearSelected();
                txtSearchbar.Focus();
            }
            if (e.KeyCode == Keys.Enter && ListboxSearchResults.SelectedIndex >= 0)
            {
                object? selectedTeacher = teacherController.getUserType(ListboxSearchResults.SelectedItem);
                updateSelectedTeacher(selectedTeacher);
            }
        }

        private void ListboxSearchResults_Click(object sender, EventArgs e)
        {
            try
            {
                object? selectedTeacher = teacherController.getUserType(ListboxSearchResults.SelectedItem);
                updateSelectedTeacher(selectedTeacher);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void updateSelectedTeacher(object? teacher)
        {   
            if (teacher != null)
            {
                refreshLableTeacherName(teacher.ToString());
                cmbCondition.SelectedIndex = -1;
                btnInsert.Enabled = true;
                cmbCondition.Focus();
            }
        }

        private void clearAll()
        {
            txtSearchbar.ResetText();
            lblteachername.Text = "";
            cmbCondition.SelectedIndex = -1;
            dateTimePickerSince.ResetText();
            dateTimePickerUntil.ResetText();
        }

        private void chkInactive_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkInactive.Checked)
            {
                bindingSourceTeachersSubject.DataSource = teacherSubjectController.getAllTeachersFromSubject(receivedSubject);
                dataGridViewTeachers.DataSource = bindingSourceTeachersSubject;
            }
            else
            {
                bindingSourceTeachersSubject.DataSource = teacherSubjectController.getTeachersFromSubject(receivedSubject);
                dataGridViewTeachers.DataSource = bindingSourceTeachersSubject;
            }
        }

        private void dataGridViewTeachers_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow? currentRow = dataGridViewTeachers.CurrentRow;

            if (currentRow != null)
            {
                selectedTeacherCharge = teacherSubjectController.findTeacherCharge(Convert.ToInt32(currentRow.Cells[0].Value));
                lblteachername.Text = Convert.ToString(Convert.ToString(currentRow.Cells[1].Value));
                cmbCondition.Text = Convert.ToString(Convert.ToString(currentRow.Cells[2].Value));
                dateTimePickerSince.Text = Convert.ToString(Convert.ToString(currentRow.Cells[4].Value));
                dateTimePickerUntil.Text = Convert.ToString(Convert.ToString(currentRow.Cells[5].Value));
            }
        }

        private void dataGridViewTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3 && e.RowIndex >= 0) // Verifica si la columna es la de 'Activo'
                {
                    bool status = Convert.ToBoolean(dataGridViewTeachers.CurrentRow.Cells["Active"].Value);

                    if (!status) // Si el docente está inactivo
                    {
                        MessageBox.Show(
                            "No se puede activar docentes ya inactivos.",
                            "Error de Activación", // Título del mensaje
                            MessageBoxButtons.OK,   // Solo el botón "OK"
                            MessageBoxIcon.Error   // Icono de error
                        );
                    }
                    else // Si el docente está activo, procede con la desactivación
                    {
                        teacherSubjectController.deactivateTeacherCharge(selectedTeacherCharge);
                    }

                    refreshTableTeachersSubject(); // Actualiza la tabla
                }
            }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message); }
        }
    }
}
