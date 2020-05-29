using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace JobEnter
{
    public partial class Form2 : Form
    {
        string name;
        string phone;
        string email;
        string instructions;
        string days;
        string city;
        int price = 900;
        string stakePrice = "35";
        string certif;

        public Form2(string name, string address, string phone, string email, string specialInstructions, string days, string stakePrice, string city, string certif)
        {
            InitializeComponent();
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.instructions = specialInstructions;
            this.days = days;
            this.stakePrice = stakePrice;
            this.city = city;
            this.certif = certif;

            boxName.Text = this.name;
            boxAddress.Text = this.address;
            boxPhone.Text = this.phone;
            boxEmail.Text = this.email;
            boxDays.Text = days;
        }

        Microsoft.Office.Interop.Word.Document wordDoc { get; set; }
        #region Text variables
        //■
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
        string doorThreshold = "Show the door threshold (entrance) elevation of the building on the site.";
        //
        string floorElevation = "Show the floor elevation of the garage, nearest the door, on the site.";
        //
        string tabulateAreas = "Tabulate areas of existing hardcover.  Note: Impervious surface requirements vary city to city. Be sure to have this tabulation reviewed and approved by the appropriate governmental agency before using this information for any site design or construction.";
        //300
        string heightPeak = "Show the peak or eave height of the existing building on site, as directed by the client.";
        //100

        //Enviornmental
        string woodedArea = "Show approximate edge of wooded areas and isolated large trees, as specified by the client. Species not determined by surveyor.";
        //
        string treeLocation = "Show location of trees larger than 6”+/- inches in diameter, unless otherwise specified by client.  Species not determined by surveyor.";
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

        //Utilities
        string utilityImprovements = "Show visible improvements related to public utilities such as, but not limited to, curbs, roadways, sidewalks.";
        string showUtilities = "Show public utilities from plans or markings, combined with visible evidence of such utilities to develop a view of underground utility lines.  Note: The exact location of underground features cannot be accurately, completely, and reliably depicted without actual excavation of those utilities.";

        //Winter Hardcover Note
        string snowClearing = "Client is responsible for clearing snow and ice off of all impervious surfaces prior to survey.  Snow and ice must be removed entirely so that the edge of the surface is clearly identifiable.  If the surveyor determines the snow and ice have not been properly removed from all surfaces at the time of the survey, impervious surface calculations will be shown as an approximate value (+/-).  Approximate values may or may not be sufficient for design or city approval.";

        #endregion

        System.Windows.Forms.CheckBox[] checkBoxBuilding = new System.Windows.Forms.CheckBox[9];
        System.Windows.Forms.CheckBox[] checkBoxEnviornmental = new System.Windows.Forms.CheckBox[11];
        System.Windows.Forms.CheckBox[] checkBoxUtilites = new System.Windows.Forms.CheckBox[3];

        private void Form2_Load(object sender, EventArgs e)
        {
            //Adding text to Building Boxes
            checkBox1.Text = visibleImprovements;
            checkBox2.Text = encroachments;
            checkBox3.Text = adjacentLots;
            checkBox4.Text = setbackLines;
            checkBox5.Text = exteriorDimensions;
            checkBox6.Text = doorThreshold;
            checkBox7.Text = floorElevation;
            checkBox8.Text = tabulateAreas;
            checkBox9.Text = heightPeak;

            //Adding text to Enviornmental Boxes
            checkBox10.Text = woodedArea;
            checkBox11.Text = treeLocation;
            checkBox12.Text = isolatedBushes;
            checkBox13.Text = showTopography;
            checkBox14.Text = benchmarkTopography;
            checkBox15.Text = showShoreline;
            checkBox16.Text = ordinaryHighwater;
            checkBox17.Text = showWetland;
            checkBox18.Text = lowlandEdge;
            checkBox19.Text = topOfSlope;
            checkBox20.Text = bluffLine;

            //Adding text to Utilites/Winter Hardcover
            checkBox21.Text = utilityImprovements;
            checkBox22.Text = showUtilities;
            checkBox23.Text = snowClearing;

            //Adding Checkboxes to Building Checkbox list
            checkBoxBuilding[0] = checkBox1;
            checkBoxBuilding[1] = checkBox2;
            checkBoxBuilding[2] = checkBox3;
            checkBoxBuilding[3] = checkBox4;
            checkBoxBuilding[4] = checkBox5;
            checkBoxBuilding[5] = checkBox6;
            checkBoxBuilding[6] = checkBox7;
            checkBoxBuilding[7] = checkBox8;
            checkBoxBuilding[8] = checkBox9;

            //Adding Checkboxes to Building Checkbox list
            checkBoxEnviornmental[0] = checkBox10;
            checkBoxEnviornmental[1] = checkBox12;
            checkBoxEnviornmental[2] = checkBox13;
            checkBoxEnviornmental[3] = checkBox14;
            checkBoxEnviornmental[4] = checkBox15;
            checkBoxEnviornmental[5] = checkBox16;
            checkBoxEnviornmental[6] = checkBox17;
            checkBoxEnviornmental[7] = checkBox18;
            checkBoxEnviornmental[8] = checkBox19;
            checkBoxEnviornmental[9] = checkBox20;

            //Adding Checkboxes to Utility Checkbox list
            checkBoxUtilites[0] = checkBox21;
            checkBoxUtilites[1] = checkBox22;
            checkBoxUtilites[2] = checkBox23;

            boxPrice.Text = price.ToString();
            boxStakePrice.Text = stakePrice;

            if(city == "St Paul")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }

        }

        string allBuilding = "";
        Boolean checkedBuilding = false;

        string allEnviornmental = "";
        Boolean checkedEnviornmental = false;

        string allUtilities = "";
        Boolean checkedUtilities = false;

        string hardCover = "";
        Boolean checkedHardCover = false;

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> BuildingChecked = new List<string>();
            List<string> EnviornmentalChecked = new List<string>();
            List<string> UtilityChecked = new List<string>();

            //Building
            for (int i = 0; i <= 8; i++)
            {
                if (checkBoxBuilding[i].Checked)
                {
                    BuildingChecked.Add("■ " + checkBoxBuilding[i].Text);
                    checkedBuilding = true;
                }

            }

            //Enviornmental
            for (int i = 0; i <= 9; i++)
            {
                if (checkBoxEnviornmental[i].Checked)
                {
                    EnviornmentalChecked.Add("■ " + checkBoxEnviornmental[i].Text);
                    checkedEnviornmental = true;
                }
            }

            //Utilities
            for (int i = 0; i <= 1; i++)
            {
                if (checkBoxUtilites[i].Checked)
                {
                    UtilityChecked.Add("■ " + checkBoxUtilites[i].Text);
                    checkedUtilities = true;
                }
            }

            //Hardcover
            if (checkBox23.Checked)
            {
                hardCover = "■ " + checkBox23.Text;
                checkedHardCover = true;
            }

            foreach (string x in BuildingChecked)
                allBuilding = allBuilding += x + "\n";
            foreach (string x in EnviornmentalChecked)
                allEnviornmental = allEnviornmental += x + "\n";
            foreach (string x in UtilityChecked)
                allUtilities = allUtilities += x + "\n";

            
            MessageBox.Show(allBuilding + allEnviornmental + allUtilities);               
        }

        private void FindAndReplace(CreateWordDoc doc1)
        {
            doc1.CreateDocument();

            //find and replace
            doc1.FindAndReplace("<name>", boxName.Text);
            doc1.FindAndReplace("<address>", boxAddress.Text);
            doc1.FindAndReplace("<phone>", boxPhone.Text);
            doc1.FindAndReplace("<email>", boxEmail.Text);
            doc1.FindAndReplace("<instructions>", instructions);
            doc1.FindAndReplace("<Price>", boxPrice.Text);
            doc1.FindAndReplace("<stakePrice>", boxStakePrice.Text);
            doc1.FindAndReplace("<days>", boxDays.Text);


            //Add building checkboxes
            if (checkedBuilding)
            {
                System.Windows.Forms.Clipboard.SetText(allBuilding);
                doc1.FindAndReplace("<improvements>", "^c^p");
                doc1.FindAndReplace("<build/improve>", "Building & Improvements:^p");
            }
            else
            {
                doc1.FindAndReplace("<build/improve>", "");
                doc1.FindAndReplace("<improvements>", "");
            }

            //Add Utility checkboxes
            if (checkedUtilities)
            {
                System.Windows.Forms.Clipboard.SetText(allUtilities);
                doc1.FindAndReplace("<utilities>", "^c^p");
                doc1.FindAndReplace("<util>", "Utilities:^p");
            }
            else
            {
                doc1.FindAndReplace("<util>", "");
                doc1.FindAndReplace("<utilities>", "");
            }

            //Add Enviornment checkboxes
            if (checkedEnviornmental)
            {
                System.Windows.Forms.Clipboard.SetText(allEnviornmental);
                doc1.FindAndReplace("<environmental>", "^c^p");
                doc1.FindAndReplace("<nature>", "Natural Features:^p");
            }
            else
            {
                doc1.FindAndReplace("<nature>", "");
                doc1.FindAndReplace("<environmental>", "");
            }

            //Add hardcover checkbox
            if (checkedHardCover)
            {
                System.Windows.Forms.Clipboard.SetText(hardCover);
                doc1.FindAndReplace("<hardcover>", "^c^p");
                doc1.FindAndReplace("<hardNote>", "Winter Hardcover Note:^p");
            }
            else
            {
                doc1.FindAndReplace("<hardcover>", "^p");
                doc1.FindAndReplace("<hardNote>", "");
            }
        }


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
            List<string> EnviornmentalChecked = new List<string>();
            List<string> UtilityChecked = new List<string>();

            /*
             * Checks if address if empty if it is, do not continue
             */
            if (boxAddress.Text != "")
            {
                Form4 f4 = new Form4(1);
                //Checks if folder already exists and if it does, do not continue
                if (!System.IO.File.Exists(folderOnDesktop))
                { 
                    f4.Show();
                }

                /*
                 * Adds all checkboxes that are marked to the proposal
                 */
                //Building
                for (int i = 0; i <= 8; i++)
                {
                    if (checkBoxBuilding[i].Checked)
                    {
                        BuildingChecked.Add("■ " + checkBoxBuilding[i].Text);
                        checkedBuilding = true;
                    }

                }

                //Enviornmental
                for (int i = 0; i <= 9; i++)
                {
                    if (checkBoxEnviornmental[i].Checked)
                    {
                        EnviornmentalChecked.Add("■ " + checkBoxEnviornmental[i].Text);
                        checkedEnviornmental = true;
                    }
                }

                //Utilities
                for (int i = 0; i <= 1; i++)
                {
                    if (checkBoxUtilites[i].Checked)
                    {
                        UtilityChecked.Add("■ " + checkBoxUtilites[i].Text);
                        checkedUtilities = true;
                    }
                }

                //Hardcover
                if (checkBox23.Checked)
                {
                    hardCover = "■ " + checkBox23.Text;
                    checkedHardCover = true;
                }

                foreach (string x in BuildingChecked)
                    allBuilding = allBuilding += x + "\n";
                foreach (string x in EnviornmentalChecked)
                    allEnviornmental = allEnviornmental += x + "\n";
                foreach (string x in UtilityChecked)
                    allUtilities = allUtilities += x + "\n";

                //Check if the folder already exists on dekstop
                if (Directory.Exists(folderOnDesktop))
                {
                    f4.Close();
                    MessageBox.Show("File Already exists on desktop.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Create a Folder on the Desktop
                Create_Folder folder1 = new Create_Folder(desktopLocation, folderOnDesktop);
                folder1.createFolder();

                //Get the directory two up
                DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
                string directory = Directory.GetCurrentDirectory(); //Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;

                //Create a word document on the desktop
                //CreateWordDocument(directory + "\\fullTemplate.docx", fileOnDesktop);
                CreateWordDoc doc1 = new CreateWordDoc(directory + "\\fullTemplate.docx", fileOnDesktop);
                FindAndReplace(doc1);
                doc1.closeAndSave();

                //Move folder from desktop to folder on dekstop
                moveFolder(fileOnDesktop, fileInFolder);

                if (fileInFolder != null)
                {
                    //Open File for edits
                    openFile(fileInFolder);

                    FileInfo fi1 = new FileInfo(fileInFolder);
                    while (checkFileStatus(fi1))
                    {  }
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
            }catch(Exception ex) { }
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

        /*
         * Move a specific file into another file
         * path 1: Path of the file you want to move
         * path 3: Name and path of the location you want to move the file to
         */
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

        /*
         * Creates a folder on the desktop and returns the full path of said folder
         * address: Name of the file with extension
         * finalAddress: Path of file on the Desktop
         * desktopLocation: Saved location of the desktop
         * folderName: Relative path of the folders 
         * pathString: Full path of the folder
         */
        private string createFolder()
        {
            //Create File Name
            string address = boxAddress.Text + ".docx";
            string finalAddress = desktopLocation + "\\Proposal for Services at " + address;

            // Specify a name for your top-level folder.
            string folderName = desktopLocation;

            // To create a string that specifies the path to a subfolder under your 
            // top-level folder, add a name for the subfolder to folderName.
            string pathString = System.IO.Path.Combine(folderName, boxAddress.Text);

            // Create the subfolder. You can verify in File Explorer that you have this
            // structure in the C: drive.
            //    Local Disk (C:)
            //        Top-Level Folder
            //            SubFolder
            System.IO.Directory.CreateDirectory(pathString);

            // Create a file name for the file you want to create. 
            string fileName = finalAddress;

            // Use Combine again to add the file name to the path.
            string pathString1 = System.IO.Path.Combine(pathString, fileName);

            // Verify the path that you have constructed.
            Console.WriteLine("Path to my file: {0}\n", pathString1);

            // Check that the file doesn't already exist. If it doesn't exist, create
            // the file and write integers 0 - 99 to it.
            // DANGER: System.IO.File.Create will overwrite the file if it already exists.
            // This could happen even with random file names, although it is unlikely.
            if (!System.IO.File.Exists(pathString1))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString1))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                    fs.Close();
                }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return "";
            }

            // Read and display the data from your file.
            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString1);
                foreach (byte b in readBuffer)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (System.IO.IOException eexcep)
            {
                Console.WriteLine(eexcep.Message);
            }

            return pathString;
        }

        
        /*
         * Controls the arrow keys on the designer page. Makes the current one invisible 
         * and the next one visible when you click the arrow. Ensure you don't go past the last one
         * or before the first.
         
        private void nextVisible()
        {
            if (currentPage == 0)
            {
                grbBuilding.Visible = true;
                grbEnviornmental.Visible = false;
                grbUtility.Visible = false;               
            }
            if (currentPage == 1)
            {
                grbBuilding.Visible = false;
                grbEnviornmental.Visible = true;
                grbUtility.Visible = false;
            }
            if (currentPage == 2)
            {
                grbBuilding.Visible = false;
                grbUtility.Visible = true;
                grbEnviornmental.Visible = false;
            }

            //Keeps the current page within the bounds of the pages
            if (currentPage >= 2)
                currentPage = 2;
            if (currentPage <= 0)
                currentPage = 0;
            
        }


        int currentPage = 0;
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            currentPage = currentPage + 1;
            nextVisible();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentPage = currentPage - 1;
            nextVisible();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                price += 100;
                boxPrice.Text = price.ToString();
            }
            else
            {
                price -= 100;
                boxPrice.Text = price.ToString();
            }
            
        }
        */
        /*
         * Adds to the price depending on if certain checkboxes are clicked
         */
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                price += 100;
                boxPrice.Text = price.ToString();
            }
            else
            {
                price -= 100;
                boxPrice.Text = price.ToString();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                price += 300;
                boxPrice.Text = price.ToString();
            }
            else
            {
                price -= 300;
                boxPrice.Text = price.ToString();
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                price += 300;
                boxPrice.Text = price.ToString();
            }
            else
            {
                price -= 300;
                boxPrice.Text = price.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateCheckInfo info;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
