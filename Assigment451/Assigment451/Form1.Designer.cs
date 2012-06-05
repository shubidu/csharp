namespace Assigment451
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
            this.btnCreateTourist = new System.Windows.Forms.Button();
            this.btnCreateConference = new System.Windows.Forms.Button();
            this.btnCapacityRooms = new System.Windows.Forms.Button();
            this.lbxView = new System.Windows.Forms.ListBox();
            this.btnBillRooms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTourist
            // 
            this.btnCreateTourist.Location = new System.Drawing.Point(12, 12);
            this.btnCreateTourist.Name = "btnCreateTourist";
            this.btnCreateTourist.Size = new System.Drawing.Size(166, 58);
            this.btnCreateTourist.TabIndex = 0;
            this.btnCreateTourist.Text = "Create Tourist";
            this.btnCreateTourist.UseVisualStyleBackColor = true;
            this.btnCreateTourist.Click += new System.EventHandler(this.btnCreateTourist_Click);
            // 
            // btnCreateConference
            // 
            this.btnCreateConference.Location = new System.Drawing.Point(12, 106);
            this.btnCreateConference.Name = "btnCreateConference";
            this.btnCreateConference.Size = new System.Drawing.Size(166, 58);
            this.btnCreateConference.TabIndex = 0;
            this.btnCreateConference.Text = "Create Conference";
            this.btnCreateConference.UseVisualStyleBackColor = true;
            this.btnCreateConference.Click += new System.EventHandler(this.btnCreateConference_Click);
            // 
            // btnCapacityRooms
            // 
            this.btnCapacityRooms.Location = new System.Drawing.Point(385, 106);
            this.btnCapacityRooms.Name = "btnCapacityRooms";
            this.btnCapacityRooms.Size = new System.Drawing.Size(166, 58);
            this.btnCapacityRooms.TabIndex = 0;
            this.btnCapacityRooms.Text = "Capacity";
            this.btnCapacityRooms.UseVisualStyleBackColor = true;
            this.btnCapacityRooms.Click += new System.EventHandler(this.btnCapacityRooms_Click);
            // 
            // lbxView
            // 
            this.lbxView.FormattingEnabled = true;
            this.lbxView.Location = new System.Drawing.Point(13, 170);
            this.lbxView.Name = "lbxView";
            this.lbxView.Size = new System.Drawing.Size(538, 134);
            this.lbxView.TabIndex = 1;
            // 
            // btnBillRooms
            // 
            this.btnBillRooms.Location = new System.Drawing.Point(385, 12);
            this.btnBillRooms.Name = "btnBillRooms";
            this.btnBillRooms.Size = new System.Drawing.Size(166, 58);
            this.btnBillRooms.TabIndex = 0;
            this.btnBillRooms.Text = "Bill Rooms";
            this.btnBillRooms.UseVisualStyleBackColor = true;
            this.btnBillRooms.Click += new System.EventHandler(this.btnBillRooms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 313);
            this.Controls.Add(this.lbxView);
            this.Controls.Add(this.btnBillRooms);
            this.Controls.Add(this.btnCreateConference);
            this.Controls.Add(this.btnCapacityRooms);
            this.Controls.Add(this.btnCreateTourist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTourist;
        private System.Windows.Forms.Button btnCreateConference;
        private System.Windows.Forms.Button btnCapacityRooms;
        private System.Windows.Forms.ListBox lbxView;
        private System.Windows.Forms.Button btnBillRooms;
    }
}

