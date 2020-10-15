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
            this.medPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmedName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnsell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMainForm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.medPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMainForm
            // 
            this.dtgMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMainForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgMainForm.Location = new System.Drawing.Point(0, 298);
            this.dtgMainForm.Name = "dtgMainForm";
            this.dtgMainForm.Size = new System.Drawing.Size(800, 152);
            this.dtgMainForm.TabIndex = 20;
            this.dtgMainForm.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMainForm_RowHeaderMouseDoubleClick);
            // 
            // cmbByTags
            // 
            this.cmbByTags.FormattingEnabled = true;
            this.cmbByTags.Location = new System.Drawing.Point(225, 162);
            this.cmbByTags.Name = "cmbByTags";
            this.cmbByTags.Size = new System.Drawing.Size(181, 21);
            this.cmbByTags.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(221, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "by Tags";
            // 
            // cmbByMed
            // 
            this.cmbByMed.FormattingEnabled = true;
            this.cmbByMed.Location = new System.Drawing.Point(14, 162);
            this.cmbByMed.Name = "cmbByMed";
            this.cmbByMed.Size = new System.Drawing.Size(181, 21);
            this.cmbByMed.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(10, 132);
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
            // medPanel
            // 
            this.medPanel.Controls.Add(this.btnsell);
            this.medPanel.Controls.Add(this.btnBuy);
            this.medPanel.Controls.Add(this.chkList);
            this.medPanel.Controls.Add(this.numCount);
            this.medPanel.Controls.Add(this.label3);
            this.medPanel.Controls.Add(this.txtmedName);
            this.medPanel.Controls.Add(this.label2);
            this.medPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.medPanel.Location = new System.Drawing.Point(439, 27);
            this.medPanel.Name = "medPanel";
            this.medPanel.Size = new System.Drawing.Size(361, 271);
            this.medPanel.TabIndex = 21;
            this.medPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(27, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Medicine Name";
            // 
            // txtmedName
            // 
            this.txtmedName.Enabled = false;
            this.txtmedName.Location = new System.Drawing.Point(31, 41);
            this.txtmedName.Name = "txtmedName";
            this.txtmedName.Size = new System.Drawing.Size(134, 20);
            this.txtmedName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Count";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(31, 103);
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(134, 20);
            this.numCount.TabIndex = 20;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkList
            // 
            this.chkList.FormattingEnabled = true;
            this.chkList.Location = new System.Drawing.Point(190, 40);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(148, 94);
            this.chkList.TabIndex = 58;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Green;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuy.Location = new System.Drawing.Point(31, 168);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 59;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnsell
            // 
            this.btnsell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsell.Location = new System.Drawing.Point(190, 151);
            this.btnsell.Name = "btnsell";
            this.btnsell.Size = new System.Drawing.Size(75, 23);
            this.btnsell.TabIndex = 60;
            this.btnsell.Text = "Sell";
            this.btnsell.UseVisualStyleBackColor = false;
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // PharmacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.medPanel);
            this.Controls.Add(this.dtgMainForm);
            this.Controls.Add(this.cmbByTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbByMed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PharmacyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmacyForm";
            this.Load += new System.EventHandler(this.PharmacyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMainForm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.medPanel.ResumeLayout(false);
            this.medPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
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
        private System.Windows.Forms.Panel medPanel;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.CheckedListBox chkList;
    }
}

