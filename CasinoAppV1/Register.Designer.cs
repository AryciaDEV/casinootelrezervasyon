namespace CasinoAppV1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnSignAccount = new System.Windows.Forms.Button();
            this.lblRegAcc = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.showPassword_Reg = new System.Windows.Forms.CheckBox();
            this.lblRegisterTitle = new System.Windows.Forms.Label();
            this.tboxPassword_Reg = new System.Windows.Forms.TextBox();
            this.lblPassword_Reg = new System.Windows.Forms.Label();
            this.tboxUserID_Reg = new System.Windows.Forms.TextBox();
            this.lblUserID_Reg = new System.Windows.Forms.Label();
            this.tboxAgainPassword_Reg = new System.Windows.Forms.TextBox();
            this.lblAgainPassword_Reg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignAccount
            // 
            this.btnSignAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnSignAccount.FlatAppearance.BorderSize = 0;
            this.btnSignAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnSignAccount.Location = new System.Drawing.Point(106, 563);
            this.btnSignAccount.Name = "btnSignAccount";
            this.btnSignAccount.Size = new System.Drawing.Size(222, 33);
            this.btnSignAccount.TabIndex = 17;
            this.btnSignAccount.Text = "Hemen oturum açın!";
            this.btnSignAccount.UseVisualStyleBackColor = false;
            this.btnSignAccount.Click += new System.EventHandler(this.btnSignAccount_Click);
            // 
            // lblRegAcc
            // 
            this.lblRegAcc.AutoSize = true;
            this.lblRegAcc.Location = new System.Drawing.Point(137, 538);
            this.lblRegAcc.Name = "lblRegAcc";
            this.lblRegAcc.Size = new System.Drawing.Size(150, 23);
            this.lblRegAcc.TabIndex = 16;
            this.lblRegAcc.Text = "Hesabınız var mı?";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(106, 473);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(216, 48);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "KAYIT OL";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // showPassword_Reg
            // 
            this.showPassword_Reg.AutoSize = true;
            this.showPassword_Reg.Location = new System.Drawing.Point(171, 418);
            this.showPassword_Reg.Name = "showPassword_Reg";
            this.showPassword_Reg.Size = new System.Drawing.Size(152, 27);
            this.showPassword_Reg.TabIndex = 14;
            this.showPassword_Reg.Text = "Parolayı Göster";
            this.showPassword_Reg.UseVisualStyleBackColor = true;
            this.showPassword_Reg.CheckedChanged += new System.EventHandler(this.showPassword_Reg_CheckedChanged);
            // 
            // lblRegisterTitle
            // 
            this.lblRegisterTitle.AutoSize = true;
            this.lblRegisterTitle.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.lblRegisterTitle.Location = new System.Drawing.Point(100, 60);
            this.lblRegisterTitle.Name = "lblRegisterTitle";
            this.lblRegisterTitle.Size = new System.Drawing.Size(170, 33);
            this.lblRegisterTitle.TabIndex = 9;
            this.lblRegisterTitle.Text = "Kayıt Olun";
            // 
            // tboxPassword_Reg
            // 
            this.tboxPassword_Reg.BackColor = System.Drawing.Color.Gainsboro;
            this.tboxPassword_Reg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxPassword_Reg.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxPassword_Reg.Location = new System.Drawing.Point(106, 273);
            this.tboxPassword_Reg.MaxLength = 15;
            this.tboxPassword_Reg.Name = "tboxPassword_Reg";
            this.tboxPassword_Reg.PasswordChar = '*';
            this.tboxPassword_Reg.Size = new System.Drawing.Size(216, 33);
            this.tboxPassword_Reg.TabIndex = 21;
            // 
            // lblPassword_Reg
            // 
            this.lblPassword_Reg.AutoSize = true;
            this.lblPassword_Reg.Location = new System.Drawing.Point(106, 243);
            this.lblPassword_Reg.Name = "lblPassword_Reg";
            this.lblPassword_Reg.Size = new System.Drawing.Size(64, 23);
            this.lblPassword_Reg.TabIndex = 20;
            this.lblPassword_Reg.Text = "Parola:";
            // 
            // tboxUserID_Reg
            // 
            this.tboxUserID_Reg.BackColor = System.Drawing.Color.Gainsboro;
            this.tboxUserID_Reg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxUserID_Reg.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxUserID_Reg.Location = new System.Drawing.Point(106, 183);
            this.tboxUserID_Reg.MaxLength = 15;
            this.tboxUserID_Reg.Name = "tboxUserID_Reg";
            this.tboxUserID_Reg.Size = new System.Drawing.Size(216, 33);
            this.tboxUserID_Reg.TabIndex = 19;
            // 
            // lblUserID_Reg
            // 
            this.lblUserID_Reg.AutoSize = true;
            this.lblUserID_Reg.Location = new System.Drawing.Point(106, 153);
            this.lblUserID_Reg.Name = "lblUserID_Reg";
            this.lblUserID_Reg.Size = new System.Drawing.Size(116, 23);
            this.lblUserID_Reg.TabIndex = 18;
            this.lblUserID_Reg.Text = "Kullanıcı Adı:";
            // 
            // tboxAgainPassword_Reg
            // 
            this.tboxAgainPassword_Reg.BackColor = System.Drawing.Color.Gainsboro;
            this.tboxAgainPassword_Reg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxAgainPassword_Reg.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxAgainPassword_Reg.Location = new System.Drawing.Point(106, 363);
            this.tboxAgainPassword_Reg.MaxLength = 15;
            this.tboxAgainPassword_Reg.Name = "tboxAgainPassword_Reg";
            this.tboxAgainPassword_Reg.PasswordChar = '*';
            this.tboxAgainPassword_Reg.Size = new System.Drawing.Size(216, 33);
            this.tboxAgainPassword_Reg.TabIndex = 23;
            // 
            // lblAgainPassword_Reg
            // 
            this.lblAgainPassword_Reg.AutoSize = true;
            this.lblAgainPassword_Reg.Location = new System.Drawing.Point(106, 333);
            this.lblAgainPassword_Reg.Name = "lblAgainPassword_Reg";
            this.lblAgainPassword_Reg.Size = new System.Drawing.Size(138, 23);
            this.lblAgainPassword_Reg.TabIndex = 22;
            this.lblAgainPassword_Reg.Text = "Parolayı Onayla:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 655);
            this.Controls.Add(this.tboxAgainPassword_Reg);
            this.Controls.Add(this.lblAgainPassword_Reg);
            this.Controls.Add(this.tboxPassword_Reg);
            this.Controls.Add(this.lblPassword_Reg);
            this.Controls.Add(this.tboxUserID_Reg);
            this.Controls.Add(this.lblUserID_Reg);
            this.Controls.Add(this.btnSignAccount);
            this.Controls.Add(this.lblRegAcc);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.showPassword_Reg);
            this.Controls.Add(this.lblRegisterTitle);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignAccount;
        private System.Windows.Forms.Label lblRegAcc;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox showPassword_Reg;
        private System.Windows.Forms.Label lblRegisterTitle;
        private System.Windows.Forms.TextBox tboxPassword_Reg;
        private System.Windows.Forms.Label lblPassword_Reg;
        private System.Windows.Forms.TextBox tboxUserID_Reg;
        private System.Windows.Forms.Label lblUserID_Reg;
        private System.Windows.Forms.TextBox tboxAgainPassword_Reg;
        private System.Windows.Forms.Label lblAgainPassword_Reg;
    }
}