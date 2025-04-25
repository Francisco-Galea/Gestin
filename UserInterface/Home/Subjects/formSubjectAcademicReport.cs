using Gestin.Controllers;
using Gestin.Properties;
using Gestin.Reports;
using Gestin.UI.Custom;

namespace Gestin.UI.Home.Subjects
{
    public partial class formSubjectAcademicReport : Form
    {
        careerController cntCareer = careerController.getInstance();
        subjectController cntSubject = subjectController.getInstance();
        subjectEnrolmentController cntSubjectEnrolment = subjectEnrolmentController.getInstance();
        object receivedCareer;
        object receivedSubject;
        int subjectId;
        string subjectName;
        string careerName;
        int yearNow;

        public formSubjectAcademicReport(object sentCareer, object sentSubject)
        {
            InitializeComponent();
            this.dgvAcademicReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            receivedCareer = sentCareer;
            receivedSubject = sentSubject;
        }

        private void formSubjectAcademicReport_Load(object sender, EventArgs e)
        {
            yearNow = DateTime.Now.Year;
            lbYear.Text = yearNow.ToString();

            if (receivedCareer != null && receivedSubject != null)
            {
                subjectId = cntSubject.getSubjectId(receivedSubject);
                subjectName = cntSubject.getSubjectName(receivedSubject);
                careerName = cntCareer.getCareerName(receivedCareer);

                lbCareer.Text = $"Carrera: {careerName}";
                lbSubject.Text = $"Materia: {subjectName}";
                loadSubjectEnrolments(yearNow);
            }
        }

        private void loadSubjectEnrolments(int year)
        {
            dgvAcademicReport.Rows.Clear();
            foreach (object se in cntSubjectEnrolment.GetSubjectEnrolments(cntSubject.getSubjectId(receivedSubject), year))
            {
                addSubjectEnrolment(se);
            }
            lblTotal.Text = Convert.ToString(dgvAcademicReport.RowCount);
        }

        private void addSubjectEnrolment(object se) //Libre students can only approve the course if they pass the exam
        {
            List<dynamic> subjectEnrolmentData = cntSubjectEnrolment.getEnrolmentDataTable(se);
            try
            {
                dgvAcademicReport.Rows.Add();
                DataGridViewRow createdRow = dgvAcademicReport.Rows[dgvAcademicReport.Rows.Count - 1];

                for (int j = 0; j < dgvAcademicReport.Columns.Count - 1; j++)
                {
                    createdRow.Cells[j].Value = subjectEnrolmentData[j];
                }
                createdRow.Cells[4].Value = !subjectEnrolmentData[4]; //must be done manually due to inversion

                if (!subjectEnrolmentData[3] && !subjectEnrolmentData[4]) //If course not passed and Libre
                {
                    dgvAcademicReport.SelectedRows[0].ReadOnly = true; //lock
                }
            }
            catch (Exception) { throw; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cntSubjectEnrolment.GetSubjectEnrolments(subjectId, Convert.ToInt32(lbYear.Text)).Count > 0)
            {
                for (int row = 0; row < dgvAcademicReport.Rows.Count; row++)
                {
                    DataGridViewRow selectedRow = dgvAcademicReport.Rows[row];
                    int studentDNI = Convert.ToInt32(selectedRow.Cells[0].Value);
                    bool courseStatus = (bool)selectedRow.Cells[3].Value;

                    if (!selectedRow.ReadOnly) //If selectedRow is not Libre
                    {
                        cntSubjectEnrolment.courseApproval(studentDNI, subjectId, courseStatus);
                    }
                }
                new MessageBoxDarkMode($"Informe de Cátedra - {subjectName} ( {lbYear.Text} ) actualizado correctamente!!", "Aviso", "Ok", Resources.Done, true);
                loadSubjectEnrolments(Convert.ToInt32(lbYear.Text));
            }
            else
            {
                new MessageBoxDarkMode($"No hay estudiantes inscriptos en la materia {subjectName} del ciclo lectivo ", "Error", "Ok", Resources.BigErrorIcon, true);
            }

        }

        private void toggSearchByYear_CheckedChanged(object sender, EventArgs e)
        {
            if (toggSearchByYear.Checked)
            {
                lbYear.Text = "????";
                lbSearchYear.Text = "Específico";
                txtSearchYear.Enabled = true;
                dgvAcademicReport.Rows.Clear();
                btnSave.Visible = false;
                btnExport.Visible = false;
            }
            else
            {
                lbYear.Text = (DateTime.Now.Year).ToString();
                lbSearchYear.Text = "Actual";
                txtSearchYear.Enabled = false;
                txtSearchYear.Text = "";
                loadSubjectEnrolments(DateTime.Now.Year);
                btnSave.Visible = true;
                btnExport.Visible = true;
            }
        }

        private void btnSearchByYear_Click(object sender, EventArgs e)
        {
            if (txtSearchYear.Text != string.Empty && txtSearchYear.Text.All(char.IsDigit))
            {
                lbYear.Text = txtSearchYear.Text;
                loadSubjectEnrolments(Convert.ToInt32(txtSearchYear.Text));
                if (dgvAcademicReport.RowCount == 0)
                {
                    new MessageBoxDarkMode($"No se encontraron registros para la materia {subjectName} - Año: {lbYear.Text}", "ATENCIÓN", "Ok", Resources.advertencia, true);
                }
                btnSave.Visible = true;
                btnExport.Visible = true;
            }
            else
            {
                new MessageBoxDarkMode("Ingrese un año en forma numerica", "Error", "Ok", Resources.BigErrorIcon, true);
            }

        }

        private void txtSearchSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if ((e.KeyChar) == (char)Keys.Enter)
                btnSearchByYear_Click(sender, e);
            validationController.validateNumbers(e, "");
            */
        }

        private void dgvAcademicReport_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvAcademicReport.Rows[e.RowIndex].Selected = true;
        }

        private void dgvAcademicReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAcademicReport.Rows)
            {
                if (row.ReadOnly)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(171, 68, 75);
                    row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(171, 68, 75);
                    row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cntSubjectEnrolment.GetSubjectEnrolments(subjectId, Convert.ToInt32(lbYear.Text)).Count > 0)
            {
                // Crea una instancia de SaveFileDialog
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    sfd.Title = "Guardar Informe de Cátedra";
                    sfd.FileName = $"Informe_Catedra_{subjectName}_{lbYear.Text}.xlsx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // Obtiene la ruta del archivo seleccionada por el usuario
                        string filePath = sfd.FileName;

                        // Crea una instancia del exportador y exporta los datos
                        var exporter = new GenerateReportExcel();
                        exporter.ExportDataGridViewToExcel(
                            dgvAcademicReport,
                            filePath,
                            careerName,
                            subjectName,
                            Convert.ToInt32(lbYear.Text),
                            dgvAcademicReport.RowCount
                        );

                        // Muestra un mensaje indicando que el archivo ha sido exportado correctamente
                        new MessageBoxDarkMode($"Informe de Cátedra - {subjectName} ( {lbYear.Text} ) exportado a Excel exitosamente!!", "Aviso", "Ok", Resources.Done, true);
                    }
                }
            }
            else
            {
                new MessageBoxDarkMode($"No hay estudiantes inscriptos en la materia {subjectName} del ciclo lectivo", "Error", "Ok", Resources.BigErrorIcon, true);
            }
        }

    }
}
