using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsShopManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            txtboxPassword.UseSystemPasswordChar = true;
        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {          

        }

        private void txtboxUsername_Enter(object sender, EventArgs e)
        {
            if (this.txtboxUsername.Text == "Username")
            {

                this.txtboxUsername.Text = "";
                this.txtboxUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtboxUsername_Leave(object sender, EventArgs e)
        {
            if (this.txtboxUsername.Text == "")
            {

                this.txtboxUsername.Text = "Username";
                this.txtboxUsername.ForeColor = System.Drawing.SystemColors.GrayText;

            }
        }

        private void txtboxPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtboxPassword.Text == "Password")
            {

                this.txtboxPassword.Text = "";
                this.txtboxPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtboxPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtboxPassword.Text == "")
            {

                this.txtboxPassword.Text = "Password";
                this.txtboxPassword.ForeColor = System.Drawing.SystemColors.GrayText;

            }
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
