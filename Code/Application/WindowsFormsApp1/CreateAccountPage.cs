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
    }
}
