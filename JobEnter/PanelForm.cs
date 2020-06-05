using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobEnter
{
    public partial class PanelForm : Form
    {
        public PanelForm()
        {
            InitializeComponent();
        }

        #region Variables

        private String name;
        private String number;
        private String address;
        private String email;
        private String city;
        private String state;
        private String zip;

        private int count = 0;
        #endregion


        private void PanelForm_Load(object sender, EventArgs e)
        {
            count = 0;
            updateMethods();
        }

        public void updateMethods()
        {
            name    = clientInfo1.Name;
            number  = clientInfo1.Number;
            address = clientInfo1.Address;
            email   = clientInfo1.Email;
            city    = clientInfo1.City;
            state   = clientInfo1.State;
            zip     = clientInfo1.Zip;
        }



        #region Button Click Methods

        private int countMax = 3;

        private void btnClientInfo_Click(object sender, EventArgs e)
        {
            count = 0;
            showHide(count);
        }

        private void btnJobType_Click(object sender, EventArgs e)
        {
            count = 1;
            showHide(count);

            //jobType1.setSelectedButton(selectServices1.getJobType());
        }

        private void btnSelectServices_Click(object sender, EventArgs e)
        {
            count = 2;
            Console.WriteLine(clientInfo1.City);
            showHide(count);
        }

        private void btnPricingPage_Click(object sender, EventArgs e)
        {
            count = 3;
            showHide(count);
        }

        private void showHide(int num)
        {
            switch (num)
            {
                case 0:
                    clientInfo1.Visible     = true;
                    selectServices1.Visible = false;
                    verifyPage.Visible      = false;
                    jobType1.Visible        = false;
                    break;
                case 1:
                    jobType1.Visible        = true;
                    clientInfo1.Visible     = false;
                    verifyPage.Visible      = false;
                    selectServices1.Visible = false;
                    break;
                case 2:
                    selectServices1.Visible = true;
                    verifyPage.Visible      = false;
                    clientInfo1.Visible     = false;
                    jobType1.Visible        = false;

                    selectServices1.setComboSelected(clientInfo1.City);
                    selectServices1.setLabelText(jobType1.getSelectedButton());
                    selectServices1.updateCheckboxList(jobType1.getSelectedButton());
                    break;
                case 3:
                    verifyPage.Visible      = true;
                    selectServices1.Visible = false;
                    jobType1.Visible        = false;
                    clientInfo1.Visible     = false;

                    selectServices1.selectHeaders();
                    verifyPage.clearBox();
                    verifyPage.addToBox(clientInfo1.Name,
                                        clientInfo1.Number,
                                        clientInfo1.Email,
                                        clientInfo1.Address,
                                        clientInfo1.State,
                                        clientInfo1.City,
                                        clientInfo1.Zip);
                    verifyPage.addToBox(selectServices1.getSelectedTitles());
                    //verifyPage.addToBox();
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e) 
        {
            if (!(count + 1 > countMax))
                count++;
            else
                count = countMax;

            showHide(count);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (!(count - 1 < 0))
                count--;
            else
                count = 0;
            showHide(count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectServices1.selectHeaders();
        }

        #endregion

        #region Update Pages

        // Write methods that will be called when each page becomes visible
        // Ex. Set selected services label and city
        // .. Set Put all info into verify conditions


        #endregion

        #region Load Events

        private void verifyConditions1_Load(object sender, EventArgs e)
        {

        }




        private void verifyConditions2_Load(object sender, EventArgs e)
        {
            updateMethods();
            verifyPage.addToBox(clientInfo1.Name);
            verifyPage.addToBox(clientInfo1.Address);
            verifyPage.addToBox(clientInfo1.Number);
            verifyPage.addToBox(clientInfo1.City);
        }

        private void selectServices1_Load(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
