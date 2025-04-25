using Gestin.Controllers;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.UI.EventHandlers;

namespace Gestin.UI.Home.Subjects
{
    public partial class formSubjectCorrelatives : Form
    {
        public event EventHandler<ResponseEventHandler> updateParentEvent;
        subjectController subjectController = subjectController.getInstance();
        formSubject parentFormSubject;
        careerController careerController;
        correlativeController correlativeController = correlativeController.getInstance();
        dynamic receivedCareer;
        dynamic receivedSubject;
        public formSubjectCorrelatives(dynamic sentCareer, dynamic sentSubject, formSubject receivedFormSubject)
        {
            parentFormSubject = receivedFormSubject;
            receivedCareer = sentCareer;
            receivedSubject = sentSubject;
            careerController = careerController.getInstance();
            InitializeComponent();
        }

        private void formSubjectCorrelatives_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateParentEvent.Invoke(this, new ResponseEventHandler(true));
            parentFormSubject.Visible = true;
        }

        private void formSubjectCorrelatives_Load(object sender, EventArgs e)
        {
            RefreshLableSubjectName();
            RefreshTableCorrelatives();
            RefreshComboboxCorrelatives();
        }

        private void checkBoxSpecial_CheckStateChanged(object sender, EventArgs e)
        {
            RefreshComboboxCorrelatives();
        }

        private void RefreshComboboxCorrelatives()
        {
            bindingSourceCorrelativasExceptSame.DataSource = correlativeController.getEnabledCorrelatives(receivedCareer, receivedSubject, checkBoxSpecial.Checked);
            bindingSourceCorrelativasExceptSame.ResetBindings(true);
            cbbCorrelativas.DataSource = bindingSourceCorrelativasExceptSame;
            cbbCorrelativas.DisplayMember = "NAME";
            cbbCorrelativas.ValueMember = "ID";
        }

        private void RefreshTableCorrelatives() //DATATABLE CORRELATIVAS
        {
            try
            {
                correlativeBindingSource.DataSource = correlativeController.getCorrelativesFromSubject(receivedSubject);
                correlativeBindingSource.ResetBindings(true);
                dataGridViewCorrelatives.DataSource = correlativeBindingSource;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void RefreshLableSubjectName()
        {
            try
            {
                lblsubjectName.Text = $"{subjectController.getSubjectName(receivedSubject)}";
                lblmateriaName2.Text = lblsubjectName.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnAddCorrelativas_Click(object sender, EventArgs e)
        {
            try
            {
                object? selectedSubject = cbbCorrelativas.SelectedItem;
                if(selectedSubject != null)
                {
                    correlativeController.createCorrelative(receivedSubject, selectedSubject, chkEstado.Checked);
                    RefreshComboboxCorrelatives();
                    RefreshTableCorrelatives();
                }
            }
            catch { new MessageBoxDarkMode("Ninguna materia seleccionada", "Error", "Ok", Resources.Error, true); }
        }

        private void btnRemoveCorrelative_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCorrelatives.Rows.Count > 0)
                {
                    int selectedCorrelativeID = Convert.ToInt32(dataGridViewCorrelatives.CurrentRow.Cells[0].Value);
                    correlativeController.removeCorrelative(selectedCorrelativeID);
                    RefreshComboboxCorrelatives();
                    RefreshTableCorrelatives();
                }
            }
            catch { new MessageBoxDarkMode("Ninguna materia seleccionada", "Error", "Ok", Resources.Error, true); }
        }
    }
}
