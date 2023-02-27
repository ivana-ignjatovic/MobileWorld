namespace MobileWorld
{
    partial class CategoryPanel
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
            this.labelCategory = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.AllowDrop = true;
            this.labelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.labelCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCategory.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.labelCategory.Location = new System.Drawing.Point(0, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(357, 53);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Naziv kategorije";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCategory.Click += new System.EventHandler(this.labelCategory_Click);
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(324, 13);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(0, 16);
            this.lblCategoryId.TabIndex = 6;
            // 
            // CategoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.labelCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CategoryPanel";
            this.Size = new System.Drawing.Size(357, 82);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label lblCategoryId;
    }
}
