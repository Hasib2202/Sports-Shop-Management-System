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
    public partial class AddNewUserUC : UserControl
    {
        public AddNewUserUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        DataAccess Da { get; set; }

        private void ClearAll()
        {
            txtEntrFullname.Clear();
            txtEntrUsername.Clear();
            txtEntePass.Clear();
            txtEntrConfirmPass.Clear();
            txtEntrSalary.Clear();
            txtEnterPhoneNmbr.Clear();

            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            rbtnOthers .Checked = false;
        }

        private string AutoId()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from UserInfo order by U_ID Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");
        }

        private void AddNewUserUC_Load(object sender, EventArgs e)
        {

        }

        private void TurnOffVisibility()
        {

            lblFullnameError.Visible = false;
            lblPasswordError.Visible = false;
            lblPhoneNmbrError.Visible = false;
            lblSalaryError.Visible = false;
            lblUsernameError.Visible = false;
            lblConfirmPassError.Visible = false;
            lblGenderError.Visible = false;

        }

        private void btnClearAddNewUsr_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            TurnOffVisibility();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string UID = "U-" + this.AutoId();
            string fullName = txtEntrFullname.Text;
            string userName = txtEntrUsername.Text;
            string phoneNumber = txtEnterPhoneNmbr.Text;
            string password = txtEntePass.Text;
            string confirmPassword = txtEntrConfirmPass.Text;
            string gender = "null";
            string role = "Seller";
            string salary = txtEntrSalary.Text;

            if (rbtnFemale.Checked == true)
            {
                gender = "Female";
            }
            else if (rbtnMale.Checked == true)
            {
                gender = "Male";
            }
            else if (rbtnOthers.Checked == true)
            {
                gender = "Others";
            }

            if (string.IsNullOrEmpty(txtEntrConfirmPass.Text) == true)
            {
                lblConfirmPassError.Visible = true;
            }
            else
            {
                lblConfirmPassError.Visible = false;
            }

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

            

            if (rbtnMale.Checked == false && rbtnFemale.Checked == false && rbtnOthers.Checked == false)
            {
                lblGenderError.Visible = true;
            }
            else
            {
                lblGenderError.Visible = false;
            }


            if (txtEntePass.Text != txtEntrConfirmPass.Text)
            {

                lblConfirmPassError.Visible = true;
                MessageBox.Show("Password Doesn't Match");

            }
            else
            {
                lblConfirmPassError.Visible = false;
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

            if (rbtnMale.Checked == false && rbtnFemale.Checked == false && rbtnOthers.Checked == false)
            {
                lblGenderError.Visible = true;
            }
            else
            {
                lblGenderError.Visible = false;
            }

            if (lblFullnameError.Visible == true || lblUsernameError.Visible == true || lblPhoneNmbrError.Visible == true || lblSalaryError.Visible == true || lblPasswordError.Visible == true || lblGenderError.Visible == true || lblConfirmPassError.Visible == true)
            {
                return;
            }

            string sql = "insert into UserInfo values ('" + UID + "', '" + fullName + "', '" + userName + "', '" + password + "', '" + gender + "', " + salary + ", '" + role + "', '" + phoneNumber + "')  ;";
            var ds = this.Da.ExecuteQuery(sql);
            MessageBox.Show("New Seller Added");

            ClearAll();


        }

        private void txtEntrSalary_TextChanged(object sender, EventArgs e)
        {

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
    }
}
