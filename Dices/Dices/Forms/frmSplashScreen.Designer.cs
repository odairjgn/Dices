namespace Dices.Forms
{
    partial class frmSplashScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbIco = new System.Windows.Forms.PictureBox();
            this.lbVersao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTask = new System.Windows.Forms.Label();
            this.segundoplano = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbIco);
            this.panel1.Controls.Add(this.lbVersao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(284, 115);
            this.panel1.TabIndex = 0;
            // 
            // pbIco
            // 
            this.pbIco.Location = new System.Drawing.Point(203, 12);
            this.pbIco.Name = "pbIco";
            this.pbIco.Size = new System.Drawing.Size(67, 63);
            this.pbIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIco.TabIndex = 3;
            this.pbIco.TabStop = false;
            // 
            // lbVersao
            // 
            this.lbVersao.AutoSize = true;
            this.lbVersao.ForeColor = System.Drawing.Color.Gray;
            this.lbVersao.Location = new System.Drawing.Point(12, 32);
            this.lbVersao.Name = "lbVersao";
            this.lbVersao.Size = new System.Drawing.Size(79, 13);
            this.lbVersao.TabIndex = 2;
            this.lbVersao.Text = "Versão: 0.0.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dices";
            // 
            // lbTask
            // 
            this.lbTask.Location = new System.Drawing.Point(15, 78);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(256, 30);
            this.lbTask.TabIndex = 0;
            this.lbTask.Text = "Carregando...";
            this.lbTask.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // segundoplano
            // 
            this.segundoplano.DoWork += new System.ComponentModel.DoWorkEventHandler(this.segundoplano_DoWork);
            this.segundoplano.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.segundoplano_RunWorkerCompleted);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 115);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dices";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVersao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.PictureBox pbIco;
        private System.ComponentModel.BackgroundWorker segundoplano;
    }
}