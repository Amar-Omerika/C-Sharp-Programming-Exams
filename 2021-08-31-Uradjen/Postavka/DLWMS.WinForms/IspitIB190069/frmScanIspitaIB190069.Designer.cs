namespace DLWMS.WinForms.IspitIB190069
{
    partial class frmScanIspitaIB190069
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnDodajScan = new System.Windows.Forms.Button();
            this.dgvKorisniciIspit = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Scan = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciIspit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled ispita za studenta:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(226, 23);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 25);
            this.lblStudent.TabIndex = 1;
            // 
            // btnDodajScan
            // 
            this.btnDodajScan.Location = new System.Drawing.Point(620, 23);
            this.btnDodajScan.Name = "btnDodajScan";
            this.btnDodajScan.Size = new System.Drawing.Size(159, 35);
            this.btnDodajScan.TabIndex = 2;
            this.btnDodajScan.Text = "Dodaj scan ispita";
            this.btnDodajScan.UseVisualStyleBackColor = true;
            this.btnDodajScan.Click += new System.EventHandler(this.btnDodajScan_Click);
            // 
            // dgvKorisniciIspit
            // 
            this.dgvKorisniciIspit.AllowUserToAddRows = false;
            this.dgvKorisniciIspit.AllowUserToDeleteRows = false;
            this.dgvKorisniciIspit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisniciIspit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.Scan,
            this.Brisi});
            this.dgvKorisniciIspit.Location = new System.Drawing.Point(12, 85);
            this.dgvKorisniciIspit.Name = "dgvKorisniciIspit";
            this.dgvKorisniciIspit.ReadOnly = true;
            this.dgvKorisniciIspit.RowHeadersWidth = 51;
            this.dgvKorisniciIspit.RowTemplate.Height = 24;
            this.dgvKorisniciIspit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisniciIspit.Size = new System.Drawing.Size(767, 229);
            this.dgvKorisniciIspit.TabIndex = 3;
            this.dgvKorisniciIspit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisniciIspit_CellContentClick);
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Width = 125;
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            this.Napomena.Width = 214;
            // 
            // Varanje
            // 
            this.Varanje.DataPropertyName = "Varanje";
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.MinimumWidth = 6;
            this.Varanje.Name = "Varanje";
            this.Varanje.ReadOnly = true;
            this.Varanje.Width = 125;
            // 
            // Scan
            // 
            this.Scan.DataPropertyName = "Slika";
            this.Scan.HeaderText = "Scan ispita";
            this.Scan.MinimumWidth = 6;
            this.Scan.Name = "Scan";
            this.Scan.ReadOnly = true;
            this.Scan.Width = 125;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            this.Brisi.Width = 125;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(620, 343);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(159, 35);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmScanIspitaIB190069
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvKorisniciIspit);
            this.Controls.Add(this.btnDodajScan);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmScanIspitaIB190069";
            this.Text = "frmScanIspitaIB190069";
            this.Load += new System.EventHandler(this.frmScanIspitaIB190069_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciIspit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnDodajScan;
        private System.Windows.Forms.DataGridView dgvKorisniciIspit;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewImageColumn Scan;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}