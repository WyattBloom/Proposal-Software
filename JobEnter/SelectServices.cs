using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace JobEnter
{
    public partial class SelectServices : UserControl
    {
        public SelectServices()
        {
            InitializeComponent();
        }

        #region Variables

        private List<String> newHome = new List<String>();
        private List<String> existing = new List<String>();
        private List<String> proposed = new List<String>();
        private string[] newHomeStrings;
        private string[] additionStrings;
        private string[] proposedStrings;

        private List<String> edinaStrings = new List<string>();
        private List<String> minneapolisStrings = new List<string>();

        private List<String> existingMinneapolis = new List<string>();
        private List<String> newHomeMinneapolis = new List<string>();

        private List<String> jobTypes = new List<String> { "One Stake",
                                                    "Two Stake",
                                                    "All Stake",
                                                    "New Home",
                                                    "Proposed",
                                                    "Addition" };
        private List<String> cities = new List<String> { "Edina",
                                                    "Minneapolis" };
        String city { get; set; }
        String jobType { get; set; }
        private String currType = "";
        #endregion

        private void NewHomeServices_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            try
            {
                newHomeStrings = File.ReadAllLines("Service Files/New Home.txt");
                additionStrings = File.ReadAllLines("Service Files/Addition.txt");
                proposedStrings = File.ReadAllLines("Service Files/Existing.txt");
                //existingMinneapolis = File.ReadAllLines("Minneapolis-Existing.txt").ToList<String>();
            } catch (System.Exception ex) {
                Console.WriteLine("Unable to find file.");
            }

            foreach (String s in cities)
                comboBox1.Items.Add(s);
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
            setCheckedTemplate(city, jobType);
        }

        #endregion

        public void setCheckedTemplate(String cityIn)
        {
            Console.WriteLine("Set Checked Template(1)");
            switch (cityIn)
            {
                case "Minneapolis":
                    Console.WriteLine(minneapolisStrings.Count);
                    setSelectedFromList1(minneapolisStrings);
                    break;
                case "Edina":
                    Console.WriteLine(edinaStrings.Count);
                    setSelectedFromList1(edinaStrings);
                    break;
            }
        }

        public void clearSelectedStrings()
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
        }


        // Temp Method
        public void setCheckedTemplate(String city, String jobType)
        {
            Console.WriteLine("Job Type: " + jobType);

            setBoxesShown(jobType);
            checkedListBox1.Items.Clear();
            this.clearSelectedStrings();

            switch (jobType)
            {
                case "Proposed":
                    Console.WriteLine("Added Porposed 1");
                    addToBox(proposedStrings);
                    if (city == "Minneapolis")
                    {
                        minneapolisStrings.Clear();
                        minneapolisStrings = File.ReadAllLines("Service Files/Existing-Minneapolis.txt").ToList<String>();
                        setSelectedFromList1(minneapolisStrings);
                        Console.WriteLine("Proposed Minni");
                    }
                    else if (city == "Edina")
                    {
                        edinaStrings.Clear();
                        //edinaStrings = File.ReadAllLines(".txt").ToList<String>();
                        setSelectedFromList1(edinaStrings);
                        Console.WriteLine("Proposed Edina");
                    }
                    break;
                case "New Home":
                    Console.WriteLine("Added New Home 1");
                    addToBox(newHomeStrings);
                    if (city == "Minneapolis")
                    {
                        minneapolisStrings.Clear();
                        minneapolisStrings = File.ReadAllLines("Service Files/New Home-Minneapolis.txt").ToList<String>();
                        setSelectedFromList1(minneapolisStrings);
                        Console.WriteLine("New Minni");
                    }
                    else if (city == "Edina")
                    {
                        edinaStrings.Clear();
                        edinaStrings = File.ReadAllLines("Service Files/New Home-Edina.txt").ToList<String>();
                        setSelectedFromList1(edinaStrings);
                        Console.WriteLine("New Edina");
                    }
                    break;
                case "Addition":
                    Console.WriteLine("Added Addition 1");
                    addToBox(additionStrings);
                    if (city == "Minneapolis")
                    {
                        minneapolisStrings.Clear();
                        //minneapolisStrings = File.ReadAllLines(".txt").ToList<String>();
                        setSelectedFromList1(minneapolisStrings);
                        Console.WriteLine("Addition Minni");
                    }
                    else if (city == "Edina")
                    {
                        edinaStrings.Clear();
                        edinaStrings = File.ReadAllLines("Service Files/Addition-Edina.txt").ToList<String>();
                        setSelectedFromList1(edinaStrings);
                        Console.WriteLine("Addition Edina");
                    }
                    break;
            }
        }

        public void setShownAndChecked(String jobType, String city)
        {
            minneapolisStrings.Clear();
            edinaStrings.Clear();
            String fileName = (jobType + "-" + city + ".txt");
            Console.WriteLine(fileName);
        }

        public void setSelectedFromList1(List<String> listIn)
        {
            Console.WriteLine("Set Selected");
            for (int i = 0; i < listIn.Count; i++)
            {
                if (checkedListBox1.Items.Contains(listIn[i]))
                {
                    //Console.WriteLine("Contained: " + listIn[i]);
                    checkedListBox1.SetItemChecked(i, true);
                    //Console.WriteLine("Number " + i + ": " + checkedListBox1.Items[i]);
                }
                else
                {
                    if (listIn[i] != "")
                    {
                        //Console.WriteLine("Extra: " + listIn[i]);
                        checkedListBox1.Items.Add(listIn[i]);
                        checkedListBox1.SetItemChecked(this.getIndex(listIn[i]), true);
                    }
                }
            }
        }

        public void getEdinaStrings()
        {
            foreach(String s in edinaStrings)
            {
                Console.WriteLine(s);
            }
        }

        public void getAllStrings()
        {
            foreach(String s in newHomeStrings)
            {
                Console.WriteLine(s);
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
            String temp = "";
            foreach(String s in checkedListBox1.Items)
            {
                if (s.StartsWith("-"))
                {
                    titleService.Add(temp);
                    temp = "";
                    titleService.Add(s);
                }
                else
                {
                    if (checkedListBox1.GetItemChecked(getIndex(s)))
                    {
                        temp = temp += "■" + s + "\n";
                    }
                }
            }
            
            return titleService;
        }


        public int getIndex(String sIn)
        {
            return checkedListBox1.Items.IndexOf(sIn);
        }

        public List<int> getAllSelectedIndexes()
        {
            List<int> selectedIndexes = new List<int>();
            foreach (int i in checkedListBox1.CheckedItems)
                selectedIndexes.Add(i);
            return selectedIndexes;
        }

        public List<String> getSelectedStrings()
        {
            List<String> outList = new List<string>();
            foreach (String s in checkedListBox1.CheckedItems)
                outList.Add(s);
            return outList;
        }

        public void setJobType(String jbIn) { this.jobType = jbIn; }
        public String getJobType() { return this.jobType; }

        public void setBoxesShown(String s)
        {
            Console.WriteLine("Set Box List");
            if (currType == s)
            {  }
            else if (currType != s)
            {
                currType = s;
                label2.Text = currType;
                checkedListBox1.Items.Clear();
                //updateCheckboxList(s);
            }
        }

        public void updateCheckboxList(String type)
        {
            Console.WriteLine("Update Checkbox List: " + type);
            if (type == "New Home")
            {
                addToBox(newHomeStrings);
                edinaStrings = File.ReadAllLines("Service Files/New Home-Edina.txt").ToList<String>();
                minneapolisStrings = File.ReadAllLines("Service Files/New Home-Minneapolis.txt").ToList<String>();
            }
            else if (type == "Addition")
            {
                addToBox(additionStrings);
                edinaStrings = File.ReadAllLines("Service Files/Addition-Edina.txt").ToList<String>();
                minneapolisStrings = File.ReadAllLines("Service Files/New Home-Minneapolis.txt").ToList<String>();
            }
            else if (type == "Proposed")
            {
                addToBox(proposedStrings);
                minneapolisStrings = File.ReadAllLines("Service Files/Existing-Minneapolis.txt").ToList<String>();
            }
        }


        #endregion

        #region Other Methods

        public void clearBox() { checkedListBox1.Items.Clear(); }


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

        public void selectHeaders()
        {
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
                        //Console.WriteLine("I: " + indexes[i]);
                        //Console.WriteLine("For Header: " + indexes[i] + " | " + checkedListBox1.Items[indexes[i]].ToString());
                        //Console.WriteLine("For Header: " + indexes[i + 1] + " | " + checkedListBox1.Items[indexes[i + 1]].ToString());
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
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if (checkedListBox1.CheckedItems[i].ToString().StartsWith("-"))
                {
                    for (int j = i; j < checkedListBox1.CheckedItems.Count; j++)
                    {

                    }
                }
            }
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }
    }
}
