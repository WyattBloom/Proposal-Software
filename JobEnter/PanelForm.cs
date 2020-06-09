using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Outlook;
using System.ServiceModel.Description;
using System.Security.Cryptography;

namespace JobEnter
{
    public partial class PanelForm : Form
    {
        public PanelForm()
        {
            InitializeComponent();
        }

        #region Variables

        private String name;
        private String number;
        private String address;
        private String email;
        private String city;
        private String state;
        private String zip;
        private String price;

        private int count = 0;

        private Settings set1 = new Settings();
        #endregion


        private void PanelForm_Load(object sender, EventArgs e)
        {
            set1.AccessToken = "zja8p39vwwxywjoch3nuwpy1de";
            set1.SheetName = "TestSheet1";
            count = 0;
        }


        public String saveToFile(String address)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.Description = "Select folder to save to";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                String folderName = "Proposal for Services at " + address;
                String finalFolderPath = createFolder(folderPath, folderName);
                return finalFolderPath;
            }
            else
            {
                Console.WriteLine("Unable to save to file");
                return null;
            }
        }


        public String createFolder(String path, String folderName)
        {
            if (!Directory.Exists(path + "\\" + folderName))
            {
                //Create a folder 
                Create_Folder folder2 = new Create_Folder(path, folderName);
                folder2.createFolder();
                return (path + "\\" + folderName);
            }
            else
            {
                MessageBox.Show("Folder already exists", "Error 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        #region Button Click Methods

        private int countMax = 4;

        private void btnClientInfo_Click(object sender, EventArgs e)
        {
            count = 0;
            showHide(count);
        }

        private void btnJobType_Click(object sender, EventArgs e)
        {
            count = 1;
            showHide(count);

            //jobType1.setSelectedButton(selectServices1.getJobType());
        }

        private void btnSelectServices_Click(object sender, EventArgs e)
        {
            count = 2;
            Console.WriteLine(clientInfo1.City);
            showHide(count);
        }

        private void btnPricingPage_Click(object sender, EventArgs e)
        {
            count = 3;
            showHide(count);
        }

        private void showHide(int num)
        {
            switch (num)
            {
                case 0:
                    clientInfo1.Visible = true;
                    selectServices1.Visible = false;
                    verifyPage.Visible = false;
                    jobType1.Visible = false;
                    stakingPage1.Visible = false;

                    btnNext.Text = "Next";
                    break;
                case 1:
                    jobType1.Visible = true;
                    clientInfo1.Visible = false;
                    verifyPage.Visible = false;
                    selectServices1.Visible = false;
                    stakingPage1.Visible = false;

                    btnNext.Text = "Next";
                    break;
                case 2:
                    if (jobType1.getSelectedButton() == "One Stake" ||
                        jobType1.getSelectedButton() == "Two Stake" ||
                        jobType1.getSelectedButton() == "All Stake")
                    {
                        stakingPage1.Visible = true;
                    }
                    else
                    {
                        selectServices1.Visible = true;
                    }
                    verifyPage.Visible = false;
                    clientInfo1.Visible = false;
                    jobType1.Visible = false;

                    // Set dropdown box City and Checkbox List items
                    selectServices1.setComboSelected(clientInfo1.City);
                    selectServices1.setBoxesShown(jobType1.getSelectedButton());

                    btnNext.Text = "Next";
                    break;
                case 3:
                    verifyPage.Visible = true;
                    selectServices1.Visible = false;
                    stakingPage1.Visible = false;
                    jobType1.Visible = false;
                    clientInfo1.Visible = false;

                    // Select all neccesary headers
                    selectServices1.selectHeaders();
                    verifyPage.clearBox();          // Clear old input

                    // Add all user information to box
                    verifyPage.addToBox(clientInfo1.Name,
                                        clientInfo1.Number,
                                        clientInfo1.Email,
                                        clientInfo1.Address,
                                        clientInfo1.State,
                                        clientInfo1.City,
                                        clientInfo1.Zip,
                                        clientInfo1.SpecialInstructions);
                    // Add titles to box
                    verifyPage.addToBox(selectServices1.getSelectedTitles());

                    btnNext.Text = "Save";
                    break;
                case 4:
                    count = 3;
                    verifyPage.addToBox("Saving...");
                    String absoluteFolderPath = saveToFile(clientInfo1.Address);
                    
                    Console.WriteLine("Here");
                    Console.WriteLine(absoluteFolderPath);
                    if (absoluteFolderPath == null)
                        break;
                    else
                    {
                        if (!saveToWord(absoluteFolderPath))
                            break;
                        else
                            verifyPage.addToBox("File saved successfully");
                    }

                    string CTFFile = getCTF("Tom");
                    String destFile = System.IO.Path.Combine(absoluteFolderPath, "CTFFile.docx");
                    File.Copy("TomCTFLetter.docx", destFile);


                    // updateAPI();

                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e) 
        {
            if (!(count + 1 > countMax))
                count++;
            else
                count = countMax;

            showHide(count);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (!(count - 1 < 0))
                count--;
            else
                count = 0;
            showHide(count);
        }


        #endregion

        #region Update Pages

        // Write methods that will be called when each page becomes visible
        // Ex. Set selected services label and city
        // .. Set Put all info into verify conditions


        #endregion

        #region Load Events

        private void verifyConditions1_Load(object sender, EventArgs e)
        {

        }


        private void verifyConditions2_Load(object sender, EventArgs e)
        {

        }

        private void selectServices1_Load(object sender, EventArgs e)
        {

        }

        #endregion



        #region Interacting with word document

        private Boolean saveToWord(String absoluteFolderPath)
        {
            try
            {
                if (clientInfo1.Address != "")
                {
                    String absoluteFilePath = absoluteFolderPath + "\\Proposal For Services at " + clientInfo1.Address;

                    CreateWordDoc doc1 = new CreateWordDoc(Directory.GetCurrentDirectory() + "\\StakingTemplate.docx", absoluteFilePath);
                    FindAndReplace(doc1);
                    doc1.closeAndSave();

                    //______verifyPage.addToBox("Saved to: " + absoluteFilePath);_____
                    return true;
                }
                else
                {
                    MessageBox.Show("Address must not be blank", "Error 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void FindAndReplace(CreateWordDoc doc1)
        {
            try
            {
                doc1.CreateDocument();

                //Find and replace
                if (clientInfo1.Name    != null) { doc1.FindAndReplace("<name>", clientInfo1.Name); }
                if (clientInfo1.Address != null) { doc1.FindAndReplace("<address>", clientInfo1.Address); }
                if (clientInfo1.Number  != null) { doc1.FindAndReplace("<phone>", clientInfo1.Number); }
                if (clientInfo1.Email   != null) { doc1.FindAndReplace("<email>", clientInfo1.Email); }
                if (clientInfo1.SpecialInstructions != null) { doc1.FindAndReplace("<price>", "TEMP VAL"); }
                if (clientInfo1.SpecialInstructions != null) { doc1.FindAndReplace("<days>", "TEMP VAL"); }
                if (clientInfo1.SpecialInstructions != null) { doc1.FindAndReplace("<stakePrice>", "TEMP VAL"); }

                if (clientInfo1.SpecialInstructions != "")
                    doc1.FindAndReplace("<instructions>", clientInfo1.SpecialInstructions);
                else
                    doc1.FindAndReplace("<instructions>", "None");
            }catch(System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region API Methods

        private void updateAPI()
        {
            try
            {
                APIRequests apiInstance = new APIRequests(set1.SheetName, set1.AccessToken,
                    clientInfo1.Name, clientInfo1.Email, clientInfo1.Address, clientInfo1.City,
                    clientInfo1.State, clientInfo1.Zip, verifyPage.Price, clientInfo1.Number, DateTime.Today);

                apiInstance.addRow();
                MessageBox.Show("Row successfully added to smartsheet", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Unable to update Smartsheet: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private String getCTF(String name)
        {
            String localTemplate;
            switch (name)
            {
                case "Tom":
                    localTemplate = "TomCTFLetter.docx";
                    break;
                case "Wayne":
                    localTemplate = "WayneCTFLetter.docx";
                    break;
                default:
                    return "";
            }
            return localTemplate;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            String absoluteFolderPath = saveToFile(clientInfo1.Address);

            string CTFFile = getCTF("Tom");
            Console.WriteLine("CTF: " + CTFFile + " | Absolute: " + absoluteFolderPath);

            String destFile = System.IO.Path.Combine(absoluteFolderPath, "CTFFile.docx");
            File.Copy("TomCTFLetter.docx", destFile);
        }

        private void newJobEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientInfo1.clearAll();
            jobType1.setSelectedButton("");
            selectServices1.clearAll();
            verifyPage.clearBox();
            // Code to clear everything for a new job entry
        }

        private void changeAccessTokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set1.Show();
        }
    }
}
