using System;
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
            cmbCounty.Text = "";
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

        public String CountyBox
        {
            get { return cmbCounty.Text; }
            set { cmbCounty.Text = value; }
        }

        public String SpecialInstructions
        {
            get { return boxInstructions.Text; }
            set { boxInstructions.Text = value; }
        }

        #endregion

        private void boxCity_TextChanged(object sender, EventArgs e)
        {
            switch (boxCity.Text)
            {
                case "Anoka":
                case "Andover":
                case "Fridley":
                case "Bethel":
                case "Columbus":
                case "Circle Pines":
                case "Ham Lake":
                case "Coon Rapids":
                case "Oak Grove":
                case "Lino Lakes":
                    cmbCounty.Text = "Anoka";
                    break;
                case "Rogers":
                case "Minneapolis":
                case "Bloomington":
                case "Richfield":
                case "Golden Valley":
                case "Robbinsdale":
                case "Minnetonka":
                case "St. Louis Park":
                case "Maple Grove":
                case "Hopkins":
                case "Crystal":
                case "Orono":
                case "Brooklyn Center":
                case "Champlin":
                case "Excelsior":
                case "Brooklyn Park":
                case "Wayzata":
                case "Osseo":
                case "Mound":
                case "Plymouth":
                case "Minnetrista":
                case "New Hope":
                case "Edina":
                case "Dayton":
                case "Maple Plain":
                    cmbCounty.Text = "Hennepin";
                    break;
                case "Carver":
                case "New Germany":
                case "Chaska":
                case "Waconia":
                case "Victoria":
                case "Hamburg":
                case "Mayer":
                case "Watertown":
                case "Cologne":
                    cmbCounty.Text = "Carver";
                    break;
                case "Apple Valley":
                case "Rosemount":
                case "South St. Paul":
                case "Lilydale":
                case "Vermillion":
                case "Eagan":
                case "Farmington":
                case "Mendota Heights":
                case "Hampton":
                case "Lakeville":
                case "Inner Grove Heights":
                case "Randolph":
                case "Burnsville":
                case "West St. Paul":
                case "Mendota":
                    cmbCounty.Text = "Dakota";
                    break;
                case "St. Paul":
                case "Shoreview":
                case "Little Canada":
                case "Vadnais Heights":
                case "Gem Lake":
                case "Maplewood":
                case "New Brighton":
                case "North St. Paul":
                case "Falcon Heights":
                case "Lauderdale":
                case "Roseville":
                case "Arden Heights":
                case "Mounds View":
                case "North Heights":
                    cmbCounty.Text = "Ramsey";
                    break;
                case "Shakopee":
                case "Savage":
                case "Belle Plaine":
                case "Jordan":
                case "Elko New Market":
                case "Prior Lake":
                    cmbCounty.Text = "Scott";
                    break;
                case "Elk River":
                case "Big Lake":
                case "Zimmerman":
                case "Becker":
                case "Clear Lake":
                    cmbCounty.Text = "Sherburne";
                    break;
                case "Woodbury":
                case "Oakdale":
                case "Scandia":
                case "Dellwood":
                case "Landfall":
                case "Stillwater":
                case "Hugo":
                case "Bayport":
                case "Grant":
                case "Cottage Grove":
                case "Lake Elmo":
                case "Newport":
                case "Afton":
                case "Lakeland":
                case "Forest Lake":
                case "Lakeland Shores":
                    cmbCounty.Text = "Washington";
                    break;
                case "Buffalo":
                case "Maple Lake":
                case "Monticello":
                case "Cokato":
                case "Annandale":
                case "Howard Lake":
                case "Otsego":
                case "Albertville":
                case "Silver Creek":
                case "Delano":
                case "Waverly":
                case "St. Michael":
                case "Montrose":
                    cmbCounty.Text = "Wright";
                    break;
                default:
                    cmbCounty.Text = "";
                    break;

            }
            
        }
    }
}
