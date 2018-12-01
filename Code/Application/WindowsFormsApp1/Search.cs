using LegacyRentals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Search : Form
    {

        Home _homepage;

        public Search(Home h)
        {
            InitializeComponent();
            _homepage = h;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _homepage.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SearchResults s = new SearchResults(_homepage, this);
            s.Visible = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _homepage.Visible = true;
        }

        private void manageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
