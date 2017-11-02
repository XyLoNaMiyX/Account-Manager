using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace UpdateChecker
{
    public class UpdateChecker : Form
    {
		
		#region Designer
		
        Button checkB;
        Label infoL;
        ProgressBar checkingPB;
		
        IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
			
            base.Dispose(disposing);
        }
		
		void InitializeComponent()
        {
        	ComponentResourceManager resources = new ComponentResourceManager(typeof(UpdateChecker));
        	checkB = new Button();
        	infoL = new Label();
        	checkingPB = new ProgressBar();
        	SuspendLayout();
        	// 
        	// checkB
        	// 
			checkB.Text = "Comprobar actualizaciones";
        	checkB.Location = new Point(12, 82);
        	checkB.Name = "checkB";
        	checkB.Size = new Size(288, 23);
        	checkB.TabIndex = 0;
        	checkB.UseVisualStyleBackColor = true;
        	checkB.Click += new System.EventHandler(checkB_Click);
        	// 
        	// infoL
        	// 
			infoL.Text = "Presione el botón de \"Comprobar actualizaciones\" para\r\ncomprobar si existe una nueva versión de este programa";
        	infoL.AutoSize = true;
        	infoL.Location = new Point(13, 13);
        	infoL.Name = "infoL";
        	infoL.Size = new Size(278, 26);
        	infoL.TabIndex = 1;
        	// 
        	// checkingPB
        	// 
        	checkingPB.Location = new Point(12, 53);
        	checkingPB.MarqueeAnimationSpeed = 0;
        	checkingPB.Name = "checkingPB";
        	checkingPB.Size = new Size(288, 23);
        	checkingPB.Style = ProgressBarStyle.Marquee;
        	checkingPB.TabIndex = 2;
        	// 
        	// UpdateChecker
        	// 
			Text = "Comprobar actualizaciones";
        	AutoScaleDimensions = new SizeF(6F, 13F);
        	AutoScaleMode = AutoScaleMode.Font;
        	ClientSize = new Size(312, 113);
        	Controls.Add(checkingPB);
        	Controls.Add(infoL);
        	Controls.Add(checkB);
        	FormBorderStyle = FormBorderStyle.FixedSingle;
        	MaximizeBox = false;
        	MinimizeBox = false;
        	Name = "UpdateChecker";
        	ResumeLayout(false);
        	PerformLayout();

        }

        #endregion
		
        #region Variables and setup
		
		readonly byte[] icon = Convert.FromBase64String("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");

        public UpdateChecker(string filepath, string shortname)
        {
            InitializeComponent();
			using (MemoryStream ms = new MemoryStream(icon))
				Icon = new Icon(ms);

            CurrentVersion = GetVersionFromFile(filepath);
            FileShortname = shortname;
            Architecture = GetArchitecture(filepath);
        }

        int GetVersionFromFile(string file) {
            var versionInfo = FileVersionInfo.GetVersionInfo(file);
            string version = versionInfo.ProductVersion;

            return Int32.Parse(version.Replace(".", ""));
        }

        string GetArchitecture(string file) {
            var assembly = AssemblyName.GetAssemblyName(file);
            string sassembly = assembly.ProcessorArchitecture.ToString().ToLower();

            if (sassembly.Contains("64"))
                return "64";

            if (sassembly.Contains("86"))
                return "86";
            
           	return "";

        }

        int CurrentVersion;
        int NewVersion = 0;
        string FileShortname;
        string Filename = "Unknown";
        string Architecture;

        #endregion

        #region Check button

        void checkB_Click(object sender, EventArgs e)
        {
        	if (checkB.Text == "Actualizar")
                DownloadUpdate();
        	else if (checkB.Text == "Aceptar y salir")
                Close();
            else
                CheckUpdates();
        }

        #endregion

        #region Check updates

        void CheckUpdates()
        {
            checkingPB.MarqueeAnimationSpeed = 10;
            infoL.Text = "Comprobando actualizaciones...";

            Uri uri = new Uri ("http://lonamiwebs.github.io/_DOWNLOADS/checkupdates.php?q=" + FileShortname);
            string lwa = "permission=lwAccess";

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                wc.UploadStringCompleted += new UploadStringCompletedEventHandler(wc_UploadStringCompleted);

                try { wc.UploadStringAsync(uri, lwa); }
                catch { }
            }
        }


        void wc_UploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
        {
            if (e.Error != null) {
        		infoL.Text = "No se pudo comprobar si existen actualizaciones\r\nCompruebe que dispone de conexión a internet";
                return;
            }

            checkingPB.MarqueeAnimationSpeed = 0;
            checkingPB.Style = ProgressBarStyle.Continuous;

            NewVersion = Int32.Parse(e.Result);
            if (NewVersion > CurrentVersion) {
            	infoL.Text = "Se ha encontrado una nueva versión\r\nHaga clic en actualizar para descargarla automáticamente";
            	checkB.Text = "Actualizar";
            } else {
                infoL.Text = "Ya está utilizando la última versión\r\nNo es necesario actualizar";
                checkB.Text = "Aceptar y salir";
            }
        }

        #endregion

        #region Update

        void DownloadUpdate() {
            SetTextUpdating(0);
            checkB.Text = "Actualizando...";

            checkB.Enabled = false;

            string fileurl = new WebClient().DownloadString(
                "http://lonamiwebs.github.io/_DOWNLOADS/getfileurl.php?q=" + FileShortname + Architecture);

            Uri uri = new Uri(fileurl);
            Filename = fileurl.Split('/')[fileurl.Split('/').Length - 1].Replace("%20", "");

            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;

                wc.DownloadFileAsync(uri, Filename);
            }
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double percentage = (double)e.BytesReceived / (double)e.TotalBytesToReceive * 100d;
            SetTextUpdating(percentage);
            checkingPB.Value = e.ProgressPercentage;
        }

        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string path = Path.GetFullPath(Filename);
            if (MessageBox.Show("El programa se ha descargado correctamente.\r\n\r\nBorre la versión actual y extraiga el archivo comprimido descargado en:" + "\r\n" + path + "\r\n\r\n" + "¿Desea abrir la carpeta?", "Actualización descargada",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Process.Start(new ProcessStartInfo() { FileName = "explorer.exe",
                    Arguments = "/e, /select, \"" + path + "\""});

            Close();
        }

        void SetTextUpdating(double percentage)
        {
            string cv = String.Join(".", CurrentVersion.ToString("D" + 4).ToCharArray());
            string nv = String.Join(".", NewVersion.ToString("D" + 4).ToCharArray());
            infoL.Text = "Actualizando desde la versión " + cv +
               "\r\na la última versión disponible" + nv + "... " + percentage.ToString("F") + "%";
        }

        #endregion
    }
}
