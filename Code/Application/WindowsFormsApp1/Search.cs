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
        private SearchResults s;

        public Search(Home h)
        {
            InitializeComponent();
            this.CenterToScreen();
            _homepage = h;
            this.refreshContent();
        }

        public void refreshContent()
        {
            if (_homepage.getSignedIn())
            {
                rentingAvailable = true;
                label5.Text = ("Hello, " + _homepage.getUsername());
                signInButton.Text = "SIGN OUT";
            }
            else
            {
                label5.Text = "Hello, Guest";
                signInButton.Text = "SIGN IN";
            }

            comboBox1.DataSource = Car.getModels();
            comboBox2.DataSource = Car.getLocations();
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

            String loc = comboBox2.Text;
            String model = comboBox1.Text;
            int maxPrice = trackBar1.Value * 1000;
            int seats = trackBar2.Value;

            List<List<String>> l = new List<List<String>> { };
            l = Car.getCars(loc, model, seats, maxPrice);
            if (s == null)
            {
                s = new SearchResults(_homepage, this, l);
            }
            s.refreshContent(l);
            s.Visible = true;
            this.Visible = false;
            
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
            label5.Text = "Guest";

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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = "$"+(trackBar1.Value * 100).ToString();
        }
    }
}
