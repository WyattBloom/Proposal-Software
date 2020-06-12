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
using Microsoft.Office.Interop.Word;
using System.Runtime.Serialization.Formatters;
using System.Text.RegularExpressions;


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

                    String templateName = getTemplateName(jobType1.getSelectedButton());
                    Console.WriteLine(templateName);

                    
                    if (absoluteFolderPath == null)
                        break;
                    else
                    {
                        if (!saveToWord(absoluteFolderPath, templateName))
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

        private void btnSaved()
        {

        }

        private String getTemplateName(String selected)
        {
            switch (selected)
            {
                case "One Stake":
                    return "StakingTemplate.docx";
                case "Two Stake":
                    return "StakingTemplate.docx";
                case "All Stake":
                    return "StakingTemplate.docx";
                case "Proposed":
                    return "Proposal Template.docx";
                case "New Home":
                    return "StakingTemplate.docx";
                case "Addition":
                    return "Additions Template.docx";
            }
            return null;
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

        private Boolean saveToWord(String absoluteFolderPath, String fileType)
        {
            try
            {
                if (clientInfo1.Address != "")
                {
                    String absoluteFilePath = absoluteFolderPath + "\\Proposal For Services at " + clientInfo1.Address;

                    CreateWordDoc doc1 = new CreateWordDoc(Directory.GetCurrentDirectory() + "\\" + fileType, absoluteFilePath);
                    doc1.CreateDocument();
                    FindAndReplaceTemplate(doc1);
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


        private void FindAndReplaceTemplate(CreateWordDoc doc1)
        {
            try
            {
                FindAndReplace_ClientInfo(doc1);
                FindAndReplace_ServicesAndTitles(doc1);

            }catch(System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FindAndReplace_ClientInfo(CreateWordDoc doc1)
        {
            try
            {
                //Find and replace
                if (clientInfo1.Name      != null) { doc1.FindAndReplace("<name>",       clientInfo1.Name); }
                if (clientInfo1.Address   != null) { doc1.FindAndReplace("<address>",    clientInfo1.Address); }
                if (clientInfo1.Number    != null) { doc1.FindAndReplace("<phone>",      clientInfo1.Number); }
                if (clientInfo1.Email     != null) { doc1.FindAndReplace("<email>",      clientInfo1.Email); }
                if (verifyPage.Price      != null) { doc1.FindAndReplace("<price>",      verifyPage.Price); }
                if (verifyPage.StakePrice != null) { doc1.FindAndReplace("<stakePrice>", verifyPage.StakePrice); }
                if (verifyPage.Days       != null) { doc1.FindAndReplace("<days>",       verifyPage.Days); }

                if (clientInfo1.SpecialInstructions == "")
                    doc1.FindAndReplace("<instructions>", "None");
                else
                    doc1.FindAndReplace("<instructions>", clientInfo1.SpecialInstructions);

            }catch(System.Exception ex)
            {
                Console.WriteLine("Error 5");
            }
        }

        private void FindAndReplace_ServicesAndTitles(CreateWordDoc doc1)
        {
            try
            {
                List<String> titles = selectServices1.getSelectedStrings();
                List<String> selectedTitles = selectServices1.getSelectedTitles();
                List<String> nonTitles = selectServices1.getNotTitles();

                List<String> titlesAndServices = selectServices1.getTitlesAndList();
                for(int i = 0; i < titlesAndServices.Count -1; i++)
                {
                    if (titlesAndServices[i].StartsWith("-"))
                    {
                        Console.WriteLine("S: " + titlesAndServices[i]);
                        Console.WriteLine("S + 1: " + titlesAndServices[i+1]);

                        if (titlesAndServices[i + 1] == "")
                        {
                            var result = titlesAndServices[i].Substring(titlesAndServices[i].LastIndexOf("-") + 1);
                            replaceTitles(doc1, result, titlesAndServices[i + 1], "");
                        }
                        else
                        {
                            var result = titlesAndServices[i].Substring(titlesAndServices[i].LastIndexOf("-") + 1);

                            System.Windows.Forms.Clipboard.SetText(titlesAndServices[i + 1]);
                            replaceTitles(doc1, result, "^c^p", result + "^p");
                        }

                    }
                }
            }catch(System.Exception ex)
            {
                Console.WriteLine("Error 4. " + ex.Message);
            }
        }

        private void replaceTitles(CreateWordDoc doc1, String titleIn, String servicesIn, String replaceWith)
        {
            switch (titleIn)
            {
                case "Building and Improvements":
                    //Console.WriteLine("Build: " + titleIn + " | " + replaceWith);
                    doc1.FindAndReplace("<build/improveHeader>", replaceWith);
                    doc1.FindAndReplace("<build/improveBody>", servicesIn);
                    break;
                case "Utilities":
                    //Console.WriteLine("Utilities:" + titleIn + " | " + replaceWith);
                    doc1.FindAndReplace("<utilHeader>", replaceWith);
                    doc1.FindAndReplace("<utilBody>", servicesIn);
                    break;
                case "Natural Features":
                    //Console.WriteLine("Natural: " + titleIn + " | " + replaceWith);
                    doc1.FindAndReplace("<naturalHeader>", replaceWith);
                    doc1.FindAndReplace("<naturalBody>", servicesIn);
                    break;
                case "New Home":
                    doc1.FindAndReplace("<additionHeader>", replaceWith);
                    doc1.FindAndReplace("<additionBody>", servicesIn);
                    break;
                case "Storm Water":
                    doc1.FindAndReplace("<stormWaterHeader>", replaceWith);
                    doc1.FindAndReplace("<stormWaterBody>", servicesIn);
                    break;
                case "Hardcover Note":
                    //Console.WriteLine("Hardcover: " + titleIn + " | " + replaceWith);
                    break;
                case "":
                    break;
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (String s in selectServices1.getTitlesAndList())
            {
                Console.WriteLine(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void newJobEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientInfo1.clearAll();
            jobType1.setSelectedButton("");
            selectServices1.clearAll();
            verifyPage.clearAll();
            // Code to clear everything for a new job entry
        }

        private void changeAccessTokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set1.Show();
        }
    }
}
