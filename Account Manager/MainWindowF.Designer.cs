namespace Account_Manager
{
    partial class MainWindowF
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name=Strings.str0>true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowF));
            this.accountsGB = new System.Windows.Forms.GroupBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchL = new System.Windows.Forms.Label();
            this.aShowpwCB = new System.Windows.Forms.CheckBox();
            this.aAccountsLV = new System.Windows.Forms.ListView();
            this.siteCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nicknameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountsCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPassTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openSiteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addAccountTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuS = new System.Windows.Forms.MenuStrip();
            this.accountsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountsFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAccountFIleTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAccountFileAsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.accountscmsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.supportTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdatesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.informationSS = new System.Windows.Forms.StatusStrip();
            this.infoTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.loginGB = new System.Windows.Forms.GroupBox();
            this.lexitB = new System.Windows.Forms.Button();
            this.lcontinueB = new System.Windows.Forms.Button();
            this.lpassTB = new System.Windows.Forms.TextBox();
            this.linfoL = new System.Windows.Forms.Label();
            this.accountsFileSFD = new System.Windows.Forms.SaveFileDialog();
            this.accountsFileOFD = new System.Windows.Forms.OpenFileDialog();
            this.accountsGB.SuspendLayout();
            this.accountsCMS.SuspendLayout();
            this.menuS.SuspendLayout();
            this.informationSS.SuspendLayout();
            this.loginGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountsGB
            // 
            this.accountsGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountsGB.Controls.Add(this.searchTB);
            this.accountsGB.Controls.Add(this.searchL);
            this.accountsGB.Controls.Add(this.aShowpwCB);
            this.accountsGB.Controls.Add(this.aAccountsLV);
            this.accountsGB.Location = new System.Drawing.Point(12, 27);
            this.accountsGB.Name = "accountsGB";
            this.accountsGB.Size = new System.Drawing.Size(290, 53);
            this.accountsGB.TabIndex = 2;
            this.accountsGB.TabStop = false;
            this.accountsGB.Text = "Mis cuentas";
            this.accountsGB.Visible = false;
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTB.Location = new System.Drawing.Point(62, 31);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(136, 20);
            this.searchTB.TabIndex = 0;
            this.searchTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchTBMouseClick);
            this.searchTB.TextChanged += new System.EventHandler(this.SearchTBTextChanged);
            // 
            // searchL
            // 
            this.searchL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchL.Location = new System.Drawing.Point(7, 34);
            this.searchL.Name = "searchL";
            this.searchL.Size = new System.Drawing.Size(49, 14);
            this.searchL.TabIndex = 1;
            this.searchL.Text = "Buscar:";
            // 
            // aShowpwCB
            // 
            this.aShowpwCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aShowpwCB.AutoSize = true;
            this.aShowpwCB.Location = new System.Drawing.Point(167, 31);
            this.aShowpwCB.Name = "aShowpwCB";
            this.aShowpwCB.Size = new System.Drawing.Size(117, 17);
            this.aShowpwCB.TabIndex = 2;
            this.aShowpwCB.Text = "Mostrar contraseña";
            this.aShowpwCB.UseVisualStyleBackColor = true;
            this.aShowpwCB.CheckedChanged += new System.EventHandler(this.aShowpwCB_CheckedChanged);
            // 
            // aAccountsLV
            // 
            this.aAccountsLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aAccountsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.siteCH,
            this.emailCH,
            this.nicknameCH,
            this.passwordCH});
            this.aAccountsLV.ContextMenuStrip = this.accountsCMS;
            this.aAccountsLV.FullRowSelect = true;
            this.aAccountsLV.Location = new System.Drawing.Point(6, 22);
            this.aAccountsLV.Name = "aAccountsLV";
            this.aAccountsLV.Size = new System.Drawing.Size(278, 3);
            this.aAccountsLV.TabIndex = 3;
            this.aAccountsLV.UseCompatibleStateImageBehavior = false;
            this.aAccountsLV.View = System.Windows.Forms.View.Details;
            this.aAccountsLV.DoubleClick += new System.EventHandler(this.aAccountsLV_DoubleClick);
            this.aAccountsLV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aAccountsLV_KeyDown);
            // 
            // siteCH
            // 
            this.siteCH.Text = "Sitio/aplicación";
            this.siteCH.Width = 108;
            // 
            // emailCH
            // 
            this.emailCH.Text = "Correo electrónico";
            this.emailCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailCH.Width = 128;
            // 
            // nicknameCH
            // 
            this.nicknameCH.Text = "Usuario";
            this.nicknameCH.Width = 74;
            // 
            // passwordCH
            // 
            this.passwordCH.Text = "Contraseña";
            this.passwordCH.Width = 123;
            // 
            // accountsCMS
            // 
            this.accountsCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPassTSMI,
            this.openSiteTSMI,
            this.toolStripSeparator1,
            this.addAccountTSMI,
            this.editAccountTSMI,
            this.removeAccountTSMI});
            this.accountsCMS.Name = "accountsCMS";
            this.accountsCMS.Size = new System.Drawing.Size(171, 120);
            this.accountsCMS.Opening += new System.ComponentModel.CancelEventHandler(this.accountsCMS_Opening);
            // 
            // copyPassTSMI
            // 
            this.copyPassTSMI.Name = "copyPassTSMI";
            this.copyPassTSMI.Size = new System.Drawing.Size(170, 22);
            this.copyPassTSMI.Text = "Copiar contraseña";
            this.copyPassTSMI.Click += new System.EventHandler(this.copyPassTSMI_Click);
            // 
            // openSiteTSMI
            // 
            this.openSiteTSMI.Name = "openSiteTSMI";
            this.openSiteTSMI.Size = new System.Drawing.Size(170, 22);
            this.openSiteTSMI.Text = "Abrir sitio(s)";
            this.openSiteTSMI.Click += new System.EventHandler(this.openSiteTSMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // addAccountTSMI
            // 
            this.addAccountTSMI.Name = "addAccountTSMI";
            this.addAccountTSMI.Size = new System.Drawing.Size(170, 22);
            this.addAccountTSMI.Text = "Añadir cuenta";
            this.addAccountTSMI.Click += new System.EventHandler(this.addAccountTSMI_Click);
            // 
            // editAccountTSMI
            // 
            this.editAccountTSMI.Name = "editAccountTSMI";
            this.editAccountTSMI.Size = new System.Drawing.Size(170, 22);
            this.editAccountTSMI.Text = "Editar cuenta(s)";
            this.editAccountTSMI.Click += new System.EventHandler(this.editAccountTSMI_Click);
            // 
            // removeAccountTSMI
            // 
            this.removeAccountTSMI.Name = "removeAccountTSMI";
            this.removeAccountTSMI.Size = new System.Drawing.Size(170, 22);
            this.removeAccountTSMI.Text = "Eliminar cuenta(s)";
            this.removeAccountTSMI.Click += new System.EventHandler(this.removeAccountTSMI_Click);
            // 
            // menuS
            // 
            this.menuS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsTSMI,
            this.optionsTSMI,
            this.helpTSMI,
            this.exit});
            this.menuS.Location = new System.Drawing.Point(0, 0);
            this.menuS.Name = "menuS";
            this.menuS.Size = new System.Drawing.Size(314, 24);
            this.menuS.TabIndex = 4;
            this.menuS.Visible = false;
            // 
            // accountsTSMI
            // 
            this.accountsTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountsFileTSMI,
            this.loadAccountFIleTSMI,
            this.saveAccountFileAsTSMI,
            this.toolStripSeparator2,
            this.accountscmsTSMI});
            this.accountsTSMI.Name = "accountsTSMI";
            this.accountsTSMI.Size = new System.Drawing.Size(62, 20);
            this.accountsTSMI.Text = "Cuentas";
            // 
            // newAccountsFileTSMI
            // 
            this.newAccountsFileTSMI.Name = "newAccountsFileTSMI";
            this.newAccountsFileTSMI.Size = new System.Drawing.Size(261, 22);
            this.newAccountsFileTSMI.Text = "Nuevo archivo de cuentas";
            this.newAccountsFileTSMI.Click += new System.EventHandler(this.newAccountsFileTSMI_Click);
            // 
            // loadAccountFIleTSMI
            // 
            this.loadAccountFIleTSMI.Name = "loadAccountFIleTSMI";
            this.loadAccountFIleTSMI.Size = new System.Drawing.Size(261, 22);
            this.loadAccountFIleTSMI.Text = "Cargar archivo de cuentas";
            this.loadAccountFIleTSMI.Click += new System.EventHandler(this.loadAccountFIleTSMI_Click);
            // 
            // saveAccountFileAsTSMI
            // 
            this.saveAccountFileAsTSMI.Name = "saveAccountFileAsTSMI";
            this.saveAccountFileAsTSMI.Size = new System.Drawing.Size(261, 22);
            this.saveAccountFileAsTSMI.Text = "Guardar archivo de cuentas como...";
            this.saveAccountFileAsTSMI.Click += new System.EventHandler(this.saveAccountFileAsTSMI_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // accountscmsTSMI
            // 
            this.accountscmsTSMI.Name = "accountscmsTSMI";
            this.accountscmsTSMI.Size = new System.Drawing.Size(261, 22);
            this.accountscmsTSMI.Text = "Cuentas";
            this.accountscmsTSMI.Click += new System.EventHandler(this.accountscmsTSMI_Click);
            // 
            // optionsTSMI
            // 
            this.optionsTSMI.Name = "optionsTSMI";
            this.optionsTSMI.Size = new System.Drawing.Size(69, 20);
            this.optionsTSMI.Text = "Opciones";
            this.optionsTSMI.Click += new System.EventHandler(this.optionsTSMI_Click);
            // 
            // helpTSMI
            // 
            this.helpTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialTSMI,
            this.supportTSMI,
            this.checkUpdatesTSMI});
            this.helpTSMI.Name = "helpTSMI";
            this.helpTSMI.Size = new System.Drawing.Size(53, 20);
            this.helpTSMI.Text = "Ayuda";
            // 
            // tutorialTSMI
            // 
            this.tutorialTSMI.Name = "tutorialTSMI";
            this.tutorialTSMI.Size = new System.Drawing.Size(218, 22);
            this.tutorialTSMI.Text = "Tutorial";
            this.tutorialTSMI.Click += new System.EventHandler(this.tutorialTSMI_Click);
            // 
            // supportTSMI
            // 
            this.supportTSMI.Name = "supportTSMI";
            this.supportTSMI.Size = new System.Drawing.Size(218, 22);
            this.supportTSMI.Text = "Soporte";
            this.supportTSMI.Click += new System.EventHandler(this.supportTSMI_Click);
            // 
            // checkUpdatesTSMI
            // 
            this.checkUpdatesTSMI.Name = "checkUpdatesTSMI";
            this.checkUpdatesTSMI.Size = new System.Drawing.Size(218, 22);
            this.checkUpdatesTSMI.Text = "Comprobar actualizaciones";
            this.checkUpdatesTSMI.Click += new System.EventHandler(this.checkUpdatesTSMI_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(41, 20);
            this.exit.Text = "Salir";
            this.exit.Click += new System.EventHandler(this.exitTSMI_Click);
            // 
            // informationSS
            // 
            this.informationSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoTSSL});
            this.informationSS.Location = new System.Drawing.Point(0, 235);
            this.informationSS.Name = "informationSS";
            this.informationSS.Size = new System.Drawing.Size(556, 22);
            this.informationSS.TabIndex = 3;
            this.informationSS.Text = "Información";
            this.informationSS.Visible = false;
            // 
            // infoTSSL
            // 
            this.infoTSSL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoTSSL.Name = "infoTSSL";
            this.infoTSSL.Size = new System.Drawing.Size(309, 17);
            this.infoTSSL.Text = "Aplicación diseñada por Lonami - http://lonamiwebs.github.io";
            // 
            // loginGB
            // 
            this.loginGB.Controls.Add(this.lexitB);
            this.loginGB.Controls.Add(this.lcontinueB);
            this.loginGB.Controls.Add(this.lpassTB);
            this.loginGB.Controls.Add(this.linfoL);
            this.loginGB.Location = new System.Drawing.Point(12, 12);
            this.loginGB.Name = "loginGB";
            this.loginGB.Size = new System.Drawing.Size(291, 90);
            this.loginGB.TabIndex = 1;
            this.loginGB.TabStop = false;
            this.loginGB.Text = "Iniciar sesión";
            // 
            // lexitB
            // 
            this.lexitB.Location = new System.Drawing.Point(6, 60);
            this.lexitB.Name = "lexitB";
            this.lexitB.Size = new System.Drawing.Size(75, 23);
            this.lexitB.TabIndex = 0;
            this.lexitB.Text = "Salir";
            this.lexitB.UseVisualStyleBackColor = true;
            this.lexitB.Click += new System.EventHandler(this.lexitB_Click);
            // 
            // lcontinueB
            // 
            this.lcontinueB.Location = new System.Drawing.Point(209, 60);
            this.lcontinueB.Name = "lcontinueB";
            this.lcontinueB.Size = new System.Drawing.Size(75, 23);
            this.lcontinueB.TabIndex = 1;
            this.lcontinueB.Text = "Continuar";
            this.lcontinueB.UseVisualStyleBackColor = true;
            this.lcontinueB.Click += new System.EventHandler(this.lcontinueB_Click);
            // 
            // lpassTB
            // 
            this.lpassTB.Location = new System.Drawing.Point(6, 34);
            this.lpassTB.Name = "lpassTB";
            this.lpassTB.PasswordChar = '●';
            this.lpassTB.Size = new System.Drawing.Size(278, 20);
            this.lpassTB.TabIndex = 0;
            this.lpassTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lpassTB_KeyDown);
            // 
            // linfoL
            // 
            this.linfoL.AutoSize = true;
            this.linfoL.Location = new System.Drawing.Point(7, 18);
            this.linfoL.Name = "linfoL";
            this.linfoL.Size = new System.Drawing.Size(238, 13);
            this.linfoL.TabIndex = 2;
            this.linfoL.Text = "Introduzca la contraseña maestra para continuar:";
            // 
            // accountsFileSFD
            // 
            this.accountsFileSFD.FileName = "accounts";
            this.accountsFileSFD.Filter = "Archivo de cuentas Account Manager|*.acf";
            this.accountsFileSFD.Title = "Elija donde guardar el archivo de cuentas";
            // 
            // accountsFileOFD
            // 
            this.accountsFileOFD.Filter = "Archivo de cuentas Account Manager|*.acf";
            this.accountsFileOFD.Title = "Elija un archivo de cuentas válido";
            // 
            // MainWindowF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 111);
            this.Controls.Add(this.loginGB);
            this.Controls.Add(this.accountsGB);
            this.Controls.Add(this.informationSS);
            this.Controls.Add(this.menuS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuS;
            this.MinimumSize = new System.Drawing.Size(330, 150);
            this.Name = "MainWindowF";
            this.Text = "Administrador de cuentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindowF_FormClosing);
            this.accountsGB.ResumeLayout(false);
            this.accountsGB.PerformLayout();
            this.accountsCMS.ResumeLayout(false);
            this.menuS.ResumeLayout(false);
            this.menuS.PerformLayout();
            this.informationSS.ResumeLayout(false);
            this.informationSS.PerformLayout();
            this.loginGB.ResumeLayout(false);
            this.loginGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.GroupBox accountsGB;
        System.Windows.Forms.CheckBox aShowpwCB;
        System.Windows.Forms.ListView aAccountsLV;
        System.Windows.Forms.ContextMenuStrip accountsCMS;
        System.Windows.Forms.ColumnHeader siteCH;
        System.Windows.Forms.ColumnHeader emailCH;
        System.Windows.Forms.ColumnHeader nicknameCH;
        System.Windows.Forms.ColumnHeader passwordCH;
        System.Windows.Forms.ToolStripMenuItem copyPassTSMI;
        System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        System.Windows.Forms.ToolStripMenuItem addAccountTSMI;
        System.Windows.Forms.ToolStripMenuItem editAccountTSMI;
        System.Windows.Forms.ToolStripMenuItem removeAccountTSMI;
        System.Windows.Forms.MenuStrip menuS;
        System.Windows.Forms.ToolStripMenuItem accountsTSMI;
        System.Windows.Forms.ToolStripMenuItem optionsTSMI;
        System.Windows.Forms.ToolStripMenuItem helpTSMI;
        System.Windows.Forms.ToolStripMenuItem tutorialTSMI;
        System.Windows.Forms.ToolStripMenuItem supportTSMI;
        System.Windows.Forms.ToolStripMenuItem exit;
        System.Windows.Forms.ToolStripMenuItem openSiteTSMI;
        System.Windows.Forms.ToolStripMenuItem loadAccountFIleTSMI;
        System.Windows.Forms.ToolStripMenuItem saveAccountFileAsTSMI;
        System.Windows.Forms.StatusStrip informationSS;
        System.Windows.Forms.ToolStripStatusLabel infoTSSL;
        System.Windows.Forms.ToolStripMenuItem newAccountsFileTSMI;
        System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        System.Windows.Forms.ToolStripMenuItem accountscmsTSMI;
        System.Windows.Forms.GroupBox loginGB;
        System.Windows.Forms.Button lexitB;
        System.Windows.Forms.Button lcontinueB;
        System.Windows.Forms.TextBox lpassTB;
        System.Windows.Forms.Label linfoL;
        System.Windows.Forms.ToolStripMenuItem checkUpdatesTSMI;
        System.Windows.Forms.SaveFileDialog accountsFileSFD;
        System.Windows.Forms.OpenFileDialog accountsFileOFD;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label searchL;
    }
}

