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
    public partial class RemoveProductUC : UserControl
    {
        public RemoveProductUC()
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

        private void dgvPeoduct_DoubleClick(object sender, EventArgs e)
        {
 
        }

        private void dgvPeoduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPeoduct.Columns[e.ColumnIndex].Name.Equals("Delete"))
            {
                DialogResult result = MessageBox.Show("Delete Product?", "Confirmation!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var sql = "DELETE FROM ProductList WHERE P_ID = '" + this.dgvPeoduct.CurrentRow.Cells["P_ID"].Value.ToString() + "';";
                    this.Da.ExecuteDMLQuery(sql);
                    MessageBox.Show("Product Deleted");
                    this.PopulateGridView();
                }
                else return;
                ClearAll();

            }
        }

        private void ClearAll()
        {
            this.PopulateGridView();
            this.txtSearchProduct.Text = "Enter Product ID";
            this.txtSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138))))); ;

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
    }
}
