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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private String accessToken;
        private String sheetName;

        private void Settings_Load(object sender, EventArgs e)
        {
            boxAccess.Text = accessToken;
            boxSName.Text = sheetName;
        }

        public String AccessToken
        {
            get { return accessToken; }
            set { accessToken = value; }
        }

        public String SheetName
        {
            get { return sheetName; }
            set { sheetName = value; }
        }


    }
}
