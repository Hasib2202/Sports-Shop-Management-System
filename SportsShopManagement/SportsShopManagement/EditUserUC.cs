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
    public partial class EditUserUC : UserControl
    {
        public EditUserUC()
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

        private void TurnOffReadOnly()
        {
            txtEntrFullname.ReadOnly = false;
            txtEntePass.ReadOnly = false;
            txtEnterPhoneNmbr.ReadOnly = false;
            txtEntrSalary.ReadOnly = false;
            txtEntrUsername.ReadOnly = false;
        }

        private void TurnOnReadOnly()
        {
            txtEntrFullname.ReadOnly = true;
            txtEntePass.ReadOnly = true;
            txtEnterPhoneNmbr.ReadOnly = true;
            txtEntrSalary.ReadOnly = true;
            txtEntrUsername.ReadOnly = true;
        }

        private void ClearAll()
        {
            txtEntrFullname.Clear();
            txtEntePass.Clear();
            txtEnterPhoneNmbr.Clear();
            txtEntrSalary.Clear();
            txtEntrUsername.Clear();
            txtSearchUser.Clear();
            this.PopulateGridView();
            this.txtSearchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138))))); ;

        }

        private void TurnOffVisibility()
        {
            lblFullnameError.Visible = false;
            lblPasswordError.Visible = false;
            lblPhoneNmbrError.Visible = false;
            lblSalaryError.Visible = false;
            lblUsernameError.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            TurnOnReadOnly();
            TurnOffVisibility();
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

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchUser.Text != "Enter User ID" || string.IsNullOrEmpty(txtSearchUser.Text) == false || string.IsNullOrWhiteSpace(txtSearchUser.Text) == false) {
                var sql = "select * from UserInfo where U_ID like '%" + this.txtSearchUser.Text + "%' and Role = 'Seller';";
                this.PopulateGridView(sql);
            }
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvUser.SelectedRows.Count == 0) { return; }
            this.TurnOffReadOnly();
            this.txtEntrFullname.Text = this.dgvUser.CurrentRow.Cells["Full_Name"].Value.ToString();
            this.txtEntrUsername.Text = this.dgvUser.CurrentRow.Cells["Username"].Value.ToString();
            this.txtEntePass.Text = this.dgvUser.CurrentRow.Cells["Password"].Value.ToString();
            this.txtEntrSalary.Text = this.dgvUser.CurrentRow.Cells["Salary"].Value.ToString();
            this.txtEnterPhoneNmbr.Text = this.dgvUser.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txtEntrFullname.Text) == true)
            {

                lblFullnameError.Visible = true;

            }
            else
            {

                lblFullnameError.Visible = false;
            }
            if (string.IsNullOrEmpty(txtEntrUsername.Text) == true)
            {

                lblUsernameError.Visible = true;
            }
            else
            {

                lblUsernameError.Visible = false;
            }
            if (string.IsNullOrEmpty(txtEnterPhoneNmbr.Text) == true)
            {
                lblPhoneNmbrError.Visible = true;


            }
            else
            {

                lblPhoneNmbrError.Visible = false;
            }
            if (string.IsNullOrEmpty(txtEntrSalary.Text) == true)
            {

                lblSalaryError.Visible = true;

            }
            else
            {

                lblSalaryError.Visible = false;
            }

            if (string.IsNullOrEmpty(txtEntePass.Text) == true)
            {

                lblPasswordError.Visible = true;

            }
            else
            {
                lblPasswordError.Visible = false;
            }



           

            if (txtEnterPhoneNmbr.Text.Length != 11)
            {
                lblPhoneNmbrError.Visible = true;
                MessageBox.Show("Phone Number Must be 11 digit");
                return;
            }

            if (txtEnterPhoneNmbr.Text.Substring(0, 2) != "01")
            {
                lblPhoneNmbrError.Visible = true;
                MessageBox.Show("Invalid Phone Number");
                return;
            }

            else
            {
                lblPhoneNmbrError.Visible = false;

            }

        

            if (lblFullnameError.Visible == true || lblUsernameError.Visible == true || lblPhoneNmbrError.Visible == true || lblSalaryError.Visible == true || lblPasswordError.Visible == true)
            {
                return;
            }

            var query = "select * from UserInfo where U_ID = '" + this.dgvUser.CurrentRow.Cells["U_ID"].Value.ToString() + "';";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                var sql = @"update UserInfo
                                set Full_Name = '" + this.txtEntrFullname.Text + @"',
                                Password = '" + this.txtEntePass.Text + @"',
                                Username = '" + this.txtEntrUsername.Text + @"',
                                PhoneNumber = '" + this.txtEnterPhoneNmbr.Text + @"',
                                Salary = " + this.txtEntrSalary.Text + @"
                                where U_ID = '" + this.dgvUser.CurrentRow.Cells["U_ID"].Value.ToString() + "';";
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

        private void txtEntrSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEnterPhoneNmbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEntrFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {

        }
    }
}
