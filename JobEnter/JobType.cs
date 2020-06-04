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
    public partial class JobType : UserControl
    {
        public JobType()
        {
            InitializeComponent();
        }

        private String jobType { get; set; }
        private Boolean changed = false;

        private void JobType_Load(object sender, EventArgs e)
        {

        }


        public String getSelectedButton()
        {
            var checkedButton = panel1.Controls.OfType<RadioButton>()
              .FirstOrDefault(r => r.Checked);

            if (checkedButton != null)
                return checkedButton.Text;
            else
                return "";
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



    }
}
