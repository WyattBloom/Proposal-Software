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
        private String corner;

        private void StakingPage_Load(object sender, EventArgs e)
        {

        }

        public string Corner
        {
            get { return boxCorner.Text; }   // get method
            set { corner = value; }          // set method
        }
    }
}
