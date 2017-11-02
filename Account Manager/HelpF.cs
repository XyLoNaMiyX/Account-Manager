using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Manager
{
    public partial class HelpF : Form
    {
        public HelpF()
        {
            InitializeComponent();
        }

        void HelpF_Load(object sender, EventArgs e)
        {
            string rtf = Properties.Resources.help;
            helpRTB.Rtf = rtf;
        }
    }
}
