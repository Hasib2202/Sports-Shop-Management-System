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
    public partial class ProductUC : UserControl
    {
        public ProductUC()
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new AddProductUC());
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new EditProductUC());
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new RemoveProductUC());
        }
    }
}
