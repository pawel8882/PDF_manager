using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using System.Collections;
using System.IO;

namespace PDFmerge
{
    internal class Pdfmerge_class
    {

        public static List<string> GetPdfFiles(string directory)
        {

            List<string> files_toimport = new List<string>(Directory.GetFiles(directory, "*.pdf", SearchOption.TopDirectoryOnly));

            return files_toimport;
        }

        public static void Merge(List<string> files_toimport, string output)
        {
            List<PdfDocument> Pdf_documents = new List<PdfDocument>();
            for (int i = 0; i < files_toimport.Count; i++)
            {
                PdfDocument inputName = PdfReader.Open(files_toimport[i], PdfDocumentOpenMode.Import);
                Pdf_documents.Add(inputName);
            }

            PdfDocument outputDocument = new PdfDocument();

            outputDocument.PageLayout = PdfPageLayout.SinglePage;


            for (int i = 0; i < Pdf_documents.Count; i++)
            {
                for (int j = 0; j < Pdf_documents[i].PageCount; j++)
                {
                    PdfPage page = Pdf_documents[i].PageCount > 0 ?
                      Pdf_documents[i].Pages[j] : new PdfPage();

                    outputDocument.AddPage(page);

                }

            }

            outputDocument.Save(output + "merged.pdf");

        }
    }
}
