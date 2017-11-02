using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Account_Manager
{
    public partial class MainWindowF : Form
    {
    	
        public MainWindowF()
        {
            InitializeComponent();
            
            if (!Directory.Exists(myAccs))
        		Directory.CreateDirectory(myAccs);

            try
            {
                Location = Properties.Settings.Default.WindowLocation;
                if (Location.X < 0 || Location.Y < 0)
                {
                	Location = new Point(0, 0);
                	Properties.Settings.Default.WindowLocation = Location;
                	Properties.Settings.Default.Save();
                }
                
                size = Properties.Settings.Default.WindowSize;

                siteCH.Width = Properties.Settings.Default.SiteWidth;
                emailCH.Width = Properties.Settings.Default.EmailWidth;
                nicknameCH.Width = Properties.Settings.Default.UserWidth;
                passwordCH.Width = Properties.Settings.Default.PassWidth;
            }
            catch {  }

            ActiveControl = lpassTB;
        }
    	
        #region Variables

        static readonly string acmpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            @"\LonamiWebs\Account Manager";
    	static readonly string myAccs = acmpath + "\\Mis cuentas";
		
        string userpw;
        string filter = "";

        bool loggedIn;

        Size size = new Size(500, 300);

        public enum DoubleClickOptions { CopyPass, OpenSite };

        public class Preferences
        {
        	public string LastOpenedFile;
        	public DoubleClickOptions DoubleClick;
        }

        public Preferences prefs = new Preferences();

        public class Account
        {
        	public string Site;
        	public string Mail;
        	public string User;
        	public string Pass;
            public string Extra;

            public Account(string site, string email, string user, string pass) {
                Site = site;
                Mail = email;
                User = user;
                Pass = pass;
            }
        }

        List<Account> _accounts = new List<Account>();
        
        public List<Account> accounts {
        	get {
				return filter == "" ? _accounts :
        			_accounts.Where(x => x.Site.ToLower().Contains(filter.ToLower())).ToList();
        	}
        	set { _accounts = value; }
        }
        
        #endregion

        #region Login

        void lexitB_Click(object sender, EventArgs e)
        { Close(); }

        void lcontinueB_Click(object sender, EventArgs e)
        { ContinueLogin(); }

        void lpassTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ContinueLogin();
        }

        void ContinueLogin()
        {
        	string svdpass = Crypter.Decrypt(File.ReadAllLines(Program.PwFile)[0], "lW S#ftW4r€");
            userpw = lpassTB.Text;
            if (userpw == svdpass)
                Login();
            else
            {
                lpassTB.SelectAll();
                linfoL.Text = "Contraseña incorrecta. Inténtelo de nuevo";
            }
        }

        void Login()
        {
            loginGB.Dispose();

            Size = size;
            accountsGB.Visible = true;
            menuS.Visible = true;
            informationSS.Visible = true;

            ReadPreferences();
            LoadAcc();
            loggedIn = true;
            
            ActiveControl = searchTB;
        }

        #endregion

        #region Preferences

        void ReadPreferences()
        {
            if (File.Exists(acmpath + @"\preferences.acp"))
                try
                {
                    string json = File.ReadAllLines(acmpath + @"\preferences.acp")[0];
                    json = Crypter.Decrypt(json, "lW S#ftW4r€");
                    prefs = JsonConvert.DeserializeObject<Preferences>(json);
                }
                catch {
                    infoTSSL.ForeColor = Color.Red;
                    infoTSSL.Text = "Hubo un error al leer las preferencias. Han sido reiniciadas";

                    prefs.LastOpenedFile = "";
                    prefs.DoubleClick = DoubleClickOptions.CopyPass;
                    SavePreferences();
                }
            else
            {
                infoTSSL.ForeColor = Color.Green;
                infoTSSL.Text = "Las preferencias se han creado correctamente";

                prefs.LastOpenedFile = "";
                prefs.DoubleClick = DoubleClickOptions.CopyPass;
                SavePreferences();
            }
        }

        public void SavePreferences()
        {
            try {
                string json = JsonConvert.SerializeObject(prefs);
                json = Crypter.Encrypt(json, "lW S#ftW4r€");
                File.WriteAllText(acmpath + @"\preferences.acp", json);
            }
            catch {
                infoTSSL.ForeColor = Color.Red;
                infoTSSL.Text = "Error al intentar guardar las preferencias. Otro programa debe tener abierto el archivo.";
            }
        }

        #endregion

        #region Context Menu Strip
        
        void copyPassTSMI_Click(object sender, EventArgs e)
        { CopyPassword(); }

        void CopyPassword()
        {
            Clipboard.SetText(accounts[aAccountsLV.SelectedIndices[0]].Pass);
            infoTSSL.ForeColor = Color.Green;
            infoTSSL.Text = "La contraseña se ha copiado correctamente al portapapeles";

        }
        void openSiteTSMI_Click(object sender, EventArgs e)
        { OpenSite(); }

        void OpenSite()
        {
            for (int i = 0; i < aAccountsLV.SelectedIndices.Count; i++) {
                string url = accounts[aAccountsLV.SelectedIndices[i]].Site;
                if (IsUrl(url))
                {
                    if (url.Contains("http://") || url.Contains("https://") || url.Contains("www."))
                        Process.Start(url);
                    else
                        Process.Start("http://" + url);

                    infoTSSL.ForeColor = Color.Green;
                    infoTSSL.Text = "Se ha abierto el sitio correctamente";

                }
                else
                {
                    infoTSSL.ForeColor = Color.Red;
                    infoTSSL.Text = "No se pudo abrir el sitio debido a que no es una URL válida";
                }
            }
        }

        void addAccountTSMI_Click(object sender, EventArgs e)
        { AddAccount(); }

        void editAccountTSMI_Click(object sender, EventArgs e)
        { EditAccount(); }

        void removeAccountTSMI_Click(object sender, EventArgs e)
        { RemoveAccount(); }

        void accountsCMS_Opening(object sender, CancelEventArgs e)
        {
            int c = aAccountsLV.SelectedIndices.Count;
            if (c > 1)
            {
                copyPassTSMI.Enabled = false;
                editAccountTSMI.Enabled = true;
                removeAccountTSMI.Enabled = true;

                int anyValid = -1;
                for (int i = 0; i < c; i++) {
                    string selectedSite = aAccountsLV.SelectedItems[i].SubItems[i].Text;
                    if (IsUrl(selectedSite))
                        anyValid++;
                }
                openSiteTSMI.Enabled = anyValid > -1;
            }
            else if (c > 0)
            {
                copyPassTSMI.Enabled = true;
                editAccountTSMI.Enabled = true;
                removeAccountTSMI.Enabled = true;
                string selectedSite = aAccountsLV.SelectedItems[0].SubItems[0].Text;
                openSiteTSMI.Enabled = IsUrl(selectedSite);
            }
            else {
                openSiteTSMI.Enabled = false;
                copyPassTSMI.Enabled = false;
                editAccountTSMI.Enabled = false;
                removeAccountTSMI.Enabled = false;
            }
        }

        bool IsUrl(string url) {
            if (url.Contains("http://") || url.Contains("https://") || url.Contains("www."))
                return true;

            if (url.Contains('.')) {
                string[] sp = url.Split('.');
                return sp[url.Count(c => c == '.')].Length == 2 || sp[url.Count(c => c == '.')].Length == 3;
            }
            
            return false;
        }

        #endregion

        #region Shortcuts

        void aAccountsLV_DoubleClick(object sender, EventArgs e)
        {
            if (aAccountsLV.SelectedIndices.Count > 0)
                switch (prefs.DoubleClick)
                {
                    case DoubleClickOptions.CopyPass:
                        CopyPassword();
                        break;
                    case DoubleClickOptions.OpenSite:
                        OpenSite();
                        break;
                }
        }

        void aAccountsLV_KeyDown(object sender, KeyEventArgs e)
        {
            if (aAccountsLV.SelectedIndices.Count > 0)
                if (e.KeyCode == Keys.Enter)
                    switch (prefs.DoubleClick)
                    {
                        case DoubleClickOptions.CopyPass:
                            CopyPassword();
                            break;
                        case DoubleClickOptions.OpenSite:
                            OpenSite();
                            break;
                    }
                else if (e.KeyCode == Keys.Delete)
                    RemoveAccount();
        }

        #endregion

        #region Save/load

        #region Save

        void SaveAcc() {
            if (prefs.LastOpenedFile != "")
                SaveAcc(prefs.LastOpenedFile);
            else
            {
                SaveFileDialog sfd = SaveAccPrompt();
                if (sfd != null)
                    SaveAcc(sfd.FileName);
            }
        }

        SaveFileDialog SaveAccPrompt()
        {   
        	Directory.CreateDirectory(myAccs);
        	accountsFileSFD.InitialDirectory = accountsFileSFD.InitialDirectory = myAccs;

			return accountsFileSFD.ShowDialog() == DialogResult.OK ? accountsFileSFD : null;
            
        }

        void SaveAcc(string path) {
            try {
                prefs.LastOpenedFile = path;
                SavePreferences();

                string json = JsonConvert.SerializeObject(_accounts);
                json = Crypter.Encrypt(json, userpw);
                File.WriteAllText(path, json);

                infoTSSL.ForeColor = Color.Green;
                infoTSSL.Text = "El archivo de cuentas se ha guardado correctamente";
            }
            catch {
                infoTSSL.ForeColor = Color.Red;
                infoTSSL.Text = "Error al intentar guardar el archivo actual con las cuentas. El archivo debe estar abierto por otro programa";

                if (MessageBox.Show("No se pudo guardar el archivo actual con las cuentas", "Error al guardar cuentas", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                    == DialogResult.Retry)
                    SaveAcc();
            }
        }

        #endregion

        #region Load

        void LoadAcc() {
            if (prefs.LastOpenedFile != "")
                LoadAcc(prefs.LastOpenedFile);
            else
            {
                if (loggedIn)
                {
                    OpenFileDialog ofd = LoadAccPrompt();
                    if (ofd != null)
                        LoadAcc(ofd.FileName);
                }
                else
                {
                	prefs.LastOpenedFile = myAccs + "\\cuentas.acf";
                    NewAccount(prefs.LastOpenedFile);
                }
            }
        }

        OpenFileDialog LoadAccPrompt()
        {
        	if (!Directory.Exists(myAccs))
        		Directory.CreateDirectory(myAccs);
        	accountsFileOFD.InitialDirectory = myAccs;

			return accountsFileOFD.ShowDialog() == DialogResult.OK ? accountsFileOFD : null;
        }

        void LoadAcc(string path)
        {
            prefs.LastOpenedFile = path;
            SavePreferences();
            try {
                string json = File.ReadAllLines(path)[0];
                json = Crypter.Decrypt(json, userpw);
                accounts = JsonConvert.DeserializeObject<List<Account>>(json);
                RefreshAccountsList();

                infoTSSL.ForeColor = Color.Green;
                if (accounts.Count == 1)
                    infoTSSL.Text = "Se ha cargado una cuenta correctamente";
                else
                    infoTSSL.Text = "Se han cargado " + accounts.Count + " cuentas correctamente";

            }
            catch {
            	if (MessageBox.Show("No se pudo cargar el archivo de cuenta seleccionado.\r\nEl archivo debe estar corrupto, dañado, o puede ser un archivo de cuentas inválido", "Error al cargar cuentas", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) ==
                    DialogResult.Retry)
                    LoadAcc();
                else {
                    infoTSSL.ForeColor = Color.Red;
                    infoTSSL.Text = "Hubo un error al cargar el archivo de cuentas. Es probable que este se encuentre dañado";
                }
            }
        }

        #endregion

        #endregion

        #region Account management

        void AddAccount() {
            new AddAccountF(new [] {"", "", "", "", "", ""}).Show();
        }

        public int AddAccount(Account account) {
            bool exists = false;
			foreach (Account a in _accounts)
				exists |= a.Site == account.Site;

            if (!exists)
            {
                _accounts.Add(account);
                SaveAcc();
                RefreshAccountsList();

                infoTSSL.ForeColor = Color.Green;
                infoTSSL.Text = "Se ha añadido una nueva cuenta correctamente";

                return 0;
            }
            
        	if (MessageBox.Show("No se pudo agregar la cuenta nueva debido a que ya existe una cuenta con ese sitio o aplicación", "Sitio ya existente", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                == DialogResult.Retry)
                return 2;
        
                infoTSSL.ForeColor = Color.Red;
                infoTSSL.Text = "No se pudo agregar la cuenta nueva debido a que ya existe una cuenta con ese sitio o aplicación";

                return 1;
        }

        public void EditAccount(Account account, int index)
        {
            _accounts[index].Site = account.Site;
            _accounts[index].Mail = account.Mail;
            _accounts[index].User = account.User;
           	_accounts[index].Pass = account.Pass;
            SaveAcc();
            RefreshAccountsList();

            infoTSSL.ForeColor = Color.Green;
            infoTSSL.Text = "Se ha editado la cuenta de" + " " + account.Site + " " + "correctamente";

        }

        void EditAccount()
        {
            for (int i = 0; i < aAccountsLV.SelectedIndices.Count; i++) {
            	int index = aAccountsLV.SelectedIndices[i];
            	string name = aAccountsLV.Items[index].SubItems[0].Text;
                Account account = _accounts.Where(x => x.Site == name).ToArray()[0];
                
                for (int j = 0; j < _accounts.Count; j++)
                	if (_accounts[j].Site == account.Site) {
                		index = j;
                		break;
                	}
                
                new AddAccountF(new [] {
                    account.Site,
                    account.Mail,
                    account.User,
                    account.Pass,
                    "Editar cuenta de" + " " + account.Site,
                    index.ToString()
                }).Show();
            }
        }

        void RemoveAccount() {
            int c = aAccountsLV.SelectedIndices.Count;
            for (int i = 0; i < c; i++) {
            	int index = aAccountsLV.SelectedIndices[i];
            	string name = aAccountsLV.Items[index].SubItems[0].Text;
            	_accounts.RemoveAll(x => x.Site == name);
            }

            SaveAcc();
            RefreshAccountsList();

            infoTSSL.ForeColor = Color.Green;
            infoTSSL.Text = c > 1 ?
            	"Has eliminado" + " " + c + " " + "cuentas correctamente" :
                "Has eliminado una cuenta correctamente";


        }

        void RefreshAccountsList() {
            aAccountsLV.Items.Clear();
            
            for (int i = 0; i < accounts.Count; i++)
            {
                string pass = "";

                pass = aShowpwCB.Checked ? pass = accounts[i].Pass :
                	new String('●', accounts[i].Pass.Length);

                var account = new ListViewItem(new[] { 
                    accounts[i].Site,
                    accounts[i].Mail,
                    accounts[i].User,
                    pass
                });
                aAccountsLV.Items.Add(account);
            }
        }

        #endregion

        #region Display options

        void aShowpwCB_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAccountsList();
        }

        #endregion

        #region Tool Strip Menu Items

        void newAccountsFileTSMI_Click(object sender, EventArgs e)
        {
            NewAccount();
        }

        void NewAccount()
        {
            SaveFileDialog sfd = SaveAccPrompt();
            if (sfd != null)
                NewAccount(sfd.FileName);
        }

        void NewAccount(string path)
        {
        	if (!Directory.Exists(myAccs))
        		Directory.CreateDirectory(myAccs);
            accounts = new List<Account>();
            SaveAcc(path);
            RefreshAccountsList();
        }

        void loadAccountFIleTSMI_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = LoadAccPrompt();
            if (ofd != null)
                LoadAcc(ofd.FileName);
        }
        void saveAccountFileAsTSMI_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = SaveAccPrompt();
            if (sfd != null)
                SaveAcc(sfd.FileName);
        }

        void accountscmsTSMI_Click(object sender, EventArgs e)
        {
            accountsCMS.Show();
        }

        void optionsTSMI_Click(object sender, EventArgs e)
        {
            new OptionsF().Show();
        }

        void tutorialTSMI_Click(object sender, EventArgs e)
        {
            new HelpF().Show();
        }

        void supportTSMI_Click(object sender, EventArgs e)
        {
            Process.Start("http://lonamiwebs.github.io/contacto.php?t=software&q=acm");
        }

        void exitTSMI_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Form closing

        void MainWindowF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowLocation = Location;

			Properties.Settings.Default.WindowSize = WindowState == FormWindowState.Normal ?
				Size : RestoreBounds.Size;
            
            Properties.Settings.Default.SiteWidth = siteCH.Width;
            Properties.Settings.Default.EmailWidth = emailCH.Width;
            Properties.Settings.Default.UserWidth = nicknameCH.Width;
            Properties.Settings.Default.PassWidth = passwordCH.Width;

            Properties.Settings.Default.Save();
        }

        #endregion

        void checkUpdatesTSMI_Click(object sender, EventArgs e)
        {
            new UpdateChecker.UpdateChecker(System.Reflection.Assembly.GetExecutingAssembly().Location, "acm").Show();
        }
        
		void SearchTBTextChanged(object sender, EventArgs e)
		{
			filter = searchTB.Text;
			RefreshAccountsList();
		}
		
		void SearchTBMouseClick(object sender, MouseEventArgs e)
		{
			searchTB.SelectAll();
		}

    }
}
