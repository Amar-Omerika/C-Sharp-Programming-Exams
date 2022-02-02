namespace DLWMS.WinForms.IspitIB190069
{
    partial class frmPretragaIB190069
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNajStudent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblZnakovi = new System.Windows.Forms.Label();
            this.lblSuglas = new System.Windows.Forms.Label();
            this.lblSuglasnici = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozeniPredmeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(128, 28);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(629, 22);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.AllowUserToAddRows = false;
            this.dgvPretraga.AllowUserToDeleteRows = false;
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.PolozeniPredmeti,
            this.BrojPolozenih,
            this.Prosjek,
            this.Ispiti});
            this.dgvPretraga.Location = new System.Drawing.Point(15, 72);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.ReadOnly = true;
            this.dgvPretraga.RowHeadersWidth = 51;
            this.dgvPretraga.RowTemplate.Height = 24;
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(742, 184);
            this.dgvPretraga.TabIndex = 2;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(192, 279);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(0, 17);
            this.lblProsjek.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Najveci prosjek ostvario:";
            // 
            // lblNajStudent
            // 
            this.lblNajStudent.AutoSize = true;
            this.lblNajStudent.Location = new System.Drawing.Point(544, 279);
            this.lblNajStudent.Name = "lblNajStudent";
            this.lblNajStudent.Size = new System.Drawing.Size(0, 17);
            this.lblNajStudent.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblZnakovi);
            this.groupBox1.Controls.Add(this.lblSuglas);
            this.groupBox1.Controls.Add(this.lblSuglasnici);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSadrzaj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 165);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // lblZnakovi
            // 
            this.lblZnakovi.AutoSize = true;
            this.lblZnakovi.Location = new System.Drawing.Point(180, 137);
            this.lblZnakovi.Name = "lblZnakovi";
            this.lblZnakovi.Size = new System.Drawing.Size(0, 17);
            this.lblZnakovi.TabIndex = 15;
            // 
            // lblSuglas
            // 
            this.lblSuglas.AutoSize = true;
            this.lblSuglas.Location = new System.Drawing.Point(186, 120);
            this.lblSuglas.Name = "lblSuglas";
            this.lblSuglas.Size = new System.Drawing.Size(0, 17);
            this.lblSuglas.TabIndex = 14;
            // 
            // lblSuglasnici
            // 
            this.lblSuglasnici.AutoSize = true;
            this.lblSuglasnici.Location = new System.Drawing.Point(210, 103);
            this.lblSuglasnici.Name = "lblSuglasnici";
            this.lblSuglasnici.Size = new System.Drawing.Size(0, 17);
            this.lblSuglasnici.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Znakova:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Suglasnika:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Samoglasnika:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sadrzaj info:";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(12, 38);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSadrzaj.Size = new System.Drawing.Size(733, 62);
            this.txtSadrzaj.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unesite sadrzaj";
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(639, 487);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(118, 34);
            this.btnGenerisi.TabIndex = 8;
            this.btnGenerisi.Text = "Generisi info";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "Student";
            this.ImePrezime.HeaderText = "Ime i Prezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 125;
            // 
            // PolozeniPredmeti
            // 
            this.PolozeniPredmeti.DataPropertyName = "PolozeniPredmeti";
            this.PolozeniPredmeti.HeaderText = "Polozeni predmet";
            this.PolozeniPredmeti.MinimumWidth = 6;
            this.PolozeniPredmeti.Name = "PolozeniPredmeti";
            this.PolozeniPredmeti.ReadOnly = true;
            this.PolozeniPredmeti.Width = 189;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.DataPropertyName = "BrojPolozenih";
            this.BrojPolozenih.HeaderText = "Broj polozenoj";
            this.BrojPolozenih.MinimumWidth = 6;
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.ReadOnly = true;
            this.BrojPolozenih.Width = 125;
            // 
            // Prosjek
            // 
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.MinimumWidth = 6;
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            this.Prosjek.Width = 125;
            // 
            // Ispiti
            // 
            this.Ispiti.HeaderText = "";
            this.Ispiti.MinimumWidth = 6;
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.ReadOnly = true;
            this.Ispiti.Text = "Ispit";
            this.Ispiti.UseColumnTextForButtonValue = true;
            this.Ispiti.Width = 125;
            // 
            // frmPretragaIB190069
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNajStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB190069";
            this.Text = "frmPretragaIB190069";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNajStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblZnakovi;
        private System.Windows.Forms.Label lblSuglas;
        private System.Windows.Forms.Label lblSuglasnici;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
    }
}