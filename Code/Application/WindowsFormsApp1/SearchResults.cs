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
    public partial class SearchResults : Form
    {

        Home _homepage;
        Search _connectedSearch;
        List<List<String>> _carResults;
        List<List<String>> indexs = new List<List<String>>{ };

        public SearchResults(Home h, Search s, List<List<String>> cr)
        {
            InitializeComponent();
            _homepage = h;
            _connectedSearch = s;
            _carResults = cr;
            listBox1.Items.Clear();
            foreach (var item in cr)
            {
                listBox1.Items.Add(item[1]+" "+item[6]);
            }
        }

        public Search getConnectedSearch()
        {
            return _connectedSearch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _homepage.Visible = true;
        }

        private void manageButton_Click(object sender, EventArgs e)
        {

        }

        public void setSignOut()
        {
            label5.Text = "Guest";

            _homepage.setSignOut();

            signInButton.Text = "SIGN IN";
            signInButton.Location = _homepage.loc;
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

        public void refreshContent(List<List<String>> cr)
        {
            if (_homepage.getSignedIn())
            {
                label5.Text = ("Hello, " + _homepage.getUsername());
                signInButton.Text = "SIGN OUT";
            }
            else
            {
                label5.Text = "Hello, Guest";
                signInButton.Text = "SIGN IN";
            }

            listBox1.Items.Clear();
            _carResults = cr;
            foreach (var item in cr)
            {
                listBox1.Items.Add(item[1] + " " + item[6]);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _connectedSearch.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarPage c = new CarPage(_homepage, this, _carResults[listBox1.SelectedIndex]);
            this.Visible = false;
            c.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
