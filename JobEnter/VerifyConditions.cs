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

        public void hideCTFBoxes(Boolean hide)
        {
            if(hide == true)
            {
                checkTom.Visible   = false;
                checkWayne.Visible = false;
                lblCTF.Visible     = false;
            }
            else
            {
                checkWayne.Visible = true;
                checkTom.Visible   = true;
                lblCTF.Visible     = true;
            }
        }

        public void hideStakePrice(Boolean hide)
        {
            if (hide == true)
            {
                boxStakePrice.Visible = false;
                lblStakePrice.Visible = false;
            }
            else
            {
                boxStakePrice.Visible = true;
                lblStakePrice.Visible = true;
            }
        }

        public String getGIS(String city)
        {
            String outVal = "";
            switch (city)
            {
                case "Hennepin":
                    outVal = "https://gis.hennepin.us/property/map/";
                    break;
                case "Ramsey":
                    outVal = "https://beacon.schneidercorp.com/application.aspx?app=RamseyCountyMN&PageType=Search";
                    break;
                case "Anoka":
                    outVal = "http://gis.anokacountymn.gov/";
                    break;
                case "Carver":
                    outVal = "https://gis.co.carver.mn.us/publicparcel/";
                    break;
                case "Washington":
                    outVal = "https://wcmn.maps.arcgis.com/apps/webappviewer/index.html?id=5c2fe2b598e744afbc07cc0550162984";
                    break;
                case "Dakota":
                    outVal = "https://gis.co.dakota.mn.us/DCGIS/";
                    break;
                case "Scott":
                    outVal = "https://gis.co.scott.mn.us/sg3/";
                    break;
                case "Sherburne":
                    outVal = "https://beacon.schneidercorp.com/?site=SherburneCountyMN";
                    break;
                case "Wright":
                    outVal = "https://beacon.schneidercorp.com/Application.aspx?App=WrightCountyMN";
                    break;
            }
            return outVal;
        }

        public void setStakePrice(String price)
        {
            boxStakePrice.Text = price;
        }

        public String getCTF()
        {
            var list = panel1.Controls.OfType<CheckBox>().Where(x => x.Checked == true);
            String output = "";
            foreach(CheckBox s in list)
            {
                output = output + s.Text;
            }
            return output;
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

        public void addToBox(String n, String num, String e, String a, String c, String s, String SI)
        {
            lbox1.Items.Add("Name: " + n);
            lbox1.Items.Add("Number: " + num);
            lbox1.Items.Add("Email: " + e);
            lbox1.Items.Add("Address: " + a);
            lbox1.Items.Add("City: " + s);
            lbox1.Items.Add("County: " + c);
            lbox1.Items.Add("Special Instructions: " + SI);
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
                    else if (control is CheckBox)
                        (control as CheckBox).Checked = false;
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
