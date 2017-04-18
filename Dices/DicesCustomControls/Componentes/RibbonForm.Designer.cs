namespace DicesCustomControls.Componentes
{
    partial class RibbonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.Ribbon();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Minimized = false;
            this.mainMenu.Name = "mainMenu";
            // 
            // 
            // 
            this.mainMenu.OrbDropDown.BorderRoundness = 8;
            this.mainMenu.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.OrbDropDown.Name = "";
            this.mainMenu.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.mainMenu.OrbDropDown.TabIndex = 0;
            this.mainMenu.OrbImage = null;
            this.mainMenu.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.mainMenu.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.mainMenu.Size = new System.Drawing.Size(375, 157);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.mainMenu.Text = "ribbon1";
            this.mainMenu.ThemeColor = System.Windows.Forms.RibbonTheme.Halloween;
            // 
            // RibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 346);
            this.Controls.Add(this.mainMenu);
            this.Name = "RibbonForm";
            this.Text = "RibbonForm";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Ribbon mainMenu;
    }
}