using System;
using System.Deployment.Application;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;


namespace JobEnter
{
    //New Home
    public partial class Form5 : Form
    {
        string name;
        string addressInherited;
        string phone;
        string email;
        string instructions;
        string days;
        string city;
        int price = 900;
        string stakePrice = "35";
        string certif;

        public Form5(string name, string address, string phone, string email, string specialInstructions, string days, string stakePrice, string city, string certif)
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
            this.certif = certif;

            boxName.Text = name;
            boxAddress.Text = addressInherited;
            boxPhone.Text = phone;
            boxEmail.Text = email;
            boxDays.Text = days;
            boxPrice.Text = price.ToString();
            boxStakePrice.Text = stakePrice;
            boxNewHomeP.Text = "900";
            boxHouseStakingP.Text = "400";
            boxFoundationBuiltP.Text = "300";
            boxFinalBuiltP.Text = "600";
            cmbCity.SelectedItem = city;
        }

        Microsoft.Office.Interop.Word.Document wordDoc { get; set; }


        //■
        //Text for Template
        
        //Building and Improvements
        string visibleImprovements = "Show significant and visible improvements deemed necessary by the surveyor on site, unless otherwise specified by the client beforehand.";
        //Included
        string encroachments = "Show any apparent and significant encroachments across boundary lines observed in the process of conducting the fieldwork.";
        //Included
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
        string heightPeak = "Show the peak or eave height of the existing building on site, as directed by the client.";
        //100

        //Utilities
        string utilityImprovements = "Show visible improvements related to public utilities such as, but not limited to, curbs, roadways, sidewalks.";
        //
        string visibleAppurtenances = "Show visible appurtenances to utilities in adjacent streets and alleys such as, manholes, power poles, catch basins, overhead utility lines or cable/telephone pedestals.";
        //
        string showUtilities = "Show public utilities from plans or markings, combined with visible evidence of such utilities to develop a view of underground utility lines.  Note: The exact location of underground features cannot be accurately, completely, and reliably depicted without actual excavation of those utilities.";
        //

        //Natural Features
        string treeLocation = "Show location of trees larger than 6”+/- inches in diameter, unless otherwise specified by client.  Species not determined by surveyor.";
        //
        string woodedEdge = "Show significant or isolated bushes and or shrubs.";
        //
        string isolatedBushes = "Show significant or isolated bushes and or shrubs. ";
        //
        string showTopography = "Show topography over the entire lot and up to the edge of the adjacent roadway at a contour interval of 1 or 2 feet, whichever is more appropriate.  In addition to contours, show critical spot elevations across the property, as needed, to depict vertical relief.";
        //300
        string benchmarkTopography = "Establish a project benchmark in relation to the topography shown.";
        //
        string showShoreline = "Show approximate shoreline of the body of water at the time of the survey.";
        //
        string ordinaryHighwater = "Show the ordinary high water (OHW) contour line as determined by the Minnesota Department of Natural Resources.";
        //
        string showWetland = "Show delineated wetland by locating wetland flags set by a certified wetland delineator.";
        //Depends
        string lowlandEdge = "Show approximate edge of lowland per the plat and/or field observations.";
        //
        string topOfSlope = "Show approximate top of steep slope.";
        //
        string bluffLine = "Show Bluff Line, per our interpretation of the city definition.  Note: While we show the bluff line per our interpretation of the city’s code, be sure to gain verification and approval from the city that they are correct before proceeding with any site design or construction.";
        //

        //New Homes
        string footprintDwelling = "Show footprint of the proposed dwelling and related improvements, per your plans.";
        //
        string proposedElevation = "Show proposed elevations for the first floor, low floor, top of foundation, and garage floor.";
        //
        string proposedGrading = "Show proposed grading & drainage details by depicting proposed contours, spot elevations, and drainage arrows, as necessary, to show the control of storm water runoff.";
        //
        string tabulateHardcover = "Tabulate areas of proposed hardcover.  Note: Impervious surface requirements vary city to city.  Be sure to have this tabulation reviewed and approved by the appropriate governmental agency before using this information for any site design or construction.";
        //
        string note1 = "Note: While we show a proposed dwelling, related improvements and grading & drainage details, we are not as familiar with the plan or overall concept for the project as our client, their builder, or their architect is. Before relying on the survey for construction and design or submitting the provided information to the city, the client is responsible to verify we are depicting their pro-posed dwelling and improvements correctly.";
        //
        string note2 = "Note: Gaining governmental approvals for your proposed dwelling and improvements is independent of the services we provide.  While we provide the appropriate documents to submit to such governmental agencies, we do not guarantee that your project will be approved at the city or county level.";
        //

        //House Staking: $400
        string placeStakes = "Place building corner stakes and offsets, per the proposed survey, to guide the excavator in digging and the foundation contractor for their layout.";
        //
        string stakingSheet = "Provide staking sheet, after building corner stakes and offsets have been set, showing how the house was staked.  Client is responsible to verify the house staking before proceeding with excavation and foundation construction.";
        //

        //Foundation As-Built: 350$
        string foundationAsBuilt = "Provide a foundation as-built survey showing the location and elevation of the new existing foundation.";
        //

        //Final as Built
        string finalAsBuilt = "Provide a final as-built survey showing actual existing lot conditions after all construction and grading is complete.  Final as-built survey will reflect the items included on the proposed new home survey.";
        //
        string asBuiltNote = "Note: Fees for final as-built survey will be determined based on the size of the proposed dwelling, amount of grading required, and extent of impervious surfaces that need to be shown.  Min. $500 – Max. $1000.";
        //

        //(EDINA)DESIGN/DEVELOPMENT FOR A STORMWATER MANAGEMENT PLAN: $600 - $1200
        string stormwaterDesign = "Design of stormwater retention/detention facilities.  Prepare a design submittal package for governing agency (city or watershed) per site requirements.  Stormwater submittal will include: supporting calculations, plan of existing and proposed drainage patterns, and necessary details.  Best Management Practice (BMP) design will be utilized per requirements.";
        string prepareSubmittalPackage = "Prepare a submittal package for governing agency review. During review process Advance will answer questions and make revisions to plans necessary for approval. Advance does not guarantee approval of project.";

        //Minneapolis
        

        System.Windows.Forms.CheckBox[] checkBoxBuilding;
        int BuildingLength;
        System.Windows.Forms.CheckBox[] checkBoxUtilites;
        int UtilityLength;
        System.Windows.Forms.CheckBox[] checkBoxEnviornmental;
        int EnviornmentalLength;
        System.Windows.Forms.CheckBox[] checkBoxNewHome;
        int NewHomeLength;
        System.Windows.Forms.CheckBox[] checkBoxHouseStaking;
        int StakingLength;
        System.Windows.Forms.CheckBox[] checkBoxFoundationAsBuilt;
        int FoundationLength;
        System.Windows.Forms.CheckBox[] checkBoxFinalAsBuilt;
        int FinalLength;
        System.Windows.Forms.CheckBox[] checkBoxEdinaStuff;
        int EdinaLength;
        System.Windows.Forms.CheckBox[] checkBoxMinneStuff;
        int MinneLength;

        string overallPrice;
        string newHomePrice;
        string houseStakingPrice;
        string finalBuiltPrice;
        string finalFoundationPrice;
        private void Form5_Load(object sender, EventArgs e)
        {
            //Building Boxes
            checkBox1.Text = visibleImprovements;
            checkBox2.Text = encroachments;
            checkBox3.Text = adjacentLots;
            checkBox4.Text = setbackLines;
            checkBox5.Text = exteriorDimensions;
            checkBox6.Text = areaEnclosed;
            checkBox7.Text = doorThreshold;
            checkBox8.Text = floorElevation;
            checkBox9.Text = tabulateAreas;
            checkBox10.Text = heightPeak;

            //Utilities
            checkBox22.Text = utilityImprovements;
            checkBox23.Text = visibleAppurtenances;
            checkBox24.Text = showUtilities;

            //Natural Features
            checkBox11.Text = treeLocation;
            checkBox12.Text = woodedEdge;
            checkBox13.Text = isolatedBushes;
            checkBox14.Text = showTopography;
            checkBox15.Text = benchmarkTopography;
            checkBox16.Text = showShoreline;
            checkBox17.Text = ordinaryHighwater;
            checkBox18.Text = showWetland;
            checkBox19.Text = lowlandEdge;
            checkBox20.Text = topOfSlope;
            checkBox21.Text = bluffLine;

            //New Homes
            checkBox25.Text = footprintDwelling;
            checkBox26.Text = proposedElevation;
            checkBox27.Text = proposedGrading;
            checkBox28.Text = tabulateHardcover;
            checkBox29.Text = note1;
            checkBox30.Text = note2;

            //House Staking
            checkBox31.Text = placeStakes;
            checkBox32.Text = stakingSheet;

            //Foundation As Built
            checkBox33.Text = foundationAsBuilt;

            //Final As Built
            checkBox34.Text = finalAsBuilt;
            checkBox35.Text = asBuiltNote;

            //Specific
            checkBox57EDINA.Text = stormwaterDesign;
            checkBox58EDINA.Text = prepareSubmittalPackage;


            //Adding Checkboxes to Building Checkbox list
            checkBoxBuilding = new System.Windows.Forms.CheckBox[]
            {
                checkBox1, checkBox2, checkBox3, checkBox4, checkBox5,
                checkBox6, checkBox7, checkBox8, checkBox9, checkBox10
            }; BuildingLength = 10;

            //Adding Checkboxes to Utility Checkbox list
            checkBoxUtilites = new System.Windows.Forms.CheckBox[] { checkBox21, checkBox22, checkBox23 };
            UtilityLength = 3;

            //Adding Checkboxes to Enviornmental Checkbox list
            checkBoxEnviornmental = new System.Windows.Forms.CheckBox[]
            {
                checkBox11, checkBox12, checkBox13, checkBox14, checkBox15,
                checkBox16, checkBox17, checkBox18, checkBox19, checkBox20
            }; EnviornmentalLength = 10;

            //Adding Checkboxes to New Home Checkbox list
            checkBoxNewHome = new System.Windows.Forms.CheckBox[]
            {
                checkBox25, checkBox26, checkBox27, checkBox28,
                checkBox29, checkBox30
            }; NewHomeLength = 6;

            //Adding Checkboxes to House Staking Checkbox list
            checkBoxHouseStaking = new System.Windows.Forms.CheckBox[]
            {
                checkBox31, checkBox32
            }; StakingLength = 2;

            //Adding Checkboxes to Foundation Checkbox list
            checkBoxFoundationAsBuilt = new System.Windows.Forms.CheckBox[] { checkBox33 };
            FoundationLength = 1;

            //Adding Checkboxes to Final Checkbox list
            checkBoxFinalAsBuilt = new System.Windows.Forms.CheckBox[] { checkBox34, checkBox35 };
            FinalLength = 2;

            //Adding Checkboxes to Edina Checkbox list
            checkBoxEdinaStuff = new System.Windows.Forms.CheckBox[] { checkBox57EDINA, checkBox58EDINA };
            EdinaLength = 2;

            //Adding Checkboxes to Minneapolis Checkbox list
            checkBoxMinneStuff = new System.Windows.Forms.CheckBox[] { checkBox57EDINA, checkBox58EDINA };
            MinneLength = 2;

            string selectedCity = "";
            if (city != "")
            {
                selectedCity = cmbCity.SelectedItem.ToString();
            }
            switch (selectedCity)
            {
                case "Edina":
                    //Price
                    boxPrice.Text = "1350";
                    newHomePrice = "900";
                    finalFoundationPrice = "300";
                    finalBuiltPrice = "600";

                    //Building/Improvements
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox5.Checked = true;
                    checkBox6.Checked = true;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    checkBox9.Checked = true;

                    //Utilities
                    checkBox22.Checked = true;
                    checkBox23.Checked = true;

                    //Natural Features
                    checkBox11.Checked = true;
                    checkBox14.Checked = true;
                    checkBox15.Checked = true;

                    //New Homes - 900
                    checkBox25.Checked = true;
                    checkBox26.Checked = true;
                    checkBox27.Checked = true;
                    checkBox28.Checked = true;
                    checkBox29.Checked = true;
                    checkBox30.Checked = true;

                    //House Staking
                    checkBox31.Checked = true;
                    checkBox32.Checked = true;

                    //Foundation as Built- 300
                    checkBox33.Checked = true;

                    //Final As Built- 600
                    checkBox34.Checked = true;

                    //Specific
                    checkBox57EDINA.Checked = true;
                    checkBox58EDINA.Checked = true;
                    break;

                case "Minneapolis":
                    //Price
                    boxPrice.Text = "950";
                    newHomePrice = " $1000";
                    finalBuiltPrice = " $600";
                    finalFoundationPrice = " $300";

                    //Building/Improvements
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox5.Checked = true;
                    checkBox6.Checked = true;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    checkBox9.Checked = true;

                    //Utilities
                    checkBox22.Checked = true;

                    //Natural Features
                    checkBox12.Checked = true;
                    checkBox14.Checked = true;
                    checkBox15.Checked = true;

                    //New Homes - 1000
                    checkBox25.Checked = true;
                    checkBox26.Checked = true;
                    checkBox27.Checked = true;
                    checkBox28.Checked = true;
                    checkBox29.Checked = true;
                    checkBox30.Checked = true;

                    //House Staking
                    checkBox31.Checked = true;
                    checkBox32.Checked = true;

                    //Foundation as Built- 300
                    checkBox33.Checked = true;

                    //Final As Built- 600
                    checkBox34.Checked = true;
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
        string allEnviornmental = "";
        Boolean checkedEnviornmental = false;

        //New Homes
        string allNewHomes = "";
        Boolean checkedHomes = false;

        //House Staking
        string allHouseStaking = "";
        Boolean checkedStaking = false;

        //Foundation as Built
        string allFoundationBuilt = "";
        Boolean checkedFoundation = false;

        //Final as Built
        string allFinalBuilt = "";
        Boolean checkedFinal = false;

        //Edina Specific Things
        string allEdinaSpecif = "";
        Boolean checkedEdinaStuff = false;

        //Minneapolis Specific Stuff
        string allMinneapolisSpecif = "";
        Boolean checkedMinneStuff = false;
        
        string saveFolder = "";
        string desktopLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string address;             //Name of the File
        string fileOnDesktop;       //Path on File on Desktop
        string folderOnDesktop;     //Path of Folder on Desktop
        string fileInFolder;        //Path of File in Folder
        string pdfInFolder;         //Path of PDF in Folder
        string nameOfFile;          //Name of File with extension
        string nameOfPDF;           //Name of PDF with extension
        /*
         * Responsible for the process of creating an converting the file. Acts almost as a main method
         */
        private void BtnSave_Click(object sender, EventArgs e)
        {
            address = "Proposal for services at " + boxAddress.Text;
            nameOfFile = address + ".docx";
            nameOfPDF = address + ".pdf";
            folderOnDesktop = desktopLocation + "\\" + boxAddress.Text;
            fileOnDesktop = desktopLocation + "\\" + nameOfFile;
            fileInFolder = folderOnDesktop + "\\" + nameOfFile;
            pdfInFolder = folderOnDesktop + "\\" + nameOfPDF;

            List<string> BuildingChecked = new List<string>();
            List<string> EnviornmentChecked = new List<string>();
            List<string> UtilityChecked = new List<string>();
            List<string> NewHomeChecked = new List<string>();
            List<string> HouseStakingChecked = new List<string>();
            List<string> FoundationBuiltChecked = new List<string>();
            List<string> FinalBuiltChecked = new List<string>();
            List<string> EdinaChecked = new List<string>();
            List<string> MinneChecked = new List<string>();

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
                for(int i = 0; i < BuildingLength; i++)
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
                for (int i = 0; i < EnviornmentalLength; i++)
                {
                    if (checkBoxEnviornmental[i].Checked ? true : false)
                    {
                        EnviornmentChecked.Add("■ " + checkBoxEnviornmental[i].Text);
                        checkedEnviornmental= true;
                    }
                }

                //New Home
                for (int i = 0; i < NewHomeLength; i++)
                {
                    if (checkBoxNewHome[i].Checked ? true : false )
                    {
                        NewHomeChecked.Add("■ " + checkBoxNewHome[i].Text);
                        checkedHomes = true;
                    }
                }

                //House Staking
                for (int i = 0; i < StakingLength; i++)
                {
                    if (checkBoxHouseStaking[i].Checked ? true : false)
                    {
                        HouseStakingChecked.Add("■ " + checkBoxHouseStaking[i].Text);
                        checkedStaking = true;
                    }
                }

                //Foundation
                for (int i = 0; i < FoundationLength; i++)
                {
                    if (checkBoxFoundationAsBuilt[i].Checked ? true : false)
                    {
                        FoundationBuiltChecked.Add("■ " + checkBoxFoundationAsBuilt[i].Text);
                        checkedFoundation= true;
                    }
                }

                //Final
                for (int i = 0; i < FinalLength; i++)
                {
                    if (checkBoxFinalAsBuilt[i].Checked ? true : false)
                    {
                        FinalBuiltChecked.Add("■ " + checkBoxFinalAsBuilt[i].Text);
                        checkedFinal = true;
                    }
                }

                //Edina Stuff
                for (int i = 0; i < EdinaLength; i++)
                {
                    if (checkBoxEdinaStuff[i].Checked ? true : false)
                    {
                        EdinaChecked.Add("■ " + checkBoxEdinaStuff[i].Text);
                        checkedEdinaStuff = true;
                    }
                }

                //Minneapolis
                for (int i = 0; i < MinneLength; i++)
                {
                    if (checkBoxMinneStuff[i].Checked ? true : false)
                    {
                        MinneChecked.Add("■ " + checkBoxMinneStuff[i].Text);
                        checkedMinneStuff = true;
                    }
                }

                foreach (string x in BuildingChecked)
                    allBuilding = allBuilding += x + "\n";
                foreach (string x in UtilityChecked)
                    allUtilities = allUtilities += x + "\n";
                foreach (string x in EnviornmentChecked)
                    allEnviornmental = allEnviornmental += x + "\n";
                foreach (string x in NewHomeChecked)
                    allNewHomes = allNewHomes += x + "\n";
                foreach (string x in HouseStakingChecked)
                    allHouseStaking = allHouseStaking  += x + "\n";
                foreach (string x in FoundationBuiltChecked)
                    allFoundationBuilt = allFoundationBuilt += x + "\n";
                foreach(string x in FinalBuiltChecked)
                    allFinalBuilt = allFinalBuilt += x + "\n";
                foreach (string x in EdinaChecked)
                    allEdinaSpecif = allEdinaSpecif += x + "\n";
                foreach (string x in MinneChecked)
                    allMinneapolisSpecif = allMinneapolisSpecif += x + "\n";

                //Create a Folder on the Desktop
                Create_Folder folder1 = new Create_Folder(desktopLocation, folderOnDesktop);
                folder1.createFolder();

                //Get the directory two up
                DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
                string directory = Directory.GetCurrentDirectory(); //Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;

                //Create a word document on the desktop
                //CreateWordDocument(directory + "\\fullTemplate.docx", fileOnDesktop);
                CreateWordDoc doc1 = new CreateWordDoc(directory + "\\Proposal Template.docx", fileOnDesktop);
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
            overallPrice = boxPrice.Text;
            newHomePrice = boxNewHomeP.Text;
            houseStakingPrice = boxHouseStakingP.Text;
            finalBuiltPrice = boxFinalBuiltP.Text;
            finalFoundationPrice = boxFoundationBuiltP.Text;

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

            //Add City Pricing
            if (city != "")
            {
                switch (cmbCity.SelectedItem.ToString())
                {
                    case "Edina":
                        Clipboard.SetText(allEdinaSpecif);
                        doc1.FindAndReplace("<existingConditions>", "EXISTING CONDITIONS: $" + overallPrice + "^p");
                        break;
                    case "Minneapolis":
                        //Clipboard.SetText(allMinneapolisSpecif);
                        doc1.FindAndReplace("<existingConditions>", "Existing Conditions: $" + overallPrice + "^p");
                        break;
                }
            }
            else { doc1.FindAndReplace("<existingConditions>", ""); }

            //Add building checkboxes
            if (checkedBuilding ? true : false)
            {
                Clipboard.SetText(allBuilding);
                doc1.FindAndReplace("<improvements>", "^c^p");
                doc1.FindAndReplace("<build/improve>", "Building & Improvements:^p");
            } else{
                doc1.FindAndReplace("<build/improve>", "");
                doc1.FindAndReplace("<improvements>", "");
            }

            //Add Utility checkboxes
            if (checkedUtilities ? true : false)
            {
                System.Windows.Forms.Clipboard.SetText(allUtilities);
                doc1.FindAndReplace("<utilities>", "^c^p");
                doc1.FindAndReplace("<util>", "Utilities:^p");
            }  else {
                doc1.FindAndReplace("<util>", "");
                doc1.FindAndReplace("<utilities>", "");
            }

            //Add Enviornment checkboxes
            if (checkedEnviornmental ? true : false ) {
                System.Windows.Forms.Clipboard.SetText(allEnviornmental);
                doc1.FindAndReplace("<environmental>", "^c^p");
                doc1.FindAndReplace("<nature>", "Natural Features:^p");
            } else{
                doc1.FindAndReplace("<nature>", "");
                doc1.FindAndReplace("<environmental>", "");
            }

            //Add New Home
            if (checkedHomes ? true : false)
            {//allNewHomes
                System.Windows.Forms.Clipboard.SetText(allNewHomes);
                doc1.FindAndReplace("<new homes>", "^c^p");
                doc1.FindAndReplace("<homesHeader>", "New Home: $" + newHomePrice + "^p");
            } else {
                doc1.FindAndReplace("<new homes>", "");
                doc1.FindAndReplace("<homesHeader>", "");
            }

            //Add House Staking
            if (checkedStaking ? true : false)
            {
                System.Windows.Forms.Clipboard.SetText(allHouseStaking);
                doc1.FindAndReplace("<house staking>", "^c^p");
                doc1.FindAndReplace("<StakingHeader>", "House Staking: $" + houseStakingPrice + "^p");
            } else {
                doc1.FindAndReplace("<house staking>", "");
                doc1.FindAndReplace("<StakingHeader>", "");
            }

            //Add Foundation as Built
            if (checkedFoundation ? true : false)
            {
                System.Windows.Forms.Clipboard.SetText(allFoundationBuilt);
                doc1.FindAndReplace("<foundation as built>", "^c^p");
                doc1.FindAndReplace("<foundationHeader>", "Foundation As-Built: $" + finalFoundationPrice + "^p");
            } else {
                doc1.FindAndReplace("<foundation as built>", "");
                doc1.FindAndReplace("<foundationHeader>", "");
            }

            //Add Final as Built
            if (checkedFinal ? true : false)
            {//allFinalBuilt
                System.Windows.Forms.Clipboard.SetText(allFinalBuilt);
                doc1.FindAndReplace("<final as built>", "^c^p");
                doc1.FindAndReplace("<finalHeader>", "Final As-Built: $" + finalBuiltPrice + "^p");
            } else {
                doc1.FindAndReplace("<final as built>", "");
                doc1.FindAndReplace("<finalHeader>", "");
            }

            //Add Edina Specific
            if (checkedEdinaStuff ? true : false)
            {
                System.Windows.Forms.Clipboard.SetText(allEdinaSpecif);
                doc1.FindAndReplace("<edinaStuff>", "^c^p");
                doc1.FindAndReplace("<edinaHeader>", "DESIGN / DEVELOPMENT FOR A STORMWATER MANAGEMENT PLAN: $600 - $1200:^p");
            }else
            {
                doc1.FindAndReplace("<edinaStuff>", "");
                doc1.FindAndReplace("<edinaHeader>", "");
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

                    //Price
                    boxPrice.Text = "1350";
                    newHomePrice = "900";
                    finalFoundationPrice = "300";
                    finalBuiltPrice = "600";

                    boxNewHomeP.Text = newHomePrice;
                    boxFoundationBuiltP.Text = finalFoundationPrice;
                    boxFinalBuiltP.Text = finalBuiltPrice;

                    //Building/Improvements
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox5.Checked = true;
                    checkBox6.Checked = true;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    checkBox9.Checked = true;

                    //Utilities
                    checkBox22.Checked = true;
                    checkBox23.Checked = true;

                    //Natural Features
                    checkBox11.Checked = true;
                    checkBox14.Checked = true;
                    checkBox15.Checked = true;

                    //New Homes - 900
                    checkBox25.Checked = true;
                    checkBox26.Checked = true;
                    checkBox27.Checked = true;
                    checkBox28.Checked = true;
                    checkBox29.Checked = true;
                    checkBox30.Checked = true;

                    //House Staking
                    checkBox31.Checked = true;
                    checkBox32.Checked = true;

                    //Foundation as Built- 300
                    checkBox33.Checked = true;

                    //Final As Built- 600
                    checkBox34.Checked = true;

                    //Specific
                    checkBox57EDINA.Checked = true;
                    checkBox58EDINA.Checked = true;


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

                    //Price
                    boxPrice.Text = "950";
                    newHomePrice = "1000";
                    finalBuiltPrice = "600";
                    finalFoundationPrice = "300";

                    boxNewHomeP.Text = newHomePrice;
                    boxFoundationBuiltP.Text = finalFoundationPrice;
                    boxFinalBuiltP.Text = finalBuiltPrice;

                    //Building/Improvements
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox5.Checked = true;
                    checkBox6.Checked = true;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    checkBox9.Checked = true;

                    //Utilities
                    checkBox22.Checked = true;

                    //Natural Features
                    checkBox12.Checked = true;
                    checkBox14.Checked = true;
                    checkBox15.Checked = true;

                    //New Homes - 1000
                    checkBox25.Checked = true;
                    checkBox26.Checked = true;
                    checkBox27.Checked = true;
                    checkBox28.Checked = true;
                    checkBox29.Checked = true;
                    checkBox30.Checked = true;

                    //House Staking
                    checkBox31.Checked = true;
                    checkBox32.Checked = true;

                    //Foundation as Built- 300
                    checkBox33.Checked = true;

                    //Final As Built- 600
                    checkBox34.Checked = true;
                    break;
            }
        }



        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.city = cmbCity.SelectedItem.ToString();
            selectedCity(this.city);
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
