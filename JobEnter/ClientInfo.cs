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
            switch (boxCity.Text.ToLower())
            {
                case "anoka":
                case "andover":
                case "fridley":
                case "bethel":
                case "columbus":
                case "circle pines":
                case "ham lake":
                case "coon rapids":
                case "oak grove":
                case "lino lakes":
                    cmbCounty.Text = "Anoka";
                    break;
                case "rogers":
                case "minneapolis":
                case "bloomington":
                case "richfield":
                case "golden valley":
                case "robbinsdale":
                case "minnetonka":
                case "st. louis park":
                case "st louis park":
                case "maple grove":
                case "hopkins":
                case "crystal":
                case "orono":
                case "brooklyn center":
                case "champlin":
                case "excelsior":
                case "brooklyn park":
                case "wayzata":
                case "osseo":
                case "mound":
                case "plymouth":
                case "minnetrista":
                case "new hope":
                case "edina":
                case "dayton":
                case "maple plain":
                    cmbCounty.Text = "Hennepin";
                    break;
                case "carver":
                case "new germany":
                case "chaska":
                case "waconia":
                case "victoria":
                case "hamburg":
                case "mayer":
                case "watertown":
                case "cologne":
                    cmbCounty.Text = "Carver";
                    break;
                case "apple valley":
                case "rosemount":
                case "south st. paul":
                case "south st paul":
                case "lilydale":
                case "vermillion":
                case "eagan":
                case "farmington":
                case "mendota heights":
                case "hampton":
                case "lakeville":
                case "inner grove heights":
                case "randolph":
                case "burnsville":
                case "west st. paul":
                case "west st paul":
                case "mendota":
                    cmbCounty.Text = "Dakota";
                    break;
                case "st. paul":
                case "st paul":
                case "shoreview":
                case "little canada":
                case "vadnais heights":
                case "gem lake":
                case "maplewood":
                case "new brighton":
                case "north st. paul":
                case "north st paul":
                case "falcon heights":
                case "lauderdale":
                case "roseville":
                case "arden heights":
                case "mounds view":
                case "north heights":
                    cmbCounty.Text = "Ramsey";
                    break;
                case "shakopee":
                case "savage":
                case "belle plaine":
                case "jordan":
                case "elko new market":
                case "prior lake":
                    cmbCounty.Text = "Scott";
                    break;
                case "elk river":
                case "big lake":
                case "zimmerman":
                case "becker":
                case "clear lake":
                    cmbCounty.Text = "Sherburne";
                    break;
                case "woodbury":
                case "oakdale":
                case "scandia":
                case "dellwood":
                case "landfall":
                case "stillwater":
                case "hugo":
                case "bayport":
                case "grant":
                case "cottage Grove":
                case "lake Elmo":
                case "newport":
                case "afton":
                case "lakeland":
                case "forest lake":
                case "lakeland Shores":
                    cmbCounty.Text = "Washington";
                    break;
                case "buffalo":
                case "maple lake":
                case "monticello":
                case "cokato":
                case "annandale":
                case "howard lake":
                case "otsego":
                case "albertville":
                case "silver creek":
                case "delano":
                case "waverly":
                case "st. michael":
                case "st michael":
                case "montrose":
                    cmbCounty.Text = "Wright";
                    break;
                default:
                    cmbCounty.Text = "";
                    break;

            }
            
        }
    }
}
