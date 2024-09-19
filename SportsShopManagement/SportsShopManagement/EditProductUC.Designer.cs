namespace SportsShopManagement
{
    partial class EditProductUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductUC));
            this.btnSearchProduct = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPeoduct = new System.Windows.Forms.DataGridView();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStockError = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblPriceError = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnSaveProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearEditProduct = new Guna.UI2.WinForms.Guna2Button();
            this.txtEnterStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEnterPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStock = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblPrice = new Guna.UI2.WinForms.Guna2TileButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeoduct)).BeginInit();
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
            this.btnSearchProduct.Location = new System.Drawing.Point(209, 5);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.ShadowDecoration.Parent = this.btnSearchProduct;
            this.btnSearchProduct.Size = new System.Drawing.Size(76, 36);
            this.btnSearchProduct.TabIndex = 3;
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
            this.txtSearchProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchProduct.HoverState.Parent = this.txtSearchProduct;
            this.txtSearchProduct.Location = new System.Drawing.Point(4, 5);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PlaceholderText = "";
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.SelectionStart = 16;
            this.txtSearchProduct.ShadowDecoration.Parent = this.txtSearchProduct;
            this.txtSearchProduct.Size = new System.Drawing.Size(200, 36);
            this.txtSearchProduct.TabIndex = 2;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            this.txtSearchProduct.Enter += new System.EventHandler(this.txtSearchProduct_Enter);
            this.txtSearchProduct.Leave += new System.EventHandler(this.txtSearchProduct_Leave);
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
            this.dgvPeoduct.Location = new System.Drawing.Point(4, 158);
            this.dgvPeoduct.Name = "dgvPeoduct";
            this.dgvPeoduct.ReadOnly = true;
            this.dgvPeoduct.RowHeadersVisible = false;
            this.dgvPeoduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeoduct.Size = new System.Drawing.Size(558, 224);
            this.dgvPeoduct.TabIndex = 5;
            this.dgvPeoduct.DoubleClick += new System.EventHandler(this.dgvPeoduct_DoubleClick);
            // 
            // P_ID
            // 
            this.P_ID.DataPropertyName = "P_ID";
            this.P_ID.HeaderText = "Product ID";
            this.P_ID.Name = "P_ID";
            this.P_ID.ReadOnly = true;
            this.P_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.P_ID.Width = 95;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Category.Width = 95;
            // 
            // Product_name
            // 
            this.Product_name.DataPropertyName = "Product_name";
            this.Product_name.HeaderText = "Pro. Name";
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            this.Product_name.Width = 95;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 95;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 95;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // lblStockError
            // 
            this.lblStockError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblStockError.BackgroundImage")));
            this.lblStockError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblStockError.BorderColor = System.Drawing.Color.Transparent;
            this.lblStockError.BorderRadius = 15;
            this.lblStockError.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblStockError.BorderThickness = 2;
            this.lblStockError.CheckedState.Parent = this.lblStockError;
            this.lblStockError.CustomImages.Parent = this.lblStockError;
            this.lblStockError.FillColor = System.Drawing.Color.Transparent;
            this.lblStockError.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblStockError.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblStockError.HoverState.Parent = this.lblStockError;
            this.lblStockError.Location = new System.Drawing.Point(395, 104);
            this.lblStockError.Name = "lblStockError";
            this.lblStockError.ShadowDecoration.Parent = this.lblStockError;
            this.lblStockError.Size = new System.Drawing.Size(25, 25);
            this.lblStockError.TabIndex = 34;
            this.lblStockError.Visible = false;
            // 
            // lblPriceError
            // 
            this.lblPriceError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblPriceError.BackgroundImage")));
            this.lblPriceError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblPriceError.BorderColor = System.Drawing.Color.Transparent;
            this.lblPriceError.BorderRadius = 15;
            this.lblPriceError.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblPriceError.BorderThickness = 2;
            this.lblPriceError.CheckedState.Parent = this.lblPriceError;
            this.lblPriceError.CustomImages.Parent = this.lblPriceError;
            this.lblPriceError.FillColor = System.Drawing.Color.Transparent;
            this.lblPriceError.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPriceError.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblPriceError.HoverState.Parent = this.lblPriceError;
            this.lblPriceError.Location = new System.Drawing.Point(395, 54);
            this.lblPriceError.Name = "lblPriceError";
            this.lblPriceError.ShadowDecoration.Parent = this.lblPriceError;
            this.lblPriceError.Size = new System.Drawing.Size(25, 25);
            this.lblPriceError.TabIndex = 33;
            this.lblPriceError.Visible = false;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveProduct.BorderColor = System.Drawing.Color.White;
            this.btnSaveProduct.BorderRadius = 15;
            this.btnSaveProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSaveProduct.BorderThickness = 2;
            this.btnSaveProduct.CheckedState.Parent = this.btnSaveProduct;
            this.btnSaveProduct.CustomImages.Parent = this.btnSaveProduct;
            this.btnSaveProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveProduct.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveProduct.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSaveProduct.HoverState.Parent = this.btnSaveProduct;
            this.btnSaveProduct.Location = new System.Drawing.Point(462, 103);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.ShadowDecoration.Parent = this.btnSaveProduct;
            this.btnSaveProduct.Size = new System.Drawing.Size(88, 36);
            this.btnSaveProduct.TabIndex = 32;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnClearEditProduct
            // 
            this.btnClearEditProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnClearEditProduct.BorderColor = System.Drawing.Color.White;
            this.btnClearEditProduct.BorderRadius = 15;
            this.btnClearEditProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnClearEditProduct.BorderThickness = 2;
            this.btnClearEditProduct.CheckedState.Parent = this.btnClearEditProduct;
            this.btnClearEditProduct.CustomImages.Parent = this.btnClearEditProduct;
            this.btnClearEditProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClearEditProduct.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClearEditProduct.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnClearEditProduct.HoverState.Parent = this.btnClearEditProduct;
            this.btnClearEditProduct.Location = new System.Drawing.Point(462, 61);
            this.btnClearEditProduct.Name = "btnClearEditProduct";
            this.btnClearEditProduct.ShadowDecoration.Parent = this.btnClearEditProduct;
            this.btnClearEditProduct.Size = new System.Drawing.Size(88, 36);
            this.btnClearEditProduct.TabIndex = 31;
            this.btnClearEditProduct.Text = "Clear";
            this.btnClearEditProduct.Click += new System.EventHandler(this.btnClearEditProduct_Click);
            // 
            // txtEnterStock
            // 
            this.txtEnterStock.BackColor = System.Drawing.Color.Transparent;
            this.txtEnterStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEnterStock.BorderRadius = 10;
            this.txtEnterStock.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtEnterStock.BorderThickness = 2;
            this.txtEnterStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnterStock.DefaultText = "";
            this.txtEnterStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnterStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnterStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterStock.DisabledState.Parent = this.txtEnterStock;
            this.txtEnterStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterStock.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtEnterStock.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.txtEnterStock.FocusedState.Parent = this.txtEnterStock;
            this.txtEnterStock.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEnterStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEnterStock.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtEnterStock.HoverState.Parent = this.txtEnterStock;
            this.txtEnterStock.Location = new System.Drawing.Point(162, 98);
            this.txtEnterStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnterStock.Name = "txtEnterStock";
            this.txtEnterStock.PasswordChar = '\0';
            this.txtEnterStock.PlaceholderText = "";
            this.txtEnterStock.SelectedText = "";
            this.txtEnterStock.ShadowDecoration.Parent = this.txtEnterStock;
            this.txtEnterStock.Size = new System.Drawing.Size(226, 36);
            this.txtEnterStock.TabIndex = 30;
            this.txtEnterStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterStock_KeyPress);
            // 
            // txtEnterPrice
            // 
            this.txtEnterPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtEnterPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEnterPrice.BorderRadius = 10;
            this.txtEnterPrice.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtEnterPrice.BorderThickness = 2;
            this.txtEnterPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnterPrice.DefaultText = "";
            this.txtEnterPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnterPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnterPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterPrice.DisabledState.Parent = this.txtEnterPrice;
            this.txtEnterPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterPrice.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtEnterPrice.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.txtEnterPrice.FocusedState.Parent = this.txtEnterPrice;
            this.txtEnterPrice.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEnterPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEnterPrice.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtEnterPrice.HoverState.Parent = this.txtEnterPrice;
            this.txtEnterPrice.Location = new System.Drawing.Point(162, 48);
            this.txtEnterPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnterPrice.Name = "txtEnterPrice";
            this.txtEnterPrice.PasswordChar = '\0';
            this.txtEnterPrice.PlaceholderText = "";
            this.txtEnterPrice.SelectedText = "";
            this.txtEnterPrice.ShadowDecoration.Parent = this.txtEnterPrice;
            this.txtEnterPrice.Size = new System.Drawing.Size(226, 36);
            this.txtEnterPrice.TabIndex = 29;
            this.txtEnterPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterPrice_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.BorderColor = System.Drawing.Color.White;
            this.lblStock.BorderRadius = 15;
            this.lblStock.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblStock.BorderThickness = 2;
            this.lblStock.CheckedState.Parent = this.lblStock;
            this.lblStock.CustomImages.Parent = this.lblStock;
            this.lblStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStock.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblStock.HoverState.BorderColor = System.Drawing.Color.White;
            this.lblStock.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStock.HoverState.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblStock.HoverState.Parent = this.lblStock;
            this.lblStock.Location = new System.Drawing.Point(4, 96);
            this.lblStock.Name = "lblStock";
            this.lblStock.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStock.ShadowDecoration.Parent = this.lblStock;
            this.lblStock.Size = new System.Drawing.Size(151, 36);
            this.lblStock.TabIndex = 28;
            this.lblStock.Text = "Stock";
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
            this.lblPrice.Location = new System.Drawing.Point(4, 49);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrice.ShadowDecoration.Parent = this.lblPrice;
            this.lblPrice.Size = new System.Drawing.Size(151, 36);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(144, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Double Click on The Row To Edit Any Product-Info ";
            // 
            // EditProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStockError);
            this.Controls.Add(this.lblPriceError);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnClearEditProduct);
            this.Controls.Add(this.txtEnterStock);
            this.Controls.Add(this.txtEnterPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.dgvPeoduct);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Name = "EditProductUC";
            this.Size = new System.Drawing.Size(565, 387);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeoduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSearchProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProduct;
        private System.Windows.Forms.DataGridView dgvPeoduct;
        private Guna.UI2.WinForms.Guna2TileButton lblStockError;
        private Guna.UI2.WinForms.Guna2TileButton lblPriceError;
        private Guna.UI2.WinForms.Guna2Button btnSaveProduct;
        private Guna.UI2.WinForms.Guna2Button btnClearEditProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterStock;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterPrice;
        private Guna.UI2.WinForms.Guna2TileButton lblStock;
        private Guna.UI2.WinForms.Guna2TileButton lblPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Label label1;
    }
}
