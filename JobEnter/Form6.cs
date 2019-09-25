using System;
using System.Deployment.Application;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace JobEnter
{
    //Addition
    public partial class Form6 : Form
    {
        string name;
        string addressInherited;
        string phone;
        string email;
        string instructions;
        string days;
        string city;
        string price = "900";
        string stakePrice = "35";
        string certif;

        public Form6(string name, string address, string phone, string email, string specialInstructions, string days, string stakePrice, string city, string price, string certif)
        {
            InitializeComponent();
            this.name = name;
            this.addressInherited = address;
            this.phone = phone;
            this.email = email;
            this.instructions = specialInstructions;
            this.days = days;
            this.stakePrice = stakePrice;
            this.city = city;
            this.price = price;
            this.certif = certif;

            boxName.Text = name;
            boxAddress.Text = address;
            boxPhone.Text = phone;
            boxEmail.Text = email;
            boxDays.Text = days;
            boxStakePrice.Text = this.stakePrice;
            boxPrice.Text = this.price;
            cmbCity.SelectedItem = city;
        }

        Microsoft.Office.Interop.Word.Document wordDoc { get; set; }

        //■
        //Text for Template

        //Building and Improvements
        string visibleImprovements = "Show significant and visible improvements deemed necessary by the surveyor on site, unless otherwise specified by the client beforehand.";
        //
        string encroachments = "Show any apparent and significant encroachments across boundary lines observed in the process of conducting the fieldwork.";
        //
        string adjacentLots = "Show front and nearest side (front to back) of the homes on the adjacent lots that front the same street as the subject property. ";
        //
        string setbackLines = "Show minimum building setback lines.  Note: While we show minimum building setbacks lines per our interpretation of the city’s code, be sure to gain verification and approval from the city that they are correct before proceeding with any site design or construction.";
        //100
        string exteriorDimensions = "Show exterior dimensions of the building footprint along with building corner dimensions to the lot line, as measured perpendicular to the lot line.";
        //
        string areaEnclosed = "Show area enclosed by building perimeter at ground level.";
        //
        string doorThreshold = "Show the door threshold (entrance) elevation of the building on the site.";
        //
        string floorElevation = "Show the floor elevation of the garage, nearest the door, on the site.";
        //
        string tabulateAreas = "Tabulate areas of existing hardcover.  Note: Impervious surface requirements vary city to city. Be sure to have this tabulation reviewed and approved by the appropriate governmental agency before using this information for any site design or construction.";
        //300
        string peakHeight = "Show the peak or eave height of the existing building on site, as directed by the client.";
        //

        //Utilities
        string utilityImprovements = "Show visible improvements related to public utilities such as, but not limited to, curbs, roadways, sidewalks.";
        //
        string visibleAppurtenances = "Show visible appurtenances to utilities in adjacent streets and alleys such as, manholes, power poles, catch basins, overhead utility lines or cable/telephone pedestals.";
        //
        string publicUtilities = "Show public utilities from plans or markings, combined with visible evidence of such utilities to develop a view of underground utility lines.  Note: The exact location of underground features cannot be accurately, completely, and reliably depicted without actual excavation of those utilities.";
        //

        //Natural Features
        string edgeOfArea = "Show edge of wooded areas and isolated, significant trees.";
        //
        string isolatedShrubs = "Show significant or isolated bushes and or shrubs.";
        //
        string lotTopography = "Show topography over the entire lot and up to the edge of the adjacent roadway at a contour interval of 1 or 2 feet, whichever is more appropriate.  In addition to contours, show critical spot elevations across the property, as needed, to depict vertical relief.";
        //
        string benchmarkTopography = "Establish a project benchmark in relation to the topography shown.";
        //
        string shoreLine = "Show approximate shoreline of the body of water at the time of the survey.";
        //
        string ordinaryHighwater = "Show the ordinary high water (OHW) contour line as determined by the Minnesota Department of Natural Resources.";
        //
        string floodContour = "Show the flood contour per FEMA’s FIRM Map or determined by an appropriate governmental agency.";
        //
        string showWetland = "Show delineated wetland by locating wetland flags set by a certified wetland delineator.";
        //
        string lowlandEdge = "Show approximate edge of lowland per the plat and/or field observations.";
        //
        string steepSlope = "Show approximate top of steep slope.";
        //
        string bluffLine = "Show Bluff Line, per our interpretation of the city definition.  Note: While we show the bluff line per our interpretation of the city’s code, be sure to gain verification and approval from the city that they are correct before proceeding with any site design or construction.";
        //
        string treeLocation = "Show location of trees larger than 6”+/- inches in diameter, unless otherwise specified by client.  Species not determined by surveyor.";
        //
        string showTopography = "Show topography over the entire lot and up to the edge of the adjacent roadway at a contour interval of 1 or 2 feet, whichever is more appropriate.  In addition to contours, show critical spot elevations across the property, as needed, to depict vertical relief.";
        //300


        //Addition
        string showFootprint = "Show footprint of the proposed addition and related improvements, per your plans.";
        //
        string showElevations = "Show proposed elevations associated with the proposed addition and improvements";
        //
        string showGrading = "Show proposed grading & drainage details by depicting proposed contours, spot elevations, and drainage arrows, as necessary, to show the control of storm water runoff.";
        //
        string tabulateHardcover = "Tabulate areas of proposed hardcover. Note: Impervious surface requirements vary city to city.  Be sure to have this tabulation reviewed and approved by the appropriate governmental agency before using this information for any site design or construction.";
        //
        string note1 = "Note: While we show a proposed dwelling, related improvements and grading & drainage details, we are not as familiar with the plan or overall concept for the project as our client, their builder, or their architect is.  Before relying on the survey for construction and design or submitting the provided information to the city, the client is responsible to verify we are depicting their proposed dwelling and improvements correctly.";
        //
        string note2 = "Note: Gaining governmental approvals for your proposed addition and improvements is independent of the services we provide.  While we provide the appropriate documents to submit to such governmental agencies, we do not guarantee that your project will be approved at the city or county level.";

        //Stormwater managment plan- EDINA
        string retentionDetetion = "Design of stormwater retention/detention facilities.  Prepare a design submittal package for governing agency (city or watershed) per site requirements.  Stormwater submittal will include:  supporting calculations, plan of existing and proposed drainage patterns, and necessary details.  Best Management Practice (BMP) design will be utilized per requirements.";
        //
        string submittalPackage = "Prepare a submittal package for governing agency review.  During review process Advance will answer questions and make revisions to plans necessary for approval.  Advance does not guarantee approval of project.";
        //


        System.Windows.Forms.CheckBox[] checkBoxBuilding;
        int BuildingLength;
        System.Windows.Forms.CheckBox[] checkBoxUtilites;
        int UtilityLength;
        System.Windows.Forms.CheckBox[] checkBoxNatural;
        int NaturalLength;
        System.Windows.Forms.CheckBox[] checkBoxAddition;
        int AdditionLength;
        System.Windows.Forms.CheckBox[] checkBoxEdina;
        int EdinaLength;

        private void Form6_Load_1(object sender, EventArgs e)
        {
            //Building/Improvements
            checkBox1.Text = visibleImprovements;
            checkBox2.Text = encroachments;
            checkBox3.Text = adjacentLots;
            checkBox4.Text = setbackLines;
            checkBox5.Text = exteriorDimensions;
            checkBox6.Text = areaEnclosed;
            checkBox7.Text = doorThreshold;
            checkBox8.Text = floorElevation;
            checkBox9.Text = tabulateAreas;

            //Utilities
            checkBox10.Text = utilityImprovements;
            checkBox11.Text = visibleAppurtenances;
            checkBox12.Text = publicUtilities;

            //Natural Features
            checkBox13.Text = edgeOfArea;
            checkBox14.Text = isolatedShrubs;
            checkBox15.Text = lotTopography;
            checkBox16.Text = benchmarkTopography;
            checkBox17.Text = shoreLine;
            checkBox18.Text = ordinaryHighwater;
            checkBox19.Text = floodContour;
            checkBox20.Text = showWetland;
            checkBox21.Text = lowlandEdge;
            checkBox22.Text = steepSlope;
            checkBox23.Text = bluffLine;
            checkBox24.Text = treeLocation;
            checkBox25.Text = showTopography;

            //Additions
            checkBox26.Text = showFootprint;
            checkBox27.Text = showElevations;
            checkBox28.Text = showGrading;
            checkBox29.Text = tabulateHardcover;
            checkBox30.Text = note1;
            checkBox31.Text = note2;

            //Stormwater Managment Plan
            checkBox32.Text = retentionDetetion;
            checkBox33.Text = submittalPackage;


            //Adding Checkboxes to Building Checkbox list
            checkBoxBuilding = new System.Windows.Forms.CheckBox[]
            {
                checkBox1, checkBox2, checkBox3, checkBox4, checkBox5,
                checkBox6, checkBox7, checkBox8, checkBox9
            }; BuildingLength = 9;

            //Adding Checkboxes to Utility Checkbox list
            checkBoxUtilites = new System.Windows.Forms.CheckBox[] { checkBox10, checkBox11, checkBox12 };
            UtilityLength = 3;

            //Adding Checkboxes to Enviornmental Checkbox list
            checkBoxNatural = new System.Windows.Forms.CheckBox[]
            {
                checkBox13, checkBox14, checkBox15, checkBox16, checkBox17,
                checkBox18, checkBox19, checkBox20, checkBox21, checkBox22,
                checkBox23, checkBox24, checkBox25
            }; NaturalLength = 13;

            //Adding Checkboxes to Additions list
            checkBoxAddition = new System.Windows.Forms.CheckBox[]
            {
                checkBox26, checkBox27, checkBox28, checkBox29, checkBox30, checkBox31
            }; AdditionLength = 6;

            //Adding Checkboxes to Stormwater Checkbox list
            checkBoxEdina = new System.Windows.Forms.CheckBox[]
            {
                checkBox32, checkBox33
            }; EdinaLength = 2;


            string selectedCity = "";
            if (city != "")
            {
                selectedCity = cmbCity.SelectedItem.ToString();
            }
            switch (selectedCity)
            {
                case "Edina":
                    //Build/Improve
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox5.Checked = true;
                    checkBox6.Checked = true;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    checkBox9.Checked = true;

                    //Utilities
                    checkBox10.Checked = true;
                    checkBox11.Checked = true;

                    //Natural
                    checkBox16.Checked = true;
                    checkBox24.Checked = true;
                    checkBox25.Checked = true;

                    //Additions
                    checkBox26.Checked = true;
                    checkBox27.Checked = true;
                    checkBox28.Checked = true;
                    checkBox29.Checked = true;
                    checkBox30.Checked = true;
                    checkBox31.Checked = true;

                    //Edina Stuff
                    checkBox32.Checked = true;
                    checkBox33.Checked = true;
                    break;
                case "Minneapolis":
                    //Build/Improve
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox5.Checked = true;
                    checkBox6.Checked = true;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    checkBox9.Checked = true;

                    //Utilities
                    checkBox10.Checked = true;
                    checkBox11.Checked = true;

                    //Natural
                    checkBox16.Checked = true;
                    checkBox24.Checked = true;
                    checkBox25.Checked = true;

                    //Additions
                    checkBox26.Checked = true;
                    checkBox27.Checked = true;
                    checkBox28.Checked = true;
                    checkBox29.Checked = true;
                    checkBox30.Checked = true;
                    checkBox31.Checked = true;
                    break;
            }
        }

        /*
         * Creating a string that contains all of the checked values
         */

        //Building and Improvements
        string allBuilding = "";
        Boolean checkedBuilding = false;

        //Utilities
        string allUtilities = "";
        Boolean checkedUtilities = false;

        //Enviornmental
        string allNaturalFeatures = "";
        Boolean checkedNaturalFeatures = false;

        //Additions
        string allAdditions = "";
        Boolean checkedAdditions = false;

        //Edina Stuff
        string allEdinaSpecific = "";
        Boolean checkedEdina = false;


        string saveFolder = "";
        string desktopLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string address;             //Name of the File
        string fileOnDesktop;       //Path on File on Desktop
        string folderOnDesktop;     //Path of Folder on Desktop
        string fileInFolder;        //Path of File in Folder
        string pdfInFolder;         //Path of PDF in Folder
        string nameOfFile;          //Name of File with extension
        string nameOfPDF;           //Name of PDF with extension
        private void btnSave_Click(object sender, EventArgs e)
        {
            address = "Proposal for services at " + boxAddress.Text;
            nameOfFile = address + ".docx";
            nameOfPDF = address + ".pdf";
            folderOnDesktop = desktopLocation + "\\" + boxAddress.Text;
            fileOnDesktop = desktopLocation + "\\" + nameOfFile;
            fileInFolder = folderOnDesktop + "\\" + nameOfFile;
            pdfInFolder = folderOnDesktop + "\\" + nameOfPDF;

            List<string> BuildingChecked = new List<string>();
            List<string> NaturalChecked = new List<string>();
            List<string> UtilityChecked = new List<string>();
            List<string> AdditionChecked = new List<string>();
            List<string> EdinaChecked = new List<string>();

            Form4 f4 = new Form4(1);
            f4.Show();
            if (boxAddress.Text != "")
            {
                //Check if folder already exists and if it does, do not continue
                if (Directory.Exists(folderOnDesktop))
                {
                    f4.Close();
                    MessageBox.Show("File Already exists on desktop.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                /*
                 * Adds all checkboxes that are marked to the proposal
                 */
                //Building
                for (int i = 0; i < BuildingLength; i++)
                {
                    if (checkBoxBuilding[i].Checked)
                    {
                        BuildingChecked.Add("■ " + checkBoxBuilding[i].Text);
                        checkedBuilding = true;
                    }
                }

                //Utilities
                for (int i = 0; i < UtilityLength; i++)
                {
                    if (checkBoxUtilites[i].Checked ? true : false)
                    {
                        UtilityChecked.Add("■ " + checkBoxUtilites[i].Text);
                        checkedUtilities = true;
                    }
                }

                //Enviornmental
                for (int i = 0; i < NaturalLength; i++)
                {
                    if (checkBoxNatural[i].Checked ? true : false)
                    {
                        NaturalChecked.Add("■ " + checkBoxNatural[i].Text);
                        checkedNaturalFeatures = true;
                    }
                }

                //New Home
                for (int i = 0; i < AdditionLength; i++)
                {
                    if (checkBoxAddition[i].Checked ? true : false)
                    {
                        AdditionChecked.Add("■ " + checkBoxAddition[i].Text);
                        checkedAdditions = true;
                    }
                }

                //Edina Stuff
                for (int i = 0; i < EdinaLength; i++)
                {
                    if (checkBoxEdina[i].Checked ? true : false)
                    {
                        EdinaChecked.Add("■ " + checkBoxEdina[i].Text);
                        checkedEdina = true;
                    }
                }

                foreach (string x in BuildingChecked)
                    allBuilding = allBuilding += x + "\n";
                foreach (string x in UtilityChecked)
                    allUtilities = allUtilities += x + "\n";
                foreach (string x in NaturalChecked)
                    allNaturalFeatures = allNaturalFeatures += x + "\n";
                foreach (string x in AdditionChecked)
                    allAdditions = allAdditions += x + "\n";
                foreach (string x in EdinaChecked)
                    allEdinaSpecific = allEdinaSpecific += x + "\n";

                //Create a Folder on the Desktop
                Create_Folder folder1 = new Create_Folder(desktopLocation, folderOnDesktop);
                folder1.createFolder();

                //Get the directory two up
                DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
                string directory = Directory.GetCurrentDirectory(); //Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;

                //Create a word document on the desktop
                //CreateWordDocument(directory + "\\fullTemplate.docx", fileOnDesktop);
                CreateWordDoc doc1 = new CreateWordDoc(directory + "\\Additions Template.docx", fileOnDesktop);
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
                    { }
                }

                //Convert Word doc to PDF
                ConvertToPDF converter = new ConvertToPDF(fileInFolder, nameOfPDF, folderOnDesktop);
                converter.convertToPDF();

                f4.Close();
                MessageBox.Show("Folder Created");

                //Open an outlook window
                string[] name = boxName.Text.Split(' ');
                SendEmail sendEmail = new SendEmail(boxEmail.Text, "info@advsur.com", address, "Hi " + name[0] + "-\nAttached is the proposal you requested.  Please let me know if you have any questions or if you would like to be added to our schedule. \n\nThank you for the opportunity.\n", pdfInFolder, null);
                sendEmail.openOutlookWindow();

            }
            else
                MessageBox.Show("Please Enter an Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void FindAndReplace(CreateWordDoc doc1)
        {
            doc1.CreateDocument();
            //Find and Replace
            {
                //find and replace
                doc1.FindAndReplace("<name>", boxName.Text);
                doc1.FindAndReplace("<address>", boxAddress.Text);
                doc1.FindAndReplace("<phone>", boxPhone.Text);
                doc1.FindAndReplace("<email>", boxEmail.Text);
                doc1.FindAndReplace("<price>", boxPrice.Text);
                doc1.FindAndReplace("<stakePrice>", boxStakePrice.Text);
                doc1.FindAndReplace("<days>", boxDays.Text);

                if (instructions != "")
                    doc1.FindAndReplace("<instructions>", instructions);
                else
                    doc1.FindAndReplace("<instructions>", "None");
            }

            string existingConditionsPrice = "$1350";
            //Replace City Pricing
            if (city != "")
            {
                switch (cmbCity.SelectedItem.ToString())
                {
                    case "Edina":
                        Clipboard.SetText(allEdinaSpecific);
                        doc1.FindAndReplace("<stormWaterHeader>", "DESIGN/DEVELOPMENT FOR A STORMWATER MANAGEMENT PLAN: $600 - $1200^p");
                        doc1.FindAndReplace("<stormWater>", "^c");
                        break;
                    case "Minneapolis":
                        doc1.FindAndReplace("<stormWaterHeader>", "");
                        doc1.FindAndReplace("<stormWater>", "");
                        break;
                }
            }
            else { doc1.FindAndReplace("<stormWaterHeader>", ""); }

            //Existing Conditions Header
            doc1.FindAndReplace("<existingConditions>", "Existing Conditions: " + existingConditionsPrice);

            //Replace building checkboxes
            if (checkedBuilding ? true : false)
            {
                Clipboard.SetText(allBuilding);
                doc1.FindAndReplace("<build/improveHeader>", "Building & Improvements:^p");
                doc1.FindAndReplace("<build/improve>", "^c^p");
            }
            else
            {
                doc1.FindAndReplace("<build/improveHeader>", "");
                doc1.FindAndReplace("<build/improve>", "");
            }

            //Replace Utility checkboxes
            if (checkedUtilities ? true : false)
            {
                System.Windows.Forms.Clipboard.SetText(allUtilities);
                doc1.FindAndReplace("<utilHeader>", "Utilities:^p");
                doc1.FindAndReplace("<utilities>", "^c^p");
            }
            else
            {
                doc1.FindAndReplace("<utilHeader>", "");
                doc1.FindAndReplace("<utilities>", "");
            }

            //Replace Natural checkboxes
            if (checkedNaturalFeatures ? true : false)
            {
                System.Windows.Forms.Clipboard.SetText(allNaturalFeatures);
                doc1.FindAndReplace("<naturalHeader>", "Natural Features:^p");
                doc1.FindAndReplace("<natural>", "^c^p");
            }
            else
            {
                doc1.FindAndReplace("<naturalHeader>", "");
                doc1.FindAndReplace("<natural>", "");
            }

            //Replace Additions
            if (checkedAdditions ? true : false)
            {//allNewHomes
                System.Windows.Forms.Clipboard.SetText(allAdditions);
                doc1.FindAndReplace("<additionHeader>", "ADDITION:^p");
                doc1.FindAndReplace("<addition>", "^c^p");
            }
            else
            {
                doc1.FindAndReplace("<addition>", "");
                doc1.FindAndReplace("<additionHeader>", "");
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

        private void moveFolder(string original, string final)
        {
            try
            {
                File.Move(original, final);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in moving the file: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Opens a specified folder
         * fileLocation: Folder to be opened
         */
        private void openFile(string fileLocation)
        {
            try
            {
                Word.Application ap = new Word.Application();
                Word.Document document = ap.Documents.Open(fileLocation);
                ap.Visible = true;
                //                this.TopMost = true;
            }
            catch (Exception ex) { }
        }

        /*
         * Check if a file is currently open and reutrn true/false
         * fileName: File your checking to see is available.
         */
        public bool checkFileStatus(FileInfo fileName)
        {
            FileStream streamInput = null;

            try
            {
                streamInput = fileName.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (streamInput != null)
                {
                    streamInput.Close();
                }
            }

            return false;
        }

        private void selectedCity(string city)
        {
            switch (city)
            {
                case "Edina":
                    foreach (var ctrl in panel1.Controls)
                    {
                        if (ctrl is CheckBox)
                        {
                            if (((CheckBox)ctrl).Checked)
                            {
                                ((CheckBox)ctrl).Checked = false;
                            }
                        }
                    }
                    //Build/Improve
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox5.Checked = true;
                    checkBox6.Checked = true;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    checkBox9.Checked = true;

                    //Utilities
                    checkBox10.Checked = true;
                    checkBox11.Checked = true;

                    //Natural
                    checkBox16.Checked = true;
                    checkBox24.Checked = true;
                    checkBox25.Checked = true;

                    //Additions
                    checkBox26.Checked = true;
                    checkBox27.Checked = true;
                    checkBox28.Checked = true;
                    checkBox29.Checked = true;
                    checkBox30.Checked = true;
                    checkBox31.Checked = true;

                    //Edina Stuff
                    checkBox32.Checked = true;
                    checkBox33.Checked = true;
                    break;
                case "Minneapolis":
                    
                    foreach (var ctrl in panel1.Controls)
                    {
                        if (ctrl is CheckBox)
                        {
                            if (((CheckBox)ctrl).Checked)
                            {
                                ((CheckBox)ctrl).Checked = false;
                            }
                        }  
                    }
                    //Build/Improve
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox5.Checked = true;
                    checkBox6.Checked = true;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    checkBox9.Checked = true;

                    //Utilities
                    checkBox10.Checked = true;
                    checkBox11.Checked = true;

                    //Natural
                    checkBox16.Checked = true;
                    checkBox24.Checked = true;
                    checkBox25.Checked = true;

                    //Additions
                    checkBox26.Checked = true;
                    checkBox27.Checked = true;
                    checkBox28.Checked = true;
                    checkBox29.Checked = true;
                    checkBox30.Checked = true;
                    checkBox31.Checked = true;
                    break;
            }
                

        }

        private void cmbCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.city = cmbCity.SelectedItem.ToString();
            selectedCity(city);
        }
    }       
}
