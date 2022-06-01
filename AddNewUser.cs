using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaFram
{
    public partial class AddNewUser : Form
    {
        User newuser = new User();

        public AddNewUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void HireDate_Click(object sender, EventArgs e)
        {

        }

        private void newUserUsername_Click(object sender, EventArgs e)
        {

        }

        private void newUserpassword_Click(object sender, EventArgs e)
        {

        }

        private void NewUserCancel_Click(object sender, EventArgs e)
        {
            Clear();

        }

        void Clear()
        {
            txtnewuseName.Text = txtHireDate.Text = txtNewUsername.Text = txtnewuserPassword.Text = "";
            btnAddNewUser.Text = "Save";
            NewUserDelete.Enabled = false;
            newuser.userID = 0;

        }

        

        private void NewUserDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esti sigur ca vrei sa stergi?","EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using(DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(newuser);
                    if (entry.State == EntityState.Detached)
                        db.Users.Attach(newuser);
                    db.Users.Remove(newuser);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Gata, e sters");
                }
        }


        void PopulateDataGridView()
        {
            dgvUser.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgvUser.DataSource = db.Users.ToList<User>();
            }
        }
        

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewUserupdate_Click(object sender, EventArgs e)
        {
            newuser.Name = txtnewuseName.Text.Trim();
            newuser.username = txtNewUsername.Text.Trim();
            newuser.password = txtnewuserPassword.Text.Trim();
            newuser.hireDate = txtHireDate.Text.Trim();

            using (DBEntities db = new DBEntities())
            {
                db.Entry(newuser).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Client Successfully Updated");
            PopulateDataGridView();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            newuser.Name = txtnewuseName.Text.Trim();
            newuser.username = txtNewUsername.Text.Trim();
            newuser.password = txtnewuserPassword.Text.Trim();
            newuser.hireDate = txtHireDate.Text.Trim();
            using (DBEntities db = new DBEntities())
            {
                db.Users.Add(newuser);
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow.Index != -1)
            {
                newuser.userID = Convert.ToInt32(dgvUser.CurrentRow.Cells["userID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    newuser = db.Users.Where(x => x.userID == newuser.userID).FirstOrDefault();
                    txtnewuseName.Text = newuser.Name;
                    txtHireDate.Text = newuser.hireDate;
                    txtNewUsername.Text = newuser.username;
                    txtnewuserPassword.Text = newuser.password;
                }

                btnAddNewUser.Text = "Add";
                NewUserDelete.Enabled = true;
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
           
            Administrator admin = new Administrator();
            admin.Show();
            this.Hide();
        }
    }
}
