namespace Assignment461
{
    partial class FrmStart
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
            this.mnustripMain = new System.Windows.Forms.MenuStrip();
            this.mnuFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPenSize = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeOneMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeTwoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeThreeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeFourMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeFiveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeSixMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeSevenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeEightMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeNineMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeTenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHorLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCasLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnustripMain
            // 
            this.mnustripMain.AccessibleName = "";
            this.mnustripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFiles,
            this.mnuProperties,
            this.mnuWindows,
            this.mnuExit});
            this.mnustripMain.Location = new System.Drawing.Point(0, 0);
            this.mnustripMain.MdiWindowListItem = this.mnuWindows;
            this.mnustripMain.Name = "mnustripMain";
            this.mnustripMain.Size = new System.Drawing.Size(563, 24);
            this.mnustripMain.TabIndex = 1;
            this.mnustripMain.Text = "menuStrip1";
            // 
            // mnuFiles
            // 
            this.mnuFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuClose});
            this.mnuFiles.Name = "mnuFiles";
            this.mnuFiles.Size = new System.Drawing.Size(42, 20);
            this.mnuFiles.Text = "&Files";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(103, 22);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(103, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuProperties
            // 
            this.mnuProperties.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPenSize,
            this.mnuColor});
            this.mnuProperties.Name = "mnuProperties";
            this.mnuProperties.Size = new System.Drawing.Size(72, 20);
            this.mnuProperties.Text = "&Properties";
            // 
            // mnuPenSize
            // 
            this.mnuPenSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penSizeOneMenu,
            this.penSizeTwoMenu,
            this.penSizeThreeMenu,
            this.penSizeFourMenu,
            this.penSizeFiveMenu,
            this.penSizeSixMenu,
            this.penSizeSevenMenu,
            this.penSizeEightMenu,
            this.penSizeNineMenu,
            this.penSizeTenMenu});
            this.mnuPenSize.Name = "mnuPenSize";
            this.mnuPenSize.Size = new System.Drawing.Size(152, 22);
            this.mnuPenSize.Text = "Pen Size";
            // 
            // penSizeOneMenu
            // 
            this.penSizeOneMenu.Name = "penSizeOneMenu";
            this.penSizeOneMenu.Size = new System.Drawing.Size(86, 22);
            this.penSizeOneMenu.Text = "1";
            this.penSizeOneMenu.Click += new System.EventHandler(this.mnuPenSize_Click);
            // 
            // penSizeTwoMenu
            // 
            this.penSizeTwoMenu.Name = "penSizeTwoMenu";
            this.penSizeTwoMenu.Size = new System.Drawing.Size(86, 22);
            this.penSizeTwoMenu.Text = "2";
            this.penSizeTwoMenu.Click += new System.EventHandler(this.mnuPenSize_Click);
            // 
            // penSizeThreeMenu
            // 
            this.penSizeThreeMenu.Name = "penSizeThreeMenu";
            this.penSizeThreeMenu.Size = new System.Drawing.Size(86, 22);
            this.penSizeThreeMenu.Text = "3";
            this.penSizeThreeMenu.Click += new System.EventHandler(this.mnuPenSize_Click);
            // 
            // penSizeFourMenu
            // 
            this.penSizeFourMenu.Name = "penSizeFourMenu";
            this.penSizeFourMenu.Size = new System.Drawing.Size(86, 22);
            this.penSizeFourMenu.Text = "4";
            this.penSizeFourMenu.Click += new System.EventHandler(this.mnuPenSize_Click);
            // 
            // penSizeFiveMenu
            // 
            this.penSizeFiveMenu.Name = "penSizeFiveMenu";
            this.penSizeFiveMenu.Size = new System.Drawing.Size(86, 22);
            this.penSizeFiveMenu.Text = "5";
            this.penSizeFiveMenu.Click += new System.EventHandler(this.mnuPenSize_Click);
            // 
            // penSizeSixMenu
            // 
            this.penSizeSixMenu.Name = "penSizeSixMenu";
            this.penSizeSixMenu.Size = new System.Drawing.Size(86, 22);
            this.penSizeSixMenu.Text = "6";
            this.penSizeSixMenu.Click += new System.EventHandler(this.mnuPenSize_Click);
            // 
            // penSizeSevenMenu
            // 
            this.penSizeSevenMenu.Name = "penSizeSevenMenu";
            this.penSizeSevenMenu.Size = new System.Drawing.Size(86, 22);
            this.penSizeSevenMenu.Text = "7";
            this.penSizeSevenMenu.Click += new System.EventHandler(this.mnuPenSize_Click);
            // 
            // penSizeEightMenu
            // 
            this.penSizeEightMenu.Name = "penSizeEightMenu";
            this.penSizeEightMenu.Size = new System.Drawing.Size(86, 22);
            this.penSizeEightMenu.Text = "8";
            this.penSizeEightMenu.Click += new System.EventHandler(this.mnuPenSize_Click);
            // 
            // penSizeNineMenu
            // 
            this.penSizeNineMenu.Name = "penSizeNineMenu";
            this.penSizeNineMenu.Size = new System.Drawing.Size(86, 22);
            this.penSizeNineMenu.Text = "9";
            this.penSizeNineMenu.Click += new System.EventHandler(this.mnuPenSize_Click);
            // 
            // penSizeTenMenu
            // 
            this.penSizeTenMenu.Name = "penSizeTenMenu";
            this.penSizeTenMenu.Size = new System.Drawing.Size(86, 22);
            this.penSizeTenMenu.Text = "10";
            this.penSizeTenMenu.Click += new System.EventHandler(this.mnuPenSize_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(152, 22);
            this.mnuColor.Text = "Color";
            this.mnuColor.Click += new System.EventHandler(this.mnuColor_Click);
            // 
            // mnuWindows
            // 
            this.mnuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVerLayout,
            this.mnuHorLayout,
            this.mnuCasLayout});
            this.mnuWindows.Name = "mnuWindows";
            this.mnuWindows.Size = new System.Drawing.Size(68, 20);
            this.mnuWindows.Text = "&Windows";
            // 
            // mnuVerLayout
            // 
            this.mnuVerLayout.Name = "mnuVerLayout";
            this.mnuVerLayout.Size = new System.Drawing.Size(129, 22);
            this.mnuVerLayout.Text = "Vertical";
            this.mnuVerLayout.Click += new System.EventHandler(this.mnuVerLayout_Click);
            // 
            // mnuHorLayout
            // 
            this.mnuHorLayout.Name = "mnuHorLayout";
            this.mnuHorLayout.Size = new System.Drawing.Size(129, 22);
            this.mnuHorLayout.Text = "Horizontal";
            this.mnuHorLayout.Click += new System.EventHandler(this.mnuHorLayout_Click);
            // 
            // mnuCasLayout
            // 
            this.mnuCasLayout.Name = "mnuCasLayout";
            this.mnuCasLayout.Size = new System.Drawing.Size(129, 22);
            this.mnuCasLayout.Text = "Cascade";
            this.mnuCasLayout.Click += new System.EventHandler(this.mnuCasLayout_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 465);
            this.Controls.Add(this.mnustripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnustripMain;
            this.Name = "FrmStart";
            this.Text = "FrmStart";
            this.mnustripMain.ResumeLayout(false);
            this.mnustripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnustripMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFiles;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuProperties;
        private System.Windows.Forms.ToolStripMenuItem mnuPenSize;
        private System.Windows.Forms.ToolStripMenuItem penSizeOneMenu;
        private System.Windows.Forms.ToolStripMenuItem penSizeTwoMenu;
        private System.Windows.Forms.ToolStripMenuItem penSizeThreeMenu;
        private System.Windows.Forms.ToolStripMenuItem penSizeFourMenu;
        private System.Windows.Forms.ToolStripMenuItem penSizeFiveMenu;
        private System.Windows.Forms.ToolStripMenuItem penSizeSixMenu;
        private System.Windows.Forms.ToolStripMenuItem penSizeSevenMenu;
        private System.Windows.Forms.ToolStripMenuItem penSizeEightMenu;
        private System.Windows.Forms.ToolStripMenuItem penSizeNineMenu;
        private System.Windows.Forms.ToolStripMenuItem penSizeTenMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuWindows;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem mnuVerLayout;
        private System.Windows.Forms.ToolStripMenuItem mnuHorLayout;
        private System.Windows.Forms.ToolStripMenuItem mnuCasLayout;
    }
}

