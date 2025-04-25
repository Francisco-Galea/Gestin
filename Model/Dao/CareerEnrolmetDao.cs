using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.EntityFrameworkCore;
using PdfSharp.Pdf.Content.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{   /// <summary>
    /// This class manages the layer of data of careerEnrolment entity
    /// </summary>
    public class CareerEnrolmentDao
    {
        

        public CareerEnrolmentDao() { }


        /// <summary>
        /// Inserts new CareerEnrolment record.
        /// </summary>
        /// <param name="careerEnrolment">CareerEnrolment to add</param>
        /// <returns>True if were successful</returns>
        /// <exception cref="Exception">If there is a careerEnrolment already</exception>
        public bool addCareerEnrolment(object careerEnrolment)
        {
            CareerEnrolment enrolment = (CareerEnrolment)careerEnrolment;
            try
            {
                using (var db = new Context())
                {
                    
                    var existingEnrolment = db.CareerEnrolments.FirstOrDefault(e => e.StudentId == enrolment.StudentId && e.CareerId == enrolment.CareerId);

                    if (existingEnrolment != null)
                    {
                        throw new Exception("El estudiante ya está inscrito en esta carrera.");
                    }

                    db.CareerEnrolments.Add(enrolment);
                    return db.SaveChanges() > 0;
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Gets all enrolments by career.
        /// </summary>
        /// <param name="careerId">IdCareer</param>
        /// <returns>A list of CareerEnrolments</returns>
        public List<CareerEnrolment> getEnrolmentsByCareerId(int careerId)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.CareerEnrolments.Where(x => x.CareerId == careerId).Include(x => x.Student.User).ToList();
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Gets student's career enrolments by student's DNI.
        /// </summary>
        /// <param name="dni">Student's DNI</param>
        /// <returns>Student's career enrolments</returns>
        public List<CareerEnrolment> searchCareerEnrolmentsByDni(int dni)
        {
 
            using (var db = new Context())
            {
                try
                {
                    return db.CareerEnrolments.Where(x => x.Student.User.Dni == dni).Include(x => x.Career).ToList();
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Gets student's careers by student's DNI.
        /// </summary>
        /// <param name="dni">Student's DNI</param>
        /// <returns>Career's list</returns>
        public List<Career> getCareersByStudentDNI(int dni)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.CareerEnrolments.Where(x => x.Student.User.Dni == dni).Include(x => x.Career).Select(x => x.Career).ToList();
                }
                catch (SqlException) { throw; }
            }
        }



    }
}
