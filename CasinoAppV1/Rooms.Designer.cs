namespace CasinoAppV1
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblUsername_Search = new System.Windows.Forms.Label();
            this.tBoxOdaType_Search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRoom = new System.Windows.Forms.Label();
            this.btnRoomCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxRoomCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxRoomName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnListe);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.lblUsername_Search);
            this.panel1.Controls.Add(this.tBoxOdaType_Search);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 276);
            this.panel1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(13, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 180);
            this.dataGridView1.TabIndex = 47;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Adı";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "lastname";
            this.Column3.HeaderText = "Soyadı";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "phonenumber";
            this.Column4.HeaderText = "Telefon Numarası";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "roomtype";
            this.Column7.HeaderText = "Oda Tipi";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
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
            this.lblSearch.Size = new System.Drawing.Size(96, 23);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Oda Sorgu";
            // 
            // lblUsername_Search
            // 
            this.lblUsername_Search.AutoSize = true;
            this.lblUsername_Search.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername_Search.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsername_Search.Location = new System.Drawing.Point(12, 40);
            this.lblUsername_Search.Name = "lblUsername_Search";
            this.lblUsername_Search.Size = new System.Drawing.Size(62, 17);
            this.lblUsername_Search.TabIndex = 8;
            this.lblUsername_Search.Text = "Oda Adı:";
            // 
            // tBoxOdaType_Search
            // 
            this.tBoxOdaType_Search.Location = new System.Drawing.Point(12, 60);
            this.tBoxOdaType_Search.Multiline = true;
            this.tBoxOdaType_Search.Name = "tBoxOdaType_Search";
            this.tBoxOdaType_Search.Size = new System.Drawing.Size(125, 20);
            this.tBoxOdaType_Search.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblTotalRoom);
            this.panel2.Controls.Add(this.btnRoomCalculate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tBoxRoomCount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tBoxRoomName);
            this.panel2.Location = new System.Drawing.Point(13, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 189);
            this.panel2.TabIndex = 47;
            // 
            // lblTotalRoom
            // 
            this.lblTotalRoom.AutoSize = true;
            this.lblTotalRoom.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRoom.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalRoom.Location = new System.Drawing.Point(202, 106);
            this.lblTotalRoom.Name = "lblTotalRoom";
            this.lblTotalRoom.Size = new System.Drawing.Size(63, 23);
            this.lblTotalRoom.TabIndex = 51;
            this.lblTotalRoom.Text = "Sonuç:";
            // 
            // btnRoomCalculate
            // 
            this.btnRoomCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnRoomCalculate.FlatAppearance.BorderSize = 0;
            this.btnRoomCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomCalculate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomCalculate.ForeColor = System.Drawing.Color.White;
            this.btnRoomCalculate.Image = ((System.Drawing.Image)(resources.GetObject("btnRoomCalculate.Image")));
            this.btnRoomCalculate.Location = new System.Drawing.Point(206, 36);
            this.btnRoomCalculate.Name = "btnRoomCalculate";
            this.btnRoomCalculate.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnRoomCalculate.Size = new System.Drawing.Size(130, 45);
            this.btnRoomCalculate.TabIndex = 47;
            this.btnRoomCalculate.Text = "Hesapla";
            this.btnRoomCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRoomCalculate.UseVisualStyleBackColor = false;
            this.btnRoomCalculate.Click += new System.EventHandler(this.btnRoomCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Toplam Oda Sayısı:";
            // 
            // tBoxRoomCount
            // 
            this.tBoxRoomCount.Location = new System.Drawing.Point(14, 109);
            this.tBoxRoomCount.Multiline = true;
            this.tBoxRoomCount.Name = "tBoxRoomCount";
            this.tBoxRoomCount.Size = new System.Drawing.Size(125, 20);
            this.tBoxRoomCount.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Oda Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Boş Oda Sayısı Sorgu";
            // 
            // tBoxRoomName
            // 
            this.tBoxRoomName.Location = new System.Drawing.Point(14, 56);
            this.tBoxRoomName.Multiline = true;
            this.tBoxRoomName.Name = "tBoxRoomName";
            this.tBoxRoomName.Size = new System.Drawing.Size(125, 20);
            this.tBoxRoomName.TabIndex = 47;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(935, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblUsername_Search;
        private System.Windows.Forms.TextBox tBoxOdaType_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRoom;
        private System.Windows.Forms.Button btnRoomCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxRoomCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxRoomName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}