using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf.Advanced;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace PDF_manager.PDFmerge
{
    internal class Pdfmerge_class
    {

        public static List<string> GetPdfFiles(string directory)
        {

            List<string> files_toimport = new List<string>(Directory.GetFiles(directory, "*.pdf", SearchOption.TopDirectoryOnly));

            return files_toimport;
        }

        private static void Merge(List<string> files_toimport, string output)
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

                    PdfPage new_page = outputDocument.AddPage(page);
                    addGraphic(new_page, "e:\\test.png");
                }

            }

            try
            {
                outputDocument.Save(output + "merged.pdf");
            }
            catch
            {
                
            }

        }

        private static void addImageToPdf(List<string> files_toimport)
        {
            List<PdfDocument> Pdf_documents = new List<PdfDocument>();
            for (int i = 0; i < files_toimport.Count; i++)
            {
                PdfDocument inputName = PdfReader.Open(files_toimport[i], PdfDocumentOpenMode.Modify);
                Pdf_documents.Add(inputName);
            }


            for (int i = 0; i < Pdf_documents.Count; i++)
            {
                for (int j = 0; j < Pdf_documents[i].PageCount; j++)
                {
                    PdfPage page = Pdf_documents[i].PageCount > 0 ?
                      Pdf_documents[i].Pages[j] : new PdfPage();
                      addGraphic(page, "e:\\test.png");

                }

                Pdf_documents[i].Save("e:\\test2.pdf");

            }
        }

        public static void selectedListMerge(ListView.ListViewItemCollection items, string output)
        {

            List<string> collection = new List<string>();

            foreach (ListViewItem item in items) 
            {
                collection.Add(item.SubItems[1].Text);
            }

            Merge(collection, output);
        }

        public static void selectedListAddGraphic(ListView.ListViewItemCollection items)
        {

            List<string> collection = new List<string>();

            foreach (ListViewItem item in items)
            {
                collection.Add(item.SubItems[1].Text);
            }

            addImageToPdf(collection);
        }

        private static void addGraphic(PdfPage page, string imageFile)
        {
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XImage image = XImage.FromFile(imageFile);

            double width = page.Width;
            double height = page.Height;
            
            XPoint position = setPositon(width, height);
            gfx.RotateAtTransform(-30, position);

            gfx.DrawImage(image, position);

        }

        private static XPoint setPositon(double width, double height)
        {
            double x = XUnit.FromMillimeter(135);
            double y = XUnit.FromMillimeter(200);
            XPoint position = new XPoint(width - x, height - y);
            return position;
        }

    }
}
