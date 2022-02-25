namespace cSharpIntroWinForms.IspitIB190069
{
    partial class frmGlavna
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
            this.btnGodineStudija = new System.Windows.Forms.Button();
            this.btnPolozeniPredmeti = new System.Windows.Forms.Button();
            this.btnIzracunajSumu = new System.Windows.Forms.Button();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGodineStudija
            // 
            this.btnGodineStudija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGodineStudija.Location = new System.Drawing.Point(12, 77);
            this.btnGodineStudija.Name = "btnGodineStudija";
            this.btnGodineStudija.Size = new System.Drawing.Size(186, 117);
            this.btnGodineStudija.TabIndex = 0;
            this.btnGodineStudija.Text = "Godine Studija";
            this.btnGodineStudija.UseVisualStyleBackColor = true;
            this.btnGodineStudija.Click += new System.EventHandler(this.btnGodineStudija_Click);
            // 
            // btnPolozeniPredmeti
            // 
            this.btnPolozeniPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolozeniPredmeti.Location = new System.Drawing.Point(246, 77);
            this.btnPolozeniPredmeti.Name = "btnPolozeniPredmeti";
            this.btnPolozeniPredmeti.Size = new System.Drawing.Size(186, 117);
            this.btnPolozeniPredmeti.TabIndex = 1;
            this.btnPolozeniPredmeti.Text = "Polozeni Predmeti";
            this.btnPolozeniPredmeti.UseVisualStyleBackColor = true;
            this.btnPolozeniPredmeti.Click += new System.EventHandler(this.btnPolozeniPredmeti_Click);
            // 
            // btnIzracunajSumu
            // 
            this.btnIzracunajSumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzracunajSumu.Location = new System.Drawing.Point(479, 118);
            this.btnIzracunajSumu.Name = "btnIzracunajSumu";
            this.btnIzracunajSumu.Size = new System.Drawing.Size(186, 76);
            this.btnIzracunajSumu.TabIndex = 2;
            this.btnIzracunajSumu.Text = "Izracunaj Sumu";
            this.btnIzracunajSumu.UseVisualStyleBackColor = true;
            this.btnIzracunajSumu.Click += new System.EventHandler(this.btnIzracunajSumu_Click);
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(479, 77);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(186, 22);
            this.txtBroj.TabIndex = 3;
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 287);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.btnIzracunajSumu);
            this.Controls.Add(this.btnPolozeniPredmeti);
            this.Controls.Add(this.btnGodineStudija);
            this.Name = "frmGlavna";
            this.Text = "frmGlavna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGodineStudija;
        private System.Windows.Forms.Button btnPolozeniPredmeti;
        private System.Windows.Forms.Button btnIzracunajSumu;
        private System.Windows.Forms.TextBox txtBroj;
    }
}