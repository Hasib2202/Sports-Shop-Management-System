namespace SportsShopManagement
{
    partial class MessageUC
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
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.btnMessageRead = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminSendMessage = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // pnlMessage
            // 
            this.pnlMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessage.Location = new System.Drawing.Point(3, 3);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(394, 554);
            this.pnlMessage.TabIndex = 0;
            // 
            // btnMessageRead
            // 
            this.btnMessageRead.BorderColor = System.Drawing.Color.White;
            this.btnMessageRead.BorderRadius = 15;
            this.btnMessageRead.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnMessageRead.BorderThickness = 2;
            this.btnMessageRead.CheckedState.Parent = this.btnMessageRead;
            this.btnMessageRead.CustomImages.Parent = this.btnMessageRead;
            this.btnMessageRead.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMessageRead.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageRead.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnMessageRead.HoverState.Parent = this.btnMessageRead;
            this.btnMessageRead.Location = new System.Drawing.Point(414, 440);
            this.btnMessageRead.Name = "btnMessageRead";
            this.btnMessageRead.ShadowDecoration.Parent = this.btnMessageRead;
            this.btnMessageRead.Size = new System.Drawing.Size(168, 36);
            this.btnMessageRead.TabIndex = 1;
            this.btnMessageRead.Text = "View Message";
            // 
            // btnAdminSendMessage
            // 
            this.btnAdminSendMessage.BorderColor = System.Drawing.Color.White;
            this.btnAdminSendMessage.BorderRadius = 15;
            this.btnAdminSendMessage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnAdminSendMessage.BorderThickness = 2;
            this.btnAdminSendMessage.CheckedState.Parent = this.btnAdminSendMessage;
            this.btnAdminSendMessage.CustomImages.Parent = this.btnAdminSendMessage;
            this.btnAdminSendMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdminSendMessage.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSendMessage.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnAdminSendMessage.HoverState.Parent = this.btnAdminSendMessage;
            this.btnAdminSendMessage.Location = new System.Drawing.Point(414, 494);
            this.btnAdminSendMessage.Name = "btnAdminSendMessage";
            this.btnAdminSendMessage.ShadowDecoration.Parent = this.btnAdminSendMessage;
            this.btnAdminSendMessage.Size = new System.Drawing.Size(168, 36);
            this.btnAdminSendMessage.TabIndex = 2;
            this.btnAdminSendMessage.Text = "Send Message";
            // 
            // MessageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAdminSendMessage);
            this.Controls.Add(this.btnMessageRead);
            this.Controls.Add(this.pnlMessage);
            this.Name = "MessageUC";
            this.Size = new System.Drawing.Size(600, 560);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMessage;
        private Guna.UI2.WinForms.Guna2Button btnMessageRead;
        private Guna.UI2.WinForms.Guna2Button btnAdminSendMessage;
    }
}
