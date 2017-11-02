namespace Account_Manager
{
    partial class FirstTimeF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTimeF));
            this.label1 = new System.Windows.Forms.Label();
            this.firstPassTB = new System.Windows.Forms.TextBox();
            this.info2L = new System.Windows.Forms.Label();
            this.secondPassTB = new System.Windows.Forms.TextBox();
            this.showPassCB = new System.Windows.Forms.CheckBox();
            this.acceptB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // firstPassTB
            // 
            this.firstPassTB.Location = new System.Drawing.Point(12, 77);
            this.firstPassTB.Name = "firstPassTB";
            this.firstPassTB.PasswordChar = '●';
            this.firstPassTB.Size = new System.Drawing.Size(392, 20);
            this.firstPassTB.TabIndex = 1;
            this.firstPassTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstPassTB_KeyDown);
            // 
            // info2L
            // 
            this.info2L.AutoSize = true;
            this.info2L.Location = new System.Drawing.Point(12, 100);
            this.info2L.Name = "info2L";
            this.info2L.Size = new System.Drawing.Size(108, 13);
            this.info2L.TabIndex = 2;
            this.info2L.Text = "Repita la contraseña:";
            // 
            // secondPassTB
            // 
            this.secondPassTB.Location = new System.Drawing.Point(12, 117);
            this.secondPassTB.Name = "secondPassTB";
            this.secondPassTB.PasswordChar = '●';
            this.secondPassTB.Size = new System.Drawing.Size(392, 20);
            this.secondPassTB.TabIndex = 3;
            this.secondPassTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.secondPassTB_KeyDown);
            // 
            // showPassCB
            // 
            this.showPassCB.AutoSize = true;
            this.showPassCB.Location = new System.Drawing.Point(12, 148);
            this.showPassCB.Name = "showPassCB";
            this.showPassCB.Size = new System.Drawing.Size(117, 17);
            this.showPassCB.TabIndex = 4;
            this.showPassCB.Text = "Mostrar contraseña";
            this.showPassCB.UseVisualStyleBackColor = true;
            this.showPassCB.CheckedChanged += new System.EventHandler(this.showPassCB_CheckedChanged);
            // 
            // acceptB
            // 
            this.acceptB.Location = new System.Drawing.Point(329, 144);
            this.acceptB.Name = "acceptB";
            this.acceptB.Size = new System.Drawing.Size(75, 23);
            this.acceptB.TabIndex = 5;
            this.acceptB.Text = "Aceptar";
            this.acceptB.UseVisualStyleBackColor = true;
            this.acceptB.Click += new System.EventHandler(this.acceptB_Click);
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(248, 144);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(75, 23);
            this.exitB.TabIndex = 6;
            this.exitB.Text = "Salir";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // FirstTimeF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 176);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.acceptB);
            this.Controls.Add(this.showPassCB);
            this.Controls.Add(this.secondPassTB);
            this.Controls.Add(this.info2L);
            this.Controls.Add(this.firstPassTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstTimeF";
            this.Text = "Bienvenido al Administrador de Cuentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.Label label1;
        System.Windows.Forms.TextBox firstPassTB;
        System.Windows.Forms.Label info2L;
        System.Windows.Forms.TextBox secondPassTB;
        System.Windows.Forms.CheckBox showPassCB;
        System.Windows.Forms.Button acceptB;
        System.Windows.Forms.Button exitB;
    }
}
