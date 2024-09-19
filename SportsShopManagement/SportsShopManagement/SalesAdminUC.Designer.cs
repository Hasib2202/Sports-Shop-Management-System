namespace SportsShopManagement
{
    partial class SalesAdminUC
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
            this.btnSearchProduct = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchTransaction = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvTransactionHistory = new System.Windows.Forms.DataGridView();
            this.T_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BorderColor = System.Drawing.Color.White;
            this.btnSearchProduct.BorderRadius = 15;
            this.btnSearchProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSearchProduct.BorderThickness = 2;
            this.btnSearchProduct.CheckedState.Parent = this.btnSearchProduct;
            this.btnSearchProduct.CustomImages.Parent = this.btnSearchProduct;
            this.btnSearchProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchProduct.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSearchProduct.HoverState.Parent = this.btnSearchProduct;
            this.btnSearchProduct.Location = new System.Drawing.Point(355, 27);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.ShadowDecoration.Parent = this.btnSearchProduct;
            this.btnSearchProduct.Size = new System.Drawing.Size(76, 36);
            this.btnSearchProduct.TabIndex = 10;
            this.btnSearchProduct.Text = "Search";
            // 
            // txtSearchTransaction
            // 
            this.txtSearchTransaction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearchTransaction.BorderRadius = 10;
            this.txtSearchTransaction.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtSearchTransaction.BorderThickness = 2;
            this.txtSearchTransaction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchTransaction.DefaultText = "Enter Transaction ID";
            this.txtSearchTransaction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchTransaction.DisabledState.Parent = this.txtSearchTransaction;
            this.txtSearchTransaction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchTransaction.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtSearchTransaction.FocusedState.Parent = this.txtSearchTransaction;
            this.txtSearchTransaction.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearchTransaction.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtSearchTransaction.HoverState.Parent = this.txtSearchTransaction;
            this.txtSearchTransaction.Location = new System.Drawing.Point(148, 27);
            this.txtSearchTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchTransaction.Name = "txtSearchTransaction";
            this.txtSearchTransaction.PasswordChar = '\0';
            this.txtSearchTransaction.PlaceholderText = "";
            this.txtSearchTransaction.SelectedText = "";
            this.txtSearchTransaction.SelectionStart = 20;
            this.txtSearchTransaction.ShadowDecoration.Parent = this.txtSearchTransaction;
            this.txtSearchTransaction.Size = new System.Drawing.Size(200, 36);
            this.txtSearchTransaction.TabIndex = 9;
            this.txtSearchTransaction.TextChanged += new System.EventHandler(this.txtSearchTransaction_TextChanged);
            this.txtSearchTransaction.Enter += new System.EventHandler(this.txtSearchTransaction_Enter);
            this.txtSearchTransaction.Leave += new System.EventHandler(this.txtSearchTransaction_Leave);
            // 
            // dgvTransactionHistory
            // 
            this.dgvTransactionHistory.AllowUserToAddRows = false;
            this.dgvTransactionHistory.AllowUserToDeleteRows = false;
            this.dgvTransactionHistory.AllowUserToResizeColumns = false;
            this.dgvTransactionHistory.AllowUserToResizeRows = false;
            this.dgvTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.T_ID,
            this.U_ID,
            this.Username,
            this.CustomerName,
            this.AmountPaid,
            this.DateOfTransaction});
            this.dgvTransactionHistory.Location = new System.Drawing.Point(3, 106);
            this.dgvTransactionHistory.Name = "dgvTransactionHistory";
            this.dgvTransactionHistory.ReadOnly = true;
            this.dgvTransactionHistory.RowHeadersVisible = false;
            this.dgvTransactionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionHistory.Size = new System.Drawing.Size(594, 451);
            this.dgvTransactionHistory.TabIndex = 14;
            // 
            // T_ID
            // 
            this.T_ID.DataPropertyName = "T_ID";
            this.T_ID.HeaderText = "Transaction ID";
            this.T_ID.Name = "T_ID";
            this.T_ID.ReadOnly = true;
            this.T_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.T_ID.Width = 90;
            // 
            // U_ID
            // 
            this.U_ID.DataPropertyName = "U_ID";
            this.U_ID.HeaderText = "User ID";
            this.U_ID.Name = "U_ID";
            this.U_ID.ReadOnly = true;
            this.U_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.U_ID.Width = 90;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Seller Name";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 110;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 110;
            // 
            // AmountPaid
            // 
            this.AmountPaid.DataPropertyName = "AmountPaid";
            this.AmountPaid.HeaderText = "Paid Amount";
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.ReadOnly = true;
            this.AmountPaid.Width = 110;
            // 
            // DateOfTransaction
            // 
            this.DateOfTransaction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfTransaction.DataPropertyName = "DateOfTransaction";
            this.DateOfTransaction.HeaderText = "Date";
            this.DateOfTransaction.Name = "DateOfTransaction";
            this.DateOfTransaction.ReadOnly = true;
            // 
            // SalesAdminUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvTransactionHistory);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchTransaction);
            this.Name = "SalesAdminUC";
            this.Size = new System.Drawing.Size(600, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSearchProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTransaction;
        private System.Windows.Forms.DataGridView dgvTransactionHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfTransaction;
    }
}
