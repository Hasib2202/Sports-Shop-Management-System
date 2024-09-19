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
    public partial class EditProductUC : UserControl
    {
        public EditProductUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private DataAccess Da { get; set; }

        private void PopulateGridView(string sql = "select * from ProductList;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvPeoduct.AutoGenerateColumns = false;
            this.dgvPeoduct.DataSource = ds.Tables[0];
        }

        private void TurnOffReadOnly()
        {
            txtEnterPrice.ReadOnly = false;
            txtEnterStock.ReadOnly = false;          
        }

        private void TurnOnReadOnly()
        {
            txtEnterPrice.ReadOnly = true;
            txtEnterStock.ReadOnly = true;
        }

        private void ClearAll()
        {
            txtEnterPrice.Clear();
            txtEnterStock.Clear();
            this.txtSearchProduct.Text = "Enter Product ID";
            this.txtSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));;
            this.PopulateGridView();
        }

        private void TurnOffVisibility()
        {
            lblPriceError.Visible = false;
            lblStockError.Visible = false;
        }

        private void btnClearEditProduct_Click(object sender, EventArgs e)
        {
            ClearAll();
            TurnOnReadOnly();
            TurnOffVisibility();
        }

        private void txtSearchProduct_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchProduct.Text == "Enter Product ID")
            {

                this.txtSearchProduct.Text = "";
                this.txtSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138))))); ;

            }
        }

        private void txtSearchProduct_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchProduct.Text == "")
            {

                this.txtSearchProduct.Text = "Enter Product ID";
                this.txtSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138))))); ;
                this.PopulateGridView();
            }
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text != "Enter Product ID" || string.IsNullOrEmpty(txtSearchProduct.Text) == false || string.IsNullOrWhiteSpace(txtSearchProduct.Text) == false)
            {
                var sql = "select * from ProductList where P_ID like '%" + this.txtSearchProduct.Text + "%';";
                this.PopulateGridView(sql);
            }


        }

        private void dgvPeoduct_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvPeoduct.SelectedRows.Count == 0) { return; }
            this.TurnOffReadOnly();
            this.txtEnterPrice.Text = this.dgvPeoduct.CurrentRow.Cells["Price"].Value.ToString();
            this.txtEnterStock.Text = this.dgvPeoduct.CurrentRow.Cells["Stock"].Value.ToString();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
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

            if (lblPriceError.Visible == true || lblStockError.Visible == true)
            {
                return;
            }

            var query = "select * from ProductList where P_ID = '" + this.dgvPeoduct.CurrentRow.Cells["P_ID"].Value.ToString() + "';";
            var ds = this.Da.ExecuteQuery(query);


            if (ds.Tables[0].Rows.Count == 1)
            {
                var sql = @"update ProductList
                                set Price = '" + this.txtEnterPrice.Text + @"',
                                Stock = '" + this.txtEnterStock.Text + @"'
                                where P_ID = '" + this.dgvPeoduct.CurrentRow.Cells["P_ID"].Value.ToString() + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data updated properly");
                else
                    MessageBox.Show("Data upgradation failed");
            }

            this.PopulateGridView();
            this.ClearAll();
            this.TurnOnReadOnly();

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
