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
    public partial class AdminHome : Form
    {
        public AdminHome(string u)
        {
            InitializeComponent();
            this.lblUserNameAdmin.Text = u; 
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }

        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            pnlAdminDisplay.Controls.Clear();
            pnlAdminDisplay.Controls.Add(userControl);
            userControl.BringToFront();

        }



        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new ProductUC());
        }

        private void btnMessageAdmin_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new MessageUC());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new UsersUC());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new SalesAdminUC());
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
