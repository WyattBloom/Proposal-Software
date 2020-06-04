using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Smartsheet.Api.Models;
using System.Security.Cryptography.X509Certificates;

namespace JobEnter
{
    public partial class VerifyConditions : UserControl
    {
        public VerifyConditions()
        {
            InitializeComponent();
        }

        private void VerifyConditions_Load(object sender, EventArgs e)
        {
        }

        public void addToBox(String txtToAdd)
        {
            if(txtToAdd != null) 
                lbox1.Items.Add(txtToAdd);
        }

        public void addToBox(List<String> listToAdd)
        {
            foreach(String s in listToAdd)
            {
                lbox1.Items.Add(s);
            }
        }

        public List<String> getTextFromBox()
        {
            List<String> returnList = new List<String>();

            foreach (int i in lbox1.Items)
            {
                returnList.Add(lbox1.GetItemText(i));
            }

            return returnList;
        }

        public void clearBox()
        {
            lbox1.Items.Clear();
        }

        public void saveToFile(String address)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            String folderName = "Proposal for Services at " + address;
            createFolder(folderPath, folderName);
        }


        public void createFolder(String path, String fileName)
        {
            if(!Directory.Exists(path + "/" + fileName))
            {
                //Create a folder on the desktop 
                Create_Folder folder2 = new Create_Folder(path, fileName);
                folder2.createFolder();
            }
            else
            {
                MessageBox.Show("Folder already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
