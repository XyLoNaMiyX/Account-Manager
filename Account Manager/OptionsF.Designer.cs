namespace Account_Manager
{
    partial class OptionsF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsF));
            this.doubleClickL = new System.Windows.Forms.Label();
            this.doubleClickCB = new System.Windows.Forms.ComboBox();
            this.behaviourGB = new System.Windows.Forms.GroupBox();
            this.acceptB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.behaviourGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // doubleClickL
            // 
            this.doubleClickL.AutoSize = true;
            this.doubleClickL.Location = new System.Drawing.Point(6, 16);
            this.doubleClickL.Name = "doubleClickL";
            this.doubleClickL.Size = new System.Drawing.Size(57, 13);
            this.doubleClickL.TabIndex = 0;
            this.doubleClickL.Text = "Doble clic:";
            // 
            // doubleClickCB
            // 
            this.doubleClickCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doubleClickCB.FormattingEnabled = true;
            this.doubleClickCB.Items.AddRange(new object[] {
            "Copiar contraseña",
            "Abrir sitio"});
            this.doubleClickCB.Location = new System.Drawing.Point(76, 13);
            this.doubleClickCB.Name = "doubleClickCB";
            this.doubleClickCB.Size = new System.Drawing.Size(121, 21);
            this.doubleClickCB.TabIndex = 1;
            // 
            // behaviourGB
            // 
            this.behaviourGB.Controls.Add(this.doubleClickL);
            this.behaviourGB.Controls.Add(this.doubleClickCB);
            this.behaviourGB.Location = new System.Drawing.Point(12, 12);
            this.behaviourGB.Name = "behaviourGB";
            this.behaviourGB.Size = new System.Drawing.Size(202, 41);
            this.behaviourGB.TabIndex = 2;
            this.behaviourGB.TabStop = false;
            this.behaviourGB.Text = "Comportamiento";
            // 
            // acceptB
            // 
            this.acceptB.Location = new System.Drawing.Point(134, 59);
            this.acceptB.Name = "acceptB";
            this.acceptB.Size = new System.Drawing.Size(75, 23);
            this.acceptB.TabIndex = 3;
            this.acceptB.Text = "Aceptar";
            this.acceptB.UseVisualStyleBackColor = true;
            this.acceptB.Click += new System.EventHandler(this.acceptB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(12, 59);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 4;
            this.cancelB.Text = "Cancelar";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // OptionsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 93);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.acceptB);
            this.Controls.Add(this.behaviourGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsF";
            this.Text = "Opciones";
            this.behaviourGB.ResumeLayout(false);
            this.behaviourGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        System.Windows.Forms.Label doubleClickL;
        System.Windows.Forms.ComboBox doubleClickCB;
        System.Windows.Forms.GroupBox behaviourGB;
        System.Windows.Forms.Button acceptB;
        System.Windows.Forms.Button cancelB;
    }
}
