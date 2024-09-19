namespace SportsShopManagement
{
    partial class RemoveUserUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveUserUC));
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearchUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchUser = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeColumns = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U_ID,
            this.Full_Name,
            this.Username,
            this.Password,
            this.Gender,
            this.Salary,
            this.Role,
            this.PhoneNumber,
            this.Delete});
            this.dgvUser.Location = new System.Drawing.Point(3, 82);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(559, 301);
            this.dgvUser.TabIndex = 7;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.DoubleClick += new System.EventHandler(this.dgvUser_DoubleClick);
            // 
            // U_ID
            // 
            this.U_ID.DataPropertyName = "U_ID";
            this.U_ID.HeaderText = "User ID";
            this.U_ID.Name = "U_ID";
            this.U_ID.ReadOnly = true;
            this.U_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.U_ID.Width = 135;
            // 
            // Full_Name
            // 
            this.Full_Name.DataPropertyName = "Full_Name";
            this.Full_Name.HeaderText = "Fullname";
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            this.Full_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Full_Name.Width = 135;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 135;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            this.Password.Width = 108;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Visible = false;
            this.Salary.Width = 108;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Visible = false;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone No.";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 135;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearchUser.BorderRadius = 10;
            this.txtSearchUser.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtSearchUser.BorderThickness = 2;
            this.txtSearchUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchUser.DefaultText = "Enter User ID";
            this.txtSearchUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchUser.DisabledState.Parent = this.txtSearchUser;
            this.txtSearchUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchUser.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtSearchUser.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.txtSearchUser.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearchUser.FocusedState.Parent = this.txtSearchUser;
            this.txtSearchUser.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearchUser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtSearchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearchUser.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtSearchUser.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.txtSearchUser.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearchUser.HoverState.Parent = this.txtSearchUser;
            this.txtSearchUser.HoverState.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.txtSearchUser.Location = new System.Drawing.Point(136, 5);
            this.txtSearchUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.PasswordChar = '\0';
            this.txtSearchUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearchUser.PlaceholderText = "";
            this.txtSearchUser.SelectedText = "";
            this.txtSearchUser.SelectionStart = 13;
            this.txtSearchUser.ShadowDecoration.Parent = this.txtSearchUser;
            this.txtSearchUser.Size = new System.Drawing.Size(200, 36);
            this.txtSearchUser.TabIndex = 5;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            this.txtSearchUser.Enter += new System.EventHandler(this.txtSearchUser_Enter);
            this.txtSearchUser.Leave += new System.EventHandler(this.txtSearchUser_Leave);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BorderColor = System.Drawing.Color.White;
            this.btnSearchUser.BorderRadius = 16;
            this.btnSearchUser.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSearchUser.BorderThickness = 2;
            this.btnSearchUser.CheckedState.Parent = this.btnSearchUser;
            this.btnSearchUser.CustomImages.Parent = this.btnSearchUser;
            this.btnSearchUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchUser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearchUser.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSearchUser.HoverState.Parent = this.btnSearchUser;
            this.btnSearchUser.Location = new System.Drawing.Point(343, 5);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.ShadowDecoration.Parent = this.btnSearchUser;
            this.btnSearchUser.Size = new System.Drawing.Size(76, 36);
            this.btnSearchUser.TabIndex = 6;
            this.btnSearchUser.Text = "Search";
            // 
            // RemoveUserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.btnSearchUser);
            this.Name = "RemoveUserUC";
            this.Size = new System.Drawing.Size(565, 387);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchUser;
        private Guna.UI2.WinForms.Guna2Button btnSearchUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
