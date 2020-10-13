namespace PharmacyProject
{
    partial class AddMedicineForm
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
            this.dtgAddMedicine = new System.Windows.Forms.DataGridView();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkReceipt = new System.Windows.Forms.CheckBox();
            this.dateExp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.datePro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAddMedicine
            // 
            this.dtgAddMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAddMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgAddMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAddMedicine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgAddMedicine.Location = new System.Drawing.Point(0, 408);
            this.dtgAddMedicine.Name = "dtgAddMedicine";
            this.dtgAddMedicine.Size = new System.Drawing.Size(903, 160);
            this.dtgAddMedicine.TabIndex = 59;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.Teal;
            this.btnAddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMedicine.Location = new System.Drawing.Point(27, 365);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(127, 37);
            this.btnAddMedicine.TabIndex = 58;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(599, 96);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(181, 94);
            this.checkedListBox1.TabIndex = 57;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // cmbTags
            // 
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(599, 35);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(181, 21);
            this.cmbTags.TabIndex = 56;
            this.cmbTags.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTags_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(595, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Tags";
            // 
            // chkReceipt
            // 
            this.chkReceipt.AutoSize = true;
            this.chkReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReceipt.ForeColor = System.Drawing.Color.Teal;
            this.chkReceipt.Location = new System.Drawing.Point(323, 249);
            this.chkReceipt.Name = "chkReceipt";
            this.chkReceipt.Size = new System.Drawing.Size(98, 19);
            this.chkReceipt.TabIndex = 54;
            this.chkReceipt.Text = "Is Receipt?";
            this.chkReceipt.UseVisualStyleBackColor = true;
            // 
            // dateExp
            // 
            this.dateExp.Location = new System.Drawing.Point(323, 209);
            this.dateExp.Name = "dateExp";
            this.dateExp.Size = new System.Drawing.Size(200, 20);
            this.dateExp.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(319, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Experience Date";
            // 
            // datePro
            // 
            this.datePro.Location = new System.Drawing.Point(323, 121);
            this.datePro.Name = "datePro";
            this.datePro.Size = new System.Drawing.Size(200, 20);
            this.datePro.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(319, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Production Date";
            // 
            // cmbFirms
            // 
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.Location = new System.Drawing.Point(312, 35);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(181, 21);
            this.cmbFirms.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(308, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Firms";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(27, 249);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(187, 96);
            this.txtDesc.TabIndex = 47;
            this.txtDesc.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(26, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Description";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(27, 189);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(190, 20);
            this.numPrice.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(32, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Price";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(30, 109);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(190, 20);
            this.txtBarcode.TabIndex = 43;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumber);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Barcode";
            // 
            // txtMedName
            // 
            this.txtMedName.Location = new System.Drawing.Point(30, 36);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(190, 20);
            this.txtMedName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(27, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Medicine Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(319, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Count";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(323, 325);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(190, 20);
            this.txtCount.TabIndex = 61;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumber);
            // 
            // AddMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 568);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgAddMedicine);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkReceipt);
            this.Controls.Add(this.dateExp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datePro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFirms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMedName);
            this.Controls.Add(this.label1);
            this.Name = "AddMedicineForm";
            this.Text = "AddMedicineForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddMedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAddMedicine;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkReceipt;
        private System.Windows.Forms.DateTimePicker dateExp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFirms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCount;
    }
}