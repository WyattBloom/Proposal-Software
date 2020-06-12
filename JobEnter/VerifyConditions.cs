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
using Smartsheet.Api.Models;
using System.Security.Cryptography.X509Certificates;

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

        }


        public void addToBox(String txtToAdd)
        {
            if(txtToAdd != null) 
                lbox1.Items.Add(txtToAdd);
        }

        public void addToBox(List<String> listToAdd)
        {
            foreach(String s in listToAdd)
            {
                lbox1.Items.Add(s);
            }
        }

        public void addToBox(String n, String num, String e, String a, String c, String s, String z, String SI)
        {
            lbox1.Items.Add("Name: " + n);
            lbox1.Items.Add("Number: " + num);
            lbox1.Items.Add("Email: " + e);
            lbox1.Items.Add("Address: " + a);
            lbox1.Items.Add("City: " + c);
            lbox1.Items.Add("State: " + s);
            lbox1.Items.Add("Zip: " + z);
            lbox1.Items.Add("Special Instructions:" + SI);
        }

        public string Price
        {
            get { return boxPrice.Text; }   // get method
            set { boxPrice.Text = value; }  // set method
        }

        public String StakePrice
        {
            get { return boxStakePrice.Text; }
            set { boxStakePrice.Text = value; }
        }

        public String Days
        {
            get { return boxDays.Text; }
            set { boxDays.Text = value; }
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

        public void clearAll()
        {
            clearBox();
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }


        public void clearBox()
        {
            lbox1.Items.Clear();
        }

    }
}
