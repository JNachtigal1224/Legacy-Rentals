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
    public partial class CreateAccountPage : Form
    {
        Home _connectedHomepage;

        public CreateAccountPage(Home h)
        {
            InitializeComponent();
            _connectedHomepage = h;
        }

        private void CreateAccountPage_Load(object sender, EventArgs e)
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
            String password = textBox2.Text;
            String firstName = textBox3.Text;
            String lastName = textBox4.Text;
            if (username.Equals("") || password.Equals("") || firstName.Equals("") || lastName.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Please fill out all text boxes before creating the acccount.");

            } else {Account.createAccount(username, firstName, lastName, password);}

            this.Visible = false;
            _connectedHomepage.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
