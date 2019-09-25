using System;
using System.Deployment.Application;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;


namespace JobEnter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Microsoft.Office.Interop.Word.Document wordDoc { get; set; }


        string savedAddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        int sideVCorner;
        string saveFolder = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            boxStakePrice.Text = "35";
            txtDays.Text = "7-10";
            boxPrice.Text = "500";

        }

        string desktopLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string address;             //Name of the File
        string fileOnDesktop;       //Path on File on Desktop
        string folderOnDesktop;     //Path of Folder on Desktop
        string fileInFolder;        //Path of File in Folder
        string pdfInFolder;         //Path of PDF in Folder
        string nameOfFile;          //Name of File with extension
        string nameOfPDF;           //Name of PDF with extension
        string CTFTomFrom;
        string CTFWayneFrom;
        private void button1_Click_1(object sender, EventArgs e)
        {
            address = "Proposal for services at " + boxAddress.Text;
            nameOfFile = address + ".docx";
            nameOfPDF = address + ".pdf";
            folderOnDesktop = desktopLocation +  "\\" + boxAddress.Text;
            fileOnDesktop = desktopLocation + "\\" + nameOfFile;
            fileInFolder = folderOnDesktop + "\\" + nameOfFile;
            pdfInFolder = folderOnDesktop + "\\" + nameOfPDF;
            

            Form4 f4 = new Form4(1);
            f4.Show();

            if (boxAddress.Text != "")
            {
                //Checks if the File already exists and exits if true
                if (Directory.Exists(folderOnDesktop))
                    //File.Exists(folderOnDesktop) ? true : false)
                {
                    f4.Dispose();
                    MessageBox.Show("File Already exists on desktop.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Create a folder on the desktop 
                Create_Folder folder2 = new Create_Folder(desktopLocation, folderOnDesktop);
                folder2.createFolder();

                //Get the directory two up
                DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
                string directory = Directory.GetCurrentDirectory(); //Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;

                //Create a word doc on the desktop
                CreateWordDoc doc1 = new CreateWordDoc(directory + "\\StakingTemplate.docx", fileOnDesktop);
                FindAndReplace(doc1);
                doc1.closeAndSave();

                //Move File from Desktop to Folder
                moveFolder(fileOnDesktop, fileInFolder);

                if (fileInFolder != null)
                {
                    //Open File for edits
                    openFile(fileInFolder);

                    FileInfo fi1 = new FileInfo(fileInFolder);
                    while (checkFileStatus(fi1))
                    {
                        label16.Text = "I got stuck in a loop";
                    }
                }
                label16.Text = "File Not In Use";

                //Convert the Word document to a PDF File
                ConvertToPDF converter = new ConvertToPDF(fileInFolder, nameOfPDF, folderOnDesktop);
                converter.convertToPDF();

                //Get the location of the Certification Letters
                CTFTomFrom = directory + "\\TomCTFLetter.docx";
                CTFWayneFrom = directory + "\\WayneCTFLetter.docx";
                string CTFTomTo = folderOnDesktop + "\\TomCTFLetter.docx";
                string CTFTomPDF = "\\TomCTFLetter.pdf";
                string CTFWayneTo = folderOnDesktop + "\\WayneCTFLetter.docx";
                string CTFWaynePDF = "\\WayneCTFLetter.pdf";

                 string CTFSaveToTom = folderOnDesktop;
                 CreateWordDoc doc2 = new CreateWordDoc(CTFTomFrom, CTFTomTo);
                 FindAndReplaceCertif(doc2);
                 doc2.closeAndSave();

                 //Convert the Word document to a PDF File
                 ConvertToPDF converter1 = new ConvertToPDF(CTFTomTo, CTFTomPDF, folderOnDesktop);
                 converter1.convertToPDF();

                 string CTFSaveToWayne = folderOnDesktop;
                 CreateWordDoc doc3 = new CreateWordDoc(CTFWayneFrom, CTFWayneTo);
                 FindAndReplaceCertif(doc3);
                 doc3.closeAndSave();

                 //Convert the Word document to a PDF File
                 ConvertToPDF converter2 = new ConvertToPDF(CTFWayneTo, CTFWaynePDF, folderOnDesktop);
                 converter2.convertToPDF();


                f4.Dispose();
                MessageBox.Show("Folder Created");


                //Open Outlook Window
                string[] name = boxName.Text.Split(' ');
                SendEmail sendEmail = new SendEmail(boxEmail.Text, "info@advsur.com", address, "Hi " + name[0] + "-\nAttached is the proposal you requested.  Please let me know if you have any questions or if you would like to be added to our schedule. \n\nThank you for the opportunity.\n", pdfInFolder, null);
                sendEmail.openOutlookWindow();
                
                label5.Text = saveFolder;
                label8.Text = fileOnDesktop;
                label12.Text = fileInFolder;
                label10.Text = pdfInFolder;
            }
            else
                MessageBox.Show("Please Enter an Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void FindAndReplace(CreateWordDoc doc1)
        {
            doc1.CreateDocument();

            //Find and replace
            doc1.FindAndReplace("<name>", boxName.Text);
            doc1.FindAndReplace("<address>", boxAddress.Text);
            doc1.FindAndReplace("<phone>", boxPhone.Text);
            doc1.FindAndReplace("<email>", boxEmail.Text);
            doc1.FindAndReplace("<price>", boxPrice.Text);
            doc1.FindAndReplace("<days>", txtDays.Text);
            doc1.FindAndReplace("<stakePrice>", boxStakePrice.Text);

            //Corner = 1, Side = 2, All = 0
            if (sideVCorner == 1)
            {
                doc1.FindAndReplace("<corner>", boxCorner.Text);
                doc1.FindAndReplace("<CornerSideAll>", "the " + boxCorner.Text.ToLower() + " corner");
            }
            if (sideVCorner == 2)
            {
                doc1.FindAndReplace("<corner>", boxSide.Text);
                doc1.FindAndReplace("<CornerSideAll>", boxSide.Text.ToLower() + " corners");
            }
            if (sideVCorner == 0)
            {
                doc1.FindAndReplace("<corner>", "All corners");
                doc1.FindAndReplace("<CornerSideAll>", "all the property corners");
            }

            if (boxInstructions.Text != "")
                doc1.FindAndReplace("<instructions>", boxInstructions.Text);
            else
                doc1.FindAndReplace("<instructions>", "None");

        }

        private void FindAndReplaceCertif(CreateWordDoc doc1)
        {
            doc1.CreateDocument();

            //Find and replace
            doc1.FindAndReplace("<name>", boxName.Text);
            doc1.FindAndReplace("<address>", boxAddress.Text);
        }



        private void openFile(string fileLocation)
        {
            try
            {
                if (fileLocation != null)
                {
                    Word.Application ap = new Word.Application();
                    Word.Document document = ap.Documents.Open(fileLocation);
                    ap.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Opening File was did not work: " + ex.Message);
            }
        }
        
        private void copyFile(string fileName, string sourcePath, string targetPath)
        {
            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder. 
            // If the directory already exists, this method does not create a new directory.
            System.IO.Directory.CreateDirectory(targetPath);
        
            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        
        }


        private void moveFolder(string sourceFile, string toFile)
        {
            //Move file from Dektop to folder
            try
            {
                File.Move(sourceFile, toFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Folder already exists on Desktop. " + ex.Message);
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

        private void rbtnTwo_CheckedChanged(object sender, EventArgs e)
        {
            //Corner
            lblCorner.Visible = false;
            boxCorner.Visible = false;

            //Side
            boxSide.Visible = true;
            lblSide.Visible = true;

            //Save Button
            btnExistingCondition.Visible = false;
            btnSave.Visible = true;

            //Change Corner vs Side
            sideVCorner = 2;

            //Proposed/Existing/Addition Button
            btnProposedConditions.Visible = false;
            btnExistingCondition.Visible = false;
            btnAddition.Visible = false;
        }

        private void rbtnOne_CheckedChanged(object sender, EventArgs e)
        {
            //Corner
            lblCorner.Visible = true;
            boxCorner.Visible = true;

            //Side
            boxSide.Visible = false;
            lblSide.Visible = false;

            //Save Button
            btnExistingCondition.Visible = false;
            btnSave.Visible = true;

            //Change Corner vs Side
            sideVCorner = 1;

            //Proposed/Existing/Addition Button
            btnProposedConditions.Visible = false;
            btnExistingCondition.Visible = false;
            btnAddition.Visible = false;
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            //Corner
            lblCorner.Visible = false;
            boxCorner.Visible = false;

            //Side
            boxSide.Visible = false;
            lblSide.Visible = false;

            //Save Button
            btnExistingCondition.Visible = false;
            btnSave.Visible = true;

            //Change Corner vs Side
            sideVCorner = 0;

            //Proposed/Existing/Addition Button
            btnProposedConditions.Visible = false;
            btnExistingCondition.Visible = false;
            btnAddition.Visible = false;
        }

        private void rbtnFull_CheckedChanged(object sender, EventArgs e)
        {
            //Corner
            lblCorner.Visible = false;
            boxCorner.Visible = false;

            //Side
            boxSide.Visible = false;
            lblSide.Visible = false;

            //Save Button
            btnExistingCondition.Visible = true;
            btnSave.Visible = false;

            //Proposed/Existing/Addition Button
            btnProposedConditions.Visible = false;
            btnExistingCondition.Visible = false;
            btnAddition.Visible = false;
        }



        /*
         * Opens the form for another template. Passes all job information to it.
         */
        private void btnExistingCondition_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(boxName.Text, boxAddress.Text, boxPhone.Text, boxEmail.Text, boxInstructions.Text, txtDays.Text, boxStakePrice.Text, cmbBoxExisting.Text, null);
            frm2.Show();
        }

        private void btnProposedConditions_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(boxName.Text, boxAddress.Text, boxPhone.Text, boxEmail.Text, boxInstructions.Text, txtDays.Text, boxStakePrice.Text, cmbBoxExisting.Text, null);
            frm5.Show();
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            UpdateCheckInfo info;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application can't be downloaded at this time.");
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Can't check for a new version of the application. The ClickOne deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application can't be updated. It's likely not a ClickOne application. Error: " + ioe.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (info.UpdateAvailable)
                {
                    if (MessageBox.Show("A newer version is available. Would you like to update it now?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ad.Update();
                            //Application.Restart();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("You are running the latest version.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Folder folder1 = new Create_Folder(desktopLocation, "This is a test");
            folder1.createFolder();
        }

        private void RbtnProposed_CheckedChanged(object sender, EventArgs e)
        {
            //Proposed/Existing/Addition Button
            btnProposedConditions.Visible = true;
            btnExistingCondition.Visible = false;
            btnAddition.Visible = false;
            
            //Corner
            lblCorner.Visible = false;
            boxCorner.Visible = false;

            //Side
            boxSide.Visible = false;
            lblSide.Visible = false;
        }

        private void RbtnExisting_CheckedChanged(object sender, EventArgs e)
        {
            //Proposed/Existing/Addition Button
            btnProposedConditions.Visible = false;
            btnExistingCondition.Visible = true;
            btnAddition.Visible = false;

            //Corner
            lblCorner.Visible = false;
            boxCorner.Visible = false;

            //Side
            boxSide.Visible = false;
            lblSide.Visible = false;
        }

        private void RbtnAddition_CheckedChanged(object sender, EventArgs e)
        {
            //Proposed/Existing/Addition Button
            btnProposedConditions.Visible = false;
            btnExistingCondition.Visible = false;
            btnAddition.Visible = true;

            //Corner
            lblCorner.Visible = false;
            boxCorner.Visible = false;

            //Side
            boxSide.Visible = false;
            lblSide.Visible = false;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = "";
            switch (selected)
            {
                case "One Stake":
                    //Proposed/Existing/Addition Button
                    btnProposedConditions.Visible = false;
                    btnExistingCondition.Visible = false;

                    //Corner
                    lblCorner.Visible = true;
                    boxCorner.Visible = true;

                    //Side
                    boxSide.Visible = false;
                    lblSide.Visible = false;

                    //Save Button
                    btnExistingCondition.Visible = false;
                    btnSave.Visible = true;

                    btnProposedConditions.Visible = false;
                    btnExistingCondition.Visible = false;

                    //Change Corner vs Side
                    sideVCorner = 1;
                    break;
                case "Two Stake":
                    //Proposed/Existing/Addition Button
                    btnProposedConditions.Visible = false;
                    btnExistingCondition.Visible = false;

                    //Corner
                    lblCorner.Visible = false;
                    boxCorner.Visible = false;

                    //Side
                    boxSide.Visible = true;
                    lblSide.Visible = true;

                    //Save Button
                    btnExistingCondition.Visible = false;
                    btnSave.Visible = true;

                    btnProposedConditions.Visible = false;
                    btnExistingCondition.Visible = false;

                    //Change Corner vs Side
                    sideVCorner = 2;
                    break;
                case "All Stake":
                    //Proposed/Existing/Addition Button
                    btnProposedConditions.Visible = false;
                    btnExistingCondition.Visible = false;

                    //Corner
                    lblCorner.Visible = false;
                    boxCorner.Visible = false;

                    //Side
                    boxSide.Visible = false;
                    lblSide.Visible = false;

                    //Save Button
                    btnExistingCondition.Visible = false;
                    btnSave.Visible = true;

                    btnProposedConditions.Visible = false;
                    btnExistingCondition.Visible = false;

                    //Change Corner vs Side
                    sideVCorner = 0;
                    break;
                case "Full Job":
                    //Proposed/Existing/Addition Button
                    btnProposedConditions.Visible = false;
                    btnExistingCondition.Visible = false;

                    //Corner
                    lblCorner.Visible = false;
                    boxCorner.Visible = false;

                    //Side
                    boxSide.Visible = false;
                    lblSide.Visible = false;

                    //Save Button
                    btnExistingCondition.Visible = true;
                    btnSave.Visible = false;
                    break;
                case "Proposed":
                    //Proposed/Existing/Addition Button
                    btnProposedConditions.Visible = true;
                    btnExistingCondition.Visible = false;
                    btnAddition.Visible = false;

                    //Corner
                    lblCorner.Visible = false;
                    boxCorner.Visible = false;

                    //Side
                    boxSide.Visible = false;
                    lblSide.Visible = false;
                    break;
                case "Existing":
                    //Proposed/Existing/Addition Button
                    btnProposedConditions.Visible = false;
                    btnExistingCondition.Visible = true;
                    btnAddition.Visible = false;

                    //Corner
                    lblCorner.Visible = false;
                    boxCorner.Visible = false;

                    //Side
                    boxSide.Visible = false;
                    lblSide.Visible = false;
                    break;
                case "Addition":
                    //Proposed/Existing/Addition Button
                    btnProposedConditions.Visible = false;
                    btnExistingCondition.Visible = false;
                    btnAddition.Visible = true;

                    //Corner
                    lblCorner.Visible = false;
                    boxCorner.Visible = false;

                    //Side
                    boxSide.Visible = false;
                    lblSide.Visible = false;
                    break;
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6(boxName.Text, boxAddress.Text, boxPhone.Text, boxEmail.Text, boxInstructions.Text, txtDays.Text, boxStakePrice.Text, cmbBoxExisting.Text, boxPrice.Text, null);
            frm6.Show();
        }
    }
}