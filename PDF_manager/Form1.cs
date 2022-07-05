using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PDFmerge;

namespace PDF_manager
{
    public partial class Form1 : Form
    {
        private string location;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            location = directory_textbox.Text;
        }

        private void Pdfmerge_button(object sender, EventArgs e)
        {

            List<string> files_toimport = Pdfmerge_class.GetPdfFiles(location);
            Pdfmerge_class.Merge(files_toimport, location);

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void directory_textbox_TextChanged(object sender, EventArgs e)
        {
            location = directory_textbox.Text;
        }
    }
 }
