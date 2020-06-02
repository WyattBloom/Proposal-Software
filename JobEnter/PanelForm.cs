using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void PanelForm_Load(object sender, EventArgs e)
        {

        }




        #region Variables
        #endregion

        private void btnNext_Click(object sender, EventArgs e)
        {
            clientInfo1.Visible = true;
            selectServices1.Visible = false;

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            clientInfo1.Visible = false;
            verifyConditions1.Visible = false;
            selectServices1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verifyConditions1.Visible = true;
            selectServices1.Visible = false;
            clientInfo1.Visible = false;
            verifyConditions1.addToBox("Test Text 2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectServices1.setCity("Minneapolis");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectServices1.setCity("Edina");
        }
    }
}
