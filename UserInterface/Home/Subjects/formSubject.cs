using System.Data;
using Gestin.Controllers;
using Gestin.UI.EventHandlers;
using Gestin.UserInterface.Custom;
using Gestin.UserInterface.Home.Assistance;
using Gestin.Validators;

namespace Gestin.UI.Home.Subjects
{
    public partial class formSubject : Form
    {
#pragma warning disable CS4014 //remove aync warnings
        PictureBoxLoading pictureBoxLoading;
        careerController careerController = careerController.getInstance();
        subjectController subjectController = subjectController.getInstance();
        correlativeController correlativeController = correlativeController.getInstance();
        teacherSubjectController teacherSubjectController = teacherSubjectController.getInstance();
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private Task<List<dynamic>> dataRetrievalTask;
        List<dynamic> listCareerSubjects;
        dynamic? selectedCareer;
        dynamic? selectedSubject;
        bool directionColumn;

        public formSubject()
        {
            InitializeComponent();
        }

        private async void formSubject_Load(object sender, EventArgs e)
        {
            if (nullCheckCareers()) { await loadDataAsync(); }
        }

        private void newCancellationTokenSource()
        {
            if (cancellationTokenSource != null)
                cancellationTokenSource.Dispose();

            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
        }

        private async Task loadDataAsync()
        {
            newCancellationTokenSource();

            try
            {
                await Task.Run(async () =>
                {
                    Action action = () =>
                    {
                        pictureBoxLoading = new PictureBoxLoading(this);
                    };

                    if (!cancellationTokenSource.IsCancellationRequested)
                    {
                        Invoke(action);
                        await refreshCareers();
                    }
                });
                pictureBoxLoading.destroyLoadingPictureBox();
            }
            catch { } //sometimes the thread is destroyed before it finishes executing
        }

        private bool nullCheckCareers()
        {
            return careerController.countCareers() > 0;
        }

        private void dataGridViewSubjects_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.CurrentRow != null)
            {
                inputFormSubjectData();
            }
        }

        private async void inputFormSubjectData()
        {
            selectedSubject = setGlobalSubject();
            refreshLabelSubjectName();
            fillFormFields();
            await loadSubjectDependencies();
        }


        private async Task nullCheckCareerSubjectCount()
        {
            await refreshTableSubjects();
        }

        private async Task loadSubjectDependencies()
        {
            if (checkSelectedCareerSubjects())
            {
                await refreshTableCorrelatives();
                await refreshTableTeachers();
            }
            else
            {
                teacherSubjectBindingSource.DataSource = null;
                correlativeBindingSource.DataSource = null;
            }
        }

        private bool checkSelectedCareerSubjects()
        {
            return selectedCareer != null && careerController.loadSubjectsFromCareer(selectedCareer).Count > 0;
        }

        private void bindDataToControl(List<dynamic> taskToBind, DataGridView control)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                BeginInvoke(new Action(() =>
                {
                    control.DataSource = taskToBind;
                }));
            }
        }
        private void bindDataToControl(List<dynamic> taskToBind, ComboBox control)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                BeginInvoke(new Action(() =>
                {
                    control.ValueMember = "Id";
                    control.DisplayMember = "Name";
                    control.DataSource = taskToBind;
                }));
            }
        }

        private async Task refreshTableSubjects()
        {
            try
            {
                if (selectedCareer != null)
                {
                    dataRetrievalTask = Task.Run(() =>
                    {
                        return new List<dynamic>(careerController.loadSubjectsFromCareer(selectedCareer));
                    }, cancellationToken);

                    List<dynamic> dataBind = await dataRetrievalTask;
                    bindDataToControl(dataBind, dataGridViewSubjects);
                    listCareerSubjects = dataBind;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private async Task refreshTableTeachers()
        {
            if (selectedSubject != null)
            {
                dataRetrievalTask = Task.Run(() =>
                {
                    return new List<dynamic>(teacherSubjectController.getAllActiveTeacherCharges(selectedSubject));
                }, cancellationToken);

                List<dynamic> dataBind = await dataRetrievalTask;
                bindDataToControl(dataBind, dataGridViewTeachers);
            }
        }

        private async Task refreshTableCorrelatives()
        {
            if (selectedSubject != null)
            {
                dataRetrievalTask = Task.Run(() =>
                {
                    return new List<dynamic>(correlativeController.getCorrelativesFromSubject(selectedSubject));
                }, cancellationToken);

                List<dynamic> dataBind = await dataRetrievalTask;
                bindDataToControl(dataBind, dataGridViewCorrelatives);
            }
        }

        private async Task refreshCareers()
        {
            try
            {
                dataRetrievalTask = Task.Run(() =>
                {
                    return new List<dynamic>(careerController.loadCareersActive());
                }, cancellationToken);

                List<dynamic> dataBind = await dataRetrievalTask;
                bindDataToControl(dataBind, cbbCareerSelector);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void refreshLabelSubjectName()
        {
            if (selectedSubject != null)
            {
                lblSelectedSubjectName.Text = Convert.ToString(dataGridViewSubjects.CurrentRow.Cells[3].Value);
            }
        }

        private bool verifyInputs()
        {
            if (selectedCareer == null)
            {
                toolTip.Show("", cbbCareerSelector, 1);
                toolTip.Show("Ninguna carrera seleccionda!", cbbCareerSelector, 3000);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip.Show("", txtName, 1);
                toolTip.Show("El nombre de la materia no puede ser nulo!", txtName, 3000);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTotalHourCount.Text))
            {
                toolTip.Show("", txtTotalHourCount, 1);
                toolTip.Show("La cantidad de horas de una materia no puede ser nulo!", txtTotalHourCount, 3000);
                return false;
            }
            if (!txtTotalHourCount.Text.All(char.IsDigit))
            {
                toolTip.Show("", txtTotalHourCount, 1);
                toolTip.Show("La cantidad de horas en forma numerica!", txtTotalHourCount, 3000);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbSubjectYear.Text))
            {
                toolTip.Show("", cbbSubjectYear, 1);
                toolTip.Show("El año de la materia no puede ser nulo!", cbbSubjectYear, 3000);
                return false;
            }
            if (!cbbSubjectYear.Text.All(char.IsDigit))
            {
                toolTip.Show("", cbbSubjectYear, 1);
                toolTip.Show("El año de la materia debe ser de forma numerica!", cbbSubjectYear, 3000);
                return false;
            }
            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (verifyInputs() && selectedCareer != null)
            {
                try
                {
                    if (subjectController.createSubject(selectedCareer, txtName.Text, Convert.ToInt32(cbbSubjectYear.SelectedItem), Int32.Parse(txtTotalHourCount.Text), txtCupof.Text))
                    {
                        lblResult.Text = "Materia Guardada";
                        uponChange();
                    }
                }
                catch (ArgumentNullException ex) { MessageBox.Show("" + ex); }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (verifyInputs() && selectedSubject != null)
            {
                int index = dataGridViewSubjects.CurrentRow.Index;

                try
                {
                    if (subjectController.updateSubject(selectedSubject, txtName.Text, Convert.ToInt32(cbbSubjectYear.SelectedItem), int.Parse(txtTotalHourCount.Text), txtCupof.Text))
                    {
                        lblResult.Text = "Materia Actualizada";
                        keepSelectedRow(index);
                        uponChange();
                    }
                }
                catch (ArgumentNullException ex) { MessageBox.Show("" + ex); }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.CurrentRow != null)
            {
                if (selectedSubject != null && generalValidator.confirmOnDelete("materia"))
                {
                    try
                    {
                        if (subjectController.softDeleteSubject(selectedSubject))
                        {
                            lblResult.Text = "Materia Eliminada";
                            uponChange();
                        }
                    }
                    catch (ArgumentNullException ex) { MessageBox.Show("" + ex); }
                }
            }
        }

        private void keepSelectedRow(int index)
        {
            dataGridViewSubjects.Rows[index].Selected = true;
        }

        private object? setGlobalCareer()
        {
            try
            {
                if (cbbCareerSelector.SelectedItem != null)
                {
                    return careerController.findCareer(cbbCareerSelector.SelectedItem);
                }
            }
            catch (ArgumentNullException ex) { MessageBox.Show("" + ex); }
            return null;
        }

        private object? setGlobalSubject() //a seleccionar una fila/materia de la grilla
        {
            int idsubject;
            try
            {
                if (selectedCareer != null && dataGridViewSubjects.CurrentRow != null)
                {
                    idsubject = Convert.ToInt32(dataGridViewSubjects.CurrentRow.Cells[0].Value);
                    return subjectController.getSpecificSubjectFromCareer(selectedCareer, idsubject);
                }
            }
            catch (ArgumentNullException ex) { MessageBox.Show("" + ex); }
            return null;
        }

        private void uponChange()
        {
            lblResult.Visible = true;
            startLabelRemovalTimer();
            refreshTableSubjects();
            clearAll();
        }

        private void fillFormFields()
        {
            cbbSubjectYear.SelectedItem = Convert.ToString(dataGridViewSubjects.CurrentRow.Cells[2].Value);
            txtName.Text = Convert.ToString(dataGridViewSubjects.CurrentRow.Cells[3].Value);
            txtCupof.Text = Convert.ToString(dataGridViewSubjects.CurrentRow.Cells[4].Value);
            txtTotalHourCount.Text = Convert.ToString(dataGridViewSubjects.CurrentRow.Cells[5].Value);
        }

        private void dataGridViewSubjects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void cbbCareerSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCareer = setGlobalCareer();
            nullCheckCareerSubjectCount();
            clearAll();
        }

        private void clearAll()
        {
            txtName.Text = "";
            txtCupof.Text = "";
            txtTotalHourCount.Text = "";
            lblSelectedSubjectName.Text = "";
        }

        private void startLabelRemovalTimer()
        {
            lableTimer.Interval = 4000; // 3 segundos
            lableTimer.Tick += labelTimer_Tick;
            lableTimer.Start();
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            lableTimer.Stop();
        }

        private void txtTotalHourCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validationController.validateNumbers(e, lbWorkload.Text);
        }


        private void dataGridViewSubjects_ColumnOrderByClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (selectedCareer != null)
            {
                string headerText = dataGridViewSubjects.Columns[e.ColumnIndex].DataPropertyName; //cualquier columna
                var source = dataGridViewSubjects.DataSource;

                if (directionColumn)
                {
                    bindingSourceCareerSubjects.DataSource = listCareerSubjects.OrderBy(o => o.GetType().GetProperty(headerText).GetValue(o)); //ASC
                    directionColumn = false;

                }
                else
                {
                    bindingSourceCareerSubjects.DataSource = listCareerSubjects.OrderByDescending(o => o.GetType().GetProperty(headerText).GetValue(o)); //DSC
                    directionColumn = true;
                }
            }
        }

        private void updateCorrelatives(object sender, ResponseEventHandler e)
        {
            if (e.status)
            {
                newCancellationTokenSource();
                refreshTableCorrelatives();
            }
        }

        private void updateTeachers(object sender, ResponseEventHandler e)
        {
            if (e.status)
            {
                newCancellationTokenSource();
                refreshTableTeachers();
            }
        }

        private void contextMenuSubjects_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (selectedCareer != null && selectedSubject != null && e.ClickedItem != null)
            {
                DataGridViewRow row = dataGridViewSubjects.Rows[dataGridViewSubjects.SelectedRows[0].Index];

                switch (e.ClickedItem.Name)
                {
                    case "informeDeCatedraToolStripMenuItem":
                        Form frmAcademicReport = new formSubjectAcademicReport(selectedCareer, selectedSubject);
                        frmAcademicReport.ShowDialog();
                        break;

                    case "assistanceToolStripMenuItem":
                        formAssistanceTemplate formGenerateAssistance = new formAssistanceTemplate(selectedCareer, selectedSubject);
                        formGenerateAssistance.ShowDialog();
                        break;

                    case "correlativasToolStripMenuItem":
                        formSubjectCorrelatives formCorrelatives = new formSubjectCorrelatives(selectedCareer, selectedSubject, this);
                        formCorrelatives.updateParentEvent += updateCorrelatives;
                        formCorrelatives.ShowDialog();
                        break;

                    case "docentesToolStripMenuItem":
                        formSubjectTeachers formSubjectTeachers = new formSubjectTeachers(selectedSubject, this);
                        formSubjectTeachers.updateParentEvent += updateTeachers;
                        formSubjectTeachers.ShowDialog();
                        break;

                    default:
                        break;
                }
                contextMenuSubjects.Hide();
            }
        }

        private void dataGridViewSubjects_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewSubjects.CurrentRow != null && e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridViewSubjects.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    dataGridViewSubjects.Rows[currentMouseOverRow].Selected = true;

                    inputFormSubjectData();

                    Point mousePosition = new Point(e.X, e.Y);

                    Point screenCoordinates = dataGridViewSubjects.PointToScreen(mousePosition);

                    contextMenuSubjects.Show(screenCoordinates);
                }
            }
        }

        private void dataGridViewSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
