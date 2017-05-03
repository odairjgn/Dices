namespace Dices.Forms.Ucs
{
    partial class frDCustom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudFaces = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaces)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFaces
            // 
            this.nudFaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFaces.Location = new System.Drawing.Point(8, 25);
            this.nudFaces.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFaces.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFaces.Name = "nudFaces";
            this.nudFaces.Size = new System.Drawing.Size(120, 29);
            this.nudFaces.TabIndex = 2;
            this.nudFaces.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Faces";
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(8, 60);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(120, 30);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // frDCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(135, 104);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudFaces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frDCustom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dx Customizado";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frDCustom_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudFaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOk;
    }
}
