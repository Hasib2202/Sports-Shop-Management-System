using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SportsShopManagement
{
    public partial class AddProductUC : UserControl
    {
        public AddProductUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        DataAccess Da { get; set; }

        private void ClearAll()
        {
            txtEnterProductName.Clear();
            TxtEnterBrand.Clear();
            txtEnterPrice.Clear();
            txtEnterStock.Clear();

            cboxProductCategory.Items.Clear();
        }

        private string AutoProductCode()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from ProductList order by P_Id Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");
        }

        private void btnClearAddProduct_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string PID = "P-" + this.AutoProductCode();
            string Name = txtEnterProductName.Text;
            string Brand = TxtEnterBrand.Text;
            string Price = txtEnterPrice.Text;
            string Stock = txtEnterStock.Text;
            string Category = "null";


            if (string.IsNullOrEmpty(txtEnterProductName.Text) == true)
            {

                lblProductNameError.Visible = true;

            }
            else
            {

                lblProductNameError.Visible = false;
            }

            if (string.IsNullOrEmpty(TxtEnterBrand.Text) == true)
            {

                lblBrandError.Visible = true;

            }
            else
            {

                lblBrandError.Visible = false;
            }


            if (string.IsNullOrEmpty(txtEnterPrice.Text) == true)
            {

                lblPriceError.Visible = true;

            }
            else
            {

                lblPriceError.Visible = false;
            }

            if (string.IsNullOrEmpty(txtEnterStock.Text) == true)
            {

                lblStockError.Visible = true;

            }
            else
            {

                lblStockError.Visible = false;
            }

            if (string.IsNullOrEmpty(cboxProductCategory.Text) == true)
            {

                lblCategoryError.Visible = true;

            }
            else
            {

                lblCategoryError.Visible = false;
            }


            if (lblCategoryError.Visible == true || lblProductNameError.Visible == true || lblBrandError.Visible == true || lblPriceError.Visible == true || lblStockError.Visible == true)
            {
                return;
            }

            if (cboxProductCategory.SelectedIndex == 0)
            {
                Category = "Badminton";
            }
            else if (cboxProductCategory.SelectedIndex == 1)
            {
                Category = "Basketball";
            }
            else if (cboxProductCategory.SelectedIndex == 2)
            {
                Category = "Cricket";
            }
            else if (cboxProductCategory.SelectedIndex == 3)
            {
                Category = "Football";
            }
            else if (cboxProductCategory.SelectedIndex == 4)
            {
                Category = "Golf";
            }
            else if (cboxProductCategory.SelectedIndex == 5)
            {
                Category = "Hockey";
            }
            else if (cboxProductCategory.SelectedIndex == 6)
            {
                Category = "Pool";
            }
            else if (cboxProductCategory.SelectedIndex == 7)
            {
                Category = "Soccer";
            }
            else if (cboxProductCategory.SelectedIndex == 8)
            {
                Category = "Tennis";
            }
            else if (cboxProductCategory.SelectedIndex == 9)
            {
                Category = "Volleyball";
            }


            string sql = "insert into ProductList values ('" + PID + "', '" + Category + "', '" + Name + "', '" + Brand + "', " + Price + ", " + Stock + ")  ;";
            var ds = this.Da.ExecuteQuery(sql);
            MessageBox.Show("New Product Added");

            ClearAll();


        }

        private void txtEnterProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtEnterPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEnterStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
