namespace SportsShopManagement
{
    partial class OrderUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderUC));
            this.dgvPeoduct = new System.Windows.Forms.DataGridView();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchProduct = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnCartClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnCartConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.lblCart = new System.Windows.Forms.Label();
            this.P_ID_Cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Quantity_Cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name_Cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_Cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plus = new System.Windows.Forms.DataGridViewImageColumn();
            this.Minus = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new Guna.UI2.WinForms.Guna2TileButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeoduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
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
            this.Stock});
            this.dgvPeoduct.Location = new System.Drawing.Point(3, 34);
            this.dgvPeoduct.Name = "dgvPeoduct";
            this.dgvPeoduct.ReadOnly = true;
            this.dgvPeoduct.RowHeadersVisible = false;
            this.dgvPeoduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeoduct.Size = new System.Drawing.Size(355, 254);
            this.dgvPeoduct.TabIndex = 9;
            this.dgvPeoduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeoduct_CellClick);
            this.dgvPeoduct.DoubleClick += new System.EventHandler(this.dgvPeoduct_DoubleClick);
            // 
            // P_ID
            // 
            this.P_ID.DataPropertyName = "P_ID";
            this.P_ID.HeaderText = "Pro. ID";
            this.P_ID.Name = "P_ID";
            this.P_ID.ReadOnly = true;
            this.P_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.P_ID.Visible = false;
            this.P_ID.Width = 70;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Category.Width = 70;
            // 
            // Product_name
            // 
            this.Product_name.DataPropertyName = "Product_name";
            this.Product_name.HeaderText = "Pro. Name";
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            this.Product_name.Width = 90;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 70;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 60;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
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
            this.btnSearchProduct.Location = new System.Drawing.Point(532, 34);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.ShadowDecoration.Parent = this.btnSearchProduct;
            this.btnSearchProduct.Size = new System.Drawing.Size(65, 36);
            this.btnSearchProduct.TabIndex = 12;
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
            this.txtSearchProduct.Location = new System.Drawing.Point(365, 34);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PlaceholderText = "";
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.SelectionStart = 16;
            this.txtSearchProduct.ShadowDecoration.Parent = this.txtSearchProduct;
            this.txtSearchProduct.Size = new System.Drawing.Size(160, 36);
            this.txtSearchProduct.TabIndex = 11;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            this.txtSearchProduct.Enter += new System.EventHandler(this.txtSearchProduct_Enter);
            this.txtSearchProduct.Leave += new System.EventHandler(this.txtSearchProduct_Leave);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_ID_Cart,
            this.Category_Cart,
            this.Total_Quantity_Cart,
            this.Product_name_Cart,
            this.Brand_Cart,
            this.Price_Cart,
            this.Quantity_Cart,
            this.Plus,
            this.Minus,
            this.Delete});
            this.dgvCart.Location = new System.Drawing.Point(3, 303);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(355, 254);
            this.dgvCart.TabIndex = 13;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // btnCartClear
            // 
            this.btnCartClear.BorderColor = System.Drawing.Color.White;
            this.btnCartClear.BorderRadius = 15;
            this.btnCartClear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnCartClear.BorderThickness = 2;
            this.btnCartClear.CheckedState.Parent = this.btnCartClear;
            this.btnCartClear.CustomImages.Parent = this.btnCartClear;
            this.btnCartClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCartClear.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartClear.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnCartClear.HoverState.Parent = this.btnCartClear;
            this.btnCartClear.Location = new System.Drawing.Point(418, 464);
            this.btnCartClear.Name = "btnCartClear";
            this.btnCartClear.ShadowDecoration.Parent = this.btnCartClear;
            this.btnCartClear.Size = new System.Drawing.Size(129, 36);
            this.btnCartClear.TabIndex = 15;
            this.btnCartClear.Text = "Clear Cart";
            this.btnCartClear.Click += new System.EventHandler(this.btnCartClear_Click);
            // 
            // btnCartConfirm
            // 
            this.btnCartConfirm.BorderColor = System.Drawing.Color.White;
            this.btnCartConfirm.BorderRadius = 15;
            this.btnCartConfirm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnCartConfirm.BorderThickness = 2;
            this.btnCartConfirm.CheckedState.Parent = this.btnCartConfirm;
            this.btnCartConfirm.CustomImages.Parent = this.btnCartConfirm;
            this.btnCartConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCartConfirm.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartConfirm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnCartConfirm.HoverState.Parent = this.btnCartConfirm;
            this.btnCartConfirm.Location = new System.Drawing.Point(418, 507);
            this.btnCartConfirm.Name = "btnCartConfirm";
            this.btnCartConfirm.ShadowDecoration.Parent = this.btnCartConfirm;
            this.btnCartConfirm.Size = new System.Drawing.Size(129, 36);
            this.btnCartConfirm.TabIndex = 16;
            this.btnCartConfirm.Text = "Confirm Cart";
            this.btnCartConfirm.Click += new System.EventHandler(this.btnCartConfirm_Click);
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCart.Location = new System.Drawing.Point(451, 354);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(82, 23);
            this.lblCart.TabIndex = 17;
            this.lblCart.Text = " 00 Taka";
            this.lblCart.Click += new System.EventHandler(this.lblCart_Click);
            // 
            // P_ID_Cart
            // 
            this.P_ID_Cart.HeaderText = "Pro. ID";
            this.P_ID_Cart.Name = "P_ID_Cart";
            this.P_ID_Cart.ReadOnly = true;
            this.P_ID_Cart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.P_ID_Cart.Visible = false;
            this.P_ID_Cart.Width = 65;
            // 
            // Category_Cart
            // 
            this.Category_Cart.HeaderText = "Category";
            this.Category_Cart.Name = "Category_Cart";
            this.Category_Cart.ReadOnly = true;
            this.Category_Cart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Category_Cart.Width = 65;
            // 
            // Total_Quantity_Cart
            // 
            this.Total_Quantity_Cart.HeaderText = "";
            this.Total_Quantity_Cart.Name = "Total_Quantity_Cart";
            this.Total_Quantity_Cart.ReadOnly = true;
            this.Total_Quantity_Cart.Visible = false;
            // 
            // Product_name_Cart
            // 
            this.Product_name_Cart.HeaderText = "Pro.Name";
            this.Product_name_Cart.Name = "Product_name_Cart";
            this.Product_name_Cart.ReadOnly = true;
            this.Product_name_Cart.Width = 65;
            // 
            // Brand_Cart
            // 
            this.Brand_Cart.HeaderText = "Brand";
            this.Brand_Cart.Name = "Brand_Cart";
            this.Brand_Cart.ReadOnly = true;
            this.Brand_Cart.Visible = false;
            this.Brand_Cart.Width = 70;
            // 
            // Price_Cart
            // 
            this.Price_Cart.HeaderText = "Price";
            this.Price_Cart.Name = "Price_Cart";
            this.Price_Cart.ReadOnly = true;
            this.Price_Cart.Width = 50;
            // 
            // Quantity_Cart
            // 
            this.Quantity_Cart.HeaderText = "Quantity Cart";
            this.Quantity_Cart.Name = "Quantity_Cart";
            this.Quantity_Cart.ReadOnly = true;
            this.Quantity_Cart.Width = 95;
            // 
            // Plus
            // 
            this.Plus.HeaderText = "";
            this.Plus.Image = ((System.Drawing.Image)(resources.GetObject("Plus.Image")));
            this.Plus.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Plus.Name = "Plus";
            this.Plus.ReadOnly = true;
            this.Plus.Width = 26;
            // 
            // Minus
            // 
            this.Minus.HeaderText = "";
            this.Minus.Image = ((System.Drawing.Image)(resources.GetObject("Minus.Image")));
            this.Minus.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Minus.Name = "Minus";
            this.Minus.ReadOnly = true;
            this.Minus.Width = 26;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Double Click on The Row To Select Any Product";
            // 
            // lblPrice
            // 
            this.lblPrice.BorderColor = System.Drawing.Color.White;
            this.lblPrice.BorderRadius = 15;
            this.lblPrice.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblPrice.BorderThickness = 2;
            this.lblPrice.CheckedState.Parent = this.lblPrice;
            this.lblPrice.CustomImages.Parent = this.lblPrice;
            this.lblPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblPrice.HoverState.BorderColor = System.Drawing.Color.White;
            this.lblPrice.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrice.HoverState.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblPrice.HoverState.Parent = this.lblPrice;
            this.lblPrice.Location = new System.Drawing.Point(385, 315);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrice.ShadowDecoration.Parent = this.lblPrice;
            this.lblPrice.Size = new System.Drawing.Size(212, 36);
            this.lblPrice.TabIndex = 50;
            this.lblPrice.Text = "Total Bill Is ";
            // 
            // OrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.btnCartConfirm);
            this.Controls.Add(this.btnCartClear);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.dgvPeoduct);
            this.Name = "OrderUC";
            this.Size = new System.Drawing.Size(600, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeoduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeoduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private Guna.UI2.WinForms.Guna2Button btnSearchProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProduct;
        private System.Windows.Forms.DataGridView dgvCart;
        private Guna.UI2.WinForms.Guna2Button btnCartClear;
        private Guna.UI2.WinForms.Guna2Button btnCartConfirm;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Quantity_Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name_Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Cart;
        private System.Windows.Forms.DataGridViewImageColumn Plus;
        private System.Windows.Forms.DataGridViewImageColumn Minus;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TileButton lblPrice;
    }
}
