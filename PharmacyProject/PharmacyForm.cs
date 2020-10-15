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
    public partial class PharmacyForm : Form
    {
        PharmacyEntities db = new PharmacyEntities();

        public PharmacyForm()
        {
            InitializeComponent();
        }

        public void FillDataGridMedicine()
        {
            dtgMainForm.DataSource = db.Medicines.Select(md => new
            {
                Medicine_Name = md.Name,
                md.Barcode,
                md.Quantity,
                md.Price,
                IsReceipt = md.Withreceipt ? "Reseptli" : "Reseptsiz",
                md.ProductionDate,
                md.ExperienceDate
            }).ToList();
            for (var i = 0; i < dtgMainForm.Rows.Count; i++)
            {
                DateTime dtEx = (DateTime)dtgMainForm.Rows[i].Cells[dtgMainForm.Columns.Count - 1].Value;
                int quantMed = Convert.ToInt32(dtgMainForm.Rows[i].Cells[2].Value);
                if (dtEx < DateTime.Now || quantMed <=0)
                {
                    dtgMainForm.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                    dtgMainForm.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }

        }
        public void MedicineComboFill()
        {
            cmbByMed.Items.AddRange(db.Medicines.Select(md => md.Name).ToArray());
        }

        public void TagsComboFill()
        {
            cmbByTags.Items.AddRange(db.Tags.Select(md => md.Name).ToArray());
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicineForm medFrm = new AddMedicineForm();
            medFrm.ShowDialog();
        }

        private void PharmacyForm_Load(object sender, EventArgs e)
        {
            MedicineComboFill();
            TagsComboFill();
            FillDataGridMedicine();
        }

        public void AddCheckedListFill()
        {
            string tagName = txtmedName.Text + ", "+ numCount.Value;
            Medicine selMed = db.Medicines.FirstOrDefault(m => m.Name == txtmedName.Text);
            if (!chkList.Items.Contains(tagName) && selMed.Quantity >=0
                && selMed.ExperienceDate > DateTime.Now)
            {              
                chkList.Items.Add(tagName, true);
            }
        }
        private void dtgMainForm_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            medPanel.Visible = true;
            string medName = dtgMainForm.Rows[e.RowIndex].Cells[0].Value.ToString();
            Medicine selectedMed = db.Medicines.FirstOrDefault(m => m.Name == medName);
            numCount.Maximum = selectedMed.Quantity;
            txtmedName.Text = medName;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            AddCheckedListFill();
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            string buyMedText = "";
            decimal totalPrice = 0;
            for (int i = chkList.Items.Count - 1; i >= 0; i--)
            {
                string buyMedName = chkList.Items[i].ToString();
                int medCount = Convert.ToInt32(buyMedName.Substring(buyMedName.LastIndexOf(",")+1));
                string medName = buyMedName.Substring(0, buyMedName.LastIndexOf(","));
               Medicine selectedMed = db.Medicines.First(m => m.Name == medName);
                db.Orders.Add( new Order()
                {
                    WorkerID = 1,
                    Amount = medCount,
                    MedicineID = selectedMed.Id,
                    PurchaseDate = DateTime.Now,
                });
                db.SaveChanges();
                selectedMed.Quantity -= medCount;
                db.SaveChanges();
                buyMedText += string.Format($"{medName} count: {medCount}, price: {selectedMed.Price} Azn\n");
                totalPrice += selectedMed.Price * medCount;
            }
            MessageBox.Show(buyMedText + $"\n Total price: {totalPrice}\nBuy succesfully","BUY",MessageBoxButtons.OK,MessageBoxIcon.Information);
            FillDataGridMedicine();
        }
    }
}
