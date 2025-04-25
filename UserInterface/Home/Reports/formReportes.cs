using DocumentFormat.OpenXml.Bibliography;
using Gestin.Controllers;
using Gestin.Controllers.Controllers_Reports;
using Gestin.Model;
using Gestin.Properties;
using Gestin.Reports;
using Gestin.UI.Custom;
using Gestin.UI.Home.Enrolments;
using Gestin.UI.Home.Schedules;
using Gestin.UserInterface.Custom;
using System.Threading;

namespace Gestin.UI.Home.Reportes
{
    public partial class formReportes : Form
    {
        careerController cntCareer = careerController.getInstance();
        subjectEnrolmentController cntSubjectEnrolment = subjectEnrolmentController.getInstance();
        dynamic? selectedCareer;
        private Task<List<dynamic>> dataRetrievalTask;
        private CancellationToken cancellationToken;
        private CancellationTokenSource cancellationTokenSource;
        PictureBoxLoading pictureBoxLoading;
        List<dynamic> listCareerSubjects;

        public formReportes()
        {
            InitializeComponent();
            CargarComboBox();
            CargarCbYearInCareer();
        }

        private void btnGenerateScheduleReport_Click(object sender, EventArgs e)
        {
            // Crea una instancia de SaveFileDialog
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.Title = "Guardar Informe de Horarios";
                sfd.FileName = $"Informe_Horarios_{DateTime.Now.ToString("yyyyMMdd")}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo seleccionada por el usuario
                    string filePath = sfd.FileName;

                    // Crea una instancia del controlador y exporta los datos
                    var scheduleExporter = ScheduleReportController.GetInstance();
                    scheduleExporter.ExportTeacherSchedulesToExcel(filePath);

                    // Muestra un mensaje indicando que el archivo ha sido exportado correctamente
                    new MessageBoxDarkMode("Informe de horarios exportado a Excel exitosamente!", "Aviso", "Ok", Resources.Done, true);

                }
            }
        }

        private void btnExportTeacherReport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (.xlsx)|*.xlsx";
                sfd.Title = "Imprimir Listado Docentes";
                sfd.FileName = "ListadoDocente";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Obtener el filepath
                    string filepath = sfd.FileName;
                    int careerId = 0;//Agregar a un Form correspondiente para aplicar
                                     //la logica y que tome el valor del Id de Carrera

                    GenerateReportExcel reportGenerator = new GenerateReportExcel();

                    reportGenerator.ExportToExcel(careerId, filepath);

                    // Mostrar un mensaje de éxito
                    new MessageBoxDarkMode($"{sfd.FileName} exportado a Excel exitosamente", "Aviso", "Ok", Resources.Done, true);
                }
            }
        }

        private void btnGenerateSpreadsheet_Click(object sender, EventArgs e)
        {
            // Crea una instancia de SaveFileDialog
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.Title = "Guardar Informe de Estudiantes";
                sfd.FileName = $"Informe_Estudiantes_{DateTime.Now.ToString("yyyyMMdd")}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo seleccionada por el usuario
                    string filePath = sfd.FileName;

                    // Crea una instancia del exportador y exporta los datos
                    var exporter = new studentReportController();
                    exporter.ExportActiveStudentsToExcel(filePath);

                    // Muestra un mensaje indicando que el archivo ha sido exportado correctamente
                    new MessageBoxDarkMode("Informe de estudiantes exportado a Excel exitosamente!", "Aviso", "Ok", Resources.Done, true);
                }
            }
        }
        private void CargarComboBox()
        {
            var listaCarreras = cntCareer.loadCareers();
            if (listaCarreras != null && listaCarreras.Count > 0)
            {
                cbbCareerSelector.ValueMember = "Id";
                cbbCareerSelector.DisplayMember = "Nombre";
                cbbCareerSelector.DataSource = listaCarreras;
                cbbCareerSelector.SelectedIndex = -1;
            }
        }

        private void CargarCbYearInCareer()
        {
            var yearsInCareer = cntSubjectEnrolment.loadYearsInCareer();
            if (yearsInCareer != null && yearsInCareer.Count > 0)
            {
                cbYearInCareer.DataSource = yearsInCareer;
            }
            lbYearInCareer.Visible = false;
            cbYearInCareer.Visible = false;

        }

        private object? setGlobalCareer()
        {
            try
            {
                if (cbbCareerSelector.SelectedItem != null)
                {
                    return cntCareer.findCareer(cbbCareerSelector.SelectedItem);
                }
            }
            catch (ArgumentNullException ex) { MessageBox.Show("" + ex); }
            return null;
        }

        private async Task nullCheckCareerSubjectCount()
        {
            await refreshTableSubjects();
        }

        private async Task refreshTableSubjects()
        {
            if (selectedCareer != null)
            {
                int careerId = ((Career)selectedCareer).Id;
                var materias = cntCareer.loadSubjectsFromCareer(careerId);

                var materiasFiltradas = materias.Select(m => new
                {
                    YearInCareer = m.YearInCareer,
                    Name = m.Name
                }).ToList();

                bindDataToControl(materiasFiltradas, dataGridViewSubjects);
            }
        }

        private void bindDataToControl<T>(List<T> taskToBind, DataGridView control)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                BeginInvoke(new Action(() =>
                {
                    control.DataSource = taskToBind;
                }));
            }
        }

        private void cbbCareerSelector_SelectedIndexChanged(object sender, EventArgs e) //al seleccionar una carrera se activan el label y combo box
        {
            lbYearInCareer.Visible = true;
            cbYearInCareer.Visible = true;
            selectedCareer = setGlobalCareer();
            nullCheckCareerSubjectCount(); //hace una validacion
        }

        private void btnTeachersByYear_Click(object sender, EventArgs e) //click para exportar el listado excel
        {
            using (SaveFileDialog sfd = new SaveFileDialog()) //se abre una instancia de dialogo para elegir una ubicacion
            {
                sfd.Filter = "Excel Files (.xlsx)|*.xlsx"; //restringe o filtra los tipos de archivos .xlsx.
                sfd.Title = "Exportar Listado Docentes Por Carrera | Año";
                sfd.FileName = "ListadoDocenteCarreraAño";

                if (sfd.ShowDialog() == DialogResult.OK) //verifica la accion del usuario, ej. click guardar
                {
                    // Obtener el filepath
                    string filepath = sfd.FileName; //la ruta seleccionada se almacena en la variable
                   

                    GenerateReportExcel reportGenerator = new GenerateReportExcel();// se instancia de la clase GenerateReportExcel se utiliza para llamar ExportToExcelTeachersByYearInCareer

                    reportGenerator.ExportToExcelTeachersByYearInCareer((Career)cbbCareerSelector.SelectedItem, filepath, (int)cbYearInCareer.SelectedItem);

                    // Mostrar un mensaje de éxito
                    new MessageBoxDarkMode($"{sfd.FileName} exportado a Excel exitosamente", "Aviso", "Ok", Resources.Done, true);
                }
            }
        }

        private void btnTeachersByCareer_Click(object sender, EventArgs e) // hace lo mismo pasos que el metodo anterior, pero invocando a otro metodo
        {
            using (SaveFileDialog sfd = new SaveFileDialog()) //se abre una instancia de dialogo para elegir una ubicacion
            {
                sfd.Filter = "Excel Files (.xlsx)|*.xlsx"; //filtra los archivos 
                sfd.Title = "Exportar Listado Docentes Por Carrera";
                sfd.FileName = "ListadoDocenteCarrera";

                if (sfd.ShowDialog() == DialogResult.OK) //verifica la accion del usuario, click guardar
                {
                    // Obtener el filepath
                    string filepath = sfd.FileName; //almacena la ruta seleccionada en la variable
             

                    GenerateReportExcel reportGenerator = new GenerateReportExcel(); // se instancia la clase GenerateReportExcel que se utiliza para llamar al metodo....

                    reportGenerator.ExportToExcelTeachersByYearInCareer((Career)cbbCareerSelector.SelectedItem, filepath); //se llama al metodo

                    // Mostrar un mensaje de éxito
                    new MessageBoxDarkMode($"{sfd.FileName} exportado a Excel exitosamente", "Aviso", "Ok", Resources.Done, true);
                }
            }
        }
    }
}
