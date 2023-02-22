namespace MobileWorld
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.labelCategory = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNaplati = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteBillITem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDevices = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uredjajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCategory.Location = new System.Drawing.Point(0, 28);
            this.panelCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(351, 600);
            this.panelCategory.TabIndex = 0;
            // 
            // labelCategory
            // 
            this.labelCategory.AllowDrop = true;
            this.labelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.labelCategory.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.labelCategory.Location = new System.Drawing.Point(2, 26);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(351, 43);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "KATEGORIJE";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.buttonNaplati);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.buttonDeleteBillITem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1000, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 600);
            this.panel2.TabIndex = 1;
            // 
            // buttonNaplati
            // 
            this.buttonNaplati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.buttonNaplati.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNaplati.Location = new System.Drawing.Point(207, 449);
            this.buttonNaplati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNaplati.Name = "buttonNaplati";
            this.buttonNaplati.Size = new System.Drawing.Size(132, 56);
            this.buttonNaplati.TabIndex = 14;
            this.buttonNaplati.Text = "Naplati";
            this.buttonNaplati.UseVisualStyleBackColor = false;
            this.buttonNaplati.Click += new System.EventHandler(this.buttonNaplati_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceID,
            this.DeviceName,
            this.DevicePrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(24, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(332, 343);
            this.dataGridView1.TabIndex = 13;
            // 
            // DeviceID
            // 
            this.DeviceID.DataPropertyName = "DeviceID";
            this.DeviceID.HeaderText = "DeviceID";
            this.DeviceID.MinimumWidth = 6;
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.Width = 125;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "Name";
            this.DeviceName.MinimumWidth = 8;
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Width = 150;
            // 
            // DevicePrice
            // 
            this.DevicePrice.DataPropertyName = "DevicePrice";
            this.DevicePrice.HeaderText = "DevicePrice";
            this.DevicePrice.MinimumWidth = 8;
            this.DevicePrice.Name = "DevicePrice";
            this.DevicePrice.Width = 150;
            // 
            // buttonDeleteBillITem
            // 
            this.buttonDeleteBillITem.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteBillITem.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteBillITem.Location = new System.Drawing.Point(38, 449);
            this.buttonDeleteBillITem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteBillITem.Name = "buttonDeleteBillITem";
            this.buttonDeleteBillITem.Size = new System.Drawing.Size(132, 56);
            this.buttonDeleteBillITem.TabIndex = 12;
            this.buttonDeleteBillITem.Text = "Izbrisi";
            this.buttonDeleteBillITem.UseVisualStyleBackColor = false;
            this.buttonDeleteBillITem.Click += new System.EventHandler(this.buttonDeleteBillITem_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(1000, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "RAČUN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDevices
            // 
            this.panelDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDevices.Location = new System.Drawing.Point(351, 28);
            this.panelDevices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDevices.Name = "panelDevices";
            this.panelDevices.Size = new System.Drawing.Size(649, 600);
            this.panelDevices.TabIndex = 2;
            this.panelDevices.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDevices_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniToolStripMenuItem,
            this.uredjajiToolStripMenuItem,
            this.racuniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1378, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // zaposleniToolStripMenuItem
            // 
            this.zaposleniToolStripMenuItem.Name = "zaposleniToolStripMenuItem";
            this.zaposleniToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.zaposleniToolStripMenuItem.Text = "Zaposleni";
            this.zaposleniToolStripMenuItem.Click += new System.EventHandler(this.zaposleniToolStripMenuItem_Click);
            // 
            // uredjajiToolStripMenuItem
            // 
            this.uredjajiToolStripMenuItem.Name = "uredjajiToolStripMenuItem";
            this.uredjajiToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.uredjajiToolStripMenuItem.Text = "Uredjaji";
            this.uredjajiToolStripMenuItem.Click += new System.EventHandler(this.uredjajiToolStripMenuItem_Click);
            // 
            // racuniToolStripMenuItem
            // 
            this.racuniToolStripMenuItem.Name = "racuniToolStripMenuItem";
            this.racuniToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.racuniToolStripMenuItem.Text = "Racuni";
            this.racuniToolStripMenuItem.Click += new System.EventHandler(this.racuniToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1378, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDevices);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDevices;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zaposleniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uredjajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racuniToolStripMenuItem;
        private System.Windows.Forms.Button buttonDeleteBillITem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNaplati;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevicePrice;
    }
}

