namespace Dices.Forms
{
    partial class Teste
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
            this.htmlEditor1 = new DicesCustomControls.Componentes.HtmlEditor();
            this.SuspendLayout();
            // 
            // htmlEditor1
            // 
            this.htmlEditor1.Location = new System.Drawing.Point(50, 26);
            this.htmlEditor1.Name = "htmlEditor1";
            this.htmlEditor1.Size = new System.Drawing.Size(698, 413);
            this.htmlEditor1.TabIndex = 0;
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 451);
            this.Controls.Add(this.htmlEditor1);
            this.Name = "Teste";
            this.Text = "Teste";
            this.ResumeLayout(false);

        }

        #endregion

        private DicesCustomControls.Componentes.HtmlEditor htmlEditor1;
    }
}