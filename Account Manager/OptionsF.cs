using System;
using System.Linq;
using System.Windows.Forms;

namespace Account_Manager
{
    public partial class OptionsF : Form
    {
        public OptionsF()
        {
            InitializeComponent();
            doubleClickCB.SelectedIndex = 0;
        }

        #region Buttons

        void cancelB_Click(object sender, EventArgs e)
        {
            Close();
        }

        void acceptB_Click(object sender, EventArgs e)
        {
            Accept();
        }

        void Accept() {
            MainWindowF f = (Application.OpenForms["MainWindowF"] as MainWindowF);
            switch (doubleClickCB.SelectedIndex) {
                case 0:
                    f.prefs.DoubleClick = MainWindowF.DoubleClickOptions.CopyPass;
                    break;
                case 1:
                    f.prefs.DoubleClick = MainWindowF.DoubleClickOptions.OpenSite;
                    break;
            }

            f.SavePreferences();
            Close();
        }

        #endregion
    }
}
