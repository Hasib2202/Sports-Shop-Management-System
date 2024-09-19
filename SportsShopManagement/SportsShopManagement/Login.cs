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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            txtboxPassword.UseSystemPasswordChar = true;
            txtboxPassword.UseSystemPasswordChar = true;
            btnInVisibl.Visible = true;
            btnVisible.Visible = true;
            btnInVisibl.BringToFront();
        }

        private DataAccess Da { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where Username = '" + txtboxUsername.Text + "' and Password = '" + txtboxPassword.Text + "';";
            var ds = this.Da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {

                if (ds.Tables[0].Rows[0][6].ToString() == "Admin")
                {

                    new AdminHome(this.txtboxUsername.Text).Show();
                    this.Hide();

                }
                else if (ds.Tables[0].Rows[0][6].ToString() == "Seller")
                {

                    new SellerHome(this.txtboxUsername.Text , this.txtboxPassword.Text).Show();
                    this.Hide();

                }

            }
            else if (ds.Tables[0].Rows.Count == 0)
            {

                this.lblerror.Visible = true;

            }
        }

        private void btnInVisibl_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.UseSystemPasswordChar == true)
            {
                txtboxPassword.UseSystemPasswordChar = false;
                btnVisible.BringToFront();
            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.UseSystemPasswordChar == false)
            {
                txtboxPassword.UseSystemPasswordChar = true;
                btnInVisibl.BringToFront();
            }
        }
    }
    
}
