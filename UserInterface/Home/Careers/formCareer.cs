using Gestin.Controllers;
using Gestin.Properties;
using Gestin.Reports;
using Gestin.UI.Custom;
using Gestin.UI.Home.Enrolments;
using Gestin.UI.Home.Schedules;
using Gestin.UserInterface.Custom;

namespace Gestin.UI.Home.Careers
{
    public partial class formCareer : Form
    {
#pragma warning disable CS4014 //remove aync warnings
        careerController careerController = careerController.getInstance();
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private Task<List<dynamic>> dataRetrievalTask;
        PictureBoxLoading pictureBoxLoading;
        object? selectedCareer;

        public formCareer()
        {
            InitializeComponent();
        }

        private async void formCareer_Load(object sender, EventArgs e)
        {
            if (nullCheckCareers())
            {
                await loadDataAsync();
            }
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
                        await refreshTableCareers();
                    }
                });
                pictureBoxLoading.destroyLoadingPictureBox();
            }
            catch { } //sometimes the thread is destroyed before it finishes executing
        }

        private void dataGridViewCareers_SelectionChanged(object sender, EventArgs e)
        {
            selectedCareer = setGlobalCareer();
            fillCareerFields();
        }


        private bool nullCheckCareers()
        {
            return careerController.countCareers() > 0;
        }

        private bool verifyInputs()
        {
            if (string.IsNullOrWhiteSpace(txtResolutionNumber.Text))
            {
                toolTip.Show("", txtResolutionNumber, 1);
                toolTip.Show("Numero de resolución no puede ser nulo!", txtResolutionNumber, 3000);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip.Show("", txtName, 1);
                toolTip.Show("El nombre de la carrera no puede ser nulo!", txtName, 3000);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                toolTip.Show("", txtTitle, 1);
                toolTip.Show("El titulo de la carrera no puede ser nulo!", txtTitle, 3000);
                return false;
            }
            return true;
        }

        private bool verifyResolutionNumber()
        {
            if (careerController.checkRepeatingResolutionNumber(txtResolutionNumber.Text))
            {
                toolTip.Show("", txtResolutionNumber, 1);
                toolTip.Show("Ya existe una carrera con ese mismo numero de resolución", txtResolutionNumber, 3000);
                return false;
            }
            return true;
        }

        private async Task refreshTableCareers()
        {
            //CancellationTokens are used to terminate threads that are still running when closing the form. (prevent resource leakage)
            dataRetrievalTask = Task.Run(() =>
            {
                return new List<dynamic>(careerController.loadCareers());
            }, cancellationToken);

            if (!cancellationToken.IsCancellationRequested)
            {
                var careers = await dataRetrievalTask;

                BeginInvoke(new Action(() =>
                {
                    BindingSourceCareers.DataSource = careers;
                    BindingSourceCareers.ResetBindings(false);
                    dataGridViewCareers.DataSource = BindingSourceCareers;
                }));
            }
            careerController.updateCareerSubjectCount();

            //The former background task used for Data Retrieval returns to the thread pool, awaiting reassignment
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (verifyInputs() && verifyResolutionNumber())
            {
                try
                {
                    if (careerController.createCareer(txtResolutionNumber.Text, txtName.Text, txtTitle.Text, cbbTurn.Text))
                    {
                        lblResult.Text = "Carrera Guardada";
                        uponChange();
                    }
                }
                catch (Exception ex) { MessageBox.Show("" + ex); }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (verifyInputs() && selectedCareer != null)
            {
                try
                {
                    if (careerController.updateCareer(selectedCareer, txtResolutionNumber.Text, txtName.Text, txtTitle.Text, cbbTurn.Text, chkActiveCareer.Checked))
                    {
                        lblResult.Text = "Carrera Actualizada";
                        uponChange();
                    }
                }
                catch (Exception ex) { MessageBox.Show("" + ex); }
            }
            dataGridViewCareers.ClearSelection();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCareer != null)
                {
                    Visible = false;
                    formSchedule form = new formSchedule(selectedCareer, this);
                    form.Show();
                }
            }
            catch { new MessageBoxDarkMode("Error, ninguna carrera seleccionada", "Error", "Ok", Resources.Error, true); }
        }

        private object? setGlobalCareer() //a seleccionar una fila/carrera de la grilla
        {
            int idcareer;
            try
            {
                if (dataGridViewCareers.CurrentRow.Cells[0].Value != null)
                {
                    idcareer = Convert.ToInt32(dataGridViewCareers.CurrentRow.Cells[0].Value);
                    return careerController.findCareer(idcareer);
                }
                return null;
            }
            catch (Exception) { throw; }
        }

        private void uponChange()
        {
            lblResult.Visible = true;
            clearAll();
            startLabelRemovalTimer();
            refreshTableCareers();
        }

        private void clearAll()
        {
            txtResolutionNumber.Clear();
            txtName.Clear();
            txtTitle.Clear();
            cbbTurn.SelectedIndex = -1;
        }

        private void dataGridViewCareers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillCareerFields();
        }

        private void dataGridViewCareers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        public void fillCareerFields()
        {
            txtResolutionNumber.Text = Convert.ToString(dataGridViewCareers.CurrentRow.Cells[1].Value);
            txtName.Text = Convert.ToString(dataGridViewCareers.CurrentRow.Cells[2].Value);
            txtTitle.Text = Convert.ToString(dataGridViewCareers.CurrentRow.Cells[3].Value);
            string? turn = Convert.ToString(dataGridViewCareers.CurrentRow.Cells[4].Value);

            if (!string.IsNullOrWhiteSpace(turn))
            {
                cbbTurn.SelectedItem = Convert.ToString(dataGridViewCareers.CurrentRow.Cells[4].Value);
            }
            else { cbbTurn.SelectedIndex = -1; }

            if (dataGridViewCareers.CurrentRow.Cells[0].Value != null)
            {
                chkActiveCareer.Checked = (bool)dataGridViewCareers.CurrentRow.Cells[6].Value;
            }
        }

        public void startLabelRemovalTimer()
        {
            labelTimer.Interval = 4000; // 4 segundos
            labelTimer.Tick += labelTimer_Tick;
            labelTimer.Start();
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            labelTimer.Stop();
        }

        private void chkActivo_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(chkActiveCareer, "Indica si la carrera se encuentra activa para inscripciones.");
        }

        public void disposeCancellationToken()
        {
            cancellationTokenSource.Dispose();
        }


        private void contextMenuCareers_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (selectedCareer != null && e.ClickedItem != null)
            {
                DataGridViewRow row = dataGridViewCareers.Rows[dataGridViewCareers.SelectedRows[0].Index];

                switch (e.ClickedItem.Name)
                {
                    case "matriculaToolStripMenuItem":
                        formCareerEnrolmentStatistics formA = new formCareerEnrolmentStatistics(dataGridViewCareers.SelectedRows[0].Cells[0].Value);
                        formA.ShowDialog();
                        break;

                    case "promediosToolStripMenuItem":
                        formBestAverages formB = new formBestAverages(dataGridViewCareers.SelectedRows[0].Index);
                        formB.ShowDialog();
                        break;

                    default:
                        break;
                }
                contextMenuCareers.Hide();
            }
        }

        private void dataGridViewCareers_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewCareers.CurrentRow != null && e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridViewCareers.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    dataGridViewCareers.Rows[currentMouseOverRow].Selected = true;

                    Point mousePosition = new Point(e.X, e.Y);

                    Point screenCoordinates = dataGridViewCareers.PointToScreen(mousePosition);

                    contextMenuCareers.Show(screenCoordinates);
                }
            }
        }
    }
}
