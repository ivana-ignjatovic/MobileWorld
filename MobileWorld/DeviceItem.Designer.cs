namespace MobileWorld
{
    partial class DeviceItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.buttonAddToBill = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv uredjaja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelImage
            // 
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImage.Location = new System.Drawing.Point(51, 39);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(224, 149);
            this.panelImage.TabIndex = 2;
            // 
            // buttonAddToBill
            // 
            this.buttonAddToBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.buttonAddToBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddToBill.Image = global::MobileWorld.Properties.Resources.icons8_loading_heart_24;
            this.buttonAddToBill.Location = new System.Drawing.Point(260, 248);
            this.buttonAddToBill.Name = "buttonAddToBill";
            this.buttonAddToBill.Size = new System.Drawing.Size(52, 47);
            this.buttonAddToBill.TabIndex = 3;
            this.buttonAddToBill.UseVisualStyleBackColor = false;
            this.buttonAddToBill.Click += new System.EventHandler(this.buttonAddToBill_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(291, 28);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(51, 20);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "label3";
            // 
            // DeviceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonAddToBill);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "DeviceItem";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(321, 299);
            this.Load += new System.EventHandler(this.DeviceItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       // public System.Windows.Forms.Label labelID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panelImage;
        public System.Windows.Forms.Button buttonAddToBill;
        public System.Windows.Forms.Label labelId;
    }
}
