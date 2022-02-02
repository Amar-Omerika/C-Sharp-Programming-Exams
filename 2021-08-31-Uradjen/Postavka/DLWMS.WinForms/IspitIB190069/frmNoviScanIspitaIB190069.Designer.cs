namespace DLWMS.WinForms.IspitIB190069
{
    partial class frmNoviScanIspitaIB190069
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.checkboxVaranje = new System.Windows.Forms.CheckBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSpasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(12, 59);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(244, 24);
            this.cmbPredmeti.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Napomena";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(16, 142);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(240, 211);
            this.txtNapomena.TabIndex = 3;
            // 
            // checkboxVaranje
            // 
            this.checkboxVaranje.AutoSize = true;
            this.checkboxVaranje.Location = new System.Drawing.Point(16, 378);
            this.checkboxVaranje.Name = "checkboxVaranje";
            this.checkboxVaranje.Size = new System.Drawing.Size(136, 21);
            this.checkboxVaranje.TabIndex = 4;
            this.checkboxVaranje.Text = "Varanje na ispitu";
            this.checkboxVaranje.UseVisualStyleBackColor = true;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(326, 59);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(287, 294);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 5;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Slika";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(513, 369);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(100, 37);
            this.btnSpasi.TabIndex = 7;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // frmNoviScanIspitaIB190069
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.checkboxVaranje);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviScanIspitaIB190069";
            this.Text = "frmNoviScanIspitaIB190069";
            this.Load += new System.EventHandler(this.frmNoviScanIspitaIB190069_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.CheckBox checkboxVaranje;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}