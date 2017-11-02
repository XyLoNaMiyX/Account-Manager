
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Account_Manager
{
    public partial class FirstTimeF : Form
    {	
        public FirstTimeF()
        {
            InitializeComponent();
        }

        void acceptB_Click(object sender, EventArgs e)
        {
            Continue();
        }

        void Continue()
        {
            if (firstPassTB.Text.Length < 4)
            	MessageBox.Show("La contraseña es demasiado corta. Introduzca otra contraseña", "Caracteres insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (showPassCB.Checked)
                    Accept();
                else
                    if (firstPassTB.Text == secondPassTB.Text)
                        Accept();
                    else
            		{
            			MessageBox.Show("Las contraseñas no coinciden. Vuelva a intentarlo",
        	                "Las contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        secondPassTB.SelectAll();
                    }
        }

        void Accept()
        {
        	if (!Directory.Exists(Program.PwPath))
            	Directory.CreateDirectory(Program.PwPath);

            string pwtext = Crypter.Encrypt(firstPassTB.Text, "lW S#ftW4r€");
            File.WriteAllText(Program.PwFile, pwtext);
            File.SetAttributes(Program.PwPath, FileAttributes.ReadOnly | FileAttributes.Hidden | 
                FileAttributes.System);

            var t = new Thread(new ThreadStart(() => Application.Run(new MainWindowF())));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            Close();
        }

        void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        void showPassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCB.Checked)
            {
                firstPassTB.PasswordChar = '\0';
                info2L.Visible = false;
                secondPassTB.Visible = false;
            }
            else
            {
                firstPassTB.PasswordChar = '●';
                info2L.Visible = true;
                secondPassTB.Visible = true;
            }
        }

        void firstPassTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                secondPassTB.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        void secondPassTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Continue();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
