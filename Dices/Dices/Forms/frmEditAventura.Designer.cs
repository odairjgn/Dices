namespace Dices.Forms
{
    partial class frmEditAventura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBuscaImg = new System.Windows.Forms.Button();
            this.ofdImg = new System.Windows.Forms.OpenFileDialog();
            this.btnRemoveImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(16, 30);
            this.txtTitulo.MaxLength = 200;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(380, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(16, 73);
            this.txtDesc.MaxLength = 200;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(380, 70);
            this.txtDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(16, 176);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(100, 91);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 4;
            this.pbImg.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ícone";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(321, 244);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnBuscaImg
            // 
            this.btnBuscaImg.Location = new System.Drawing.Point(122, 244);
            this.btnBuscaImg.Name = "btnBuscaImg";
            this.btnBuscaImg.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaImg.TabIndex = 7;
            this.btnBuscaImg.Text = "...";
            this.btnBuscaImg.UseVisualStyleBackColor = true;
            this.btnBuscaImg.Click += new System.EventHandler(this.btnBuscaImg_Click);
            // 
            // ofdImg
            // 
            this.ofdImg.FileName = "openFileDialog1";
            this.ofdImg.Filter = "Imagens|*.jpg;*.png;*.bmp;*.gif";
            // 
            // btnRemoveImg
            // 
            this.btnRemoveImg.Location = new System.Drawing.Point(122, 215);
            this.btnRemoveImg.Name = "btnRemoveImg";
            this.btnRemoveImg.Size = new System.Drawing.Size(28, 23);
            this.btnRemoveImg.TabIndex = 8;
            this.btnRemoveImg.Text = "X";
            this.btnRemoveImg.UseVisualStyleBackColor = true;
            this.btnRemoveImg.Click += new System.EventHandler(this.btnRemoveImg_Click);
            // 
            // frmEditAventura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 279);
            this.Controls.Add(this.btnRemoveImg);
            this.Controls.Add(this.btnBuscaImg);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditAventura";
            this.Text = "frmEditAventura";
            this.Load += new System.EventHandler(this.frmEditAventura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBuscaImg;
        private System.Windows.Forms.OpenFileDialog ofdImg;
        private System.Windows.Forms.Button btnRemoveImg;
    }
}