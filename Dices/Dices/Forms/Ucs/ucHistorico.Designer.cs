namespace Dices.Forms.Ucs
{
    partial class ucHistorico
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
            this.gridDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDados
            // 
            this.gridDados.AllowUserToAddRows = false;
            this.gridDados.AllowUserToDeleteRows = false;
            this.gridDados.AllowUserToOrderColumns = true;
            this.gridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDados.Location = new System.Drawing.Point(0, 0);
            this.gridDados.Name = "gridDados";
            this.gridDados.ReadOnly = true;
            this.gridDados.RowHeadersVisible = false;
            this.gridDados.Size = new System.Drawing.Size(513, 353);
            this.gridDados.TabIndex = 0;
            // 
            // ucHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridDados);
            this.Name = "ucHistorico";
            this.Size = new System.Drawing.Size(513, 353);
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDados;
    }
}
