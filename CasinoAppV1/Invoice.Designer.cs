namespace CasinoAppV1
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.rtBoxSendMailMessage = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxSendMailSubject = new System.Windows.Forms.TextBox();
            this.lblUsername_Search = new System.Windows.Forms.Label();
            this.tBoxSendMailAdress = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnSendMail);
            this.panel1.Controls.Add(this.rtBoxSendMailMessage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tBoxSendMailSubject);
            this.panel1.Controls.Add(this.lblUsername_Search);
            this.panel1.Controls.Add(this.tBoxSendMailAdress);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 471);
            this.panel1.TabIndex = 20;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnSendMail.FlatAppearance.BorderSize = 0;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Image = ((System.Drawing.Image)(resources.GetObject("btnSendMail.Image")));
            this.btnSendMail.Location = new System.Drawing.Point(12, 412);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnSendMail.Size = new System.Drawing.Size(130, 45);
            this.btnSendMail.TabIndex = 48;
            this.btnSendMail.Text = "Gönder";
            this.btnSendMail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // rtBoxSendMailMessage
            // 
            this.rtBoxSendMailMessage.Location = new System.Drawing.Point(12, 170);
            this.rtBoxSendMailMessage.Name = "rtBoxSendMailMessage";
            this.rtBoxSendMailMessage.Size = new System.Drawing.Size(885, 236);
            this.rtBoxSendMailMessage.TabIndex = 14;
            this.rtBoxSendMailMessage.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "E-posta İçeriği:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "E-posta Başlığı:";
            // 
            // tBoxSendMailSubject
            // 
            this.tBoxSendMailSubject.Location = new System.Drawing.Point(12, 115);
            this.tBoxSendMailSubject.Multiline = true;
            this.tBoxSendMailSubject.Name = "tBoxSendMailSubject";
            this.tBoxSendMailSubject.Size = new System.Drawing.Size(125, 20);
            this.tBoxSendMailSubject.TabIndex = 11;
            // 
            // lblUsername_Search
            // 
            this.lblUsername_Search.AutoSize = true;
            this.lblUsername_Search.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername_Search.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsername_Search.Location = new System.Drawing.Point(12, 40);
            this.lblUsername_Search.Name = "lblUsername_Search";
            this.lblUsername_Search.Size = new System.Drawing.Size(95, 17);
            this.lblUsername_Search.TabIndex = 10;
            this.lblUsername_Search.Text = "E-pota Adresi:";
            // 
            // tBoxSendMailAdress
            // 
            this.tBoxSendMailAdress.Location = new System.Drawing.Point(12, 60);
            this.tBoxSendMailAdress.Multiline = true;
            this.tBoxSendMailAdress.Name = "tBoxSendMailAdress";
            this.tBoxSendMailAdress.Size = new System.Drawing.Size(125, 20);
            this.tBoxSendMailAdress.TabIndex = 9;
            this.tBoxSendMailAdress.TextChanged += new System.EventHandler(this.tBoxSendMailAdress_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.LightGray;
            this.lblSearch.Location = new System.Drawing.Point(8, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(134, 23);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "E-posta Gönder";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(935, 495);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblUsername_Search;
        private System.Windows.Forms.TextBox tBoxSendMailAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxSendMailSubject;
        private System.Windows.Forms.RichTextBox rtBoxSendMailMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendMail;
    }
}