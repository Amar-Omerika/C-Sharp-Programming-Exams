namespace cSharpIntroWinForms.IspitIB190069
{
    partial class frmKorisniciPolozeniPredmeti
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
            this.cbPolozeni = new System.Windows.Forms.ComboBox();
            this.cbOcjena = new System.Windows.Forms.ComboBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPolozeni
            // 
            this.cbPolozeni.FormattingEnabled = true;
            this.cbPolozeni.Location = new System.Drawing.Point(12, 25);
            this.cbPolozeni.Name = "cbPolozeni";
            this.cbPolozeni.Size = new System.Drawing.Size(219, 24);
            this.cbPolozeni.TabIndex = 0;
            // 
            // cbOcjena
            // 
            this.cbOcjena.FormattingEnabled = true;
            this.cbOcjena.Location = new System.Drawing.Point(249, 25);
            this.cbOcjena.Name = "cbOcjena";
            this.cbOcjena.Size = new System.Drawing.Size(134, 24);
            this.cbOcjena.TabIndex = 1;
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(403, 27);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 22);
            this.dtPicker.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(636, 25);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(141, 29);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Ucitaj nepolozene";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.AllowUserToAddRows = false;
            this.dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Ocjena,
            this.Datum});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(12, 109);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.ReadOnly = true;
            this.dgvPolozeniPredmeti.RowHeadersWidth = 51;
            this.dgvPolozeniPredmeti.RowTemplate.Height = 24;
            this.dgvPolozeniPredmeti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(765, 213);
            this.dgvPolozeniPredmeti.TabIndex = 5;
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(12, 348);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(141, 29);
            this.btnAsync.TabIndex = 6;
            this.btnAsync.Text = "Run ASYNC";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(636, 348);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(141, 29);
            this.btnPrintaj.TabIndex = 7;
            this.btnPrintaj.Text = "Printaj uvjerenje";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // frmKorisniciPolozeniPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.cbOcjena);
            this.Controls.Add(this.cbPolozeni);
            this.Name = "frmKorisniciPolozeniPredmeti";
            this.Text = "frmKorisniciPolozeniPredmeti";
            this.Load += new System.EventHandler(this.frmKorisniciPolozeniPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPolozeni;
        private System.Windows.Forms.ComboBox cbOcjena;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnPrintaj;
    }
}