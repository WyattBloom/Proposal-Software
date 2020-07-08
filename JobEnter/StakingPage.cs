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
    public partial class StakingPage : UserControl
    {
        public StakingPage()
        {
            InitializeComponent();
        }

        private void StakingPage_Load(object sender, EventArgs e)
        {

        }

        public string Corner
        {
            get { return boxCorner.Text; }   // get method
            set { boxCorner.Text = value; }          // set method
        }

        public string STKPRice
        {
            get { return boxSTKPrice.Text; }   // get method
            set { boxSTKPrice.Text = value; }          // set method
        }
    }
}
