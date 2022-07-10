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
using PDF_manager.PDFmerge;

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
            selected_files.Columns.Add("Selected files", 320, HorizontalAlignment.Left);
            selected_files.View = View.Details;
            selected_files.MultiSelect = false;
        }

        private void Pdfmerge_button(object sender, EventArgs e)
        {

            //List<string> files_toimport = Pdfmerge_class.GetPdfFiles(location);
           // Pdfmerge_class.Merge(files_toimport, location);
            Pdfmerge_class.selectedListMerge(selected_files.Items, location);

        }

        private void directory_textbox_TextChanged(object sender, EventArgs e)
        {
            location = directory_textbox.Text;
        }

        private void select_files_Click(object sender, EventArgs e)
        {
         
            selected_files.Items.AddRange(Files_browser.selectFiles());
        }

        private void selected_files_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected_files.Items.Clear();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                int currentIndex = selected_files.SelectedItems[0].Index;
                ListViewItem item = selected_files.Items[currentIndex];
                if (currentIndex > 0)
                {
                    selected_files.Items.RemoveAt(currentIndex);
                    selected_files.Items.Insert(currentIndex - 1, item);
                }
            }
            catch { }
          
        }

        private void moveDown_button_Click(object sender, EventArgs e)
        {
            try
            {
                int maxIndex = selected_files.Items.Count;
                int currentIndex = selected_files.SelectedItems[0].Index;
                ListViewItem item = selected_files.Items[currentIndex];
                if (currentIndex + 1 < maxIndex)
                {
                    selected_files.Items.RemoveAt(currentIndex);
                    selected_files.Items.Insert(currentIndex + 1, item);
                }
            }
            catch { }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int currentIndex = selected_files.SelectedItems[0].Index;
                ListViewItem item = selected_files.Items[currentIndex];
                selected_files.Items.RemoveAt(currentIndex);        
            }
            catch { }
        }

        private void addImage_button_Click(object sender, EventArgs e)
        {
            Pdfmerge_class.selectedListAddGraphic(selected_files.Items);
        }
    }
 }
