namespace SportsShopManagement
{
    partial class SellerMessageUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSellerSendMessage = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellerViewMessage = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 554);
            this.panel1.TabIndex = 0;
            // 
            // btnSellerSendMessage
            // 
            this.btnSellerSendMessage.BorderColor = System.Drawing.Color.White;
            this.btnSellerSendMessage.BorderRadius = 15;
            this.btnSellerSendMessage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSellerSendMessage.BorderThickness = 2;
            this.btnSellerSendMessage.CheckedState.Parent = this.btnSellerSendMessage;
            this.btnSellerSendMessage.CustomImages.Parent = this.btnSellerSendMessage;
            this.btnSellerSendMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSellerSendMessage.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellerSendMessage.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSellerSendMessage.HoverState.Parent = this.btnSellerSendMessage;
            this.btnSellerSendMessage.Location = new System.Drawing.Point(414, 494);
            this.btnSellerSendMessage.Name = "btnSellerSendMessage";
            this.btnSellerSendMessage.ShadowDecoration.Parent = this.btnSellerSendMessage;
            this.btnSellerSendMessage.Size = new System.Drawing.Size(168, 36);
            this.btnSellerSendMessage.TabIndex = 3;
            this.btnSellerSendMessage.Text = "Send Message";
            // 
            // btnSellerViewMessage
            // 
            this.btnSellerViewMessage.BorderColor = System.Drawing.Color.White;
            this.btnSellerViewMessage.BorderRadius = 15;
            this.btnSellerViewMessage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSellerViewMessage.BorderThickness = 2;
            this.btnSellerViewMessage.CheckedState.Parent = this.btnSellerViewMessage;
            this.btnSellerViewMessage.CustomImages.Parent = this.btnSellerViewMessage;
            this.btnSellerViewMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSellerViewMessage.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellerViewMessage.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSellerViewMessage.HoverState.Parent = this.btnSellerViewMessage;
            this.btnSellerViewMessage.Location = new System.Drawing.Point(414, 440);
            this.btnSellerViewMessage.Name = "btnSellerViewMessage";
            this.btnSellerViewMessage.ShadowDecoration.Parent = this.btnSellerViewMessage;
            this.btnSellerViewMessage.Size = new System.Drawing.Size(168, 36);
            this.btnSellerViewMessage.TabIndex = 4;
            this.btnSellerViewMessage.Text = "View Message";
            // 
            // SellerMessageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnSellerViewMessage);
            this.Controls.Add(this.btnSellerSendMessage);
            this.Controls.Add(this.panel1);
            this.Name = "SellerMessageUC";
            this.Size = new System.Drawing.Size(600, 560);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSellerSendMessage;
        private Guna.UI2.WinForms.Guna2Button btnSellerViewMessage;
    }
}
