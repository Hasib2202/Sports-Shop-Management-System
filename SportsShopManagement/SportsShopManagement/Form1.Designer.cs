namespace SportsShopManagement
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseTab = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtboxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.btnShowPassword = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.kryptonBorderEdge1);
            this.panel1.Controls.Add(this.btnCloseTab);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 560);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.BackColor = System.Drawing.Color.Black;
            this.btnCloseTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCloseTab.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseTab.BorderRadius = 19;
            this.btnCloseTab.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnCloseTab.CheckedState.Parent = this.btnCloseTab;
            this.btnCloseTab.CustomImages.Parent = this.btnCloseTab;
            this.btnCloseTab.FillColor = System.Drawing.Color.White;
            this.btnCloseTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseTab.ForeColor = System.Drawing.Color.White;
            this.btnCloseTab.HoverState.Parent = this.btnCloseTab;
            this.btnCloseTab.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseTab.Image")));
            this.btnCloseTab.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCloseTab.Location = new System.Drawing.Point(791, -2);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.ShadowDecoration.Parent = this.btnCloseTab;
            this.btnCloseTab.Size = new System.Drawing.Size(51, 53);
            this.btnCloseTab.TabIndex = 2;
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnShowPassword);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtboxPassword);
            this.panel2.Controls.Add(this.txtboxUsername);
            this.panel2.Location = new System.Drawing.Point(242, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 278);
            this.panel2.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(141, 195);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BorderRadius = 10;
            this.txtboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxPassword.DefaultText = "Password";
            this.txtboxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxPassword.DisabledState.Parent = this.txtboxPassword;
            this.txtboxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPassword.FocusedState.Parent = this.txtboxPassword;
            this.txtboxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPassword.HoverState.Parent = this.txtboxPassword;
            this.txtboxPassword.Location = new System.Drawing.Point(78, 120);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '\0';
            this.txtboxPassword.PlaceholderText = "";
            this.txtboxPassword.SelectedText = "";
            this.txtboxPassword.SelectionStart = 8;
            this.txtboxPassword.ShadowDecoration.Parent = this.txtboxPassword;
            this.txtboxPassword.Size = new System.Drawing.Size(200, 36);
            this.txtboxPassword.TabIndex = 1;
            this.txtboxPassword.TextOffset = new System.Drawing.Point(5, 0);
            this.txtboxPassword.TextChanged += new System.EventHandler(this.txtboxPassword_TextChanged);
            this.txtboxPassword.Enter += new System.EventHandler(this.txtboxPassword_Enter);
            this.txtboxPassword.Leave += new System.EventHandler(this.txtboxPassword_Leave);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BorderRadius = 10;
            this.txtboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxUsername.DefaultText = "Username";
            this.txtboxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxUsername.DisabledState.Parent = this.txtboxUsername;
            this.txtboxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxUsername.FocusedState.Parent = this.txtboxUsername;
            this.txtboxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxUsername.HoverState.Parent = this.txtboxUsername;
            this.txtboxUsername.Location = new System.Drawing.Point(78, 60);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.PasswordChar = '\0';
            this.txtboxUsername.PlaceholderText = "";
            this.txtboxUsername.SelectedText = "";
            this.txtboxUsername.SelectionStart = 8;
            this.txtboxUsername.ShadowDecoration.Parent = this.txtboxUsername;
            this.txtboxUsername.Size = new System.Drawing.Size(200, 36);
            this.txtboxUsername.TabIndex = 0;
            this.txtboxUsername.TextOffset = new System.Drawing.Point(5, 0);
            this.txtboxUsername.TextChanged += new System.EventHandler(this.txtboxUsername_TextChanged);
            this.txtboxUsername.Enter += new System.EventHandler(this.txtboxUsername_Enter);
            this.txtboxUsername.Leave += new System.EventHandler(this.txtboxUsername_Leave);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(808, 149);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(50, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BorderRadius = 10;
            this.btnShowPassword.CheckedState.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowPassword.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPassword.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnShowPassword.CheckedState.Parent = this.btnShowPassword;
            this.btnShowPassword.CustomImages.Parent = this.btnShowPassword;
            this.btnShowPassword.FillColor = System.Drawing.Color.Gray;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPassword.ForeColor = System.Drawing.Color.White;
            this.btnShowPassword.HoverState.Parent = this.btnShowPassword;
            this.btnShowPassword.Location = new System.Drawing.Point(213, 159);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.ShadowDecoration.Parent = this.btnShowPassword;
            this.btnShowPassword.Size = new System.Drawing.Size(65, 18);
            this.btnShowPassword.TabIndex = 3;
            this.btnShowPassword.Text = "Show";
            this.btnShowPassword.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(840, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtboxPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtboxUsername;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnCloseTab;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Guna.UI2.WinForms.Guna2Button btnShowPassword;
    }
}

