using Gestin.LocalFiles;
using Gestin.Properties;
using Gestin.Reports;
using Gestin.UI.Commons;
using System.Globalization;

namespace Gestin.Controllers
{
    internal class regularStudentCertificateController
    {
        ImageSelectionController cntSetting = ImageSelectionController.getInstance();
        string CertificateHtmlTemplate;
        CultureInfo culture = LocalGestinSettings.LocalLanguage;

        #region Singleton

        private static regularStudentCertificateController? Instance;
        private regularStudentCertificateController() { }

        public static regularStudentCertificateController getInstance()
        {
            if (Instance == null)
            {
                Instance = new regularStudentCertificateController();
            }
            return Instance;
        }
        #endregion


        #region Regular Student Certificate

        public void generateRegularStudentCertificate(string name, string numberInsti, string dni,string course,string specialty, string city, string rutaDestino)
        {
            setFormValuesInHtmlTemplate(name, numberInsti, dni, course, specialty, city);
            GenerateReportPDF.ConvertHtmlPdfItextSharp(CertificateHtmlTemplate, rutaDestino, 15, 15, 10, 5); 
        }

        private void setFormValuesInHtmlTemplate(string name, string numberInsti, string dni, string course, string specialty, string city)
        {
            CertificateHtmlTemplate = Resources.certificado.ToString();
            CertificateHtmlTemplate = CertificateHtmlTemplate.Replace("@NOMBRE", $"{name}");
            CertificateHtmlTemplate = CertificateHtmlTemplate.Replace("@NROINSTI", $"{numberInsti}");
            CertificateHtmlTemplate = CertificateHtmlTemplate.Replace("@DNI", $"{dni}");
            CertificateHtmlTemplate = CertificateHtmlTemplate.Replace("@CURSO", $"{course}");
            CertificateHtmlTemplate = CertificateHtmlTemplate.Replace("@ESPECIALIDAD", $"{specialty}");
            CertificateHtmlTemplate = CertificateHtmlTemplate.Replace("@CIUDAD", $"{city}");
            CertificateHtmlTemplate = CertificateHtmlTemplate.Replace("@DIA", $"{DateTime.Now.Day.ToString(culture)}");
            CertificateHtmlTemplate = CertificateHtmlTemplate.Replace("@MES", DateTime.Now.ToString("MMMM", culture).ToUpper());
            CertificateHtmlTemplate = CertificateHtmlTemplate.Replace("@ANIO", $"{DateTime.Now.Year.ToString(culture)}");
            if (cntSetting.ReadSelectedImagePathFromConfig() != null)
            {
                CertificateHtmlTemplate = CertificateHtmlTemplate.Replace("@RUTA", "file:///" + cntSetting.ReadSelectedImagePathFromConfig());
            }
            else
            {
                formShowInfo formAv = new formShowInfo("Agregue una imagen como logo", Resources.CloudError);
            }
        }

        #endregion

    }
}
