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
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loginpage login = new loginpage();
            login.Show();
            this.Hide();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
            this.Hide();
        }

        private void AddNewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addcust = new AddCustomer();
            addcust.Show();
            this.Hide();

        }

        private void addNewMedicine_Click(object sender, EventArgs e)
        {
            AddMedicine addmed = new AddMedicine();
            addmed.Show();
            this.Hide();
        }
    }
}
