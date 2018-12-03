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
        public String _username;
        public Boolean isSignedIn = false;
        public Point loc;
        private Search search;

        public Home()
        {
            InitializeComponent();
            loc = signButton.Location;
            this.CenterToScreen();
        }

        public void manageShow(Boolean vis)
        {
            if (vis)
            {
                manageButton.Visible = true;
            }
            else
            {
                manageButton.Visible = false;
            }
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

            signButton.Text = "SIGN OUT";

            signButton.Location = createButton.Location;

            createButton.Visible = false;

        }

        public void setSignOut()
        {
            _username = null;
            isSignedIn = false;
            label5.Text = "";

            Program.localAccount = null;

            manageButton.Visible = false;

            signButton.Text = "SIGN IN";

            signButton.Location = loc;

            createButton.Visible = true;

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

            if (search == null)
            {
                search= new Search(this);
            }

            if (isSignedIn)
            {
                search.createShow(false);
            }
            else
            {
                search.createShow(true);
            }
            search.Visible = true;
            this.Visible = false;

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
            if(signButton.Text=="SIGN OUT")
            {
                this.setSignOut();
            }
            else
            {
                this.Visible = false;
                SignInPage sip = new SignInPage(this);
                sip.Visible = true;
            }
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
