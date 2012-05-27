namespace WindowsFormsApplication1
{
    partial class frmDemo
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
            this.btnPrintText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrintText
            // 
            this.btnPrintText.Location = new System.Drawing.Point(197, 227);
            this.btnPrintText.Name = "btnPrintText";
            this.btnPrintText.Size = new System.Drawing.Size(75, 23);
            this.btnPrintText.TabIndex = 0;
            this.btnPrintText.Text = "PrintText";
            this.btnPrintText.UseVisualStyleBackColor = true;
            this.btnPrintText.Click += new System.EventHandler(this.btnPrintText_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnPrintText);
            this.Name = "frmDemo";
            this.Text = "DemoProject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintText;

    }
}

