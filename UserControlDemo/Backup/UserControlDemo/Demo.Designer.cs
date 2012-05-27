namespace UserControlDemo
{
    partial class Demo
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
            this.loginControl1 = new SampleForm.LoginControl();
            this.SuspendLayout();
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginControl1.Location = new System.Drawing.Point(0, 1);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(251, 139);
            this.loginControl1.TabIndex = 0;
            this.loginControl1.UserName = "student";
    
            this.loginControl1.Login += new SampleForm.LoginHandler(this.loginControl1_Login);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 141);
            this.Controls.Add(this.loginControl1);
            this.Name = "Demo";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SampleForm.LoginControl loginControl1;
    }
}

