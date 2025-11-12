using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableValleyMunicipalApp.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnAddViewIssues_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStayInformed_Click(object sender, EventArgs e)
        {
            StayInformed stayInformed = new StayInformed();
            stayInformed.Show();
            this.Hide();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
