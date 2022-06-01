using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaFram
{
    public partial class AddMedicine : Form
    {
        MedicineCRUD addmed = new MedicineCRUD();
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void btnCancelM_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtMediName.Text = txtExpireDate.Text = txtManufacturingDate.Text = txtPricePerUnit.Text = txtQuantity.Text = " ";
            btnAddM.Text = "Save";
            btnDeleteM.Enabled = false;
            addmed.MedicineID = 0;
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            addmed.MedicineName = txtMediName.Text.Trim();
            addmed.ManufacturingDate = txtManufacturingDate.Text.Trim();
            addmed.ExpireDate = txtExpireDate.Text.Trim();
            addmed.Quantity = txtQuantity.Text.Trim();
            addmed.PricePerUnit = txtPricePerUnit.Text.Trim();
            using (DBEntities db = new DBEntities())
            {
                if (addmed.MedicineID == 0) //Insert
                    db.MedicineCRUDs.Add(addmed);
                else//Update
                    db.Entry(addmed).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView1();
            MessageBox.Show("Submitted Successfully!");
        }

        void PopulateDataGridView1()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.MedicineCRUDs.ToList<MedicineCRUD>();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                addmed.MedicineID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MedicineID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    addmed = db.MedicineCRUDs.Where(x => x.MedicineID == addmed.MedicineID).FirstOrDefault();
                    txtMediName.Text = addmed.MedicineName;
                    txtManufacturingDate.Text = addmed.ManufacturingDate;
                    txtExpireDate.Text = addmed.ExpireDate;
                    txtQuantity.Text = addmed.Quantity;
                    txtPricePerUnit.Text = addmed.PricePerUnit;
                }
                btnAddM.Text = "Update";
                btnDeleteM.Enabled = true;
            }
        }

        private void btnDeleteM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry1 = db.Entry(addmed);
                    if (entry1.State == System.Data.Entity.EntityState.Detached)
                        db.MedicineCRUDs.Attach(addmed);
                    db.MedicineCRUDs.Remove(addmed);
                    db.SaveChanges();
                    PopulateDataGridView1();
                    Clear();
                    MessageBox.Show("Deleted Successfully!");

                }
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Pharmacy pharm = new Pharmacy();
            pharm.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
