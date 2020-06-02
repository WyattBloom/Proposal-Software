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
        private string[] newHomeStrings = System.IO.File.ReadAllLines("NewHomeConditions.txt");
        private string[] additionStrings = System.IO.File.ReadAllLines("Addition.txt");

        String city;

        private void NewHomeServices_Load(object sender, EventArgs e)
        {
            updateCity(city);
        }

        public void updateCity(String city)
        {
            city = this.getCity();
            checkedListBox1.Items.Clear();
            if (this.getCity() == "Minneapolis")
            {
                checkedListBox1.Items.AddRange(newHomeStrings);
            }
            else if (this.getCity() == "Edina")
            {
                checkedListBox1.Items.AddRange(additionStrings);
            }
        }


        public void setCity(String c)
        {
            this.city = c;
            updateCity(c);
        }
        public String getCity()
        {
            return this.city;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<String> getAllSelectedStrings()
        {
            List<String> selectedStrings = new List<String>();

            foreach (String s in checkedListBox1.CheckedItems)
            {
                selectedStrings.Add(s);
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
