namespace UI.Forme
{
    partial class frmInstruktor
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.cbSpol = new System.Windows.Forms.ComboBox();
            this.dtpDatRodj = new System.Windows.Forms.DateTimePicker();
            this.dtpIskustvo = new System.Windows.Forms.DateTimePicker();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatumRodj = new System.Windows.Forms.Label();
            this.lblSpol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBiografija = new System.Windows.Forms.Label();
            this.rtbBiografija = new System.Windows.Forms.RichTextBox();
            this.lblCv = new System.Windows.Forms.Label();
            this.btnCvUpload = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.epIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDatumRodj = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSpol = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIskustvo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCV = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBiografija = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDatumRodj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSpol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIskustvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBiografija)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(116, 24);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(138, 23);
            this.tbIme.TabIndex = 0;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(116, 71);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(138, 23);
            this.tbPrezime.TabIndex = 2;
            this.tbPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrezime_Validating);
            // 
            // cbSpol
            // 
            this.cbSpol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpol.FormattingEnabled = true;
            this.cbSpol.Location = new System.Drawing.Point(116, 163);
            this.cbSpol.Name = "cbSpol";
            this.cbSpol.Size = new System.Drawing.Size(138, 23);
            this.cbSpol.TabIndex = 3;
            this.cbSpol.Validating += new System.ComponentModel.CancelEventHandler(this.cbSpol_Validating);
            // 
            // dtpDatRodj
            // 
            this.dtpDatRodj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatRodj.Location = new System.Drawing.Point(116, 117);
            this.dtpDatRodj.Name = "dtpDatRodj";
            this.dtpDatRodj.Size = new System.Drawing.Size(138, 23);
            this.dtpDatRodj.TabIndex = 4;
            this.dtpDatRodj.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatRodj_Validating);
            // 
            // dtpIskustvo
            // 
            this.dtpIskustvo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIskustvo.Location = new System.Drawing.Point(383, 24);
            this.dtpIskustvo.Name = "dtpIskustvo";
            this.dtpIskustvo.Size = new System.Drawing.Size(165, 23);
            this.dtpIskustvo.TabIndex = 6;
            this.dtpIskustvo.Validating += new System.ComponentModel.CancelEventHandler(this.dtpIskustvo_Validating);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 27);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 15);
            this.lblIme.TabIndex = 7;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 74);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(52, 15);
            this.lblPrezime.TabIndex = 8;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblDatumRodj
            // 
            this.lblDatumRodj.AutoSize = true;
            this.lblDatumRodj.Location = new System.Drawing.Point(12, 123);
            this.lblDatumRodj.Name = "lblDatumRodj";
            this.lblDatumRodj.Size = new System.Drawing.Size(89, 15);
            this.lblDatumRodj.TabIndex = 9;
            this.lblDatumRodj.Text = "Datum rođenja:";
            // 
            // lblSpol
            // 
            this.lblSpol.AutoSize = true;
            this.lblSpol.Location = new System.Drawing.Point(12, 166);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(33, 15);
            this.lblSpol.TabIndex = 10;
            this.lblSpol.Text = "Spol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Skijaško iskustvo:";
            // 
            // lblBiografija
            // 
            this.lblBiografija.AutoSize = true;
            this.lblBiografija.Location = new System.Drawing.Point(279, 123);
            this.lblBiografija.Name = "lblBiografija";
            this.lblBiografija.Size = new System.Drawing.Size(60, 15);
            this.lblBiografija.TabIndex = 13;
            this.lblBiografija.Text = "Biografija:";
            // 
            // rtbBiografija
            // 
            this.rtbBiografija.Location = new System.Drawing.Point(383, 120);
            this.rtbBiografija.Name = "rtbBiografija";
            this.rtbBiografija.Size = new System.Drawing.Size(165, 88);
            this.rtbBiografija.TabIndex = 14;
            this.rtbBiografija.Text = "";
            this.rtbBiografija.Validating += new System.ComponentModel.CancelEventHandler(this.rtbBiografija_Validating);
            // 
            // lblCv
            // 
            this.lblCv.AutoSize = true;
            this.lblCv.Location = new System.Drawing.Point(279, 74);
            this.lblCv.Name = "lblCv";
            this.lblCv.Size = new System.Drawing.Size(25, 15);
            this.lblCv.TabIndex = 15;
            this.lblCv.Text = "CV:";
            // 
            // btnCvUpload
            // 
            this.btnCvUpload.Location = new System.Drawing.Point(523, 71);
            this.btnCvUpload.Name = "btnCvUpload";
            this.btnCvUpload.Size = new System.Drawing.Size(25, 23);
            this.btnCvUpload.TabIndex = 16;
            this.btnCvUpload.Text = "...";
            this.btnCvUpload.UseVisualStyleBackColor = true;
            this.btnCvUpload.Click += new System.EventHandler(this.btnCvUpload_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(383, 71);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(124, 23);
            this.tbFileName.TabIndex = 17;
            this.tbFileName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFileName_Validating);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(12, 218);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(91, 15);
            this.lblTel.TabIndex = 19;
            this.lblTel.Text = "Kontakt telefon:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(116, 215);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(138, 23);
            this.tbTelefon.TabIndex = 18;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(473, 218);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 20;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(383, 218);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 21;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
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
            // epTelefon
            // 
            this.epTelefon.ContainerControl = this;
            // 
            // epIskustvo
            // 
            this.epIskustvo.ContainerControl = this;
            // 
            // epCV
            // 
            this.epCV.ContainerControl = this;
            // 
            // epBiografija
            // 
            this.epBiografija.ContainerControl = this;
            // 
            // frmInstruktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 259);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.btnCvUpload);
            this.Controls.Add(this.lblCv);
            this.Controls.Add(this.rtbBiografija);
            this.Controls.Add(this.lblBiografija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSpol);
            this.Controls.Add(this.lblDatumRodj);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.dtpIskustvo);
            this.Controls.Add(this.dtpDatRodj);
            this.Controls.Add(this.cbSpol);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInstruktor";
            this.Text = "frmInstruktor";
            this.Load += new System.EventHandler(this.frmInstruktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDatumRodj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSpol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIskustvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBiografija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.ComboBox cbSpol;
        private System.Windows.Forms.DateTimePicker dtpDatRodj;
        private System.Windows.Forms.DateTimePicker dtpIskustvo;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatumRodj;
        private System.Windows.Forms.Label lblSpol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBiografija;
        private System.Windows.Forms.RichTextBox rtbBiografija;
        private System.Windows.Forms.Label lblCv;
        private System.Windows.Forms.Button btnCvUpload;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.ErrorProvider epIme;
        private System.Windows.Forms.ErrorProvider epPrezime;
        private System.Windows.Forms.ErrorProvider epDatumRodj;
        private System.Windows.Forms.ErrorProvider epSpol;
        private System.Windows.Forms.ErrorProvider epTelefon;
        private System.Windows.Forms.ErrorProvider epIskustvo;
        private System.Windows.Forms.ErrorProvider epCV;
        private System.Windows.Forms.ErrorProvider epBiografija;
    }
}