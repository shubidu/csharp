namespace Generics
{
    partial class Form1
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
            this.btnCreateInt = new System.Windows.Forms.Button();
            this.btnCreateDbl = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateInt
            // 
            this.btnCreateInt.Location = new System.Drawing.Point(40, 27);
            this.btnCreateInt.Name = "btnCreateInt";
            this.btnCreateInt.Size = new System.Drawing.Size(126, 57);
            this.btnCreateInt.TabIndex = 0;
            this.btnCreateInt.Text = "Create Integers";
            this.btnCreateInt.UseVisualStyleBackColor = true;
            this.btnCreateInt.Click += new System.EventHandler(this.btnCreateInt_Click);
            // 
            // btnCreateDbl
            // 
            this.btnCreateDbl.Location = new System.Drawing.Point(250, 27);
            this.btnCreateDbl.Name = "btnCreateDbl";
            this.btnCreateDbl.Size = new System.Drawing.Size(126, 57);
            this.btnCreateDbl.TabIndex = 0;
            this.btnCreateDbl.Text = "Create Double";
            this.btnCreateDbl.UseVisualStyleBackColor = true;
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(40, 103);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(336, 172);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(37, 292);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(84, 13);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Enter searh key:";
            this.lblKey.Click += new System.EventHandler(this.lblKey_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(40, 361);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(336, 41);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(158, 289);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(218, 20);
            this.txtKey.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(37, 332);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(339, 26);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 414);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnCreateDbl);
            this.Controls.Add(this.btnCreateInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateInt;
        private System.Windows.Forms.Button btnCreateDbl;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblResult;
    }
}

