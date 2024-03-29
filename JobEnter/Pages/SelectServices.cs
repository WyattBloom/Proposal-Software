﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Windows.Forms;


namespace JobEnter
{
    public partial class SelectServices : UserControl
    {
        public SelectServices()
        {
            InitializeComponent();

            /*var heightField = typeof(CheckedListBox).GetField(
                "scaledListItemBordersHeight",
                BindingFlags.NonPublic | BindingFlags.Instance
                );

            var addedHeight = 10; // Some appropriate value, greater than the field's default of 2

            heightField.SetValue(comboBox1, addedHeight); // Where "clb" is your CheckedListBox
            */
        }

        #region Variables

        /* New Home
         * Platt
         * Lot Split
         */

        private List<String> newHome = new List<String>();
        private List<String> existing = new List<String>();
        private List<String> proposed = new List<String>();
        private string[] newHomeStrings;
        private string[] additionStrings;
        private string[] fullStrings;
        private string[] lotSplitStrings;
        private string[] altaStrings;
        private string[] platStrings;

        private String minniPath;
        private String edinaPath;
        private String stPaulPath;
        private String currentDir = Environment.CurrentDirectory;

        private List<String> edinaStrings = new List<string>();
        private List<String> minneapolisStrings = new List<string>();

        private List<String> existingMinneapolis = new List<string>();
        private List<String> newHomeMinneapolis = new List<string>();

        private List<String> jobTypes = new List<String> { "One Stake", "Two Stake", "All Stake", "New Home", "Full", "Addition", "Lot Split" };
        private List<String> cities = new List<String> { "Edina", "Minneapolis", "Minetonka", "St. Paul" };
        
        String city { get; set; }
        String jobType { get; set; }
        private String currType = "";
        #endregion

        private void NewHomeServices_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            try
            {
                newHomeStrings  = File.ReadAllLines(Path.Combine(currentDir, "Service Files", "New Home.txt"));
                additionStrings = File.ReadAllLines(Path.Combine(currentDir, "Service Files", "Addition.txt"));
                fullStrings     = File.ReadAllLines(Path.Combine(currentDir, "Service Files", "Full.txt"));
                lotSplitStrings = File.ReadAllLines(Path.Combine(currentDir, "Service Files", "Lot Split.txt"));
                altaStrings     = File.ReadAllLines(Path.Combine(currentDir, "Service Files", "ALTA Services.txt"));
                platStrings     = File.ReadAllLines(Path.Combine(currentDir, "Service Files", "Plat.txt"));
            } catch (System.Exception ex) {
                Console.WriteLine("Unable to find file. " + ex.Message);
            }

            foreach (String s in cities)
                comboBox1.Items.Add(s);
        }

        public void setSize(int width, int height)
        {
            checkedListBox1.Size = new System.Drawing.Size(width, height);
        }

        public void clearAll()
        {
            checkedListBox1.Items.Clear();
            comboBox1.SelectedItem = "";
        }


        #region Methods for Box input

        #region UI Updates

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            city = (comboBox1.SelectedItem.ToString());
            //setCheckedTemplate(city, jobType);
        }

        #endregion

        public void clearSelectedStrings()
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
        }

        private void checkAll()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        /*
         * Sets what items show up in the checked list box
         * Note: Only clears and updates the checkboxes if its different that the current one
         */
        public void setBoxesShown()
        {
            if (currType == jobType)
            { }
            else if (currType != jobType)
            {
                currType = jobType;
                label2.Text = currType;
                checkedListBox1.Items.Clear();
                showBoxes(jobType);
            }
        }

        /*
         * Experimental Method for handling what boxes show up in checklist box 1
         * Will handle only the boxes, should create a seperate method for setting certain ones to be checked depening on city
         */
        public void showBoxes(String jt)
        {
            showButtons(jt);
            switch (jt)
            {
                case "Full":
                    addToBox(fullStrings);
                    break;
                case "Addition":
                    addToBox(additionStrings);
                    break;
                case "New Home":
                    addToBox(newHomeStrings);
                    minniPath = Path.Combine(currentDir, "New Home-Minneapolis");
                    edinaPath = Path.Combine(currentDir, "New Home-Edina");
                    break;
                case "Lot Split":
                    addToBox(lotSplitStrings);
                    break;
                case "ALTA":
                    addToBox(altaStrings);
                    break;
                case "Plat":
                    addToBox(platStrings);
                    break;
            }
        }

        public void showButtons(String btn)
        {
            switch (btn)
            {
                case "Full":
                    btnBasic.Visible = true;
                    btnFullHC.Visible = true;
                    btnFullLake.Visible = true;
                    btnFullTopo.Visible = true;
                    btnFullWetland.Visible = true;
                    hideALTA();
                    break;
                case "ALTA":
                    btnTypAlta.Visible = true;
                    hideFull();
                    break;
                default:
                    hideFull();
                    hideALTA();
                    break;
            }
        }
        public void hideFull()
        {
            btnBasic.Visible = false;
            btnFullHC.Visible = false;
            btnFullLake.Visible = false;
            btnFullTopo.Visible = false;
            btnFullWetland.Visible = false;
        }
        public void hideALTA()
        {
            btnTypAlta.Visible = false;
        }

        public void setSelectedFromList1(List<String> listIn)
        {
            for (int i = 0; i < listIn.Count; i++)
            {
                if (checkedListBox1.Items.Contains(listIn[i]))
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                else
                {
                    if (listIn[i] != "")
                    {
                        checkedListBox1.Items.Add(listIn[i]);
                        checkedListBox1.SetItemChecked(this.getIndex(listIn[i]), true);
                    }
                }
            }
        }

        #endregion


        #region Get Set Methods


        public void setComboSelected(String input)
        {
            comboBox1.Text = input;
        }


        private void setSelectedFromList(List<String> listIn)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (listIn.Contains(checkedListBox1.Items[i].ToString()))
                    checkedListBox1.SetItemChecked(i, true);
            }
        }

        public List<String> getSelectedServices()
        {
            List<String> selectedStrings = new List<String>();
            foreach (String s in checkedListBox1.CheckedItems)
            {
                if (!s.StartsWith("-"))
                    selectedStrings.Add(s);
            }
            return selectedStrings;
        }

        public List<String> getTitles()
        {
            List<String> titles = new List<string>();
            foreach(String s in checkedListBox1.Items)
            {
                if (s.StartsWith("-"))
                    titles.Add(s);
            }
            return titles;
        }

        public List<String> getSelectedTitles()
        {
            List<String> selectedStrings = new List<String>();
            foreach (String s in checkedListBox1.CheckedItems)
            {
                if (s.StartsWith("-"))
                    selectedStrings.Add(s);
            }
            return selectedStrings;
        }

        public List<String> getNotTitles()
        {
            List<String> outList = new List<String>();
            foreach (String s in checkedListBox1.Items)
            {
                if (!checkedListBox1.CheckedItems.Contains(s))
                {
                    if(s.StartsWith("-"))
                        outList.Add(s);
                }
            }
            return outList;
        }

        public List<String> getTitlesAndList()
        {
            List<String> titleService = new List<string>();
            String servicesString = "";
            foreach(String s in checkedListBox1.Items)
            {
                if (s.StartsWith("-"))
                {
                    titleService.Add(servicesString);
                    servicesString = "";
                    titleService.Add(s);
                }
                else
                {
                    Console.WriteLine(getIndex(s) + " | " + checkedListBox1.GetItemCheckState(getIndex(s)) + " | " + "S: " + s);
                    if (checkedListBox1.GetItemChecked(getIndex(s)))
                    {
                        servicesString = servicesString += "■" + s + "\n";
                    }
                }
            }
            
            titleService.Add(servicesString);

            return titleService;
        }


        public int getIndex(String sIn)
        {
            return checkedListBox1.Items.IndexOf(sIn);
        }

        /*
         * Returns a list of all selected services from the check list box
         * Note: Excludes titles, only returns selected services
         */
        public List<String> getSelectedStrings()
        {
            List<String> outList = new List<string>();
            foreach (String s in checkedListBox1.CheckedItems)
                outList.Add(s);
            return outList;
        }

        public void setJobType(String jbIn) { this.jobType = jbIn; }
        public String getJobType() { return this.jobType; }

        /*
         * Sets all items from a passed path to checked in checklist box
         */
        private void setStringChecked(String templatePath)
        {
            foreach (String s in File.ReadLines(templatePath))
            {
                if (checkedListBox1.Items.Contains(s))
                {
                    checkedListBox1.SetItemChecked(checkedListBox1.Items.IndexOf(s), true);
                }
            }
        }


        #endregion

        #region Button Handlers

        /* 
         * Button Handler
         * Checks items in checkedListBox1 based off of the Full Topo template text file
         */
        private void btnBasic_Click(object sender, EventArgs e)
        {
            this.uncheckAll();

            String templatePath = Path.Combine(currentDir, "Service Files", "Basic Full.txt");
            setStringChecked(templatePath);
        }


        private void btnFullTopo_Click(object sender, EventArgs e)
        {
            this.uncheckAll();

            String templatePath = Path.Combine(currentDir, "Service Files", "Full topo.txt");
            setStringChecked(templatePath);
        }

        private void btnFullLake_Click(object sender, EventArgs e)
        {
            this.uncheckAll();

            String templatePath = Path.Combine(currentDir, "Service Files", "Full on lake.txt");
            setStringChecked(templatePath);
        }

        private void btnFullHC_Click(object sender, EventArgs e)
        {
            this.uncheckAll();

            String templatePath = Path.Combine(currentDir, "Service Files", "Full Topo HC.txt");
            setStringChecked(templatePath);
        }

        private void btnFullWetland_Click(object sender, EventArgs e)
        {
            this.uncheckAll();

            String templatePath = Path.Combine(currentDir, "Service Files", "Full wetland.txt");
            setStringChecked(templatePath);
        }


        private void btnTypAlta_Click(object sender, EventArgs e)
        {
            this.uncheckAll();

            String templatePath = Path.Combine(currentDir, "Service Files", "Typical ALTA.txt");
            setStringChecked(templatePath);
        }


        #endregion


        #region Other Methods

        /*
         * Clears all items in the checked list box
         */
        public void clearBox() { checkedListBox1.Items.Clear(); }

        /*
         * Adds all strings in an array to the checked list box
         * Note: Does not include Null values and empty Strings
         */
        public void addToBox(String[] listS)
        {
            if (listS != null)
            {
                for (int i = 0; i < listS.Length; i++)
                {
                    String s = listS[i];
                    if (s == "") { }
                    else if (!s.StartsWith("-"))
                        checkedListBox1.Items.Add(s);
                    else if (s.StartsWith("-"))
                    {
                        //s = s.ToUpper();
                        checkedListBox1.Items.Add(s);
                    }
                }
            }
        }



        #endregion

        #region Experimental

        /*
         * Selects all the headers based off of weather or not any of the items below it have been selected
         * 
         */
        public void selectHeaders()
        {
            if (checkedListBox1.Items.Count == 0)
                return;
            List<int> indexes = new List<int>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString().StartsWith("-"))
                    indexes.Add(i);
            }
            try
            {
                int last = indexes.Last();
                for (int i = 0; i < indexes.Count - 1; i++)
                {
                    if (!i.Equals(last))
                    {
                        for (int j = indexes[i]; j < indexes[i + 1]; j++)
                        {
                            if (checkedListBox1.GetItemChecked(j))
                                checkedListBox1.SetItemChecked(indexes[i], true);
                        }

                    }
                }
            }
            catch (System.Exception ex) { Console.WriteLine(ex); }

        }

        // Temp Method
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void uncheckAll()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        /*
         * Button to check all the items in the list box
         */
        private void button1_Click(object sender, EventArgs e)
        {
            this.uncheckAll();
        }

        /*
         * Button to uncheck all the items in the list box
         */
        private void button2_Click(object sender, EventArgs e)
        {
            checkAll();
        }
    }
}
