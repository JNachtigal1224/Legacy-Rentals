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
        Boolean rentingAvailable = false;

        public Search(Home h)
        {
            InitializeComponent();
            this.CenterToScreen();
            _homepage = h;
            if (h.getSignedIn())
            {
                rentingAvailable = true;
                label5.Text = ("Hello, " + h.getUsername());
            }

            if (Program.localAccount == null)
            {
                signInButton.Text = "SIGN IN";
            }
            else
            {
                signInButton.Text = "SIGN OUT";
            }


             List<string> models = Car.getModels();
             comboBox1.DataSource = models;
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
            _homepage.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String loc = textBox1.Text;
            String model = comboBox1.Text;
            int maxPrice = trackBar1.Value;
            int seats = trackBar2.Value;

            this.Visible = false;
            List<List<String>> l = new List<List<String>> { };
            l = Car.getCars(loc, model, seats, maxPrice);
            SearchResults s = new SearchResults(_homepage, this, l);
            s.Visible = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        public void createShow(Boolean vis)
        {
            if (vis)
            {
                createButton.Visible = true;
            }
            else
            {
                createButton.Visible = false;
            }
        }

        public void setSignOut()
        {
            label5.Text = "";

            _homepage.setSignOut();

            signInButton.Text = "SIGN IN";
            signInButton.Location = _homepage.loc;

            createButton.Visible = true;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (signInButton.Text == "SIGN OUT")
            {
                setSignOut();
            }
            else
            {
                this.Visible = false;
                SignInPage sip = new SignInPage(_homepage);
                sip.Visible = true;
            }

            //this.Visible = false;
            //_homepage.Visible = true;
        }

        private void manageButton_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
