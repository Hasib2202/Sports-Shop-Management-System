namespace SportsShopManagement
{
    partial class RemoveProductUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveProductUC));
            this.dgvPeoduct = new System.Windows.Forms.DataGridView();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSearchProduct = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeoduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeoduct
            // 
            this.dgvPeoduct.AllowUserToAddRows = false;
            this.dgvPeoduct.AllowUserToDeleteRows = false;
            this.dgvPeoduct.AllowUserToResizeColumns = false;
            this.dgvPeoduct.AllowUserToResizeRows = false;
            this.dgvPeoduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeoduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_ID,
            this.Category,
            this.Product_name,
            this.Brand,
            this.Price,
            this.Stock,
            this.Delete});
            this.dgvPeoduct.Location = new System.Drawing.Point(3, 82);
            this.dgvPeoduct.Name = "dgvPeoduct";
            this.dgvPeoduct.ReadOnly = true;
            this.dgvPeoduct.RowHeadersVisible = false;
            this.dgvPeoduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeoduct.Size = new System.Drawing.Size(559, 301);
            this.dgvPeoduct.TabIndex = 8;
            this.dgvPeoduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeoduct_CellClick);
            this.dgvPeoduct.DoubleClick += new System.EventHandler(this.dgvPeoduct_DoubleClick);
            // 
            // P_ID
            // 
            this.P_ID.DataPropertyName = "P_ID";
            this.P_ID.HeaderText = "Product ID";
            this.P_ID.Name = "P_ID";
            this.P_ID.ReadOnly = true;
            this.P_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.P_ID.Width = 135;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Category.Width = 135;
            // 
            // Product_name
            // 
            this.Product_name.DataPropertyName = "Product_name";
            this.Product_name.HeaderText = "Pro. Name";
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            this.Product_name.Width = 135;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 135;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
            this.Price.Width = 95;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Visible = false;
            this.Stock.Width = 95;
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
            this.btnSearchProduct.Location = new System.Drawing.Point(343, 5);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.ShadowDecoration.Parent = this.btnSearchProduct;
            this.btnSearchProduct.Size = new System.Drawing.Size(76, 36);
            this.btnSearchProduct.TabIndex = 7;
            this.btnSearchProduct.Text = "Search";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearchProduct.BorderRadius = 10;
            this.txtSearchProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtSearchProduct.BorderThickness = 2;
            this.txtSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchProduct.DefaultText = "Enter Product ID";
            this.txtSearchProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProduct.DisabledState.Parent = this.txtSearchProduct;
            this.txtSearchProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProduct.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtSearchProduct.FocusedState.Parent = this.txtSearchProduct;
            this.txtSearchProduct.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearchProduct.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtSearchProduct.HoverState.Parent = this.txtSearchProduct;
            this.txtSearchProduct.Location = new System.Drawing.Point(136, 5);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PlaceholderText = "";
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.SelectionStart = 16;
            this.txtSearchProduct.ShadowDecoration.Parent = this.txtSearchProduct;
            this.txtSearchProduct.Size = new System.Drawing.Size(200, 36);
            this.txtSearchProduct.TabIndex = 6;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            this.txtSearchProduct.Enter += new System.EventHandler(this.txtSearchProduct_Enter);
            this.txtSearchProduct.Leave += new System.EventHandler(this.txtSearchProduct_Leave);
            // 
            // RemoveProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvPeoduct);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Name = "RemoveProductUC";
            this.Size = new System.Drawing.Size(565, 387);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeoduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeoduct;
        private Guna.UI2.WinForms.Guna2Button btnSearchProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
