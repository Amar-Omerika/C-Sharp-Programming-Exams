namespace cSharpIntroWinForms.IspitIB190069
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
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv Predmeta";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(141, 24);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(609, 22);
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
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Poruke});
            this.dgvPretraga.Location = new System.Drawing.Point(12, 69);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.ReadOnly = true;
            this.dgvPretraga.RowHeadersWidth = 51;
            this.dgvPretraga.RowTemplate.Height = 24;
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(738, 228);
            this.dgvPretraga.TabIndex = 2;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "Korisnik";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 125;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Width = 185;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 125;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 125;
            // 
            // Poruke
            // 
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.MinimumWidth = 6;
            this.Poruke.Name = "Poruke";
            this.Poruke.ReadOnly = true;
            this.Poruke.Text = "Poruke";
            this.Poruke.UseColumnTextForButtonValue = true;
            this.Poruke.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(192, 315);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(0, 17);
            this.lblProsjek.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSuma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSumiraj);
            this.groupBox1.Controls.Add(this.txtBroj);
            this.groupBox1.Location = new System.Drawing.Point(462, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(15, 39);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(132, 22);
            this.txtBroj.TabIndex = 6;
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(181, 30);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(92, 40);
            this.btnSumiraj.TabIndex = 7;
            this.btnSumiraj.Text = "Sumiraj";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suma:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(66, 88);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(0, 17);
            this.lblSuma.TabIndex = 8;
            // 
            // frmPretragaIB190069
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Poruke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.TextBox txtBroj;
    }
}