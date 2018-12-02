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
    public partial class SignInPage : Form
    {

        Home _connectedHomepage;

        public SignInPage(Home h)
        {
            InitializeComponent();
            _connectedHomepage = h;
        }

        private void SignInPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
