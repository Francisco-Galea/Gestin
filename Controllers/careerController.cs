using Gestin.Exceptions;
using Gestin.Model;
using Gestin.Model.Dao;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.Validators;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestin.Controllers
{
    internal class careerController
    {
        sessionController sessionController = sessionController.getInstance();
        CareerDao careerDao = new CareerDao();

        #region Singletone

        private static careerController? Instance;

        private careerController() { }

        public static careerController getInstance()
        {
            if (Instance == null)
            {
                Instance = new careerController();
            }
            return Instance;
        }
        #endregion


        #region Loaders

        public List<Career> loadCareers()
        {
            return careerDao.loadCareers();
        }

        public List<Career> loadCareersActive()
        {
            return careerDao.loadCareersActive();
        }

        public List<Subject> loadSubjectsFromCareer(int careerId)
        {
            return careerDao.loadSubjectsFromCareer(careerId);
        }

        public List<Subject> loadSubjectsFromCareer(object selectedCareer)
        {
            return careerDao.loadSubjectsFromCareer(selectedCareer);
        }

        #endregion


        #region Career

        public int countCareers()
        {
            return careerDao.countCareers();
        }

        public Career findCareer(object career)
        {
            return (Career)career;
        }

        public Career findCareer(int id)
        {
            return careerDao.findCareer(id);
        }

        public Career? findCareer(string resolutionNumber)
        {
            return careerDao.findCareer(resolutionNumber);
        }

        public string getCareerName(object career)
        {
            return ((Career)career).Name;
        }

        public string? getCareerResolution(int careerId)
        {
            Career career = findCareer(careerId);
            return career.Resolution;
        }

        public string? getCareerTurn(object career)
        {
            return ((Career)career).Turn;
        }

        /// <summary>
        /// Creates a new career with the specified attributes.
        /// </summary>
        /// <param name="resolutionNumber">The career's resolution number.</param>
        /// <param name="name">The name of the career.</param>
        /// <param name="degree">The degree of the career.</param>
        /// <param name="turn">The turn (schedule) of the career.</param>
        /// <returns>True if the career is successfully created and saved; otherwise, false.</returns>
        /// <exception cref="ArgumentException">Thrown if any input parameter is null or whitespace.</exception>
        public bool createCareer(string resolutionNumber, string name, string degree, string turn)
        {
            validateInputs(resolutionNumber, name, degree, turn);

            Career newCareer = buildCareer(resolutionNumber, name, degree, turn);

            return saveCareer(newCareer);
        }

        /// <summary>
        /// Validates the input parameters for creating a career.
        /// </summary>
        /// <param name="resolutionNumber">The career's resolution number.</param>
        /// <param name="name">The name of the career.</param>
        /// <param name="degree">The degree of the career.</param>
        /// <param name="turn">The turn (schedule) of the career.</param>
        /// <exception cref="ArgumentException">Thrown if any parameter is null or whitespace.</exception>
        private void validateInputs(string resolutionNumber, string name, string degree, string turn)
        {
            if (string.IsNullOrWhiteSpace(resolutionNumber))
                throw new ArgumentException("El número de resolución no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(degree))
                throw new ArgumentException("El grado no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(turn))
                throw new ArgumentException("El turno no puede estar vacío.");
        }

        /// <summary>
        /// Builds a new career instance with the specified attributes.
        /// </summary>
        /// <param name="resolutionNumber">The career's resolution number.</param>
        /// <param name="name">The name of the career.</param>
        /// <param name="degree">The degree of the career.</param>
        /// <param name="turn">The turn (schedule) of the career.</param>
        /// <returns>A new Career instance with the provided attributes.</returns>
        private Career buildCareer(string resolutionNumber, string name, string degree, string turn)
        {
            return new Career
            {
                Resolution = resolutionNumber,
                Name = name,
                Degree = degree,
                Turn = turn,
                CreatedAt = DateTime.Now,
                LastModificationBy = sessionController.getSessionedUserData()
            };
        }

        public bool saveCareer(Career newCareer)
        {
            return careerDao.saveCareer(newCareer);
        }

        /// <summary>
        /// Updates the specified career with new attribute values.
        /// </summary>
        /// <param name="career">The existing career object to update.</param>
        /// <param name="resolutionNum">The new resolution number for the career.</param>
        /// <param name="name">The new name for the career.</param>
        /// <param name="degree">The new degree for the career.</param>
        /// <param name="turn">The new turn (schedule) for the career.</param>
        /// <param name="careerState">The active status of the career.</param>
        /// <returns>True if the career was successfully updated and saved; otherwise, false.</returns>
        /// <exception cref="InvalidOperationException">Thrown if an error occurs while saving changes to the database.</exception>
        public bool updateCareer(object career, string resolutionNum, string name, string degree, string turn, bool careerState)
        {
            Career existingCareer = (Career)career;

            updateCareerAttributes(existingCareer, resolutionNum, name, degree, turn, careerState);
            return saveCareerChanges(existingCareer);
        }

        /// <summary>
        /// Updates the attributes of a career instance.
        /// </summary>
        /// <param name="career">The career instance to update.</param>
        /// <param name="resolution">The new resolution number for the career.</param>
        /// <param name="name">The new name for the career.</param>
        /// <param name="degree">The new degree for the career.</param>
        /// <param name="turn">The new turn (schedule) for the career.</param>
        /// <param name="state">The new active status of the career.</param>
        private void updateCareerAttributes(Career career, string resolution, string name, string degree, string turn, bool state)
        {
            career.Resolution = resolution;
            career.Name = name;
            career.Degree = degree;
            career.Turn = turn;
            career.Active = state;
            career.LastModificationBy = sessionController.getSessionedUserData();
            career.UpdatedAt = DateTime.Now;
        }

        private bool saveCareerChanges(Career career)
        {
            return careerDao.saveCareerChanges(career);
        }

        public void updateCareerSubjectCount()
        {
            careerDao.updateCareerSubjectCount();    
        }

        public bool checkRepeatingResolutionNumber(string ResolutionNum)
        {
            return findCareer(ResolutionNum) != null;
        }

        #endregion
    }
}

