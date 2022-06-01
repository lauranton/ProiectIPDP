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
    public partial class Administrator : Form
    {
      
        public Administrator()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            loginpage fm = new loginpage();
            fm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewUserbtn_Click(object sender, EventArgs e)
        {
            
            AddNewUser addnewuser = new AddNewUser();
            addnewuser.Show();
            this.Hide();

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            loginpage loginpg = new loginpage();
            loginpg.Show();
            this.Hide();
            
        }

        private void PharmBtn_Click(object sender, EventArgs e)
        {
            Pharmacy pharm = new Pharmacy();
            pharm.Show();
            this.Hide();
        }
    }
}
