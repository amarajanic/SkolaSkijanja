namespace UI.Forme
{
    partial class frmInstrukcijaDetalji
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
            this.tbImePrezime = new System.Windows.Forms.TextBox();
            this.tbBrojCas = new System.Windows.Forms.TextBox();
            this.tbBrojUcen = new System.Windows.Forms.TextBox();
            this.rtbBiljeske = new System.Windows.Forms.RichTextBox();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.tbVrijeme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvUcenici = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).BeginInit();
            this.SuspendLayout();
            // 
            // tbImePrezime
            // 
            this.tbImePrezime.Location = new System.Drawing.Point(132, 18);
            this.tbImePrezime.Name = "tbImePrezime";
            this.tbImePrezime.ReadOnly = true;
            this.tbImePrezime.Size = new System.Drawing.Size(100, 23);
            this.tbImePrezime.TabIndex = 0;
            // 
            // tbBrojCas
            // 
            this.tbBrojCas.Location = new System.Drawing.Point(132, 176);
            this.tbBrojCas.Name = "tbBrojCas";
            this.tbBrojCas.ReadOnly = true;
            this.tbBrojCas.Size = new System.Drawing.Size(100, 23);
            this.tbBrojCas.TabIndex = 3;
            // 
            // tbBrojUcen
            // 
            this.tbBrojUcen.Location = new System.Drawing.Point(346, 18);
            this.tbBrojUcen.Name = "tbBrojUcen";
            this.tbBrojUcen.ReadOnly = true;
            this.tbBrojUcen.Size = new System.Drawing.Size(100, 23);
            this.tbBrojUcen.TabIndex = 4;
            // 
            // rtbBiljeske
            // 
            this.rtbBiljeske.Location = new System.Drawing.Point(346, 70);
            this.rtbBiljeske.Name = "rtbBiljeske";
            this.rtbBiljeske.ReadOnly = true;
            this.rtbBiljeske.Size = new System.Drawing.Size(240, 129);
            this.rtbBiljeske.TabIndex = 5;
            this.rtbBiljeske.Text = "";
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(132, 67);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.ReadOnly = true;
            this.tbDatum.Size = new System.Drawing.Size(100, 23);
            this.tbDatum.TabIndex = 6;
            // 
            // tbVrijeme
            // 
            this.tbVrijeme.Location = new System.Drawing.Point(132, 120);
            this.tbVrijeme.Name = "tbVrijeme";
            this.tbVrijeme.ReadOnly = true;
            this.tbVrijeme.Size = new System.Drawing.Size(100, 23);
            this.tbVrijeme.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime i prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum održavanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vrijeme održavanja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Broj časova:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Broj učenika:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bilješke:";
            // 
            // dgvUcenici
            // 
            this.dgvUcenici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUcenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenici.Location = new System.Drawing.Point(16, 247);
            this.dgvUcenici.Name = "dgvUcenici";
            this.dgvUcenici.RowTemplate.Height = 25;
            this.dgvUcenici.Size = new System.Drawing.Size(570, 191);
            this.dgvUcenici.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Spisak učenika:";
            // 
            // frmInstrukcijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvUcenici);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVrijeme);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.rtbBiljeske);
            this.Controls.Add(this.tbBrojUcen);
            this.Controls.Add(this.tbBrojCas);
            this.Controls.Add(this.tbImePrezime);
            this.Name = "frmInstrukcijaDetalji";
            this.Text = "frmInstrukcijaDetalji";
            this.Load += new System.EventHandler(this.frmInstrukcijaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbImePrezime;
        private System.Windows.Forms.TextBox tbBrojCas;
        private System.Windows.Forms.TextBox tbBrojUcen;
        private System.Windows.Forms.RichTextBox rtbBiljeske;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.TextBox tbVrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvUcenici;
        private System.Windows.Forms.Label label7;
    }
}