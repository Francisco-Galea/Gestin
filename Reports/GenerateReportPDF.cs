using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using PdfSharp.Pdf.IO;
using PageSize = iTextSharp.text.PageSize;
using PdfName = iTextSharp.text.pdf.PdfName;
using PdfNumber = iTextSharp.text.pdf.PdfNumber;


namespace Gestin.Reports
{
    internal class GenerateReportPDF
    {
        static int numberOfConversions = 0;

        public static void MergePDFs(List<string> pdfRoutes, string targetPath)
        {
            using (var targetDoc = new PdfSharp.Pdf.PdfDocument())
            {
                foreach (var pdf in pdfRoutes)
                {
                    using (var pdfDoc = PdfSharp.Pdf.IO.PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (var i = 0; i < pdfDoc.PageCount; i++)
                            targetDoc.AddPage(pdfDoc.Pages[i]);
                    }
                }
                targetDoc.Save(targetPath);
            }
        }

        public static void GenerateMultiplePdfDocuments(Dictionary<string,string> htmldocuments)
        {
            try
            {
                foreach (var documentData in htmldocuments)
                {
                    ConvertHtmlPdfItextSharp(documentData.Key, documentData.Value);
                }
            }
            catch(Exception) { throw; }
        }

        public static bool GenerateCombinedPDFDocument(Dictionary<string, string> htmldocuments, string destinationRoute)
        {
            try
            {
                GenerateMultiplePdfDocuments(htmldocuments);
                List<string> routes = htmldocuments.Keys.ToList();
                MergePDFs(routes, destinationRoute);
                return true;
            }
            catch(Exception) { throw; }
        }

        public static bool ConvertHtmlPdfItextSharp(string rutaDestino, string html) //Assistance
        {
            try
            {
                using (FileStream stream = new FileStream(rutaDestino, FileMode.Create))
                {
                    using (Document doc = new Document(iTextSharp.text.PageSize.LEGAL.Rotate(), 10, 10, 10, 10)) //edit margins here
                    {
                        PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                        writer.AddPageDictEntry(PdfName.ROTATE, new PdfNumber(90));
                        doc.Open();
                        using (StringReader sr = new StringReader(html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, sr);
                            return true;
                        }
                    }
                }
            }
            catch (Exception) { throw; }
            
        }

        public static void ConvertHtmlPdfItextSharp(string html, string rutaDestino,  float marginLeft, float marginRight, float marginTop, float marginBottom)
        {
            using(FileStream stream = new FileStream(rutaDestino, FileMode.Create))
            {
                Document doc = new Document(PageSize.LEGAL, marginLeft, marginRight, marginTop, marginBottom);
                PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                doc.Open();
                using (StringReader sr = new StringReader(html))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, sr);
                }
                doc.Close();
                stream.Close();
            }
        }
    }
}
