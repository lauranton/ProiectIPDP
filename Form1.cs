using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaFram
{
    public partial class loginpage : Form
    {

        User model = new User();
        /*
        User model = new User();
        FileStream fs = new FileStream("../../logging.xml", FileMode.Open);
        private protected Log logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);// User model = new User();
        FileStream fs = new FileStream("../../logging.xml", FileMode.Open);
        private protected ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        */

        public loginpage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUseName.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            using(DBEntities db = new DBEntities())
            {
                var dataset = db.Users.Where(x => x.username == txtUseName.Text && x.password == txtPassword.Text).Select(x => new { x.username, x.password }).FirstOrDefault();
                if (dataset != null)
                {
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                   // logger.Info("Bravo! Inca mai stii parola :))");

                }
                else
                {
                    //Singleton s = Singleton.Instance;
                    //s.Print("Wrong Username or Password!");
                    // MessageBox.Show("Wrong Username or Password!");
                   // logger.Warn("Opaa! Da' ce am facut sefu' ?!");
                   // logger.Error("Ai gresit parola sau/si usernameul!!! Noteaza daca nu tii minte!!!");
                }
            }
           /* if ((txtUseName.Text == "Laura" || txtUseName.Text == "Irina") && txtPassword.Text == "plswork")
            {
                Administrator am = new Administrator();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaImageButton1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
