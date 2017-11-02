namespace Account_Manager
{
    partial class AddAccountF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name=Strings.str0>true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountF));
        	this.siteL = new System.Windows.Forms.Label();
        	this.emailL = new System.Windows.Forms.Label();
        	this.userL = new System.Windows.Forms.Label();
        	this.passL = new System.Windows.Forms.Label();
        	this.siteTB = new System.Windows.Forms.TextBox();
        	this.emailTB = new System.Windows.Forms.TextBox();
        	this.userTB = new System.Windows.Forms.TextBox();
        	this.passTB = new System.Windows.Forms.TextBox();
        	this.acceptB = new System.Windows.Forms.Button();
        	this.cancelB = new System.Windows.Forms.Button();
        	this.showPassCB = new System.Windows.Forms.CheckBox();
        	this.SuspendLayout();
        	// 
        	// siteL
        	// 
        	this.siteL.AutoSize = true;
        	this.siteL.Location = new System.Drawing.Point(12, 13);
        	this.siteL.Name = "siteL";
        	this.siteL.Size = new System.Drawing.Size(0, 13);
        	this.siteL.TabIndex = 0;

            Text = "Añadir cuenta";
            showPassCB.Text = "Mostrar contraseña";
            cancelB.Text = "Cancelar";
            acceptB.Text = "Aceptar";
            passL.Text = "Contraseña:";
            userL.Text = "Usuario:";
            emailL.Text = "Correo electrónico:";
            siteL.Text = "Sitio/aplicación:";
        	// 
        	// emailL
        	// 
        	this.emailL.AutoSize = true;
        	this.emailL.Location = new System.Drawing.Point(12, 39);
        	this.emailL.Name = "emailL";
        	this.emailL.Size = new System.Drawing.Size(0, 13);
        	this.emailL.TabIndex = 1;
        	// 
        	// userL
        	// 
        	this.userL.AutoSize = true;
        	this.userL.Location = new System.Drawing.Point(12, 65);
        	this.userL.Name = "userL";
        	this.userL.Size = new System.Drawing.Size(0, 13);
        	this.userL.TabIndex = 2;
        	// 
        	// passL
        	// 
        	this.passL.AutoSize = true;
        	this.passL.Location = new System.Drawing.Point(12, 91);
        	this.passL.Name = "passL";
        	this.passL.Size = new System.Drawing.Size(0, 13);
        	this.passL.TabIndex = 3;
        	// 
        	// siteTB
        	// 
        	this.siteTB.Location = new System.Drawing.Point(115, 10);
        	this.siteTB.Name = "siteTB";
        	this.siteTB.Size = new System.Drawing.Size(292, 20);
        	this.siteTB.TabIndex = 4;
        	this.siteTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.siteTB_KeyDown);
        	// 
        	// emailTB
        	// 
        	this.emailTB.Location = new System.Drawing.Point(115, 36);
        	this.emailTB.Name = "emailTB";
        	this.emailTB.Size = new System.Drawing.Size(292, 20);
        	this.emailTB.TabIndex = 5;
        	this.emailTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTB_KeyDown);
        	// 
        	// userTB
        	// 
        	this.userTB.Location = new System.Drawing.Point(115, 62);
        	this.userTB.Name = "userTB";
        	this.userTB.Size = new System.Drawing.Size(292, 20);
        	this.userTB.TabIndex = 6;
        	this.userTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTB_KeyDown);
        	// 
        	// passTB
        	// 
        	this.passTB.Location = new System.Drawing.Point(115, 88);
        	this.passTB.Name = "passTB";
        	this.passTB.PasswordChar = '●';
        	this.passTB.Size = new System.Drawing.Size(292, 20);
        	this.passTB.TabIndex = 7;
        	this.passTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTB_KeyDown);
        	// 
        	// acceptB
        	// 
        	this.acceptB.Location = new System.Drawing.Point(332, 114);
        	this.acceptB.Name = "acceptB";
        	this.acceptB.Size = new System.Drawing.Size(75, 23);
        	this.acceptB.TabIndex = 8;
        	this.acceptB.UseVisualStyleBackColor = true;
        	this.acceptB.Click += new System.EventHandler(this.acceptB_Click);
        	// 
        	// cancelB
        	// 
        	this.cancelB.Location = new System.Drawing.Point(251, 114);
        	this.cancelB.Name = "cancelB";
        	this.cancelB.Size = new System.Drawing.Size(75, 23);
        	this.cancelB.TabIndex = 9;
        	this.cancelB.UseVisualStyleBackColor = true;
        	this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
        	// 
        	// showPassCB
        	// 
        	this.showPassCB.AutoSize = true;
        	this.showPassCB.Location = new System.Drawing.Point(12, 115);
        	this.showPassCB.Name = "showPassCB";
        	this.showPassCB.Size = new System.Drawing.Size(15, 14);
        	this.showPassCB.TabIndex = 10;
        	this.showPassCB.UseVisualStyleBackColor = true;
        	this.showPassCB.CheckedChanged += new System.EventHandler(this.showPassCB_CheckedChanged);
        	// 
        	// AddAccountF
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(419, 144);
        	this.Controls.Add(this.showPassCB);
        	this.Controls.Add(this.cancelB);
        	this.Controls.Add(this.acceptB);
        	this.Controls.Add(this.passTB);
        	this.Controls.Add(this.userTB);
        	this.Controls.Add(this.emailTB);
        	this.Controls.Add(this.siteTB);
        	this.Controls.Add(this.passL);
        	this.Controls.Add(this.userL);
        	this.Controls.Add(this.emailL);
        	this.Controls.Add(this.siteL);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "AddAccountF";
        	this.Load += new System.EventHandler(this.AddAccountF_Load);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.Label siteL;
        System.Windows.Forms.Label emailL;
        System.Windows.Forms.Label userL;
        System.Windows.Forms.Label passL;
        System.Windows.Forms.TextBox siteTB;
        System.Windows.Forms.TextBox emailTB;
        System.Windows.Forms.TextBox userTB;
        System.Windows.Forms.TextBox passTB;
        System.Windows.Forms.Button acceptB;
        System.Windows.Forms.Button cancelB;
        System.Windows.Forms.CheckBox showPassCB;
    }
}
