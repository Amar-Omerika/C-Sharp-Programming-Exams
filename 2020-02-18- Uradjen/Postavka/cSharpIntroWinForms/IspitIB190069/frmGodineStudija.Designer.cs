namespace cSharpIntroWinForms.IspitIB190069
{
    partial class frmGodineStudija
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
            this.components = new System.ComponentModel.Container();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cbAktivna = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dgvGodine = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 31);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(222, 22);
            this.txtNaziv.TabIndex = 0;
            // 
            // cbAktivna
            // 
            this.cbAktivna.AutoSize = true;
            this.cbAktivna.Location = new System.Drawing.Point(261, 31);
            this.cbAktivna.Name = "cbAktivna";
            this.cbAktivna.Size = new System.Drawing.Size(76, 21);
            this.cbAktivna.TabIndex = 1;
            this.cbAktivna.Text = "Aktivna";
            this.cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(356, 24);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(87, 33);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // dgvGodine
            // 
            this.dgvGodine.AllowUserToAddRows = false;
            this.dgvGodine.AllowUserToDeleteRows = false;
            this.dgvGodine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGodine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Aktivna});
            this.dgvGodine.Location = new System.Drawing.Point(12, 82);
            this.dgvGodine.Name = "dgvGodine";
            this.dgvGodine.ReadOnly = true;
            this.dgvGodine.RowHeadersWidth = 51;
            this.dgvGodine.RowTemplate.Height = 24;
            this.dgvGodine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGodine.Size = new System.Drawing.Size(431, 150);
            this.dgvGodine.TabIndex = 3;
            this.dgvGodine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGodine_CellContentClick);
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Aktivna
            // 
            this.Aktivna.DataPropertyName = "Aktivna";
            this.Aktivna.HeaderText = "Aktivna";
            this.Aktivna.MinimumWidth = 6;
            this.Aktivna.Name = "Aktivna";
            this.Aktivna.ReadOnly = true;
            this.Aktivna.Width = 125;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmGodineStudija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 270);
            this.Controls.Add(this.dgvGodine);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbAktivna);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmGodineStudija";
            this.Text = "frmGodineStudija";
            this.Load += new System.EventHandler(this.frmGodineStudija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.CheckBox cbAktivna;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dgvGodine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivna;
        private System.Windows.Forms.ErrorProvider err;
    }
}