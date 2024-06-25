using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallSchool
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void frmCity_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitClient_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            lstClient.Items.Add(txtClient.Text);
            txtClient.Text = string.Empty;
            txtClient.Focus();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            lstClient.Items.RemoveAt(lstClient.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstClient.Items.Clear();
        }
    }
}
