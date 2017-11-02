using System;
using System.Linq;
using System.Windows.Forms;

namespace Account_Manager
{
    public partial class AddAccountF : Form
    {
        public AddAccountF(string[] variables)
        {
            InitializeComponent();
            options = variables;
        }
		
        readonly string[] options = new string[6];

        #region Setup

        void AddAccountF_Load(object sender, EventArgs e)
        {
            if (options[4] != "")
            {
                siteTB.Text = options[0];
                emailTB.Text = options[1];
                userTB.Text = options[2];
                passTB.Text = options[3];
                Text = options[4];
            }
        }

        #endregion

        #region Key down
        void siteTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                emailTB.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        void emailTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                userTB.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        void userTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passTB.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        void passTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Accept();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        #endregion

        #region Preferences
        void showPassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCB.Checked)
                passTB.PasswordChar = '\0';
            else
                passTB.PasswordChar = '●';
        }
        #endregion

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

            if (options[5] == "")
            {

                if (f.AddAccount(new MainWindowF.Account(siteTB.Text, emailTB.Text,
                        userTB.Text, passTB.Text)) < 2)
                    Close();
                else
                {
                    siteTB.Focus();
                    siteTB.SelectAll();
                }
            }
            else
            {
                f.EditAccount(new MainWindowF.Account(siteTB.Text, emailTB.Text, 
                    userTB.Text, passTB.Text), Int32.Parse(options[5]));
                Close();
           }
        }

        #endregion
    }
}
