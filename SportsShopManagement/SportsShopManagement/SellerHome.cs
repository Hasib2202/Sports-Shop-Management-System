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
    public partial class SellerHome : Form
    {
        public SellerHome(string u , string p)
        {
            InitializeComponent();
            this.lblUserNameSeller.Text = u;
            Username = u;
            Password = p;
        }

        private string Username { get; set; }
        private string Password { get; set; }

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
            pnlSellerDisplay.Controls.Clear();
            pnlSellerDisplay.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void SellerHome_Load(object sender, EventArgs e)
        {

        }

        private void btnLogoutSeller_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnMessageSeller_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new SellerMessageUC());
        }

        private void btnOrderSeller_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new OrderUC(Username,Password));
        }
    }
}
