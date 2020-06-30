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
                    //selectServices1.setBoxesShown(jobType1.getSelectedButton());

                    selectServices1.setJobType(jobType1.getSelectedButton());
                    selectServices1.setBoxesShown();
                    selectServices1.selectCityBoxes(clientInfo1.City);

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
                    // Add titles to box
                    //verifyPage.addToBox(selectServices1.getSelectedTitles());

                    btnNext.Text = "Save";
                    break;
                case 4:
                    count = 3;

                    //-------Make sure all necessary information is filled in-------
                    if(verifyConditions() == false)
                    {
                        break;
                    }
                    //========================================================
                    
                    verifyPage.addToBox("Saving...");

                    // Location Strings
                    String absoluteFolderPath = getSaveDialog(clientInfo1.Address);
                    String absoluteFilePath   = absoluteFolderPath + "\\Proposal For Services at " + clientInfo1.Address;
                    String pdfPath            = absoluteFilePath + ".pdf";
                    String templateName = getTemplateName(jobType1.getSelectedButton());

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
                        if (!saveToWord(absoluteFolderPath, templateName, absoluteFilePath))
                            break;
                        else
                            verifyPage.addToBox("File saved successfully");
                    }
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

                    break;
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
                    return "StakingTemplate.docx";
                case "Two Stake":
                    return "StakingTemplate.docx";
                case "All Stake":
                    return "fullTemplate.docx";
                case "Proposed":
                    return "Proposal Template.docx";
                case "New Home":
                    return "Proposal Template.docx";
                case "Addition":
                    return "Additions Template.docx";
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

        private Boolean saveToWord(String absoluteFolderPath, String fileType, String filePath)
        {
            try
            {
                Console.WriteLine("File: " + filePath);
                CreateWordDoc doc1 = new CreateWordDoc(Directory.GetCurrentDirectory() + "\\" + fileType, filePath);
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
                List<String> titles         = selectServices1.getSelectedStrings();
                List<String> selectedTitles = selectServices1.getSelectedTitles();
                List<String> nonTitles      = selectServices1.getNotTitles();

                List<String> titlesAndServices = selectServices1.getTitlesAndList();
                for(int i = 0; i < titlesAndServices.Count -1; i++)
                {
                    if (titlesAndServices[i].StartsWith("-"))
                    {
                        //Console.WriteLine("S: " + titlesAndServices[i]);
                        //Console.WriteLine("S + 1: " + titlesAndServices[i+1]);

                        if (titlesAndServices[i + 1] == "")
                        {
                            var result = titlesAndServices[i].Substring(titlesAndServices[i].LastIndexOf("-") + 1);
                            replaceTitles(doc1, result, titlesAndServices[i + 1], "");

                            //Console.WriteLine(titlesAndServices[i + 1]);
                        }
                        else
                        {
                            var result = titlesAndServices[i].Substring(titlesAndServices[i].LastIndexOf("-") + 1);

                            //Console.WriteLine(titlesAndServices[i + 1]);

                            System.Windows.Forms.Clipboard.SetText(titlesAndServices[i + 1]);
                            replaceTitles(doc1, result, "^c^p", result + "^p");
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
            String stakingPrice    = "$400";
            String finalPrice      = "$600";
            String foundationPrice = "$350";
            String stormwaterPrice = "$600 - $1200";

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
                case "Storm Water":
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
            String CTFFile;
            String destFile;
            switch (verifyPage.getCTF())
            {
                case "Tom":
                    CTFFile = ctfFindandReplace("Tom");
                    destFile = System.IO.Path.Combine(folderPath, "CTFFile.docx");
                    File.Copy("TomCTFLetter.docx", destFile);
                    break;
                case "Wayne":
                    CTFFile = ctfFindandReplace("Wayne");
                    destFile = System.IO.Path.Combine(folderPath, "CTFFile.docx");
                    File.Copy("WayneCTFLetter.docx", destFile);
                    break;
                case "WayneTom":
                    CTFFile = ctfFindandReplace("Wayne");
                    destFile = System.IO.Path.Combine(folderPath, "CTFFile-Tom.docx");
                    File.Copy("WayneCTFLetter.docx", destFile);
                    
                    CTFFile = ctfFindandReplace("Tom");
                    destFile = System.IO.Path.Combine(folderPath, "CTFFile-Wayne.docx");
                    File.Copy("TomCTFLetter.docx", destFile);
                    break;
            }
        }

        private String ctfFindandReplace(String name)
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
            Console.WriteLine(verifyPage.getCTF());   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(getGIS(clientInfo1.CountyBox));
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
