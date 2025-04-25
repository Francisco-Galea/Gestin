using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.Excel;
using Gestin.Controllers;
using Gestin.Model;
using Gestin.Properties;
using Gestin.UI.Custom;

namespace Gestin.UI.Home.Enrolments
{
    public partial class formCareerEnrolmentStatistics : Form //Form unfinished, someone else may complete it
    {
        private careerController careerController = careerController.getInstance();
        private statisticsController statisticsController = statisticsController.getInstance();
        private object receivedCareer;
        private int receivedCareerIndex;

        #region Constructors
        public formCareerEnrolmentStatistics()
        {
            InitializeComponent();
        }

        public formCareerEnrolmentStatistics(int selectedCareerIndex)
        {
            InitializeComponent();
            receivedCareerIndex = selectedCareerIndex;
        }

        public formCareerEnrolmentStatistics(object selectedCareer)
        {
            InitializeComponent();
            receivedCareer = selectedCareer;
            cbbCourse.SelectedIndex = 0;
            LblYear.Text = DateTime.Now.Year.ToString();
        }
        #endregion

        #region FillView
        private void formCareerEnrolmentStatistics_Load(object sender, EventArgs e)
        {
            fillCbbCareer();
            fillCbbSubjects();

            if (cbbCareerSelector.SelectedIndex >= 0)
            {
                if (receivedCareerIndex >= 0)
                {
                    cbbCareerSelector.SelectedIndex = receivedCareerIndex;
                    lblCareerName.Text = careerController.findCareer(Convert.ToInt32(receivedCareer)).Name;
                    cbbCareerSelector.Enabled = true;
                    btnPromedios.Visible = false;
                }
                else if (receivedCareer != null && cbbCareerSelector.Items.Contains(receivedCareer))
                {
                    cbbCareerSelector.SelectedItem = receivedCareer;
                    cbbCareerSelector.Enabled = false;
                    btnPromedios.Visible = false;
                }
            }
            returnBasicStatistics();
        }

        //private void btnPromedios_Click(object sender, EventArgs e)
        //{
        //    formBestAverages frmBestAverages = new formBestAverages();
        //    frmBestAverages.ShowDialog();
        //}

        private void fillCbbCareer()
        {
            if (careerController.countCareers() > 0)
            {
                cbbCareerSelector.DataSource = careerController.loadCareers(); //May show non active careers as well
            }
        }

        private void fillCbbSubjects()
        {
            cbbSubjects.DataSource = careerController.loadSubjectsFromCareer(Convert.ToInt32(receivedCareer));

        }
        private void returnBasicStatistics()
        {
            totalEnrolmentsByCareerByYear(Convert.ToInt32(receivedCareer), Convert.ToInt32(LblYear.Text));
            totalMaleEnrolmentsByCareer(Convert.ToInt32(receivedCareer), Convert.ToInt32(LblYear.Text));
            totalFemaleEnrolmentsByCareer(Convert.ToInt32(receivedCareer), Convert.ToInt32(LblYear.Text));
            totalOtherGenderEnrolmentsByCareer(Convert.ToInt32(receivedCareer), Convert.ToInt32(LblYear.Text));
        }

        private void returnTotalStatistics()
        {
            var selectedSubject = (Subject)cbbSubjects.SelectedItem;
            int subjectId = selectedSubject.Id;
            try
            {
                totalEnrolmentsByCareerBySubject(Convert.ToInt32(receivedCareer), subjectId, Convert.ToInt32(LblYear.Text));
                totalAcademicDelaysByCareerBySubject(Convert.ToInt32(receivedCareer), subjectId);
                totalRecurringEnrolments(subjectId, Convert.ToInt32(LblYear.Text));
                totalNotAcademicDelaysByCareerBySubject(Convert.ToInt32(receivedCareer), subjectId);
                totalMaleEnrolmentsByCareerBySubject(Convert.ToInt32(receivedCareer), subjectId, Convert.ToInt32(LblYear.Text));
                totalFemaleEnrolmentsByCareer(Convert.ToInt32(receivedCareer), Convert.ToInt32(LblYear.Text));
                totalPresentialEnrolmentsByCareer(subjectId, Convert.ToInt32(LblYear.Text));
                totalFemaleEnrolmentsByCareerBySubject(Convert.ToInt32(receivedCareer), subjectId, Convert.ToInt32(LblYear.Text));
                totalFreeEnrolmentsByCareer(subjectId, Convert.ToInt32(LblYear.Text));
                totalAcademicDelaysByCareerBySubject(subjectId, Convert.ToInt32(LblYear.Text));
                totalNotAcademicDelaysByCareerBySubject(subjectId, Convert.ToInt32(LblYear.Text));
                totalOtherGenderEnrolmentsByCareer(Convert.ToInt32(receivedCareer), Convert.ToInt32(LblYear.Text));
            }
            catch(Exception)
            {
                new MessageBoxDarkMode("Por favor, complete el campo restante para buscar.", "Error", "Ok", Resources.Error, true);
            }
        }
        #endregion

        #region LoadStatistics

        
        //Total matricula por carrera por año
        private void totalEnrolmentsByCareerByYear(int id, int Year)
        {
            LblTotalEnroments.Text = statisticsController.getEnrolmentsByCareerByYear(id, Year).ToString();
        }

        //Total matricula por carrera por año por materia
        private void totalEnrolmentsByCareerBySubject(int careerId, int subjectId, int Year)
        {
            LblTotalEnroments.Text = statisticsController.getTotalEnrolmentsByCareerBySubject(careerId, subjectId, Year).ToString();
        }
        //Total matricula por carrera por curso
        private void totalEnrolmentsByCareerByCourse(int YearInCareer, int subjectId)
        {
            LblTotalEnroments.Text = statisticsController.getEnrolmentsByCareerByCourse(YearInCareer, subjectId).ToString();
        }
        

        

        //Total matricula presencial por carrera
        private void totalPresentialEnrolmentsByCareer(int idSubject, int Year)
        {
            LblPresentialEnrolment.Text = statisticsController.getPresentialEnrolmentsBySubjectByYear(idSubject, Year).ToString();
        }
        //Total matricula libre por carrera
        private void totalFreeEnrolmentsByCareer(int idSubject, int Year)
        {
            LblFreeEnrolment.Text = statisticsController.getFreeEnrolmentsBySubjectByYear(idSubject, Year).ToString();
        }
        

        //Total matricula masculina por carrera por año
        private void totalMaleEnrolmentsByCareer(int id, int Year)
        {
            LblTotalMales.Text = statisticsController.getMaleEnrolmentsByCareer(id, Year).ToString();
        }
        //Total matricula masculina por carrera por año por materia
        private void totalMaleEnrolmentsByCareerBySubject(int id, int subject, int Year)
        {
            LblTotalMales.Text = statisticsController.getMaleEnrolmentsByCareerBySubjectByYear(id, subject, Year).ToString();
        }

        //Total matricula femenina por carrera por año
        private void totalFemaleEnrolmentsByCareer(int id, int Year)
        {
            LblTotalFemales.Text = statisticsController.getFemaleEnrolmentsByCareer(id, Year).ToString();
        }

        //Total matricula femenina por carrera por año por materia
        private void totalFemaleEnrolmentsByCareerBySubject(int id, int subject, int Year)
        {
            LblTotalFemales.Text = statisticsController.getFemaleEnrolmentsByCareerBySubjectByYear(id, subject, Year).ToString();
        }
        //matricula total otro genero por carrera
        private void totalOtherGenderEnrolmentsByCareer(int id, int Year)
        {
            lblTotalOtherGender.Text = statisticsController.getOtherGenderEnrolmentsByCareer(id, Year).ToString();
        }

        //matricula total recursantes por materia por año
        private void totalRecurringEnrolments(int subjectId, int Year)
        {
            LbLSubjectRecurring.Text = statisticsController.getRecurrentStudentsBySubjectAndYearInCareer(subjectId, Year).ToString();
        }
        //matricula total atraso academico por carrera por materia
        private void totalAcademicDelaysByCareerBySubject(int subject, int Year)
        {
            LblAcademicallyBehind.Text = statisticsController.getAcademicDelaysByCareerBySubject(subject, Year).ToString();
        }
        //matricula total sin atraso academico por carrera por materia
        private void totalNotAcademicDelaysByCareerBySubject(int subject, int Year)
        {
            LblNoAcademicDelay.Text = statisticsController.getNotAcademicDelaysByCareerBySubject(subject, Year).ToString();
        }
        #endregion

        #region Buttons
        private void toggSearchByYear_CheckedChanged_1(object sender, EventArgs e)
        {
            if (toggSearchByYear.Checked)
            {
                LblYear.Text = "????";
                LblSearch.Text = "Específico";
                txtSearchYear.Enabled = true;
                btnSearchByYear.Enabled = true;
            }
            else
            {
                LblYear.Text = DateTime.Now.Year.ToString();
                LblSearch.Text = "Actual";
                txtSearchYear.Enabled = false;
                txtSearchYear.Text = "";
                btnSearchByYear.Enabled = false;
                returnBasicStatistics();
            }
        }

        private void btnSearchByYear_Click(object sender, EventArgs e)
        {
            LblYear.Text = txtSearchYear.Text;
            returnTotalStatistics();

        }

        private void cbbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSubjects.SelectedItem != null)
            {
                returnTotalStatistics();

            }
        }


        private void toggleSubjects_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSubjects.Checked)
            {
                materia.Visible = true;
                cbbSubjects.Visible = true;
                moreStatisticsPnl.Visible = true;
                cbbSubjects.Enabled = true;
                returnTotalStatistics();

            }
            else
            {
                materia.Visible = false;
                cbbSubjects.Visible = false;
                cbbSubjects.Enabled = false;
                moreStatisticsPnl.Visible = false;
                returnBasicStatistics();

            }
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!toggleButton1.Checked)
            {
                LblCourseFilter.Text = "Todos los cursos";
                CoursePnl.Visible = false;
                returnTotalStatistics();

            }
            else
            {
                LblCourseFilter.Text = "Específico";
                CoursePnl.Visible = true;
            }
        }
        private void cbbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Must be return statistics filtered by course.
        }
        #endregion
    }
}
