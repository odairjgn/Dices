namespace Dices.Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenu = new System.Windows.Forms.Ribbon();
            this.rtbInicio = new System.Windows.Forms.RibbonTab();
            this.rpnCalc = new System.Windows.Forms.RibbonPanel();
            this.rpbDados = new System.Windows.Forms.RibbonPanel();
            this.menuImportExport = new System.Windows.Forms.RibbonOrbMenuItem();
            this.menuTrocar = new System.Windows.Forms.RibbonButton();
            this.menuAjuda = new System.Windows.Forms.RibbonButton();
            this.menuSair = new System.Windows.Forms.RibbonButton();
            this.mSobre = new System.Windows.Forms.RibbonButton();
            this.menuFeedbak = new System.Windows.Forms.RibbonOrbRecentItem();
            this.rbtCalculadora = new System.Windows.Forms.RibbonButton();
            this.btnD20 = new System.Windows.Forms.RibbonButton();
            this.btnD4 = new System.Windows.Forms.RibbonButton();
            this.btnD6 = new System.Windows.Forms.RibbonButton();
            this.btnD8 = new System.Windows.Forms.RibbonButton();
            this.btnD10 = new System.Windows.Forms.RibbonButton();
            this.btnD12 = new System.Windows.Forms.RibbonButton();
            this.btnD100 = new System.Windows.Forms.RibbonButton();
            this.btn10p = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.btnDOutros = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Controls.Add(this.mainMenu, 0, 0);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Margin = new System.Windows.Forms.Padding(0);
            this.layout.Name = "layout";
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Size = new System.Drawing.Size(775, 492);
            this.layout.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenu.BorderMode = System.Windows.Forms.RibbonWindowMode.InsideWindow;
            this.mainMenu.CaptionBarVisible = false;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenu.Minimized = false;
            this.mainMenu.Name = "mainMenu";
            // 
            // 
            // 
            this.mainMenu.OrbDropDown.BorderRoundness = 8;
            this.mainMenu.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.OrbDropDown.MenuItems.Add(this.menuImportExport);
            this.mainMenu.OrbDropDown.MenuItems.Add(this.menuTrocar);
            this.mainMenu.OrbDropDown.MenuItems.Add(this.menuAjuda);
            this.mainMenu.OrbDropDown.Name = "";
            this.mainMenu.OrbDropDown.OptionItems.Add(this.menuSair);
            this.mainMenu.OrbDropDown.OptionItems.Add(this.mSobre);
            this.mainMenu.OrbDropDown.RecentItems.Add(this.menuFeedbak);
            this.mainMenu.OrbDropDown.Size = new System.Drawing.Size(527, 204);
            this.mainMenu.OrbDropDown.TabIndex = 0;
            this.mainMenu.OrbDropDown.Text = "Dices";
            this.mainMenu.OrbImage = null;
            this.mainMenu.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.mainMenu.OrbText = "Dices";
            this.mainMenu.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.mainMenu.Size = new System.Drawing.Size(775, 122);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Tabs.Add(this.rtbInicio);
            this.mainMenu.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.mainMenu.Text = "Menu";
            this.mainMenu.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            // 
            // rtbInicio
            // 
            this.rtbInicio.Panels.Add(this.rpnCalc);
            this.rtbInicio.Panels.Add(this.rpbDados);
            this.rtbInicio.Text = "Inicio";
            // 
            // rpnCalc
            // 
            this.rpnCalc.Items.Add(this.rbtCalculadora);
            this.rpnCalc.Text = "Atalhos";
            // 
            // rpbDados
            // 
            this.rpbDados.Items.Add(this.btnD20);
            this.rpbDados.Items.Add(this.btnD4);
            this.rpbDados.Items.Add(this.btnD6);
            this.rpbDados.Items.Add(this.btnD8);
            this.rpbDados.Items.Add(this.btnD10);
            this.rpbDados.Items.Add(this.btnD12);
            this.rpbDados.Items.Add(this.btnD100);
            this.rpbDados.Items.Add(this.ribbonSeparator2);
            this.rpbDados.Items.Add(this.btn10p);
            this.rpbDados.Items.Add(this.ribbonSeparator1);
            this.rpbDados.Items.Add(this.btnDOutros);
            this.rpbDados.Text = "Dados";
            // 
            // menuImportExport
            // 
            this.menuImportExport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.menuImportExport.Image = ((System.Drawing.Image)(resources.GetObject("menuImportExport.Image")));
            this.menuImportExport.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuImportExport.SmallImage")));
            this.menuImportExport.Text = "Exportar/Importar";
            // 
            // menuTrocar
            // 
            this.menuTrocar.Image = ((System.Drawing.Image)(resources.GetObject("menuTrocar.Image")));
            this.menuTrocar.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuTrocar.SmallImage")));
            this.menuTrocar.Text = "Trocar de Aventura";
            // 
            // menuAjuda
            // 
            this.menuAjuda.Image = ((System.Drawing.Image)(resources.GetObject("menuAjuda.Image")));
            this.menuAjuda.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuAjuda.SmallImage")));
            this.menuAjuda.Text = "Ajuda";
            // 
            // menuSair
            // 
            this.menuSair.Image = ((System.Drawing.Image)(resources.GetObject("menuSair.Image")));
            this.menuSair.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuSair.SmallImage")));
            this.menuSair.Text = "Sair";
            // 
            // mSobre
            // 
            this.mSobre.Image = ((System.Drawing.Image)(resources.GetObject("mSobre.Image")));
            this.mSobre.SmallImage = ((System.Drawing.Image)(resources.GetObject("mSobre.SmallImage")));
            this.mSobre.Text = "Sobre...";
            // 
            // menuFeedbak
            // 
            this.menuFeedbak.Image = ((System.Drawing.Image)(resources.GetObject("menuFeedbak.Image")));
            this.menuFeedbak.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuFeedbak.SmallImage")));
            this.menuFeedbak.Text = "Deixe seu feedeback";
            // 
            // rbtCalculadora
            // 
            this.rbtCalculadora.Image = global::Dices.Properties.Resources.CalculadoraIco;
            this.rbtCalculadora.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtCalculadora.SmallImage")));
            this.rbtCalculadora.Text = "Calculadora";
            this.rbtCalculadora.ToolTip = "Calculadora";
            // 
            // btnD20
            // 
            this.btnD20.Image = global::Dices.Properties.Resources.d20;
            this.btnD20.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnD20.SmallImage")));
            this.btnD20.Text = "D20";
            // 
            // btnD4
            // 
            this.btnD4.Image = global::Dices.Properties.Resources.d4;
            this.btnD4.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnD4.SmallImage")));
            this.btnD4.Text = "D4";
            // 
            // btnD6
            // 
            this.btnD6.Image = global::Dices.Properties.Resources.d6;
            this.btnD6.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnD6.SmallImage")));
            this.btnD6.Text = "D6";
            // 
            // btnD8
            // 
            this.btnD8.Image = global::Dices.Properties.Resources.d8;
            this.btnD8.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnD8.SmallImage")));
            this.btnD8.Text = "D8";
            // 
            // btnD10
            // 
            this.btnD10.Image = global::Dices.Properties.Resources.d10;
            this.btnD10.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnD10.SmallImage")));
            this.btnD10.Text = "D10";
            // 
            // btnD12
            // 
            this.btnD12.Image = global::Dices.Properties.Resources.d12;
            this.btnD12.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnD12.SmallImage")));
            this.btnD12.Text = "D12";
            // 
            // btnD100
            // 
            this.btnD100.Image = global::Dices.Properties.Resources.d100;
            this.btnD100.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnD100.SmallImage")));
            this.btnD100.Text = "D100";
            // 
            // btn10p
            // 
            this.btn10p.Image = global::Dices.Properties.Resources.d10p;
            this.btn10p.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn10p.SmallImage")));
            this.btn10p.Text = "D10%";
            // 
            // btnDOutros
            // 
            this.btnDOutros.Image = global::Dices.Properties.Resources.dx;
            this.btnDOutros.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDOutros.SmallImage")));
            this.btnDOutros.Text = "Personalizado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 492);
            this.Controls.Add(this.layout);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.layout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Ribbon mainMenu;
        private System.Windows.Forms.RibbonTab rtbInicio;
        private System.Windows.Forms.RibbonPanel rpnCalc;
        private System.Windows.Forms.RibbonButton rbtCalculadora;
        private System.Windows.Forms.RibbonOrbMenuItem menuImportExport;
        private System.Windows.Forms.RibbonButton menuTrocar;
        private System.Windows.Forms.RibbonButton menuAjuda;
        private System.Windows.Forms.RibbonButton menuSair;
        private System.Windows.Forms.RibbonOrbRecentItem menuFeedbak;
        private System.Windows.Forms.RibbonButton mSobre;
        private System.Windows.Forms.RibbonPanel rpbDados;
        private System.Windows.Forms.RibbonButton btnD20;
        private System.Windows.Forms.RibbonButton btnD4;
        private System.Windows.Forms.RibbonButton btnD6;
        private System.Windows.Forms.RibbonButton btnD8;
        private System.Windows.Forms.RibbonButton btnD10;
        private System.Windows.Forms.RibbonButton btnD12;
        private System.Windows.Forms.RibbonButton btnD100;
        private System.Windows.Forms.RibbonButton btn10p;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonButton btnDOutros;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
    }
}