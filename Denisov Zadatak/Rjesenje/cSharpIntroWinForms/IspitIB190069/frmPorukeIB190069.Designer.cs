namespace cSharpIntroWinForms.IspitIB190069
{
    partial class frmPorukeIB190069
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
            this.btnNovaPoruka = new System.Windows.Forms.Button();
            this.dgvPoruka = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruka)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Komunikacija Sa:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(193, 29);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 25);
            this.lblStudent.TabIndex = 1;
            // 
            // btnNovaPoruka
            // 
            this.btnNovaPoruka.Location = new System.Drawing.Point(641, 24);
            this.btnNovaPoruka.Name = "btnNovaPoruka";
            this.btnNovaPoruka.Size = new System.Drawing.Size(136, 41);
            this.btnNovaPoruka.TabIndex = 2;
            this.btnNovaPoruka.Text = "Nova Poruka";
            this.btnNovaPoruka.UseVisualStyleBackColor = true;
            this.btnNovaPoruka.Click += new System.EventHandler(this.btnNovaPoruka_Click);
            // 
            // dgvPoruka
            // 
            this.dgvPoruka.AllowUserToAddRows = false;
            this.dgvPoruka.AllowUserToDeleteRows = false;
            this.dgvPoruka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Sadrzaj,
            this.Slika,
            this.Brisi});
            this.dgvPoruka.Location = new System.Drawing.Point(17, 75);
            this.dgvPoruka.Name = "dgvPoruka";
            this.dgvPoruka.ReadOnly = true;
            this.dgvPoruka.RowHeadersWidth = 51;
            this.dgvPoruka.RowTemplate.Height = 24;
            this.dgvPoruka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoruka.Size = new System.Drawing.Size(760, 220);
            this.dgvPoruka.TabIndex = 3;
            this.dgvPoruka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoruka_CellContentClick);
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumVrijeme";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 125;
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.MinimumWidth = 6;
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.MinimumWidth = 6;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Width = 125;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "Brisi";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            this.Brisi.Width = 125;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(641, 312);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(136, 41);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmPorukeIB190069
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvPoruka);
            this.Controls.Add(this.btnNovaPoruka);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmPorukeIB190069";
            this.Text = "frmPorukeIB190069";
            this.Load += new System.EventHandler(this.frmPorukeIB190069_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnNovaPoruka;
        private System.Windows.Forms.DataGridView dgvPoruka;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}