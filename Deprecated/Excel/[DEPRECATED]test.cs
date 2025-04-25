using Gestin.Controllers;
using SpreadsheetLight;
using System.Text.RegularExpressions;

namespace Gestin
{
    public partial class formTest : Form
    {
        #pragma warning disable CS8602
        public formTest()
        {
            InitializeComponent();
            careers = s2.GetWorksheetNames();
        }
        List<Dictionary<string, string>> NotLoaded = new List<Dictionary<string, string>>();
        SLDocument s1 = new SLDocument("C:\\Users\\ana\\Desktop\\vaMatr.xlsx");
        SLDocument s2 = new SLDocument("C:\\Users\\ana\\Desktop\\hys.xlsx");

        careerController cntCareer = careerController.getInstance();
        userController cntUser = userController.getInstance();
        careerEnrolmentController cntCareerEnrol = careerEnrolmentController.getInstance();

        List<string> careers = new List<string>();
        private void btnLoadCareer_Click(object sender, EventArgs e)
        {
            loadCareer();
        }
        private void btnLoadSubjects_Click(object sender, EventArgs e)
        {
            loadsubject();
        }
        void loadCareer()
        {
            foreach (string career in careers)
            {
                s1.SelectWorksheet(career);
                string name = (s1.GetCellValueAsString(1, 1));
                string degree = (s1.GetCellValueAsString(2, 2));
                string res = (s1.GetCellValueAsString(3, 2));
                //cntCareer.createCareer(res, name, degree);
            }
        }
        void loadsubject()
        {
            int CareerId = 0;
            foreach (string career in careers)
            {
                int year = 1;
                int row = 5;
                CareerId++;
                s1.SelectWorksheet(career);
                while (!string.IsNullOrEmpty(s1.GetCellValueAsString(row, 1)))
                {
                    if (char.IsDigit(s1.GetCellValueAsString(row, 1)[0]))
                    {
                        year++;
                    }
                    else
                    {
                        string name = s1.GetCellValueAsString(row, 1);
                        int hours = s1.GetCellValueAsInt32(row, 2);
                        //cntCareer.createSubject(CareerId, name, year, hours);
                    }
                    row++;
                }
            }
        }
        void loadStudent()
        {
            int CareerId = 0;
            foreach (string career in careers)
            {
                int row = 3;
                if (career == "paleontologos")
                {
                    row = 2;
                }

                CareerId++;
                s2.SelectWorksheet(career);
                while (!string.IsNullOrEmpty(s2.GetCellValueAsString(row, 1)))
                {
                    string Dni = s2.GetCellValueAsString(row, 3);
                    string name = s2.GetCellValueAsString(row, 2);
                    string lastname = s2.GetCellValueAsString(row, 1);
                    DateTime dateOfBirth = s2.GetCellValueAsDateTime(row, 4);
                    string phone = s2.GetCellValueAsString(row, 5);
                    string mail = s2.GetCellValueAsString(row, 6);

                    if (!Dni.ToString().Equals(""))
                    {
                        int _dni = Int32.Parse(Regex.Replace(Dni, "[@,\\.\";'\\\\]", string.Empty));
                        try
                        {
                            //cntUser.enrolStudent(_dni, mail, name, lastname, dateOfBirth, phone);
                            //cntUser.enrolStudentByExcel(_dni, mail, name, lastname, dateOfBirth, phone);
                        }
                        catch (Exception) { throw; }
                        {
                            Dictionary<string, string> a = new Dictionary<string, string>();
                            a.Add("carrera", career);
                            a.Add("fila", row.ToString());
                            a.Add("dni", Dni);

                            NotLoaded.Add(a);
                        }
                    }
                    row++;
                }
            }
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            loadStudent();
        }

        private void btnLoadCareerEnrolment_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> careerIds = new Dictionary<string, int>();
            careerIds.Add("Higiene y Seguridad", 10);
            careerIds.Add("Enfermería", 3);
            careerIds.Add("Gastronomía", 5);
            //careerIds.Add("Turismo", 2);
            careerIds.Add("AT", 7);
            careerIds.Add("Agroalimentos", 6);
            careerIds.Add("Analistas Progr", 9);
            careerIds.Add("Paleontologos", 8);
            careerIds.Add("Hemoterapia", 13); 
            careerIds.Add("Radiología", 14); 

            foreach (string career in careers)
            {
                int row = 3;
                if (career == "paleontologos")
                {
                    row = 2;
                }
                s2.SelectWorksheet(career);
                while (!string.IsNullOrEmpty(s2.GetCellValueAsString(row, 1)))
                {
                    try
                    {
                        string Dni = s2.GetCellValueAsString(row, 3);
                        int _dni = Int32.Parse(Regex.Replace(Dni, "[@,\\.\";'\\\\]", string.Empty));
                        //int userId = 0;//cntUser.findStudent(_dni).Id;
                        int careerId = careerIds[career];
                        int yearOfRegistration = DateTime.Now.Year;
                        //cntCareerEnrol.enrolStudent(userId, careerId, yearOfRegistration);
                        row++;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }
        void updateStudentPhone()
        {
            int CareerId = 0;
            foreach (string career in careers)
            {
                int row = 3;
                if (career == "paleontologos")
                {
                    row = 2;
                }

                CareerId++;
                s2.SelectWorksheet(career);
                while (!string.IsNullOrEmpty(s2.GetCellValueAsString(row, 1)))
                {
                    string Dni = s2.GetCellValueAsString(row, 3);
                    string phone = s2.GetCellValueAsString(row, 5);

                    if (!Dni.ToString().Equals(""))
                    {
                        int _dni = Int32.Parse(Regex.Replace(Dni, "[@,\\.\";'\\\\]", string.Empty));
                        try
                        {
                            //cntUser.updateStudentPhone(_dni, phone);
                        }
                        catch (Exception) { throw; }
                    }
                    row++;
                }
            }
        }
        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            updateStudentPhone();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
