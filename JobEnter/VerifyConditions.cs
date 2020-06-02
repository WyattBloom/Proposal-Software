using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobEnter
{
    public partial class VerifyConditions : UserControl
    {
        public VerifyConditions()
        {
            InitializeComponent();
        }

        private void VerifyConditions_Load(object sender, EventArgs e)
        {
            lbox1.Items.Add("Test Text 1");
        }

        public void addToBox(String txtToAdd)
        {
            lbox1.Items.Add(txtToAdd);
        }

        public List<String> getTextFromBox()
        {
            List<String> returnList = new List<String>();

            foreach (int i in lbox1.Items)
            {
                returnList.Add(lbox1.GetItemText(i));
            }

            return returnList;
        }
    }
}
