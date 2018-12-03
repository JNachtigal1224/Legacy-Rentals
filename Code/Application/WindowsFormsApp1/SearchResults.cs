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

        public SearchResults(Home h, Search s, List<List<String>> cr)
        {
            InitializeComponent();
            _homepage = h;
            _connectedSearch = s;
            _carResults = cr;
            foreach (var item in cr)
            {
                listBox1.Items.Add(item[1]+" "+item[6]);
            }
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

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _homepage.Visible = true;
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
           List<String> test = new List<String> { };
           test = listBox1.SelectedItem as List<String>;
            //System.Windows.Forms.MessageBox.Show(test[0]);
            CarPage c = new CarPage(_homepage, this, test);
            this.Visible = false;
            c.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
