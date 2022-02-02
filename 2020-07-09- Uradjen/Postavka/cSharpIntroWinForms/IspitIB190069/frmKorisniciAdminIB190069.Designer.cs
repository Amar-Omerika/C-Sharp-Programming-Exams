namespace cSharpIntroWinForms.IspitIB190069
{
    partial class frmKorisniciAdminIB190069
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.cbSpol = new System.Windows.Forms.ComboBox();
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrator = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Slike = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.lblSumirano = new System.Windows.Forms.Label();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 25);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(452, 22);
            this.txtPretraga.TabIndex = 0;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // cbSpol
            // 
            this.cbSpol.FormattingEnabled = true;
            this.cbSpol.Location = new System.Drawing.Point(488, 23);
            this.cbSpol.Name = "cbSpol";
            this.cbSpol.Size = new System.Drawing.Size(121, 24);
            this.cbSpol.TabIndex = 1;
            this.cbSpol.SelectedIndexChanged += new System.EventHandler(this.cbSpol_SelectedIndexChanged);
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Location = new System.Drawing.Point(638, 25);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(113, 21);
            this.checkAdmin.TabIndex = 2;
            this.checkAdmin.Text = "Administrator";
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.AllowUserToAddRows = false;
            this.dgvPretraga.AllowUserToDeleteRows = false;
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Spol,
            this.KorisnickoIme,
            this.Administrator,
            this.Slike});
            this.dgvPretraga.Location = new System.Drawing.Point(12, 71);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.ReadOnly = true;
            this.dgvPretraga.RowHeadersWidth = 51;
            this.dgvPretraga.RowTemplate.Height = 24;
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(793, 221);
            this.dgvPretraga.TabIndex = 3;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPretraga_CellContentClick);
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 125;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 125;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.MinimumWidth = 6;
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            this.Spol.Width = 125;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "KorisnickoIme";
            this.KorisnickoIme.MinimumWidth = 6;
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            this.KorisnickoIme.Width = 125;
            // 
            // Administrator
            // 
            this.Administrator.DataPropertyName = "Admin";
            this.Administrator.HeaderText = "Administrator";
            this.Administrator.MinimumWidth = 6;
            this.Administrator.Name = "Administrator";
            this.Administrator.ReadOnly = true;
            this.Administrator.Width = 125;
            // 
            // Slike
            // 
            this.Slike.HeaderText = "";
            this.Slike.MinimumWidth = 6;
            this.Slike.Name = "Slike";
            this.Slike.ReadOnly = true;
            this.Slike.Text = "Slike";
            this.Slike.UseColumnTextForButtonValue = true;
            this.Slike.Width = 125;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(12, 325);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(171, 22);
            this.txtBroj.TabIndex = 4;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(189, 321);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(89, 31);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // lblSumirano
            // 
            this.lblSumirano.AutoSize = true;
            this.lblSumirano.Location = new System.Drawing.Point(62, 363);
            this.lblSumirano.Name = "lblSumirano";
            this.lblSumirano.Size = new System.Drawing.Size(0, 17);
            this.lblSumirano.TabIndex = 7;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(605, 321);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(212, 31);
            this.btnPrintaj.TabIndex = 8;
            this.btnPrintaj.Text = "Printaj polozene";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmKorisniciAdminIB190069
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 409);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.lblSumirano);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.checkAdmin);
            this.Controls.Add(this.cbSpol);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmKorisniciAdminIB190069";
            this.Text = "frmKorisniciAdminIB190069";
            this.Load += new System.EventHandler(this.frmKorisniciAdminIB190069_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.ComboBox cbSpol;
        private System.Windows.Forms.CheckBox checkAdmin;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblSumirano;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Administrator;
        private System.Windows.Forms.DataGridViewButtonColumn Slike;
    }
}