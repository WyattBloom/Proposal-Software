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
        private String county;

        #endregion



        private void ClientInfo_Load(object sender, EventArgs e)
        {

        }

        public void clearAll()
        {
            boxName.Text = "";
            boxEmail.Text = "";
            boxNumber.Text = "";
            boxAddress.Text = "";
            boxCity.Text = "";
            boxCounty.Text = "";
            boxInstructions.Text = "";
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
            set { boxNumber.Text = value; }  // set method
        }

        public string Address
        {
            get { return boxAddress.Text; }   // get method
            set { boxAddress.Text = value; }  // set method
        }

        public string Email
        {
            get { return boxEmail.Text; }   // get method
            set { boxEmail.Text = value; }  // set method
        }

        public string City
        {
            get { return boxCity.Text; }   // get method
            set { boxCity.Text = value; }  // set method
        }

        public string County
        {
            get { return boxCounty.Text; }   // get method
            set { boxCounty.Text = value; }  // set method
        }

        public String SpecialInstructions
        {
            get { return boxInstructions.Text; }
            set { boxInstructions.Text = value; }
        }

        #endregion
    }
}
