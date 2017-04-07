using System.Windows.Forms;
using DicesCustomControls.Componentes.Internos;
using LiveSwitch.TextControl;

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
            this.dropDownControl1 = new Editor();
            this.pnBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBase
            // 
            this.pnBase.ColumnCount = 1;
            this.pnBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnBase.Controls.Add(this.dropDownControl1, 0, 0);
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
            // dropDownControl1
            // 
            this.dropDownControl1.BackColor = System.Drawing.Color.White;
            this.dropDownControl1.Location = new System.Drawing.Point(3, 3);
            this.dropDownControl1.Name = "dropDownControl1";
            this.dropDownControl1.Size = new System.Drawing.Size(150, 150);
            this.dropDownControl1.TabIndex = 0;
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
        private Editor dropDownControl1;
    }
}
