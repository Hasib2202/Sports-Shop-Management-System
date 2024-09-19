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
    public partial class CashMemo : Form
    {
        public CashMemo(string u , string p , double a)
        {
            InitializeComponent();
            Ammount = a;
            Username = u;   
            Password = p;
            Da = new DataAccess(); 
            this.txtDate.Text = DateTime.Now.ToString("D");
            this.txtAmmount.Text = a.ToString() + " Taka";
        }

        private string AutoId()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from TransactionHistory order by T_ID Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");

        }

        public string CustomerName { get; set; }

        private DataAccess Da { get; set; }

        private double Ammount { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private void btnCartConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCusName.Text) == true)
            {
                lblNameError.Visible = true;
                return;
            }
            CustomerName = this.txtCusName.Text;
            lblNameError.Visible = false;

            string transactionID = "T-" + AutoId();
            var sql = @"select U_ID from UserInfo where Username = '" + Username + "' and Password = '" + Password + "';";
            var ds = Da.ExecuteQuery(sql);
            string uID = ds.Tables[0].Rows[0][0].ToString();
            string purchaseDate = DateTime.Now.ToString("d");
            var query = @"insert into TransactionHistory values('" + transactionID + "', '" + uID + "', '" + Username + "', '" + CustomerName + "', " + Ammount + ", '" + purchaseDate + "');";

            ds = Da.ExecuteQuery(query);

            MessageBox.Show("Order Confirmed");
            this.Close();
        }

        private void txtCusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);

        }
    }
}
