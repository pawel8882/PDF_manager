using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDF_manager.PDFmerge
{

    internal class Files_browser
    {

        public static ListViewItem[] selectFiles()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "e:\\";
            openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               List<string> files = new List<string>(openFileDialog1.FileNames);

               return createListFromString(files);
            }
            return createListFromString(new List<string>());
        }

        private static ListViewItem[] createListFromString(List<string> strings)
        {
            List<ListViewItem> items = new List<ListViewItem>();

            foreach (string s in strings)
            {
                ListViewItem item = new ListViewItem(new string[] {Path.GetFileName(s), s});
                items.Add(item);
            }
            
            return items.ToArray<ListViewItem>();
        }
    }
}
