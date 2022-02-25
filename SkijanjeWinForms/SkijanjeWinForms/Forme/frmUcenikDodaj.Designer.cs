namespace UI.Forme
{
    partial class frmUcenikDodaj
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
            this.lblTel = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lblSpol = new System.Windows.Forms.Label();
            this.lblDatumRodj = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.dtpDatRodj = new System.Windows.Forms.DateTimePicker();
            this.cbSpol = new System.Windows.Forms.ComboBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.epIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDatumRodj = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSpol = new System.Windows.Forms.ErrorProvider(this.components);
            this.epKontaktTel = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDatumRodj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSpol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKontaktTel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(265, 67);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(91, 15);
            this.lblTel.TabIndex = 38;
            this.lblTel.Text = "Kontakt telefon:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(369, 64);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(138, 23);
            this.tbTelefon.TabIndex = 37;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            // 
            // lblSpol
            // 
            this.lblSpol.AutoSize = true;
            this.lblSpol.Location = new System.Drawing.Point(265, 15);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(33, 15);
            this.lblSpol.TabIndex = 30;
            this.lblSpol.Text = "Spol:";
            // 
            // lblDatumRodj
            // 
            this.lblDatumRodj.AutoSize = true;
            this.lblDatumRodj.Location = new System.Drawing.Point(9, 111);
            this.lblDatumRodj.Name = "lblDatumRodj";
            this.lblDatumRodj.Size = new System.Drawing.Size(89, 15);
            this.lblDatumRodj.TabIndex = 29;
            this.lblDatumRodj.Text = "Datum rođenja:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(9, 62);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(52, 15);
            this.lblPrezime.TabIndex = 28;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(9, 15);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 15);
            this.lblIme.TabIndex = 27;
            this.lblIme.Text = "Ime:";
            // 
            // dtpDatRodj
            // 
            this.dtpDatRodj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatRodj.Location = new System.Drawing.Point(113, 105);
            this.dtpDatRodj.Name = "dtpDatRodj";
            this.dtpDatRodj.Size = new System.Drawing.Size(138, 23);
            this.dtpDatRodj.TabIndex = 25;
            this.dtpDatRodj.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatRodj_Validating);
            // 
            // cbSpol
            // 
            this.cbSpol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpol.FormattingEnabled = true;
            this.cbSpol.Location = new System.Drawing.Point(369, 12);
            this.cbSpol.Name = "cbSpol";
            this.cbSpol.Size = new System.Drawing.Size(138, 23);
            this.cbSpol.TabIndex = 24;
            this.cbSpol.Validating += new System.ComponentModel.CancelEventHandler(this.cbSpol_Validating);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(113, 59);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(138, 23);
            this.tbPrezime.TabIndex = 23;
            this.tbPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrezime_Validating);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(113, 12);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(138, 23);
            this.tbIme.TabIndex = 22;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(342, 111);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 40;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(432, 111);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 39;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // epIme
            // 
            this.epIme.ContainerControl = this;
            // 
            // epPrezime
            // 
            this.epPrezime.ContainerControl = this;
            // 
            // epDatumRodj
            // 
            this.epDatumRodj.ContainerControl = this;
            // 
            // epSpol
            // 
            this.epSpol.ContainerControl = this;
            // 
            // epKontaktTel
            // 
            this.epKontaktTel.ContainerControl = this;
            // 
            // frmUcenikDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 144);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.lblSpol);
            this.Controls.Add(this.lblDatumRodj);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.dtpDatRodj);
            this.Controls.Add(this.cbSpol);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUcenikDodaj";
            this.Text = "frmUcenikDodaj";
            this.Load += new System.EventHandler(this.frmUcenikDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDatumRodj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSpol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKontaktTel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lblSpol;
        private System.Windows.Forms.Label lblDatumRodj;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.DateTimePicker dtpDatRodj;
        private System.Windows.Forms.ComboBox cbSpol;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.ErrorProvider epIme;
        private System.Windows.Forms.ErrorProvider epPrezime;
        private System.Windows.Forms.ErrorProvider epDatumRodj;
        private System.Windows.Forms.ErrorProvider epSpol;
        private System.Windows.Forms.ErrorProvider epKontaktTel;
    }
}