namespace MobileWorld
{
    partial class BillPanel
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
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceID.ForeColor = System.Drawing.Color.White;
            this.lblDeviceID.Location = new System.Drawing.Point(0, 30);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(251, 26);
            this.lblDeviceID.TabIndex = 1;
            this.lblDeviceID.Text = "ID Racuna";
            this.lblDeviceID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.White;
            this.labelDateTime.Location = new System.Drawing.Point(0, 65);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(251, 26);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "Datum i vreme";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.buttonInfo.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(45, 138);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(160, 55);
            this.buttonInfo.TabIndex = 10;
            this.buttonInfo.Text = "Ceo racun";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // BillPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.lblDeviceID);
            this.Name = "BillPanel";
            this.Size = new System.Drawing.Size(251, 219);
            this.Load += new System.EventHandler(this.BillPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceID;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Button buttonInfo;
    }
}
