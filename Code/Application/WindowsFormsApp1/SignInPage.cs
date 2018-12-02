using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LegacyRentals
{
    public partial class SignInPage : Form
    {

        Home _connectedHomepage;

        public SignInPage(Home h)
        {
            InitializeComponent();
            _connectedHomepage = h;
        }

        private void SignInPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _connectedHomepage.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            System.Windows.Forms.MessageBox.Show(username);
            String password = textBox2.Text;
            if (Account.signIn(username, password))
            {

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Your username or password is not found in the database. " +
                    "If you have not created an account yet please select CREATE ACCOUNT");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateAccountPage cap = new CreateAccountPage(_connectedHomepage);
            cap.Visible = true;
        }
    }
}
