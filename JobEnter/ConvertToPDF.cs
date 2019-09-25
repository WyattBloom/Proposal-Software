using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;


namespace JobEnter
{
    class ConvertToPDF
    {
        Microsoft.Office.Interop.Word.Document wordDoc { get; set; }
        private string fileToConvert;
        private string saveToPath;
        private string pdfName;
        private string saveLocation;

        public ConvertToPDF(string fileToConvert, string pdfName, string saveLocation)
        {
            this.fileToConvert = fileToConvert;
            this.pdfName = pdfName;
            this.saveLocation = saveLocation;
            saveToPath = saveLocation + "\\" + pdfName;
        }


        /*
        * Creates a pdf copy of the word file 
        * pdfFileName: Path and file name of the PDF file with the extension address on the desktop
        * pdfInFolder: Path and file name of the pdf file in the Folder
        */
        public void convertToPDF()
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            wordDoc = app.Documents.Open(fileToConvert, ReadOnly: true);
            wordDoc.ExportAsFixedFormat(saveToPath, WdExportFormat.wdExportFormatPDF);

            wordDoc.Close(WdSaveOptions.wdDoNotSaveChanges);
            app.Quit();
        }
    }
}
