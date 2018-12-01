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
    public partial class RemoveItemPage : Form
    {
        ManagePage _connectedManagePage;

        public RemoveItemPage(ManagePage m)
        {
            InitializeComponent();
            _connectedManagePage = m;
        }
        private void RemoveItemPage_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConfirmRequestPage crp = new ConfirmRequestPage(_connectedManagePage);
            crp.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddCarPage acp = new AddCarPage(_connectedManagePage);
            acp.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChangeItemPage cip = new ChangeItemPage(_connectedManagePage);
            cip.Visible = true;
        }
    }
}
