using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.Office.Interop.Word;

namespace JobEnter
{
    public partial class JobType : UserControl
    {
        public JobType()
        {
            InitializeComponent();

            foreach (var item in panel1.Controls.OfType<RadioButton>())
            {
                item.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            }
        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                if(rb.Text == "New Home" || rb.Text == "Addition")
                {
                    groupBox1.Visible = true;
                }
                else
                {
                    groupBox1.Visible = false;
                }
            }
        }

        private String jobType { get; set; }
        private Boolean changed = false;

        private void JobType_Load(object sender, EventArgs e)
        {
            rbtnLumpSum.Checked = true;
        }


        public String getSelectedButton()
        {
            var checkedButton = panel1.Controls.OfType<RadioButton>()
              .FirstOrDefault(r => r.Checked);

            if (checkedButton != null)
            {
                return checkedButton.Text;
            }
            else
                return null;

        }

        public String getSelectedPrice()
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
              .FirstOrDefault(r => r.Checked);

            if (checkedButton != null)
            {
                return checkedButton.Text;
            }
            else
                return null;
        }

        public void setSelectedButton(String setText)
        {
            foreach(var x in panel1.Controls.OfType<RadioButton>())
            {
                if (x.Text == setText)
                    x.Checked = true;
                else
                    x.Checked = false;
            }
        }

        public Boolean jobChanged()
        {
            Boolean temp = changed;
            changed = false;
            return temp;
        }

        private void rbtnAddition_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnAddition.Checked == true)
            {

            }
        }
    }
}
