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
    public partial class UsersUC : UserControl
    {
        public UsersUC()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsersUC_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new AddNewUserUC());
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new EditUserUC());
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new RemoveUserUC());
        }

        private void btnRemoveUser_Click_1(object sender, EventArgs e)
        {
            this.AddUserControl(new RemoveUserUC());
        }
    }
}
