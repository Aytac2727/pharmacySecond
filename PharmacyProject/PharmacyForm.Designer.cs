namespace PharmacyProject
{
    partial class PharmacyForm
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
            this.dtgMainForm = new System.Windows.Forms.DataGridView();
            this.cmbByTags = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbByMed = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMainForm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgMainForm
            // 
            this.dtgMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMainForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgMainForm.Location = new System.Drawing.Point(0, 249);
            this.dtgMainForm.Name = "dtgMainForm";
            this.dtgMainForm.Size = new System.Drawing.Size(800, 201);
            this.dtgMainForm.TabIndex = 20;
            // 
            // cmbByTags
            // 
            this.cmbByTags.FormattingEnabled = true;
            this.cmbByTags.Location = new System.Drawing.Point(413, 164);
            this.cmbByTags.Name = "cmbByTags";
            this.cmbByTags.Size = new System.Drawing.Size(181, 21);
            this.cmbByTags.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(409, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "by Tags";
            // 
            // cmbByMed
            // 
            this.cmbByMed.FormattingEnabled = true;
            this.cmbByMed.Location = new System.Drawing.Point(101, 164);
            this.cmbByMed.Name = "cmbByMed";
            this.cmbByMed.Size = new System.Drawing.Size(181, 21);
            this.cmbByMed.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(97, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "by Medicine";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.medicineToolStripMenuItem,
            this.firmsToolStripMenuItem,
            this.tagsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.medicineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.medicineToolStripMenuItem.Text = "Medicine";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // firmsToolStripMenuItem
            // 
            this.firmsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firmsToolStripMenuItem.Name = "firmsToolStripMenuItem";
            this.firmsToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.firmsToolStripMenuItem.Text = "Firms";
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.tagsToolStripMenuItem.Text = "Tags";
            // 
            // PharmacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgMainForm);
            this.Controls.Add(this.cmbByTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbByMed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PharmacyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmacyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMainForm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMainForm;
        private System.Windows.Forms.ComboBox cmbByTags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbByMed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
    }
}

