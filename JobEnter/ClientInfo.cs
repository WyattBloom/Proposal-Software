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
    public partial class ClientInfo : UserControl
    {
        public ClientInfo()
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

        #endregion



        private void ClientInfo_Load(object sender, EventArgs e)
        {

        }

        public void updateVariables()
        {
            name = boxName.Text;
            number = boxNumber.Text;
            address = boxAddress.Text;
            city = boxCity.Text;
            state = boxState.Text;
            zip = boxZip.Text;
            email = boxEmail.Text;
        }

        #region Getters and Setters

        public string Name   
        {
            get { return boxName.Text; }   // get method
            set { name = value; }  // set method
        }

        public string Number   
        {
            get { return boxNumber.Text; }   // get method
            set { number = value; }  // set method
        }

        public string Address
        {
            get { return boxAddress.Text; }   // get method
            set { address = value; }  // set method
        }

        public string Email
        {
            get { return boxEmail.Text; }   // get method
            set { email = value; }  // set method
        }

        public string City
        {
            get { return boxCity.Text; }   // get method
            set { city = value; }  // set method
        }

        public string State
        {
            get { return boxState.Text; }   // get method
            set { state = value; }  // set method
        }

        public string Zip
        {
            get { return boxZip.Text; }   // get method
            set { zip = value; }  // set method
        }
        #endregion
    }
}
