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
    public partial class AddCarPage : Form
    {

        ManagePage _connectedManagePage;

        public AddCarPage(ManagePage m)
        {
            InitializeComponent();
            _connectedManagePage = m;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConfirmRequestPage crp = new ConfirmRequestPage(_connectedManagePage);
            crp.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _connectedManagePage.getHomepage().Visible = true;

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _connectedManagePage.getHomepage().Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RemoveItemPage rip = new RemoveItemPage(_connectedManagePage);
            rip.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChangeItemPage cip = new ChangeItemPage(_connectedManagePage);
            cip.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String id = textBox2.Text;
            String model = textBox3.Text;
            String loc = textBox6.Text;
            String price = textBox5.Text;
            String seating = textBox4.Text;
            String avil = textBox7.Text;

            if(name.Equals("") || id.Equals("") || model.Equals("") || loc.Equals("")
                || price.Equals("") || seating.Equals("") || avil.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Please fill out all text boxes before submitting.");
            } else
            {
                Manage.addCar(id, model, loc, price, seating, avil, name);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
