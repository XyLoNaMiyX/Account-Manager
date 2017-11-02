namespace Account_Manager
{
    partial class HelpF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpF));
            helpRTB = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // helpRTB
            // 
            helpRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            helpRTB.Location = new System.Drawing.Point(0, 0);
            helpRTB.Name = "helpRTB";
            helpRTB.ReadOnly = true;
            helpRTB.Size = new System.Drawing.Size(534, 321);
            helpRTB.TabIndex = 0;
            // 
            // HelpF
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(534, 321);
            Controls.Add(helpRTB);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "HelpF";
            Text = "Tutorial";
            Load += new System.EventHandler(HelpF_Load);
            ResumeLayout(false);

        }

        #endregion

        System.Windows.Forms.RichTextBox helpRTB;
    }
}
