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
    public partial class ChangeItemPage : Form
    {
        ManagePage _connectedManagePage;

        public ChangeItemPage(ManagePage m)
        {
            InitializeComponent();
            _connectedManagePage = m;
        }

        private void ChangeItemPage_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RemoveItemPage rip = new RemoveItemPage(_connectedManagePage);
            rip.Visible = true;
        }
    }
}
