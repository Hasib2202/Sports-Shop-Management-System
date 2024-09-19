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
    public partial class RemoveUserUC : UserControl
    {
        public RemoveUserUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private DataAccess Da { get; set; }

        private void PopulateGridView(string sql = "select * from UserInfo where Role = 'Seller';")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = ds.Tables[0];
        }


        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name.Equals("Delete"))
            {
                DialogResult result = MessageBox.Show("Delete User?", "Confirmation!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var sql = "DELETE FROM UserInfo WHERE U_ID = '" + this.dgvUser.CurrentRow.Cells["U_ID"].Value.ToString() + "';";
                    this.Da.ExecuteDMLQuery(sql);
                    MessageBox.Show("User Deleted");
                    this.PopulateGridView();
                }
                else return;
                ClearAll();

            }
        }

        private void txtSearchUser_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchUser.Text == "Enter User ID")
            {

                this.txtSearchUser.Text = "";
                this.txtSearchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138))))); ;

            }
        }

        private void txtSearchUser_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchUser.Text == "")
            {

                this.txtSearchUser.Text = "Enter User ID";
                this.txtSearchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138))))); ;
                this.PopulateGridView();
            }
        }

        private void ClearAll()
        {
            this.PopulateGridView();
            this.txtSearchUser.Text = "Enter User ID";
            this.txtSearchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138))))); ;

        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchUser.Text != "Enter User ID" || string.IsNullOrEmpty(txtSearchUser.Text) == false || string.IsNullOrWhiteSpace(txtSearchUser.Text) == false)
            {
                var sql = "select * from UserInfo where U_ID like '%" + this.txtSearchUser.Text + "%' and Role = 'Seller';";
                this.PopulateGridView(sql);
            }
        }
    }
}
