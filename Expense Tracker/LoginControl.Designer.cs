namespace Expense_Tracker
{
    partial class LoginControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(127, 37);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(227, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(127, 78);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(227, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(16, 41);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(16, 81);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(115, 110);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 42);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegister.Location = new System.Drawing.Point(115, 160);
            this.lnkRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(61, 17);
            this.lnkRegister.TabIndex = 7;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Register";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRegister_LinkClicked);
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForgotPassword.Location = new System.Drawing.Point(200, 160);
            this.lnkForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(122, 17);
            this.lnkForgotPassword.TabIndex = 8;
            this.lnkForgotPassword.TabStop = true;
            this.lnkForgotPassword.Text = "Forgot Password?";
            this.lnkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkForgotPassword_LinkClicked);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.lnkForgotPassword);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(400, 197);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
    }
}
