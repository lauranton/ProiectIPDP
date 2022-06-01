using log4net;
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

        
        User us = new User();

        /* User model = new User();
         FileStream fs = new FileStream("../../logging.xml", FileMode.Open);
         private protected Log logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);// User model = new User();
         FileStream fs = new FileStream("../../logging.xml", FileMode.Open);
         private protected ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); */

        User model = new User();
       // FileStream fs = new FileStream("../../loGGing.xml", FileMode.Open);
        private protected ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


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
                    logger.Info("Super! Te-ai autentificat cu succes!))");

                }
                else
                {
                    Singleton s = Singleton.Instance;
                    s.Print("Wrong Username or Password!");
                    MessageBox.Show("Wrong Username or Password!");
                    logger.Warn("Atentie! Unul sau mai multe caractere sunt gresite!");
                    logger.Error("Ne pare rau! Parola sau numele de utilizator au fost introduse gresit!");
                }
            }
         
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
