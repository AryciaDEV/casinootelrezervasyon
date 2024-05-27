namespace CasinoApp
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
            this.lblSignTitle = new System.Windows.Forms.Label();
            this.lblUserID_Log = new System.Windows.Forms.Label();
            this.tboxUserID_Log = new System.Windows.Forms.TextBox();
            this.tboxPassword_Log = new System.Windows.Forms.TextBox();
            this.lblPassword_Log = new System.Windows.Forms.Label();
            this.showPassword_Log = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSignAcc = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSignTitle
            // 
            this.lblSignTitle.AutoSize = true;
            this.lblSignTitle.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.lblSignTitle.Location = new System.Drawing.Point(100, 60);
            this.lblSignTitle.Name = "lblSignTitle";
            this.lblSignTitle.Size = new System.Drawing.Size(202, 33);
            this.lblSignTitle.TabIndex = 0;
            this.lblSignTitle.Text = "Oturum Açın";
            // 
            // lblUserID_Log
            // 
            this.lblUserID_Log.AutoSize = true;
            this.lblUserID_Log.Location = new System.Drawing.Point(106, 153);
            this.lblUserID_Log.Name = "lblUserID_Log";
            this.lblUserID_Log.Size = new System.Drawing.Size(116, 23);
            this.lblUserID_Log.TabIndex = 1;
            this.lblUserID_Log.Text = "Kullanıcı Adı:";
            // 
            // tboxUserID_Log
            // 
            this.tboxUserID_Log.BackColor = System.Drawing.Color.Gainsboro;
            this.tboxUserID_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxUserID_Log.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxUserID_Log.Location = new System.Drawing.Point(106, 183);
            this.tboxUserID_Log.MaxLength = 15;
            this.tboxUserID_Log.Name = "tboxUserID_Log";
            this.tboxUserID_Log.Size = new System.Drawing.Size(216, 33);
            this.tboxUserID_Log.TabIndex = 2;
            // 
            // tboxPassword_Log
            // 
            this.tboxPassword_Log.BackColor = System.Drawing.Color.Gainsboro;
            this.tboxPassword_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxPassword_Log.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxPassword_Log.Location = new System.Drawing.Point(106, 273);
            this.tboxPassword_Log.MaxLength = 15;
            this.tboxPassword_Log.Name = "tboxPassword_Log";
            this.tboxPassword_Log.PasswordChar = '*';
            this.tboxPassword_Log.Size = new System.Drawing.Size(216, 33);
            this.tboxPassword_Log.TabIndex = 4;
            // 
            // lblPassword_Log
            // 
            this.lblPassword_Log.AutoSize = true;
            this.lblPassword_Log.Location = new System.Drawing.Point(106, 243);
            this.lblPassword_Log.Name = "lblPassword_Log";
            this.lblPassword_Log.Size = new System.Drawing.Size(64, 23);
            this.lblPassword_Log.TabIndex = 3;
            this.lblPassword_Log.Text = "Parola:";
            // 
            // showPassword_Log
            // 
            this.showPassword_Log.AutoSize = true;
            this.showPassword_Log.Location = new System.Drawing.Point(171, 328);
            this.showPassword_Log.Name = "showPassword_Log";
            this.showPassword_Log.Size = new System.Drawing.Size(152, 27);
            this.showPassword_Log.TabIndex = 5;
            this.showPassword_Log.Text = "Parolayı Göster";
            this.showPassword_Log.UseVisualStyleBackColor = true;
            this.showPassword_Log.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(106, 383);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 48);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "OTURUM AÇ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSignAcc
            // 
            this.lblSignAcc.AutoSize = true;
            this.lblSignAcc.Location = new System.Drawing.Point(137, 448);
            this.lblSignAcc.Name = "lblSignAcc";
            this.lblSignAcc.Size = new System.Drawing.Size(159, 23);
            this.lblSignAcc.TabIndex = 7;
            this.lblSignAcc.Text = "Hesabınız yok mu?";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnCreateAccount.Location = new System.Drawing.Point(106, 473);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(222, 33);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Yeni bir hesap oluşturun!";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 655);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblSignAcc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.showPassword_Log);
            this.Controls.Add(this.tboxPassword_Log);
            this.Controls.Add(this.lblPassword_Log);
            this.Controls.Add(this.tboxUserID_Log);
            this.Controls.Add(this.lblUserID_Log);
            this.Controls.Add(this.lblSignTitle);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignTitle;
        private System.Windows.Forms.Label lblUserID_Log;
        private System.Windows.Forms.TextBox tboxUserID_Log;
        private System.Windows.Forms.TextBox tboxPassword_Log;
        private System.Windows.Forms.Label lblPassword_Log;
        private System.Windows.Forms.CheckBox showPassword_Log;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSignAcc;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}