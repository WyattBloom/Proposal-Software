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
            name = clientInfo1.Name;
            number = clientInfo1.Number;
            address = clientInfo1.Address;
            email = clientInfo1.Email;
            city = clientInfo1.City;
            state = clientInfo1.State;
            zip = clientInfo1.Zip;
        }



        #region Button Click Methods

        private void btnClientInfo_Click(object sender, EventArgs e)
        {
            count = 0;
            showHide(count);
        }

        private void btnSelectServices_Click(object sender, EventArgs e)
        {
            count = 1;
            Console.WriteLine(clientInfo1.City);
            selectServices1.setCity(clientInfo1.City);

            showHide(count);
        }

        private void btnPricingPage_Click(object sender, EventArgs e)
        {
            count = 2;
            showHide(count);

            verifyPage.clearBox();

            Console.WriteLine(clientInfo1.Name);
            Console.WriteLine(clientInfo1.Address);

            verifyPage.addToBox(clientInfo1.Name);
            verifyPage.addToBox(clientInfo1.Address);
        }

        #endregion

        private void verifyConditions1_Load(object sender, EventArgs e)
        {

        }

        private void showHide(int num)
        {
            switch (num)
            {
                case 0:
                    clientInfo1.Visible = true;
                    selectServices1.Visible = false;
                    verifyPage.Visible = false;
                    break;
                case 1:
                    clientInfo1.Visible = false;
                    verifyPage.Visible = false;
                    selectServices1.Visible = true;
                    break;
                case 2:
                    verifyPage.Visible = true;
                    selectServices1.Visible = false;
                    clientInfo1.Visible = false;
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            count++;
            showHide(count);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            count--;
            showHide(count);
        }

        private void verifyConditions2_Load(object sender, EventArgs e)
        {
            updateMethods();
            verifyPage.addToBox(clientInfo1.Name);
            verifyPage.addToBox(clientInfo1.Address);
            verifyPage.addToBox(clientInfo1.Number);
            verifyPage.addToBox(clientInfo1.City);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectServices1.getTitles();
        }
    }
}
