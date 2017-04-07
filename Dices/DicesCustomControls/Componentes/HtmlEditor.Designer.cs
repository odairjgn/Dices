namespace DicesCustomControls.Componentes
{
    partial class HtmlEditor
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
            this.pnBase = new System.Windows.Forms.TableLayoutPanel();
            this.HTML_Editor = new GvS.Controls.HtmlTextbox();
            this.pnBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBase
            // 
            this.pnBase.ColumnCount = 1;
            this.pnBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnBase.Controls.Add(this.HTML_Editor, 0, 0);
            this.pnBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBase.Location = new System.Drawing.Point(0, 0);
            this.pnBase.Name = "pnBase";
            this.pnBase.RowCount = 1;
            this.pnBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnBase.Size = new System.Drawing.Size(567, 327);
            this.pnBase.TabIndex = 0;
            // 
            // HTML_Editor
            // 
            this.HTML_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTML_Editor.Fonts = new string[] {
        "Corbel",
        "Corbel, Verdana, Arial, Helvetica, sans-serif",
        "Georgia, Times New Roman, Times, serif",
        "Consolas, Courier New, Courier, monospace"};
            this.HTML_Editor.IllegalPatterns = new string[] {
        "<script.*?>",
        "<\\w+\\s+.*?(j|java|vb|ecma)script:.*?>",
        "<\\w+(\\s+|\\s+.*?\\s+)on\\w+\\s*=.+?>",
        "</?input.*?>"};
            this.HTML_Editor.Location = new System.Drawing.Point(1, 1);
            this.HTML_Editor.Margin = new System.Windows.Forms.Padding(1);
            this.HTML_Editor.Name = "HTML_Editor";
            this.HTML_Editor.ShowHtmlSource = false;
            this.HTML_Editor.Size = new System.Drawing.Size(565, 325);
            this.HTML_Editor.TabIndex = 0;
            this.HTML_Editor.ToolbarStyle = GvS.Controls.ToolbarStyles.AlwaysInternal;
            // 
            // HtmlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBase);
            this.Name = "HtmlEditor";
            this.Size = new System.Drawing.Size(567, 327);
            this.pnBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnBase;
        private GvS.Controls.HtmlTextbox HTML_Editor;
    }
}
