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
    public partial class ConfirmRequestPage : Form
    {
        ManagePage _connectedManagePage;

        public ConfirmRequestPage(ManagePage m)
        {
            InitializeComponent();
            _connectedManagePage = m;
        }

        private void ConfrimRequestPage_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddCarPage acp = new AddCarPage(_connectedManagePage);
            acp.Visible = true;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String requestId = textBox1.Text;
            Manage.removeRequest(requestId);
        }
    }
}
