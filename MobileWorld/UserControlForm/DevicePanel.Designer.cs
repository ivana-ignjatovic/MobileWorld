namespace MobileWorld
{
    partial class DevicePanel
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
            this.labelId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddToBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv uredjaja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelImage
            // 
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImage.Location = new System.Drawing.Point(45, 31);
            this.panelImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(199, 119);
            this.panelImage.TabIndex = 2;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(259, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(44, 16);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "label3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::MobileWorld.Properties.Resources._326659_info_icon__2_;
            this.button1.Location = new System.Drawing.Point(-1, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddToBill
            // 
            this.buttonAddToBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.buttonAddToBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddToBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddToBill.Image = global::MobileWorld.Properties.Resources._3994437_add_create_new_plus_positive_icon;
            this.buttonAddToBill.Location = new System.Drawing.Point(244, 207);
            this.buttonAddToBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddToBill.Name = "buttonAddToBill";
            this.buttonAddToBill.Size = new System.Drawing.Size(44, 35);
            this.buttonAddToBill.TabIndex = 3;
            this.buttonAddToBill.UseVisualStyleBackColor = false;
            this.buttonAddToBill.Click += new System.EventHandler(this.buttonAddToBill_Click);
            // 
            // DevicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonAddToBill);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DevicePanel";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(287, 241);
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
        public System.Windows.Forms.Button button1;
    }
}
