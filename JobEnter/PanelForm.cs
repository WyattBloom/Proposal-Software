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
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Outlook;
using System.ServiceModel.Description;
using System.Security.Cryptography;
using Microsoft.Office.Interop.Word;
using System.Runtime.Serialization.Formatters;
using System.Text.RegularExpressions;
using System.Web.Caching;

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
        private String jobType;
        String currentDIR = Environment.CurrentDirectory;


        private int count = 0;

        private Settings set1 = new Settings();
        #endregion


        private void PanelForm_Load(object sender, EventArgs e)
        {
            // Spam Sheet Access Token : zja8p39vwwxywjoch3nuwpy1de
            // Spam Name               : TestSheet1 
            // Advsur API Key          : b2j1a696p2uyqw8apn44s3vpiq
            // Advsur Landing Page ID  : 3637774839506820
            // Advsur Landing Page Name: Landing Page 2020
            set1.AccessToken = "b2j1a696p2uyqw8apn44s3vpiq";
            set1.SheetName = "Landing Page 2020";
            count = 0;
        }


        public String getSaveDialog(String address)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.Description = "Select folder to save to";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                //String folderName = "Proposal for Services at " + address;
                String folderName = clientInfo1.Address + " " + clientInfo1.City;
                Console.WriteLine("Folder: " + folderName);
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
            showHide(count);
        }

        private void btnPricingPage_Click(object sender, EventArgs e)
        {
            count = 3;
            showHide(count);
        }

        private void showHide(int num)
        {
            this.jobType = jobType1.getSelectedButton();
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
                    verifyPage.Visible  = false;
                    clientInfo1.Visible = false;
                    jobType1.Visible    = false;

                    // Set dropdown box City and Checkbox List items
                    selectServices1.setComboSelected(clientInfo1.City);
                    selectServices1.setJobType(jobType1.getSelectedButton());
                    selectServices1.setBoxesShown();

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
                                        clientInfo1.CountyBox,
                                        clientInfo1.City,
                                        clientInfo1.SpecialInstructions);
                    
                    btnNext.Text = "Save";
                    break;
                case 4:
                    count = 3;

                    //-------Make sure all necessary information is filled in-------
                    //if(verifyConditions() == false)
                    //{
                    //    break;
                    //}
                    //========================================================
                    
                    verifyPage.addToBox("Saving...");
                    
                    // Location Strings
                    String absoluteFolderPath = getSaveDialog(clientInfo1.Address);
                    String absoluteFilePath   = absoluteFolderPath + "\\Proposal For Services at " + clientInfo1.Address;
                    String pdfPath            = absoluteFilePath + ".pdf";
                    String templateName       = getTemplateName(jobType1.getSelectedButton());

                    if (templateName == null)
                    {
                        MessageBox.Show("Could not find template file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        verifyPage.addToBox("Error");
                        break;
                    }

                    //--------------Save to File-----------------------------
                    if (absoluteFolderPath == null)
                        break;
                    else
                    {
                        switch (jobType1.getSelectedButton())
                        {
                            case "ALTA":
                                if (!FindAndReplace_ALTA(getTemplateName(jobType1.getSelectedButton()), absoluteFilePath))
                                    break;
                                else
                                    verifyPage.addToBox("File saved successfully");
                                break;
                            case "One Stake":
                                goto case "All Stake";
                            case "Two Stake":
                                goto case "All Stake";
                            case "All Stake":
                                if (!FindAndReplace_Staking(getTemplateName(jobType1.getSelectedButton()), absoluteFilePath))
                                    break;
                                else
                                    verifyPage.addToBox("File saved successfully");
                                break;
                            default:
                                if (!saveToWord(absoluteFolderPath, templateName, absoluteFilePath))
                                    break;
                                else
                                    verifyPage.addToBox("File saved successfully");
                                break;
                        }
                    }
                    /*
                    //=====================================================


                    //--------------Add CTF Letter to folder--------------
                    this.addCTFLetter(absoluteFolderPath);
                    //====================================================


                    //---------------Open File for Editing-------------
                    openFile(absoluteFilePath + ".docx");

                    FileInfo fi1 = new FileInfo(absoluteFilePath + ".docx");
                    while (checkFileStatus(fi1))
                    { }
                    //=================================================
                    

                    //--------------Convert Word document to PDF----------
                    ConvertToPDF converter = new ConvertToPDF(absoluteFilePath, pdfPath, absoluteFolderPath);
                    converter.convertToPDF();
                    //====================================================


                    //-------------------Open Draft in Outlook--------------
                    string[] name = clientInfo1.Name.Split(' ');
                    SendEmail sendEmail = new SendEmail(clientInfo1.Email, "info@advsur.com", clientInfo1.Address, "Hi " + name[0] + "-\nAttached is the proposal you requested.  Please let me know if you have any questions or if you would like to be added to our schedule. \n\nThank you for the opportunity.\n", pdfPath, null);
                    sendEmail.openOutlookWindow();
                    //======================================================

                    //----------------Add row to Smartsheet-----------------
                    verifyPage.addToBox("Adding to Smartsheet...");
                    updateAPI();
                    verifyPage.addToBox("Done");
                    //======================================================
                    */
                    break;
            }
        }

        private void getALTAStrings()
        {
            foreach(String s in selectServices1.getSelectedServices())
            {
                String[] outStr = s.Split(']');
                Console.WriteLine(outStr.First());
            }
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
            catch (System.Exception ex)
            {
                MessageBox.Show("Opening File was did not work: " + ex.Message);
            }
        }

        public Boolean verifyConditions()
        {
            if (clientInfo1.Address == "")
            {
                count = 0;
                showHide(count);
                MessageBox.Show("Please Enter a Address", "Address String Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (clientInfo1.City == "")
            {
                count = 0;
                showHide(count);
                MessageBox.Show("Please Enter a City", "City String Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (jobType1.getSelectedButton() == null)
            {
                count = 1;
                showHide(count);
                MessageBox.Show("Please Select a Job Type", "Job Type Null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
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
                    return Path.Combine(currentDIR, "Templates", "StakingTemplate.docx");
                case "Two Stake":
                    return Path.Combine(currentDIR, "Templates", "StakingTemplate.docx");
                case "All Stake":
                    return Path.Combine(currentDIR, "Templates", "StakingTemplate.docx");
                case "Proposed":
                    return Path.Combine(currentDIR, "Templates", "Proposal Template.docx");
                case "New Home":
                    return Path.Combine(currentDIR, "Templates", "New Home Template.docx");
                case "Addition":
                    return Path.Combine(currentDIR, "Templates", "Additions Template.docx");
                case "Full":
                    return Path.Combine(currentDIR, "Templates", "fullTemplate.docx");
                case "Plat":
                    return Path.Combine(currentDIR, "Templates", "Plat Template.docx");
                case "ALTA":
                    return Path.Combine(currentDIR, "Templates", "ALTA Template.docx");
                default:
                    return null;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private Boolean FindAndReplace_Staking(String templateName, String filePath)
        {
            try
            {
                CreateWordDoc doc1 = new CreateWordDoc(Path.Combine(currentDIR, templateName), filePath);
                doc1.CreateDocument();

                FindAndReplace_ClientInfo(doc1);

                doc1.FindAndReplace("<corner>", stakingPage1.Corner);
                doc1.FindAndReplace("<stakePrice>", stakingPage1.STKPRice);
                doc1.FindAndReplace("<CornerSideAll>", stakingPage1.Corner);

                doc1.closeAndSave();

                return true;
            }catch(System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }



        private Boolean FindAndReplace_ALTA(String templateName, String filePath)
        {
            try
            {
                CreateWordDoc doc1 = new CreateWordDoc(Path.Combine(currentDIR, templateName), filePath);
                String[] numbers = new String[] { "1", "2", "3", "4", "5", "6A", "6B", "7A", "7B", "7C", "8",
                                              "9", "10A", "10B", "11", "12", "13", "14", "15", "16", "17",
                                              "18", "19", "20", "21" };
                doc1.CreateDocument();

                doc1.FindAndReplace("<address>", clientInfo1.Address);
                doc1.FindAndReplace("<name>", clientInfo1.Name);
                doc1.FindAndReplace("<daysEST>", verifyPage.Days);
                doc1.FindAndReplace("<sumTotal>", verifyPage.Price);

                foreach (String s in selectServices1.getSelectedServices())
                {
                    String outStr = s.Split(']').First();
                    Console.WriteLine(outStr);
                    doc1.FindAndReplace("<" + outStr + ">", "Included");
                }
                foreach (String s in numbers)
                {
                    doc1.FindAndReplace("<" + s + ">", "Not Included");
                }

                doc1.closeAndSave();

                return true;

            }catch(SystemException ex)
            {
                return false;
            }
        }


        private Boolean saveToWord(String absoluteFolderPath, String fileType, String filePath)
        {
            try
            {
                CreateWordDoc doc1 = new CreateWordDoc(Path.Combine(currentDIR, fileType), filePath);
                doc1.CreateDocument();
                FindAndReplaceTemplate(doc1);
                doc1.closeAndSave();

                //______verifyPage.addToBox("Saved to: " + absoluteFilePath);_____
                return true;
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
                // Find and replace client info
                FindAndReplace_ClientInfo(doc1);
                // Find and replace selected services and titles
                FindAndReplace_ServicesAndTitles(doc1);
                this.cleanUp1(doc1);

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
                if (stakingPage1.STKPRice != null) { doc1.FindAndReplace("<stakePrice>", stakingPage1.STKPRice); }
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
                List<String> titles         = selectServices1.getSelectedStrings();
                List<String> selectedTitles = selectServices1.getSelectedTitles();
                List<String> nonTitles      = selectServices1.getNotTitles();

                List<String> titlesAndServices = selectServices1.getTitlesAndList();

                for(int i = 0; i <= titlesAndServices.Count -1; i++)
                {
                    Console.WriteLine(titlesAndServices[i]);
                    if (titlesAndServices[i].StartsWith("-"))
                    {
                        var result = titlesAndServices[i].Substring(titlesAndServices[i].LastIndexOf("-") + 1);
                        if (titlesAndServices[i + 1] == "")
                        {   
                            switch (jobType1.getSelectedButton())
                            {
                                case "Plat":
                                    replaceTitles_Plat(doc1, result, titlesAndServices[i + 1], "");
                                    break;
                                case "Addition":
                                    replaceTitles_Addition(doc1, result, titlesAndServices[i + 1], "");
                                    break;
                                case "New Home":
                                    replaceTitles_NewHome(doc1, result, titlesAndServices[i + 1], "");
                                    break;
                                default:
                                    replaceTitles(doc1, result, titlesAndServices[i + 1], "");
                                    break;                     
                            }
                        }
                        else
                        {
                            System.Windows.Forms.Clipboard.SetText(titlesAndServices[i + 1]);
                            switch (jobType1.getSelectedButton())
                            {
                                case "Plat":
                                    replaceTitles_Plat(doc1, result, "^c^p", result + "^p");
                                    break;
                                case "Addition":
                                    replaceTitles_Addition(doc1, result, "^c^p", result + "^p");
                                    break;
                                case "New Home":
                                    replaceTitles_NewHome(doc1, result, "^c^p", result + "^p");
                                    break;
                                default:
                                    replaceTitles(doc1, result, "^c^p", result + "^p");
                                    break;
                            }
                        }
                        
                    }
                }
                this.cleanUp1(doc1);
            }catch(System.Exception ex)
            {
                Console.WriteLine("Error 4. " + ex.Message);
            }
        }

        public String getPrice(String cityIn)
        {



            return "";
        }

        private void replaceTitles_Plat(CreateWordDoc doc1, String titleIn,
                                        String servicesIn, String replaceWith)
        {
            switch (titleIn)
            {
                case "General Items":

                    break;
                case "Building & Improvements":
                    doc1.FindAndReplace("<build/improveHeader>", replaceWith);
                    doc1.FindAndReplace("<build/improveBody>", servicesIn);
                    break;
                case "Utilities":
                    doc1.FindAndReplace("<utilHeader>", replaceWith);
                    doc1.FindAndReplace("<utilBody>", servicesIn);
                    break;
                case "Natural Features":
                    doc1.FindAndReplace("<naturalHeader>", replaceWith);
                    doc1.FindAndReplace("<naturalBody>", servicesIn);
                    break;
                case "Proposed Items":
                    doc1.FindAndReplace("<proposedHeader>", replaceWith);
                    doc1.FindAndReplace("<proposedBody>", servicesIn);
                    break;
                case "Lot Splits":
                    doc1.FindAndReplace("<lotSplitHeader>", replaceWith);
                    doc1.FindAndReplace("<lotSplitBody>", servicesIn);
                    break;
                case "SCOPE OF SERVICES [FINAL/RECORD PLAT]":
                    doc1.FindAndReplace("<PlatHeader>", replaceWith);
                    doc1.FindAndReplace("<PlatBody>", servicesIn);
                    break;
            }
        }

        private void replaceTitles_Addition(CreateWordDoc doc1, String titleIn,
                                        String servicesIn, String replaceWith)
        {
            switch (titleIn)
            {
                case "General Items":

                    break;
                case "Building & Improvements":
                    doc1.FindAndReplace("<build/improveHeader>", replaceWith);
                    doc1.FindAndReplace("<build/improveBody>", servicesIn);
                    break;
                case "Utilities":
                    doc1.FindAndReplace("<utilHeader>", replaceWith);
                    doc1.FindAndReplace("<utilBody>", servicesIn);
                    break;
                case "Natural Features":
                    doc1.FindAndReplace("<naturalHeader>", replaceWith);
                    doc1.FindAndReplace("<naturalBody>", servicesIn);
                    break;
                case "Addition":
                    doc1.FindAndReplace("<AdditionHeader>", replaceWith);
                    doc1.FindAndReplace("<AdditionBody>", servicesIn);
                    break;
                case "House Staking":
                    doc1.FindAndReplace("<StakingHeader>", replaceWith);
                    doc1.FindAndReplace("<StakingBody>", servicesIn);
                    break;
                case "Foundation as built":
                    doc1.FindAndReplace("<FoundationHeader>", replaceWith);
                    doc1.FindAndReplace("<FoundationBody>", servicesIn);
                    break;
                case "Final as built":
                    doc1.FindAndReplace("<FinalHeader>", replaceWith);
                    doc1.FindAndReplace("<FinalBody>", servicesIn);
                    break;
            }
        }

        private void replaceTitles_NewHome(CreateWordDoc doc1, String titleIn,
                                String servicesIn, String replaceWith)
        {
            Console.WriteLine("New Home");

            switch (titleIn)
            {
                case "General Items":

                    break;
                case "Building & Improvements":
                    doc1.FindAndReplace("<build/improveHeader>", replaceWith);
                    doc1.FindAndReplace("<build/improveBody>", servicesIn);
                    break;
                case "Utilities":
                    doc1.FindAndReplace("<utilHeader>", replaceWith);
                    doc1.FindAndReplace("<utilBody>", servicesIn);
                    break;
                case "Natural Features":
                    doc1.FindAndReplace("<naturalHeader>", replaceWith);
                    doc1.FindAndReplace("<naturalBody>", servicesIn);
                    break;
                case "New Homes":
                    doc1.FindAndReplace("<NewHomeHeader>", replaceWith);
                    doc1.FindAndReplace("<NewHomeBody>", servicesIn);
                    break;
                case "House Staking":
                    doc1.FindAndReplace("<StakingHeader>", replaceWith);
                    doc1.FindAndReplace("<StakingBody>", servicesIn);
                    break;
                case "Foundation as built":
                    doc1.FindAndReplace("<FoundationHeader>", replaceWith);
                    doc1.FindAndReplace("<FoundationBody>", servicesIn);
                    break;
                case "Final as built":
                    doc1.FindAndReplace("<FinalHeader>", replaceWith);
                    doc1.FindAndReplace("<FinalBody>", servicesIn);
                    break;
            }
        }


        /*
         * Addition(Edina)- Existing Condition: $1350
         * New Home(Edina)- Existing Condition: $1350
         * New Home 
         *      New Home: 
         *          Edina       - $900
         *          Minneapolis - $1000
         *      Final: 
         *          Edina - 
         *          Minneapolis - $600 
         *      Staking: 
         *          Edina        - $400
         *          Minneapolis  - $400
         *      Foundation: 
         *          Edina     - $300 
         *          Minneapolis - $300
         * Addition
         *      House Staking: $400
         *      Foundation: $350
         *      Final: $ 
         *      Edina:
         *          Stormwater: %600 - $1200
        */
        private void replaceTitles(CreateWordDoc doc1, String titleIn, 
                                String servicesIn, String replaceWith)
        {
            Console.WriteLine(titleIn);

            switch (titleIn)
            {
                case "Building and Improvements":
                    doc1.FindAndReplace("<build/improveHeader>", replaceWith);
                    doc1.FindAndReplace("<build/improveBody>", servicesIn);
                    break;
                case "Utilities":
                    doc1.FindAndReplace("<utilHeader>", replaceWith);
                    doc1.FindAndReplace("<utilBody>", servicesIn);
                    break;
                case "Natural Features":
                    doc1.FindAndReplace("<naturalHeader>", replaceWith);
                    doc1.FindAndReplace("<naturalBody>", servicesIn);
                    break;
                case "New Home":
                    doc1.FindAndReplace("<homesHeader>", replaceWith);
                    doc1.FindAndReplace("<homesBody>", servicesIn);
                    break;
                case "Additions":
                    doc1.FindAndReplace("<additionHeader>", replaceWith);
                    doc1.FindAndReplace("<additionBody>", servicesIn);
                    break;
                case "Edina Stuff":
                    doc1.FindAndReplace("<edinaHeader>", replaceWith);
                    doc1.FindAndReplace("<edinaBody>", servicesIn);
                    break;
                case "House Staking":
                    doc1.FindAndReplace("<stakingHeader>", replaceWith);
                    doc1.FindAndReplace("<stakingBody>", servicesIn);
                    break;
                case "Foundation as Built":
                    doc1.FindAndReplace("<foundationHeader>", replaceWith);
                    doc1.FindAndReplace("<foundationBody>", servicesIn);
                    break;
                case "Final as Built":
                    doc1.FindAndReplace("<finalHeader>", replaceWith);
                    doc1.FindAndReplace("<finalBody>", servicesIn);
                    break;
                case "Hardcover Note":
                    doc1.FindAndReplace("<hardnoteHeader>", replaceWith);
                    doc1.FindAndReplace("<hardnoteBody>", servicesIn);
                    break;
                case "DESIGN/DEVELOPMENT FOR A STORMWATER MANAGEMENT PLAN: $600 - $1200":
                    // Edina Specific
                    // DESIGN/DEVELOPMENT FOR A STORMWATER MANAGEMENT PLAN: $600 - $1200
                    doc1.FindAndReplace("<stormWaterHeader>", replaceWith);
                    doc1.FindAndReplace("<stormWaterBody>", servicesIn);
                    break;
                case "":
                    break;
            }
        }

        private void cleanUp1(CreateWordDoc doc1)
        {
            // Build/Improve
            doc1.FindAndReplace("<build/improveHeader>", "");
            doc1.FindAndReplace("<build/improveBody>", "");

            // Utilities
            doc1.FindAndReplace("<utilHeader>", "");
            doc1.FindAndReplace("<utilBody>", "");

            // Natural
            doc1.FindAndReplace("<naturalHeader>", "");
            doc1.FindAndReplace("<naturalBody>", "");

            // New Home
            doc1.FindAndReplace("<homesHeader>", "");
            doc1.FindAndReplace("<homesBody>", "");

            // Additions
            doc1.FindAndReplace("<additionHeader>", "");
            doc1.FindAndReplace("<additionBody>", "");

            // Edina
            doc1.FindAndReplace("<edinaHeader>", "");
            doc1.FindAndReplace("<edinaBody>", "");

            // Staking
            doc1.FindAndReplace("<stakingHeader>", "");
            doc1.FindAndReplace("<stakingBody>", "");

            // Foundation
            doc1.FindAndReplace("<foundationHeader>", "");
            doc1.FindAndReplace("<foundationBody>", "");

            // Final
            doc1.FindAndReplace("<finalHeader>", "");
            doc1.FindAndReplace("<finalBody>", "");

            // Hardcover Note
            doc1.FindAndReplace("<hardnoteHeader>", "");
            doc1.FindAndReplace("<hardnoteBody>", "");

            // Storm Water
            doc1.FindAndReplace("<stormwaterHeader>", "");
            doc1.FindAndReplace("<stormwaterBody>", "");

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

        private void addCTFLetter(String folderPath)
        {
            String destFileTom = System.IO.Path.Combine(folderPath, "TomCTF.docx");
            String destFileWayne = System.IO.Path.Combine(folderPath, "WayneCTF.docx");
            switch (verifyPage.getCTF())
            {
                case "Tom":
                    FindAndReplace_CTF(destFileTom, "Tom");
                    break;
                case "Wayne":
                    FindAndReplace_CTF(destFileWayne, "Wayne");
                    break;
                case "WayneTom":
                    FindAndReplace_CTF(destFileTom, "Tom");
                    FindAndReplace_CTF(destFileWayne, "Wayne");
                    break;
            }
        }

        private void FindAndReplace_CTF(String filePath, String surveyor)
        {
            try
            {
                if (surveyor == "Tom")
                {
                    Console.WriteLine("File: " + filePath);
                    CreateWordDoc docTom = new CreateWordDoc(Directory.GetCurrentDirectory() + "\\TomCTFLetter.docx", filePath);
                    docTom.CreateDocument();

                    //Find and replace
                    if (clientInfo1.Address != null) { docTom.FindAndReplace("<address>", clientInfo1.Address); }
                    if (this.jobType        != null) { docTom.FindAndReplace("<jobType>", jobType); }

                    docTom.closeAndSave();
                }
                else if (surveyor == "Wayne")
                {
                    Console.WriteLine("File: " + filePath);
                    CreateWordDoc docWayne = new CreateWordDoc(Directory.GetCurrentDirectory() + "\\WayneCTFLetter.docx", filePath);
                    docWayne.CreateDocument();

                    //Find and replace
                    if (clientInfo1.Address != null) { docWayne.FindAndReplace("<address>", clientInfo1.Address); }
                    if (this.jobType        != null) { docWayne.FindAndReplace("<jobType>", jobType); }

                    docWayne.closeAndSave();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
        }


        #endregion

        //======================================================================//
        #region PDF Methods




        #endregion

        //======================================================================//
        #region Email Methods




        #endregion

        //======================================================================//
        #region API Methods

        private void updateAPI()
        {
            try
            {
                APIRequests apiInstance = new APIRequests(set1.SheetName, set1.AccessToken,
                    verifyPage.getGIS(clientInfo1.CountyBox), clientInfo1.Name, clientInfo1.Email, 
                    clientInfo1.Address, clientInfo1.City, clientInfo1.CountyBox, verifyPage.Price, 
                    clientInfo1.Number, clientInfo1.SpecialInstructions, DateTime.Today);

                if (apiInstance.addRow())
                    MessageBox.Show("Row successfully added to smartsheet", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error in adding row to smartsheet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Unable to update Smartsheet: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (String s in selectServices1.getTitlesAndList())
            {
                Console.WriteLine(s);
            }
        }

        public String getGIS(String county)
        {
            String outVal = "";
            switch (county)
            {
                case "Hennepin":
                    outVal = "https://gis.hennepin.us/property/map/";
                    break;
                case "Ramsey":
                    outVal = "https://beacon.schneidercorp.com/application.aspx?app=RamseyCountyMN&PageType=Search";
                    break;
                case "Anoka":
                    outVal = "http://gis.anokacountymn.gov/webgis/#<http://gis.anokacountymn.gov/webgis";
                    break;
                case "Carver":
                    outVal = "https://gis.co.carver.mn.us/publicparcel/";
                    break;
                case "Washington":
                    outVal = "https://wcmn.maps.arcgis.com/apps/webappviewer/index.html?id=5c2fe2b598e744afbc07cc0550162984";
                    break;
                case "Dakota":
                    outVal = "https://gis.co.dakota.mn.us/DCGIS/";
                    break;
                case "Scott":
                    outVal = "https://gis.co.scott.mn.us/sg3/";
                    break;
                case "Sherburne":
                    outVal = "https://beacon.schneidercorp.com/?site=SherburneCountyMN";
                    break;
                case "Wright":
                    outVal = "https://beacon.schneidercorp.com/Application.aspx?App=WrightCountyMN";
                    break;
            }
            return outVal;
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
