using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JobEnter
{
    public partial class SelectServices : UserControl
    {
        public SelectServices()
        {
            InitializeComponent();
        }

        private List<String> newHome = new List<String>();
        private List<String> existing = new List<String>();
        private List<String> proposed = new List<String>();
        private string[] newHomeStrings; 
        private string[] additionStrings;

        private List<String> cities = new List<String> { "One Stake", 
                                                    "Two Stake", 
                                                    "All Stake", 
                                                    "New Home", 
                                                    "Proposed", 
                                                    "Addition" };

        String city { get; set; }
        String jobType;

        private void NewHomeServices_Load(object sender, EventArgs e)
        {
            try
            {
                newHomeStrings = File.ReadAllLines("NewHomeConditions.txt");
                additionStrings  = File.ReadAllLines("Addition.txt");
            }catch(System.Exception ex)
            {
                Console.WriteLine("Unable to find file.");
            }


            foreach (String s in cities)
            {
                comboBox1.Items.Add(s);
            }
            updateJobType(city);
        }

        public void updateJobType(String type)
        {
            if (type == "New Home")
            {
                addToBox(newHomeStrings);
            }
            else if (type == "Addition")
            {
                addToBox(additionStrings);
            }
        }

        public void setSelectedIndex(String input)
        {
            comboBox1.Text = input;
            updateJobType(input);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();

            setJobType(comboBox1.SelectedItem.ToString());
            updateJobType(getJobType());
            Console.WriteLine(comboBox1.SelectedItem.ToString());
        }

        public void setJobType(String jbIn) { this.jobType = jbIn; }
        public String getJobType() { return this.jobType; }


        public void addToBox(String[] listS)
        {
            List<String> titles = new List<string>();
            for (int i = 0; i < listS.Length; i++)
            {
                String s = listS[i];
                if (s == "")
                {
                    
                }
                else if (!s.StartsWith("-"))
                {
                    checkedListBox1.Items.Add(s);
                }
                else if (s.StartsWith("-"))
                {
                    s = s.ToUpper();
                    checkedListBox1.Items.Add(s);
                }
            }
        }

        public void setCity(String c) {   this.city = c;  }
        public String getCity() {   return this.city;   }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if (checkedListBox1.CheckedItems[i].ToString().StartsWith("-"))
                {
                    for(int j = i; j < checkedListBox1.CheckedItems.Count; j++)
                    {

                    }
                }
            }
        }

        public List<String> getSelectedServices()
        {
            List<String> selectedStrings = new List<String>();

            foreach (String s in checkedListBox1.CheckedItems)
            {
                if (!s.StartsWith("-"))
                {
                    selectedStrings.Add(s);
                }
            }
            return selectedStrings;
        }

        public void getTitles()
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
        }

        public List<String> getSelectedTitles()
        {
            List<String> selectedStrings = new List<String>();

            foreach (String s in checkedListBox1.CheckedItems)
            {
                if (s.StartsWith("-"))
                {
                    selectedStrings.Add(s);
                }
            }
            return selectedStrings;
        }

        public List<int> getAllSelectedIndexes()
        {
            List<int> selectedIndexes = new List<int>();

            foreach (int i in checkedListBox1.CheckedItems)
            {
                selectedIndexes.Add(i);
            }
            return selectedIndexes;
        }


    }
}
