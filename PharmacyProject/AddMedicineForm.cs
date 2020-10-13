using PharmacyProject.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyProject
{
    public partial class AddMedicineForm : Form
    {
        PharmacyEntities db = new PharmacyEntities();
        public AddMedicineForm()
        {
            InitializeComponent();
        }

        public void FillFirmsCombo()
        {
            cmbFirms.Items.AddRange(db.Firms.Select(x => x.Name).ToArray());
        }

        public void FillTagsCombo()
        {
            cmbTags.Items.AddRange(db.Tags.Select(x => x.Name).ToArray());
        }

        public void FillDataGridMedicine()
        {
            dtgAddMedicine.DataSource = db.Medicines.Select(md => new
            {
                Medicine_Name = md.Name,
                md.Barcode,
                md.Quantity,
                md.Price,
                IsReceipt = md.Withreceipt ? "Reseptli" : "Reseptsiz",
                md.ProductionDate,
                md.ExperienceDate
            }).ToList();
            for (var i = 0; i < dtgAddMedicine.Rows.Count; i++)
            {
               DateTime dtEx =(DateTime)dtgAddMedicine.Rows[i].Cells[dtgAddMedicine.Columns.Count - 1].Value;
                if(dtEx < DateTime.Now)
                {
                    dtgAddMedicine.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                    dtgAddMedicine.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            
        }
        private void AddMedicineForm_Load(object sender, EventArgs e)
        {
            FillFirmsCombo();
            FillTagsCombo();
            FillDataGridMedicine();
        }

        public int HaveFirms(string frm)
        {
            Firm hasFirm = db.Firms.FirstOrDefault(x => x.Name == frm);
            if(hasFirm == null)
            {
                Firm newFirm = new Firm()
                {
                    Name = frm
                };
                db.Firms.Add(newFirm);
                db.SaveChanges();
                return newFirm.ID;
            }
                return hasFirm.ID;
        }
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string FirmName = cmbFirms.Text;
            int FirmId = HaveFirms(FirmName);
            string medName = txtMedName.Text;
            string barCode = txtBarcode.Text;
            string medCount = txtCount.Text;
            DateTime prodate = datePro.Value;
            DateTime expDate = dateExp.Value;
            decimal price = numPrice.Value;
            string desc = txtDesc.Text;
            string[] myArr = new string[] { FirmName, medName, barCode, medCount, desc};
           if(Extentions.IsEmpty(myArr,string.Empty))
            {
                if(expDate >= DateTime.Now)
                {
                    Medicine newMed = new Medicine()
                    {
                        Name = medName,
                        Barcode = Convert.ToInt32(barCode),
                        Quantity = Convert.ToInt32(medCount),
                        ProductionDate = prodate,
                        ExperienceDate = expDate,
                        Price = price,
                        Description = desc,
                        Withreceipt = chkReceipt.Checked ? true : false,
                    };
                    db.Medicines.Add(newMed);
                    db.SaveChanges();
                    db.Medicine_To_Firms.Add(new Medicine_To_Firms()
                    {
                        MedicineId = newMed.Id,
                        FirmId = FirmId,
                    });
                    db.SaveChanges();
                    AddMedWithTag(newMed.Id);
                    MessageBox.Show("Medicine was added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllData();
                }
            }
        
        }

        public void ClearAllData()
        {
            foreach (var con in this.Controls)
            {
                if(con is TextBox)
                {
                    TextBox txt = (TextBox)con;
                    txt.Text = "";
                }
                else if(con is ComboBox)
                {
                    ComboBox cmb = (ComboBox)con;
                    cmb.Text = "";
                }
                else if(con is NumericUpDown)
                {
                    NumericUpDown num = (NumericUpDown)con;
                    num.Value = 0;
                }
                else if(con is RichTextBox)
                {
                    RichTextBox rc = (RichTextBox)con;
                    rc.Text = "";
                }
                else if(con is CheckedListBox)
                {
                    CheckedListBox ch = (CheckedListBox)con;
                    ch.Items.Clear();
                }
                else if(con is DateTimePicker)
                {
                    DateTimePicker dtg = (DateTimePicker)con;
                    dtg.Value = DateTime.Now;
                }
                else if (con is CheckBox)
                {
                    CheckBox check = (CheckBox)con;
                    check.Checked = false;
                }
            }
        }
        public void AddMedWithTag(int medId)
        {
            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i --)
            {
                string tagName = checkedListBox1.Items[i].ToString();
                Tag selectedTag = db.Tags.FirstOrDefault(tg => tg.Name == tagName);
                int tagId;
                if(selectedTag == null)
                {
                    Tag newTag = new Tag()
                    {
                        Name = tagName
                    };
                    db.Tags.Add(newTag);
                    db.SaveChanges();
                    tagId = newTag.ID;
                }
                else
                {
                    tagId = selectedTag.ID;
                }
                db.Medicine_To_Tags.Add(new Medicine_To_Tags()
                {
                    MedicineID = medId,
                    TagID = tagId
                });
                db.SaveChanges();
            }
        }
        private void cmbTags_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if(e.KeyChar == 13)
            {
                string tagName = cmbTags.Text;
                if(!checkedListBox1.Items.Contains(tagName))
                {
                    checkedListBox1.Items.Add(tagName, true);
                }
                cmbTags.Text = "";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = checkedListBox1.SelectedIndex;
            if(selected != -1)
            {
                checkedListBox1.Items.RemoveAt(selected);
            }
        }

        private void txtOnlyNumber(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Name == "txtCount")
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57 || txtCount.Text.Length >=5) && e.KeyChar !=8)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57 || txtBarcode.Text.Length >= 8) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
