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
    public partial class SalesAdminUC : UserControl
    {
        public SalesAdminUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private DataAccess Da { get; set; }

        private void PopulateGridView(string sql = "select * from TransactionHistory;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvTransactionHistory.AutoGenerateColumns = false;
            this.dgvTransactionHistory.DataSource = ds.Tables[0];
        }

        private void txtSearchTransaction_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchTransaction.Text == "Enter Transaction ID")
            {

                this.txtSearchTransaction.Text = "";
                this.txtSearchTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138))))); ;

            }
        }

        private void txtSearchTransaction_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchTransaction.Text == "")
            {

                this.txtSearchTransaction.Text = "Enter Transaction ID";
                this.txtSearchTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138))))); ;
                this.PopulateGridView();
            }
        }

        private void txtSearchTransaction_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchTransaction.Text != "Enter Transaction ID" || string.IsNullOrEmpty(txtSearchTransaction.Text) == false || string.IsNullOrWhiteSpace(txtSearchTransaction.Text) == false)
            {
                var sql = "select * from TransactionHistory where T_ID like '%" + this.txtSearchTransaction.Text + "%' ;";
                this.PopulateGridView(sql);
            }
        }
    }
}
