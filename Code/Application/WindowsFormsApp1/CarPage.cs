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
    public partial class CarPage : Form
    {
        Home _homepage;
        SearchResults _connectedSearchResults;
        List<String> _carInfo;

        public CarPage(Home h, SearchResults s, List<String> ci)
        {
            InitializeComponent();
            _homepage = h;
            _connectedSearchResults = s;
            _carInfo = ci;

            if (!_homepage.getSignedIn()) {
                button1.Enabled = false;
            }

            textBox1.Text = _carInfo[6];
            textBox2.Text = _carInfo[0];
            textBox3.Text = _carInfo[1];
            textBox6.Text = _carInfo[2];
            textBox5.Text = _carInfo[3];
            textBox4.Text = _carInfo[4];
            textBox7.Text = _carInfo[5];
        }

        private void CarPage_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _connectedSearchResults.Visible = true;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _homepage.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String carId = _carInfo[0];
            String username = Program.localAccount[1];
            String requestId = carId + username;
            Manage.request(requestId, carId, username);
        }
    }
}
