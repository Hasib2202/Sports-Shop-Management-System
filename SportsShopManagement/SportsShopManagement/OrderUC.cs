using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SportsShopManagement
{
    public partial class OrderUC : UserControl
    {
        public OrderUC(string u , string p)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            Username = u;
            Password = p;
        }

        private string Username { get; set; }
        private string Password { get; set; }

        private DataAccess Da { get; set; }

        private void PopulateGridView(string sql = "select * from ProductList;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvPeoduct.AutoGenerateColumns = false;
            this.dgvPeoduct.DataSource = ds.Tables[0];
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
                var sql = "select * from ProductList where P_ID like '%" + this.txtSearchProduct.Text + "%' ;";
                this.PopulateGridView(sql);
            }
        }

        private void dgvPeoduct_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvPeoduct.SelectedRows.Count <= 0) return;
            var pID = dgvPeoduct.CurrentRow.Cells["P_ID"].Value.ToString();
            this.AddToCart(pID);
        }

        private void AddToCart(string pID)
        {
            try
            {
                int i = 0;
                while (i < dgvCart.Rows.Count)
                {
                    string val = dgvCart.Rows[i].Cells["P_ID_Cart"].Value.ToString();
                    if (val.Equals(pID))
                    {
                        MessageBox.Show("Product exists in the cart");
                        return;
                    }
                    i++;
                }


                string sql = "select P_ID, Category, Stock, Product_name, Brand, Price from ProductList where P_ID = '" + pID + "';";
                var dt = Da.ExecuteQueryTable(sql);
                this.dgvCart.AutoGenerateColumns = false;
                string[] row = new string[] { dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), "1" };
                this.dgvCart.Rows.Add(row);
                this.CalculateCost();

            }

            catch (Exception e)
            {
                return;
            }
        }


        private double CalculateCost(int q = 1)
        {

            int index = 0;
            double total = 0.0;


            while (index < this.dgvCart.RowCount)
            {
                var price = Double.Parse(this.dgvCart.Rows[index].Cells["Price_Cart"].Value.ToString());
                var quantity = Double.Parse(this.dgvCart.Rows[index].Cells["Quantity_Cart"].Value.ToString());
                total += price * quantity;
                index++;
            }

            this.lblCart.Text = total.ToString() + "Taka";
            return total;
        }

        private void btnCartClear_Click(object sender, EventArgs e)
        {
            this.dgvCart.DataSource = null;
            this.dgvCart.Rows.Clear();
            this.CalculateCost();
        }

        private void dgvPeoduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentQuantity = 0;
            if (this.dgvCart.Columns[e.ColumnIndex].Name.Equals("Plus"))
            {
                currentQuantity = Int32.Parse(this.dgvCart.CurrentRow.Cells["Quantity_Cart"].Value.ToString());
                var totalQuantity = Int32.Parse(this.dgvCart.CurrentRow.Cells["Total_Quantity_Cart"].Value.ToString());
                if (totalQuantity == currentQuantity)
                {
                    MessageBox.Show("Out of stock");
                    return;
                }
                this.dgvCart.CurrentRow.Cells["Quantity_Cart"].Value = (++currentQuantity).ToString();
                this.CalculateCost(currentQuantity);
            }
            else if (this.dgvCart.Columns[e.ColumnIndex].Name.Equals("Minus"))
            {
                currentQuantity = Int32.Parse(this.dgvCart.CurrentRow.Cells["Quantity_Cart"].Value.ToString());
                if (currentQuantity == 1)
                {
                    return;
                }
                this.dgvCart.CurrentRow.Cells["Quantity_Cart"].Value = (--currentQuantity).ToString();
                this.CalculateCost(currentQuantity);
            }
            else if (this.dgvCart.Columns[e.ColumnIndex].Name.Equals("Delete"))
            {
                if (this.dgvCart.SelectedRows.Count <= 0) return;
                this.dgvCart.Rows.RemoveAt(e.RowIndex);
                this.CalculateCost();
            }

        }

        private void btnCartConfirm_Click(object sender, EventArgs e)
        {
            if (CalculateCost() == 0) return;

            string[] a = lblCart.Text.Split('T');
            double amountPaid = Convert.ToDouble(a[0]);



            CashMemo cashMemo = new CashMemo(Username, Password, amountPaid);
            cashMemo.Show();
            int index = 0;
            while (index < this.dgvCart.Rows.Count)
            {
                var sql = $@"update ProductList set Stock = Stock- {this.dgvCart.Rows[index].Cells["Quantity_Cart"].Value.ToString()} where P_ID = '{this.dgvCart.Rows[index].Cells["P_ID_Cart"].Value.ToString()}';";
                Da.ExecuteDMLQuery(sql);
                index++;
            }


            this.dgvCart.DataSource = null;
            this.dgvCart.Rows.Clear();
            this.CalculateCost();
            this.PopulateGridView();
        }

        private void lblCart_Click(object sender, EventArgs e)
        {

        }
    }
}
