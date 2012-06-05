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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.filesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.colorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalArrangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalArrangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeArrangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesMenu,
            this.propertiesMenu,
            this.windowsMenu,
            this.exitMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MdiWindowListItem = this.windowsMenu;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(563, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // filesMenu
            // 
            this.filesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.closeMenu});
            this.filesMenu.Name = "filesMenu";
            this.filesMenu.Size = new System.Drawing.Size(42, 20);
            this.filesMenu.Text = "Files";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.Size = new System.Drawing.Size(103, 22);
            this.newMenu.Text = "New";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(103, 22);
            this.closeMenu.Text = "Close";
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // propertiesMenu
            // 
            this.propertiesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penSizeMenu,
            this.colorMenu});
            this.propertiesMenu.Name = "propertiesMenu";
            this.propertiesMenu.Size = new System.Drawing.Size(72, 20);
            this.propertiesMenu.Text = "Properties";
            // 
            // penSizeMenu
            // 
            this.penSizeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.penSizeMenu.Name = "penSizeMenu";
            this.penSizeMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeMenu.Text = "Pen Size";
            // 
            // penSizeOneMenu
            // 
            this.penSizeOneMenu.Name = "penSizeOneMenu";
            this.penSizeOneMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeOneMenu.Text = "1";
            this.penSizeOneMenu.Click += new System.EventHandler(this.penSizeMenu_Click);
            // 
            // penSizeTwoMenu
            // 
            this.penSizeTwoMenu.Name = "penSizeTwoMenu";
            this.penSizeTwoMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeTwoMenu.Text = "2";
            this.penSizeTwoMenu.Click += new System.EventHandler(this.penSizeMenu_Click);
            // 
            // penSizeThreeMenu
            // 
            this.penSizeThreeMenu.Name = "penSizeThreeMenu";
            this.penSizeThreeMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeThreeMenu.Text = "3";
            this.penSizeThreeMenu.Click += new System.EventHandler(this.penSizeMenu_Click);
            // 
            // penSizeFourMenu
            // 
            this.penSizeFourMenu.Name = "penSizeFourMenu";
            this.penSizeFourMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeFourMenu.Text = "4";
            this.penSizeFourMenu.Click += new System.EventHandler(this.penSizeMenu_Click);
            // 
            // penSizeFiveMenu
            // 
            this.penSizeFiveMenu.Name = "penSizeFiveMenu";
            this.penSizeFiveMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeFiveMenu.Text = "5";
            this.penSizeFiveMenu.Click += new System.EventHandler(this.penSizeMenu_Click);
            // 
            // penSizeSixMenu
            // 
            this.penSizeSixMenu.Name = "penSizeSixMenu";
            this.penSizeSixMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeSixMenu.Text = "6";
            this.penSizeSixMenu.Click += new System.EventHandler(this.penSizeMenu_Click);
            // 
            // penSizeSevenMenu
            // 
            this.penSizeSevenMenu.Name = "penSizeSevenMenu";
            this.penSizeSevenMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeSevenMenu.Text = "7";
            this.penSizeSevenMenu.Click += new System.EventHandler(this.penSizeMenu_Click);
            // 
            // penSizeEightMenu
            // 
            this.penSizeEightMenu.Name = "penSizeEightMenu";
            this.penSizeEightMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeEightMenu.Text = "8";
            this.penSizeEightMenu.Click += new System.EventHandler(this.penSizeMenu_Click);
            // 
            // penSizeNineMenu
            // 
            this.penSizeNineMenu.Name = "penSizeNineMenu";
            this.penSizeNineMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeNineMenu.Text = "9";
            this.penSizeNineMenu.Click += new System.EventHandler(this.penSizeMenu_Click);
            // 
            // penSizeTenMenu
            // 
            this.penSizeTenMenu.Name = "penSizeTenMenu";
            this.penSizeTenMenu.Size = new System.Drawing.Size(152, 22);
            this.penSizeTenMenu.Text = "10";
            this.penSizeTenMenu.Click += new System.EventHandler(this.penSizeMenu_Click);
            // 
            // colorMenu
            // 
            this.colorMenu.Name = "colorMenu";
            this.colorMenu.Size = new System.Drawing.Size(152, 22);
            this.colorMenu.Text = "Color";
            this.colorMenu.Click += new System.EventHandler(this.colorMenu_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalArrangeMenu,
            this.horizontalArrangeMenu,
            this.cascadeArrangeMenu});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "Windows";
            // 
            // verticalArrangeMenu
            // 
            this.verticalArrangeMenu.Name = "verticalArrangeMenu";
            this.verticalArrangeMenu.Size = new System.Drawing.Size(129, 22);
            this.verticalArrangeMenu.Text = "Vertical";
            this.verticalArrangeMenu.Click += new System.EventHandler(this.verticalArrangeMenu_Click);
            // 
            // horizontalArrangeMenu
            // 
            this.horizontalArrangeMenu.Name = "horizontalArrangeMenu";
            this.horizontalArrangeMenu.Size = new System.Drawing.Size(129, 22);
            this.horizontalArrangeMenu.Text = "Horizontal";
            this.horizontalArrangeMenu.Click += new System.EventHandler(this.horizontalArrangeMenu_Click);
            // 
            // cascadeArrangeMenu
            // 
            this.cascadeArrangeMenu.Name = "cascadeArrangeMenu";
            this.cascadeArrangeMenu.Size = new System.Drawing.Size(129, 22);
            this.cascadeArrangeMenu.Text = "Cascade";
            this.cascadeArrangeMenu.Click += new System.EventHandler(this.cascadeArrangeMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(37, 20);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 465);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FrmStart";
            this.Text = "FrmStart";
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem filesMenu;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.ToolStripMenuItem propertiesMenu;
        private System.Windows.Forms.ToolStripMenuItem penSizeMenu;
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
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem colorMenu;
        private System.Windows.Forms.ToolStripMenuItem verticalArrangeMenu;
        private System.Windows.Forms.ToolStripMenuItem horizontalArrangeMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeArrangeMenu;
    }
}

