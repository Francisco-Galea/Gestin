using Gestin.Model.Model_Internal;
using Gestin.Controllers;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.UI.Home.Careers;

namespace Gestin.UI.Home.Schedules
{
    /// <summary>
    /// Class <c>formSchedule</c> Formulario usado para mostrar los horarios
    /// </summary>
    public partial class formSchedule : Form
    {
        formCareer parentFormCareer;
        careerController careerController;
        subjectController subjectController = subjectController.getInstance();
        scheduleController scheduleController = scheduleController.getInstance();
        teacherSubjectController teacherSubjectController = teacherSubjectController.getInstance();
        object receivedCareer;
        List<List<string?>> requestedScheduleValues = new();
        int amountOfSchedulesRows = 4;

        public formSchedule(object sentCareer, formCareer receivedFormCareer)
        {
            parentFormCareer = receivedFormCareer;
            receivedCareer = sentCareer;
            careerController = careerController.getInstance();
            InitializeComponent();
        }

        private void formSchedule_Load(object sender, EventArgs e)
        {
            loadScheduleTurns();
            nullCheckSchedule();
            changeLableText();
        }

        private void formSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentFormCareer.Show();
        }
        /// <summary>
        /// Method <c>nullCheckSchedule</c> Refresca la tabla de materias si es que hay un horario seleccionado y la cantidad de horarios no es 0
        /// </summary>
        private void nullCheckSchedule()
        {
            if (scheduleController.countSchedules() != 0 && comboBoxYear.SelectedItem != null)
            {
                refreshTableSchedule();
            }
        }
        /// <summary>
        /// Method <c>addRowsToViewSchedules</c> Añade filas a dataGridViewSchedules basada en amountOfSchedulesRows y evita que el usuario no pueda hacerlo manualmente
        /// </summary>
        private void addStaticRows() //eventually rows will need to be dynamically added in the future
        {
            addRowsToViewSchedules(amountOfSchedulesRows);
            dataGridViewSchedules.AllowUserToAddRows = false;
        }
        /// <summary>
        /// Method <c>addRowsToViewSchedules</c> Añade una cantidad determinada de filas a dataGridViewSchedules
        /// </summary>
        private void addRowsToViewSchedules(int amount)
        {
            for(int i=0;i<amount;i++)
                dataGridViewSchedules.Rows.Add();
        }
        /// <summary>
        /// Method <c>loadScheduleTurns</c> Carga la cantidad de filas del formulario basado en amountOfSchedulesRows
        /// </summary>
        private void loadScheduleTurns()
        {
            addStaticRows();
            List<string> careerTurnTimeList = assignCareerTurnTime();
            if (careerTurnTimeList != null)
            {
                for (int i = 0; i < amountOfSchedulesRows; i++)
                {
                    dataGridViewSchedules.Rows[i].HeaderCell.Value = careerTurnTimeList[i];
                }
            }
        }
        /// <summary>
        /// Method <c>assignCareerTurnTime</c> Retorna una lista de strings basada en receivedCareer
        /// </summary>
        private List<string> assignCareerTurnTime() //Row Headers Values
        {
            List<string> timeList = new List<string>();
            switch (careerController.getCareerTurn(receivedCareer))
            {
                default:
                    addToListString(timeList, "N/A", "N/A", "N/A", "N/A");
                    nullTurn();
                    break;
                case "Mañana":
                    addToListString(timeList, "08:00 09:00", "09:00 10:00", "10:00 11:00", "11:00 12:00");
                    break;
                case "Tarde":
                    addToListString(timeList, "13:00 14:00", "14:00 15:00", "15:00 16:00", "16:00 17:00");
                    break;
                case "Vespertino":
                    addToListString(timeList, "18:00 19:00", "19:00 20:00", "20:00 21:00", "21:00 22:00");
                    break;
            }
            return timeList;
        }
        /// <summary>
        /// Method <c>addToListString</c> Añade varios strings a una lista
        /// </summary>
        private void addToListString(List<string> list, params string[] args)
        {
            foreach (string str in args)
            {
                list.Add(str);
            }
        }
        /// <summary>
        /// Method <c>changeLableText</c> Cambia el labelCareerName al de receivedCareer
        /// </summary>
        private void changeLableText()
        {
            labelCareerName.Text = careerController.getCareerName(receivedCareer);
        }
        /// <summary>
        /// Method <c>nullTurn</c> Hace que el turno sea nulo
        /// Evita que se puedan usar los dataGridView de materias y horarios
        /// </summary>
        private void nullTurn()
        {
            dataGridViewSubjects.Enabled = false;
            dataGridViewSubjects.RowsDefaultCellStyle.SelectionBackColor = dataGridViewSubjects.BackgroundColor;
            dataGridViewSchedules.Enabled = false;
            dataGridViewSchedules.RowsDefaultCellStyle.SelectionBackColor = dataGridViewSchedules.BackgroundColor;
            setErrorPictureBox();
        }
        /// <summary>
        /// Method <c>setErrorPictureBox</c> Muestra la imagen de error
        /// </summary>
        private void setErrorPictureBox()
        {
            pictureBoxError.Visible = true;
            pictureBoxError.BackgroundImage = Resources.BigErrorIcon;
            pictureBoxError.BackgroundImageLayout = ImageLayout.Stretch;
        }
        /// <summary>
        /// Method <c>getSpecifiedStartingTime</c> Retorn un TimeSpan dada la posición de una fila concreta
        /// </summary>
        private TimeSpan getSpecifiedStartingTime(int row) //rowheader text first time (08:00 09:00) -> timespan (08:00)
        {
            List<string> timeList = assignCareerTurnTime();
            TimeSpan time = TimeSpan.Parse(timeList[row].Split(" ")[0]);
            return time;
        }
        /// <summary>
        /// Method <c>refreshTableSubjects</c> Refresca la tabla de materias al tener un año seleccionado(escrito de mejor forma)
        /// Puede tirar un POP UP ya que usa la controladora de carrera que se conecta a la base de datos
        /// </summary>
        private void refreshTableSchedule() //refactored to comply with SRP and Encapsulation rules
        {
            clearAllCells();
            DataGridViewTextBoxColumn[] textBoxes = { txtLunes, txtMartes, txtMiercoles, txtJueves, txtViernes, txtSabado };
            int selectedYear = Convert.ToInt32(comboBoxYear.SelectedItem);
            requestedScheduleValues = scheduleController.getScheduleValues(scheduleController.getSchedulesInCareerByYear(receivedCareer, selectedYear));

            if (requestedScheduleValues != null)
            {
                try
                {
                    foreach (List<string?> scheduleData in requestedScheduleValues)
                    {
                        int scheduleId = Convert.ToInt32(scheduleData[0]);
                        string subjectName = scheduleData[1];
                        TimeSpan scheduleTime = TimeSpan.Parse(scheduleData[2]);
                        string scheduleDay = scheduleData[3];
                        string? subjectTeacher = scheduleData[4];

                        DataGridViewTextBoxColumn? textBox = textBoxes.FirstOrDefault(t => t.HeaderText == scheduleDay);

                        int columnIndex = Array.IndexOf(textBoxes, textBox);
                        int rowIndex = GetRowIndexByStartingTime(scheduleTime);
                        if (rowIndex >= 0 && columnIndex >= 0)
                        {
                            DataGridViewCell rowCell = dataGridViewSchedules.Rows[rowIndex].Cells[columnIndex];
                            
                            if (rowCell != null)
                            {
                                rowCell.Value = subjectName += subjectTeacher;
                                setSubjectIdTagForCell(rowCell, scheduleId);
                            }
                        }
                    }
                }
                catch (Exception exc) { MessageBox.Show("" + exc.Message); }
            }
        }
        /// <summary>
        /// Method <c>GetRowIndexByStartingTime</c> Retorna la fila basado en un TimeSpan dado
        /// </summary>
        private int GetRowIndexByStartingTime(TimeSpan startingTime)
        {
            int result = -1;
            for (int i = 0; i < dataGridViewSchedules.Rows.Count; i++)
            {
                string selectStartingTime = startingTime.ToString("hh\\:mm");
                string selectedCellTime = getSpecifiedStartingTime(i).ToString("hh\\:mm");
                if (selectedCellTime == selectStartingTime)
                {
                    result = i;
                    i = dataGridViewSchedules.Rows.Count;
                }
            }
            return result;
        }

        /// <summary>
        /// Method <c>RefreshTableSubjects</c> Refresca la tabla de materias al tener un año seleccionado
        /// Puede tirar un POP UP ya que usa la controladora de carrera que se conecta a la base de datos
        /// </summary>
        private void RefreshTableSubjects()
        {
            dataGridViewSubjects.DataSource = null;
            if (comboBoxYear.SelectedItem != null)
            {
                try
                {
                    bindingSourceSubjects.DataSource = subjectController.getSubjectsFromCareerByYear(receivedCareer, Convert.ToInt32(comboBoxYear.SelectedItem));
                    bindingSourceSubjects.ResetBindings(false);
                    dataGridViewSubjects.DataSource = bindingSourceSubjects;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewSchedule_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridViewSchedules.Rows.Count > amountOfSchedulesRows) //Existen solamente 4 filas 
            {
                dataGridViewSchedules.EndEdit();
                while (dataGridViewSchedules.Rows.Count > amountOfSchedulesRows)
                {
                    dataGridViewSchedules.Rows.RemoveAt(dataGridViewSchedules.Rows.Count - 1);
                }
            }
        }

        private void comboBoxYear_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshTableSubjects();
            refreshTableSchedule();
        }
        /// <summary>
        /// Method <c>clearAllCells</c> Borra la información de todas las celdas del formulario
        /// </summary>
        private void clearAllCells() //dataGridViewSchedules.Rows.Clear() no me gusta, mejor lo hago asi
        {
            dataGridViewSchedules.SelectAll(); //seleciono todas las celdas
            foreach (DataGridViewCell selectedCell in dataGridViewSchedules.SelectedCells)
            {
                selectedCell.Value = null;
            }
            dataGridViewSchedules.ClearSelection(); //dejo de seleccionar todas las celdas
        }

        private void dataGridViewSubjectsByYear_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo dragInfo = dataGridViewSubjects.HitTest(e.X, e.Y);
                if (dragInfo.RowIndex >= 0 && dragInfo.ColumnIndex >= 0)
                {
                    int hiddenID = Convert.ToInt32(dataGridViewSubjects.CurrentRow.Cells[0].Value);
                    string? details = Convert.ToString(dataGridViewSubjects.CurrentRow.Cells[1].Value);
                    string? teachers = teacherSubjectController.filterSubjectTeachers(hiddenID);
                    DraggedData draggedData = new DraggedData(hiddenID, details, teachers);
                    dataGridViewSubjects.DoDragDrop(draggedData, DragDropEffects.Copy);
                }
            }
        }

        private void dataGridViewSchedules_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridViewSchedules_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(typeof(DraggedData)))
            {
                DraggedData draggedData = (DraggedData)e.Data.GetData(typeof(DraggedData));
                DataGridView.HitTestInfo dropInfo = dataGridViewSchedules.HitTest(dataGridViewSchedules.PointToClient(new Point(e.X, e.Y)).X, dataGridViewSchedules.PointToClient(new Point(e.X, e.Y)).Y);

                if (dropInfo.RowIndex >= 0 && dropInfo.ColumnIndex >= 0)
                {
                    DataGridViewCell selectedCell = dataGridViewSchedules.Rows[dropInfo.RowIndex].Cells[dropInfo.ColumnIndex];
                    setSubjectIdTagForCell(selectedCell, draggedData.GetId);
                    assignSchedule(selectedCell, draggedData);
                }
            }
        }
        private void dataGridViewSchedules_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                foreach (DataGridViewCell selectedCell in dataGridViewSchedules.SelectedCells)
                {
                    if (selectedCell.Value != null)
                    {
                        deleteSchedule(selectedCell);
                    }
                }
            }
        }
        /// <summary>
        /// Method <c>setSubjectIdTagForCell</c> Setea el Tag de una celda dada a un ID de una materia
        /// </summary>
        private void setSubjectIdTagForCell(DataGridViewCell cell, int hiddenID)
        {
            cell.Tag = hiddenID;
        }
        /// <summary>
        /// Method <c>getSubjectIDTagFromCell</c> Retorna el ID de una materia badasa en una celda dada
        /// </summary>
        private int getSubjectIDTagFromCell(DataGridViewCell cell)
        {
            int id = 0;
            if (cell.Tag != null && cell.Tag is int)
            {
                id=(int)cell.Tag;
            }
            return id;
        }
        /// <summary>
        /// Method <c>assignSchedule</c> Asigna un horario a una materia basado en una celda dada
        /// Verifica si la materia se execede en su cantidad de horas semanales y tira un POP-UP
        /// </summary>
        private void assignSchedule(DataGridViewCell draggedCell, DraggedData draggedData)
        {
            try
            {
                TimeSpan time = getSpecifiedStartingTime(draggedCell.RowIndex);
                string day = dataGridViewSchedules.Columns[draggedCell.ColumnIndex].HeaderText;
                int subjectID = getSubjectIDTagFromCell(draggedCell);
                int careerYear = Convert.ToInt32(comboBoxYear.SelectedItem);
                int currentWeeklyHours = getCurrentWeeklyHours(subjectID);

                if (scheduleController.IsSubjectWeeklyHoursExceeded(currentWeeklyHours, subjectID))
                {
                    new MessageBoxDarkMode($"La materia [{draggedData.GetDescription}] ya tiene la cantidad maxima de horas alojadas", "Error", "Ok", Resources.Error, true);
                    nullifyCellContents(draggedCell);
                }
                else
                {
                    draggedCell.Value = draggedData.ToString();
                    scheduleController.assignScheduleForSpecifiedSubject(time, day, careerYear, subjectID);
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        /// <summary>
        /// Method <c>deleteSchedule</c> Borra los horarios de una materia especifica basada en una celda dada
        /// </summary>
        private void deleteSchedule(DataGridViewCell selectedCell)
        {
            TimeSpan time = getSpecifiedStartingTime(selectedCell.RowIndex);
            string day = dataGridViewSchedules.Columns[selectedCell.ColumnIndex].HeaderText;
            int subject = getSubjectIDTagFromCell(selectedCell);
            int year = Convert.ToInt32(comboBoxYear.SelectedItem);
            scheduleController.deleteScheduleForSpecifiedSubject(time, day, year, subject);
            nullifyCellContents(selectedCell);
        }
        /// <summary>
        /// Method <c>nullifyCellContents</c> Convirte todas los valores de una celda dada a NULL
        /// </summary>
        public void nullifyCellContents(DataGridViewCell selectedCell)
        {
            dataGridViewSchedules.CurrentCell = selectedCell;
            dataGridViewSchedules.CurrentCell.Value = null;
            dataGridViewSchedules.CurrentCell.Tag = null;
            dataGridViewSchedules.CurrentCell = null;
        }
        /// <summary>
        /// Method <c>getCurrentWeeklyHours</c> Retorna la cantidad de horas una materia seleccionada usando su ID
        /// </summary>
        private int getCurrentWeeklyHours(int selectedSubjectID)
        {
            dataGridViewSchedules.SelectAll();
            int? cellSubjectID;
            int hourCount = 0;
            foreach (DataGridViewCell selectedCell in dataGridViewSchedules.SelectedCells)
            {
                cellSubjectID = getSubjectIDTagFromCell(selectedCell);
                if (selectedSubjectID == cellSubjectID) //comparo los ID's de cada celda, con el ID de la materia a momento de insertar
                {
                    hourCount++;
                }
            }
            dataGridViewSchedules.ClearSelection();
            return hourCount;
        }
    }
}
