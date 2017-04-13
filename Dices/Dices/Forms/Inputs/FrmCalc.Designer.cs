namespace Dices.Forms.Inputs
{
    partial class frmCalc
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
            this.ucCalcKeyboard1 = new Dices.Forms.Inputs.ucCalcKeyboard();
            this.SuspendLayout();
            // 
            // ucCalcKeyboard1
            // 
            this.ucCalcKeyboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCalcKeyboard1.Location = new System.Drawing.Point(0, 0);
            this.ucCalcKeyboard1.MinimumSize = new System.Drawing.Size(420, 550);
            this.ucCalcKeyboard1.Name = "ucCalcKeyboard1";
            this.ucCalcKeyboard1.Size = new System.Drawing.Size(421, 554);
            this.ucCalcKeyboard1.TabIndex = 0;
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 554);
            this.Controls.Add(this.ucCalcKeyboard1);
            this.MinimumSize = new System.Drawing.Size(437, 592);
            this.Name = "frmCalc";
            this.Text = "frmCalc";
            this.ResumeLayout(false);

        }

        #endregion

        private ucCalcKeyboard ucCalcKeyboard1;
    }
}