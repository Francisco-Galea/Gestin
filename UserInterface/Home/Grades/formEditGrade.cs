using Gestin.Controllers;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.Validators;

namespace Gestin.UI.Home.Grades
{
    public partial class formEditGrade : Form
    {
        gradeController cntGrade = gradeController.getInstance();
        subjectEnrolmentController cntSubEnrol = subjectEnrolmentController.getInstance();
        object studentRecord;
        string studentName;
        int studentId;
        List<dynamic?> studentRecordValues;

        public formEditGrade(object sentStudentRecord, string sentStudentName, int studentid)
        {
            studentRecord = sentStudentRecord;
            studentName = sentStudentName;
            studentId = studentid;
            InitializeComponent();
        }


        private void formEditGrade_Load(object sender, EventArgs e)
        {
            studentRecordValues = cntGrade.studentRecordValues(studentRecord);
            loadData();
        }

        public void loadData()
        {
            string? accreditationType = studentRecordValues[6];
            DateTime? dateTime = studentRecordValues[11];

            lblStudent.Text = studentName;
            lblSubject.Text = studentRecordValues[0];
            txtEnrolmentYear.Text = studentRecordValues[1];
            chkPresential.Checked = studentRecordValues[2];
            txtGrade.Text = studentRecordValues[3];
            txtBookRecord.Text = studentRecordValues[4];
            chkApproved.Checked = studentRecordValues[7];

            if (cbbAccType.Items.Contains(accreditationType)) { cbbAccType.Text = accreditationType; }

            if (dateTime != null) { dtAccreditationDate.Value = dateTime.Value; } else { dtAccreditationDate.Value = DateTime.Now; }

            chkApproved_CheckedChanged(this, null); //force a recheck
        }

        #region "Minimizar,cerrar y arrastrar"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        /// <summary>
        /// Handles the click event for the "Save" button, validating the exam accreditation conditions before proceeding.
        /// </summary>
        /// <remarks>
        /// This method is triggered when the "Save" button is clicked. It checks if the conditions for exam accreditation
        /// are met by calling the `ChkAcreditationExam()` method. If the conditions are satisfied, the exam is saved by
        /// calling `saveExam()`. If not, a message box is displayed to inform the user that the exam cannot be accredited
        /// because the student has not passed the required course.
        /// </remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSave_ClickAsync(object sender, EventArgs e)
        {
            if (ChkAcreditationExam())
            {
                saveExam();
            }
            else
            {
                new MessageBoxDarkMode($"El estudiante {lblStudent.Text} no puede acreditar el final porque NO tiene la cursada aprobada de esta materia  {lblSubject.Text}", "Error", "Ok", Resources.BigErrorIcon, true);
            }
                
        }

        /// <summary>
        /// Checks whether the exam can be saved based on the accreditation and attendance status.
        /// </summary>
        /// <remarks>
        /// This method evaluates the states of the "chkPresential" and "chkApproved" checkboxes to determine if 
        /// the conditions are met for saving the exam. It returns true if any of the following conditions are met:
        /// 
        /// - The exam is marked as presential and approved.
        /// - The exam is marked as free and not approved (equivalency).
        /// - The exam is not presential but is approved (typically when editing).
        /// </remarks>
        /// <returns>
        /// `true` if the accreditation and attendance conditions allow the exam to be saved; otherwise, `false`.
        /// </returns>
        private bool ChkAcreditationExam()
        {
            return (chkPresential.Checked && chkApproved.Checked) ||    //Presential
                   (!chkPresential.Checked && !chkApproved.Checked) ||  //Libre && Equivalencies
                   (!chkPresential.Checked && chkApproved.Checked);     //When editing above
        }

        private async void saveExam()
        {
            object subject = studentRecordValues[8];
            int? gradeId = studentRecordValues[9]; // in order to prevent a subjectEnrolment to have more than 1 grade, gradeId must not be 0
            int? subjectEnrolmentId = studentRecordValues[10];

            if (ExamFormCompletion())
            {
                if (!txtGrade.Text.Equals(string.Empty) && noErrors())
                {
                    if (gradeId > 0) //If Id Exists
                    {
                        if (cntGrade.updateGrade(Convert.ToInt32(gradeId), txtGrade.Text, txtBookRecord.Text, dtAccreditationDate.Value, cbbAccType.Text))
                            await showDoneImgAsync();
                    }
                    else
                    {
                        if (cntGrade.addGrade(studentId, subject, Int32.Parse(txtGrade.Text), txtBookRecord.Text, dtAccreditationDate.Value, cbbAccType.Text))
                            await showDoneImgAsync();
                    }
                }
                else
                {
                    if (cntSubEnrol.updateEnrolment(Convert.ToInt32(subjectEnrolmentId), txtEnrolmentYear.Text, chkPresential.Checked))
                        await showDoneImgAsync();
                }
            }
        }

        /// <summary>
        /// Checks if the required fields on the exam form are filled out.
        /// </summary>
        /// <remarks>
        /// This method verifies the completion of the essential fields in the exam form, specifically 
        /// checking if the "txtEnrolmentYear" and "txtBookRecord" text fields are populated. If either 
        /// of these fields is empty, the form is considered incomplete, and the method will return false.
        /// </remarks>
        /// <returns>
        /// `true` if all required fields ("txtEnrolmentYear" and "txtBookRecord") are filled; `false` if any of them is empty.
        /// </returns>
        private bool ExamFormCompletion()

        {
            bool status = true;
            if (txtEnrolmentYear.Text.Equals(string.Empty) || txtBookRecord.Text.Equals(string.Empty)) { status = false; }
            return status;
        }

        private bool noErrors()
        {
            if (Int32.Parse(txtGrade.Text) > 10 || Int32.Parse(txtGrade.Text) < 0)
            {
                showError("La nota ingresada no es valida");
                return false;
            }
            return true;
        }

        private async Task showDoneImgAsync()
        {
            pbDone.Visible = true;
            await Task.Delay(750);
            this.Close();
        }
        private void showError(string error)
        {
            lblError.Text = "         " + error;
            lblError.Visible = true;
        }

        /// <summary>
        /// Handles the event when the state of the approval checkbox changes.
        /// </summary>
        /// <remarks>
        /// This method is triggered when the checkbox indicating whether the course is approved is 
        /// checked or unchecked. It retrieves the current accreditation type from a combo box and 
        /// updates the course state accordingly by calling the `SetCourseState` method. 
        /// Additionally, it disables both the approval and presential checkboxes to prevent further 
        /// changes until the state is reset.
        /// </remarks>
        /// <param name="sender">The source of the event, typically the checkbox that triggered the event.</param>
        /// <param name="e">The event data associated with the checkbox state change.</param>
        private void chkApproved_CheckedChanged(object sender, EventArgs e)
        {
            string accreditationType = cbbAccType.Text;
            SetCourseState(accreditationType, chkApproved.Checked);
            chkPresential.Enabled = false;
            chkApproved.Enabled = false;
        }

        /// <summary>
        /// Sets the course state labels and colors based on accreditation type and approval status.
        /// </summary>
        /// <remarks>
        /// This method updates the course state labels (`lbCourseState` and `lblPresential`) and their corresponding colors
        /// according to the provided accreditation type and whether the course is approved. 
        /// 
        /// For "Libre" accreditation type:
        /// - Displays "Cursada APROBADA" and "Cursada LIBRE" if approved, with colors GreenYellow and Yellow, respectively.
        /// - Otherwise, displays "Cursada LIBRE" and "LIBRE" with Yellow color for both labels.
        ///
        /// For "Equivalencia" accreditation type:
        /// - Displays "APROBADA" if approved and "Equivalencia" otherwise, with corresponding GreenYellow or Yellow color for both labels.
        ///
        /// For other accreditation types:
        /// - Displays "Cursada APROBADA" if approved or "Cursada DESAPROBADA" otherwise, with GreenYellow or Red color for `lbCourseState`.
        /// </remarks>
        /// <param name="accreditationType">The type of accreditation, which can be "Libre," "Equivalencia," or another type.</param>
        /// <param name="isApproved">Boolean indicating if the course is approved (`true`) or not (`false`).</param>
        private void SetCourseState(string accreditationType, bool isApproved)
        {
            if (accreditationType.Equals("Libre"))
            {
                lbCourseState.Text = isApproved ? "Cursada APROBADA" : "Cursada LIBRE";
                lblPresential.Text = isApproved ? "Cursada LIBRE" : "LIBRE";
                lbCourseState.ForeColor = isApproved ? Color.GreenYellow : Color.Yellow;
                lblPresential.ForeColor = Color.Yellow;
            }
            else if (accreditationType.Equals("Equivalencia"))
            {
                lbCourseState.Text = isApproved ? "APROBADA" : "Equivalencia";
                lblPresential.Text = "Equivalencia";
                lbCourseState.ForeColor = isApproved ? Color.GreenYellow : Color.Yellow;
                lblPresential.ForeColor = Color.Yellow;
            }
            else
            {
                lbCourseState.Text = isApproved ? "Cursada APROBADA" : "Cursada DESAPROBADA";
                lbCourseState.ForeColor = isApproved ? Color.GreenYellow : Color.Red;
            }
        }

        /// <summary>
        /// Handles the click event for the button to delete a grade.
        /// </summary>
        /// <remarks>
        /// This method manages the process of deleting a grade when the delete button 
        /// is clicked. It first checks if a valid grade ID exists. If not, it shows an 
        /// error message. Then, it confirms the deletion with the user. If confirmed, 
        /// it attempts to delete the grade and shows a success or error message based on 
        /// the result of the deletion. 
        /// </remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnDeleteGrade_Click(object sender, EventArgs e)
        {
            int? gradeId = studentRecordValues[9];

            if (!IsGradeIdValid(gradeId))
            {
                new MessageBoxDarkMode(
                    "No se encontró una nota válida para eliminar.",
                    "Error",
                    "Ok",
                    Resources.BigErrorIcon,
                    true
                );
                return;
            }

            if (ConfirmGradeDeletion())
            {
                bool isDeleted = DeleteGrade(gradeId.Value);
                if (isDeleted)
                {
                    new MessageBoxDarkMode(
                            "La nota se ha eliminado exitosamente.",
                            "Éxito",
                            "Ok",
                            Resources.Done,
                            true
                        );
                    this.Close();
                }
                else
                {
                    new MessageBoxDarkMode(
                            "Hubo un error al intentar eliminar la nota. Por favor, intente nuevamente",
                            "Error",
                            "Error",
                            Resources.BigErrorIcon,
                            true
                        );
                }
            }
            
        }

        /// <summary>
        /// Checks if the given grade ID is valid.
        /// </summary>
        /// <remarks>
        /// This method verifies that the provided grade ID has a value and is greater than zero. 
        /// A valid grade ID is considered one that is non-null and positive.
        /// </remarks>
        /// <param name="gradeId">The nullable grade ID to validate.</param>
        /// <returns>
        /// `true` if the grade ID has a value and is greater than zero; otherwise, `false`.
        /// </returns>
        private bool IsGradeIdValid(int? gradeId)
        {
            return gradeId.HasValue && gradeId > 0;
        }

        /// <summary>
        /// Confirms the deletion of a grade through a confirmation dialog.
        /// </summary>
        /// <remarks>
        /// This method displays a confirmation dialog asking the user if they want to 
        /// proceed with the deletion of the grade associated with the subject.
        /// The dialog presents options to confirm or cancel the action, and returns 
        /// the result of the user's choice.
        /// </remarks>
        /// <returns>
        /// `true` if the user confirms the deletion; otherwise, `false`.
        /// </returns>
        private bool ConfirmGradeDeletion()
        {
            var confirmationResult = new MessageBoxDarkMode(
                $"¿Confirma que desea eliminar la nota de la materia {lblSubject.Text}?",
                "Confirmar",
                "OkCancel",
                Resources.advertencia,
                true
            );
            return generalValidator.messageBoxDialogResult(confirmationResult);
        }

        /// <summary>
        /// Deletes a grade based on the provided grade ID.
        /// </summary>
        /// <remarks>
        /// This method invokes the deletion process for a grade through the `cntGrade` 
        /// object. It returns the result of the deletion operation, indicating whether 
        /// the grade was successfully deleted or not.
        /// </remarks>
        /// <param name="gradeId">The ID of the grade to be deleted.</param>
        /// <returns>
        /// `true` if the grade was deleted successfully; otherwise, `false`.
        /// </returns>
        private bool DeleteGrade(int gradeId)
        {
            return cntGrade.deleteGrade(gradeId);
        }
    }
}
