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
    public partial class AddCustomer : Form
    {

        Customer addcustomer = new Customer();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnCancelC_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtCustName.Text = txtNrtel.Text = txtAdresa.Text = " ";
            btnAddC.Text = "Save";
            btnDeleteC.Enabled = false;
            addcustomer.CustomerID = 0;
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            addcustomer.CustomerName = txtCustName.Text.Trim();
            addcustomer.Nrtel = txtNrtel.Text.Trim();
            addcustomer.Adresa = txtAdresa.Text.Trim();

            using (DBEntities db = new DBEntities())
            {
                if (addcustomer.CustomerID == 0) //Insert
                    db.Customers.Add(addcustomer);
                else//Update
                    db.Entry(addcustomer).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView2();
            MessageBox.Show("Submitted Successfully!");
        }

        void PopulateDataGridView2()
        {
            dataGridView2.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView2.DataSource = db.Customers.ToList<Customer>();
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView2();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {
                addcustomer.CustomerID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["CustomerID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    addcustomer = db.Customers.Where(x => x.CustomerID == addcustomer.CustomerID).FirstOrDefault();
                    txtCustName.Text = addcustomer.CustomerName;
                    txtNrtel.Text = addcustomer.Nrtel;
                    txtAdresa.Text = addcustomer.Adresa;
                }
                btnAddC.Text = "Update";
                btnDeleteC.Enabled = true;
            }
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry2 = db.Entry(addcustomer);
                    if (entry2.State == System.Data.Entity.EntityState.Detached)
                        db.Customers.Attach(addcustomer);
                    db.Customers.Remove(addcustomer);
                    db.SaveChanges();
                    PopulateDataGridView2();
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
