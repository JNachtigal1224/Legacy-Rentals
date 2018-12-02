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
    public partial class Home : Form
    {
        String _username;
        Boolean isSignedIn = false;

        public Home()
        {
            InitializeComponent();
        }

        public void manageShow(Boolean visible)
        {
            manageButton.Visible = visible;
        }

        public Boolean getSignedIn()
        {
            return isSignedIn;
        }

        public String getUsername()
        {
            return _username;
        }

        public void setSignIn(String username)
        {
            _username = username;
            isSignedIn = true;
            label5.Text = "Hello, " + username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Visible = false;
            Search s = new Search(this);
            s.Visible = true;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Visible = false;
            ManagePage m = new ManagePage(this);
            m.Visible = true;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            SignInPage sip = new SignInPage(this);
            sip.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateAccountPage cap = new CreateAccountPage(this);
            cap.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
