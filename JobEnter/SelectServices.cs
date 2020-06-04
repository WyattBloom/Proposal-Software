using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        private List<String> newHome    = new List<String>();
        private List<String> existing   = new List<String>();
        private List<String> proposed   = new List<String>();
        private string[] newHomeStrings; 
        private string[] additionStrings;
        private List<String> existingMinneapolis = new List<string>();
        private List<String> existingEdina       = new List<string>();

        private List<String> jobTypes = new List<String> { "One Stake", 
                                                    "Two Stake", 
                                                    "All Stake", 
                                                    "New Home", 
                                                    "Proposed", 
                                                    "Addition" };
        private List<String> cities   = new List<String> { "Edina",
                                                    "Minneapolis" };
        String city     { get; set; }
        String jobType  { get; set; }
        private String currType;
        #endregion

        private void NewHomeServices_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            try
            {
                newHomeStrings = File.ReadAllLines("NewHomeConditions.txt");
                additionStrings = File.ReadAllLines("Addition.txt");
                existingMinneapolis = File.ReadAllLines("Minneapolis-Existing.txt").ToList<String>();
            } catch (System.Exception ex) {
                Console.WriteLine("Unable to find file.");
            }

            foreach (String s in cities)
                comboBox1.Items.Add(s);
        }


        #region UI Updates

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            city = (comboBox1.SelectedItem.ToString());
            setCheckedTemplate(city);
            Console.WriteLine(comboBox1.SelectedItem.ToString());
        }

        #endregion

        #region Get Set Methods

        public void setCheckedTemplate(String cityIn)
        {
            switch (cityIn)
            {
                case "Minneapolis":
                    setSelectedFromList(existingMinneapolis);
                    break;
                case "Edina":
                    break;
            }
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
            List<String> selectedTitles = new List<string>();
            System.Collections.IEnumerator checkedList = checkedListBox1.CheckedItems.GetEnumerator();

            while (checkedList.MoveNext())
            {
                if (checkedList.Current.ToString().StartsWith("-"))
                {
                    String tempVal = checkedList.Current.ToString();
                    while (checkedList.MoveNext())
                    {
                        if (!checkedList.Current.ToString().StartsWith("-"))
                            Console.WriteLine(tempVal + ": " + checkedList.Current.ToString());
                        else
                            tempVal = checkedList.Current.ToString();
                    }
                }
            }
            return selectedTitles;
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

        public void setComboSelected(String input)
        {
            comboBox1.Text = input;
            updateCheckboxList(input);
        }

        public void setJobType(String jbIn) {   this.jobType = jbIn;    }
        public String getJobType() { return this.jobType; }
        public void setLabelText(String s)
        {
            if(currType == "")
            { label2.Text = s; }
            else if(currType == s)
            { }
            else
            {
                label2.Text = s;
                currType = label2.Text;
                checkedListBox1.Items.Clear();
            }
        }


        #endregion

        #region Other Methods

        public void clearBox() {   checkedListBox1.Items.Clear();   }

        public void updateCheckboxList(String type)
        {
            //checkedListBox1.Items.Clear();
            if (type == "New Home")
            {
                addToBox(newHomeStrings);
            }
            else if (type == "Addition")
            {
                addToBox(additionStrings);
            }
        }

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
                        s = s.ToUpper();
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

            int last = indexes.Last();
            for(int i = 0; i < indexes.Count-1; i++)
            {
                if(!i.Equals(last))
                {
                    Console.WriteLine("I: " + indexes[i]);
                    Console.WriteLine("For Header: " + indexes[i] + " | " + checkedListBox1.Items[indexes[i]].ToString());
                    Console.WriteLine("For Header: " + indexes[i+1] + " | " + checkedListBox1.Items[indexes[i+1]].ToString());
                    for(int j = indexes[i]; j < indexes[i+1]; j++)
                    {
                        if (checkedListBox1.GetItemChecked(j))
                            checkedListBox1.SetItemChecked(indexes[i], true);
                    }

                }
            }

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

    }
}
