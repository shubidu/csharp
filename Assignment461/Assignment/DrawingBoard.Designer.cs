namespace Assignment461
{
    partial class DrawingBoard
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
            this.pnlBig = new System.Windows.Forms.Panel();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.pnlBig.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBig
            // 
            this.pnlBig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBig.Controls.Add(this.pnlDraw);
            this.pnlBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBig.Location = new System.Drawing.Point(0, 0);
            this.pnlBig.Name = "pnlBig";
            this.pnlBig.Size = new System.Drawing.Size(349, 326);
            this.pnlBig.TabIndex = 0;
            // 
            // pnlDraw
            // 
            this.pnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDraw.Location = new System.Drawing.Point(28, 10);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(289, 286);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseDown);
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseMove);
            this.pnlDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseUp);
            // 
            // DrawingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 326);
            this.Controls.Add(this.pnlBig);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 364);
            this.Name = "DrawingBoard";
            this.Text = "DrawingBoard";
            this.Load += new System.EventHandler(this.DrawingBoard_Load);
            this.pnlBig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBig;
        private System.Windows.Forms.Panel pnlDraw;
    }
}