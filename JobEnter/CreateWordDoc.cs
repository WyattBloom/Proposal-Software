using System;
using System.Windows.Forms;
using System.IO;
using System.Deployment.Application;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace JobEnter
{
    class CreateWordDoc
    {
        private Word.Application wordApp = new Word.Application();
        private object missing = Missing.Value;
        private Word.Document myWordDoc = null;

        private object filename;
        private object SaveAs;

        public CreateWordDoc(object filename, object SaveAs)
        {
            this.filename = filename;
            this.SaveAs = SaveAs;
        }

        public void CreateDocument()
        {
            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();
            }
            else
            {
                MessageBox.Show("File Not Found!");
            }
        }

    public bool checkFileStatus(FileInfo fileName)
        {
            FileStream streamInput = null;

            try
            {
                streamInput = fileName.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException) { return true; }
            finally
            {
                if (streamInput != null)
                    streamInput.Close();
            }

            return false;
        }

        public void closeAndSave()
        {
            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);
            myWordDoc.Close();
            wordApp.Quit();
            //MessageBox.Show("File Created!");
        }

        public void FindAndReplace(object textToFind, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = true;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref textToFind,
                ref matchCase, ref matchWholeWord, ref matchWildCards,
                ref matchSoundLike, ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

    }

}
