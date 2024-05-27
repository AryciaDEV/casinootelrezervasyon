namespace CasinoAppV1
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.tboxPassword_Add = new System.Windows.Forms.TextBox();
            this.lblPassword_Add = new System.Windows.Forms.Label();
            this.lblUsername_Add = new System.Windows.Forms.Label();
            this.tBoxUsername_Add = new System.Windows.Forms.TextBox();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsername_Search = new System.Windows.Forms.Label();
            this.tBoxUsername_Search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tBoxID_Update = new System.Windows.Forms.TextBox();
            this.lblID_Update = new System.Windows.Forms.Label();
            this.tboxPassword_Update = new System.Windows.Forms.TextBox();
            this.lblPassword_Update = new System.Windows.Forms.Label();
            this.lblUsername_Update = new System.Windows.Forms.Label();
            this.tBoxUsername_Update = new System.Windows.Forms.TextBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.btnUserAdd);
            this.panel5.Controls.Add(this.tboxPassword_Add);
            this.panel5.Controls.Add(this.lblPassword_Add);
            this.panel5.Controls.Add(this.lblUsername_Add);
            this.panel5.Controls.Add(this.tBoxUsername_Add);
            this.panel5.Controls.Add(this.lblAddUser);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(910, 88);
            this.panel5.TabIndex = 17;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnUserAdd.FlatAppearance.BorderSize = 0;
            this.btnUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdd.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdd.ForeColor = System.Drawing.Color.White;
            this.btnUserAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAdd.Image")));
            this.btnUserAdd.Location = new System.Drawing.Point(352, 35);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnUserAdd.Size = new System.Drawing.Size(130, 45);
            this.btnUserAdd.TabIndex = 39;
            this.btnUserAdd.Text = "Ekle";
            this.btnUserAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // tboxPassword_Add
            // 
            this.tboxPassword_Add.Location = new System.Drawing.Point(182, 60);
            this.tboxPassword_Add.Multiline = true;
            this.tboxPassword_Add.Name = "tboxPassword_Add";
            this.tboxPassword_Add.Size = new System.Drawing.Size(125, 20);
            this.tboxPassword_Add.TabIndex = 10;
            // 
            // lblPassword_Add
            // 
            this.lblPassword_Add.AutoSize = true;
            this.lblPassword_Add.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword_Add.ForeColor = System.Drawing.Color.LightGray;
            this.lblPassword_Add.Location = new System.Drawing.Point(182, 38);
            this.lblPassword_Add.Name = "lblPassword_Add";
            this.lblPassword_Add.Size = new System.Drawing.Size(43, 17);
            this.lblPassword_Add.TabIndex = 9;
            this.lblPassword_Add.Text = "Şifre:";
            // 
            // lblUsername_Add
            // 
            this.lblUsername_Add.AutoSize = true;
            this.lblUsername_Add.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername_Add.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsername_Add.Location = new System.Drawing.Point(12, 40);
            this.lblUsername_Add.Name = "lblUsername_Add";
            this.lblUsername_Add.Size = new System.Drawing.Size(90, 17);
            this.lblUsername_Add.TabIndex = 8;
            this.lblUsername_Add.Text = "Kullanıcı Adı:";
            // 
            // tBoxUsername_Add
            // 
            this.tBoxUsername_Add.Location = new System.Drawing.Point(12, 60);
            this.tBoxUsername_Add.Multiline = true;
            this.tBoxUsername_Add.Name = "tBoxUsername_Add";
            this.tBoxUsername_Add.Size = new System.Drawing.Size(125, 20);
            this.tBoxUsername_Add.TabIndex = 7;
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblAddUser.Location = new System.Drawing.Point(8, 10);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(116, 23);
            this.lblAddUser.TabIndex = 6;
            this.lblAddUser.Text = "Kullanıcı Ekle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnListe);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblUsername_Search);
            this.panel1.Controls.Add(this.tBoxUsername_Search);
            this.panel1.Location = new System.Drawing.Point(13, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 276);
            this.panel1.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(181, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnSearch.Size = new System.Drawing.Size(130, 45);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Ara";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnListe
            // 
            this.btnListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnListe.FlatAppearance.BorderSize = 0;
            this.btnListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListe.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListe.ForeColor = System.Drawing.Color.White;
            this.btnListe.Image = ((System.Drawing.Image)(resources.GetObject("btnListe.Image")));
            this.btnListe.Location = new System.Drawing.Point(765, 35);
            this.btnListe.Name = "btnListe";
            this.btnListe.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnListe.Size = new System.Drawing.Size(130, 45);
            this.btnListe.TabIndex = 45;
            this.btnListe.Text = "Listele";
            this.btnListe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnListe.UseVisualStyleBackColor = false;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.LightGray;
            this.lblSearch.Location = new System.Drawing.Point(8, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(145, 23);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Kullanıcı Sorgula";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(14, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 175);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 95F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "username";
            this.Column2.FillWeight = 250F;
            this.Column2.HeaderText = "KullanıcıAdı";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "password";
            this.Column3.FillWeight = 250F;
            this.Column3.HeaderText = "Şifre";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 350;
            // 
            // lblUsername_Search
            // 
            this.lblUsername_Search.AutoSize = true;
            this.lblUsername_Search.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername_Search.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsername_Search.Location = new System.Drawing.Point(12, 40);
            this.lblUsername_Search.Name = "lblUsername_Search";
            this.lblUsername_Search.Size = new System.Drawing.Size(90, 17);
            this.lblUsername_Search.TabIndex = 8;
            this.lblUsername_Search.Text = "Kullanıcı Adı:";
            // 
            // tBoxUsername_Search
            // 
            this.tBoxUsername_Search.Location = new System.Drawing.Point(12, 60);
            this.tBoxUsername_Search.Multiline = true;
            this.tBoxUsername_Search.Name = "tBoxUsername_Search";
            this.tBoxUsername_Search.Size = new System.Drawing.Size(125, 20);
            this.tBoxUsername_Search.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.tBoxID_Update);
            this.panel2.Controls.Add(this.lblID_Update);
            this.panel2.Controls.Add(this.tboxPassword_Update);
            this.panel2.Controls.Add(this.lblPassword_Update);
            this.panel2.Controls.Add(this.lblUsername_Update);
            this.panel2.Controls.Add(this.tBoxUsername_Update);
            this.panel2.Controls.Add(this.lblUpdate);
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 89);
            this.panel2.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(692, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnDelete.Size = new System.Drawing.Size(130, 45);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(522, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnUpdate.Size = new System.Drawing.Size(130, 45);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tBoxID_Update
            // 
            this.tBoxID_Update.Location = new System.Drawing.Point(352, 60);
            this.tBoxID_Update.Multiline = true;
            this.tBoxID_Update.Name = "tBoxID_Update";
            this.tBoxID_Update.Size = new System.Drawing.Size(125, 20);
            this.tBoxID_Update.TabIndex = 16;
            // 
            // lblID_Update
            // 
            this.lblID_Update.AutoSize = true;
            this.lblID_Update.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_Update.ForeColor = System.Drawing.Color.LightGray;
            this.lblID_Update.Location = new System.Drawing.Point(352, 40);
            this.lblID_Update.Name = "lblID_Update";
            this.lblID_Update.Size = new System.Drawing.Size(26, 17);
            this.lblID_Update.TabIndex = 15;
            this.lblID_Update.Text = "ID:";
            // 
            // tboxPassword_Update
            // 
            this.tboxPassword_Update.Location = new System.Drawing.Point(182, 60);
            this.tboxPassword_Update.Multiline = true;
            this.tboxPassword_Update.Name = "tboxPassword_Update";
            this.tboxPassword_Update.Size = new System.Drawing.Size(125, 20);
            this.tboxPassword_Update.TabIndex = 12;
            // 
            // lblPassword_Update
            // 
            this.lblPassword_Update.AutoSize = true;
            this.lblPassword_Update.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword_Update.ForeColor = System.Drawing.Color.LightGray;
            this.lblPassword_Update.Location = new System.Drawing.Point(182, 40);
            this.lblPassword_Update.Name = "lblPassword_Update";
            this.lblPassword_Update.Size = new System.Drawing.Size(43, 17);
            this.lblPassword_Update.TabIndex = 11;
            this.lblPassword_Update.Text = "Şifre:";
            // 
            // lblUsername_Update
            // 
            this.lblUsername_Update.AutoSize = true;
            this.lblUsername_Update.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername_Update.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsername_Update.Location = new System.Drawing.Point(12, 40);
            this.lblUsername_Update.Name = "lblUsername_Update";
            this.lblUsername_Update.Size = new System.Drawing.Size(90, 17);
            this.lblUsername_Update.TabIndex = 8;
            this.lblUsername_Update.Text = "Kullanıcı Adı:";
            // 
            // tBoxUsername_Update
            // 
            this.tBoxUsername_Update.Location = new System.Drawing.Point(12, 60);
            this.tBoxUsername_Update.Multiline = true;
            this.tBoxUsername_Update.Name = "tBoxUsername_Update";
            this.tBoxUsername_Update.Size = new System.Drawing.Size(125, 20);
            this.tBoxUsername_Update.TabIndex = 7;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.LightGray;
            this.lblUpdate.Location = new System.Drawing.Point(8, 10);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(147, 23);
            this.lblUpdate.TabIndex = 6;
            this.lblUpdate.Text = "Kullanıcı Düzenle";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(935, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.TextBox tboxPassword_Add;
        private System.Windows.Forms.Label lblPassword_Add;
        private System.Windows.Forms.Label lblUsername_Add;
        private System.Windows.Forms.TextBox tBoxUsername_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUsername_Search;
        private System.Windows.Forms.TextBox tBoxUsername_Search;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tboxPassword_Update;
        private System.Windows.Forms.Label lblPassword_Update;
        private System.Windows.Forms.Label lblUsername_Update;
        private System.Windows.Forms.TextBox tBoxUsername_Update;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox tBoxID_Update;
        private System.Windows.Forms.Label lblID_Update;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnListe;
    }
}