namespace SportsShopManagement
{
    partial class AddProductUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductUC));
            this.cboxProductCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCategory = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblProductName = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblBrand = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblPrice = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblStock = new Guna.UI2.WinForms.Guna2TileButton();
            this.txtEnterProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtEnterBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEnterPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEnterStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClearAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.lblCategoryError = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblProductNameError = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblBrandError = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblPriceError = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblStockError = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // cboxProductCategory
            // 
            this.cboxProductCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboxProductCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cboxProductCategory.BorderRadius = 10;
            this.cboxProductCategory.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.cboxProductCategory.BorderThickness = 2;
            this.cboxProductCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProductCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cboxProductCategory.FocusedState.Parent = this.cboxProductCategory;
            this.cboxProductCategory.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboxProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cboxProductCategory.FormattingEnabled = true;
            this.cboxProductCategory.HoverState.Parent = this.cboxProductCategory;
            this.cboxProductCategory.ItemHeight = 30;
            this.cboxProductCategory.Items.AddRange(new object[] {
            "Badminton",
            "Basketball",
            "Cricket",
            "Football",
            "Golf",
            "Hockey",
            "Pool",
            "Soccer",
            "Tennis",
            "Volleyball"});
            this.cboxProductCategory.ItemsAppearance.Parent = this.cboxProductCategory;
            this.cboxProductCategory.Location = new System.Drawing.Point(254, 46);
            this.cboxProductCategory.Name = "cboxProductCategory";
            this.cboxProductCategory.ShadowDecoration.Parent = this.cboxProductCategory;
            this.cboxProductCategory.Size = new System.Drawing.Size(226, 36);
            this.cboxProductCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.BorderColor = System.Drawing.Color.White;
            this.lblCategory.BorderRadius = 15;
            this.lblCategory.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblCategory.BorderThickness = 2;
            this.lblCategory.CheckedState.Parent = this.lblCategory;
            this.lblCategory.CustomImages.Parent = this.lblCategory;
            this.lblCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCategory.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblCategory.HoverState.BorderColor = System.Drawing.Color.White;
            this.lblCategory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCategory.HoverState.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblCategory.HoverState.Parent = this.lblCategory;
            this.lblCategory.Location = new System.Drawing.Point(73, 46);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCategory.ShadowDecoration.Parent = this.lblCategory;
            this.lblCategory.Size = new System.Drawing.Size(151, 36);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblProductName
            // 
            this.lblProductName.BorderColor = System.Drawing.Color.White;
            this.lblProductName.BorderRadius = 15;
            this.lblProductName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblProductName.BorderThickness = 2;
            this.lblProductName.CheckedState.Parent = this.lblProductName;
            this.lblProductName.CustomImages.Parent = this.lblProductName;
            this.lblProductName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProductName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblProductName.HoverState.BorderColor = System.Drawing.Color.White;
            this.lblProductName.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProductName.HoverState.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblProductName.HoverState.Parent = this.lblProductName;
            this.lblProductName.Location = new System.Drawing.Point(73, 96);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProductName.ShadowDecoration.Parent = this.lblProductName;
            this.lblProductName.Size = new System.Drawing.Size(151, 36);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Name";
            // 
            // lblBrand
            // 
            this.lblBrand.BorderColor = System.Drawing.Color.White;
            this.lblBrand.BorderRadius = 15;
            this.lblBrand.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblBrand.BorderThickness = 2;
            this.lblBrand.CheckedState.Parent = this.lblBrand;
            this.lblBrand.CustomImages.Parent = this.lblBrand;
            this.lblBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBrand.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblBrand.HoverState.BorderColor = System.Drawing.Color.White;
            this.lblBrand.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBrand.HoverState.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblBrand.HoverState.Parent = this.lblBrand;
            this.lblBrand.Location = new System.Drawing.Point(73, 146);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBrand.ShadowDecoration.Parent = this.lblBrand;
            this.lblBrand.Size = new System.Drawing.Size(151, 36);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand";
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
            this.lblPrice.Location = new System.Drawing.Point(73, 196);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrice.ShadowDecoration.Parent = this.lblPrice;
            this.lblPrice.Size = new System.Drawing.Size(151, 36);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
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
            this.lblStock.Location = new System.Drawing.Point(73, 246);
            this.lblStock.Name = "lblStock";
            this.lblStock.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStock.ShadowDecoration.Parent = this.lblStock;
            this.lblStock.Size = new System.Drawing.Size(151, 36);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            // 
            // txtEnterProductName
            // 
            this.txtEnterProductName.BackColor = System.Drawing.Color.Transparent;
            this.txtEnterProductName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEnterProductName.BorderRadius = 10;
            this.txtEnterProductName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtEnterProductName.BorderThickness = 2;
            this.txtEnterProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnterProductName.DefaultText = "";
            this.txtEnterProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnterProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnterProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterProductName.DisabledState.Parent = this.txtEnterProductName;
            this.txtEnterProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterProductName.FocusedState.FillColor = System.Drawing.Color.OrangeRed;
            this.txtEnterProductName.FocusedState.Parent = this.txtEnterProductName;
            this.txtEnterProductName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEnterProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEnterProductName.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtEnterProductName.HoverState.Parent = this.txtEnterProductName;
            this.txtEnterProductName.Location = new System.Drawing.Point(254, 96);
            this.txtEnterProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnterProductName.Name = "txtEnterProductName";
            this.txtEnterProductName.PasswordChar = '\0';
            this.txtEnterProductName.PlaceholderText = "";
            this.txtEnterProductName.SelectedText = "";
            this.txtEnterProductName.ShadowDecoration.Parent = this.txtEnterProductName;
            this.txtEnterProductName.Size = new System.Drawing.Size(226, 36);
            this.txtEnterProductName.TabIndex = 6;
            this.txtEnterProductName.TextChanged += new System.EventHandler(this.txtEnterProductName_TextChanged);
            this.txtEnterProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterProductName_KeyPress);
            // 
            // TxtEnterBrand
            // 
            this.TxtEnterBrand.BackColor = System.Drawing.Color.Transparent;
            this.TxtEnterBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TxtEnterBrand.BorderRadius = 10;
            this.TxtEnterBrand.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TxtEnterBrand.BorderThickness = 2;
            this.TxtEnterBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEnterBrand.DefaultText = "";
            this.TxtEnterBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEnterBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEnterBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEnterBrand.DisabledState.Parent = this.TxtEnterBrand;
            this.TxtEnterBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEnterBrand.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.TxtEnterBrand.FocusedState.FillColor = System.Drawing.Color.OrangeRed;
            this.TxtEnterBrand.FocusedState.Parent = this.TxtEnterBrand;
            this.TxtEnterBrand.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.TxtEnterBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TxtEnterBrand.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.TxtEnterBrand.HoverState.Parent = this.TxtEnterBrand;
            this.TxtEnterBrand.Location = new System.Drawing.Point(254, 146);
            this.TxtEnterBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEnterBrand.Name = "TxtEnterBrand";
            this.TxtEnterBrand.PasswordChar = '\0';
            this.TxtEnterBrand.PlaceholderText = "";
            this.TxtEnterBrand.SelectedText = "";
            this.TxtEnterBrand.ShadowDecoration.Parent = this.TxtEnterBrand;
            this.TxtEnterBrand.Size = new System.Drawing.Size(226, 36);
            this.TxtEnterBrand.TabIndex = 7;
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
            this.txtEnterPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterPrice.FocusedState.FillColor = System.Drawing.Color.OrangeRed;
            this.txtEnterPrice.FocusedState.Parent = this.txtEnterPrice;
            this.txtEnterPrice.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEnterPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEnterPrice.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtEnterPrice.HoverState.Parent = this.txtEnterPrice;
            this.txtEnterPrice.Location = new System.Drawing.Point(254, 196);
            this.txtEnterPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnterPrice.Name = "txtEnterPrice";
            this.txtEnterPrice.PasswordChar = '\0';
            this.txtEnterPrice.PlaceholderText = "";
            this.txtEnterPrice.SelectedText = "";
            this.txtEnterPrice.ShadowDecoration.Parent = this.txtEnterPrice;
            this.txtEnterPrice.Size = new System.Drawing.Size(226, 36);
            this.txtEnterPrice.TabIndex = 8;
            this.txtEnterPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterPrice_KeyPress);
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
            this.txtEnterStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterStock.FocusedState.FillColor = System.Drawing.Color.OrangeRed;
            this.txtEnterStock.FocusedState.Parent = this.txtEnterStock;
            this.txtEnterStock.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEnterStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEnterStock.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtEnterStock.HoverState.Parent = this.txtEnterStock;
            this.txtEnterStock.Location = new System.Drawing.Point(254, 246);
            this.txtEnterStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnterStock.Name = "txtEnterStock";
            this.txtEnterStock.PasswordChar = '\0';
            this.txtEnterStock.PlaceholderText = "";
            this.txtEnterStock.SelectedText = "";
            this.txtEnterStock.ShadowDecoration.Parent = this.txtEnterStock;
            this.txtEnterStock.Size = new System.Drawing.Size(226, 36);
            this.txtEnterStock.TabIndex = 9;
            this.txtEnterStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterStock_KeyPress);
            // 
            // btnClearAddProduct
            // 
            this.btnClearAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAddProduct.BorderColor = System.Drawing.Color.White;
            this.btnClearAddProduct.BorderRadius = 15;
            this.btnClearAddProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnClearAddProduct.BorderThickness = 2;
            this.btnClearAddProduct.CheckedState.Parent = this.btnClearAddProduct;
            this.btnClearAddProduct.CustomImages.Parent = this.btnClearAddProduct;
            this.btnClearAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClearAddProduct.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClearAddProduct.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnClearAddProduct.HoverState.Parent = this.btnClearAddProduct;
            this.btnClearAddProduct.Location = new System.Drawing.Point(298, 296);
            this.btnClearAddProduct.Name = "btnClearAddProduct";
            this.btnClearAddProduct.ShadowDecoration.Parent = this.btnClearAddProduct;
            this.btnClearAddProduct.Size = new System.Drawing.Size(88, 36);
            this.btnClearAddProduct.TabIndex = 10;
            this.btnClearAddProduct.Text = "Clear";
            this.btnClearAddProduct.Click += new System.EventHandler(this.btnClearAddProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BorderColor = System.Drawing.Color.White;
            this.btnAddProduct.BorderRadius = 15;
            this.btnAddProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnAddProduct.BorderThickness = 2;
            this.btnAddProduct.CheckedState.Parent = this.btnAddProduct;
            this.btnAddProduct.CustomImages.Parent = this.btnAddProduct;
            this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnAddProduct.HoverState.Parent = this.btnAddProduct;
            this.btnAddProduct.Location = new System.Drawing.Point(392, 296);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.ShadowDecoration.Parent = this.btnAddProduct;
            this.btnAddProduct.Size = new System.Drawing.Size(88, 36);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblCategoryError
            // 
            this.lblCategoryError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblCategoryError.BackgroundImage")));
            this.lblCategoryError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblCategoryError.BorderColor = System.Drawing.Color.Transparent;
            this.lblCategoryError.BorderRadius = 15;
            this.lblCategoryError.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblCategoryError.BorderThickness = 2;
            this.lblCategoryError.CheckedState.Parent = this.lblCategoryError;
            this.lblCategoryError.CustomImages.Parent = this.lblCategoryError;
            this.lblCategoryError.FillColor = System.Drawing.Color.Transparent;
            this.lblCategoryError.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCategoryError.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblCategoryError.HoverState.Parent = this.lblCategoryError;
            this.lblCategoryError.Location = new System.Drawing.Point(495, 51);
            this.lblCategoryError.Name = "lblCategoryError";
            this.lblCategoryError.ShadowDecoration.Parent = this.lblCategoryError;
            this.lblCategoryError.Size = new System.Drawing.Size(25, 25);
            this.lblCategoryError.TabIndex = 22;
            this.lblCategoryError.Visible = false;
            // 
            // lblProductNameError
            // 
            this.lblProductNameError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblProductNameError.BackgroundImage")));
            this.lblProductNameError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblProductNameError.BorderColor = System.Drawing.Color.Transparent;
            this.lblProductNameError.BorderRadius = 15;
            this.lblProductNameError.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblProductNameError.BorderThickness = 2;
            this.lblProductNameError.CheckedState.Parent = this.lblProductNameError;
            this.lblProductNameError.CustomImages.Parent = this.lblProductNameError;
            this.lblProductNameError.FillColor = System.Drawing.Color.Transparent;
            this.lblProductNameError.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProductNameError.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblProductNameError.HoverState.Parent = this.lblProductNameError;
            this.lblProductNameError.Location = new System.Drawing.Point(495, 101);
            this.lblProductNameError.Name = "lblProductNameError";
            this.lblProductNameError.ShadowDecoration.Parent = this.lblProductNameError;
            this.lblProductNameError.Size = new System.Drawing.Size(25, 25);
            this.lblProductNameError.TabIndex = 23;
            this.lblProductNameError.Visible = false;
            // 
            // lblBrandError
            // 
            this.lblBrandError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblBrandError.BackgroundImage")));
            this.lblBrandError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblBrandError.BorderColor = System.Drawing.Color.Transparent;
            this.lblBrandError.BorderRadius = 15;
            this.lblBrandError.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblBrandError.BorderThickness = 2;
            this.lblBrandError.CheckedState.Parent = this.lblBrandError;
            this.lblBrandError.CustomImages.Parent = this.lblBrandError;
            this.lblBrandError.FillColor = System.Drawing.Color.Transparent;
            this.lblBrandError.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBrandError.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblBrandError.HoverState.Parent = this.lblBrandError;
            this.lblBrandError.Location = new System.Drawing.Point(495, 151);
            this.lblBrandError.Name = "lblBrandError";
            this.lblBrandError.ShadowDecoration.Parent = this.lblBrandError;
            this.lblBrandError.Size = new System.Drawing.Size(25, 25);
            this.lblBrandError.TabIndex = 24;
            this.lblBrandError.Visible = false;
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
            this.lblPriceError.Location = new System.Drawing.Point(495, 201);
            this.lblPriceError.Name = "lblPriceError";
            this.lblPriceError.ShadowDecoration.Parent = this.lblPriceError;
            this.lblPriceError.Size = new System.Drawing.Size(25, 25);
            this.lblPriceError.TabIndex = 25;
            this.lblPriceError.Visible = false;
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
            this.lblStockError.Location = new System.Drawing.Point(495, 251);
            this.lblStockError.Name = "lblStockError";
            this.lblStockError.ShadowDecoration.Parent = this.lblStockError;
            this.lblStockError.Size = new System.Drawing.Size(25, 25);
            this.lblStockError.TabIndex = 26;
            this.lblStockError.Visible = false;
            // 
            // AddProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblStockError);
            this.Controls.Add(this.lblPriceError);
            this.Controls.Add(this.lblBrandError);
            this.Controls.Add(this.lblProductNameError);
            this.Controls.Add(this.lblCategoryError);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnClearAddProduct);
            this.Controls.Add(this.txtEnterStock);
            this.Controls.Add(this.txtEnterPrice);
            this.Controls.Add(this.TxtEnterBrand);
            this.Controls.Add(this.txtEnterProductName);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboxProductCategory);
            this.Name = "AddProductUC";
            this.Size = new System.Drawing.Size(565, 387);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cboxProductCategory;
        private Guna.UI2.WinForms.Guna2TileButton lblCategory;
        private Guna.UI2.WinForms.Guna2TileButton lblProductName;
        private Guna.UI2.WinForms.Guna2TileButton lblBrand;
        private Guna.UI2.WinForms.Guna2TileButton lblPrice;
        private Guna.UI2.WinForms.Guna2TileButton lblStock;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterProductName;
        private Guna.UI2.WinForms.Guna2TextBox TxtEnterBrand;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterStock;
        private Guna.UI2.WinForms.Guna2Button btnClearAddProduct;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private Guna.UI2.WinForms.Guna2TileButton lblCategoryError;
        private Guna.UI2.WinForms.Guna2TileButton lblProductNameError;
        private Guna.UI2.WinForms.Guna2TileButton lblBrandError;
        private Guna.UI2.WinForms.Guna2TileButton lblPriceError;
        private Guna.UI2.WinForms.Guna2TileButton lblStockError;
    }
}
