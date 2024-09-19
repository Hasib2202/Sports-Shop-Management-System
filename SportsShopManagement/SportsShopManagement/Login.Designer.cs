namespace SportsShopManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInVisibl = new System.Windows.Forms.PictureBox();
            this.btnVisible = new System.Windows.Forms.PictureBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnExitLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtboxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInVisibl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisible)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 560);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnInVisibl);
            this.panel2.Controls.Add(this.btnVisible);
            this.panel2.Controls.Add(this.lblerror);
            this.panel2.Controls.Add(this.btnExitLogin);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtboxPassword);
            this.panel2.Controls.Add(this.txtboxUsername);
            this.panel2.Location = new System.Drawing.Point(242, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 278);
            this.panel2.TabIndex = 0;
            // 
            // btnInVisibl
            // 
            this.btnInVisibl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInVisibl.BackgroundImage")));
            this.btnInVisibl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInVisibl.Location = new System.Drawing.Point(284, 123);
            this.btnInVisibl.Name = "btnInVisibl";
            this.btnInVisibl.Size = new System.Drawing.Size(30, 30);
            this.btnInVisibl.TabIndex = 5;
            this.btnInVisibl.TabStop = false;
            this.btnInVisibl.Visible = false;
            this.btnInVisibl.Click += new System.EventHandler(this.btnInVisibl_Click);
            // 
            // btnVisible
            // 
            this.btnVisible.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisible.BackgroundImage")));
            this.btnVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisible.Location = new System.Drawing.Point(284, 123);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(30, 30);
            this.btnVisible.TabIndex = 4;
            this.btnVisible.TabStop = false;
            this.btnVisible.Visible = false;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(69, 220);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(217, 19);
            this.lblerror.TabIndex = 3;
            this.lblerror.Text = "Invalid Username And  Password";
            this.lblerror.Visible = false;
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.BorderColor = System.Drawing.Color.White;
            this.btnExitLogin.BorderRadius = 15;
            this.btnExitLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnExitLogin.BorderThickness = 2;
            this.btnExitLogin.CheckedState.Parent = this.btnExitLogin;
            this.btnExitLogin.CustomImages.Parent = this.btnExitLogin;
            this.btnExitLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExitLogin.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExitLogin.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExitLogin.HoverState.Parent = this.btnExitLogin;
            this.btnExitLogin.Location = new System.Drawing.Point(92, 170);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.ShadowDecoration.Parent = this.btnExitLogin;
            this.btnExitLogin.Size = new System.Drawing.Size(76, 35);
            this.btnExitLogin.TabIndex = 1;
            this.btnExitLogin.Text = "Exit";
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(184, 170);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(76, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BorderRadius = 10;
            this.txtboxPassword.BorderThickness = 0;
            this.txtboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxPassword.DefaultText = "Password";
            this.txtboxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxPassword.DisabledState.Parent = this.txtboxPassword;
            this.txtboxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPassword.FocusedState.Parent = this.txtboxPassword;
            this.txtboxPassword.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtboxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPassword.HoverState.Parent = this.txtboxPassword;
            this.txtboxPassword.Location = new System.Drawing.Point(78, 120);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '\0';
            this.txtboxPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtboxPassword.PlaceholderText = "";
            this.txtboxPassword.SelectedText = "";
            this.txtboxPassword.SelectionStart = 8;
            this.txtboxPassword.ShadowDecoration.Parent = this.txtboxPassword;
            this.txtboxPassword.Size = new System.Drawing.Size(200, 36);
            this.txtboxPassword.TabIndex = 5;
            this.txtboxPassword.TextOffset = new System.Drawing.Point(5, 0);
            this.txtboxPassword.TextChanged += new System.EventHandler(this.txtboxPassword_TextChanged);
            this.txtboxPassword.Enter += new System.EventHandler(this.txtboxPassword_Enter);
            this.txtboxPassword.Leave += new System.EventHandler(this.txtboxPassword_Leave);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BorderColor = System.Drawing.Color.White;
            this.txtboxUsername.BorderRadius = 10;
            this.txtboxUsername.BorderThickness = 0;
            this.txtboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxUsername.DefaultText = "Username";
            this.txtboxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxUsername.DisabledState.Parent = this.txtboxUsername;
            this.txtboxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxUsername.FocusedState.Parent = this.txtboxUsername;
            this.txtboxUsername.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtboxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxUsername.HoverState.Parent = this.txtboxUsername;
            this.txtboxUsername.Location = new System.Drawing.Point(78, 60);
            this.txtboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.PasswordChar = '\0';
            this.txtboxUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtboxUsername.PlaceholderText = "";
            this.txtboxUsername.SelectedText = "";
            this.txtboxUsername.SelectionStart = 8;
            this.txtboxUsername.ShadowDecoration.Parent = this.txtboxUsername;
            this.txtboxUsername.Size = new System.Drawing.Size(200, 36);
            this.txtboxUsername.TabIndex = 5;
            this.txtboxUsername.TextOffset = new System.Drawing.Point(5, 0);
            this.txtboxUsername.TextChanged += new System.EventHandler(this.txtboxUsername_TextChanged);
            this.txtboxUsername.Enter += new System.EventHandler(this.txtboxUsername_Enter);
            this.txtboxUsername.Leave += new System.EventHandler(this.txtboxUsername_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(840, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInVisibl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisible)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtboxPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtboxUsername;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnExitLogin;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.PictureBox btnInVisibl;
        private System.Windows.Forms.PictureBox btnVisible;
    }
}

